using LibLlenarGrids;
using sistemaFCNM.Clases;
using sistemaFCNM.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace sistemaFCNM
{
    public partial class Scanner : Form
    {
        public Scanner()
        {
            InitializeComponent();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MouseMovimiento mouse = new MouseMovimiento(this);
        }

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
        {
            MouseMovimiento mouseMove = new MouseMovimiento(this);
            this.menuSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(mouseMove.Form1_MouseMove);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtScanner_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                llenarGrid();

            }
        }

        private void llenarGrid()
        {
            LlenarGrids llenarGrids = new LlenarGrids("Parametros.xml");
            gridInventario.DataSource = null;
            llenarGrids.SQL = "select e.id_Equipo, p.Inventario_Pantalla,p.pulgadas,car.estado,car.marca,car.modelo,car.serie " +
            "from Equipo e, Pantalla p, Mouse m, Teclado t, CPU, " +
            "Caracteristicas car where e.Inventario_CPU = CPU.ID and e.Pantalla = p.ID " +
            "and e.Mouse = m.ID and e.Teclado = t.ID and car.id_caracteristica = p.caracteristicas  and e.id_Equipo ='" + txtScanner.Text.Trim() + "'; ";
            //MessageBox.Show(""+txtScanner.Text.Length);
            llenarGrids.LlenarGridWindows(gridInventario);
            try
            {
                Thread.Sleep(1200);
            }
            catch (Exception)
            {

                throw;
            }
            txtScanner.Clear();
            
        }

        private void btnDetalleCpu_Click(object sender, EventArgs e)
        {
            CPU ventana = new CPU();
            ventana.MdiParent = Program.form1;
            ventana.Show();
        }
    }
}
