using sistemaFCNM.Clases;
using sistemaFCNM.Vistas;
using System;
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
            btn11 = this.btnPproyeccion;
            btn12 = this.btnRadio;
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


        private void btnScanner_Click(object sender, EventArgs e)
        {
            apagarBotones();
            FuncionesUtiles.siguienteActiva = true;
            FuncionesUtiles.abrirVentanas(new Equipos(), contenedor);
           
           
            
        }

        private void btnCpu_Click(object sender, EventArgs e)
        {

            FuncionesUtiles.abrirVentanas(new CPU(), contenedor);


        }

        private void btnPantalla_Click(object sender, EventArgs e)
        {

            FuncionesUtiles.abrirVentanas(new Vistas.Pantalla(), contenedor);

        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Teclado(), contenedor);
        }

        private void btnMouse_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Mouse(), contenedor);
        }

        private void btnRegulador_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Regulador(), contenedor);
        }

        private void btnProyector_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Proyector(), contenedor);
        }

        private void btnImpresora_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Impresora(), contenedor);
        }

        private void btnParlante_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Parlante(), contenedor);
        }

        private void btnMicro_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Microfono(), contenedor);
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Telefono(), contenedor);
        }

        private void btnPproyeccion_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.PProyeccion(), contenedor);
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Vistas.Radio(), contenedor);
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
            this.Close();
            FuncionesUtiles.form1.Visible = false;
            FuncionesUtiles.INVENTARIO_EQUIPO = "";
        }

        private void cargarDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Datos().crearListaObjetos();
        }

        private void guardarMenuItem_Click(object sender, EventArgs e)
        {
            mainPrincipal.btn13.Visible = true;
            mainPrincipal.btn1.Visible = true;
            mainPrincipal.btn2.Visible = true;
            mainPrincipal.btn3.Visible = true;
            mainPrincipal.btn4.Visible = true;
            mainPrincipal.btn5.Visible = true;
            mainPrincipal.btn6.Visible = true;
            mainPrincipal.btn7.Visible = true;
            mainPrincipal.btn8.Visible = true;
            mainPrincipal.btn9.Visible = true;
            mainPrincipal.btn10.Visible = true;
            mainPrincipal.btn11.Visible = true;
            mainPrincipal.btn12.Visible = true;
            FuncionesUtiles.siguienteActiva = false;
            FuncionesUtiles.INVENTARIO_EQUIPO = "";
            FuncionesUtiles.masdetallesActiva = false;
            FuncionesUtiles.OBSERVACION = "";
            this.Visible = false;
            FuncionesUtiles.form1 = new mainPrincipal();
            FuncionesUtiles.form1.Show();
        }
    }
}



