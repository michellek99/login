using login.Datos;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms = System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace login
{
    public partial class Mantenimiento_de_Productos : Form
    {
        private ListaProductos listaProductosForm;
        public Mantenimiento_de_Productos()
        {
            InitializeComponent();
            CargarMarcas();
            CargarCategorias();

            // Configurar ComboBox para solo permitir la selección
            comboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;

            // Eventos para bloquear copiar, pegar, cortar
            comboMarca.KeyDown += comboMarca_KeyDown;
            comboMarca.KeyUp += comboMarca_KeyUp;
            comboCategoria.KeyDown += comboCategoria_KeyDown;
            comboCategoria.KeyUp += comboCategoria_KeyUp;


            button1.Enabled = true; //nuevo
            button4.Enabled = false; //modificar
            button3.Enabled = false; //eliminar
            button1.EnabledChanged += Button_EnabledChanged;
            button4.EnabledChanged += Button_EnabledChanged;
            button3.EnabledChanged += Button_EnabledChanged;

           // textPrecio.KeyPress += textPrecio_KeyPress;

            ApplyInitialButtonColors();
        }

        private void CargarMarcas()
        {
            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                string query = "SELECT COD_MARCA, NOMBRE FROM MARCA";
                OracleCommand command = new OracleCommand(query, ConexionBD.Conex);
                OracleDataAdapter da = new OracleDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "MARCA");
                comboMarca.DisplayMember = "NOMBRE";
                comboMarca.ValueMember = "COD_MARCA";
                comboMarca.DataSource = ds.Tables["MARCA"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar marcas: " + ex.Message);
            }
        }

        private void CargarCategorias()
        {
            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                string query = "SELECT COD_CATEGORIA, NOMBRE FROM CATEGORIA_PRODUCTOS";
                OracleCommand command = new OracleCommand(query, ConexionBD.Conex);
                OracleDataAdapter da = new OracleDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "CATEGORIA_PRODUCTOS");
                comboCategoria.DisplayMember = "NOMBRE";
                comboCategoria.ValueMember = "COD_CATEGORIA";
                comboCategoria.DataSource = ds.Tables["CATEGORIA_PRODUCTOS"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }


        private void buttBuscar_Click(object sender, EventArgs e)
        {
            // Obtiene el código del producto desde el TextBox textCodigo
            string codigoProducto = textCodigo.Text.Trim();

            // Verifica si el campo no está vacío
            if (string.IsNullOrEmpty(codigoProducto))
            {
                MessageBox.Show("Por favor, ingresa un código de producto.");
                return;
            }

            // Llama al método BuscarProducto con el código proporcionado
            BuscarProducto(codigoProducto);
        }

        private void BuscarProducto(string codigoProducto)
        {
            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                string query = @"SELECT p.COD_PRODUCTO, p.REFERENCIA, p.NOMBRE, p.PRESENTACION, p.PRECIO, m.NOMBRE AS NOMBRE_MARCA, c.NOMBRE AS NOMBRE_CATEGORIA
                         FROM PRODUCTOS p
                         JOIN MARCA m ON p.COD_MARCA = m.COD_MARCA
                         JOIN CATEGORIA_PRODUCTOS c ON p.COD_CATEGORIA = c.COD_CATEGORIA
                         WHERE p.COD_PRODUCTO = :codigo";

                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    command.Parameters.Add(new OracleParameter("codigo", codigoProducto));

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Asumiendo que tienes los controles TextBox y ComboBox adecuados en tu formulario
                            textCodigo.Text = reader["COD_PRODUCTO"].ToString();
                            textReferencia.Text = reader["REFERENCIA"].ToString();
                            textNombre.Text = reader["NOMBRE"].ToString();
                            textPresentacion.Text = reader["PRESENTACION"].ToString();
                            textPrecio.Text = reader["PRECIO"].ToString();

                            // Establece la selección de los ComboBox basándose en los nombres. 
                            // Esto requiere que los ComboBox ya tengan cargados todos los posibles valores.
                            comboMarca.SelectedIndex = comboMarca.FindStringExact(reader["NOMBRE_MARCA"].ToString());
                            comboCategoria.SelectedIndex = comboCategoria.FindStringExact(reader["NOMBRE_CATEGORIA"].ToString());

                            button1.Enabled = false;
                            button4.Enabled = true;
                            button3.Enabled = true;
                            textCodigo.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado.");
                            // Limpia los campos si se desea
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el producto: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!ValidarTextBoxes())
            {
                return;
            }

            DialogResult result = MessageBox.Show("¿Seguro que desea insertar los registros indicados?", "Confirmar inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string codigoProducto = textCodigo.Text.Trim();

                if (CodigoDuplicado(codigoProducto))
                {
                    MessageBox.Show("El código del producto ya existe.");
                    return;
                }
                else
                {
                    InsertarProducto(
                    textCodigo.Text.Trim(),
                    textReferencia.Text.Trim(),
                    textNombre.Text.Trim(),
                    textPresentacion.Text.Trim(),
                    comboMarca.SelectedValue.ToString(),
                    comboCategoria.SelectedValue.ToString(),
                    textPrecio.Text.Trim());
                }
            }

            LimpiarControles();
        }

        public bool CodigoDuplicado(string codigoProducto)
        {
            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return false;
            }

            try
            {
                string query = @"SELECT COUNT(1)
                         FROM PRODUCTOS
                         WHERE COD_PRODUCTO = :codigo";

                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    command.Parameters.Add(new OracleParameter("codigo", codigoProducto));

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar el código duplicado: {ex.Message}");
                return false;
            }
        }

        private void InsertarProducto(string codProducto, string referencia, string nombre, string presentacion, string codMarca, string codCategoria, string precio)
        {
            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                string query = @"INSERT INTO PRODUCTOS (COD_PRODUCTO, REFERENCIA, NOMBRE, PRESENTACION, COD_MARCA, COD_CATEGORIA, PRECIO)
                         VALUES (:codProducto, :referencia, :nombre, :presentacion, :codMarca, :codCategoria, :precio)";

                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    command.Parameters.Add(new OracleParameter("codProducto", codProducto));
                    command.Parameters.Add(new OracleParameter("referencia", referencia));
                    command.Parameters.Add(new OracleParameter("nombre", nombre));
                    command.Parameters.Add(new OracleParameter("presentacion", presentacion));
                    command.Parameters.Add(new OracleParameter("codMarca", codMarca));
                    command.Parameters.Add(new OracleParameter("codCategoria", codCategoria));
                    command.Parameters.Add(new OracleParameter("precio", precio));

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Producto insertado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar el producto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar el producto: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!ValidarTextBoxes())
            {
                return;
            }

            // Asume que textCodigo contiene el código del producto a actualizar
            string codigoProducto = textCodigo.Text.Trim();
            string referencia = textReferencia.Text.Trim();
            string nombre = textNombre.Text.Trim();
            string presentacion = textPresentacion.Text.Trim();
            string precioTexto = textPrecio.Text.Trim();
            decimal precio;

            if (string.IsNullOrEmpty(codigoProducto) || string.IsNullOrEmpty(referencia) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(presentacion) || string.IsNullOrEmpty(precioTexto) || !decimal.TryParse(precioTexto, out precio))
            {
                MessageBox.Show("Por favor, asegúrate de que todos los campos estén correctamente llenados antes de actualizar.");
                return;
            }

            // Muestra un mensaje de confirmación antes de proceder con la eliminación
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas modificar este producto?",
                                                 "Confirmar modificación",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Obtiene los valores seleccionados en los ComboBox
                var codMarca = comboMarca.SelectedValue;
                var codCategoria = comboCategoria.SelectedValue;

                // Llama al método ActualizarProducto con los valores recogidos
                ActualizarProducto(codigoProducto, referencia, nombre, presentacion, precio, codMarca, codCategoria);

            }

            LimpiarControles();
        }

        private void ActualizarProducto(string codigoProducto, string referencia, string nombre, string presentacion, decimal precio, object codMarca, object codCategoria)
        {
            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                string query = @"UPDATE PRODUCTOS 
                         SET REFERENCIA = :referencia, NOMBRE = :nombre, PRESENTACION = :presentacion, PRECIO = :precio, COD_MARCA = :codMarca, COD_CATEGORIA = :codCategoria
                         WHERE COD_PRODUCTO = :codigoProducto";

                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    command.Parameters.Add(new OracleParameter("referencia", referencia));
                    command.Parameters.Add(new OracleParameter("nombre", nombre));
                    command.Parameters.Add(new OracleParameter("presentacion", presentacion));
                    command.Parameters.Add(new OracleParameter("precio", precio));
                    command.Parameters.Add(new OracleParameter("codMarca", codMarca));
                    command.Parameters.Add(new OracleParameter("codCategoria", codCategoria));
                    command.Parameters.Add(new OracleParameter("codigoProducto", codigoProducto));

                    int resultado = command.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Producto actualizado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el producto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el producto: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Asume que textCodigo contiene el código del producto a eliminar
            string codigoProducto = textCodigo.Text.Trim();

            if (string.IsNullOrEmpty(codigoProducto))
            {
                MessageBox.Show("Por favor, ingresa el código del producto que deseas eliminar.");
                return;
            }

            // Muestra un mensaje de confirmación antes de proceder con la eliminación
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Si el usuario confirma, llama al método EliminarProducto
                EliminarProducto(codigoProducto);
            }

            LimpiarControles();
        }

        private void EliminarProducto(string codigoProducto)
        {
            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                string query = @"DELETE FROM PRODUCTOS WHERE COD_PRODUCTO = :codigoProducto";

                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    command.Parameters.Add(new OracleParameter("codigoProducto", codigoProducto));

                    int resultado = command.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Producto eliminado con éxito.");
                        // Opcional: Limpia los controles del formulario si lo consideras necesario
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar el producto especificado para eliminar.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}");
            }
        }

        private void buttLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            // Establece el texto de cada TextBox a una cadena vacía
            textCodigo.Text = "";
            textReferencia.Text = "";
            textNombre.Text = "";
            textPresentacion.Text = "";
            textPrecio.Text = "";

            button1.Enabled = true;
            button4.Enabled = false;
            button3.Enabled = false;
            textCodigo.Enabled = true;

            comboMarca.SelectedIndex = -1; // Esto seleccionará "ningún ítem"
            comboMarca.Text = string.Empty;
            comboCategoria.SelectedIndex = -1; // Esto seleccionará "ningún ítem"
            comboCategoria.Text = string.Empty;
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
            UpdateButtonColors(button1);
            UpdateButtonColors(button4);
            UpdateButtonColors(button3);
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

        private bool ValidarTextBoxes()
        {
            foreach (Control control in this.Controls)
            {
                // Verifica si el control es un TextBox
                if (control is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox textBox = control as System.Windows.Forms.TextBox;

                    // Verifica si el TextBox está vacío
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show("Debe llenar todos los campos");
                        return false;
                    }
                }
                if (string.IsNullOrEmpty(comboCategoria.Text) || comboCategoria.SelectedIndex == -1 ||
                    string.IsNullOrEmpty(comboMarca.Text) || comboMarca.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una opción en ambos campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void textCodigo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        public void SetTextCodigo(string codigo)
        {
            textCodigo.Text = codigo;
        }

        private void PrincipalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cerrar el formulario ListaProductos si está abierto
            if (listaProductosForm != null && !listaProductosForm.IsDisposed)
            {
                listaProductosForm.Close();
            }
        }
        //PARA LOS PARAMETROS DE SEGURIDAD DE LETRAS Y NUMEROS
        //btn codigo
        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //no dejara pasar numeros del 32 al 47 y del 58 al 47 para que solo se queden los num. en el ASCII
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void textReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96 || (e.KeyChar >= 123 && e.KeyChar <= 255)))
            {
                MessageBox.Show("Ingrese solo números y letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 33) || (e.KeyChar >= 35 && e.KeyChar <= 46)
                || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese números,letras,carácter comillas y diagonal permitidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textPresentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void comboCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                e.Handled = true; // Evita la acción de copiar, pegar o cortar
            }


        }

        private void textPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números y el punto decimal", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            /*  // Permitir solo números, el punto y la tecla de retroceso
             *  
             *  ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 47 && e.KeyChar <= 47) ||
                  (e.KeyChar >= 58 && e.KeyChar <= 255))
             *  
              if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
              {
                  e.Handled = true;
                  return;
              }

              // Si el punto decimal está presente, permitir solo hasta dos decimales
              if (e.KeyChar == '.' && (sender as WinForms.TextBox).Text.IndexOf('.') > -1)
              {
                  e.Handled = true;
                  return;
              }

              // Limitar a dos decimales
              WinForms.TextBox textBox = sender as WinForms.TextBox;
              string[] split = textBox.Text.Split('.');
              if (split.Length > 1 && split[1].Length >= 2 && textBox.SelectionStart > textBox.Text.IndexOf('.'))
              {
                  e.Handled = true;
              }*/
        }

        private void comboMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                e.Handled = true; // Evita la acción de copiar, pegar o cortar
            }

        }
        //para bloquear el combo box
        private void comboCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true; // Evita la acción de copiar, pegar o cortar
            }
        }

        private void comboCategoria_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true; // Evita la acción de copiar, pegar o cortar
            }
        }

        private void comboMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true; // Evita la acción de copiar, pegar o cortar
            }
        }

        private void comboMarca_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true; // Evita la acción de copiar, pegar o cortar
            }
        }


        //CODIGO QUE NO SE ESTA USANDO
        private void textCodigo_TextChanged(object sender, EventArgs e) { }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e) { }

        private void Numeros_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void label9_Click(object sender, EventArgs e) { }
  
        private void label10_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void Mantenimiento_de_Productos_Load(object sender, EventArgs e) { }




    }
}
