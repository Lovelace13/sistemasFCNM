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
        public static string INVENTARIO_EQUIPO; 
        public Scanner()
        {
            InitializeComponent();
        }
              
        private void txtScanner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "select e.id_Equipo,o.nombre_oficina,inv.Ayudante,inv.fecha_inventario,"+
                    "c.inventario_cpu,p.Inventario_Pantalla,t.Inventario_teclado,m.Inventario_Mouse,"+
                    "par.Inventario_Parlante,reg.Inventario_Regulador,im.Inventario_Impresora,"+
                    "pro.Inventario_Proyector,mi.Inventario_Microfono,tel.Inventario_Telefono,"+
                    "pp.Inventario_PantallaProyeccion,ra.Inventario_Radio from  Equipo e,Oficina o, Pantalla p, Mouse m, "+
                    "Teclado t, CPU c,Parlante par, Regulador reg, Impresora im,Proyector pro,Microfonos mi, "+
                    "Telefono tel,Pantalla_Proyeccion pp,Radio ra,Inventario inv where e.Inventario_CPU= c.ID and "+
                    "e.Oficina = o.ID and e.id_Equipo = inv.Equipo and e.Pantalla = p.ID and e.Teclado = t.ID and "+
                    "e.Mouse = m.ID and e.Parlante = par.ID and e.Regulador = reg.ID and e.Impresora = im.ID and e.Telefono = tel.ID "+
                    "and e.PantallaProyeccion = pp.ID and e.Radios = ra.ID and e.Microfono = mi.ID and e.Proyector = pro.ID and "+
                    "e.id_Equipo = '"+txtScanner.Text.Trim()+"';";
                Datos.llenarGrid(sql, gridInventario);
                INVENTARIO_EQUIPO = txtScanner.Text.Trim();
                limpiarTxtandWait();
                llenarCampos();

            }
        }

        private void llenarCampos()
        {
            if (gridInventario.Rows.Count == 1)
            {
                return;
            }
            txtCpu.Text = gridInventario.Rows[0].Cells["inventario_cpu"].Value.ToString();
            txtAyudante.Text = gridInventario.Rows[0].Cells["Ayudante"].Value.ToString();
            txtFecha.Text = gridInventario.Rows[0].Cells["fecha_inventario"].Value.ToString();
            txtOficina.Text = gridInventario.Rows[0].Cells["nombre_oficina"].Value.ToString();
            txtPantalla.Text = gridInventario.Rows[0].Cells["Inventario_Pantalla"].Value.ToString();
            txtMouse.Text = gridInventario.Rows[0].Cells["Inventario_Mouse"].Value.ToString();
            txtTeclado.Text = gridInventario.Rows[0].Cells["Inventario_teclado"].Value.ToString();
            txtTelefono.Text = gridInventario.Rows[0].Cells["Inventario_Telefono"].Value.ToString();
            txtParlante.Text = gridInventario.Rows[0].Cells["Inventario_Parlante"].Value.ToString();
            txtProyeccion.Text = gridInventario.Rows[0].Cells["Inventario_PantallaProyeccion"].Value.ToString();
            txtProyector.Text = gridInventario.Rows[0].Cells["Inventario_Proyector"].Value.ToString();
            txtRadio.Text = gridInventario.Rows[0].Cells["Inventario_Radio"].Value.ToString();
            txtMicrofono.Text = gridInventario.Rows[0].Cells["Inventario_Microfono"].Value.ToString();
            txtImpresora.Text = gridInventario.Rows[0].Cells["Inventario_Impresora"].Value.ToString();
            txtRegulador.Text = gridInventario.Rows[0].Cells["Inventario_Regulador"].Value.ToString();
                        
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
            if (!FuncionesUtiles.masdetallesActiva)
            {
                FuncionesUtiles.masdetallesActiva = true;
            }
            FuncionesUtiles.abrirVentanas(new CPU(), mainPrincipal.contenedor);
        }

        private void btnDetalleTeclado_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Teclado(), mainPrincipal.contenedor);
        }

        private void btnDetallePantalla_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Pantalla(), mainPrincipal.contenedor);
        }

        private void btnDetalleMouse_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Mouse(), mainPrincipal.contenedor);
        }

        private void btnDetalleMicro_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Microfono(), mainPrincipal.contenedor);
        }

        private void btnDetallePproyeccion_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new PProyeccion(), mainPrincipal.contenedor);
        }

        private void btnDetalleRegulador_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Regulador(), mainPrincipal.contenedor);
        }

        private void btnDetalleProyector_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Proyector(), mainPrincipal.contenedor);
        }

        private void btnDetalleImpresora_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Impresora(), mainPrincipal.contenedor);
        }

        private void btnDetalleParlante_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Parlante(), mainPrincipal.contenedor);
        }

        private void btnDetalleTelef_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Telefono(), mainPrincipal.contenedor);
        }

        private void btnDetalleRadio_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Radio(), mainPrincipal.contenedor);
        }
    }
}
