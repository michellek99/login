namespace login
{
    partial class EntradaInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttNuevo = new Button();
            buttEliminar = new Button();
            buttLimpiar = new Button();
            buttImprimir = new Button();
            textDescripcion = new TextBox();
            labelNombre = new Label();
            labelCategoria = new Label();
            textCodigo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textObservacion = new TextBox();
            label1 = new Label();
            textExistencia = new TextBox();
            label4 = new Label();
            textCantidad = new TextBox();
            label5 = new Label();
            textCosto = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textFecha = new TextBox();
            label9 = new Label();
            textNoDoc = new TextBox();
            textTotal = new TextBox();
            label10 = new Label();
            textCantidad2 = new TextBox();
            label11 = new Label();
            buttBuscar = new Button();
            buttInsertar = new Button();
            dataGridView1 = new DataGridView();
            textSubTotal = new TextBox();
            label6 = new Label();
            label12 = new Label();
            textBuscarDoc = new TextBox();
            label13 = new Label();
            buttBuscarDoc = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttNuevo
            // 
            buttNuevo.BackColor = Color.FromArgb(0, 0, 64);
            buttNuevo.FlatAppearance.BorderSize = 0;
            buttNuevo.FlatStyle = FlatStyle.Flat;
            buttNuevo.ForeColor = SystemColors.ControlLightLight;
            buttNuevo.Location = new Point(366, 464);
            buttNuevo.Name = "buttNuevo";
            buttNuevo.Size = new Size(116, 30);
            buttNuevo.TabIndex = 55;
            buttNuevo.Text = "Nuevo";
            buttNuevo.UseVisualStyleBackColor = false;
            buttNuevo.Click += buttNuevo_Click;
            // 
            // buttEliminar
            // 
            buttEliminar.BackColor = Color.FromArgb(0, 0, 64);
            buttEliminar.FlatAppearance.BorderSize = 0;
            buttEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            buttEliminar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            buttEliminar.FlatStyle = FlatStyle.Flat;
            buttEliminar.ForeColor = SystemColors.ControlLightLight;
            buttEliminar.Location = new Point(638, 464);
            buttEliminar.Name = "buttEliminar";
            buttEliminar.Size = new Size(116, 30);
            buttEliminar.TabIndex = 52;
            buttEliminar.Text = "Eliminar";
            buttEliminar.UseVisualStyleBackColor = false;
            buttEliminar.Click += buttEliminar_Click;
            // 
            // buttLimpiar
            // 
            buttLimpiar.BackColor = Color.FromArgb(0, 0, 64);
            buttLimpiar.FlatAppearance.BorderSize = 0;
            buttLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            buttLimpiar.FlatAppearance.MouseOverBackColor = Color.Navy;
            buttLimpiar.FlatStyle = FlatStyle.Flat;
            buttLimpiar.ForeColor = SystemColors.ControlLightLight;
            buttLimpiar.Location = new Point(502, 464);
            buttLimpiar.Name = "buttLimpiar";
            buttLimpiar.Size = new Size(116, 30);
            buttLimpiar.TabIndex = 51;
            buttLimpiar.Text = "Limpiar";
            buttLimpiar.UseVisualStyleBackColor = false;
            buttLimpiar.Click += buttGuardar_Click;
            // 
            // buttImprimir
            // 
            buttImprimir.BackColor = Color.FromArgb(0, 0, 64);
            buttImprimir.FlatAppearance.BorderSize = 0;
            buttImprimir.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            buttImprimir.FlatAppearance.MouseOverBackColor = Color.Navy;
            buttImprimir.FlatStyle = FlatStyle.Flat;
            buttImprimir.ForeColor = SystemColors.ControlLightLight;
            buttImprimir.Location = new Point(227, 464);
            buttImprimir.Name = "buttImprimir";
            buttImprimir.Size = new Size(116, 30);
            buttImprimir.TabIndex = 50;
            buttImprimir.Text = "Imprimir";
            buttImprimir.UseVisualStyleBackColor = false;
            buttImprimir.Click += buttImprimir_Click;
            // 
            // textDescripcion
            // 
            textDescripcion.Enabled = false;
            textDescripcion.Location = new Point(480, 149);
            textDescripcion.MaxLength = 50;
            textDescripcion.Name = "textDescripcion";
            textDescripcion.ReadOnly = true;
            textDescripcion.ShortcutsEnabled = false;
            textDescripcion.Size = new Size(356, 23);
            textDescripcion.TabIndex = 48;
            textDescripcion.KeyPress += textDescripcion_KeyPress;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = SystemColors.ControlLightLight;
            labelNombre.Location = new Point(390, 149);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(84, 17);
            labelNombre.TabIndex = 47;
            labelNombre.Text = "Descripción:";
            labelNombre.Click += labelNombre_Click;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategoria.ForeColor = SystemColors.ControlLightLight;
            labelCategoria.Location = new Point(98, 150);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(56, 17);
            labelCategoria.TabIndex = 46;
            labelCategoria.Text = "Código:";
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(162, 149);
            textCodigo.MaxLength = 15;
            textCodigo.Name = "textCodigo";
            textCodigo.ShortcutsEnabled = false;
            textCodigo.Size = new Size(143, 23);
            textCodigo.TabIndex = 45;
            textCodigo.TextChanged += textCodigo_TextChanged;
            textCodigo.KeyDown += textCodigo_KeyDown;
            textCodigo.KeyPress += textCodigo_KeyPress;
            textCodigo.PreviewKeyDown += textCodigo_PreviewKeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(364, 20);
            label3.Name = "label3";
            label3.Size = new Size(206, 24);
            label3.TabIndex = 44;
            label3.Text = "Entrada de Inventario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 68);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 43;
            // 
            // textObservacion
            // 
            textObservacion.Location = new Point(208, 392);
            textObservacion.MaxLength = 50;
            textObservacion.Name = "textObservacion";
            textObservacion.ShortcutsEnabled = false;
            textObservacion.Size = new Size(292, 23);
            textObservacion.TabIndex = 57;
            textObservacion.KeyPress += textObservacion_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(100, 393);
            label1.Name = "label1";
            label1.Size = new Size(102, 17);
            label1.TabIndex = 56;
            label1.Text = "Observaciones:";
            // 
            // textExistencia
            // 
            textExistencia.Enabled = false;
            textExistencia.Location = new Point(184, 199);
            textExistencia.MaxLength = 25;
            textExistencia.Name = "textExistencia";
            textExistencia.ReadOnly = true;
            textExistencia.ShortcutsEnabled = false;
            textExistencia.Size = new Size(66, 23);
            textExistencia.TabIndex = 59;
            textExistencia.KeyPress += textExistencia_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(99, 200);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 58;
            label4.Text = "Existencias:";
            // 
            // textCantidad
            // 
            textCantidad.Location = new Point(344, 198);
            textCantidad.MaxLength = 25;
            textCantidad.Name = "textCantidad";
            textCantidad.ShortcutsEnabled = false;
            textCantidad.Size = new Size(66, 23);
            textCantidad.TabIndex = 61;
            textCantidad.TextChanged += textCantidad_TextChanged;
            textCantidad.KeyPress += textCantidad_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(271, 199);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 60;
            label5.Text = "Cantidad:";
            // 
            // textCosto
            // 
            textCosto.Enabled = false;
            textCosto.Location = new Point(489, 197);
            textCosto.MaxLength = 25;
            textCosto.Name = "textCosto";
            textCosto.ReadOnly = true;
            textCosto.ShortcutsEnabled = false;
            textCosto.Size = new Size(81, 23);
            textCosto.TabIndex = 63;
            textCosto.TextAlignChanged += textCosto_TextAlignChanged;
            textCosto.TextChanged += textCosto_TextChanged;
            textCosto.KeyPress += textCosto_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(436, 198);
            label7.Name = "label7";
            label7.Size = new Size(47, 17);
            label7.TabIndex = 62;
            label7.Text = "Costo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(100, 100);
            label8.Name = "label8";
            label8.Size = new Size(47, 17);
            label8.TabIndex = 67;
            label8.Text = "Fecha:";
            // 
            // textFecha
            // 
            textFecha.Enabled = false;
            textFecha.Location = new Point(153, 100);
            textFecha.Name = "textFecha";
            textFecha.ReadOnly = true;
            textFecha.ShortcutsEnabled = false;
            textFecha.Size = new Size(80, 23);
            textFecha.TabIndex = 66;
            textFecha.TextChanged += textFecha_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(250, 100);
            label9.Name = "label9";
            label9.Size = new Size(110, 17);
            label9.TabIndex = 69;
            label9.Text = "No. Documento:";
            // 
            // textNoDoc
            // 
            textNoDoc.Enabled = false;
            textNoDoc.Location = new Point(366, 99);
            textNoDoc.Name = "textNoDoc";
            textNoDoc.ShortcutsEnabled = false;
            textNoDoc.Size = new Size(82, 23);
            textNoDoc.TabIndex = 68;
            textNoDoc.TextChanged += textNoDoc_TextChanged;
            textNoDoc.PreviewKeyDown += textNoDoc_PreviewKeyDown;
            // 
            // textTotal
            // 
            textTotal.Enabled = false;
            textTotal.Location = new Point(755, 391);
            textTotal.MaxLength = 25;
            textTotal.Name = "textTotal";
            textTotal.ReadOnly = true;
            textTotal.Size = new Size(81, 23);
            textTotal.TabIndex = 73;
            textTotal.KeyPress += textTotal_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(706, 391);
            label10.Name = "label10";
            label10.Size = new Size(43, 17);
            label10.TabIndex = 72;
            label10.Text = "Total:";
            // 
            // textCantidad2
            // 
            textCantidad2.Enabled = false;
            textCantidad2.Location = new Point(597, 392);
            textCantidad2.MaxLength = 25;
            textCantidad2.Name = "textCantidad2";
            textCantidad2.ReadOnly = true;
            textCantidad2.Size = new Size(81, 23);
            textCantidad2.TabIndex = 71;
            textCantidad2.KeyPress += textCantidad2_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(524, 393);
            label11.Name = "label11";
            label11.Size = new Size(67, 17);
            label11.TabIndex = 70;
            label11.Text = "Cantidad:";
            // 
            // buttBuscar
            // 
            buttBuscar.BackColor = Color.FromArgb(0, 0, 64);
            buttBuscar.FlatAppearance.BorderSize = 0;
            buttBuscar.FlatStyle = FlatStyle.Flat;
            buttBuscar.ForeColor = SystemColors.ControlLightLight;
            buttBuscar.Location = new Point(311, 147);
            buttBuscar.Name = "buttBuscar";
            buttBuscar.Size = new Size(66, 25);
            buttBuscar.TabIndex = 74;
            buttBuscar.Text = "Buscar";
            buttBuscar.UseVisualStyleBackColor = false;
            buttBuscar.Click += buttBuscar_Click;
            // 
            // buttInsertar
            // 
            buttInsertar.BackColor = SystemColors.ControlLightLight;
            buttInsertar.FlatAppearance.BorderSize = 0;
            buttInsertar.FlatStyle = FlatStyle.Flat;
            buttInsertar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttInsertar.ForeColor = Color.FromArgb(0, 0, 64);
            buttInsertar.Location = new Point(770, 197);
            buttInsertar.Name = "buttInsertar";
            buttInsertar.Size = new Size(66, 25);
            buttInsertar.TabIndex = 75;
            buttInsertar.Text = "Insertar";
            buttInsertar.UseVisualStyleBackColor = false;
            buttInsertar.Click += buttInsertar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(100, 241);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(736, 127);
            dataGridView1.TabIndex = 76;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textSubTotal
            // 
            textSubTotal.Enabled = false;
            textSubTotal.Location = new Point(673, 199);
            textSubTotal.MaxLength = 25;
            textSubTotal.Name = "textSubTotal";
            textSubTotal.ReadOnly = true;
            textSubTotal.Size = new Size(81, 23);
            textSubTotal.TabIndex = 78;
            textSubTotal.KeyPress += textSubTotal_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(601, 200);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 77;
            label6.Text = "SubTotal:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(472, 102);
            label12.Name = "label12";
            label12.Size = new Size(128, 17);
            label12.TabIndex = 81;
            label12.Text = "Buscar Documento:";
            // 
            // textBuscarDoc
            // 
            textBuscarDoc.Location = new Point(602, 100);
            textBuscarDoc.MaxLength = 15;
            textBuscarDoc.Name = "textBuscarDoc";
            textBuscarDoc.ShortcutsEnabled = false;
            textBuscarDoc.Size = new Size(152, 23);
            textBuscarDoc.TabIndex = 80;
            textBuscarDoc.TextChanged += textUsuario_TextChanged;
            textBuscarDoc.KeyPress += textBuscarDoc_KeyPress;
            textBuscarDoc.PreviewKeyDown += textBuscarDoc_PreviewKeyDown;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(644, 69);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 79;
            // 
            // buttBuscarDoc
            // 
            buttBuscarDoc.BackColor = Color.FromArgb(0, 0, 64);
            buttBuscarDoc.FlatAppearance.BorderSize = 0;
            buttBuscarDoc.FlatStyle = FlatStyle.Flat;
            buttBuscarDoc.ForeColor = SystemColors.ControlLightLight;
            buttBuscarDoc.Location = new Point(770, 97);
            buttBuscarDoc.Name = "buttBuscarDoc";
            buttBuscarDoc.Size = new Size(66, 25);
            buttBuscarDoc.TabIndex = 82;
            buttBuscarDoc.Text = "Buscar";
            buttBuscarDoc.UseVisualStyleBackColor = false;
            buttBuscarDoc.Click += buttBuscarDoc_Click;
            // 
            // EntradaInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(946, 538);
            Controls.Add(buttBuscarDoc);
            Controls.Add(label12);
            Controls.Add(textBuscarDoc);
            Controls.Add(label13);
            Controls.Add(textSubTotal);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(buttInsertar);
            Controls.Add(buttBuscar);
            Controls.Add(textTotal);
            Controls.Add(label10);
            Controls.Add(textCantidad2);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(textNoDoc);
            Controls.Add(label8);
            Controls.Add(textFecha);
            Controls.Add(textCosto);
            Controls.Add(label7);
            Controls.Add(textCantidad);
            Controls.Add(label5);
            Controls.Add(textExistencia);
            Controls.Add(label4);
            Controls.Add(textObservacion);
            Controls.Add(label1);
            Controls.Add(buttNuevo);
            Controls.Add(buttEliminar);
            Controls.Add(buttLimpiar);
            Controls.Add(buttImprimir);
            Controls.Add(textDescripcion);
            Controls.Add(labelNombre);
            Controls.Add(labelCategoria);
            Controls.Add(textCodigo);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EntradaInventario";
            Text = "EntradaInventario";
            Load += EntradaInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttNuevo;
        private Button buttEliminar;
        private Button buttLimpiar;
        private Button buttImprimir;
        private TextBox textDescripcion;
        private Label labelNombre;
        private Label labelCategoria;
        private TextBox textCodigo;
        private Label label3;
        private Label label2;
        private TextBox textObservacion;
        private Label label1;
        private TextBox textExistencia;
        private Label label4;
        private TextBox textCantidad;
        private Label label5;
        private TextBox textCosto;
        private Label label7;
        private Label label8;
        private TextBox textFecha;
        private Label label9;
        private TextBox textNoDoc;
        private TextBox textTotal;
        private Label label10;
        private TextBox textCantidad2;
        private Label label11;
        private Button buttBuscar;
        private Button buttInsertar;
        private DataGridView dataGridView1;
        private TextBox textSubTotal;
        private Label label6;
        private Label label12;
        private TextBox textBuscarDoc;
        private Label label13;
        private Button buttBuscarDoc;
    }
}