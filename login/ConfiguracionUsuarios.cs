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
        public ConfiguracionUsuarios()
        {
            InitializeComponent();
        }
        //Encriptacion encriptacion = new Encriptacion();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarUsuario(
            EMP_CODIGO.Text.Trim(),
            Nombres.Text.Trim(),
            Apellidos.Text.Trim(),
            Direccion.Text.Trim(),
            No_Identificacion.Text.Trim(),
            //Tipo_Usuario.SelectedText,
            // Contrasena.Text.Trim(),
            //Genero.SelectedText);

            Contrasena.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(Contrasena.Text)));

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
                EliminarUsuario(codigo);
            }

           ;
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

        private void EMP_CODIGO_TextChanged(object sender, EventArgs e)
        {

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

                            // Establece la selección de los ComboBox basándose en los nombres. 
                            // Esto requiere que los ComboBox ya tengan cargados todos los posibles valores.
                            //               Genero.SelectedIndex = Genero.FindStringExact(reader["Genero"].ToString());
                            //             Tipo_Usuario.SelectedIndex = Tipo_Usuario.FindStringExact(reader["Tipo_Usuario"].ToString());
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
                MessageBox.Show($"Error al buscar el usuario.");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

            ActualizarUsuario(
            EMP_CODIGO.Text.Trim(),
            Nombres.Text.Trim(),
            Apellidos.Text.Trim(),
            Direccion.Text.Trim(),
            No_Identificacion.Text.Trim(),
            //Tipo_Usuario.SelectedText,
            //Contrasena.Text.Trim());
            //Genero.SelectedText);
            Contrasena.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(Contrasena.Text)));

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

        private void ConfiguracionUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void buttImprimir_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
        private void LimpiarControles()
        {

            EMP_CODIGO.Text = "";
            Nombres.Text = "";
            Apellidos.Text = "";
            Direccion.Text = "";
            No_Identificacion.Text = "";
            //Tipo_Usuario.SelectedIndex = -1;
            Contrasena.Text = "";
            //Genero.SelectedIndex = -1;
        }

        private void Contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Tipo_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Numeros_TextChanged(object sender, EventArgs e)
        {

        }
        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Letras_TextChanged(object sender, EventArgs e)
        {

        }

        private void Letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras (a-z, A-Z) y teclas de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Ignorar el evento de tecla
            }
        }

        private void Direccion_TextChanged(object sender, EventArgs e)
        {

        }
        private void Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras (a-z, A-Z), números (0-9), guión (-) y teclas de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true; // Ignorar el evento de tecla
            }
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
                // Crear una instancia del formulario ListaProductos con los parámetros necesarios
                ListaProductos listaProductosForm = new ListaProductos("USUARIOS", "EMP_CODIGO", "NOMBRES");

                // Suscribirse al evento ProductoSeleccionado
                listaProductosForm.ProductoSeleccionado += ListaProductosForm_ProductoSeleccionado;

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
    }
}
