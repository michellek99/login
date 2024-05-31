namespace login
{
    partial class MantenimientoMarca
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
            buttModificar = new Button();
            buttEliminar = new Button();
            buttGuardar = new Button();
            buttNuevo = new Button();
            textNombre = new TextBox();
            labelNombre = new Label();
            labelCodigo = new Label();
            textCodigo = new TextBox();
            labelTitulo = new Label();
            label2 = new Label();
            buttBuscar = new Button();
            SuspendLayout();
            // 
            // buttModificar
            // 
            buttModificar.BackColor = Color.FromArgb(0, 0, 64);
            buttModificar.FlatAppearance.BorderSize = 0;
            buttModificar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            buttModificar.FlatAppearance.MouseOverBackColor = Color.Navy;
            buttModificar.FlatStyle = FlatStyle.Flat;
            buttModificar.ForeColor = SystemColors.ControlLightLight;
            buttModificar.Location = new Point(377, 422);
            buttModificar.Name = "buttModificar";
            buttModificar.Size = new Size(116, 30);
            buttModificar.TabIndex = 52;
            buttModificar.Text = "Modificar";
            buttModificar.UseVisualStyleBackColor = false;
            buttModificar.Click += buttModificar_Click;
            // 
            // buttEliminar
            // 
            buttEliminar.BackColor = Color.FromArgb(0, 0, 64);
            buttEliminar.FlatAppearance.BorderSize = 0;
            buttEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            buttEliminar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            buttEliminar.FlatStyle = FlatStyle.Flat;
            buttEliminar.ForeColor = SystemColors.ControlLightLight;
            buttEliminar.Location = new Point(649, 422);
            buttEliminar.Name = "buttEliminar";
            buttEliminar.Size = new Size(116, 30);
            buttEliminar.TabIndex = 51;
            buttEliminar.Text = "Eliminar";
            buttEliminar.UseVisualStyleBackColor = false;
            buttEliminar.Click += buttEliminar_Click;
            // 
            // buttGuardar
            // 
            buttGuardar.BackColor = Color.FromArgb(0, 0, 64);
            buttGuardar.FlatAppearance.BorderSize = 0;
            buttGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            buttGuardar.FlatAppearance.MouseOverBackColor = Color.Navy;
            buttGuardar.FlatStyle = FlatStyle.Flat;
            buttGuardar.ForeColor = SystemColors.ControlLightLight;
            buttGuardar.Location = new Point(513, 422);
            buttGuardar.Name = "buttGuardar";
            buttGuardar.Size = new Size(116, 30);
            buttGuardar.TabIndex = 50;
            buttGuardar.Text = "Limpiar";
            buttGuardar.UseVisualStyleBackColor = false;
            buttGuardar.Click += buttGuardar_Click;
            // 
            // buttNuevo
            // 
            buttNuevo.BackColor = Color.FromArgb(0, 0, 64);
            buttNuevo.FlatAppearance.BorderSize = 0;
            buttNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            buttNuevo.FlatAppearance.MouseOverBackColor = Color.Navy;
            buttNuevo.FlatStyle = FlatStyle.Flat;
            buttNuevo.ForeColor = SystemColors.ControlLightLight;
            buttNuevo.Location = new Point(238, 422);
            buttNuevo.Name = "buttNuevo";
            buttNuevo.Size = new Size(116, 30);
            buttNuevo.TabIndex = 49;
            buttNuevo.Text = "Guardar";
            buttNuevo.UseVisualStyleBackColor = false;
            buttNuevo.Click += buttNuevo_Click;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(273, 273);
            textNombre.MaxLength = 25;
            textNombre.Name = "textNombre";
            textNombre.ShortcutsEnabled = false;
            textNombre.Size = new Size(470, 23);
            textNombre.TabIndex = 58;
            textNombre.KeyPress += textNombre_KeyPress;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = SystemColors.ControlLightLight;
            labelNombre.Location = new Point(170, 274);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(62, 17);
            labelNombre.TabIndex = 57;
            labelNombre.Text = "Nombre:";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCodigo.ForeColor = SystemColors.ControlLightLight;
            labelCodigo.Location = new Point(170, 205);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(56, 17);
            labelCodigo.TabIndex = 56;
            labelCodigo.Text = "Código:";
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(273, 204);
            textCodigo.MaxLength = 15;
            textCodigo.Name = "textCodigo";
            textCodigo.ShortcutsEnabled = false;
            textCodigo.Size = new Size(310, 23);
            textCodigo.TabIndex = 55;
            textCodigo.TextChanged += textCodigo_TextChanged;
            textCodigo.KeyPress += textCodigo_KeyPress;
            textCodigo.PreviewKeyDown += textCodigo_PreviewKeyDown;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold);
            labelTitulo.ForeColor = SystemColors.ButtonHighlight;
            labelTitulo.Location = new Point(376, 113);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(231, 24);
            labelTitulo.TabIndex = 54;
            labelTitulo.Text = "Mantenimiento de Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 175);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 53;
            // 
            // buttBuscar
            // 
            buttBuscar.BackColor = Color.FromArgb(0, 0, 64);
            buttBuscar.FlatAppearance.BorderSize = 0;
            buttBuscar.FlatStyle = FlatStyle.Flat;
            buttBuscar.ForeColor = SystemColors.ControlLightLight;
            buttBuscar.Location = new Point(610, 202);
            buttBuscar.Name = "buttBuscar";
            buttBuscar.Size = new Size(66, 25);
            buttBuscar.TabIndex = 59;
            buttBuscar.Text = "Buscar";
            buttBuscar.UseVisualStyleBackColor = false;
            buttBuscar.Click += buttBuscar_Click;
            // 
            // MantenimientoMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(945, 533);
            Controls.Add(buttBuscar);
            Controls.Add(textNombre);
            Controls.Add(labelNombre);
            Controls.Add(labelCodigo);
            Controls.Add(textCodigo);
            Controls.Add(labelTitulo);
            Controls.Add(label2);
            Controls.Add(buttModificar);
            Controls.Add(buttEliminar);
            Controls.Add(buttGuardar);
            Controls.Add(buttNuevo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "MantenimientoMarca";
            Text = "MantenimientoMarca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttModificar;
        private Button buttEliminar;
        private Button buttGuardar;
        private Button buttNuevo;
        private TextBox textNombre;
        private Label labelNombre;
        private Label labelCodigo;
        private TextBox textCodigo;
        private Label labelTitulo;
        private Label label2;
        private Button buttBuscar;
    }
}