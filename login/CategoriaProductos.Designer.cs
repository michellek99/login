namespace login
{
    partial class CategoriaProductos
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
            buttBuscar = new Button();
            buttEliminar = new Button();
            buttGuardar = new Button();
            buttNuevo = new Button();
            textNombre = new TextBox();
            labelNombre = new Label();
            labelCategoria = new Label();
            textCategoria = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelDescripcion = new Label();
            textDescripcion = new TextBox();
            buttModificar = new Button();
            SuspendLayout();
            // 
            // buttBuscar
            // 
            buttBuscar.BackColor = Color.FromArgb(0, 0, 64);
            buttBuscar.FlatAppearance.BorderSize = 0;
            buttBuscar.FlatStyle = FlatStyle.Flat;
            buttBuscar.ForeColor = SystemColors.ControlLightLight;
            buttBuscar.Location = new Point(615, 141);
            buttBuscar.Name = "buttBuscar";
            buttBuscar.Size = new Size(66, 25);
            buttBuscar.TabIndex = 40;
            buttBuscar.Text = "Buscar";
            buttBuscar.UseVisualStyleBackColor = false;
            buttBuscar.Click += buttBuscar_Click;
            // 
            // buttEliminar
            // 
            buttEliminar.BackColor = Color.FromArgb(0, 0, 64);
            buttEliminar.FlatAppearance.BorderSize = 0;
            buttEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            buttEliminar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            buttEliminar.FlatStyle = FlatStyle.Flat;
            buttEliminar.ForeColor = SystemColors.ControlLightLight;
            buttEliminar.Location = new Point(635, 464);
            buttEliminar.Name = "buttEliminar";
            buttEliminar.Size = new Size(116, 30);
            buttEliminar.TabIndex = 39;
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
            buttGuardar.Location = new Point(499, 464);
            buttGuardar.Name = "buttGuardar";
            buttGuardar.Size = new Size(116, 30);
            buttGuardar.TabIndex = 38;
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
            buttNuevo.Location = new Point(224, 464);
            buttNuevo.Name = "buttNuevo";
            buttNuevo.Size = new Size(116, 30);
            buttNuevo.TabIndex = 37;
            buttNuevo.Text = "Guardar";
            buttNuevo.UseVisualStyleBackColor = false;
            buttNuevo.Click += buttNuevo_Click;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(281, 212);
            textNombre.MaxLength = 25;
            textNombre.Name = "textNombre";
            textNombre.ShortcutsEnabled = false;
            textNombre.Size = new Size(309, 23);
            textNombre.TabIndex = 31;
            textNombre.KeyPress += textNombre_KeyPress;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = SystemColors.ControlLightLight;
            labelNombre.Location = new Point(178, 214);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(62, 17);
            labelNombre.TabIndex = 30;
            labelNombre.Text = "Nombre:";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategoria.ForeColor = SystemColors.ControlLightLight;
            labelCategoria.Location = new Point(140, 144);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(135, 17);
            labelCategoria.TabIndex = 27;
            labelCategoria.Text = "Código de Producto:";
            labelCategoria.Click += labelCategoria_Click;
            // 
            // textCategoria
            // 
            textCategoria.Location = new Point(281, 143);
            textCategoria.MaxLength = 15;
            textCategoria.Name = "textCategoria";
            textCategoria.ShortcutsEnabled = false;
            textCategoria.Size = new Size(309, 23);
            textCategoria.TabIndex = 26;
            textCategoria.TextChanged += textCategoria_TextChanged;
            textCategoria.KeyPress += textCategoria_KeyPress;
            textCategoria.PreviewKeyDown += textCategoria_PreviewKeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(384, 53);
            label3.Name = "label3";
            label3.Size = new Size(225, 24);
            label3.TabIndex = 25;
            label3.Text = "Categoría de Productos";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 115);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 46);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 23;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescripcion.ForeColor = SystemColors.ControlLightLight;
            labelDescripcion.Location = new Point(178, 284);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(84, 17);
            labelDescripcion.TabIndex = 32;
            labelDescripcion.Text = "Descripción:";
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(281, 283);
            textDescripcion.MaxLength = 50;
            textDescripcion.Multiline = true;
            textDescripcion.Name = "textDescripcion";
            textDescripcion.ShortcutsEnabled = false;
            textDescripcion.Size = new Size(470, 90);
            textDescripcion.TabIndex = 41;
            textDescripcion.KeyPress += textDescripcion_KeyPress;
            // 
            // buttModificar
            // 
            buttModificar.BackColor = Color.FromArgb(0, 0, 64);
            buttModificar.FlatAppearance.BorderSize = 0;
            buttModificar.FlatStyle = FlatStyle.Flat;
            buttModificar.ForeColor = SystemColors.ControlLightLight;
            buttModificar.Location = new Point(363, 464);
            buttModificar.Name = "buttModificar";
            buttModificar.Size = new Size(116, 30);
            buttModificar.TabIndex = 42;
            buttModificar.Text = "Modificar";
            buttModificar.UseVisualStyleBackColor = false;
            buttModificar.Click += buttModificar_Click;
            // 
            // CategoriaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(945, 526);
            Controls.Add(buttModificar);
            Controls.Add(textDescripcion);
            Controls.Add(buttBuscar);
            Controls.Add(buttEliminar);
            Controls.Add(buttGuardar);
            Controls.Add(buttNuevo);
            Controls.Add(labelDescripcion);
            Controls.Add(textNombre);
            Controls.Add(labelNombre);
            Controls.Add(labelCategoria);
            Controls.Add(textCategoria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "CategoriaProductos";
            Text = "CategoriaProductos";
            Load += CategoriaProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textDescripcion;
        private Button buttBuscar;
        private Button buttEliminar;
        private Button buttGuardar;
        private Button buttNuevo;
        private Label labelDescripcion;
        private TextBox textNombre;
        private Label labelNombre;
        private Label labelCategoria;
        private TextBox textCategoria;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttModificar;
    }
}