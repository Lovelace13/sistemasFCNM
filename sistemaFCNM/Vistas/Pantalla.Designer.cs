namespace sistemaFCNM.Vistas
{
    partial class Pantalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pantallaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemasFCNMDataSet = new sistemaFCNM.sistemasFCNMDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.lblCpu = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrevius = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboPulgadas = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pantallaTableAdapter = new sistemaFCNM.sistemasFCNMDataSetTableAdapters.PantallaTableAdapter();
            this.tableAdapterManager = new sistemaFCNM.sistemasFCNMDataSetTableAdapters.TableAdapterManager();
            this.pantallaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pantallaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.gridPantalla = new System.Windows.Forms.DataGridView();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pulgadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pantallaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasFCNMDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pantallaBindingNavigator)).BeginInit();
            this.pantallaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPantalla)).BeginInit();
            this.SuspendLayout();
            // 
            // pantallaBindingSource
            // 
            this.pantallaBindingSource.DataMember = "Pantalla";
            this.pantallaBindingSource.DataSource = this.sistemasFCNMDataSet;
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
            this.label10.Location = new System.Drawing.Point(26, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Estado";
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pantallaBindingSource, "Serie", true));
            this.txtSerie.Enabled = false;
            this.txtSerie.Location = new System.Drawing.Point(140, 94);
            this.txtSerie.Multiline = true;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(172, 31);
            this.txtSerie.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "Serie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Modelo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 68;
            this.label13.Text = "Marca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(30, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Pulgadas";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPantalla
            // 
            this.txtPantalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPantalla.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pantallaBindingSource, "Inventario", true));
            this.txtPantalla.Enabled = false;
            this.txtPantalla.Location = new System.Drawing.Point(150, 87);
            this.txtPantalla.Multiline = true;
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(172, 31);
            this.txtPantalla.TabIndex = 47;
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCpu.Location = new System.Drawing.Point(30, 93);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(114, 13);
            this.lblCpu.TabIndex = 48;
            this.lblCpu.Text = "Inventario Pantalla";
            this.lblCpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEquipo
            // 
            this.txtEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEquipo.Enabled = false;
            this.txtEquipo.Location = new System.Drawing.Point(150, 36);
            this.txtEquipo.Multiline = true;
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(172, 31);
            this.txtEquipo.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Equipo";
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
            this.btnPrevius.TabIndex = 115;
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
            this.btnNext.TabIndex = 114;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.comboPulgadas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCpu);
            this.groupBox1.Controls.Add(this.txtPantalla);
            this.groupBox1.Controls.Add(this.txtEquipo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(85, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 227);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PANTALLA DATOS BASICOS";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::sistemaFCNM.Properties.Resources.adicionar;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(210, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 24);
            this.button3.TabIndex = 164;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboPulgadas
            // 
            this.comboPulgadas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pantallaBindingSource, "Pulgadas", true));
            this.comboPulgadas.Enabled = false;
            this.comboPulgadas.FormattingEnabled = true;
            this.comboPulgadas.Location = new System.Drawing.Point(150, 138);
            this.comboPulgadas.Name = "comboPulgadas";
            this.comboPulgadas.Size = new System.Drawing.Size(54, 21);
            this.comboPulgadas.TabIndex = 114;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.comboModelo);
            this.groupBox2.Controls.Add(this.comboEstado);
            this.groupBox2.Controls.Add(this.comboMarca);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSerie);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(556, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 227);
            this.groupBox2.TabIndex = 117;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caracteristicas";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::sistemaFCNM.Properties.Resources.adicionar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(318, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 24);
            this.button2.TabIndex = 163;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::sistemaFCNM.Properties.Resources.adicionar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(318, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 24);
            this.button1.TabIndex = 162;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::sistemaFCNM.Properties.Resources.adicionar;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(318, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 24);
            this.btnAdd.TabIndex = 161;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboModelo
            // 
            this.comboModelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pantallaBindingSource, "Modelo", true));
            this.comboModelo.Enabled = false;
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(140, 59);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(172, 21);
            this.comboModelo.TabIndex = 116;
            // 
            // comboEstado
            // 
            this.comboEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pantallaBindingSource, "Estado", true));
            this.comboEstado.Enabled = false;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(140, 145);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(172, 21);
            this.comboEstado.TabIndex = 115;
            // 
            // comboMarca
            // 
            this.comboMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pantallaBindingSource, "Marca", true));
            this.comboMarca.Enabled = false;
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(140, 16);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(172, 21);
            this.comboMarca.TabIndex = 114;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::sistemaFCNM.Properties.Resources.espolLogo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(943, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 125);
            this.panel1.TabIndex = 154;
            // 
            // pantallaTableAdapter
            // 
            this.pantallaTableAdapter.ClearBeforeFill = true;
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
            // pantallaBindingNavigator
            // 
            this.pantallaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pantallaBindingNavigator.BindingSource = this.pantallaBindingSource;
            this.pantallaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pantallaBindingNavigator.DeleteItem = null;
            this.pantallaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pantallaBindingNavigatorSaveItem,
            this.btnEditar,
            this.toolStripButton1});
            this.pantallaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pantallaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pantallaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pantallaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pantallaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pantallaBindingNavigator.Name = "pantallaBindingNavigator";
            this.pantallaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pantallaBindingNavigator.Size = new System.Drawing.Size(1088, 25);
            this.pantallaBindingNavigator.TabIndex = 155;
            this.pantallaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::sistemaFCNM.Properties.Resources.Nuevo;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // pantallaBindingNavigatorSaveItem
            // 
            this.pantallaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pantallaBindingNavigatorSaveItem.Image = global::sistemaFCNM.Properties.Resources.Guardar;
            this.pantallaBindingNavigatorSaveItem.Name = "pantallaBindingNavigatorSaveItem";
            this.pantallaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pantallaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.pantallaBindingNavigatorSaveItem.Click += new System.EventHandler(this.pantallaBindingNavigatorSaveItem_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::sistemaFCNM.Properties.Resources.Modificar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "toolStripButton1";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gridPantalla
            // 
            this.gridPantalla.AllowUserToAddRows = false;
            this.gridPantalla.AllowUserToDeleteRows = false;
            this.gridPantalla.AutoGenerateColumns = false;
            this.gridPantalla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridPantalla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridPantalla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridPantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPantalla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridPantalla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.gridPantalla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPantalla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gridPantalla.ColumnHeadersHeight = 28;
            this.gridPantalla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPantalla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estadoDataGridViewTextBoxColumn,
            this.inventarioDataGridViewTextBoxColumn,
            this.pulgadasDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn});
            this.gridPantalla.DataSource = this.pantallaBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPantalla.DefaultCellStyle = dataGridViewCellStyle14;
            this.gridPantalla.EnableHeadersVisualStyles = false;
            this.gridPantalla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridPantalla.Location = new System.Drawing.Point(146, 337);
            this.gridPantalla.MultiSelect = false;
            this.gridPantalla.Name = "gridPantalla";
            this.gridPantalla.ReadOnly = true;
            this.gridPantalla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPantalla.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.gridPantalla.RowHeadersVisible = false;
            this.gridPantalla.RowHeadersWidth = 15;
            this.gridPantalla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPantalla.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.gridPantalla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPantalla.Size = new System.Drawing.Size(722, 265);
            this.gridPantalla.TabIndex = 156;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 75;
            // 
            // inventarioDataGridViewTextBoxColumn
            // 
            this.inventarioDataGridViewTextBoxColumn.DataPropertyName = "Inventario";
            this.inventarioDataGridViewTextBoxColumn.HeaderText = "Inventario";
            this.inventarioDataGridViewTextBoxColumn.Name = "inventarioDataGridViewTextBoxColumn";
            this.inventarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.inventarioDataGridViewTextBoxColumn.Width = 97;
            // 
            // pulgadasDataGridViewTextBoxColumn
            // 
            this.pulgadasDataGridViewTextBoxColumn.DataPropertyName = "Pulgadas";
            this.pulgadasDataGridViewTextBoxColumn.HeaderText = "Pulgadas";
            this.pulgadasDataGridViewTextBoxColumn.Name = "pulgadasDataGridViewTextBoxColumn";
            this.pulgadasDataGridViewTextBoxColumn.ReadOnly = true;
            this.pulgadasDataGridViewTextBoxColumn.Width = 93;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Width = 75;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeloDataGridViewTextBoxColumn.Width = 81;
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
            this.serieDataGridViewTextBoxColumn.Width = 64;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::sistemaFCNM.Properties.Resources.DESCARGA;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Pantalla
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = global::sistemaFCNM.Properties.Resources.fondooo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1088, 685);
            this.Controls.Add(this.gridPantalla);
            this.Controls.Add(this.pantallaBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrevius);
            this.Controls.Add(this.btnNext);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pantalla";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Pantalla";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pantalla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pantallaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasFCNMDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pantallaBindingNavigator)).EndInit();
            this.pantallaBindingNavigator.ResumeLayout(false);
            this.pantallaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPantalla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrevius;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private sistemasFCNMDataSet sistemasFCNMDataSet;
        private System.Windows.Forms.BindingSource pantallaBindingSource;
        private sistemasFCNMDataSetTableAdapters.PantallaTableAdapter pantallaTableAdapter;
        private sistemasFCNMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pantallaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pantallaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView gridPantalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pulgadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ComboBox comboPulgadas;
        private System.Windows.Forms.ComboBox comboModelo;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}