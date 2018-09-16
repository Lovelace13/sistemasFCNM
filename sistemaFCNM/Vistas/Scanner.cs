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
            VariablesUtiles.ventanaActiva = false;
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
                string sql = "select e.id_Equipo,o.nombre_oficina,inv.Ayudante,inv.fecha_inventario,c.inventario_cpu,p.Inventario_Pantalla,t.Inventario_teclado,m.Inventario_Mouse,par.Inventario_Parlante,reg.Inventario_Regulador,im.Inventario_Impresora,pro.Inventario_Proyector,mi.Inventario_Microfono,tel.Inventario_Telefono,pp.Inventario_PantallaProyeccion,ra.Inventario_Radio from  Equipo e,Oficina o, Pantalla p, Mouse m, Teclado t, CPU c,Parlante par, Regulador reg, Impresora im,Proyector pro,Microfonos mi, Telefono tel,Pantalla_Proyeccion pp,Radio ra,Inventario inv where e.Inventario_CPU= c.ID and e.Oficina = o.ID and e.id_Equipo = inv.Equipo and e.Pantalla = p.ID and e.Teclado = t.ID and e.Mouse = m.ID and e.Parlante = par.ID and e.Regulador = reg.ID and e.Impresora = im.ID and e.Telefono = tel.ID and e.PantallaProyeccion = pp.ID and e.Radios = ra.ID and e.Microfono = mi.ID and e.Proyector = pro.ID and e.id_Equipo = '"+txtScanner.Text.Trim()+"';";
                Datos.llenarGrid(sql, gridInventario);
                limpiarTxtandWait();

            }
        }



        private void limpiarTxtandWait()
        {
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

        private void btnDetalleTeclado_Click(object sender, EventArgs e)
        {

        }
    }
}
