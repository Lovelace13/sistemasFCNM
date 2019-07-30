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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPrincipal));
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
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
            this.panelContenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.menuSuperior = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelCabecera.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.menuSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelCabecera.Controls.Add(this.btnRestaurar);
            this.panelCabecera.Controls.Add(this.btnMinimizar);
            this.panelCabecera.Controls.Add(this.label1);
            this.panelCabecera.Controls.Add(this.btnMaximizar);
            this.panelCabecera.Controls.Add(this.btnCerrar);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1300, 24);
            this.panelCabecera.TabIndex = 2;
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
            this.btnRestaurar.Image = global::sistemaFCNM.Properties.Resources.IconoRestaurar;
            this.btnRestaurar.Location = new System.Drawing.Point(1225, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(40, 24);
            this.btnRestaurar.TabIndex = 5;
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
            this.btnMinimizar.Size = new System.Drawing.Size(40, 30);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(561, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inventario FCNM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnMaximizar.Size = new System.Drawing.Size(40, 24);
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
            this.btnCerrar.Size = new System.Drawing.Size(40, 24);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Highlight;
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
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.ForeColor = System.Drawing.SystemColors.Window;
            this.panelMenu.Location = new System.Drawing.Point(0, 48);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(75, 682);
            this.panelMenu.TabIndex = 0;
            // 
            // btnRadio
            // 
            this.btnRadio.AutoEllipsis = true;
            this.btnRadio.BackgroundImage = global::sistemaFCNM.Properties.Resources.walkietalkie;
            this.btnRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRadio.FlatAppearance.BorderSize = 0;
            this.btnRadio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRadio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadio.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRadio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRadio.Location = new System.Drawing.Point(-8, 582);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(82, 42);
            this.btnRadio.TabIndex = 13;
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
            this.btnPproyeccion.Location = new System.Drawing.Point(-8, 534);
            this.btnPproyeccion.Name = "btnPproyeccion";
            this.btnPproyeccion.Size = new System.Drawing.Size(83, 42);
            this.btnPproyeccion.TabIndex = 12;
            this.btnPproyeccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPproyeccion.UseVisualStyleBackColor = true;
            this.btnPproyeccion.Click += new System.EventHandler(this.btnPproyeccion_Click);
            // 
            // btnTelefono
            // 
            this.btnTelefono.AutoEllipsis = true;
            this.btnTelefono.BackgroundImage = global::sistemaFCNM.Properties.Resources.telefono1;
            this.btnTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTelefono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelefono.FlatAppearance.BorderSize = 0;
            this.btnTelefono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnTelefono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelefono.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelefono.Location = new System.Drawing.Point(-5, 486);
            this.btnTelefono.Name = "btnTelefono";
            this.btnTelefono.Size = new System.Drawing.Size(84, 42);
            this.btnTelefono.TabIndex = 11;
            this.btnTelefono.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTelefono.UseVisualStyleBackColor = true;
            this.btnTelefono.Click += new System.EventHandler(this.btnTelefono_Click);
            // 
            // btnMicro
            // 
            this.btnMicro.AutoEllipsis = true;
            this.btnMicro.BackgroundImage = global::sistemaFCNM.Properties.Resources.microfono;
            this.btnMicro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMicro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMicro.FlatAppearance.BorderSize = 0;
            this.btnMicro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMicro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMicro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMicro.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMicro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMicro.Location = new System.Drawing.Point(-8, 438);
            this.btnMicro.Name = "btnMicro";
            this.btnMicro.Size = new System.Drawing.Size(87, 42);
            this.btnMicro.TabIndex = 10;
            this.btnMicro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMicro.UseVisualStyleBackColor = true;
            this.btnMicro.Click += new System.EventHandler(this.btnMicro_Click);
            // 
            // btnParlante
            // 
            this.btnParlante.AutoEllipsis = true;
            this.btnParlante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnParlante.BackgroundImage")));
            this.btnParlante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnParlante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParlante.FlatAppearance.BorderSize = 0;
            this.btnParlante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnParlante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnParlante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParlante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParlante.ForeColor = System.Drawing.SystemColors.Window;
            this.btnParlante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParlante.Location = new System.Drawing.Point(-8, 294);
            this.btnParlante.Name = "btnParlante";
            this.btnParlante.Size = new System.Drawing.Size(87, 42);
            this.btnParlante.TabIndex = 9;
            this.btnParlante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParlante.UseVisualStyleBackColor = true;
            this.btnParlante.Click += new System.EventHandler(this.btnParlante_Click);
            // 
            // btnImpresora
            // 
            this.btnImpresora.AutoEllipsis = true;
            this.btnImpresora.BackgroundImage = global::sistemaFCNM.Properties.Resources.impresora1;
            this.btnImpresora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImpresora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImpresora.FlatAppearance.BorderSize = 0;
            this.btnImpresora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnImpresora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnImpresora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpresora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpresora.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImpresora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpresora.Location = new System.Drawing.Point(-8, 342);
            this.btnImpresora.Name = "btnImpresora";
            this.btnImpresora.Size = new System.Drawing.Size(87, 42);
            this.btnImpresora.TabIndex = 8;
            this.btnImpresora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImpresora.UseVisualStyleBackColor = true;
            this.btnImpresora.Click += new System.EventHandler(this.btnImpresora_Click);
            // 
            // btnProyector
            // 
            this.btnProyector.AutoEllipsis = true;
            this.btnProyector.BackgroundImage = global::sistemaFCNM.Properties.Resources.proyector1;
            this.btnProyector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProyector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyector.FlatAppearance.BorderSize = 0;
            this.btnProyector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProyector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnProyector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyector.ForeColor = System.Drawing.SystemColors.Window;
            this.btnProyector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyector.Location = new System.Drawing.Point(-8, 390);
            this.btnProyector.Name = "btnProyector";
            this.btnProyector.Size = new System.Drawing.Size(87, 42);
            this.btnProyector.TabIndex = 7;
            this.btnProyector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProyector.UseVisualStyleBackColor = true;
            this.btnProyector.Click += new System.EventHandler(this.btnProyector_Click);
            // 
            // btnRegulador
            // 
            this.btnRegulador.AutoEllipsis = true;
            this.btnRegulador.BackgroundImage = global::sistemaFCNM.Properties.Resources.desktoppc;
            this.btnRegulador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegulador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegulador.FlatAppearance.BorderSize = 0;
            this.btnRegulador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRegulador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnRegulador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegulador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegulador.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRegulador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegulador.Location = new System.Drawing.Point(-5, 246);
            this.btnRegulador.Name = "btnRegulador";
            this.btnRegulador.Size = new System.Drawing.Size(79, 42);
            this.btnRegulador.TabIndex = 6;
            this.btnRegulador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegulador.UseVisualStyleBackColor = true;
            this.btnRegulador.Click += new System.EventHandler(this.btnRegulador_Click);
            // 
            // btnMouse
            // 
            this.btnMouse.AutoEllipsis = true;
            this.btnMouse.BackgroundImage = global::sistemaFCNM.Properties.Resources.raton1;
            this.btnMouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMouse.FlatAppearance.BorderSize = 0;
            this.btnMouse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMouse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMouse.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMouse.Location = new System.Drawing.Point(-5, 198);
            this.btnMouse.Name = "btnMouse";
            this.btnMouse.Size = new System.Drawing.Size(79, 42);
            this.btnMouse.TabIndex = 5;
            this.btnMouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMouse.UseVisualStyleBackColor = true;
            this.btnMouse.Click += new System.EventHandler(this.btnMouse_Click);
            // 
            // btnTeclado
            // 
            this.btnTeclado.AutoEllipsis = true;
            this.btnTeclado.BackgroundImage = global::sistemaFCNM.Properties.Resources.teclado1;
            this.btnTeclado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTeclado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeclado.FlatAppearance.BorderSize = 0;
            this.btnTeclado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnTeclado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnTeclado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeclado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeclado.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTeclado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeclado.Location = new System.Drawing.Point(-5, 150);
            this.btnTeclado.Name = "btnTeclado";
            this.btnTeclado.Size = new System.Drawing.Size(84, 42);
            this.btnTeclado.TabIndex = 4;
            this.btnTeclado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeclado.UseVisualStyleBackColor = true;
            this.btnTeclado.Click += new System.EventHandler(this.btnTeclado_Click);
            // 
            // btnPantalla
            // 
            this.btnPantalla.AutoEllipsis = true;
            this.btnPantalla.BackgroundImage = global::sistemaFCNM.Properties.Resources.imac_off;
            this.btnPantalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPantalla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPantalla.FlatAppearance.BorderSize = 0;
            this.btnPantalla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPantalla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnPantalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPantalla.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPantalla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPantalla.Location = new System.Drawing.Point(-5, 102);
            this.btnPantalla.Name = "btnPantalla";
            this.btnPantalla.Size = new System.Drawing.Size(84, 42);
            this.btnPantalla.TabIndex = 3;
            this.btnPantalla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPantalla.UseVisualStyleBackColor = true;
            this.btnPantalla.Click += new System.EventHandler(this.btnPantalla_Click);
            // 
            // btnCpu
            // 
            this.btnCpu.AutoEllipsis = true;
            this.btnCpu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCpu.BackgroundImage")));
            this.btnCpu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCpu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCpu.FlatAppearance.BorderSize = 0;
            this.btnCpu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCpu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnCpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCpu.ForeColor = System.Drawing.Color.Transparent;
            this.btnCpu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCpu.Location = new System.Drawing.Point(-5, 54);
            this.btnCpu.Name = "btnCpu";
            this.btnCpu.Size = new System.Drawing.Size(79, 42);
            this.btnCpu.TabIndex = 2;
            this.btnCpu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCpu.UseVisualStyleBackColor = true;
            this.btnCpu.Click += new System.EventHandler(this.btnCpu_Click);
            // 
            // btnScanner
            // 
            this.btnScanner.AutoEllipsis = true;
            this.btnScanner.BackgroundImage = global::sistemaFCNM.Properties.Resources.codigoqr;
            this.btnScanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnScanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScanner.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnScanner.FlatAppearance.BorderSize = 0;
            this.btnScanner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnScanner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanner.ForeColor = System.Drawing.SystemColors.Window;
            this.btnScanner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanner.Location = new System.Drawing.Point(-8, 6);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(94, 42);
            this.btnScanner.TabIndex = 1;
            this.btnScanner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScanner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScanner.UseVisualStyleBackColor = true;
            this.btnScanner.Click += new System.EventHandler(this.btnScanner_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackgroundImage = global::sistemaFCNM.Properties.Resources.fondo2;
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedor.Location = new System.Drawing.Point(92, 63);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1229, 684);
            this.panelContenedor.TabIndex = 4;
            // 
            // menuSuperior
            // 
            this.menuSuperior.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuSuperior.Location = new System.Drawing.Point(0, 24);
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuSuperior.Size = new System.Drawing.Size(1300, 24);
            this.menuSuperior.TabIndex = 68;
            this.menuSuperior.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarMenuItem,
            this.cargarDocumentoToolStripMenuItem,
            this.CerrarSesion,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarMenuItem
            // 
            this.guardarMenuItem.Name = "guardarMenuItem";
            this.guardarMenuItem.Size = new System.Drawing.Size(175, 22);
            this.guardarMenuItem.Text = "Regresar Menu";
            this.guardarMenuItem.Click += new System.EventHandler(this.guardarMenuItem_Click);
            // 
            // cargarDocumentoToolStripMenuItem
            // 
            this.cargarDocumentoToolStripMenuItem.Name = "cargarDocumentoToolStripMenuItem";
            this.cargarDocumentoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cargarDocumentoToolStripMenuItem.Text = "Cargar Documento";
            this.cargarDocumentoToolStripMenuItem.Click += new System.EventHandler(this.cargarDocumentoToolStripMenuItem_Click);
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(175, 22);
            this.CerrarSesion.Text = "Cerrar Sesion";
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(129, 6);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de..";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mainPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::sistemaFCNM.Properties.Resources.fondooo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 730);
            this.ControlBox = false;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.menuSuperior);
            this.Controls.Add(this.panelCabecera);
            this.Controls.Add(this.panelContenedor);
            this.DoubleBuffered = true;
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
            this.menuSuperior.ResumeLayout(false);
            this.menuSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
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
        private System.Windows.Forms.FlowLayoutPanel panelContenedor;


        public void botonesAdministracion()
        {
            
        }

        private System.Windows.Forms.MenuStrip menuSuperior;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CerrarSesion;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

