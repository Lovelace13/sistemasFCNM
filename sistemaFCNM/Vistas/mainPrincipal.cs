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
using System.IO;
using System.Collections;

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
        
        
        private void btnCargarDocumento_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos csv (*.csv)|*.csv";
            ofd.Title = "Abrir";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName);
            }
            ofd.Dispose();


            StreamReader objReader = new StreamReader(ofd.FileName);
            string linea = "";
            LinkedList<String> oficina = new LinkedList<string>();
            LinkedList<String> edificio = new LinkedList<string>();
            LinkedList<String> tipoPC = new LinkedList<string>();
            LinkedList<String> estado = new LinkedList<string>();
            LinkedList<String> perfil = new LinkedList<string>();
            LinkedList<String> marcaCpu = new LinkedList<string>();
            LinkedList<String> procesador = new LinkedList<string>();
            LinkedList<String> memoria = new LinkedList<string>();
            LinkedList<String> disco = new LinkedList<string>();

            LinkedList<String> marcaPantalla = new LinkedList<string>();
            LinkedList<String> modeloPantalla = new LinkedList<string>();
            LinkedList<String> pulgadas = new LinkedList<string>();

            LinkedList<String> marcaTeclado = new LinkedList<string>();
            LinkedList<String> modeloTeclado = new LinkedList<string>();

            LinkedList<String> marcaMouse = new LinkedList<string>();
            LinkedList<String> modeloMouse = new LinkedList<string>();

            while (linea != null)
            {
                linea = objReader.ReadLine();
                try
                {
                    String[] campos = linea.Split(';');
                    FuncionesUtiles.agregar(oficina, 3, campos);
                    FuncionesUtiles.agregar(edificio, 2, campos);
                    FuncionesUtiles.agregar(tipoPC, 8, campos);
                    FuncionesUtiles.agregar(estado, 9, campos);
                    FuncionesUtiles.agregar(marcaCpu, 10, campos);
                    FuncionesUtiles.agregar(procesador, 15, campos);
                    FuncionesUtiles.agregar(memoria, 16, campos);
                    FuncionesUtiles.agregar(disco, 17, campos);
                    FuncionesUtiles.agregar(perfil, 11, campos);

                }
                catch (NullReferenceException)
                {
                    
                }
            }
            objReader.Close();
            foreach (String list in edificio)
            {
                Console.WriteLine(list);
            }
        }
           
   
    }
}        

        

