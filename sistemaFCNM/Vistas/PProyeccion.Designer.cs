﻿namespace sistemaFCNM.Vistas
{
    partial class PProyeccion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PProyeccion));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDimensiones = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPproyeccion = new System.Windows.Forms.TextBox();
            this.lblCpu = new System.Windows.Forms.Label();
            this.btnPrevius = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sistemasFCNMDataSet = new sistemaFCNM.sistemasFCNMDataSet();
            this.pantallaProyeccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pantallaProyeccionTableAdapter = new sistemaFCNM.sistemasFCNMDataSetTableAdapters.PantallaProyeccionTableAdapter();
            this.tableAdapterManager = new sistemaFCNM.sistemasFCNMDataSetTableAdapters.TableAdapterManager();
            this.pantallaProyeccionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pantallaProyeccionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gridPP = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasFCNMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantallaProyeccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantallaProyeccionBindingNavigator)).BeginInit();
            this.pantallaProyeccionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(10, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 135;
            this.label1.Text = "Dimensiones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDimensiones
            // 
            this.txtDimensiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDimensiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDimensiones.Enabled = false;
            this.txtDimensiones.Location = new System.Drawing.Point(197, 121);
            this.txtDimensiones.Multiline = true;
            this.txtDimensiones.Name = "txtDimensiones";
            this.txtDimensiones.Size = new System.Drawing.Size(105, 31);
            this.txtDimensiones.TabIndex = 134;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(153, 144);
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(172, 31);
            this.txtEstado.TabIndex = 129;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 130;
            this.label10.Text = "Estado";
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerie.Enabled = false;
            this.txtSerie.Location = new System.Drawing.Point(153, 101);
            this.txtSerie.Multiline = true;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(172, 31);
            this.txtSerie.TabIndex = 127;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 128;
            this.label11.Text = "Serie";
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(153, 62);
            this.txtModelo.Multiline = true;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(172, 31);
            this.txtModelo.TabIndex = 125;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 126;
            this.label12.Text = "Modelo";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(153, 19);
            this.txtMarca.Multiline = true;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(172, 31);
            this.txtMarca.TabIndex = 123;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 124;
            this.label13.Text = "Marca";
            // 
            // txtPproyeccion
            // 
            this.txtPproyeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPproyeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPproyeccion.Enabled = false;
            this.txtPproyeccion.Location = new System.Drawing.Point(197, 76);
            this.txtPproyeccion.Multiline = true;
            this.txtPproyeccion.Name = "txtPproyeccion";
            this.txtPproyeccion.Size = new System.Drawing.Size(172, 31);
            this.txtPproyeccion.TabIndex = 121;
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCpu.Location = new System.Drawing.Point(10, 82);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(181, 13);
            this.lblCpu.TabIndex = 122;
            this.lblCpu.Text = "Inventario Pantalla Proyeccion";
            this.lblCpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrevius
            // 
            this.btnPrevius.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevius.FlatAppearance.BorderSize = 0;
            this.btnPrevius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevius.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevius.Image")));
            this.btnPrevius.Location = new System.Drawing.Point(926, 627);
            this.btnPrevius.Name = "btnPrevius";
            this.btnPrevius.Size = new System.Drawing.Size(36, 34);
            this.btnPrevius.TabIndex = 157;
            this.btnPrevius.UseVisualStyleBackColor = false;
            this.btnPrevius.Click += new System.EventHandler(this.btnPrevius_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(995, 627);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 34);
            this.btnNext.TabIndex = 156;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtEquipo
            // 
            this.txtEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEquipo.Enabled = false;
            this.txtEquipo.Location = new System.Drawing.Point(197, 30);
            this.txtEquipo.Multiline = true;
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(172, 31);
            this.txtEquipo.TabIndex = 158;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 159;
            this.label2.Text = "Equipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDimensiones);
            this.groupBox1.Controls.Add(this.lblCpu);
            this.groupBox1.Controls.Add(this.txtPproyeccion);
            this.groupBox1.Controls.Add(this.txtEquipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(91, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 227);
            this.groupBox1.TabIndex = 165;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PANTALLA PROYECCION DATOS BASICOS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSerie);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtModelo);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtMarca);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(553, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 227);
            this.groupBox2.TabIndex = 166;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caracteristicas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(935, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 125);
            this.panel1.TabIndex = 167;
            // 
            // sistemasFCNMDataSet
            // 
            this.sistemasFCNMDataSet.DataSetName = "sistemasFCNMDataSet";
            this.sistemasFCNMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pantallaProyeccionBindingSource
            // 
            this.pantallaProyeccionBindingSource.DataMember = "PantallaProyeccion";
            this.pantallaProyeccionBindingSource.DataSource = this.sistemasFCNMDataSet;
            // 
            // pantallaProyeccionTableAdapter
            // 
            this.pantallaProyeccionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaOficinaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CpuAdicionalLoteTableAdapter = null;
            this.tableAdapterManager.CpuCodeTableAdapter = null;
            this.tableAdapterManager.CpuDiscoTableAdapter = null;
            this.tableAdapterManager.CpuInventarioTableAdapter = null;
            this.tableAdapterManager.CpuMarcaTableAdapter = null;
            this.tableAdapterManager.CpuMemoriaTableAdapter = null;
            this.tableAdapterManager.CpuNombreTableAdapter = null;
            this.tableAdapterManager.CpuPerfilTableAdapter = null;
            this.tableAdapterManager.CpuProcesadorTableAdapter = null;
            this.tableAdapterManager.CpuSerieTableAdapter = null;
            this.tableAdapterManager.CpuTagTableAdapter = null;
            this.tableAdapterManager.CpuTipoTableAdapter = null;
            this.tableAdapterManager.EdificioTableAdapter = null;
            this.tableAdapterManager.EquipoInventarioTableAdapter = null;
            this.tableAdapterManager.EstadoTableAdapter = null;
            this.tableAdapterManager.FechaInventarioTableAdapter = null;
            this.tableAdapterManager.ImpresoraInventarioTableAdapter = null;
            this.tableAdapterManager.ImpresoraMarcaTableAdapter = null;
            this.tableAdapterManager.ImpresoraModeloTableAdapter = null;
            this.tableAdapterManager.ImpresoraSerieTableAdapter = null;
            //this.tableAdapterManager.ImpresoraTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.MicrofonoInventarioTableAdapter = null;
            this.tableAdapterManager.MicrofonoMarcaTableAdapter = null;
            this.tableAdapterManager.MicrofonoSerieTableAdapter = null;
            this.tableAdapterManager.MicrofonoTableAdapter = null;
            this.tableAdapterManager.MicrofonoTipoTableAdapter = null;
            this.tableAdapterManager.MouseInventarioTableAdapter = null;
            this.tableAdapterManager.MouseMarcaTableAdapter = null;
            this.tableAdapterManager.MouseModeloTableAdapter = null;
            this.tableAdapterManager.MouseSerieTableAdapter = null;
            //this.tableAdapterManager.MouseTableAdapter = null;
            this.tableAdapterManager.NombreOficinaTableAdapter = null;
            this.tableAdapterManager.OficinaTableAdapter = null;
            this.tableAdapterManager.PantallaInventarioTableAdapter = null;
            this.tableAdapterManager.PantallaMarcaTableAdapter = null;
            this.tableAdapterManager.PantallaModeloTableAdapter = null;
            this.tableAdapterManager.PantallaProyeccionDimensionesTableAdapter = null;
            this.tableAdapterManager.PantallaProyeccionInventarioTableAdapter = null;
            this.tableAdapterManager.PantallaProyeccionMarcaTableAdapter = null;
            this.tableAdapterManager.PantallaProyeccionModeloTableAdapter = null;
            this.tableAdapterManager.PantallaProyeccionSerieTableAdapter = null;
            this.tableAdapterManager.PantallaProyeccionTableAdapter = this.pantallaProyeccionTableAdapter;
            this.tableAdapterManager.PantallaPulgadasTableAdapter = null;
            this.tableAdapterManager.PantallaSerieTableAdapter = null;
            //this.tableAdapterManager.PantallaTableAdapter = null;
            this.tableAdapterManager.ParlanteInventarioTableAdapter = null;
            this.tableAdapterManager.ParlanteMarcaTableAdapter = null;
            this.tableAdapterManager.ParlanteModeloTableAdapter = null;
            this.tableAdapterManager.ParlanteSerieTableAdapter = null;
            //this.tableAdapterManager.ParlanteTableAdapter = null;
            this.tableAdapterManager.PropietarioTableAdapter = null;
            this.tableAdapterManager.ProyectorInventarioEspolTechTableAdapter = null;
            this.tableAdapterManager.ProyectorInventarioTableAdapter = null;
            this.tableAdapterManager.ProyectorMarcaTableAdapter = null;
            this.tableAdapterManager.ProyectorModeloTableAdapter = null;
            this.tableAdapterManager.ProyectorSerieTableAdapter = null;
            //this.tableAdapterManager.ProyectorTableAdapter = null;
            this.tableAdapterManager.RadioInventarioTableAdapter = null;
            this.tableAdapterManager.RadioMarcaTableAdapter = null;
            this.tableAdapterManager.RadioModeloTableAdapter = null;
            this.tableAdapterManager.RadioSerieTableAdapter = null;
            this.tableAdapterManager.RadioTableAdapter = null;
            this.tableAdapterManager.ReguladorInventarioTableAdapter = null;
            this.tableAdapterManager.ReguladorMarcaTableAdapter = null;
            this.tableAdapterManager.ReguladorModeloTableAdapter = null;
            this.tableAdapterManager.ReguladorSerieTableAdapter = null;
           // this.tableAdapterManager.ReguladorTableAdapter = null;
            this.tableAdapterManager.ReguladorTipoTableAdapter = null;
            this.tableAdapterManager.TecladoInventarioTableAdapter = null;
            this.tableAdapterManager.TecladoMarcaTableAdapter = null;
            this.tableAdapterManager.TecladoModeloTableAdapter = null;
            this.tableAdapterManager.TecladoSerieTableAdapter = null;
            //this.tableAdapterManager.TecladoTableAdapter = null;
            this.tableAdapterManager.TelefonoExtensionTableAdapter = null;
            this.tableAdapterManager.TelefonoInventarioTableAdapter = null;
            this.tableAdapterManager.TelefonoMarcaTableAdapter = null;
            this.tableAdapterManager.TelefonoModeloTableAdapter = null;
            this.tableAdapterManager.TelefonoSerieTableAdapter = null;
            this.tableAdapterManager.TelefonoTableAdapter = null;
            this.tableAdapterManager.TelefonoTipoTableAdapter = null;
            this.tableAdapterManager.TipoUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sistemaFCNM.sistemasFCNMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // pantallaProyeccionBindingNavigator
            // 
            this.pantallaProyeccionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pantallaProyeccionBindingNavigator.BindingSource = this.pantallaProyeccionBindingSource;
            this.pantallaProyeccionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pantallaProyeccionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pantallaProyeccionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pantallaProyeccionBindingNavigatorSaveItem});
            this.pantallaProyeccionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pantallaProyeccionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pantallaProyeccionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pantallaProyeccionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pantallaProyeccionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pantallaProyeccionBindingNavigator.Name = "pantallaProyeccionBindingNavigator";
            this.pantallaProyeccionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pantallaProyeccionBindingNavigator.Size = new System.Drawing.Size(1088, 25);
            this.pantallaProyeccionBindingNavigator.TabIndex = 168;
            this.pantallaProyeccionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // pantallaProyeccionBindingNavigatorSaveItem
            // 
            this.pantallaProyeccionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pantallaProyeccionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pantallaProyeccionBindingNavigatorSaveItem.Image")));
            this.pantallaProyeccionBindingNavigatorSaveItem.Name = "pantallaProyeccionBindingNavigatorSaveItem";
            this.pantallaProyeccionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pantallaProyeccionBindingNavigatorSaveItem.Text = "Guardar datos";
            this.pantallaProyeccionBindingNavigatorSaveItem.Click += new System.EventHandler(this.pantallaProyeccionBindingNavigatorSaveItem_Click);
            // 
            // gridPP
            // 
            this.gridPP.AutoGenerateColumns = false;
            this.gridPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.gridPP.DataSource = this.pantallaProyeccionBindingSource;
            this.gridPP.Location = new System.Drawing.Point(181, 270);
            this.gridPP.Name = "gridPP";
            this.gridPP.Size = new System.Drawing.Size(745, 220);
            this.gridPP.TabIndex = 168;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Inventario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Inventario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Dimensiones";
            this.dataGridViewTextBoxColumn3.HeaderText = "Dimensiones";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn4.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Serie";
            this.dataGridViewTextBoxColumn6.HeaderText = "Serie";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn7.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // PProyeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sistemaFCNM.Properties.Resources.fondooo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1088, 685);
            this.Controls.Add(this.gridPP);
            this.Controls.Add(this.pantallaProyeccionBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrevius);
            this.Controls.Add(this.btnNext);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PProyeccion";
            this.Text = "PProyeccion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PProyeccion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasFCNMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantallaProyeccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantallaProyeccionBindingNavigator)).EndInit();
            this.pantallaProyeccionBindingNavigator.ResumeLayout(false);
            this.pantallaProyeccionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDimensiones;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPproyeccion;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.Button btnPrevius;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private sistemasFCNMDataSet sistemasFCNMDataSet;
        private System.Windows.Forms.BindingSource pantallaProyeccionBindingSource;
        private sistemasFCNMDataSetTableAdapters.PantallaProyeccionTableAdapter pantallaProyeccionTableAdapter;
        private sistemasFCNMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pantallaProyeccionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pantallaProyeccionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView gridPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}