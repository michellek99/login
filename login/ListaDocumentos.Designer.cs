namespace login
{
    partial class ListaDocumentos
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
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, -1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(233, 409);
            listBox1.TabIndex = 1;
            // 
            // ListaDocumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 410);
            Controls.Add(listBox1);
            Name = "ListaDocumentos";
            Text = "ListaDocumentos";
            Load += ListaDocumentos_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
    }
}