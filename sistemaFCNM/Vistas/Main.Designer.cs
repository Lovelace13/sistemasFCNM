namespace sistemaFCNM.Vistas
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            this.btnScanner = new System.Windows.Forms.Button();
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
            this.btnRadio = new System.Windows.Forms.Button();
            this.panelContenedor.SuspendLayout();
            this.menuSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackgroundImage = global::sistemaFCNM.Properties.Resources.fondo2;
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedor.Controls.Add(this.menuSuperior);
            this.panelContenedor.Controls.Add(this.btnScanner);
            this.panelContenedor.Controls.Add(this.btnPproyeccion);
            this.panelContenedor.Controls.Add(this.btnTelefono);
            this.panelContenedor.Controls.Add(this.btnMicro);
            this.panelContenedor.Controls.Add(this.btnParlante);
            this.panelContenedor.Controls.Add(this.btnImpresora);
            this.panelContenedor.Controls.Add(this.btnProyector);
            this.panelContenedor.Controls.Add(this.btnRegulador);
            this.panelContenedor.Controls.Add(this.btnMouse);
            this.panelContenedor.Controls.Add(this.btnTeclado);
            this.panelContenedor.Controls.Add(this.btnPantalla);
            this.panelContenedor.Controls.Add(this.btnCpu);
            this.panelContenedor.Controls.Add(this.btnRadio);
            this.panelContenedor.Location = new System.Drawing.Point(0, 2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1191, 598);
            this.panelContenedor.TabIndex = 5;
            // 
            // menuSuperior
            // 
            this.menuSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuSuperior.AutoSize = false;
            this.menuSuperior.Dock = System.Windows.Forms.DockStyle.None;
            this.menuSuperior.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.menuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuSuperior.Location = new System.Drawing.Point(0, 0);
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuSuperior.Size = new System.Drawing.Size(1170, 24);
            this.menuSuperior.TabIndex = 69;
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
            this.btnScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnScanner.ForeColor = System.Drawing.SystemColors.Window;
            this.btnScanner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanner.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnScanner.Location = new System.Drawing.Point(3, 27);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(94, 42);
            this.btnScanner.TabIndex = 70;
            this.btnScanner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScanner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScanner.UseVisualStyleBackColor = true;
            this.btnScanner.Click += new System.EventHandler(this.btnScanner_Click);
            // 
            // btnPproyeccion
            // 
            this.btnPproyeccion.AutoEllipsis = true;
            this.btnPproyeccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPproyeccion.FlatAppearance.BorderSize = 0;
            this.btnPproyeccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPproyeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnPproyeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPproyeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPproyeccion.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPproyeccion.Image = ((System.Drawing.Image)(resources.GetObject("btnPproyeccion.Image")));
            this.btnPproyeccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPproyeccion.Location = new System.Drawing.Point(103, 27);
            this.btnPproyeccion.Name = "btnPproyeccion";
            this.btnPproyeccion.Size = new System.Drawing.Size(83, 42);
            this.btnPproyeccion.TabIndex = 81;
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
            this.btnTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTelefono.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTelefono.Location = new System.Drawing.Point(192, 27);
            this.btnTelefono.Name = "btnTelefono";
            this.btnTelefono.Size = new System.Drawing.Size(84, 42);
            this.btnTelefono.TabIndex = 80;
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
            this.btnMicro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMicro.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMicro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMicro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMicro.Location = new System.Drawing.Point(282, 27);
            this.btnMicro.Name = "btnMicro";
            this.btnMicro.Size = new System.Drawing.Size(87, 42);
            this.btnMicro.TabIndex = 79;
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
            this.btnParlante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnParlante.ForeColor = System.Drawing.SystemColors.Window;
            this.btnParlante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParlante.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnParlante.Location = new System.Drawing.Point(375, 27);
            this.btnParlante.Name = "btnParlante";
            this.btnParlante.Size = new System.Drawing.Size(87, 42);
            this.btnParlante.TabIndex = 78;
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
            this.btnImpresora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImpresora.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImpresora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpresora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnImpresora.Location = new System.Drawing.Point(468, 27);
            this.btnImpresora.Name = "btnImpresora";
            this.btnImpresora.Size = new System.Drawing.Size(87, 42);
            this.btnImpresora.TabIndex = 77;
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
            this.btnProyector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProyector.ForeColor = System.Drawing.SystemColors.Window;
            this.btnProyector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyector.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProyector.Location = new System.Drawing.Point(561, 27);
            this.btnProyector.Name = "btnProyector";
            this.btnProyector.Size = new System.Drawing.Size(87, 42);
            this.btnProyector.TabIndex = 76;
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
            this.btnRegulador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegulador.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRegulador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegulador.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRegulador.Location = new System.Drawing.Point(654, 27);
            this.btnRegulador.Name = "btnRegulador";
            this.btnRegulador.Size = new System.Drawing.Size(79, 42);
            this.btnRegulador.TabIndex = 75;
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
            this.btnMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMouse.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMouse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMouse.Location = new System.Drawing.Point(739, 27);
            this.btnMouse.Name = "btnMouse";
            this.btnMouse.Size = new System.Drawing.Size(79, 42);
            this.btnMouse.TabIndex = 74;
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
            this.btnTeclado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTeclado.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTeclado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeclado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTeclado.Location = new System.Drawing.Point(824, 27);
            this.btnTeclado.Name = "btnTeclado";
            this.btnTeclado.Size = new System.Drawing.Size(84, 42);
            this.btnTeclado.TabIndex = 73;
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
            this.btnPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPantalla.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPantalla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPantalla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPantalla.Location = new System.Drawing.Point(914, 27);
            this.btnPantalla.Name = "btnPantalla";
            this.btnPantalla.Size = new System.Drawing.Size(84, 42);
            this.btnPantalla.TabIndex = 72;
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
            this.btnCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCpu.ForeColor = System.Drawing.Color.Transparent;
            this.btnCpu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCpu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCpu.Location = new System.Drawing.Point(1004, 27);
            this.btnCpu.Name = "btnCpu";
            this.btnCpu.Size = new System.Drawing.Size(79, 42);
            this.btnCpu.TabIndex = 71;
            this.btnCpu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCpu.UseVisualStyleBackColor = true;
            this.btnCpu.Click += new System.EventHandler(this.btnCpu_Click);
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
            this.btnRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRadio.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRadio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRadio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRadio.Location = new System.Drawing.Point(1089, 27);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(82, 42);
            this.btnRadio.TabIndex = 82;
            this.btnRadio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRadio.UseVisualStyleBackColor = true;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 602);
            this.Controls.Add(this.panelContenedor);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FACULTAD DE CIENCIAS NATURALES Y MATEMATICAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.panelContenedor.ResumeLayout(false);
            this.menuSuperior.ResumeLayout(false);
            this.menuSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelContenedor;
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
        private System.Windows.Forms.Button btnScanner;
        private System.Windows.Forms.Button btnCpu;
        private System.Windows.Forms.Button btnPproyeccion;
        private System.Windows.Forms.Button btnTelefono;
        private System.Windows.Forms.Button btnMicro;
        private System.Windows.Forms.Button btnParlante;
        private System.Windows.Forms.Button btnImpresora;
        private System.Windows.Forms.Button btnProyector;
        private System.Windows.Forms.Button btnRegulador;
        private System.Windows.Forms.Button btnMouse;
        private System.Windows.Forms.Button btnTeclado;
        private System.Windows.Forms.Button btnPantalla;
        private System.Windows.Forms.Button btnRadio;
    }
}