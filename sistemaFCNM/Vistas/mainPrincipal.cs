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
            abrirVentanas(new Scanner());
        }

        private void btnCpu_Click(object sender, EventArgs e)
        {
            abrirVentanas(new CPU());
            


        }

        private void btnPantalla_Click(object sender, EventArgs e)
        {
            abrirVentanas(new Pantalla());
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            abrirVentanas(new Teclado());
        }

        private void btnMouse_Click(object sender, EventArgs e)
        {
            abrirVentanas(new Mouse());
        }

        private void btnRegulador_Click(object sender, EventArgs e)
        {
            abrirVentanas(new Regulador());
        }

        private void btnProyector_Click(object sender, EventArgs e)
        {
            abrirVentanas(new Proyector());
        }

        private void btnImpresora_Click(object sender, EventArgs e)
        {
            abrirVentanas(new Impresora());
        }

        private void btnParlante_Click(object sender, EventArgs e)
        {
            abrirVentanas(new Parlante());
        }

        private void timerOcultarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 60)
            {
                this.timerOcultarMenu.Enabled = false;
            }
            else
            {
                this.panelMenu.Width = this.panelMenu.Width - 20;
            }
        }

        //Sumara 20 cada  100ms
        private void timerMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 220)
            {
                this.timerMostrarMenu.Enabled = false;
            }
            else
            {
                this.panelMenu.Width = this.panelMenu.Width + 20;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 220)
            {
                timerOcultarMenu.Enabled = true;
                imgLogoBig.Visible = false;
                imgLogoMini.Visible = true;

            }
            else if (panelMenu.Width == 60)
            {
                timerMostrarMenu.Enabled = true;
                imgLogoMini.Visible = false;
                imgLogoBig.Visible = true;
            }

        }

        private void abrirVentanas(Form ventana)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);

            }
            ventana.TopLevel = false;
            ventana.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(ventana);
            this.panelContenedor.Tag = ventana;
            ventana.Show();
        }

        private void btnMicro_Click(object sender, EventArgs e)
        {
            abrirVentanas(new Microfono());
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            abrirVentanas(new Telefono());
        }

        private void btnPproyeccion_Click(object sender, EventArgs e)
        {
            abrirVentanas(new PProyeccion());
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            abrirVentanas(new Radio());
        }
    }
}
