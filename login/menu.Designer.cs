using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    partial class menu
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(menu));
            panelSideMenu = new Panel();
            panelConfigSubMenu = new Panel();
            button5 = new Button();
            button14 = new Button();
            btnConfiguracion = new Button();
            panelReportesSubMenu = new Panel();
            btnKardex = new Button();
            btnRExistencias = new Button();
            btnStocks = new Button();
            btnRICatalogos = new Button();
            panelProcesosSubMenu = new Panel();
            btnSInventario = new Button();
            btnEinventario = new Button();
            btnProcesos = new Button();
            panelCatalogosSubMenu = new Panel();
            btnMMarca = new Button();
            btnCProdutos = new Button();
            btnMProductos = new Button();
            btnCatalogos = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panelcontenedorForm = new Panel();
            panelSideMenu.SuspendLayout();
            panelConfigSubMenu.SuspendLayout();
            panelReportesSubMenu.SuspendLayout();
            panelProcesosSubMenu.SuspendLayout();
            panelCatalogosSubMenu.SuspendLayout();
            panel3.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(0, 0, 64);
            panelSideMenu.Controls.Add(panelConfigSubMenu);
            panelSideMenu.Controls.Add(btnConfiguracion);
            panelSideMenu.Controls.Add(panelReportesSubMenu);
            panelSideMenu.Controls.Add(btnRICatalogos);
            panelSideMenu.Controls.Add(panelProcesosSubMenu);
            panelSideMenu.Controls.Add(btnProcesos);
            panelSideMenu.Controls.Add(panelCatalogosSubMenu);
            panelSideMenu.Controls.Add(btnCatalogos);
            panelSideMenu.Controls.Add(panel3);
            panelSideMenu.Controls.Add(panel1);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Margin = new Padding(3, 2, 3, 2);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(234, 621);
            panelSideMenu.TabIndex = 0;
            // 
            // panelConfigSubMenu
            // 
            panelConfigSubMenu.BackColor = Color.Navy;
            panelConfigSubMenu.Controls.Add(button5);
            panelConfigSubMenu.Controls.Add(button14);
            panelConfigSubMenu.Dock = DockStyle.Top;
            panelConfigSubMenu.Location = new Point(0, 538);
            panelConfigSubMenu.Margin = new Padding(3, 2, 3, 2);
            panelConfigSubMenu.Name = "panelConfigSubMenu";
            panelConfigSubMenu.Size = new Size(234, 72);
            panelConfigSubMenu.TabIndex = 9;
            // 
            // button5
            // 
            button5.BackColor = Color.Navy;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(0, 31);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Padding = new Padding(31, 0, 0, 0);
            button5.Size = new Size(234, 31);
            button5.TabIndex = 1;
            button5.Text = "Reporte de Usuarios";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button14
            // 
            button14.Dock = DockStyle.Top;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.ForeColor = SystemColors.ControlLightLight;
            button14.Location = new Point(0, 0);
            button14.Margin = new Padding(3, 2, 3, 2);
            button14.Name = "button14";
            button14.Padding = new Padding(31, 0, 0, 0);
            button14.Size = new Size(234, 31);
            button14.TabIndex = 0;
            button14.Text = "Usuarios";
            button14.TextAlign = ContentAlignment.MiddleLeft;
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Dock = DockStyle.Top;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.ForeColor = SystemColors.ControlLightLight;
            btnConfiguracion.Location = new Point(0, 508);
            btnConfiguracion.Margin = new Padding(3, 2, 3, 2);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Padding = new Padding(9, 0, 0, 0);
            btnConfiguracion.Size = new Size(234, 30);
            btnConfiguracion.TabIndex = 8;
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // panelReportesSubMenu
            // 
            panelReportesSubMenu.BackColor = Color.Navy;
            panelReportesSubMenu.Controls.Add(btnKardex);
            panelReportesSubMenu.Controls.Add(btnRExistencias);
            panelReportesSubMenu.Controls.Add(btnStocks);
            panelReportesSubMenu.Dock = DockStyle.Top;
            panelReportesSubMenu.Location = new Point(0, 406);
            panelReportesSubMenu.Margin = new Padding(3, 2, 3, 2);
            panelReportesSubMenu.Name = "panelReportesSubMenu";
            panelReportesSubMenu.Size = new Size(234, 102);
            panelReportesSubMenu.TabIndex = 7;
            // 
            // btnKardex
            // 
            btnKardex.Dock = DockStyle.Top;
            btnKardex.FlatAppearance.BorderSize = 0;
            btnKardex.FlatStyle = FlatStyle.Flat;
            btnKardex.ForeColor = SystemColors.ControlLightLight;
            btnKardex.Location = new Point(0, 62);
            btnKardex.Margin = new Padding(3, 2, 3, 2);
            btnKardex.Name = "btnKardex";
            btnKardex.Padding = new Padding(31, 0, 0, 0);
            btnKardex.Size = new Size(234, 31);
            btnKardex.TabIndex = 2;
            btnKardex.Text = "Kardex";
            btnKardex.TextAlign = ContentAlignment.MiddleLeft;
            btnKardex.UseVisualStyleBackColor = true;
            btnKardex.Click += btnKardex_Click;
            // 
            // btnRExistencias
            // 
            btnRExistencias.Dock = DockStyle.Top;
            btnRExistencias.FlatAppearance.BorderSize = 0;
            btnRExistencias.FlatStyle = FlatStyle.Flat;
            btnRExistencias.ForeColor = SystemColors.ControlLightLight;
            btnRExistencias.Location = new Point(0, 31);
            btnRExistencias.Margin = new Padding(3, 2, 3, 2);
            btnRExistencias.Name = "btnRExistencias";
            btnRExistencias.Padding = new Padding(31, 0, 0, 0);
            btnRExistencias.Size = new Size(234, 31);
            btnRExistencias.TabIndex = 1;
            btnRExistencias.Text = "Reporte de Usuarios";
            btnRExistencias.TextAlign = ContentAlignment.MiddleLeft;
            btnRExistencias.UseVisualStyleBackColor = true;
            btnRExistencias.Click += btnRExistencias_Click;
            // 
            // btnStocks
            // 
            btnStocks.Dock = DockStyle.Top;
            btnStocks.FlatAppearance.BorderSize = 0;
            btnStocks.FlatStyle = FlatStyle.Flat;
            btnStocks.ForeColor = SystemColors.ControlLightLight;
            btnStocks.Location = new Point(0, 0);
            btnStocks.Margin = new Padding(3, 2, 3, 2);
            btnStocks.Name = "btnStocks";
            btnStocks.Padding = new Padding(31, 0, 0, 0);
            btnStocks.Size = new Size(234, 31);
            btnStocks.TabIndex = 0;
            btnStocks.Text = "Reporte de Productos";
            btnStocks.TextAlign = ContentAlignment.MiddleLeft;
            btnStocks.UseVisualStyleBackColor = true;
            btnStocks.Click += btnStocks_Click;
            // 
            // btnRICatalogos
            // 
            btnRICatalogos.Dock = DockStyle.Top;
            btnRICatalogos.FlatAppearance.BorderSize = 0;
            btnRICatalogos.FlatStyle = FlatStyle.Flat;
            btnRICatalogos.ForeColor = SystemColors.ControlLightLight;
            btnRICatalogos.Location = new Point(0, 376);
            btnRICatalogos.Margin = new Padding(3, 2, 3, 2);
            btnRICatalogos.Name = "btnRICatalogos";
            btnRICatalogos.Padding = new Padding(9, 0, 0, 0);
            btnRICatalogos.Size = new Size(234, 30);
            btnRICatalogos.TabIndex = 6;
            btnRICatalogos.Text = "Reportes de Invetario";
            btnRICatalogos.TextAlign = ContentAlignment.MiddleLeft;
            btnRICatalogos.UseVisualStyleBackColor = true;
            btnRICatalogos.Click += btnRICatalogos_Click;
            // 
            // panelProcesosSubMenu
            // 
            panelProcesosSubMenu.BackColor = Color.Navy;
            panelProcesosSubMenu.Controls.Add(btnSInventario);
            panelProcesosSubMenu.Controls.Add(btnEinventario);
            panelProcesosSubMenu.Dock = DockStyle.Top;
            panelProcesosSubMenu.Location = new Point(0, 304);
            panelProcesosSubMenu.Margin = new Padding(3, 2, 3, 2);
            panelProcesosSubMenu.Name = "panelProcesosSubMenu";
            panelProcesosSubMenu.Size = new Size(234, 72);
            panelProcesosSubMenu.TabIndex = 5;
            // 
            // btnSInventario
            // 
            btnSInventario.Dock = DockStyle.Top;
            btnSInventario.FlatAppearance.BorderSize = 0;
            btnSInventario.FlatStyle = FlatStyle.Flat;
            btnSInventario.ForeColor = SystemColors.ControlLightLight;
            btnSInventario.Location = new Point(0, 31);
            btnSInventario.Margin = new Padding(3, 2, 3, 2);
            btnSInventario.Name = "btnSInventario";
            btnSInventario.Padding = new Padding(31, 0, 0, 0);
            btnSInventario.Size = new Size(234, 31);
            btnSInventario.TabIndex = 1;
            btnSInventario.Text = "Salidas del Inventario";
            btnSInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnSInventario.UseVisualStyleBackColor = true;
            btnSInventario.Click += btnSInventario_Click;
            // 
            // btnEinventario
            // 
            btnEinventario.Dock = DockStyle.Top;
            btnEinventario.FlatAppearance.BorderSize = 0;
            btnEinventario.FlatStyle = FlatStyle.Flat;
            btnEinventario.ForeColor = SystemColors.ControlLightLight;
            btnEinventario.Location = new Point(0, 0);
            btnEinventario.Margin = new Padding(3, 2, 3, 2);
            btnEinventario.Name = "btnEinventario";
            btnEinventario.Padding = new Padding(31, 0, 0, 0);
            btnEinventario.Size = new Size(234, 31);
            btnEinventario.TabIndex = 0;
            btnEinventario.Text = "Entradas del Inventario";
            btnEinventario.TextAlign = ContentAlignment.MiddleLeft;
            btnEinventario.UseVisualStyleBackColor = true;
            btnEinventario.Click += btnEinventario_Click;
            // 
            // btnProcesos
            // 
            btnProcesos.Dock = DockStyle.Top;
            btnProcesos.FlatAppearance.BorderSize = 0;
            btnProcesos.FlatStyle = FlatStyle.Flat;
            btnProcesos.ForeColor = SystemColors.ControlLightLight;
            btnProcesos.Location = new Point(0, 274);
            btnProcesos.Margin = new Padding(3, 2, 3, 2);
            btnProcesos.Name = "btnProcesos";
            btnProcesos.Padding = new Padding(9, 0, 0, 0);
            btnProcesos.Size = new Size(234, 30);
            btnProcesos.TabIndex = 4;
            btnProcesos.Text = "Procesos";
            btnProcesos.TextAlign = ContentAlignment.MiddleLeft;
            btnProcesos.UseVisualStyleBackColor = true;
            btnProcesos.Click += btnProcesos_Click;
            // 
            // panelCatalogosSubMenu
            // 
            panelCatalogosSubMenu.BackColor = Color.Navy;
            panelCatalogosSubMenu.Controls.Add(btnMMarca);
            panelCatalogosSubMenu.Controls.Add(btnCProdutos);
            panelCatalogosSubMenu.Controls.Add(btnMProductos);
            panelCatalogosSubMenu.Dock = DockStyle.Top;
            panelCatalogosSubMenu.Location = new Point(0, 172);
            panelCatalogosSubMenu.Margin = new Padding(3, 2, 3, 2);
            panelCatalogosSubMenu.Name = "panelCatalogosSubMenu";
            panelCatalogosSubMenu.Size = new Size(234, 102);
            panelCatalogosSubMenu.TabIndex = 3;
            // 
            // btnMMarca
            // 
            btnMMarca.Dock = DockStyle.Top;
            btnMMarca.FlatAppearance.BorderSize = 0;
            btnMMarca.FlatStyle = FlatStyle.Flat;
            btnMMarca.ForeColor = SystemColors.ControlLightLight;
            btnMMarca.Location = new Point(0, 62);
            btnMMarca.Margin = new Padding(3, 2, 3, 2);
            btnMMarca.Name = "btnMMarca";
            btnMMarca.Padding = new Padding(31, 0, 0, 0);
            btnMMarca.Size = new Size(234, 31);
            btnMMarca.TabIndex = 2;
            btnMMarca.Text = "Mantenimiento de Marca";
            btnMMarca.TextAlign = ContentAlignment.MiddleLeft;
            btnMMarca.UseVisualStyleBackColor = true;
            btnMMarca.Click += btnMMarca_Click;
            // 
            // btnCProdutos
            // 
            btnCProdutos.Dock = DockStyle.Top;
            btnCProdutos.FlatAppearance.BorderSize = 0;
            btnCProdutos.FlatStyle = FlatStyle.Flat;
            btnCProdutos.ForeColor = SystemColors.ControlLightLight;
            btnCProdutos.Location = new Point(0, 31);
            btnCProdutos.Margin = new Padding(3, 2, 3, 2);
            btnCProdutos.Name = "btnCProdutos";
            btnCProdutos.Padding = new Padding(31, 0, 0, 0);
            btnCProdutos.Size = new Size(234, 31);
            btnCProdutos.TabIndex = 1;
            btnCProdutos.Text = "Categoría de Productos";
            btnCProdutos.TextAlign = ContentAlignment.MiddleLeft;
            btnCProdutos.UseVisualStyleBackColor = true;
            btnCProdutos.Click += btnCProdutos_Click;
            // 
            // btnMProductos
            // 
            btnMProductos.Dock = DockStyle.Top;
            btnMProductos.FlatAppearance.BorderSize = 0;
            btnMProductos.FlatStyle = FlatStyle.Flat;
            btnMProductos.ForeColor = SystemColors.ControlLightLight;
            btnMProductos.Location = new Point(0, 0);
            btnMProductos.Margin = new Padding(3, 2, 3, 2);
            btnMProductos.Name = "btnMProductos";
            btnMProductos.Padding = new Padding(31, 0, 0, 0);
            btnMProductos.Size = new Size(234, 31);
            btnMProductos.TabIndex = 0;
            btnMProductos.Text = "Mantenimiento de Productos";
            btnMProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnMProductos.UseVisualStyleBackColor = true;
            btnMProductos.Click += btnMProductos_Click;
            // 
            // btnCatalogos
            // 
            btnCatalogos.Dock = DockStyle.Top;
            btnCatalogos.FlatAppearance.BorderSize = 0;
            btnCatalogos.FlatStyle = FlatStyle.Flat;
            btnCatalogos.ForeColor = SystemColors.ControlLightLight;
            btnCatalogos.Location = new Point(0, 142);
            btnCatalogos.Margin = new Padding(3, 2, 3, 2);
            btnCatalogos.Name = "btnCatalogos";
            btnCatalogos.Padding = new Padding(9, 0, 0, 0);
            btnCatalogos.Size = new Size(234, 30);
            btnCatalogos.TabIndex = 2;
            btnCatalogos.Text = "Catálogos";
            btnCatalogos.TextAlign = ContentAlignment.MiddleLeft;
            btnCatalogos.UseVisualStyleBackColor = true;
            btnCatalogos.Click += btnCatalogos_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 26);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 116);
            panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 26);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(234, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(946, 26);
            panel2.TabIndex = 1;
            // 
            // panelcontenedorForm
            // 
            panelcontenedorForm.AutoSize = true;
            panelcontenedorForm.Dock = DockStyle.Fill;
            panelcontenedorForm.Location = new Point(234, 26);
            panelcontenedorForm.Margin = new Padding(3, 2, 3, 2);
            panelcontenedorForm.Name = "panelcontenedorForm";
            panelcontenedorForm.Size = new Size(946, 595);
            panelcontenedorForm.TabIndex = 2;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1180, 621);
            Controls.Add(panelcontenedorForm);
            Controls.Add(panel2);
            Controls.Add(panelSideMenu);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(833, 460);
            Name = "menu";
            Text = "menu";
            panelSideMenu.ResumeLayout(false);
            panelConfigSubMenu.ResumeLayout(false);
            panelReportesSubMenu.ResumeLayout(false);
            panelProcesosSubMenu.ResumeLayout(false);
            panelCatalogosSubMenu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Panel panelCatalogosSubMenu;
        private Button button2;
        private Button btnCatalogos;
        private Button button4;
        private Button button3;
        private Panel panelConfigSubMenu;
        private Button button14;
        private Button button15;
        private Panel panelReportesSubMenu;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Panel panelProcesosSubMenu;
        private Button button1;
        private Button btnSInventario;
        private Button btnEinventario;
        private Button btnProcesos;
        private PictureBox pictureBox1;
        private Panel panelcontenedorForm;
        private Button button5;
    }
}