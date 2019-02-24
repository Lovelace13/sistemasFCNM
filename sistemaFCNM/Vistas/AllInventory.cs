using sistemaFCNM.Clases;
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
    public partial class AllInventory : Form
    {
        public AllInventory()
        {
            InitializeComponent();
        }

        private void fillByAllToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.equipoTableAdapter.FillByAll(this.sistemasFCNMDataSet.Equipo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void AllInventory_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);

        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            Datos.writeCSV(gridInventarioAll, "C:\\Users\\JULIO\\Downloads\\InventarioReporte.csv");
            MessageBox.Show("Descargado!!");
        }
    }
}
