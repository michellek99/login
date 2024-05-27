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
    public partial class ListaProductos : Form
    {
        public event Action<string> ProductoSeleccionado;

        private string nombreTabla;
        private string campoCodigo;
        private string campoNombre;

        // Variable estática para mantener la instancia actual
        private static ListaProductos instanciaActual;

        public ListaProductos(string nombreTabla, string campoCodigo, string campoNombre)
        {
            InitializeComponent();

            this.nombreTabla = nombreTabla;
            this.campoCodigo = campoCodigo;
            this.campoNombre = campoNombre;

            CargarDatosEnListBox();

            // Registro de los manejadores de eventos
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);

            // Cerrar la instancia anterior si ya existe
            if (instanciaActual != null && !instanciaActual.IsDisposed)
            {
                instanciaActual.Close();
            }

            // Establecer esta instancia como la actual
            instanciaActual = this;

            // Evento de cierre para limpiar la referencia estática
            this.FormClosed += new FormClosedEventHandler(this.ListaProductos_FormClosed);
        }

        private void ListaProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Limpiar la referencia estática cuando el formulario se cierre
            if (instanciaActual == this)
            {
                instanciaActual = null;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            SeleccionarProducto();
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionarProducto();
                // Evitar el sonido de "ding" que ocurre al presionar Enter
                e.SuppressKeyPress = true;
            }
        }

        private void SeleccionarProducto()
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                string[] parts = selectedItem.Split('-');
                string codigo = parts[0].Trim();

                ProductoSeleccionado?.Invoke(codigo);

                this.Close();
            }
        }

        public void CargarDatosEnListBox()
        {
            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                string query = $@"SELECT {campoCodigo}, {campoNombre} FROM {nombreTabla}";

                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        listBox1.Items.Clear();

                        while (reader.Read())
                        {
                            string codigo = reader[campoCodigo].ToString();
                            string nombre = reader[campoNombre].ToString();
                            listBox1.Items.Add(codigo + " - " + nombre);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
