using login.Datos;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace login
{
    public partial class MantenimientoMarca : Form
    {
        private ListaProductos listaProductosForm;
        public MantenimientoMarca()
        {
            InitializeComponent();
            buttNuevo.Enabled = true;
            buttModificar.Enabled = false;
            buttEliminar.Enabled = false;
            buttNuevo.EnabledChanged += Button_EnabledChanged;
            buttModificar.EnabledChanged += Button_EnabledChanged;
            buttEliminar.EnabledChanged += Button_EnabledChanged;


            ApplyInitialButtonColors();
        }

        private void buttBuscar_Click(object sender, EventArgs e)
        {
            // Obtiene el código ingresado por el usuario
            string codigoMarca = textCodigo.Text;

            // Llama al método para buscar la marca
            BuscarMarca(codigoMarca);
        }

        private void BuscarMarca(string codigoMarca)
        {
            if (string.IsNullOrEmpty(codigoMarca))
            {
                MessageBox.Show("Por favor, ingrese un código.");
                return;
            }

            // Verifica si la conexión está abierta
            if (ConexionBD.Conex.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                string query = "SELECT NOMBRE FROM MARCA WHERE COD_MARCA = :codigo";

                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    // Añade el parámetro para prevenir inyección SQL
                    command.Parameters.Add(new OracleParameter("codigo", codigoMarca));

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textNombre.Text = reader["NOMBRE"].ToString();
                            buttNuevo.Enabled = false;
                            buttModificar.Enabled = true;
                            buttEliminar.Enabled = true;
                            textCodigo.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Marca no encontrada.");
                            textNombre.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar la marca: {ex.Message}");
            }
        }


        private void buttNuevo_Click(object sender, EventArgs e)
        {
            if (!ValidarTextBoxes())
            {
                return;
            }

            DialogResult result = MessageBox.Show("¿Seguro que desea insertar los registros indicados?", "Confirmar inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string codigoMarca = textCodigo.Text;
                string nombreMarca = textNombre.Text;

                if (CodigoDuplicado(codigoMarca))
                {
                    MessageBox.Show("El código de marca ya existe.");
                    return;
                }
                else
                {
                    // Llama al método para insertar la marca
                    InsertarMarca(codigoMarca, nombreMarca);
                }
            }

            LimpiarCampos();
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
                         FROM MARCA
                         WHERE COD_MARCA = :codigo";

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

        private void InsertarMarca(string codigoMarca, string nombreMarca)
        {
            // Verifica si la conexión está abierta
            if (ConexionBD.Conex.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                string query = "INSERT INTO MARCA (COD_MARCA, NOMBRE) VALUES (:codigo, :nombre)";

                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    // Añade los parámetros para prevenir inyección SQL
                    command.Parameters.Add(new OracleParameter("codigo", codigoMarca));
                    command.Parameters.Add(new OracleParameter("nombre", nombreMarca));

                    // Ejecuta la consulta
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Marca insertada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar la marca.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar la marca: {ex.Message}");
            }
        }

        private void buttModificar_Click(object sender, EventArgs e)
        {
            if (!ValidarTextBoxes())
            {
                return;
            }
            // Obtiene los valores ingresados por el usuario
            string codigoMarca = textCodigo.Text;
            string nombreNuevo = textNombre.Text;


            if (string.IsNullOrEmpty(codigoMarca) || string.IsNullOrEmpty(nombreNuevo))
            {
                MessageBox.Show("Por favor, asegúrate de que todos los campos estén correctamente llenados antes de actualizar.");
                return;
            }

            // Muestra un mensaje de confirmación antes de proceder con la eliminación
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas modificar esta marca?",
                                                 "Confirmar modificación",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Llama al método para actualizar la marca
                ActualizarMarca(codigoMarca, nombreNuevo);
            }

            LimpiarCampos();
        }

        private void ActualizarMarca(string codigoMarca, string nombreNuevo)
        {
            // Verifica si la conexión está abierta
            if (ConexionBD.Conex.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                string query = "UPDATE MARCA SET NOMBRE = :nombre WHERE COD_MARCA = :codigo";

                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    // Añade los parámetros para prevenir inyección SQL
                    command.Parameters.Add(new OracleParameter("nombre", nombreNuevo));
                    command.Parameters.Add(new OracleParameter("codigo", codigoMarca));

                    // Ejecuta la consulta
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Marca actualizada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la marca para actualizar. Verifica el código proporcionado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la marca: {ex.Message}");
            }
        }

        private void buttEliminar_Click(object sender, EventArgs e)
        {
            // Obtiene el código ingresado por el usuario
            string codigoMarca = textCodigo.Text;

            // Muestra un mensaje de confirmación antes de proceder con la eliminación
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta marca?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Llama al método para eliminar la marca
                EliminarMarca(codigoMarca);
            }

            LimpiarCampos();

        }

        private void EliminarMarca(string codigoMarca)
        {
            if (string.IsNullOrEmpty(codigoMarca))
            {
                MessageBox.Show("Por favor, ingresa un código. ");
                return;
            }

            // Verifica si la conexión está abierta
            if (ConexionBD.Conex.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                string query = "DELETE FROM MARCA WHERE COD_MARCA = :codigo";

                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    // Añade el parámetro para prevenir inyección SQL
                    command.Parameters.Add(new OracleParameter("codigo", codigoMarca));

                    // Ejecuta la consulta
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Marca eliminada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la marca para eliminar. Verifica el código proporcionado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la marca: {ex.Message}");
            }
        }

        private void buttGuardar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textCodigo.Text = "";
            textNombre.Text = "";
            buttNuevo.Enabled = true;
            buttModificar.Enabled = false;
            buttEliminar.Enabled = false;
            textCodigo.Enabled = true;
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
            UpdateButtonColors(buttNuevo);
            UpdateButtonColors(buttModificar);
            UpdateButtonColors(buttEliminar);
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
            }
            return true;
        }

        private void textCodigo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                // Crear una instancia del formulario ListaProductos con los parámetros necesarios
                listaProductosForm = new ListaProductos("MARCA", "COD_MARCA", "NOMBRE");

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

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {

        }
       
        //PARA LOS PARAMETROS DE SEGURIDAD DE LETRAS Y NUMEROS
        //btn codigo
        private void textCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //no dejara pasar numeros del 32 al 47 y del 58 al 47 para que solo se queden los num. en el ASCII
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //btn nombre
        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
