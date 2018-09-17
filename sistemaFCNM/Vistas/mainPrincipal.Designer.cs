namespace sistemaFCNM
{
    partial class mainPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPrincipal));
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.imgLogoBig = new System.Windows.Forms.PictureBox();
            this.btnRadio = new System.Windows.Forms.Button();
            this.btnPproyeccion = new System.Windows.Forms.Button();
            this.btnTelefono = new System.Windows.Forms.Button();
            this.btnMicro = new System.Windows.Forms.Button();
            this.btnParlante = new System.Windows.Forms.Button();
            this.btnImpresora = new System.Windows.Forms.Button();
            this.btnProyector = new System.Windows.Forms.Button();
            this.btnRegulador = new System.Windows.Forms.Button();
            this.btnMouse = new System.Windows.Forms.Button();
            this.btnTeclado = new System.Windows.Forms.Button();
            this.btnPantalla = new System.Windows.Forms.Button();
            this.btnCpu = new System.Windows.Forms.Button();
            this.btnScanner = new System.Windows.Forms.Button();
            this.imgLogoMini = new System.Windows.Forms.PictureBox();
            this.timerOcultarMenu = new System.Windows.Forms.Timer(this.components);
            this.timerMostrarMenu = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCabecera.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoMini)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.Goldenrod;
            this.panelCabecera.Controls.Add(this.label1);
            this.panelCabecera.Controls.Add(this.btnRestaurar);
            this.panelCabecera.Controls.Add(this.btnMinimizar);
            this.panelCabecera.Controls.Add(this.btnMaximizar);
            this.panelCabecera.Controls.Add(this.btnCerrar);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1300, 34);
            this.panelCabecera.TabIndex = 2;
            this.panelCabecera.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCabecera_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(643, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "INVENTARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = global::sistemaFCNM.Properties.Resources.IconoRestaurar;
            this.btnRestaurar.Location = new System.Drawing.Point(1225, 0);
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
            this.btnMinimizar.Image = global::sistemaFCNM.Properties.Resources.IconoMinimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(1190, 0);
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
            this.btnMaximizar.Image = global::sistemaFCNM.Properties.Resources.IconoMaximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(1225, 0);
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
            this.btnCerrar.Image = global::sistemaFCNM.Properties.Resources.IconocerrarFN;
            this.btnCerrar.Location = new System.Drawing.Point(1260, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelMenu.Controls.Add(this.panel13);
            this.panelMenu.Controls.Add(this.panel12);
            this.panelMenu.Controls.Add(this.panel11);
            this.panelMenu.Controls.Add(this.panel10);
            this.panelMenu.Controls.Add(this.panel9);
            this.panelMenu.Controls.Add(this.panel8);
            this.panelMenu.Controls.Add(this.panel7);
            this.panelMenu.Controls.Add(this.panel6);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Controls.Add(this.imgLogoBig);
            this.panelMenu.Controls.Add(this.btnRadio);
            this.panelMenu.Controls.Add(this.btnPproyeccion);
            this.panelMenu.Controls.Add(this.btnTelefono);
            this.panelMenu.Controls.Add(this.btnMicro);
            this.panelMenu.Controls.Add(this.btnParlante);
            this.panelMenu.Controls.Add(this.btnImpresora);
            this.panelMenu.Controls.Add(this.btnProyector);
            this.panelMenu.Controls.Add(this.btnRegulador);
            this.panelMenu.Controls.Add(this.btnMouse);
            this.panelMenu.Controls.Add(this.btnTeclado);
            this.panelMenu.Controls.Add(this.btnPantalla);
            this.panelMenu.Controls.Add(this.btnCpu);
            this.panelMenu.Controls.Add(this.btnScanner);
            this.panelMenu.Controls.Add(this.imgLogoMini);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.ForeColor = System.Drawing.SystemColors.Window;
            this.panelMenu.Location = new System.Drawing.Point(0, 34);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 696);
            this.panelMenu.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Goldenrod;
            this.panel13.Location = new System.Drawing.Point(0, 649);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(9, 37);
            this.panel13.TabIndex = 22;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Goldenrod;
            this.panel12.Location = new System.Drawing.Point(0, 608);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(9, 35);
            this.panel12.TabIndex = 21;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Goldenrod;
            this.panel11.Location = new System.Drawing.Point(0, 560);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(9, 42);
            this.panel11.TabIndex = 19;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Goldenrod;
            this.panel10.Location = new System.Drawing.Point(0, 512);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(9, 42);
            this.panel10.TabIndex = 19;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Goldenrod;
            this.panel9.Location = new System.Drawing.Point(0, 368);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(9, 42);
            this.panel9.TabIndex = 19;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Goldenrod;
            this.panel8.Location = new System.Drawing.Point(0, 416);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(9, 42);
            this.panel8.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Goldenrod;
            this.panel7.Location = new System.Drawing.Point(0, 464);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(9, 42);
            this.panel7.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Goldenrod;
            this.panel6.Location = new System.Drawing.Point(0, 320);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(9, 42);
            this.panel6.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Goldenrod;
            this.panel5.Location = new System.Drawing.Point(0, 272);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(9, 42);
            this.panel5.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Goldenrod;
            this.panel4.Location = new System.Drawing.Point(0, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(9, 42);
            this.panel4.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Goldenrod;
            this.panel3.Location = new System.Drawing.Point(0, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(9, 42);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(9, 42);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(9, 42);
            this.panel1.TabIndex = 16;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.Image = global::sistemaFCNM.Properties.Resources.MobileMenuIcon;
            this.btnMenu.InitialImage = null;
            this.btnMenu.Location = new System.Drawing.Point(183, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(34, 32);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 15;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // imgLogoBig
            // 
            this.imgLogoBig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.imgLogoBig.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoBig.Image")));
            this.imgLogoBig.Location = new System.Drawing.Point(23, 6);
            this.imgLogoBig.Name = "imgLogoBig";
            this.imgLogoBig.Size = new System.Drawing.Size(144, 54);
            this.imgLogoBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoBig.TabIndex = 14;
            this.imgLogoBig.TabStop = false;
            // 
            // btnRadio
            // 
            this.btnRadio.AutoEllipsis = true;
            this.btnRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRadio.FlatAppearance.BorderSize = 0;
            this.btnRadio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRadio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadio.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRadio.Image = ((System.Drawing.Image)(resources.GetObject("btnRadio.Image")));
            this.btnRadio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRadio.Location = new System.Drawing.Point(9, 649);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(220, 37);
            this.btnRadio.TabIndex = 13;
            this.btnRadio.Text = "      Radio";
            this.btnRadio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRadio.UseVisualStyleBackColor = true;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // btnPproyeccion
            // 
            this.btnPproyeccion.AutoEllipsis = true;
            this.btnPproyeccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPproyeccion.FlatAppearance.BorderSize = 0;
            this.btnPproyeccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPproyeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnPproyeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPproyeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPproyeccion.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPproyeccion.Image = ((System.Drawing.Image)(resources.GetObject("btnPproyeccion.Image")));
            this.btnPproyeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPproyeccion.Location = new System.Drawing.Point(9, 608);
            this.btnPproyeccion.Name = "btnPproyeccion";
            this.btnPproyeccion.Size = new System.Drawing.Size(220, 35);
            this.btnPproyeccion.TabIndex = 12;
            this.btnPproyeccion.Text = "      P.Proyeccion";
            this.btnPproyeccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPproyeccion.UseVisualStyleBackColor = true;
            this.btnPproyeccion.Click += new System.EventHandler(this.btnPproyeccion_Click);
            // 
            // btnTelefono
            // 
            this.btnTelefono.AutoEllipsis = true;
            this.btnTelefono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelefono.FlatAppearance.BorderSize = 0;
            this.btnTelefono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnTelefono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelefono.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTelefono.Image = ((System.Drawing.Image)(resources.GetObject("btnTelefono.Image")));
            this.btnTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelefono.Location = new System.Drawing.Point(9, 560);
            this.btnTelefono.Name = "btnTelefono";
            this.btnTelefono.Size = new System.Drawing.Size(220, 42);
            this.btnTelefono.TabIndex = 11;
            this.btnTelefono.Text = "      Telefono";
            this.btnTelefono.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTelefono.UseVisualStyleBackColor = true;
            this.btnTelefono.Click += new System.EventHandler(this.btnTelefono_Click);
            // 
            // btnMicro
            // 
            this.btnMicro.AutoEllipsis = true;
            this.btnMicro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMicro.FlatAppearance.BorderSize = 0;
            this.btnMicro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMicro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMicro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMicro.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMicro.Image = ((System.Drawing.Image)(resources.GetObject("btnMicro.Image")));
            this.btnMicro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMicro.Location = new System.Drawing.Point(9, 512);
            this.btnMicro.Name = "btnMicro";
            this.btnMicro.Size = new System.Drawing.Size(220, 42);
            this.btnMicro.TabIndex = 10;
            this.btnMicro.Text = "      Microfono";
            this.btnMicro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMicro.UseVisualStyleBackColor = true;
            this.btnMicro.Click += new System.EventHandler(this.btnMicro_Click);
            // 
            // btnParlante
            // 
            this.btnParlante.AutoEllipsis = true;
            this.btnParlante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParlante.FlatAppearance.BorderSize = 0;
            this.btnParlante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnParlante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnParlante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParlante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParlante.ForeColor = System.Drawing.SystemColors.Window;
            this.btnParlante.Image = ((System.Drawing.Image)(resources.GetObject("btnParlante.Image")));
            this.btnParlante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParlante.Location = new System.Drawing.Point(9, 368);
            this.btnParlante.Name = "btnParlante";
            this.btnParlante.Size = new System.Drawing.Size(220, 42);
            this.btnParlante.TabIndex = 9;
            this.btnParlante.Text = "      Parlante";
            this.btnParlante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParlante.UseVisualStyleBackColor = true;
            this.btnParlante.Click += new System.EventHandler(this.btnParlante_Click);
            // 
            // btnImpresora
            // 
            this.btnImpresora.AutoEllipsis = true;
            this.btnImpresora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImpresora.FlatAppearance.BorderSize = 0;
            this.btnImpresora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnImpresora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnImpresora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpresora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpresora.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImpresora.Image = ((System.Drawing.Image)(resources.GetObject("btnImpresora.Image")));
            this.btnImpresora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpresora.Location = new System.Drawing.Point(9, 416);
            this.btnImpresora.Name = "btnImpresora";
            this.btnImpresora.Size = new System.Drawing.Size(220, 42);
            this.btnImpresora.TabIndex = 8;
            this.btnImpresora.Text = "      Impresora";
            this.btnImpresora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImpresora.UseVisualStyleBackColor = true;
            this.btnImpresora.Click += new System.EventHandler(this.btnImpresora_Click);
            // 
            // btnProyector
            // 
            this.btnProyector.AutoEllipsis = true;
            this.btnProyector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyector.FlatAppearance.BorderSize = 0;
            this.btnProyector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProyector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnProyector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyector.ForeColor = System.Drawing.SystemColors.Window;
            this.btnProyector.Image = ((System.Drawing.Image)(resources.GetObject("btnProyector.Image")));
            this.btnProyector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyector.Location = new System.Drawing.Point(9, 464);
            this.btnProyector.Name = "btnProyector";
            this.btnProyector.Size = new System.Drawing.Size(220, 42);
            this.btnProyector.TabIndex = 7;
            this.btnProyector.Text = "      Proyector";
            this.btnProyector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProyector.UseVisualStyleBackColor = true;
            this.btnProyector.Click += new System.EventHandler(this.btnProyector_Click);
            // 
            // btnRegulador
            // 
            this.btnRegulador.AutoEllipsis = true;
            this.btnRegulador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegulador.FlatAppearance.BorderSize = 0;
            this.btnRegulador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRegulador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnRegulador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegulador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegulador.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRegulador.Image = ((System.Drawing.Image)(resources.GetObject("btnRegulador.Image")));
            this.btnRegulador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegulador.Location = new System.Drawing.Point(9, 320);
            this.btnRegulador.Name = "btnRegulador";
            this.btnRegulador.Size = new System.Drawing.Size(220, 42);
            this.btnRegulador.TabIndex = 6;
            this.btnRegulador.Text = "      Regulador";
            this.btnRegulador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegulador.UseVisualStyleBackColor = true;
            this.btnRegulador.Click += new System.EventHandler(this.btnRegulador_Click);
            // 
            // btnMouse
            // 
            this.btnMouse.AutoEllipsis = true;
            this.btnMouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMouse.FlatAppearance.BorderSize = 0;
            this.btnMouse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMouse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMouse.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMouse.Image = ((System.Drawing.Image)(resources.GetObject("btnMouse.Image")));
            this.btnMouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMouse.Location = new System.Drawing.Point(9, 272);
            this.btnMouse.Name = "btnMouse";
            this.btnMouse.Size = new System.Drawing.Size(220, 42);
            this.btnMouse.TabIndex = 5;
            this.btnMouse.Text = "      Mouse";
            this.btnMouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMouse.UseVisualStyleBackColor = true;
            this.btnMouse.Click += new System.EventHandler(this.btnMouse_Click);
            // 
            // btnTeclado
            // 
            this.btnTeclado.AutoEllipsis = true;
            this.btnTeclado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeclado.FlatAppearance.BorderSize = 0;
            this.btnTeclado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnTeclado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnTeclado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeclado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeclado.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTeclado.Image = ((System.Drawing.Image)(resources.GetObject("btnTeclado.Image")));
            this.btnTeclado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeclado.Location = new System.Drawing.Point(9, 224);
            this.btnTeclado.Name = "btnTeclado";
            this.btnTeclado.Size = new System.Drawing.Size(220, 42);
            this.btnTeclado.TabIndex = 4;
            this.btnTeclado.Text = "      Teclado";
            this.btnTeclado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeclado.UseVisualStyleBackColor = true;
            this.btnTeclado.Click += new System.EventHandler(this.btnTeclado_Click);
            // 
            // btnPantalla
            // 
            this.btnPantalla.AutoEllipsis = true;
            this.btnPantalla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPantalla.FlatAppearance.BorderSize = 0;
            this.btnPantalla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPantalla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnPantalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPantalla.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPantalla.Image = ((System.Drawing.Image)(resources.GetObject("btnPantalla.Image")));
            this.btnPantalla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPantalla.Location = new System.Drawing.Point(9, 176);
            this.btnPantalla.Name = "btnPantalla";
            this.btnPantalla.Size = new System.Drawing.Size(220, 42);
            this.btnPantalla.TabIndex = 3;
            this.btnPantalla.Text = "      Pantalla";
            this.btnPantalla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPantalla.UseVisualStyleBackColor = true;
            this.btnPantalla.Click += new System.EventHandler(this.btnPantalla_Click);
            // 
            // btnCpu
            // 
            this.btnCpu.AutoEllipsis = true;
            this.btnCpu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCpu.FlatAppearance.BorderSize = 0;
            this.btnCpu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCpu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnCpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCpu.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCpu.Image = ((System.Drawing.Image)(resources.GetObject("btnCpu.Image")));
            this.btnCpu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCpu.Location = new System.Drawing.Point(9, 128);
            this.btnCpu.Name = "btnCpu";
            this.btnCpu.Size = new System.Drawing.Size(220, 42);
            this.btnCpu.TabIndex = 2;
            this.btnCpu.Text = "       CPU";
            this.btnCpu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCpu.UseVisualStyleBackColor = true;
            this.btnCpu.Click += new System.EventHandler(this.btnCpu_Click);
            // 
            // btnScanner
            // 
            this.btnScanner.AutoEllipsis = true;
            this.btnScanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScanner.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnScanner.FlatAppearance.BorderSize = 0;
            this.btnScanner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnScanner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanner.ForeColor = System.Drawing.SystemColors.Window;
            this.btnScanner.Image = ((System.Drawing.Image)(resources.GetObject("btnScanner.Image")));
            this.btnScanner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanner.Location = new System.Drawing.Point(9, 80);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(220, 42);
            this.btnScanner.TabIndex = 1;
            this.btnScanner.Text = "      Scanear Codigo";
            this.btnScanner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScanner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScanner.UseVisualStyleBackColor = true;
            this.btnScanner.Click += new System.EventHandler(this.btnScanner_Click);
            // 
            // imgLogoMini
            // 
            this.imgLogoMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.imgLogoMini.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoMini.Image")));
            this.imgLogoMini.Location = new System.Drawing.Point(0, 28);
            this.imgLogoMini.Name = "imgLogoMini";
            this.imgLogoMini.Size = new System.Drawing.Size(55, 55);
            this.imgLogoMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoMini.TabIndex = 4;
            this.imgLogoMini.TabStop = false;
            this.imgLogoMini.Visible = false;
            // 
            // timerOcultarMenu
            // 
            this.timerOcultarMenu.Tick += new System.EventHandler(this.timerOcultarMenu_Tick);
            // 
            // timerMostrarMenu
            // 
            this.timerMostrarMenu.Tick += new System.EventHandler(this.timerMostrarMenu_Tick);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackgroundImage = global::sistemaFCNM.Properties.Resources.pcIncono2;
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedor.Location = new System.Drawing.Point(220, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1080, 695);
            this.panelContenedor.TabIndex = 4;
            // 
            // mainPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::sistemaFCNM.Properties.Resources.pcIncono2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 730);
            this.ControlBox = false;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoMini)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.PictureBox imgLogoMini;
        private System.Windows.Forms.Button btnScanner;
        private System.Windows.Forms.Button btnCpu;
        private System.Windows.Forms.Button btnPantalla;
        private System.Windows.Forms.Button btnParlante;
        private System.Windows.Forms.Button btnImpresora;
        private System.Windows.Forms.Button btnProyector;
        private System.Windows.Forms.Button btnRegulador;
        private System.Windows.Forms.Button btnMouse;
        private System.Windows.Forms.Button btnTeclado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRadio;
        private System.Windows.Forms.Button btnPproyeccion;
        private System.Windows.Forms.Button btnTelefono;
        private System.Windows.Forms.Button btnMicro;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox imgLogoBig;
        private System.Windows.Forms.Timer timerOcultarMenu;
        private System.Windows.Forms.Timer timerMostrarMenu;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelContenedor;
    }
}

