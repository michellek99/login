namespace login
{
    partial class SalidaInvenario
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
            label3 = new Label();
            label2 = new Label();
            label12 = new Label();
            textUsuario = new TextBox();
            textSubTotal = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            buttInsertar = new Button();
            buttBuscar = new Button();
            textTotal = new TextBox();
            label10 = new Label();
            textCantidad2 = new TextBox();
            label11 = new Label();
            label9 = new Label();
            textNoDoc = new TextBox();
            label8 = new Label();
            textFecha = new TextBox();
            textCosto = new TextBox();
            label7 = new Label();
            textCantidad = new TextBox();
            label5 = new Label();
            textExistencia = new TextBox();
            label4 = new Label();
            textObservacion = new TextBox();
            label1 = new Label();
            buttNuevo = new Button();
            buttEliminar = new Button();
            buttLimpiar = new Button();
            buttImprimir = new Button();
            textDescripcion = new TextBox();
            labelNombre = new Label();
            labelCategoria = new Label();
            textCodigo = new TextBox();
            buttBuscarDoc = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(325, 14);
            label3.Name = "label3";
            label3.Size = new Size(197, 24);
            label3.TabIndex = 45;
            label3.Text = "Salida del Inventario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 26);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 79;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(494, 62);
            label12.Name = "label12";
            label12.Size = new Size(124, 17);
            label12.TabIndex = 112;
            label12.Text = "Buscar Documento";
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(624, 60);
            textUsuario.MaxLength = 15;
            textUsuario.Name = "textUsuario";
            textUsuario.ShortcutsEnabled = false;
            textUsuario.Size = new Size(121, 23);
            textUsuario.TabIndex = 111;
            textUsuario.KeyPress += textUsuario_KeyPress;
            textUsuario.PreviewKeyDown += textUsuario_PreviewKeyDown;
            // 
            // textSubTotal
            // 
            textSubTotal.Enabled = false;
            textSubTotal.Location = new Point(641, 170);
            textSubTotal.MaxLength = 25;
            textSubTotal.Name = "textSubTotal";
            textSubTotal.ShortcutsEnabled = false;
            textSubTotal.Size = new Size(81, 23);
            textSubTotal.TabIndex = 110;
            textSubTotal.KeyPress += textSubTotal_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(569, 171);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 109;
            label6.Text = "SubTotal:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(68, 212);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(736, 162);
            dataGridView1.TabIndex = 108;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttInsertar
            // 
            buttInsertar.BackColor = Color.FromArgb(0, 0, 64);
            buttInsertar.FlatAppearance.BorderSize = 0;
            buttInsertar.FlatStyle = FlatStyle.Flat;
            buttInsertar.ForeColor = SystemColors.ControlLightLight;
            buttInsertar.Location = new Point(738, 168);
            buttInsertar.Name = "buttInsertar";
            buttInsertar.Size = new Size(66, 25);
            buttInsertar.TabIndex = 107;
            buttInsertar.Text = "Insertar";
            buttInsertar.UseVisualStyleBackColor = false;
            buttInsertar.Click += buttInsertar_Click_1;
            // 
            // buttBuscar
            // 
            buttBuscar.BackColor = Color.FromArgb(0, 0, 64);
            buttBuscar.FlatAppearance.BorderSize = 0;
            buttBuscar.FlatStyle = FlatStyle.Flat;
            buttBuscar.ForeColor = SystemColors.ControlLightLight;
            buttBuscar.Location = new Point(279, 118);
            buttBuscar.Name = "buttBuscar";
            buttBuscar.Size = new Size(66, 25);
            buttBuscar.TabIndex = 106;
            buttBuscar.Text = "Buscar";
            buttBuscar.UseVisualStyleBackColor = false;
            buttBuscar.Click += buttBuscar_Click;
            // 
            // textTotal
            // 
            textTotal.Enabled = false;
            textTotal.Location = new Point(723, 391);
            textTotal.MaxLength = 25;
            textTotal.Name = "textTotal";
            textTotal.ShortcutsEnabled = false;
            textTotal.Size = new Size(81, 23);
            textTotal.TabIndex = 105;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(674, 391);
            label10.Name = "label10";
            label10.Size = new Size(43, 17);
            label10.TabIndex = 104;
            label10.Text = "Total:";
            // 
            // textCantidad2
            // 
            textCantidad2.Enabled = false;
            textCantidad2.Location = new Point(565, 392);
            textCantidad2.MaxLength = 25;
            textCantidad2.Name = "textCantidad2";
            textCantidad2.ShortcutsEnabled = false;
            textCantidad2.Size = new Size(81, 23);
            textCantidad2.TabIndex = 103;
            textCantidad2.KeyPress += textCantidad2_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(492, 393);
            label11.Name = "label11";
            label11.Size = new Size(67, 17);
            label11.TabIndex = 102;
            label11.Text = "Cantidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(207, 61);
            label9.Name = "label9";
            label9.Size = new Size(110, 17);
            label9.TabIndex = 101;
            label9.Text = "No. Documento:";
            // 
            // textNoDoc
            // 
            textNoDoc.Enabled = false;
            textNoDoc.Location = new Point(330, 60);
            textNoDoc.MaxLength = 38;
            textNoDoc.Name = "textNoDoc";
            textNoDoc.ShortcutsEnabled = false;
            textNoDoc.Size = new Size(152, 23);
            textNoDoc.TabIndex = 100;
            textNoDoc.TextChanged += textNoDoc_TextChanged;
            textNoDoc.PreviewKeyDown += textNoDoc_PreviewKeyDown_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(68, 60);
            label8.Name = "label8";
            label8.Size = new Size(47, 17);
            label8.TabIndex = 99;
            label8.Text = "Fecha:";
            // 
            // textFecha
            // 
            textFecha.Enabled = false;
            textFecha.Location = new Point(121, 60);
            textFecha.MaxLength = 10;
            textFecha.Name = "textFecha";
            textFecha.ReadOnly = true;
            textFecha.ShortcutsEnabled = false;
            textFecha.Size = new Size(80, 23);
            textFecha.TabIndex = 98;
            textFecha.TextChanged += textFecha_TextChanged;
            // 
            // textCosto
            // 
            textCosto.Enabled = false;
            textCosto.Location = new Point(457, 168);
            textCosto.MaxLength = 25;
            textCosto.Name = "textCosto";
            textCosto.ShortcutsEnabled = false;
            textCosto.Size = new Size(81, 23);
            textCosto.TabIndex = 97;
            textCosto.KeyPress += textCosto_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(404, 169);
            label7.Name = "label7";
            label7.Size = new Size(47, 17);
            label7.TabIndex = 96;
            label7.Text = "Costo:";
            // 
            // textCantidad
            // 
            textCantidad.Location = new Point(312, 169);
            textCantidad.MaxLength = 25;
            textCantidad.Name = "textCantidad";
            textCantidad.ShortcutsEnabled = false;
            textCantidad.Size = new Size(66, 23);
            textCantidad.TabIndex = 95;
            textCantidad.TextChanged += textCantidad_TextChanged_1;
            textCantidad.KeyPress += textCantidad_KeyPress_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(239, 170);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 94;
            label5.Text = "Cantidad:";
            // 
            // textExistencia
            // 
            textExistencia.Enabled = false;
            textExistencia.Location = new Point(152, 170);
            textExistencia.MaxLength = 25;
            textExistencia.Name = "textExistencia";
            textExistencia.ShortcutsEnabled = false;
            textExistencia.Size = new Size(66, 23);
            textExistencia.TabIndex = 93;
            textExistencia.KeyPress += textExistencia_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(67, 171);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 92;
            label4.Text = "Existencias:";
            // 
            // textObservacion
            // 
            textObservacion.Location = new Point(176, 392);
            textObservacion.MaxLength = 50;
            textObservacion.Name = "textObservacion";
            textObservacion.ShortcutsEnabled = false;
            textObservacion.Size = new Size(292, 23);
            textObservacion.TabIndex = 91;
            textObservacion.KeyPress += textObservacion_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(68, 393);
            label1.Name = "label1";
            label1.Size = new Size(102, 17);
            label1.TabIndex = 90;
            label1.Text = "Observaciones:";
            // 
            // buttNuevo
            // 
            buttNuevo.BackColor = Color.FromArgb(0, 0, 64);
            buttNuevo.FlatAppearance.BorderSize = 0;
            buttNuevo.FlatStyle = FlatStyle.Flat;
            buttNuevo.ForeColor = SystemColors.ControlLightLight;
            buttNuevo.Location = new Point(334, 435);
            buttNuevo.Name = "buttNuevo";
            buttNuevo.Size = new Size(116, 30);
            buttNuevo.TabIndex = 89;
            buttNuevo.Text = "Nuevo";
            buttNuevo.UseVisualStyleBackColor = false;
            buttNuevo.Click += buttNuevo_Click_1;
            // 
            // buttEliminar
            // 
            buttEliminar.BackColor = Color.FromArgb(0, 0, 64);
            buttEliminar.FlatAppearance.BorderSize = 0;
            buttEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            buttEliminar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            buttEliminar.FlatStyle = FlatStyle.Flat;
            buttEliminar.ForeColor = SystemColors.ControlLightLight;
            buttEliminar.Location = new Point(606, 435);
            buttEliminar.Name = "buttEliminar";
            buttEliminar.Size = new Size(116, 30);
            buttEliminar.TabIndex = 88;
            buttEliminar.Text = "Eliminar";
            buttEliminar.UseVisualStyleBackColor = false;
            buttEliminar.Click += buttEliminar_Click_1;
            // 
            // buttLimpiar
            // 
            buttLimpiar.BackColor = Color.FromArgb(0, 0, 64);
            buttLimpiar.FlatAppearance.BorderSize = 0;
            buttLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            buttLimpiar.FlatAppearance.MouseOverBackColor = Color.Navy;
            buttLimpiar.FlatStyle = FlatStyle.Flat;
            buttLimpiar.ForeColor = SystemColors.ControlLightLight;
            buttLimpiar.Location = new Point(470, 435);
            buttLimpiar.Name = "buttLimpiar";
            buttLimpiar.Size = new Size(116, 30);
            buttLimpiar.TabIndex = 87;
            buttLimpiar.Text = "Limpiar";
            buttLimpiar.UseVisualStyleBackColor = false;
            buttLimpiar.Click += buttLimpiar_Click;
            // 
            // buttImprimir
            // 
            buttImprimir.BackColor = Color.FromArgb(0, 0, 64);
            buttImprimir.FlatAppearance.BorderSize = 0;
            buttImprimir.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            buttImprimir.FlatAppearance.MouseOverBackColor = Color.Navy;
            buttImprimir.FlatStyle = FlatStyle.Flat;
            buttImprimir.ForeColor = SystemColors.ControlLightLight;
            buttImprimir.Location = new Point(195, 435);
            buttImprimir.Name = "buttImprimir";
            buttImprimir.Size = new Size(116, 30);
            buttImprimir.TabIndex = 86;
            buttImprimir.Text = "Imprimir";
            buttImprimir.UseVisualStyleBackColor = false;
            buttImprimir.Click += buttImprimir_Click;
            // 
            // textDescripcion
            // 
            textDescripcion.Enabled = false;
            textDescripcion.Location = new Point(448, 120);
            textDescripcion.MaxLength = 50;
            textDescripcion.Name = "textDescripcion";
            textDescripcion.ShortcutsEnabled = false;
            textDescripcion.Size = new Size(356, 23);
            textDescripcion.TabIndex = 85;
            textDescripcion.TextChanged += textDescripcion_TextChanged;
            textDescripcion.KeyPress += textDescripcion_KeyPress;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = SystemColors.ControlLightLight;
            labelNombre.Location = new Point(358, 120);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(84, 17);
            labelNombre.TabIndex = 84;
            labelNombre.Text = "Descripción:";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategoria.ForeColor = SystemColors.ControlLightLight;
            labelCategoria.Location = new Point(66, 121);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(56, 17);
            labelCategoria.TabIndex = 83;
            labelCategoria.Text = "Código:";
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(130, 120);
            textCodigo.MaxLength = 15;
            textCodigo.Name = "textCodigo";
            textCodigo.ShortcutsEnabled = false;
            textCodigo.Size = new Size(143, 23);
            textCodigo.TabIndex = 82;
            textCodigo.TextChanged += textCodigo_TextChanged;
            textCodigo.KeyPress += textCodigo_KeyPress;
            textCodigo.PreviewKeyDown += textCodigo_PreviewKeyDown_1;
            // 
            // buttBuscarDoc
            // 
            buttBuscarDoc.BackColor = Color.FromArgb(0, 0, 64);
            buttBuscarDoc.FlatAppearance.BorderSize = 0;
            buttBuscarDoc.FlatStyle = FlatStyle.Flat;
            buttBuscarDoc.ForeColor = SystemColors.ControlLightLight;
            buttBuscarDoc.Location = new Point(751, 59);
            buttBuscarDoc.Name = "buttBuscarDoc";
            buttBuscarDoc.Size = new Size(66, 25);
            buttBuscarDoc.TabIndex = 113;
            buttBuscarDoc.Text = "Buscar";
            buttBuscarDoc.UseVisualStyleBackColor = false;
            buttBuscarDoc.Click += buttBuscarDoc_Click;
            // 
            // SalidaInvenario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(930, 499);
            Controls.Add(buttBuscarDoc);
            Controls.Add(label12);
            Controls.Add(textUsuario);
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
            Controls.Add(label2);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalidaInvenario";
            Text = "MA";
            Load += SalidaInvenario_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label12;
        private TextBox textUsuario;
        private TextBox textSubTotal;
        private Label label6;
        private DataGridView dataGridView1;
        private Button buttInsertar;
        private Button buttBuscar;
        private TextBox textTotal;
        private Label label10;
        private TextBox textCantidad2;
        private Label label11;
        private Label label9;
        private TextBox textNoDoc;
        private Label label8;
        private TextBox textFecha;
        private TextBox textCosto;
        private Label label7;
        private TextBox textCantidad;
        private Label label5;
        private TextBox textExistencia;
        private Label label4;
        private TextBox textObservacion;
        private Label label1;
        private Button buttNuevo;
        private Button buttEliminar;
        private Button buttLimpiar;
        private Button buttImprimir;
        private TextBox textDescripcion;
        private Label labelNombre;
        private Label labelCategoria;
        private TextBox textCodigo;
        private Button buttBuscarDoc;
    }
}