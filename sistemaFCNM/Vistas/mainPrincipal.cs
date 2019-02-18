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
    }
}



