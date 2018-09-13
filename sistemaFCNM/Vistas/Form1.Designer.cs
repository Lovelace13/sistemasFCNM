namespace sistemaFCNM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPantalla = new System.Windows.Forms.Button();
            this.btnCpu = new System.Windows.Forms.Button();
            this.btnScanner = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabScanner = new System.Windows.Forms.TabPage();
            this.tabCpu = new System.Windows.Forms.TabPage();
            this.tmOcultarMenu = new System.Windows.Forms.Timer(this.components);
            this.tmMostrarMenu = new System.Windows.Forms.Timer(this.components);
            this.panelCabecera.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.Goldenrod;
            this.panelCabecera.Controls.Add(this.btnRestaurar);
            this.panelCabecera.Controls.Add(this.btnMinimizar);
            this.panelCabecera.Controls.Add(this.btnMaximizar);
            this.panelCabecera.Controls.Add(this.btnCerrar);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1100, 40);
            this.panelCabecera.TabIndex = 0;
            this.panelCabecera.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCabecera_Paint);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = global::sistemaFCNM.Properties.Resources.Icono_Restaurar;
            this.btnRestaurar.Location = new System.Drawing.Point(1025, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(40, 40);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::sistemaFCNM.Properties.Resources.Icono_Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(990, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::sistemaFCNM.Properties.Resources.Icono_Maximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(1025, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(40, 40);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::sistemaFCNM.Properties.Resources.Icono_cerrar_FN;
            this.btnCerrar.Location = new System.Drawing.Point(1060, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelMenu.Controls.Add(this.btnPantalla);
            this.panelMenu.Controls.Add(this.btnCpu);
            this.panelMenu.Controls.Add(this.btnScanner);
            this.panelMenu.Controls.Add(this.pictureBox4);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Cornsilk;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 540);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnPantalla
            // 
            this.btnPantalla.AutoEllipsis = true;
            this.btnPantalla.FlatAppearance.BorderSize = 0;
            this.btnPantalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPantalla.Image = global::sistemaFCNM.Properties.Resources.imac_off;
            this.btnPantalla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPantalla.Location = new System.Drawing.Point(10, 312);
            this.btnPantalla.Name = "btnPantalla";
            this.btnPantalla.Size = new System.Drawing.Size(200, 50);
            this.btnPantalla.TabIndex = 7;
            this.btnPantalla.Text = "Pantalla";
            this.btnPantalla.UseVisualStyleBackColor = true;
            // 
            // btnCpu
            // 
            this.btnCpu.AutoEllipsis = true;
            this.btnCpu.FlatAppearance.BorderSize = 0;
            this.btnCpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCpu.Image = global::sistemaFCNM.Properties.Resources.Dell_4600c_copy;
            this.btnCpu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCpu.Location = new System.Drawing.Point(10, 245);
            this.btnCpu.Name = "btnCpu";
            this.btnCpu.Size = new System.Drawing.Size(200, 50);
            this.btnCpu.TabIndex = 6;
            this.btnCpu.Text = "CPU";
            this.btnCpu.UseVisualStyleBackColor = true;
            this.btnCpu.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnScanner
            // 
            this.btnScanner.AutoEllipsis = true;
            this.btnScanner.FlatAppearance.BorderSize = 0;
            this.btnScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanner.Image = global::sistemaFCNM.Properties.Resources.scanner11;
            this.btnScanner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanner.Location = new System.Drawing.Point(12, 189);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(200, 50);
            this.btnScanner.TabIndex = 5;
            this.btnScanner.Text = "  Scanear Codigo";
            this.btnScanner.UseVisualStyleBackColor = true;
            this.btnScanner.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.Gold;
            this.pictureBox4.Image = global::sistemaFCNM.Properties.Resources.logo_fcnm;
            this.pictureBox4.Location = new System.Drawing.Point(1, 105);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(217, 78);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.Image = global::sistemaFCNM.Properties.Resources.Mobile_Menu_Icon;
            this.btnMenu.Location = new System.Drawing.Point(177, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 36);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.tabControl);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 40);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(880, 540);
            this.panelContenedor.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabScanner);
            this.tabControl.Controls.Add(this.tabCpu);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(880, 537);
            this.tabControl.TabIndex = 0;
            // 
            // tabScanner
            // 
            this.tabScanner.Location = new System.Drawing.Point(4, 22);
            this.tabScanner.Name = "tabScanner";
            this.tabScanner.Padding = new System.Windows.Forms.Padding(3);
            this.tabScanner.Size = new System.Drawing.Size(872, 511);
            this.tabScanner.TabIndex = 0;
            this.tabScanner.Text = "Scanner";
            this.tabScanner.UseVisualStyleBackColor = true;
            this.tabScanner.Click += new System.EventHandler(this.tabScanner_Click);
            // 
            // tabCpu
            // 
            this.tabCpu.Location = new System.Drawing.Point(4, 22);
            this.tabCpu.Name = "tabCpu";
            this.tabCpu.Padding = new System.Windows.Forms.Padding(3);
            this.tabCpu.Size = new System.Drawing.Size(872, 511);
            this.tabCpu.TabIndex = 1;
            this.tabCpu.Text = "CPU";
            this.tabCpu.UseVisualStyleBackColor = true;
            this.tabCpu.Click += new System.EventHandler(this.tabCpu_Click);
            // 
            // tmOcultarMenu
            // 
            this.tmOcultarMenu.Tick += new System.EventHandler(this.tmOcultarMenu_Tick);
            // 
            // tmMostrarMenu
            // 
            this.tmMostrarMenu.Tick += new System.EventHandler(this.tmMostrarMenu_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 580);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelCabecera.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Timer tmOcultarMenu;
        private System.Windows.Forms.Timer tmMostrarMenu;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnScanner;
        private System.Windows.Forms.Button btnCpu;
        private System.Windows.Forms.Button btnPantalla;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabScanner;
        private System.Windows.Forms.TabPage tabCpu;
    }
}

