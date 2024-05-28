using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using login.Datos;
using System.Net.NetworkInformation;
using System.Data;
using login.Entidades;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace login
{
    public partial class SalidaInvenario : Form
    {
        private ListaProductos listaProductosForm;
        public SalidaInvenario()
        {
            InitializeComponent();
            ConfigurarColumnasDataGridView();
            EstablecerFechaActual();
            textCosto.Text = "0.00";
            CargarDatos.CargarUltimoIDInventario(textNoDoc, ConexionBD.Conex);
            buttInsertar.Enabled = false;
            buttBuscar.Enabled = true;
            buttNuevo.Enabled = true;
            buttEliminar.Enabled = false;
            buttImprimir.Enabled = false;
            buttBuscar.EnabledChanged += Button_EnabledChanged;
            buttInsertar.EnabledChanged += Button_EnabledChanged;
            buttNuevo.EnabledChanged += Button_EnabledChanged;
            buttEliminar.EnabledChanged += Button_EnabledChanged;
            buttImprimir.EnabledChanged += Button_EnabledChanged;

            ApplyInitialButtonColors();
        }

        private void SalidaInvenario_Load(object sender, EventArgs e)
        {

            try
            {
                if (ConexionBD.Conex.State != System.Data.ConnectionState.Open)
                {
                    ConexionBD.Conex.Open();
                }

                string query = "SELECT MAX(NO_DOCUMENTO) AS ULTIMO_ID FROM INVENTARIO";
                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    object resultado = command.ExecuteScalar();

                    if (resultado != DBNull.Value && resultado != null)
                    {
                        int ultimoID = Convert.ToInt32(resultado) + 1;
                        textNoDoc.Text = ultimoID.ToString();
                    }
                    else
                    {
                        textNoDoc.Text = "1";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el último ID de inventario: {ex.Message}");
            }
        }


        // Método que maneja el evento CodigoSeleccionado del formulario ListaProductos
        private void ListaProductosForm_CodigoSeleccionado(string codigo)
        {
            // Asignar el código seleccionado al textbox en SalidaInventario
            textCodigo.Text = codigo;
        }

        private void ConfigurarColumnasDataGridView()
        {
            //Limpia el dataGridView antes de agregar columnas.
            dataGridView1.Columns.Clear();

            // Agrega encabezados de las columnas.
            dataGridView1.Columns.Add("Columna1", "Codigo");
            dataGridView1.Columns.Add("Columna2", "Descripcion");
            dataGridView1.Columns.Add("Columna3", "Cantidad");
            dataGridView1.Columns.Add("Columna4", "Costo Unitario");
            dataGridView1.Columns.Add("Columna5", "Costo Total");

            // Configura las columnas para que se ajusten y ocupen el espacio disponible.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }


        private void EstablecerFechaActual()
        {
            // Establece la fecha actual en el TextBox textFecha
            textFecha.Text = DateTime.Now.ToString("dd/MM/yy");

        }


        private void textCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter no es un dígito y tampoco es una tecla de control (como retroceso).
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Maneja el evento, impidiendo que el carácter se escriba en el TextBox.
            }
        }

        // Método para validar el valor ingresado en el campo Cantidad
        private bool ValidarCantidad()
        {
            // Verifica si el campo no está vacío y si el número es mayor a cero
            if (string.IsNullOrEmpty(textCantidad.Text) || int.Parse(textCantidad.Text) <= 0)
            {
                MessageBox.Show("Favor de ingresar una cantidad mayor a cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verifica si la cantidad es menor o igual a la existencia
            int cantidad = int.Parse(textCantidad.Text);
            int existencia = int.Parse(textExistencia.Text);

            if (cantidad > existencia)
            {
                MessageBox.Show("No hay suficientes existencias.", "Existencias Insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void buttBuscar_Click(object sender, EventArgs e)
        {
            CargarDatosProducto();
        }

        private void CargarDatosProducto()
        {
            // Verificar si el campo de búsqueda está vacío
            if (string.IsNullOrWhiteSpace(textCodigo.Text))
            {
                MessageBox.Show("Por favor, ingrese el código de producto.");
                return;
            }

            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            string codigo = textCodigo.Text;

            try
            {
                // Consultar la información del producto en la tabla PRODUCTOS
                string queryProductos = "SELECT NOMBRE, PRESENTACION, PRECIO FROM PRODUCTOS WHERE COD_PRODUCTO = :codigo";
                using (OracleCommand productosCommand = new OracleCommand(queryProductos, ConexionBD.Conex))
                {
                    productosCommand.Parameters.Add(new OracleParameter("codigo", codigo));
                    using (OracleDataReader productosReader = productosCommand.ExecuteReader())
                    {
                        if (productosReader.Read())
                        {
                            string nombre = productosReader["NOMBRE"].ToString();
                            string presentacion = productosReader["PRESENTACION"].ToString();
                            decimal precio = Convert.ToDecimal(productosReader["PRECIO"]);

                            // Mostrar nombre y presentación en textDescripcion
                            textDescripcion.Text = $"{nombre} {presentacion}";

                            // Asignar el precio al campo textCosto
                            textCosto.Text = precio.ToString();
                            buttInsertar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("El código de producto no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Salir del método si no se encuentra el producto en la tabla PRODUCTOS
                        }
                    }
                }

                // Consultar la existencia del producto en la tabla DETALLE_INVENTARIO
                string queryDetalle = "SELECT SUM(INGRESO) AS TOTAL_INGRESO, SUM(EGRESO) AS TOTAL_EGRESO FROM DETALLE_INVENTARIO WHERE COD_PRODUCTO = :codigo GROUP BY COSTO";
                using (OracleCommand command = new OracleCommand(queryDetalle, ConexionBD.Conex))
                {
                    command.Parameters.Add(new OracleParameter("codigo", codigo));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal totalIngreso = Convert.ToDecimal(reader["TOTAL_INGRESO"]);
                            decimal totalEgreso = Convert.ToDecimal(reader["TOTAL_EGRESO"]);
                            decimal existencia = totalIngreso - totalEgreso;

                            textExistencia.Text = existencia.ToString();

                            textCodigo.Enabled = false;
                            textUsuario.Enabled = false;
                            buttInsertar.Enabled = true;
                        }
                        else
                        {
                            // Si no hay registros en DETALLE_INVENTARIO, se establece existencia como 0
                            textExistencia.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el producto: {ex.Message}");
            }
        }

        private void textCantidad_TextChanged(object sender, EventArgs e)
        {
            decimal cantidad = 0;

            if (!string.IsNullOrEmpty(textCantidad.Text))
            {
                cantidad = decimal.Parse(textCantidad.Text);
            }

            // Obtener el valor de textCosto (asumiendo que ya ha sido validado)
            decimal costo = decimal.Parse(textCosto.Text);

            // Calcular el subtotal multiplicando la cantidad por el costo
            decimal subtotal = cantidad * costo;

            // Formatear el subtotal con el prefijo "Q. " y alineado a la derecha
            textSubTotal.Text = string.Format("Q. {0,10}", subtotal.ToString("#,##0.00"));
        }

        private void LimpiarTextBoxes()
        {
            textCodigo.Enabled = true;
            textCodigo.Text = "";
            textDescripcion.Text = "";
            textExistencia.Text = "";
            textCantidad.Text = "";
            textSubTotal.Text = "";
        }

        private void SumarColumnas()
        {
            decimal sumaCantidad = 0;
            decimal sumaTotal = 0;

            // Iterar a través de las filas del DataGridView, excluyendo la última fila
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow fila = dataGridView1.Rows[i];

                // Verificar si la celda en la tercera columna es convertible a decimal
                if (decimal.TryParse(fila.Cells[2].Value?.ToString(), out decimal cantidad))
                {
                    // Sumar el valor de la tercera columna
                    sumaCantidad += cantidad;

                    // Obtener el valor de la quinta columna como cadena
                    string textoSubtotal = fila.Cells[4].Value?.ToString();

                    if (!string.IsNullOrEmpty(textoSubtotal))
                    {
                        // Eliminar el prefijo "Q. " si existe
                        textoSubtotal = textoSubtotal.Replace("Q. ", "");

                        // Convertir el valor restante a decimal
                        if (decimal.TryParse(textoSubtotal, out decimal subtotal))
                        {
                            // Sumar el valor de la quinta columna
                            sumaTotal += subtotal;
                        }
                        else
                        {
                            // Manejar el error de conversión
                            MessageBox.Show($"Error de conversión en la fila {i + 1}: Valor no válido '{textoSubtotal}'", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            // Asignar la suma de la tercera columna a textCantidad2
            textCantidad2.Text = sumaCantidad.ToString();

            // Formatear el valor de sumaTotal con el prefijo "Q. " y alineado a la derecha
            textTotal.Text = string.Format("Q. {0,10}", sumaTotal.ToString("#,##0.00"));
        }

        private void buttGuardar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox && control != textFecha && control != textNoDoc)
                {
                    ((TextBox)control).Text = "";

                    textCosto.Text = "0.00";
                    buttInsertar.Enabled = false;
                    buttBuscar.Enabled = true;
                    buttNuevo.Enabled = true;
                    buttEliminar.Enabled = false;
                    buttImprimir.Enabled = false;
                }
            }

            // Limpiar el DataGridView
            dataGridView1.Rows.Clear();
        }

        public void SetTextCodigo(string codigo)
        {
            textCodigo.Text = codigo;
        }
        public void InsertarDatos()
        {
            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            int usuario = EnviarUsuario.GetUsuario();
            string empCodigo = usuario.ToString();

            // Iniciar una transacción
            OracleTransaction transaction = ConexionBD.Conex.BeginTransaction();

            try
            {
                string tipoDocumento = "SI";
                string fecha = textFecha.Text;
                string noDocumento = textNoDoc.Text;

                string queryInsertarInventario = "INSERT INTO INVENTARIO (NO_DOCUMENTO, TIPO_DOCUMENTO, FECHA) VALUES (:noDocumento, :tipoDocumento, TO_DATE(:fecha, 'DD/MM/YY'))";
                using (OracleCommand command = new OracleCommand(queryInsertarInventario, ConexionBD.Conex))
                {
                    command.Parameters.Add(new OracleParameter("noDocumento", noDocumento));
                    command.Parameters.Add(new OracleParameter("tipoDocumento", tipoDocumento));
                    command.Parameters.Add(new OracleParameter("fecha", fecha));
                    command.ExecuteNonQuery();
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Verificar si la fila es la última fila vacía
                    if (row.IsNewRow)
                        continue; // Saltar la iteración si es la última fila vacía

                    string codProducto = row.Cells["Columna1"].Value.ToString();
                    string descripcion = row.Cells["Columna2"].Value.ToString();
                    decimal egreso = Math.Truncate(Convert.ToDecimal(row.Cells["Columna3"].Value));
                    decimal costo = Math.Truncate(Convert.ToDecimal(row.Cells["Columna4"].Value));
                    decimal subtotal = Math.Truncate(Convert.ToDecimal(row.Cells["Columna5"].Value.ToString().Replace("Q. ", "")));


                    string queryInsertarDetalle = "INSERT INTO DETALLE_INVENTARIO (COD_PRODUCTO, DESCRIPCION, COSTO, INGRESO, EGRESO, SUBTOTAL, EMP_CODIGO, OBSERVACION, NO_DOCUMENTO, TIPO_DOCUMENTO, LINEA) VALUES (:codProducto, :descripcion, :costo, 0, :egreso, :subtotal, :empCodigo, :observacion, :noDocumento, 'SI', :linea)";
                    using (OracleCommand detalleCommand = new OracleCommand(queryInsertarDetalle, ConexionBD.Conex))
                    {
                        detalleCommand.Parameters.Add(new OracleParameter("codProducto", codProducto));
                        detalleCommand.Parameters.Add(new OracleParameter("descripcion", descripcion));
                        detalleCommand.Parameters.Add(new OracleParameter("costo", costo));
                        detalleCommand.Parameters.Add(new OracleParameter("egreso", egreso));
                        detalleCommand.Parameters.Add(new OracleParameter("subtotal", subtotal));
                        detalleCommand.Parameters.Add(new OracleParameter("empCodigo", empCodigo));
                        detalleCommand.Parameters.Add(new OracleParameter("observacion", textObservacion.Text));
                        detalleCommand.Parameters.Add(new OracleParameter("noDocumento", noDocumento));
                        detalleCommand.Parameters.Add(new OracleParameter("linea", row.Index + 1));
                        detalleCommand.ExecuteNonQuery();
                    }
                }

                // Commit de la transacción si todo se ejecutó correctamente
                transaction.Commit();
                MessageBox.Show("Datos insertados correctamente en la base de datos.");
                CargarDatos.CargarUltimoIDInventario(textNoDoc, ConexionBD.Conex);
            }
            catch (Exception ex)
            {
                // Rollback de la transacción en caso de error
                transaction.Rollback();
                MessageBox.Show($"Error al insertar datos en la base de datos: {ex.Message}");
            }
        }

        private bool ValidarUsuario(string empCodigo)
        {
            string query = "SELECT COUNT(*) FROM USUARIOS WHERE EMP_CODIGO = :empCodigo";
            using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
            {
                command.Parameters.Add(new OracleParameter("empCodigo", empCodigo));
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        private void BuscarParaEliminar(string noDocumento)
        {
            // Verificar si el número de documento está vacío
            if (string.IsNullOrWhiteSpace(noDocumento))
            {
                MessageBox.Show("El número de documento está vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prepara la consulta SQL para buscar en la tabla DETALLE_INVENTARIO
            string queryDetalle = "SELECT COD_PRODUCTO, DESCRIPCION, EGRESO, COSTO, SUBTOTAL FROM DETALLE_INVENTARIO WHERE NO_DOCUMENTO = :noDocumento";

            // Prepara la consulta SQL para obtener la observación de la tabla DETALLE_INVENTARIO
            string queryObservacion = "SELECT OBSERVACION FROM DETALLE_INVENTARIO WHERE NO_DOCUMENTO = :noDocumento AND ROWNUM = 1";

            // Prepara la consulta SQL para obtener la fecha de la tabla INVENTARIO
            string queryFecha = "SELECT FECHA FROM INVENTARIO WHERE NO_DOCUMENTO = :noDocumento";

            // Verifica si la conexión está abierta
            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            string queryExisteDocumento = "SELECT COUNT(1) FROM INVENTARIO WHERE NO_DOCUMENTO = :noDocumento";

            try
            {
                using (OracleCommand commandVerificar = new OracleCommand(queryExisteDocumento, ConexionBD.Conex))
                {
                    commandVerificar.Parameters.Add(new OracleParameter("noDocumento", noDocumento));

                    // Ejecutar la consulta y verificar el resultado
                    int count = Convert.ToInt32(commandVerificar.ExecuteScalar());
                    if (count == 0)
                    {
                        MessageBox.Show("El número de documento no existe en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textUsuario.Text = "";
                        return;
                    }
                    else
                    {
                        // Si el documento existe, verificamos el tipo de documento
                        string queryVerificarTipoDocumento = "SELECT TIPO_DOCUMENTO FROM INVENTARIO WHERE NO_DOCUMENTO = :noDocumento";
                        using (OracleCommand commandTipoDocumento = new OracleCommand(queryVerificarTipoDocumento, ConexionBD.Conex))
                        {
                            commandTipoDocumento.Parameters.Add(new OracleParameter("noDocumento", noDocumento));

                            string tipoDocumento = commandTipoDocumento.ExecuteScalar().ToString();
                            if (tipoDocumento != "SI")
                            {
                                MessageBox.Show("El tipo de documento no es válido.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }
                }

                using (OracleCommand commandDetalle = new OracleCommand(queryDetalle, ConexionBD.Conex))
                {
                    commandDetalle.Parameters.Add(new OracleParameter("noDocumento", noDocumento));
                    using (OracleDataReader readerDetalle = commandDetalle.ExecuteReader())
                    {
                        // Limpiar las filas existentes del DataGridView
                        dataGridView1.Rows.Clear();

                        // Iterar sobre los resultados y agregarlos al DataGridView
                        while (readerDetalle.Read())
                        {
                            object[] rowData = new object[5]; // 5 columnas
                            rowData[0] = readerDetalle["COD_PRODUCTO"];
                            rowData[1] = readerDetalle["DESCRIPCION"];
                            rowData[2] = readerDetalle["EGRESO"];
                            rowData[3] = readerDetalle["COSTO"];
                            rowData[4] = readerDetalle["SUBTOTAL"];
                            dataGridView1.Rows.Add(rowData);
                        }
                    }
                }

                // Obtener la observación de DETALLE_INVENTARIO
                using (OracleCommand commandObservacion = new OracleCommand(queryObservacion, ConexionBD.Conex))
                {
                    commandObservacion.Parameters.Add(new OracleParameter("noDocumento", noDocumento));
                    object observacion = commandObservacion.ExecuteScalar();
                    if (observacion != null)
                    {
                        textObservacion.Text = observacion.ToString();
                    }
                }

                // Obtener la fecha de INVENTARIO
                using (OracleCommand commandFecha = new OracleCommand(queryFecha, ConexionBD.Conex))
                {
                    commandFecha.Parameters.Add(new OracleParameter("noDocumento", noDocumento));
                    object fecha = commandFecha.ExecuteScalar();
                    if (fecha != null && fecha is DateTime)
                    {
                        DateTime fechaDateTime = (DateTime)fecha;
                        textFecha.Text = fechaDateTime.ToString("yyyy-MM-dd"); // Formatear solo la fecha
                    }
                }
                buttBuscar.Enabled = false;
                buttInsertar.Enabled = false;
                buttNuevo.Enabled = false;
                buttEliminar.Enabled = true;
                buttImprimir.Enabled = true;
                textCodigo.Enabled = false;
                textUsuario.Enabled = false;

                SumarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EliminarRegistro(string noDocumento)
        {
            // Prepara la consulta SQL para eliminar los datos
            string queryInventario = "DELETE FROM INVENTARIO WHERE NO_DOCUMENTO = :noDocumento";
            string queryDetalle = "DELETE FROM DETALLE_INVENTARIO WHERE NO_DOCUMENTO = :noDocumento";

            // Verifica si la conexión está abierta
            if (ConexionBD.Conex.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            // Iniciar una transacción
            OracleTransaction transaction = ConexionBD.Conex.BeginTransaction();

            try
            {

                // Eliminar los registros de la tabla DETALLE_INVENTARIO asociados al NO_DOCUMENTO
                using (OracleCommand commandDetalle = new OracleCommand(queryDetalle, ConexionBD.Conex))
                {
                    // Añade el parámetro para prevenir inyección SQL
                    commandDetalle.Parameters.Add(new OracleParameter("noDocumento", noDocumento));

                    // Ejecuta la consulta
                    int resultDetalle = commandDetalle.ExecuteNonQuery();

                    if (resultDetalle > 0)
                    {
                        //MessageBox.Show("Registros de detalle de inventario eliminados correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros de detalle de inventario para eliminar. Verifica el número de documento proporcionado.");
                    }
                }

                // Eliminar el registro de la tabla INVENTARIO
                using (OracleCommand commandInventario = new OracleCommand(queryInventario, ConexionBD.Conex))
                {
                    // Añade el parámetro para prevenir inyección SQL
                    commandInventario.Parameters.Add(new OracleParameter("noDocumento", noDocumento));

                    // Ejecuta la consulta
                    int resultInventario = commandInventario.ExecuteNonQuery();

                    if (resultInventario > 0)
                    {
                        // Commit de la transacción si todo se ejecutó correctamente
                        transaction.Commit();
                        MessageBox.Show("Registro eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro de inventario para eliminar. Verifica el número de documento proporcionado.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Rollback de la transacción en caso de error
                transaction.Rollback();
                MessageBox.Show($"Error al eliminar los registros: {ex.Message}");
            }
        }

        private void buttBuscarDoc_Click(object sender, EventArgs e)
        {
            string noDocumento = textUsuario.Text;

            // Llama al método para buscar en la base de datos y mostrar la información
            BuscarParaEliminar(noDocumento);

        }
        private void buttInsertar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCantidad())
            {
                // Si la validación falla, salir del método
                return;
            }

            // Validar que la cantidad a retirar no se mayor que las existencias
            if (!ValidarExistencias())
            {
                LimpiarTextBoxes();
                buttInsertar.Enabled = false;
                return;
            }

            // Obtener los valores de los TextBox
            string codigo = textCodigo.Text;
            string descripcion = textDescripcion.Text;
            int cantidad = Convert.ToInt32(textCantidad.Text);
            decimal costo = Convert.ToDecimal(textCosto.Text);
            string subtotal = textSubTotal.Text;

            // Validar si el código ya existe en el DataGridView
            if (CodigoExisteEnDataGridView(codigo))
            {
                MessageBox.Show("El código de producto ya está en la tabla.", "Código Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Agregar una nueva fila al DataGridView con los valores de los TextBox
                dataGridView1.Rows.Add(codigo, descripcion, cantidad, costo, subtotal);

                SumarColumnas();
            }

            // Limpiar los TextBox después de la inserción
            LimpiarTextBoxes();
            buttInsertar.Enabled = false;
        }

        private bool CodigoExisteEnDataGridView(string codigo)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Asumiendo que el código está en la primera columna (índice 0)
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == codigo)
                {
                    return true;
                }
            }
            return false;
        }


        private bool ValidarExistencias()
        {
            int cantidad = Convert.ToInt32(textCantidad.Text);
            int existencia = Convert.ToInt32(textExistencia.Text);

            if (cantidad > existencia)
            {
                MessageBox.Show("No hay suficientes existencias.", "Existencias Insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void buttNuevo_Click_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textObservacion.Text) && dataGridView1.Rows.Count > 1)
            {
                // Confirmar si se desea realizar la eliminación
                DialogResult result = MessageBox.Show("¿Seguro que desea insertar los registros indicados?", "Confirmar inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    InsertarDatos();

                    DialogResult resultPDF = MessageBox.Show("¿Desea generar un PDF de su transacción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultPDF == DialogResult.Yes)
                    {
                        GeneradorPDF();
                    }

                    LimpiarControles();
                    CargarDatos.CargarUltimoIDInventario(textNoDoc, ConexionBD.Conex);
                    EstablecerFechaActual();
                }
            }
            else
            {
                // Si alguno de los controles está vacío, muestra un mensaje al usuario y sale del evento
                MessageBox.Show("Faltan datos que llenar.");
                return;
            }

        }

        private void buttEliminar_Click_1(object sender, EventArgs e)
        {
            //nota textUsuario es parte de buscar no. documento, si lo elimino me da error
            string noDocumento = textUsuario.Text;

            // Confirmar si se desea realizar la eliminación
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar los registros asociados al documento?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Llamar al método para eliminar registros del inventario
                EliminarRegistro(noDocumento);
                LimpiarControles();
                CargarDatos.CargarUltimoIDInventario(textNoDoc, ConexionBD.Conex);
                EstablecerFechaActual();
            }
        }

        private void buttLimpiar_Click(object sender, EventArgs e)
        {

            foreach (Control control in Controls)
            {
                if (control is TextBox && control != textFecha && control != textNoDoc)
                {
                    ((TextBox)control).Text = "";

                    textCosto.Text = "0.00";
                    textCodigo.Enabled = true;
                    textUsuario.Enabled = true;
                    buttInsertar.Enabled = false;
                }
            }

            // Limpiar el DataGridView
            dataGridView1.Rows.Clear();
        }
        private void buttImprimir_Click(object sender, EventArgs e)
        {
            GeneradorPDF();
           
        }
        private void textNoDoc_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            string noDocumento = textNoDoc.Text;

            // Llama al método para buscar en la base de datos y mostrar la información
            BuscarParaEliminar(noDocumento);
        }

        private void textCantidad_TextChanged_1(object sender, EventArgs e)
        {
            decimal cantidad = 0;

            if (!string.IsNullOrEmpty(textCantidad.Text))
            {
                cantidad = decimal.Parse(textCantidad.Text);
            }

            // Obtener el valor de textCosto (asumiendo que ya ha sido validado)
            decimal costo = decimal.Parse(textCosto.Text);

            // Calcular el subtotal multiplicando la cantidad por el costo
            decimal subtotal = cantidad * costo;

            // Formatear el subtotal con el prefijo "Q. " y alineado a la derecha
            textSubTotal.Text = string.Format("Q. {0,10}", subtotal.ToString("#,##0.00"));
        }

        private void textCodigo_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                // Crear una instancia del formulario ListaProductos con los parámetros necesarios
                listaProductosForm = new ListaProductos("PRODUCTOS", "COD_PRODUCTO", "NOMBRE");

                // Suscribirse al evento ProductoSeleccionado
                listaProductosForm.ProductoSeleccionado += ListaProductosForm_ProductoSeleccionado;

                // Suscribirse al evento FormClosed del formulario principal para cerrar ListaProductos
                this.FormClosed += PrincipalForm_FormClosed;


                // Mostrar el formulario ListaProductos
                listaProductosForm.Show();
            }
        }

        private void ListaProductosForm_ProductoSeleccionado(string codigo)
        {
            // Establecer el valor del textCodigo con el código del producto seleccionado
            SetTextCodigo(codigo);
        }

        private void Button_EnabledChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            if (button != null)
            {
                if (!button.Enabled)
                {
                    // Define los colores cuando el botón está deshabilitado
                    button.BackColor = Color.White;
                    button.ForeColor = Color.FromArgb(0, 0, 64);
                }
                else
                {
                    // Restaura los colores originales cuando el botón está habilitado
                    button.BackColor = Color.FromArgb(0, 0, 64);  // Fondo azul oscuro
                    button.ForeColor = Color.White;  // Texto blanco
                }
            }
        }


        private void ApplyInitialButtonColors()
        {
            UpdateButtonColors(buttInsertar);
            UpdateButtonColors(buttNuevo);
            UpdateButtonColors(buttBuscar);
            UpdateButtonColors(buttEliminar);
            UpdateButtonColors(buttImprimir);
            // Repetir para otros botones según sea necesario
        }

        private void UpdateButtonColors(System.Windows.Forms.Button button)
        {
            if (!button.Enabled)
            {
                button.BackColor = Color.White;
                button.ForeColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                button.BackColor = Color.FromArgb(0, 0, 64);
                button.ForeColor = Color.White;
            }
        }

        private void GeneradorPDF()
        {
            // Crear un cuadro de diálogo para guardar el archivo PDF
            SaveFileDialog guardarDialogo = new SaveFileDialog();
            guardarDialogo.Filter = "Archivos PDF (*.pdf)|*.pdf";
            guardarDialogo.Title = "Guardar PDF";

            if (guardarDialogo.ShowDialog() == DialogResult.OK)
            {
                string nombreArchivo = guardarDialogo.FileName;


                // Crear documento PDF
                Document documento = new Document(PageSize.A4);

                try
                {
                    // Crear un escritor de PDF
                    PdfWriter.GetInstance(documento, new FileStream(nombreArchivo, FileMode.Create));

                    // Abrir el documento
                    documento.Open();

                    // Agregar la palabra "Inventario" con estilo
                    iTextSharp.text.Font tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 24, BaseColor.BLACK);
                    Paragraph titulo = new Paragraph("Salidas de Inventario", tituloFont);
                    titulo.Alignment = Element.ALIGN_CENTER;
                    documento.Add(titulo);


                    // Crear contenido adicional para agregar al PDF
                    string contenidoAdicional = $"Fecha : {textFecha.Text}\n";
                    contenidoAdicional += $"Numero del documento: {textNoDoc.Text}\n\n";
                    contenidoAdicional += $"Observaciones: {textObservacion.Text}\n\n";
                    contenidoAdicional += $"Cantidad: {textCantidad2.Text}\n\n";
                    contenidoAdicional += $"Total: {textTotal.Text}\n\n";


                    documento.Add(new Paragraph(contenidoAdicional));


                    // Agregar contenido del DataGridView al PDF
                    PdfPTable tabla = new PdfPTable(dataGridView1.Columns.Count);
                    tabla.WidthPercentage = 100;

                    // Agregar encabezados de columna
                    foreach (DataGridViewColumn columna in dataGridView1.Columns)
                    {
                        PdfPCell celda = new PdfPCell(new Phrase(columna.HeaderText));
                        tabla.AddCell(celda);
                    }

                    // Agregar filas y celdas
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell celda in fila.Cells)
                        {
                            if (celda.Value != null)
                            {
                                tabla.AddCell(celda.Value.ToString());
                            }
                        }
                    }

                    documento.Add(tabla);

                    // Cerrar el documento
                    documento.Close();

                    MessageBox.Show("PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textUsuario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                // Crear una instancia del formulario ListaProductos con los parámetros necesarios
                listaProductosForm = new ListaProductos("INVENTARIO", "NO_DOCUMENTO", "TIPO_DOCUMENTO");

                // Suscribirse al evento ProductoSeleccionado
                listaProductosForm.ProductoSeleccionado += ListaProductosForm_Seleccionado;

                // Suscribirse al evento FormClosed del formulario principal para cerrar ListaProductos
                this.FormClosed += PrincipalForm_FormClosed;


                // Mostrar el formulario ListaProductos
                listaProductosForm.Show();
            }
        }

        private void ListaProductosForm_Seleccionado(string NoDoc)
        {
            SetTextNoDoc(NoDoc);
        }

        public void SetTextNoDoc(string NoDoc)
        {
            textUsuario.Text = NoDoc;
        }



        //PARA LOS PARAMETROS DE SEGURIDAD DE LETRAS Y NUMEROS
        //btn codigo
        private void textCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {     //no dejara pasar numeros del 32 al 47 y del 58 al 47 para que solo se queden los num. en el ASCII
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //btn descripción

        private void textDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //btn existencias
        private void textExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }
        //btn cantidad
        private void textCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }
        //btn costos
        private void textCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //btn subtotal
        private void textSubTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }
        //btn observaciones
        private void textObservacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //btn cantidad
        private void textCantidad2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //btn usuario -- pendiente colocarle si es numero  o letras
        private void textUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {      //no dejara pasar numeros del 32 al 47 y del 58 al 47 para que solo se queden los num. en el ASCII
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        //VACIO TEXTCOSTO, TEXTCODIGO , DESCRIPCION
        private void textCosto_TextChanged(object sender, EventArgs e)
        {

        }
        private void textCodigo_TextChanged(object sender, EventArgs e)
        { }
        private void textCodigo_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {
            //por equivocación abri este código lo elimine y lo volvi a regresar pero medio error
        }

        private void PrincipalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cerrar el formulario ListaProductos si está abierto
            if (listaProductosForm != null && !listaProductosForm.IsDisposed)
            {
                listaProductosForm.Close();
            }
        }

        private void textNoDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void textFecha_TextChanged(object sender, EventArgs e)
        {

        }
        private void SalidaInvenario_Load_1(object sender, EventArgs e)
        {

        }


    }
}

