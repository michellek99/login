namespace login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            textuser = new TextBox();
            textpass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnlogin = new Button();
            btncerrar = new PictureBox();
            btnminimizar = new PictureBox();
            btnmaximizar = new PictureBox();
            btnrestaurar = new PictureBox();
            checkBoxMostrarContraseña = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnmaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnrestaurar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 340);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 89);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 150);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(471, 105);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 16);
            linkLabel1.TabIndex = 1;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(383, 128);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(0, 16);
            linkLabel2.TabIndex = 2;
            // 
            // textuser
            // 
            textuser.BackColor = Color.FromArgb(0, 0, 64);
            textuser.BorderStyle = BorderStyle.None;
            textuser.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textuser.ForeColor = SystemColors.InactiveBorder;
            textuser.Location = new Point(333, 124);
            textuser.Name = "textuser";
            textuser.Size = new Size(387, 15);
            textuser.TabIndex = 1;
            textuser.Text = "USUARIO";
            textuser.TextChanged += textuser_TextChanged;
            textuser.Enter += textuser_Enter;
            textuser.KeyPress += Letras_KeyPress;
            textuser.Leave += textuser_Leave;
            // 
            // textpass
            // 
            textpass.BackColor = Color.FromArgb(0, 0, 64);
            textpass.BorderStyle = BorderStyle.None;
            textpass.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textpass.ForeColor = SystemColors.InactiveBorder;
            textpass.Location = new Point(333, 184);
            textpass.Name = "textpass";
            textpass.Size = new Size(294, 15);
            textpass.TabIndex = 2;
            textpass.Text = "CONTRASEÑA";
            textpass.TextChanged += textpass_TextChanged;
            textpass.Enter += textpass_Enter;
            textpass.Leave += textpass_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(275, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 17);
            label1.TabIndex = 5;
            label1.Text = "BIENVENIDOS AL PROGRAMA DE INVENTARIO S.A.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(428, 44);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 6;
            label2.Text = "LOGIN";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(40, 40, 40);
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = SystemColors.ButtonHighlight;
            btnlogin.Location = new Point(333, 226);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(373, 40);
            btnlogin.TabIndex = 3;
            btnlogin.Text = "INGRESAR";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btncerrar
            // 
            btncerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(744, 8);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(25, 25);
            btncerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btncerrar.TabIndex = 9;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(683, 8);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(25, 25);
            btnminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizar.TabIndex = 10;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // btnmaximizar
            // 
            btnmaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnmaximizar.Image = (Image)resources.GetObject("btnmaximizar.Image");
            btnmaximizar.Location = new Point(712, 7);
            btnmaximizar.Name = "btnmaximizar";
            btnmaximizar.Size = new Size(25, 25);
            btnmaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnmaximizar.TabIndex = 11;
            btnmaximizar.TabStop = false;
            btnmaximizar.Click += btnmaximizar_Click;
            // 
            // btnrestaurar
            // 
            btnrestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnrestaurar.Image = (Image)resources.GetObject("btnrestaurar.Image");
            btnrestaurar.Location = new Point(712, 8);
            btnrestaurar.Name = "btnrestaurar";
            btnrestaurar.Size = new Size(25, 25);
            btnrestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnrestaurar.TabIndex = 12;
            btnrestaurar.TabStop = false;
            btnrestaurar.Visible = false;
            btnrestaurar.Click += btnrestaurar_Click;
            // 
            // checkBoxMostrarContraseña
            // 
            checkBoxMostrarContraseña.AutoSize = true;
            checkBoxMostrarContraseña.Location = new Point(659, 189);
            checkBoxMostrarContraseña.Name = "checkBoxMostrarContraseña";
            checkBoxMostrarContraseña.Size = new Size(15, 14);
            checkBoxMostrarContraseña.TabIndex = 13;
            checkBoxMostrarContraseña.UseVisualStyleBackColor = true;
            checkBoxMostrarContraseña.CheckedChanged += checkBoxMostrarContraseña_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(780, 340);
            Controls.Add(checkBoxMostrarContraseña);
            Controls.Add(btnrestaurar);
            Controls.Add(btnmaximizar);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(btnlogin);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textpass);
            Controls.Add(textuser);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnmaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnrestaurar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private TextBox textuser;
        private TextBox textpass;
        private Label label1;
        private Label label2;
        private Button btnlogin;
        private PictureBox btncerrar;
        private PictureBox btnminimizar;
        private PictureBox pictureBox3;
        private PictureBox btnmaximizar;
        private PictureBox btnrestaurar;
        private CheckBox checkBoxMostrarContraseña;
    }
}
