namespace login
{
    partial class Mantenimiento_de_Productos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textCodigo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textReferencia = new TextBox();
            label6 = new Label();
            textNombre = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboCategoria = new ComboBox();
            textPrecio = new TextBox();
            button1 = new Button();
            buttLimpiar = new Button();
            button3 = new Button();
            button4 = new Button();
            textPresentacion = new TextBox();
            label10 = new Label();
            comboMarca = new ComboBox();
            buttBuscar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 41);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 68);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(331, 9);
            label3.Name = "label3";
            label3.Size = new Size(267, 24);
            label3.TabIndex = 2;
            label3.Text = "Mantenimiento de Productos";
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(138, 96);
            textCodigo.MaxLength = 15;
            textCodigo.Name = "textCodigo";
            textCodigo.ShortcutsEnabled = false;
            textCodigo.Size = new Size(206, 23);
            textCodigo.TabIndex = 3;
            textCodigo.TextChanged += textCodigo_TextChanged;
            textCodigo.KeyPress += Numeros_KeyPress;
            textCodigo.PreviewKeyDown += textCodigo_PreviewKeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 97);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 4;
            label4.Text = "Código:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(458, 97);
            label5.Name = "label5";
            label5.Size = new Size(76, 17);
            label5.TabIndex = 5;
            label5.Text = "Referencia:";
            // 
            // textReferencia
            // 
            textReferencia.Location = new Point(565, 97);
            textReferencia.MaxLength = 15;
            textReferencia.Name = "textReferencia";
            textReferencia.ShortcutsEnabled = false;
            textReferencia.Size = new Size(280, 23);
            textReferencia.TabIndex = 6;
            textReferencia.KeyPress += textReferencia_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 166);
            label6.Name = "label6";
            label6.Size = new Size(62, 17);
            label6.TabIndex = 7;
            label6.Text = "Nombre:";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(138, 165);
            textNombre.MaxLength = 50;
            textNombre.Name = "textNombre";
            textNombre.ShortcutsEnabled = false;
            textNombre.Size = new Size(707, 23);
            textNombre.TabIndex = 8;
            textNombre.KeyPress += textNombre_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(35, 253);
            label7.Name = "label7";
            label7.Size = new Size(91, 17);
            label7.TabIndex = 9;
            label7.Text = "Presentación:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(35, 328);
            label8.Name = "label8";
            label8.Size = new Size(71, 17);
            label8.TabIndex = 10;
            label8.Text = "Categoría:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(458, 328);
            label9.Name = "label9";
            label9.Size = new Size(50, 17);
            label9.TabIndex = 11;
            label9.Text = "Precio:";
            label9.Click += label9_Click;
            // 
            // comboCategoria
            // 
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(138, 322);
            comboCategoria.MaxLength = 38;
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(280, 23);
            comboCategoria.TabIndex = 13;
            comboCategoria.SelectedIndexChanged += comboCategoria_SelectedIndexChanged;
            comboCategoria.KeyDown += comboCategoria_KeyDown;
            comboCategoria.KeyPress += comboCategoria_KeyPress;
            comboCategoria.KeyUp += comboCategoria_KeyUp;
            // 
            // textPrecio
            // 
            textPrecio.Location = new Point(565, 322);
            textPrecio.MaxLength = 6;
            textPrecio.Name = "textPrecio";
            textPrecio.ShortcutsEnabled = false;
            textPrecio.Size = new Size(280, 23);
            textPrecio.TabIndex = 15;
            textPrecio.KeyPress += textPrecio_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(138, 464);
            button1.Name = "button1";
            button1.Size = new Size(116, 30);
            button1.TabIndex = 16;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttLimpiar
            // 
            buttLimpiar.BackColor = Color.FromArgb(0, 0, 64);
            buttLimpiar.FlatAppearance.BorderSize = 0;
            buttLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            buttLimpiar.FlatAppearance.MouseOverBackColor = Color.Navy;
            buttLimpiar.FlatStyle = FlatStyle.Flat;
            buttLimpiar.Location = new Point(539, 464);
            buttLimpiar.Name = "buttLimpiar";
            buttLimpiar.Size = new Size(116, 30);
            buttLimpiar.TabIndex = 17;
            buttLimpiar.Text = "Limpiar";
            buttLimpiar.UseVisualStyleBackColor = false;
            buttLimpiar.Click += buttLimpiar_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 64);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            button3.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(729, 464);
            button3.Name = "button3";
            button3.Size = new Size(116, 30);
            button3.TabIndex = 18;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 0, 64);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            button4.FlatAppearance.MouseOverBackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(331, 464);
            button4.Name = "button4";
            button4.Size = new Size(116, 30);
            button4.TabIndex = 19;
            button4.Text = "Modificar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textPresentacion
            // 
            textPresentacion.Location = new Point(138, 247);
            textPresentacion.MaxLength = 15;
            textPresentacion.Name = "textPresentacion";
            textPresentacion.ShortcutsEnabled = false;
            textPresentacion.Size = new Size(707, 23);
            textPresentacion.TabIndex = 20;
            textPresentacion.KeyPress += textPresentacion_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(35, 395);
            label10.Name = "label10";
            label10.Size = new Size(49, 17);
            label10.TabIndex = 21;
            label10.Text = "Marca:";
            label10.Click += label10_Click;
            // 
            // comboMarca
            // 
            comboMarca.FormattingEnabled = true;
            comboMarca.Location = new Point(138, 395);
            comboMarca.MaxLength = 38;
            comboMarca.Name = "comboMarca";
            comboMarca.Size = new Size(280, 23);
            comboMarca.TabIndex = 22;
            comboMarca.KeyDown += comboMarca_KeyDown;
            comboMarca.KeyPress += comboMarca_KeyPress;
            comboMarca.KeyUp += comboMarca_KeyUp;
            // 
            // buttBuscar
            // 
            buttBuscar.BackColor = Color.FromArgb(0, 0, 64);
            buttBuscar.FlatAppearance.BorderSize = 0;
            buttBuscar.FlatStyle = FlatStyle.Flat;
            buttBuscar.ForeColor = SystemColors.ControlLightLight;
            buttBuscar.Location = new Point(352, 95);
            buttBuscar.Name = "buttBuscar";
            buttBuscar.Size = new Size(66, 25);
            buttBuscar.TabIndex = 60;
            buttBuscar.Text = "Buscar";
            buttBuscar.UseVisualStyleBackColor = false;
            buttBuscar.Click += buttBuscar_Click;
            // 
            // Mantenimiento_de_Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(946, 538);
            Controls.Add(buttBuscar);
            Controls.Add(comboMarca);
            Controls.Add(label10);
            Controls.Add(textPresentacion);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(buttLimpiar);
            Controls.Add(button1);
            Controls.Add(textPrecio);
            Controls.Add(comboCategoria);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textNombre);
            Controls.Add(label6);
            Controls.Add(textReferencia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textCodigo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mantenimiento_de_Productos";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Mantenimiento_de_Productos";
            Load += Mantenimiento_de_Productos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textCodigo;
        private Label label4;
        private Label label5;
        private TextBox textReferencia;
        private Label label6;
        private TextBox textNombre;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboCategoria;
        private ComboBox comboMarca;
        private TextBox textPrecio;
        private Button button1;
        private Button buttLimpiar;
        private Button button3;
        private Button button4;
        private TextBox textPresentacion;
        private Label label10;
        private PictureBox btncerrar;
        private PictureBox btnrestaurar;
        private PictureBox btnminimizar;
        private Button buttBuscar;
    }
}