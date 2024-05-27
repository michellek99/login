﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login.Datos;
using static iTextSharp.tool.xml.html.HTML;

namespace login
{
    public partial class CategoriaProductos : Form
    {
        private ListaProductos listaProductosForm;
        public CategoriaProductos()
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

        private void CategoriaProductos_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttBuscar_Click(object sender, EventArgs e)
        {
            BuscarCategoria(textCategoria.Text);
        }

        private void BuscarCategoria(string codigo)
        {
            try
            {
                if (string.IsNullOrEmpty(codigo))
                {
                    MessageBox.Show("Por favor, ingresa un código de producto.");
                    return;
                }

                if (ConexionBD.Conex.State != System.Data.ConnectionState.Open)
                {
                    ConexionBD.Conex.Open(); // Intenta abrir la conexión si no está abierta
                }

                string query = "SELECT NOMBRE, DESCRIPCION FROM CATEGORIA_PRODUCTOS WHERE COD_CATEGORIA = :codigo";

                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    command.Parameters.Add(new OracleParameter("codigo", codigo));

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textNombre.Text = reader["NOMBRE"].ToString();
                            textDescripcion.Text = reader["DESCRIPCION"].ToString();

                            buttNuevo.Enabled = false;
                            buttModificar.Enabled = true;
                            buttEliminar.Enabled = true;
                            textCategoria.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Categoría no encontrada.");
                            textNombre.Clear();
                            textDescripcion.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar la categoría: {ex.Message}");
            }
        }

        private void buttModificar_Click(object sender, EventArgs e)
        {
            if (!ValidarTextBoxes())
            {
                return;
            }

            string codigoCategoria = textCategoria.Text;
            string nombreActualizado = textNombre.Text;
            string descripcionActualizada = textDescripcion.Text;

            // Llama al método para actualizar los datos
            ActualizarCategoria(codigoCategoria, nombreActualizado, descripcionActualizada);

            LimpiarCampos();
        }

        private void ActualizarCategoria(string codigoCategoria, string nombreNuevo, string descripcionNueva)
        {
            // Prepara la consulta SQL para actualizar los datos
            string query = "UPDATE CATEGORIA_PRODUCTOS SET NOMBRE = :nombre, DESCRIPCION = :descripcion WHERE COD_CATEGORIA = :codigo";

            // Verifica si la conexión está abierta
            if (ConexionBD.Conex.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    // Añade los parámetros para prevenir inyección SQL
                    command.Parameters.Add(new OracleParameter("nombre", nombreNuevo));
                    command.Parameters.Add(new OracleParameter("descripcion", descripcionNueva));
                    command.Parameters.Add(new OracleParameter("codigo", codigoCategoria));

                    // Ejecuta la consulta
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Datos actualizados correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudieron actualizar los datos. Asegúrate de que el código de categoría sea correcto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar los datos: {ex.Message}");
            }
        }

        private void buttNuevo_Click(object sender, EventArgs e)
        {
            if (!ValidarTextBoxes())
            {
                return;
            }

            // Obtiene los valores ingresados
            string codigoCategoria = textCategoria.Text;
            string nombre = textNombre.Text;
            string descripcion = textDescripcion.Text;

            // Llama al método para insertar los datos
            InsertarCategoria(codigoCategoria, nombre, descripcion);

            LimpiarCampos();
        }

        private void InsertarCategoria(string codigoCategoria, string nombre, string descripcion)
        {
            // Prepara la consulta SQL para insertar los datos
            string query = "INSERT INTO CATEGORIA_PRODUCTOS (COD_CATEGORIA, NOMBRE, DESCRIPCION) VALUES (:codigo, :nombre, :descripcion)";

            // Verifica si la conexión está abierta
            if (ConexionBD.Conex.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    // Añade los parámetros para prevenir inyección SQL
                    command.Parameters.Add(new OracleParameter("codigo", codigoCategoria));
                    command.Parameters.Add(new OracleParameter("nombre", nombre));
                    command.Parameters.Add(new OracleParameter("descripcion", descripcion));

                    // Ejecuta la consulta
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Datos insertados correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudieron insertar los datos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar los datos: {ex.Message}");
            }
        }

        private void buttEliminar_Click(object sender, EventArgs e)
        {
            string codigoCategoria = textCategoria.Text;

            // Muestra un mensaje de confirmación antes de proceder con la eliminación
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta categoría?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Llama al método para eliminar los datos
                EliminarCategoria(codigoCategoria);

                LimpiarCampos();
            }
        }

        private void EliminarCategoria(string codigoCategoria)
        {
            // Prepara la consulta SQL para eliminar los datos
            string query = "DELETE FROM CATEGORIA_PRODUCTOS WHERE COD_CATEGORIA = :codigo";

            // Verifica si la conexión está abierta
            if (ConexionBD.Conex.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    // Añade el parámetro para prevenir inyección SQL
                    command.Parameters.Add(new OracleParameter("codigo", codigoCategoria));

                    // Ejecuta la consulta
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Categoría eliminada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la categoría para eliminar. Verifica el código proporcionado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No es posible eliminar la categoría, este código está enlazado a un producto existente.");
            }
        }

        private void buttGuardar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textCategoria.Text = "";
            textNombre.Text = "";
            textDescripcion.Text = "";

            buttNuevo.Enabled = true;
            buttModificar.Enabled = false;
            buttEliminar.Enabled = false;
            textCategoria.Enabled = true;
        }

        private void labelCategoria_Click(object sender, EventArgs e)
        {

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

        private void textCategoria_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                // Crear una instancia del formulario ListaProductos con los parámetros necesarios
                listaProductosForm = new ListaProductos("CATEGORIA_PRODUCTOS", "COD_CATEGORIA", "NOMBRE");

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
            SetTextCategoria(codigo);
        }

        public void SetTextCategoria(string codigo)
        {
            textCategoria.Text = codigo;
        }

        private void PrincipalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cerrar el formulario ListaProductos si está abierto
            if (listaProductosForm != null && !listaProductosForm.IsDisposed)
            {
                listaProductosForm.Close();
            }
        }

        private void textCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        //PARA LOS PARAMETROS DE SEGURIDAD DE LETRAS Y NUMEROS
        //btn codigo
        private void textCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            //no dejara pasar numeros del 32 al 47 y del 58 al 47 para que solo se queden los num. en el ASCII
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textDescripcion_KeyPress(object sender, KeyPressEventArgs e)
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
