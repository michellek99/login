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
    public partial class Kardex : Form
    {
        private ListaProductos listaProductosForm;
        public Kardex()
        {
            InitializeComponent();
            ConfigurarColumnasDataGridView();
            txtEntrada.Enabled = false;
            txtsalida.Enabled = false;
            txtSaldo.Enabled = false;
            txtNombre.Enabled = false;
            txtpresentacion.Enabled = false;

            textCodigo.Enabled = true;
            buttImprimir.Enabled = false;
            buttImprimir.EnabledChanged += Button_EnabledChanged;


            ApplyInitialButtonColors();


        }
        private void ConfigurarColumnasDataGridView()
        {
            //Limpia el dataGridView antes de agregar columnas.
            dataGridView1.Columns.Clear();

            // Agrega encabezados de las columnas.
            dataGridView1.Columns.Add("Columna1", "TIPO MOVIMIENTO");
            dataGridView1.Columns.Add("Columna2", "NO. DOCUMENTO");
            dataGridView1.Columns.Add("Columna3", "OBSERVACION");
            dataGridView1.Columns.Add("Columna4", "ENTRADAS");
            dataGridView1.Columns.Add("Columna5", "SALIDAS");

            // Configura las columnas para que se ajusten y ocupen el espacio disponible.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void buttImprimir_Click(object sender, EventArgs e)
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
                    Paragraph titulo = new Paragraph("MOVIMIENTO DE PRODUCTOS KARDEX", tituloFont);
                    titulo.Alignment = Element.ALIGN_CENTER;
                    documento.Add(titulo);


                    // Crear contenido adicional para agregar al PDF
                    string contenidoAdicional = $"Código del producto: {textCodigo.Text}\n";
                    contenidoAdicional += $"Nombre del producto: {txtNombre.Text}\n\n";
                    contenidoAdicional += $"Presentación: {txtpresentacion.Text}\n\n";
                    contenidoAdicional += $"Total entradas: {txtEntrada.Text}\n\n";
                    contenidoAdicional += $"Total salidas: {txtsalida.Text}\n\n";
                    contenidoAdicional += $"Saldo Producto: {txtSaldo.Text}\n\n";


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

        private void buttBuscar_Click(object sender, EventArgs e)
        {
            string noCodigo = textCodigo.Text;
            CargarDatosProducto(noCodigo);
            SumarCol();

        }

        private void CargarDatosProducto(string noCodigo)
        {
            // Prepara la consulta SQL para buscar en la tabla DETALLE_INVENTARIO
            string queryDetalle = "SELECT OBSERVACION, INGRESO, EGRESO, NO_DOCUMENTO, TIPO_DOCUMENTO FROM DETALLE_INVENTARIO WHERE COD_PRODUCTO = :noCodigo";
            string queryNombre = "SELECT NOMBRE FROM PRODUCTOS WHERE COD_PRODUCTO = :noCodigo";
            string queryprese = "SELECT  PRESENTACION FROM PRODUCTOS WHERE COD_PRODUCTO = :noCodigo";
            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }
            try
            {

                using (OracleCommand commandDetalle = new OracleCommand(queryDetalle, ConexionBD.Conex))
                {
                    commandDetalle.Parameters.Add(new OracleParameter("COD_PRODUCTO", noCodigo));
                    using (OracleDataReader readerDetalle = commandDetalle.ExecuteReader())
                    {
                        // Limpiar las filas existentes del DataGridView
                        dataGridView1.Rows.Clear();

                        // Iterar sobre los resultados y agregarlos al DataGridView
                        while (readerDetalle.Read())
                        {
                            object[] rowData = new object[5]; // 5 columnas
                            rowData[0] = readerDetalle["TIPO_DOCUMENTO"];
                            rowData[1] = readerDetalle["NO_DOCUMENTO"];
                            rowData[2] = readerDetalle["OBSERVACION"];
                            rowData[3] = readerDetalle["INGRESO"];
                            rowData[4] = readerDetalle["EGRESO"];
                            dataGridView1.Rows.Add(rowData);
                        }
                    }
                }
                using (OracleCommand commandNombre = new OracleCommand(queryNombre, ConexionBD.Conex))
                {
                    commandNombre.Parameters.Add(new OracleParameter("COD_PRODUCTO", noCodigo));
                    //commandNombre.Parameters.Add(new OracleParameter("noDocumento", noCodigo));
                    object nombre = commandNombre.ExecuteScalar();


                    if (nombre != null)
                    {
                        txtNombre.Text = nombre.ToString();

                    }
                }
                using (OracleCommand commandPrese = new OracleCommand(queryprese, ConexionBD.Conex))
                {
                    commandPrese.Parameters.Add(new OracleParameter("COD_PRODUCTO", noCodigo));
                    object prese = commandPrese.ExecuteScalar();


                    if (prese != null)
                    {
                        txtpresentacion.Text = prese.ToString();

                    }
                }

                textCodigo.Enabled = false;
                buttImprimir.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void SumarCol()
        {
            int column4Index = 3;
            int column5Index = 4;

            // Variables para almacenar las sumas de las columnas
            double sumColumn4 = 0;
            double sumColumn5 = 0;

            // Recorrer las filas del DataGridView y sumar los valores de cada columna
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Verificar que la fila no es una fila nueva (nueva fila añadida automáticamente por DataGridView)
                if (row.IsNewRow) continue;

                // Sumar los valores de la columna 4
                if (row.Cells[column4Index].Value != null && double.TryParse(row.Cells[column4Index].Value.ToString(), out double value4))
                {
                    sumColumn4 += value4;
                }

                // Sumar los valores de la columna 5
                if (row.Cells[column5Index].Value != null && double.TryParse(row.Cells[column5Index].Value.ToString(), out double value5))
                {
                    sumColumn5 += value5;
                }
            }

            // Realizar la resta entre las sumas obtenidas
            double result = sumColumn4 - sumColumn5;
            txtEntrada.Text = sumColumn4.ToString();
            txtsalida.Text = sumColumn5.ToString();
            txtSaldo.Text = result.ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView
            dataGridView1.Rows.Clear();

            // Limpiar los TextBox en el formulario
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }

            textCodigo.Enabled = true;
            buttImprimir.Enabled = false;
        }

        private void Kardex_Load(object sender, EventArgs e)
        {
            txtEntrada.Enabled = false;
            txtsalida.Enabled = false;
            txtSaldo.Enabled = false;
            txtNombre.Enabled = false;
            txtpresentacion.Enabled = false;


        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {

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
    }
}

       

