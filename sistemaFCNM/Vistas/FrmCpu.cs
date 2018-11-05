using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaFCNM.Vistas
{
    public partial class FrmCpu : Form
    {
        public FrmCpu()
        {
            InitializeComponent();
        }

        private void cPUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cPUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemasFCNMDataSet);

        }

        private void FrmCpu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Caracteristicas' Puede moverla o quitarla según sea necesario.
            this.caracteristicasTableAdapter.Fill(this.sistemasFCNMDataSet.Caracteristicas);
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.CPU' Puede moverla o quitarla según sea necesario.
            this.cPUTableAdapter.Fill(this.sistemasFCNMDataSet.CPU);

        }

        private void cPUDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
