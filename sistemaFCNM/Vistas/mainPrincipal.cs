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
        public static FlowLayoutPanel contenedor;
        public static Button btn1;
        public static Button btn2;
        public static Button btn3;
        public static Button btn4;
        public static Button btn5;
        public static Button btn6;
        public static Button btn7;
        public static Button btn8;
        public static Button btn9;
        public static Button btn10;
        public static Button btn11;
        public static Button btn12;
        public static Button btn13;


        public mainPrincipal()
        {
            InitializeComponent();
            contenedor = this.panelContenedor;
            btn1 = this.btnCpu;
            btn2 = this.btnPantalla;
            btn3 = this.btnTeclado;
            btn4 = this.btnMouse;
            btn5 = this.btnParlante;
            btn6 = this.btnImpresora;
            btn7 = this.btnProyector;
            btn8 = this.btnRegulador;
            btn9 = this.btnMicro;
            btn10 = this.btnTelefono;
            btn11= this.btnPproyeccion;
            btn12= this.btnRadio;
            btn13 = this.btnScanner;
        }
       
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnScanner_Click(object sender, EventArgs e)
        {
            apagarBotones();
            FuncionesUtiles.siguienteActiva = true;
            FuncionesUtiles.abrirVentanas(new Scanner(),contenedor);
        }

        private void btnCpu_Click(object sender, EventArgs e)
        {
            
            FuncionesUtiles.abrirVentanas(new CPU(), contenedor);
            
            
        }

        private void btnPantalla_Click(object sender, EventArgs e)
        {
            
            FuncionesUtiles.abrirVentanas(new Pantalla(), contenedor);
            
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Teclado(), contenedor);
        }

        private void btnMouse_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Mouse(), contenedor);
        }

        private void btnRegulador_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Regulador(), contenedor);
        }

        private void btnProyector_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Proyector(), contenedor);
        }

        private void btnImpresora_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Impresora(), contenedor);
        }

        private void btnParlante_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Parlante(), contenedor);
        }

        private void btnMicro_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Microfono(), contenedor);
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Telefono(), contenedor);
        }

        private void btnPproyeccion_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new PProyeccion(), contenedor);
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Radio(), contenedor);
        }

        private void apagarBotones()
        {
            btnCpu.Enabled = false;
            btnPantalla.Enabled = false;
            btnTeclado.Enabled = false;
            btnMouse.Enabled = false;
            btnParlante.Enabled = false;
            btnImpresora.Enabled = false;
            btnProyector.Enabled = false;
            btnRegulador.Enabled = false;
            btnMicro.Enabled = false;
            btnTelefono.Enabled = false;
            btnPproyeccion.Enabled = false;
            btnRadio.Enabled = false;
            
       }

        private void mainPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}        

        

