using LibLlenarGrids;
using sistemaFCNM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistemaFCNM
{
    public partial class Scanner : Form
    {
        public Scanner()
        {
            InitializeComponent();
        }

        LlenarGrids llenarGrids = new LlenarGrids("Parametros.xml");
         
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Scanner_Load(object sender, EventArgs e)
        {
            llenarGrids.SQL = "select*from CPU;";
            llenarGrids.LlenarGridWindows(gridInventario);
        }

        private void txtScanner_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtScanner_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("");
            }
        }

        private void gridInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MouseMovimiento mouse = new MouseMovimiento(this);
        }

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
        {
            MouseMovimiento mouseMove = new MouseMovimiento(this);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(mouseMove.Form1_MouseMove);
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
    }
}
