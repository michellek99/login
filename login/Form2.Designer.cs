namespace login
{
    partial class Form2
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
            buttBuscar = new Button();
            dataGridView1 = new DataGridView();
            txtTotal = new TextBox();
            label5 = new Label();
            buttImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Location = new Point(310, 43);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 0;
            label1.Text = "CATALOGO DE PRODUCTOS";
            label1.Click += label1_Click;
            // 
            // buttBuscar
            // 
            buttBuscar.BackColor = Color.FromArgb(0, 0, 64);
            buttBuscar.FlatAppearance.BorderSize = 0;
            buttBuscar.FlatStyle = FlatStyle.Flat;
            buttBuscar.ForeColor = SystemColors.ControlLightLight;
            buttBuscar.Location = new Point(263, 84);
            buttBuscar.Name = "buttBuscar";
            buttBuscar.Size = new Size(101, 30);
            buttBuscar.TabIndex = 113;
            buttBuscar.Text = "Buscar";
            buttBuscar.UseVisualStyleBackColor = false;
            buttBuscar.Click += buttBuscar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView1.Location = new Point(32, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(736, 162);
            dataGridView1.TabIndex = 114;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(203, 343);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(245, 23);
            txtTotal.TabIndex = 125;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(45, 344);
            label5.Name = "label5";
            label5.Size = new Size(151, 17);
            label5.TabIndex = 124;
            label5.Text = "TOTAL DE PRODUCTOS";
            // 
            // buttImprimir
            // 
            buttImprimir.BackColor = Color.FromArgb(0, 0, 64);
            buttImprimir.FlatAppearance.BorderSize = 0;
            buttImprimir.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            buttImprimir.FlatAppearance.MouseOverBackColor = Color.Navy;
            buttImprimir.FlatStyle = FlatStyle.Flat;
            buttImprimir.ForeColor = SystemColors.ControlLightLight;
            buttImprimir.Location = new Point(459, 84);
            buttImprimir.Name = "buttImprimir";
            buttImprimir.Size = new Size(116, 30);
            buttImprimir.TabIndex = 126;
            buttImprimir.Text = "Imprimir";
            buttImprimir.UseVisualStyleBackColor = false;
            buttImprimir.Click += buttImprimir_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttImprimir);
            Controls.Add(txtTotal);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(buttBuscar);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttBuscar;
        private DataGridView dataGridView1;
        private TextBox txtTotal;
        private Label label5;
        private Button buttImprimir;
    }
}