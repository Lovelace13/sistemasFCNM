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
    public partial class Main : Form
    {
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
        public Main()
        {
            InitializeComponent();
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
            btn11 = this.btnPproyeccion;
            btn12 = this.btnRadio;
            btn13 = this.btnScanner;
        }

        private void btnScanner_Click(object sender, EventArgs e)
        {
           
            FuncionesUtiles.siguienteActiva = true;
            FuncionesUtiles.abrirVentanas(new Equipos());

        }
        private void btnCpu_Click(object sender, EventArgs e)
        {

            FuncionesUtiles.abrirVentanas(new CPU());


        }

        private void btnPantalla_Click(object sender, EventArgs e)
        {

            FuncionesUtiles.abrirVentanas(new Vistas.Pantalla());

        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Teclado());
        }

        private void btnMouse_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Mouse());
        }

        private void btnRegulador_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Regulador());
        }

        private void btnProyector_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Proyector());
        }

        private void btnImpresora_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Impresora());
        }

        private void btnParlante_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Parlante());
        }

        private void btnMicro_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Microfono());
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Telefono());
        }

        private void btnPproyeccion_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.PProyeccion());
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Radio());
        }

        private void apagarBotones()
        {
            btnCpu.Visible = false;
            btnPantalla.Visible = false;
            btnTeclado.Visible = false;
            btnMouse.Visible = false;
            btnParlante.Visible = false;
            btnImpresora.Visible = false;
            btnProyector.Visible = false;
            btnRegulador.Visible = false;
            btnMicro.Visible = false;
            btnTelefono.Visible = false;
            btnPproyeccion.Visible = false;
            btnRadio.Visible = false;

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            FuncionesUtiles.form1.Visible = false;
            FuncionesUtiles.INVENTARIO_EQUIPO = "";
        }

        private void cargarDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Datos().crearListaObjetos();
        }

        private void guardarMenuItem_Click(object sender, EventArgs e)
        {
            Main.btn13.Visible = true;
            Main.btn1.Visible = true;
            Main.btn2.Visible = true;
            Main.btn3.Visible = true;
            Main.btn4.Visible = true;
            Main.btn5.Visible = true;
            Main.btn6.Visible = true;
            Main.btn7.Visible = true;
            Main.btn8.Visible = true;
            Main.btn9.Visible = true;
            Main.btn10.Visible = true;
            Main.btn11.Visible = true;
            Main.btn12.Visible = true;
            FuncionesUtiles.siguienteActiva = false;
            FuncionesUtiles.INVENTARIO_EQUIPO = "";
            FuncionesUtiles.masdetallesActiva = false;
            FuncionesUtiles.OBSERVACION = "";
            this.Visible = false;
            FuncionesUtiles.form1 = new Main();
            FuncionesUtiles.form1.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            GC.Collect();
        }
    }
}
