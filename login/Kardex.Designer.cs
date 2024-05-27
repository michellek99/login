namespace login
{
    partial class Kardex
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
            dataGridView1 = new DataGridView();
            buttBuscar = new Button();
            labelCategoria = new Label();
            textCodigo = new TextBox();
            buttImprimir = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtpresentacion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEntrada = new TextBox();
            txtsalida = new TextBox();
            txtSaldo = new TextBox();
            btnlimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView1.Location = new Point(52, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(736, 162);
            dataGridView1.TabIndex = 109;
            // 
            // buttBuscar
            // 
            buttBuscar.BackColor = Color.FromArgb(0, 0, 64);
            buttBuscar.FlatAppearance.BorderSize = 0;
            buttBuscar.FlatStyle = FlatStyle.Flat;
            buttBuscar.ForeColor = SystemColors.ControlLightLight;
            buttBuscar.Location = new Point(169, 153);
            buttBuscar.Name = "buttBuscar";
            buttBuscar.Size = new Size(80, 30);
            buttBuscar.TabIndex = 112;
            buttBuscar.Text = "Buscar";
            buttBuscar.UseVisualStyleBackColor = false;
            buttBuscar.Click += buttBuscar_Click;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategoria.ForeColor = SystemColors.ControlLightLight;
            labelCategoria.Location = new Point(185, 92);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(56, 17);
            labelCategoria.TabIndex = 111;
            labelCategoria.Text = "Código:";
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(148, 112);
            textCodigo.MaxLength = 38;
            textCodigo.Name = "textCodigo";
            textCodigo.ShortcutsEnabled = false;
            textCodigo.Size = new Size(143, 23);
            textCodigo.TabIndex = 110;
            textCodigo.TextChanged += textCodigo_TextChanged;
            textCodigo.PreviewKeyDown += textCodigo_PreviewKeyDown;
            // 
            // buttImprimir
            // 
            buttImprimir.BackColor = Color.FromArgb(0, 0, 64);
            buttImprimir.FlatAppearance.BorderSize = 0;
            buttImprimir.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            buttImprimir.FlatAppearance.MouseOverBackColor = Color.Navy;
            buttImprimir.FlatStyle = FlatStyle.Flat;
            buttImprimir.ForeColor = SystemColors.ControlLightLight;
            buttImprimir.Location = new Point(312, 153);
            buttImprimir.Name = "buttImprimir";
            buttImprimir.Size = new Size(116, 30);
            buttImprimir.TabIndex = 113;
            buttImprimir.Text = "Imprimir";
            buttImprimir.UseVisualStyleBackColor = false;
            buttImprimir.Click += buttImprimir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(381, 28);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 114;
            label1.Text = "kardex";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(303, 112);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(192, 23);
            txtNombre.TabIndex = 115;
            // 
            // txtpresentacion
            // 
            txtpresentacion.Location = new Point(501, 113);
            txtpresentacion.Name = "txtpresentacion";
            txtpresentacion.Size = new Size(214, 23);
            txtpresentacion.TabIndex = 116;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(351, 92);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 117;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(501, 92);
            label3.Name = "label3";
            label3.Size = new Size(87, 17);
            label3.TabIndex = 118;
            label3.Text = "Presentación";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(439, 372);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 119;
            label4.Text = "TOTALES";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(444, 406);
            label5.Name = "label5";
            label5.Size = new Size(51, 17);
            label5.TabIndex = 120;
            label5.Text = "SALDO";
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(523, 371);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(114, 23);
            txtEntrada.TabIndex = 121;
            // 
            // txtsalida
            // 
            txtsalida.Location = new Point(654, 371);
            txtsalida.Name = "txtsalida";
            txtsalida.Size = new Size(114, 23);
            txtsalida.TabIndex = 122;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(523, 405);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(245, 23);
            txtSaldo.TabIndex = 123;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.FromArgb(0, 0, 64);
            btnlimpiar.FlatAppearance.BorderSize = 0;
            btnlimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            btnlimpiar.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.ForeColor = SystemColors.ControlLightLight;
            btnlimpiar.Location = new Point(478, 153);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(116, 30);
            btnlimpiar.TabIndex = 124;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // Kardex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(855, 466);
            Controls.Add(btnlimpiar);
            Controls.Add(txtSaldo);
            Controls.Add(txtsalida);
            Controls.Add(txtEntrada);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtpresentacion);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(buttImprimir);
            Controls.Add(buttBuscar);
            Controls.Add(labelCategoria);
            Controls.Add(textCodigo);
            Controls.Add(dataGridView1);
            Name = "Kardex";
            Text = "Kardex";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttBuscar;
        private Label labelCategoria;
        private TextBox textCodigo;
        private Button buttImprimir;
        private Label label1;
        private TextBox txtNombre;
        private TextBox textBox1;
        private TextBox txtpresentacion;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEntrada;
        private TextBox txtsalida;
        private TextBox txtSaldo;
        private Button btnlimpiar;
    }
}