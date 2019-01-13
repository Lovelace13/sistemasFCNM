using sistemaFCNM.Clases;

namespace sistemaFCNM.Vistas
{
    partial class CPU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPU));
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.cpuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemasFCNMDataSet = new sistemaFCNM.sistemasFCNMDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDisco = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMemoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProcesador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpu = new System.Windows.Forms.TextBox();
            this.lblCpu = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevius = new System.Windows.Forms.Button();
            this.cpuTableAdapter = new sistemaFCNM.sistemasFCNMDataSetTableAdapters.CpuTableAdapter();
            this.tableAdapterManager = new sistemaFCNM.sistemasFCNMDataSetTableAdapters.TableAdapterManager();
            this.cpuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cpuBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCpu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cpuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasFCNMDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuBindingNavigator)).BeginInit();
            this.cpuBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCpu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpuBindingSource, "Estado", true));
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(165, 102);
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(172, 31);
            this.txtEstado.TabIndex = 104;
            // 
            // cpuBindingSource
            // 
            this.cpuBindingSource.DataMember = "Cpu";
            this.cpuBindingSource.DataSource = this.sistemasFCNMDataSet;
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
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(45, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 105;
            this.label10.Text = "Estado";
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpuBindingSource, "Serie", true));
            this.txtSerie.Enabled = false;
            this.txtSerie.Location = new System.Drawing.Point(165, 65);
            this.txtSerie.Multiline = true;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(172, 31);
            this.txtSerie.TabIndex = 102;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(45, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 103;
            this.label11.Text = "Serie";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(0, 0);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 107;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 106;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpuBindingSource, "Marca", true));
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(165, 28);
            this.txtMarca.Multiline = true;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(172, 31);
            this.txtMarca.TabIndex = 98;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(45, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 99;
            this.label13.Text = "Marca";
            // 
            // txtLote
            // 
            this.txtLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpuBindingSource, "AdicionalLote", true));
            this.txtLote.Enabled = false;
            this.txtLote.Location = new System.Drawing.Point(144, 146);
            this.txtLote.Multiline = true;
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(193, 31);
            this.txtLote.TabIndex = 96;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(19, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 97;
            this.label14.Text = "Adicional / Lote";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDisco
            // 
            this.txtDisco.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDisco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpuBindingSource, "Disco", true));
            this.txtDisco.Enabled = false;
            this.txtDisco.Location = new System.Drawing.Point(289, 194);
            this.txtDisco.Multiline = true;
            this.txtDisco.Name = "txtDisco";
            this.txtDisco.Size = new System.Drawing.Size(48, 32);
            this.txtDisco.TabIndex = 94;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(244, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 95;
            this.label15.Text = "Disco";
            // 
            // txtMemoria
            // 
            this.txtMemoria.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMemoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMemoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpuBindingSource, "Memoria", true));
            this.txtMemoria.Enabled = false;
            this.txtMemoria.Location = new System.Drawing.Point(144, 247);
            this.txtMemoria.Multiline = true;
            this.txtMemoria.Name = "txtMemoria";
            this.txtMemoria.Size = new System.Drawing.Size(56, 32);
            this.txtMemoria.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "Memoria";
            // 
            // txtProcesador
            // 
            this.txtProcesador.BackColor = System.Drawing.Color.Gainsboro;
            this.txtProcesador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProcesador.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpuBindingSource, "Procesador", true));
            this.txtProcesador.Enabled = false;
            this.txtProcesador.Location = new System.Drawing.Point(144, 194);
            this.txtProcesador.Multiline = true;
            this.txtProcesador.Name = "txtProcesador";
            this.txtProcesador.Size = new System.Drawing.Size(56, 32);
            this.txtProcesador.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(46, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Procesador";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpuBindingSource, "Code", true));
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(129, 263);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(371, 31);
            this.txtCode.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(66, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Code";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTag
            // 
            this.txtTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpuBindingSource, "Tag", true));
            this.txtTag.Enabled = false;
            this.txtTag.Location = new System.Drawing.Point(129, 221);
            this.txtTag.Multiline = true;
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(172, 31);
            this.txtTag.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(73, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Tag";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPerfil
            // 
            this.txtPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPerfil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPerfil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpuBindingSource, "Perfil", true));
            this.txtPerfil.Enabled = false;
            this.txtPerfil.Location = new System.Drawing.Point(129, 178);
            this.txtPerfil.Multiline = true;
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(172, 31);
            this.txtPerfil.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(66, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Perfil";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpuBindingSource, "TipoPC", true));
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(129, 139);
            this.txtTipo.Multiline = true;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(172, 31);
            this.txtTipo.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(50, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Tipo PC";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpuBindingSource, "NombrePC", true));
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(129, 97);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 31);
            this.txtNombre.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(32, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Nombre PC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCpu
            // 
            this.txtCpu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCpu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpuBindingSource, "Inventario", true));
            this.txtCpu.Enabled = false;
            this.txtCpu.Location = new System.Drawing.Point(129, 53);
            this.txtCpu.Multiline = true;
            this.txtCpu.Name = "txtCpu";
            this.txtCpu.Size = new System.Drawing.Size(172, 31);
            this.txtCpu.TabIndex = 78;
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpu.ForeColor = System.Drawing.Color.Black;
            this.lblCpu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCpu.Location = new System.Drawing.Point(9, 59);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(93, 13);
            this.lblCpu.TabIndex = 79;
            this.lblCpu.Text = "Inventario CPU";
            this.lblCpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEquipo
            // 
            this.txtEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEquipo.Enabled = false;
            this.txtEquipo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEquipo.Location = new System.Drawing.Point(129, 10);
            this.txtEquipo.Multiline = true;
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(172, 31);
            this.txtEquipo.TabIndex = 108;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(56, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 109;
            this.label8.Text = "Equipo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtCpu);
            this.groupBox1.Controls.Add(this.lblCpu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPerfil);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEquipo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTag);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 302);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU DATOS BASICOS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtMarca);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtModelo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSerie);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtDisco);
            this.groupBox2.Controls.Add(this.txtLote);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtMemoria);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtProcesador);
            this.groupBox2.Location = new System.Drawing.Point(553, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 302);
            this.groupBox2.TabIndex = 126;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caracteristicas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(1015, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 125);
            this.panel1.TabIndex = 123;
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
            this.btnNext.TabIndex = 110;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevius
            // 
            this.btnPrevius.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevius.Enabled = false;
            this.btnPrevius.FlatAppearance.BorderSize = 0;
            this.btnPrevius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevius.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevius.Image")));
            this.btnPrevius.Location = new System.Drawing.Point(926, 627);
            this.btnPrevius.Name = "btnPrevius";
            this.btnPrevius.Size = new System.Drawing.Size(36, 34);
            this.btnPrevius.TabIndex = 111;
            this.btnPrevius.UseVisualStyleBackColor = false;
            // 
            // cpuTableAdapter
            // 
            this.cpuTableAdapter.ClearBeforeFill = true;
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
            //this.tableAdapterManager.ImpresoraTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.MicrofonoInventarioTableAdapter = null;
            this.tableAdapterManager.MicrofonoMarcaTableAdapter = null;
            this.tableAdapterManager.MicrofonoSerieTableAdapter = null;
            //this.tableAdapterManager.MicrofonoTableAdapter = null;
            this.tableAdapterManager.MicrofonoTipoTableAdapter = null;
            this.tableAdapterManager.MouseInventarioTableAdapter = null;
            this.tableAdapterManager.MouseMarcaTableAdapter = null;
            this.tableAdapterManager.MouseModeloTableAdapter = null;
            this.tableAdapterManager.MouseSerieTableAdapter = null;
           // this.tableAdapterManager.MouseTableAdapter = null;
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
            //this.tableAdapterManager.PantallaProyeccionTableAdapter = null;
            this.tableAdapterManager.PantallaPulgadasTableAdapter = null;
            this.tableAdapterManager.PantallaSerieTableAdapter = null;
            this.tableAdapterManager.ParlanteInventarioTableAdapter = null;
            this.tableAdapterManager.ParlanteMarcaTableAdapter = null;
            this.tableAdapterManager.ParlanteModeloTableAdapter = null;
            this.tableAdapterManager.ParlanteSerieTableAdapter = null;
           // this.tableAdapterManager.ParlanteTableAdapter = null;
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
            //this.tableAdapterManager.RadioTableAdapter = null;
            this.tableAdapterManager.ReguladorInventarioTableAdapter = null;
            this.tableAdapterManager.ReguladorMarcaTableAdapter = null;
            this.tableAdapterManager.ReguladorModeloTableAdapter = null;
            this.tableAdapterManager.ReguladorSerieTableAdapter = null;
            //this.tableAdapterManager.ReguladorTableAdapter = null;
            this.tableAdapterManager.ReguladorTipoTableAdapter = null;
            this.tableAdapterManager.TecladoInventarioTableAdapter = null;
            this.tableAdapterManager.TecladoMarcaTableAdapter = null;
            this.tableAdapterManager.TecladoModeloTableAdapter = null;
            this.tableAdapterManager.TecladoSerieTableAdapter = null;
           // this.tableAdapterManager.TecladoTableAdapter = null;
            this.tableAdapterManager.TelefonoExtensionTableAdapter = null;
            this.tableAdapterManager.TelefonoInventarioTableAdapter = null;
            this.tableAdapterManager.TelefonoMarcaTableAdapter = null;
            this.tableAdapterManager.TelefonoModeloTableAdapter = null;
            this.tableAdapterManager.TelefonoSerieTableAdapter = null;
            //this.tableAdapterManager.TelefonoTableAdapter = null;
            this.tableAdapterManager.TelefonoTipoTableAdapter = null;
            this.tableAdapterManager.TipoUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sistemaFCNM.sistemasFCNMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // cpuBindingNavigator
            // 
            this.cpuBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cpuBindingNavigator.BindingSource = this.cpuBindingSource;
            this.cpuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cpuBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cpuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cpuBindingNavigatorSaveItem});
            this.cpuBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cpuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cpuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cpuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cpuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cpuBindingNavigator.Name = "cpuBindingNavigator";
            this.cpuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cpuBindingNavigator.Size = new System.Drawing.Size(1256, 25);
            this.cpuBindingNavigator.TabIndex = 127;
            this.cpuBindingNavigator.Text = "bindingNavigator1";
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
            // cpuBindingNavigatorSaveItem
            // 
            this.cpuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cpuBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cpuBindingNavigatorSaveItem.Image")));
            this.cpuBindingNavigatorSaveItem.Name = "cpuBindingNavigatorSaveItem";
            this.cpuBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cpuBindingNavigatorSaveItem.Text = "Guardar datos";
            this.cpuBindingNavigatorSaveItem.Click += new System.EventHandler(this.cpuBindingNavigatorSaveItem_Click_1);
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn14.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Serie";
            this.dataGridViewTextBoxColumn13.HeaderText = "Serie";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn12.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "AdicionalLote";
            this.dataGridViewTextBoxColumn11.HeaderText = "AdicionalLote";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Disco";
            this.dataGridViewTextBoxColumn10.HeaderText = "Disco";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Memoria";
            this.dataGridViewTextBoxColumn9.HeaderText = "Memoria";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Procesador";
            this.dataGridViewTextBoxColumn8.HeaderText = "Procesador";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn7.HeaderText = "Code";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Perfil";
            this.dataGridViewTextBoxColumn5.HeaderText = "Perfil";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TipoPC";
            this.dataGridViewTextBoxColumn4.HeaderText = "TipoPC";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NombrePC";
            this.dataGridViewTextBoxColumn3.HeaderText = "NombrePC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Inventario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Inventario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // gridCpu
            // 
            this.gridCpu.AllowUserToAddRows = false;
            this.gridCpu.AllowUserToDeleteRows = false;
            this.gridCpu.AutoGenerateColumns = false;
            this.gridCpu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCpu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.gridCpu.DataSource = this.cpuBindingSource;
            this.gridCpu.Location = new System.Drawing.Point(24, 345);
            this.gridCpu.Name = "gridCpu";
            this.gridCpu.ReadOnly = true;
            this.gridCpu.Size = new System.Drawing.Size(1039, 220);
            this.gridCpu.TabIndex = 127;
            this.gridCpu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCpu_CellContentClick);
            // 
            // CPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(163)))), ((int)(((byte)(131)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1256, 685);
            this.ControlBox = false;
            this.Controls.Add(this.gridCpu);
            this.Controls.Add(this.cpuBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrevius);
            this.Controls.Add(this.btnNext);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CPU";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CPU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasFCNMDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuBindingNavigator)).EndInit();
            this.cpuBindingNavigator.ResumeLayout(false);
            this.cpuBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDisco;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMemoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProcesador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCpu;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevius;
        private sistemasFCNMDataSet sistemasFCNMDataSet;
        private System.Windows.Forms.BindingSource cpuBindingSource;
        private sistemasFCNMDataSetTableAdapters.CpuTableAdapter cpuTableAdapter;
        private sistemasFCNMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cpuBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cpuBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView gridCpu;
    }
}