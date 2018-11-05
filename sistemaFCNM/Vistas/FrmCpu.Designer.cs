namespace sistemaFCNM.Vistas
{
    partial class FrmCpu
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
            System.Windows.Forms.Label procesadorLabel;
            System.Windows.Forms.Label memoriaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCpu));
            this.sistemasFCNMDataSet = new sistemaFCNM.sistemasFCNMDataSet();
            this.cPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPUTableAdapter = new sistemaFCNM.sistemasFCNMDataSetTableAdapters.CPUTableAdapter();
            this.tableAdapterManager = new sistemaFCNM.sistemasFCNMDataSetTableAdapters.TableAdapterManager();
            this.caracteristicasTableAdapter = new sistemaFCNM.sistemasFCNMDataSetTableAdapters.CaracteristicasTableAdapter();
            this.cPUBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cPUBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.procesadorTextBox = new System.Windows.Forms.TextBox();
            this.memoriaTextBox = new System.Windows.Forms.TextBox();
            this.caracteristicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPUDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            procesadorLabel = new System.Windows.Forms.Label();
            memoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasFCNMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingNavigator)).BeginInit();
            this.cPUBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caracteristicasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // procesadorLabel
            // 
            procesadorLabel.AutoSize = true;
            procesadorLabel.Location = new System.Drawing.Point(100, 53);
            procesadorLabel.Name = "procesadorLabel";
            procesadorLabel.Size = new System.Drawing.Size(63, 13);
            procesadorLabel.TabIndex = 2;
            procesadorLabel.Text = "procesador:";
            // 
            // memoriaLabel
            // 
            memoriaLabel.AutoSize = true;
            memoriaLabel.Location = new System.Drawing.Point(114, 79);
            memoriaLabel.Name = "memoriaLabel";
            memoriaLabel.Size = new System.Drawing.Size(49, 13);
            memoriaLabel.TabIndex = 4;
            memoriaLabel.Text = "memoria:";
            // 
            // sistemasFCNMDataSet
            // 
            this.sistemasFCNMDataSet.DataSetName = "sistemasFCNMDataSet";
            this.sistemasFCNMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cPUBindingSource
            // 
            this.cPUBindingSource.DataMember = "CPU";
            this.cPUBindingSource.DataSource = this.sistemasFCNMDataSet;
            // 
            // cPUTableAdapter
            // 
            this.cPUTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CaracteristicasTableAdapter = this.caracteristicasTableAdapter;
            this.tableAdapterManager.EdificioTableAdapter = null;
            this.tableAdapterManager.EquipoTableAdapter = null;
            this.tableAdapterManager.ImpresoraTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.MicrofonosTableAdapter = null;
            this.tableAdapterManager.MouseTableAdapter = null;
            this.tableAdapterManager.OficinaTableAdapter = null;
            this.tableAdapterManager.Pantalla_ProyeccionTableAdapter = null;
            this.tableAdapterManager.PantallaTableAdapter = null;
            this.tableAdapterManager.ParlanteTableAdapter = null;
            this.tableAdapterManager.ProyectorTableAdapter = null;
            this.tableAdapterManager.RadioTableAdapter = null;
            this.tableAdapterManager.ReguladorTableAdapter = null;
            this.tableAdapterManager.TecladoTableAdapter = null;
            this.tableAdapterManager.TelefonoTableAdapter = null;
            this.tableAdapterManager.tipo_userTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sistemaFCNM.sistemasFCNMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // caracteristicasTableAdapter
            // 
            this.caracteristicasTableAdapter.ClearBeforeFill = true;
            // 
            // cPUBindingNavigator
            // 
            this.cPUBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cPUBindingNavigator.BindingSource = this.cPUBindingSource;
            this.cPUBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cPUBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cPUBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cPUBindingNavigatorSaveItem});
            this.cPUBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cPUBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cPUBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cPUBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cPUBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cPUBindingNavigator.Name = "cPUBindingNavigator";
            this.cPUBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cPUBindingNavigator.Size = new System.Drawing.Size(1347, 25);
            this.cPUBindingNavigator.TabIndex = 0;
            this.cPUBindingNavigator.Text = "bindingNavigator1";
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
            // cPUBindingNavigatorSaveItem
            // 
            this.cPUBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cPUBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cPUBindingNavigatorSaveItem.Image")));
            this.cPUBindingNavigatorSaveItem.Name = "cPUBindingNavigatorSaveItem";
            this.cPUBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cPUBindingNavigatorSaveItem.Text = "Guardar datos";
            this.cPUBindingNavigatorSaveItem.Click += new System.EventHandler(this.cPUBindingNavigatorSaveItem_Click);
            // 
            // procesadorTextBox
            // 
            this.procesadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cPUBindingSource, "procesador", true));
            this.procesadorTextBox.Location = new System.Drawing.Point(169, 50);
            this.procesadorTextBox.Name = "procesadorTextBox";
            this.procesadorTextBox.Size = new System.Drawing.Size(100, 20);
            this.procesadorTextBox.TabIndex = 3;
            // 
            // memoriaTextBox
            // 
            this.memoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cPUBindingSource, "memoria", true));
            this.memoriaTextBox.Location = new System.Drawing.Point(169, 76);
            this.memoriaTextBox.Name = "memoriaTextBox";
            this.memoriaTextBox.Size = new System.Drawing.Size(100, 20);
            this.memoriaTextBox.TabIndex = 5;
            // 
            // caracteristicasBindingSource
            // 
            this.caracteristicasBindingSource.DataMember = "Caracteristicas";
            this.caracteristicasBindingSource.DataSource = this.sistemasFCNMDataSet;
            // 
            // cPUDataGridView
            // 
            this.cPUDataGridView.AutoGenerateColumns = false;
            this.cPUDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cPUDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
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
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.cPUDataGridView.DataSource = this.cPUBindingSource;
            this.cPUDataGridView.Location = new System.Drawing.Point(12, 252);
            this.cPUDataGridView.Name = "cPUDataGridView";
            this.cPUDataGridView.Size = new System.Drawing.Size(1298, 220);
            this.cPUDataGridView.TabIndex = 8;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "inventario_cpu";
            this.dataGridViewTextBoxColumn2.HeaderText = "inventario_cpu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre_PC";
            this.dataGridViewTextBoxColumn3.HeaderText = "nombre_PC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tipo_PC";
            this.dataGridViewTextBoxColumn4.HeaderText = "tipo_PC";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "perfil";
            this.dataGridViewTextBoxColumn5.HeaderText = "perfil";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tag";
            this.dataGridViewTextBoxColumn6.HeaderText = "tag";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "code";
            this.dataGridViewTextBoxColumn7.HeaderText = "code";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "procesador";
            this.dataGridViewTextBoxColumn8.HeaderText = "procesador";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "memoria";
            this.dataGridViewTextBoxColumn9.HeaderText = "memoria";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "disco";
            this.dataGridViewTextBoxColumn10.HeaderText = "disco";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "adicional_lote";
            this.dataGridViewTextBoxColumn11.HeaderText = "adicional_lote";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "marca";
            this.dataGridViewTextBoxColumn18.HeaderText = "marca";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "modelo";
            this.dataGridViewTextBoxColumn19.HeaderText = "modelo";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "serie";
            this.dataGridViewTextBoxColumn20.HeaderText = "serie";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn21.HeaderText = "estado";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // FrmCpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 535);
            this.Controls.Add(this.cPUDataGridView);
            this.Controls.Add(memoriaLabel);
            this.Controls.Add(this.memoriaTextBox);
            this.Controls.Add(procesadorLabel);
            this.Controls.Add(this.procesadorTextBox);
            this.Controls.Add(this.cPUBindingNavigator);
            this.Name = "FrmCpu";
            this.Text = "FrmCpu";
            this.Load += new System.EventHandler(this.FrmCpu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemasFCNMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingNavigator)).EndInit();
            this.cPUBindingNavigator.ResumeLayout(false);
            this.cPUBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caracteristicasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistemasFCNMDataSet sistemasFCNMDataSet;
        private System.Windows.Forms.BindingSource cPUBindingSource;
        private sistemasFCNMDataSetTableAdapters.CPUTableAdapter cPUTableAdapter;
        private sistemasFCNMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cPUBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cPUBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox procesadorTextBox;
        private System.Windows.Forms.TextBox memoriaTextBox;
        private sistemasFCNMDataSetTableAdapters.CaracteristicasTableAdapter caracteristicasTableAdapter;
        private System.Windows.Forms.BindingSource caracteristicasBindingSource;
        private System.Windows.Forms.DataGridView cPUDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    }
}