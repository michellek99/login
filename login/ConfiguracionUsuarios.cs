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

namespace login
{
    public partial class ConfiguracionUsuarios : Form
    {
        private ListaProductos listaProductosForm;
        public ConfiguracionUsuarios()
        {
            InitializeComponent();
            button1.Enabled = true;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.EnabledChanged += Button_EnabledChanged;
            button3.EnabledChanged += Button_EnabledChanged;
            button2.EnabledChanged += Button_EnabledChanged;


            ApplyInitialButtonColors();
        }
        //Encriptacion encriptacion = new Encriptacion();
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarTextBoxes())
            {
                return;
            }

            DialogResult result = MessageBox.Show("¿Seguro que desea insertar los registros indicados?", "Confirmar inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                InsertarUsuario(
                EMP_CODIGO.Text.Trim(),
                Nombres.Text.Trim(),
                Apellidos.Text.Trim(),
                Direccion.Text.Trim(),
                No_Identificacion.Text.Trim(),

                Contrasena.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(Contrasena.Text)));
            }

            LimpiarControles();

        }
        private bool ValidarTextBoxes()
        {
            foreach (Control control in this.Controls)
            {
                // Verifica si el control es un TextBox
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;

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

        //Inserta usuario en la base de datos//
        private void InsertarUsuario(string EMP_CODIGO, string Nombres, string Apellidos, string Direccion, string No_Identificacion, /*string Tipo_Usuario,*/ string Contrasena/*, string Genero*/)
        {
            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                // Consulta para verificar si el usuario ya existe
                string userQuery = @"SELECT COUNT(*) FROM usuarios WHERE EMP_CODIGO = :codigo";
                using (OracleCommand userCommand = new OracleCommand(userQuery, ConexionBD.Conex))
                {
                    userCommand.Parameters.Add(new OracleParameter("codigo", EMP_CODIGO));
                    int userCount = Convert.ToInt32(userCommand.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("El usuario ya existe en la base de datos.");
                        LimpiarControles();
                        return; // No insertar usuario si ya existe
                    }
                }

                // Consulta de inserción si el usuario no existe
                string insertQuery = @"INSERT INTO USUARIOS (EMP_CODIGO, NOMBRES, APELLIDOS, DIRECCION, NO_IDENTIFICACION, CONTRASEÑA)
                              VALUES (:EMP_CODIGO, :Nombres, :Apellidos, :Direccion, :No_Identificacion, :Contrasena)";
                using (OracleCommand command = new OracleCommand(insertQuery, ConexionBD.Conex))
                {
                    command.Parameters.Add(new OracleParameter("EMP_CODIGO", EMP_CODIGO));
                    command.Parameters.Add(new OracleParameter("Nombres", Nombres));
                    command.Parameters.Add(new OracleParameter("Apellidos", Apellidos));
                    command.Parameters.Add(new OracleParameter("Direccion", Direccion));
                    command.Parameters.Add(new OracleParameter("No_Identificacion", No_Identificacion));
                    command.Parameters.Add(new OracleParameter("Contrasena", Contrasena));

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        LimpiarControles();
                        MessageBox.Show("Usuario registrado correctamente.");


                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el usuario.");
                        LimpiarControles();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el usuario: {ex.Message}");
                LimpiarControles();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // Asume que textCodigo contiene el código del producto a eliminar
            string codigo = EMP_CODIGO.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Por favor, ingresa el código del Usuario que deseas eliminar.");
                return;
            }

            // Muestra un mensaje de confirmación antes de proceder con la eliminación
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Si el usuario confirma, llama al método Eliminar usuario
                EliminarUsuario(codigo);
            }

            LimpiarControles();
        }
        private void EliminarUsuario(string EMP_CODIGO)
        {
            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                string query = @"DELETE FROM USUARIOS WHERE EMP_CODIGO = :EMP_CODIGO";

                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    command.Parameters.Add(new OracleParameter("EMP_CODIGO", EMP_CODIGO));

                    int resultado = command.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Usuario eliminado con éxito.");
                        LimpiarControles();
                        // Opcional: Limpia los controles del formulario si lo consideras necesario
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar el Usuario especificado para eliminar.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el Usuario: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string codigoUsuario = EMP_CODIGO.Text.Trim();
            BuscarUsuario(codigoUsuario);
        }


        public string Decrypt(string data)
        {
            byte[] dataBytes = Convert.FromBase64String(data);
            string decodedString = Encoding.UTF8.GetString(dataBytes);
            return decodedString;
        }

        private void BuscarUsuario(string codigoUsuario)
        {
            // Verificar si el código de usuario está vacío
            if (string.IsNullOrWhiteSpace(codigoUsuario))
            {
                MessageBox.Show("Por favor, ingrese el código del empleado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                string query = @"SELECT * FROM usuarios WHERE EMP_CODIGO = :codigo";

                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    command.Parameters.Add(new OracleParameter("codigo", codigoUsuario));

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Asumiendo que tienes los controles TextBox y ComboBox adecuados en tu formulario
                            EMP_CODIGO.Text = reader["EMP_CODIGO"].ToString();
                            Nombres.Text = reader["Nombres"].ToString();
                            Apellidos.Text = reader["Apellidos"].ToString();
                            Direccion.Text = reader["Direccion"].ToString();
                            Contrasena.Text = Decrypt(reader["Contraseña"].ToString());
                            No_Identificacion.Text = reader["No_Identificacion"].ToString();

                            button1.Enabled = false;
                            button3.Enabled = true;
                            button2.Enabled = true;
                            EMP_CODIGO.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado.");

                            // Limpia los campos si se desea
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (!ValidarTextBoxes())
            {
                return;
            }

            // Muestra un mensaje de confirmación antes de proceder con la eliminación
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ActualizarUsuario(
                EMP_CODIGO.Text.Trim(),
                Nombres.Text.Trim(),
                Apellidos.Text.Trim(),
                Direccion.Text.Trim(),
                No_Identificacion.Text.Trim(),
                Contrasena.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(Contrasena.Text)));
            }

            LimpiarControles();
            
        }
        private void ActualizarUsuario(string EMP_CODIGO, string Nombres, string Apellidos, string Direccion, string No_Identificacion, string Contrasena)
        {
            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                string query = @"UPDATE USUARIOS 
                     SET NOMBRES = :Nombres, 
                         APELLIDOS = :Apellidos, 
                         DIRECCION = :Direccion, 
                         NO_IDENTIFICACION = :No_Identificacion, 
                         CONTRASEÑA = :Contrasena
                     WHERE EMP_CODIGO = :EMP_CODIGO";

                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    // Agregar parámetros al comando
                    command.Parameters.Add(new OracleParameter("Nombres", Nombres));
                    command.Parameters.Add(new OracleParameter("Apellidos", Apellidos));
                    command.Parameters.Add(new OracleParameter("Direccion", Direccion));
                    command.Parameters.Add(new OracleParameter("No_Identificacion", No_Identificacion));
                    command.Parameters.Add(new OracleParameter("Contrasena", Contrasena));
                    command.Parameters.Add(new OracleParameter("EMP_CODIGO", EMP_CODIGO));

                    // Ejecutar el comando
                    int resultado = command.ExecuteNonQuery();

                    // Comprobar el resultado de la ejecución
                    if (resultado > 0)
                    {
                        MessageBox.Show("Usuario actualizado con éxito.");
                        LimpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el Usuario, el código no debe ser modificado.");
                        LimpiarControles();
                    }
                }
            }
            catch (OracleException ex)
            {
                // Muestra detalles específicos del error de Oracle
                MessageBox.Show($"Error al actualizar el usuario: {ex.Message}\nCódigo de error: {ex.Number}\nFuente: {ex.Source}");
                LimpiarControles();
            }
            catch (Exception ex)
            {
                // Muestra cualquier otro tipo de error general
                MessageBox.Show($"Error inesperado: {ex.Message}\nFuente: {ex.Source}");
                LimpiarControles();
            }

        }

        private void buttImprimir_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
        private void LimpiarControles()
        {
            EMP_CODIGO.Enabled = true;
            EMP_CODIGO.Text = "";
            Nombres.Text = "";
            Apellidos.Text = "";
            Direccion.Text = "";
            No_Identificacion.Text = "";
            //Tipo_Usuario.SelectedIndex = -1;
            Contrasena.Text = "";
            //Genero.SelectedIndex = -1;
            button1.Enabled = true;
            button3.Enabled = false;
            button2.Enabled = false;
        }

       
        private void Tipo_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        


        private void Letras_TextChanged(object sender, EventArgs e)
        {

        }



        private void Direccion_TextChanged(object sender, EventArgs e)
        {

        }


        private void No_Identificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            {
                Contrasena.UseSystemPasswordChar = !checkBoxMostrarContraseña.Checked;
            }
        }

        private void EMP_CODIGO_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                // Crear una instancia del formulario Lista usuario con los parámetros necesarios
                listaProductosForm = new ListaProductos("USUARIOS", "EMP_CODIGO", "NOMBRES");

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
            EMP_CODIGO.Text = codigo;
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
            UpdateButtonColors(button1);
            UpdateButtonColors(button3);
            UpdateButtonColors(button2);
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

        //PARA LOS PARAMETROS DE SEGURIDAD DE LETRAS Y NUMEROS
        //btn codigo
        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void Letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras (a-z, A-Z), números (0-9), guión (-) y teclas de control (como Backspace)
            if ((e.KeyChar >= 33 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Signos perimitidos / - , .", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        //codigo que no se utiliza
        private void EMP_CODIGO_KeyUp(object sender, KeyEventArgs e){  }
        private void Contrasena_TextChanged(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void Numeros_TextChanged(object sender, EventArgs e) { }
        private void ConfiguracionUsuarios_Load(object sender, EventArgs e) { }
        private void EMP_CODIGO_TextChanged(object sender, EventArgs e) {  }
        private void label1_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }

    }
}
