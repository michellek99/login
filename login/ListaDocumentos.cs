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
    public partial class ListaDocumentos : Form
    {
        public event Action<string> DocumentoSeleccionado;

        private static ListaDocumentos instanciaActual;
        //private ListBox listBox1 = new ListBox();
        public ListaDocumentos(string tipoDocumento)
        {
            InitializeComponent();

            CargarDatosEnListBox(tipoDocumento);

            // Registro de los manejadores de eventos
            this.listBox1.DoubleClick += new EventHandler(this.listBox1_DoubleClick);
            this.listBox1.KeyDown += new KeyEventHandler(this.listBox1_KeyDown);

            // Cerrar la instancia anterior si ya existe
            if (instanciaActual != null && !instanciaActual.IsDisposed)
            {
                instanciaActual.Close();
            }

            // Establecer esta instancia como la actual
            instanciaActual = this;

            // Evento de cierre para limpiar la referencia estática
            this.FormClosed += new FormClosedEventHandler(this.ListaDocumentos_FormClosed);
        }


        private void ListaDocumentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Limpiar la referencia estática cuando el formulario se cierre
            if (instanciaActual == this)
            {
                instanciaActual = null;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            SeleccionarDocumento();
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionarDocumento();
                // Evitar el sonido de "ding" que ocurre al presionar Enter
                e.SuppressKeyPress = true;
            }
        }

        private void SeleccionarDocumento()
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                string[] parts = selectedItem.Split('-');
                string codigo = parts[0].Trim();

                DocumentoSeleccionado?.Invoke(codigo);

                this.Close();
            }
        }

        public void CargarDatosEnListBox(string tipoDocumento)
        {
            if (ConexionBD.Conex.State != ConnectionState.Open)
            {
                MessageBox.Show("La conexión a la base de datos no está abierta.");
                return;
            }

            try
            {
                string query = @"
                SELECT DISTINCT i.NO_DOCUMENTO, d.OBSERVACION
                FROM INVENTARIO i
                JOIN DETALLE_INVENTARIO d ON i.NO_DOCUMENTO = d.NO_DOCUMENTO
                WHERE i.TIPO_DOCUMENTO = :tipoDocumento";

                using (OracleCommand command = new OracleCommand(query, ConexionBD.Conex))
                {
                    command.Parameters.Add(new OracleParameter("tipoDocumento", tipoDocumento));

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        listBox1.Items.Clear();

                        while (reader.Read())
                        {
                            string noDocumento = reader["NO_DOCUMENTO"].ToString();
                            string observacion = reader["OBSERVACION"].ToString();
                            listBox1.Items.Add(noDocumento + " - " + observacion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }


    private void ListaDocumentos_Load(object sender, EventArgs e)
        {

        }
    }
}
