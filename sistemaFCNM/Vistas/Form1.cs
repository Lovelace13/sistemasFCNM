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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void panelCabecera_Paint(object sender, PaintEventArgs e)
        {
            MouseMovimiento mouseMove = new MouseMovimiento(this); 
            this.panelCabecera.MouseMove += new System.Windows.Forms.MouseEventHandler(mouseMove.Form1_MouseMove);
        }

        private void tmOcultarMenu_Tick(object sender, EventArgs e)
        {
            if (this.panelMenu.Width <= 60)
            {
                this.tmOcultarMenu.Enabled = false;
            }
            else
            {
                this.panelMenu.Width = panelMenu.Width - 20;
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (this.panelMenu.Width >= 220)
            {
                this.tmOcultarMenu.Enabled = false;
            }
            else
            {
                this.panelMenu.Width = panelMenu.Width + 20;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (this.panelMenu.Width==220)
            {
                tmOcultarMenu.Enabled = true;
            }
            else if (this.panelMenu.Width == 60)
            {
                tmMostrarMenu.Enabled = true;
            }
        }

       

       
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scanner ventana = new Scanner();
            TabPage tab = new TabPage { Text = ventana.Text };
            tabControl.TabPages.Add(tab);

            ventana.TopLevel = false;
            ventana.Parent = tab;
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        

        private void tabScanner_Click(object sender, EventArgs e)
        {

        }

        private void tabCpu_Click(object sender, EventArgs e)
        {
           

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
