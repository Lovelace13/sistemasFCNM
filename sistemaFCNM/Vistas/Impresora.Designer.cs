namespace sistemaFCNM.Vistas
{
    partial class Impresora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impresora));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.impresoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemasFCNMDataSet = new sistemaFCNM.sistemasFCNMDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtImpresora = new System.Windows.Forms.TextBox();
            this.lblCpu = new System.Windows.Forms.Label();
            this.btnPrevius = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.impresoraTableAdapter = new sistemaFCNM.sistemasFCNMDataSetTableAdapters.ImpresoraTableAdapter();
            this.tableAdapterManager = new sistemaFCNM.sistemasFCNMDataSetTableAdapters.TableAdapterManager();
            this.impresoraBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.impresoraBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gridImpresora = new System.Windows.Forms.DataGridView();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.impresoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasFCNMDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impresoraBindingNavigator)).BeginInit();
            this.impresoraBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridImpresora)).BeginInit();
            this.SuspendLayout();
            // 
            // impresoraBindingSource
            // 
            this.impresoraBindingSource.DataMember = "Impresora";
            this.impresoraBindingSource.DataSource = this.sistemasFCNMDataSet;
            // 
            // sistemasFCNMDataSet
            // 
            this.sistemasFCNMDataSet.DataSetName = "sistemasFCNMDataSet";
            this.sistemasFCNMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 102;
            this.label10.Text = "Estado";
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.impresoraBindingSource, "Serie", true));
            this.txtSerie.Enabled = false;
            this.txtSerie.Location = new System.Drawing.Point(140, 101);
            this.txtSerie.Multiline = true;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(172, 31);
            this.txtSerie.TabIndex = 99;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 100;
            this.label11.Text = "Serie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 98;
            this.label12.Text = "Modelo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 96;
            this.label13.Text = "Marca";
            // 
            // txtImpresora
            // 
            this.txtImpresora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtImpresora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImpresora.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.impresoraBindingSource, "Inventario", true));
            this.txtImpresora.Enabled = false;
            this.txtImpresora.Location = new System.Drawing.Point(145, 55);
            this.txtImpresora.Multiline = true;
            this.txtImpresora.Name = "txtImpresora";
            this.txtImpresora.Size = new System.Drawing.Size(172, 31);
            this.txtImpresora.TabIndex = 93;
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCpu.Location = new System.Drawing.Point(4, 59);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(123, 13);
            this.lblCpu.TabIndex = 94;
            this.lblCpu.Text = "Inventario Impresora";
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
            this.btnPrevius.TabIndex = 124;
            this.btnPrevius.UseVisualStyleBackColor = false;
            this.btnPrevius.Click += new System.EventHandler(this.btnPrevius_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(995, 627);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 34);
            this.btnNext.TabIndex = 123;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtEquipo
            // 
            this.txtEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEquipo.Enabled = false;
            this.txtEquipo.Location = new System.Drawing.Point(145, 19);
            this.txtEquipo.Multiline = true;
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(172, 31);
            this.txtEquipo.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 127;
            this.label2.Text = "Equipo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboModelo);
            this.groupBox1.Controls.Add(this.comboEstado);
            this.groupBox1.Controls.Add(this.comboMarca);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(556, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 214);
            this.groupBox1.TabIndex = 129;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caracteristicas";
            // 
            // comboModelo
            // 
            this.comboModelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.impresoraBindingSource, "Modelo", true));
            this.comboModelo.Enabled = false;
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(140, 58);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(172, 21);
            this.comboModelo.TabIndex = 119;
            // 
            // comboEstado
            // 
            this.comboEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.impresoraBindingSource, "Estado", true));
            this.comboEstado.Enabled = false;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(140, 144);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(172, 21);
            this.comboEstado.TabIndex = 118;
            // 
            // comboMarca
            // 
            this.comboMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.impresoraBindingSource, "Marca", true));
            this.comboMarca.Enabled = false;
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(140, 15);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(172, 21);
            this.comboMarca.TabIndex = 117;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtEquipo);
            this.groupBox2.Controls.Add(this.lblCpu);
            this.groupBox2.Controls.Add(this.txtImpresora);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(85, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 214);
            this.groupBox2.TabIndex = 130;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IMPRESORA DATOS BASICOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::sistemaFCNM.Properties.Resources.espolLogo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(935, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 125);
            this.panel1.TabIndex = 128;
            // 
            // impresoraTableAdapter
            // 
            this.impresoraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaOficinaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.MicrofonoInventarioTableAdapter = null;
            this.tableAdapterManager.MicrofonoMarcaTableAdapter = null;
            this.tableAdapterManager.MicrofonoSerieTableAdapter = null;
            this.tableAdapterManager.MicrofonoTipoTableAdapter = null;
            this.tableAdapterManager.MouseInventarioTableAdapter = null;
            this.tableAdapterManager.MouseMarcaTableAdapter = null;
            this.tableAdapterManager.MouseModeloTableAdapter = null;
            this.tableAdapterManager.MouseSerieTableAdapter = null;
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
            this.tableAdapterManager.PantallaPulgadasTableAdapter = null;
            this.tableAdapterManager.PantallaSerieTableAdapter = null;
            this.tableAdapterManager.ParlanteInventarioTableAdapter = null;
            this.tableAdapterManager.ParlanteMarcaTableAdapter = null;
            this.tableAdapterManager.ParlanteModeloTableAdapter = null;
            this.tableAdapterManager.ParlanteSerieTableAdapter = null;
            this.tableAdapterManager.PropietarioTableAdapter = null;
            this.tableAdapterManager.ProyectorInventarioEspolTechTableAdapter = null;
            this.tableAdapterManager.ProyectorInventarioTableAdapter = null;
            this.tableAdapterManager.ProyectorMarcaTableAdapter = null;
            this.tableAdapterManager.ProyectorModeloTableAdapter = null;
            this.tableAdapterManager.ProyectorSerieTableAdapter = null;
            this.tableAdapterManager.RadioInventarioTableAdapter = null;
            this.tableAdapterManager.RadioMarcaTableAdapter = null;
            this.tableAdapterManager.RadioModeloTableAdapter = null;
            this.tableAdapterManager.RadioSerieTableAdapter = null;
            this.tableAdapterManager.ReguladorInventarioTableAdapter = null;
            this.tableAdapterManager.ReguladorMarcaTableAdapter = null;
            this.tableAdapterManager.ReguladorModeloTableAdapter = null;
            this.tableAdapterManager.ReguladorSerieTableAdapter = null;
            this.tableAdapterManager.ReguladorTipoTableAdapter = null;
            this.tableAdapterManager.TecladoInventarioTableAdapter = null;
            this.tableAdapterManager.TecladoMarcaTableAdapter = null;
            this.tableAdapterManager.TecladoModeloTableAdapter = null;
            this.tableAdapterManager.TecladoSerieTableAdapter = null;
            this.tableAdapterManager.TelefonoExtensionTableAdapter = null;
            this.tableAdapterManager.TelefonoInventarioTableAdapter = null;
            this.tableAdapterManager.TelefonoMarcaTableAdapter = null;
            this.tableAdapterManager.TelefonoModeloTableAdapter = null;
            this.tableAdapterManager.TelefonoSerieTableAdapter = null;
            this.tableAdapterManager.TelefonoTipoTableAdapter = null;
            this.tableAdapterManager.TipoUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sistemaFCNM.sistemasFCNMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // impresoraBindingNavigator
            // 
            this.impresoraBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.impresoraBindingNavigator.BindingSource = this.impresoraBindingSource;
            this.impresoraBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.impresoraBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.impresoraBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.impresoraBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.impresoraBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.impresoraBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.impresoraBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.impresoraBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.impresoraBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.impresoraBindingNavigator.Name = "impresoraBindingNavigator";
            this.impresoraBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.impresoraBindingNavigator.Size = new System.Drawing.Size(1088, 25);
            this.impresoraBindingNavigator.TabIndex = 131;
            this.impresoraBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // impresoraBindingNavigatorSaveItem
            // 
            this.impresoraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.impresoraBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("impresoraBindingNavigatorSaveItem.Image")));
            this.impresoraBindingNavigatorSaveItem.Name = "impresoraBindingNavigatorSaveItem";
            this.impresoraBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.impresoraBindingNavigatorSaveItem.Text = "Guardar datos";
            this.impresoraBindingNavigatorSaveItem.Click += new System.EventHandler(this.impresoraBindingNavigatorSaveItem_Click);
            // 
            // gridImpresora
            // 
            this.gridImpresora.AllowUserToAddRows = false;
            this.gridImpresora.AllowUserToDeleteRows = false;
            this.gridImpresora.AutoGenerateColumns = false;
            this.gridImpresora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridImpresora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridImpresora.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridImpresora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridImpresora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridImpresora.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.gridImpresora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridImpresora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridImpresora.ColumnHeadersHeight = 28;
            this.gridImpresora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridImpresora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estadoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.inventarioDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn});
            this.gridImpresora.DataSource = this.impresoraBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridImpresora.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridImpresora.EnableHeadersVisualStyles = false;
            this.gridImpresora.Location = new System.Drawing.Point(230, 337);
            this.gridImpresora.MultiSelect = false;
            this.gridImpresora.Name = "gridImpresora";
            this.gridImpresora.ReadOnly = true;
            this.gridImpresora.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridImpresora.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridImpresora.RowHeadersVisible = false;
            this.gridImpresora.RowHeadersWidth = 15;
            this.gridImpresora.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridImpresora.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.gridImpresora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridImpresora.Size = new System.Drawing.Size(601, 265);
            this.gridImpresora.TabIndex = 157;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 75;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Width = 75;
            // 
            // inventarioDataGridViewTextBoxColumn
            // 
            this.inventarioDataGridViewTextBoxColumn.DataPropertyName = "Inventario";
            this.inventarioDataGridViewTextBoxColumn.HeaderText = "Inventario";
            this.inventarioDataGridViewTextBoxColumn.Name = "inventarioDataGridViewTextBoxColumn";
            this.inventarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.inventarioDataGridViewTextBoxColumn.Width = 97;
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
            this.serieDataGridViewTextBoxColumn.Width = 64;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeloDataGridViewTextBoxColumn.Width = 81;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::sistemaFCNM.Properties.Resources.Modificar;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "modificar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Impresora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::sistemaFCNM.Properties.Resources.fondooo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1088, 685);
            this.Controls.Add(this.gridImpresora);
            this.Controls.Add(this.impresoraBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrevius);
            this.Controls.Add(this.btnNext);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Impresora";
            this.Text = "Impresora";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Impresora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.impresoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasFCNMDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impresoraBindingNavigator)).EndInit();
            this.impresoraBindingNavigator.ResumeLayout(false);
            this.impresoraBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridImpresora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtImpresora;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.Button btnPrevius;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private sistemasFCNMDataSet sistemasFCNMDataSet;
        private System.Windows.Forms.BindingSource impresoraBindingSource;
        private sistemasFCNMDataSetTableAdapters.ImpresoraTableAdapter impresoraTableAdapter;
        private sistemasFCNMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator impresoraBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton impresoraBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView gridImpresora;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboModelo;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}