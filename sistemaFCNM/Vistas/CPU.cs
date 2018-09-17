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
    public partial class CPU : Form
    {
        public CPU()
        {
            InitializeComponent();
        }

        private void CPU_Load(object sender, EventArgs e)
        {
            if (FuncionesUtiles.masdetallesActiva)
            {
                string sql = "";
                FuncionesUtiles.masdetallesActiva = false;
            }
            else
            {
                string s = Microsoft.VisualBasic.Interaction.InputBox("Inventario Equipo", "Registrar Busqueda", "", 600);
                MessageBox.Show("Ingrese Id Equipo");
            }
        }
    }
}
