namespace login
{
    partial class ConfiguracionUsuarios
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
            EMP_CODIGO = new TextBox();
            label2 = new Label();
            label4 = new Label();
            Nombres = new TextBox();
            label7 = new Label();
            label8 = new Label();
            Contrasena = new TextBox();
            buttImprimir = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            No_Identificacion = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Apellidos = new TextBox();
            label9 = new Label();
            Direccion = new TextBox();
            button4 = new Button();
            label10 = new Label();
            checkBoxMostrarContraseña = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(364, 20);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 0;
            label1.Text = "Usuarios ";
            label1.Click += label1_Click;
            // 
            // EMP_CODIGO
            // 
            EMP_CODIGO.AcceptsReturn = true;
            EMP_CODIGO.Location = new Point(179, 99);
            EMP_CODIGO.MaxLength = 8;
            EMP_CODIGO.Name = "EMP_CODIGO";
            EMP_CODIGO.ShortcutsEnabled = false;
            EMP_CODIGO.Size = new Size(221, 23);
            EMP_CODIGO.TabIndex = 1;
            EMP_CODIGO.TextChanged += Numeros_TextChanged;
            EMP_CODIGO.KeyPress += Numeros_KeyPress;
            EMP_CODIGO.KeyUp += EMP_CODIGO_KeyUp;
            EMP_CODIGO.PreviewKeyDown += EMP_CODIGO_PreviewKeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(9, 97);
            label2.Name = "label2";
            label2.Size = new Size(173, 21);
            label2.TabIndex = 2;
            label2.Text = "Código de empleado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(8, 154);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 5;
            label4.Text = "Nombre:";
            // 
            // Nombres
            // 
            Nombres.Location = new Point(179, 157);
            Nombres.MaxLength = 35;
            Nombres.Name = "Nombres";
            Nombres.ShortcutsEnabled = false;
            Nombres.Size = new Size(221, 23);
            Nombres.TabIndex = 6;
            Nombres.TextChanged += Numeros_TextChanged;
            Nombres.KeyPress += Letras_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(7, 270);
            label7.Name = "label7";
            label7.Size = new Size(0, 21);
            label7.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(423, 218);
            label8.Name = "label8";
            label8.Size = new Size(100, 21);
            label8.TabIndex = 12;
            label8.Text = "Contraseña:";
            label8.Click += label8_Click;
            // 
            // Contrasena
            // 
            Contrasena.Location = new Point(547, 214);
            Contrasena.MaxLength = 14;
            Contrasena.Name = "Contrasena";
            Contrasena.ShortcutsEnabled = false;
            Contrasena.Size = new Size(221, 23);
            Contrasena.TabIndex = 13;
            Contrasena.TextChanged += Contrasena_TextChanged;
            // 
            // buttImprimir
            // 
            buttImprimir.BackColor = Color.FromArgb(0, 0, 64);
            buttImprimir.FlatAppearance.BorderSize = 0;
            buttImprimir.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            buttImprimir.FlatAppearance.MouseOverBackColor = Color.Navy;
            buttImprimir.FlatStyle = FlatStyle.Flat;
            buttImprimir.ForeColor = SystemColors.ControlLightLight;
            buttImprimir.Location = new Point(498, 378);
            buttImprimir.Name = "buttImprimir";
            buttImprimir.Size = new Size(116, 30);
            buttImprimir.TabIndex = 51;
            buttImprimir.Text = "Limpiar";
            buttImprimir.UseVisualStyleBackColor = false;
            buttImprimir.Click += buttImprimir_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(189, 378);
            button1.Name = "button1";
            button1.Size = new Size(116, 30);
            button1.TabIndex = 52;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            button2.FlatAppearance.MouseOverBackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(652, 378);
            button2.Name = "button2";
            button2.Size = new Size(116, 30);
            button2.TabIndex = 53;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 64);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            button3.FlatAppearance.MouseOverBackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(345, 378);
            button3.Name = "button3";
            button3.Size = new Size(116, 30);
            button3.TabIndex = 54;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // No_Identificacion
            // 
            No_Identificacion.Location = new Point(179, 218);
            No_Identificacion.MaxLength = 13;
            No_Identificacion.Name = "No_Identificacion";
            No_Identificacion.ShortcutsEnabled = false;
            No_Identificacion.Size = new Size(221, 23);
            No_Identificacion.TabIndex = 8;
            No_Identificacion.TextChanged += No_Identificacion_TextChanged;
            No_Identificacion.KeyPress += Numeros_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(10, 216);
            label5.Name = "label5";
            label5.Size = new Size(131, 21);
            label5.TabIndex = 7;
            label5.Text = "Número de DPI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(423, 159);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 55;
            label6.Text = "Apellido:";
            // 
            // Apellidos
            // 
            Apellidos.Location = new Point(547, 159);
            Apellidos.MaxLength = 35;
            Apellidos.Name = "Apellidos";
            Apellidos.ShortcutsEnabled = false;
            Apellidos.Size = new Size(221, 23);
            Apellidos.TabIndex = 56;
            Apellidos.KeyPress += Letras_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(13, 270);
            label9.Name = "label9";
            label9.Size = new Size(87, 21);
            label9.TabIndex = 57;
            label9.Text = "Dirección:";
            // 
            // Direccion
            // 
            Direccion.Location = new Point(179, 281);
            Direccion.MaxLength = 50;
            Direccion.Name = "Direccion";
            Direccion.ShortcutsEnabled = false;
            Direccion.Size = new Size(589, 23);
            Direccion.TabIndex = 58;
            Direccion.KeyPress += Direccion_KeyPress;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 0, 64);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            button4.FlatAppearance.MouseOverBackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(430, 94);
            button4.Name = "button4";
            button4.Size = new Size(116, 30);
            button4.TabIndex = 61;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(430, 218);
            label10.Name = "label10";
            label10.Size = new Size(0, 21);
            label10.TabIndex = 59;
            label10.Click += label10_Click;
            // 
            // checkBoxMostrarContraseña
            // 
            checkBoxMostrarContraseña.AutoSize = true;
            checkBoxMostrarContraseña.Location = new Point(749, 218);
            checkBoxMostrarContraseña.Name = "checkBoxMostrarContraseña";
            checkBoxMostrarContraseña.Size = new Size(15, 14);
            checkBoxMostrarContraseña.TabIndex = 62;
            checkBoxMostrarContraseña.UseVisualStyleBackColor = true;
            checkBoxMostrarContraseña.CheckedChanged += checkBoxMostrarContraseña_CheckedChanged;
            // 
            // ConfiguracionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(833, 481);
            Controls.Add(checkBoxMostrarContraseña);
            Controls.Add(button4);
            Controls.Add(label10);
            Controls.Add(Direccion);
            Controls.Add(label9);
            Controls.Add(Apellidos);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttImprimir);
            Controls.Add(Contrasena);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(No_Identificacion);
            Controls.Add(label5);
            Controls.Add(Nombres);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(EMP_CODIGO);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfiguracionUsuarios";
            Text = "ConfiguracionUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        //private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private ComboBox comboBox2;
        private Label label7;
        private Label label8;
        private TextBox textBox4;
        private Button buttImprimir;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox6;
        private Button button4;
        private TextBox Codigo;
        private TextBox EMP_CODIGO;
        private TextBox Nombres;
        private TextBox Apellidos;
        private TextBox Direccion;
        private TextBox No_Identificacion;
        private TextBox Contrasena;
        private Label label10;
        private CheckBox checkBoxMostrarContraseña;
    }
}