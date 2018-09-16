using sistemaFCNM.Clases;
using sistemaFCNM.Vistas;
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
    public partial class mainPrincipal : Form
    {
        
        public mainPrincipal()
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


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("");
            }
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnScanner_Click(object sender, EventArgs e)
        {
            if (!VariablesUtiles.ventanaActiva)
            {
                Scanner ventana = new Scanner();
                ventana.MdiParent = this;
                ventana.Show();
                VariablesUtiles.ventanaActiva = true;
            }
            else
            {
                MessageBox.Show("Debe Cerrar Ventana");
            }
           
        }

        private void btnCpu_Click(object sender, EventArgs e)
        {
            CPU ventana = new CPU();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void btnPantalla_Click(object sender, EventArgs e)
        {
            Pantalla ventana = new Pantalla();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            Teclado ventana = new Teclado();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void btnMouse_Click(object sender, EventArgs e)
        {
            Mouse ventana = new Mouse();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void btnRegulador_Click(object sender, EventArgs e)
        {
            Regulador ventana = new Regulador();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void btnProyector_Click(object sender, EventArgs e)
        {
            Proyector ventana= new Proyector();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void btnImpresora_Click(object sender, EventArgs e)
        {
            Impresora ventana = new Impresora();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void btnParlante_Click(object sender, EventArgs e)
        {
            Parlante ventana = new Parlante();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
