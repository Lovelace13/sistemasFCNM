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
    public partial class Mouse : Form
    {
        public Mouse()
        {
            InitializeComponent();
        }

        private void Mouse_Load(object sender, EventArgs e)
        {
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
            }
            else
            {
                FuncionesUtiles.INVENTARIO_EQUIPO = Microsoft.VisualBasic.Interaction.InputBox("Inventario Equipo", "Registrar Busqueda", "", 600);

            }


            string sql = "select e.id_Equipo, m.Inventario_Mouse,car.estado,car.marca,"
                +"car.modelo,car.serie from  Equipo e, Mouse m, CPU ,"
                +"Caracteristicas car where e.Inventario_CPU = CPU.ID and"
                +" e.Mouse = m.ID and car.id_caracteristica = m.caracteristicas and e.id_Equipo = '"+FuncionesUtiles.INVENTARIO_EQUIPO+"'; ";

            Datos.llenarGrid(sql, gridMouse);
            llenarCampos();
        }

        private void llenarCampos()
        {

            if (gridMouse.Rows.Count == 1)
            {
                return;
            }
            txtEquipo.Text = gridMouse.Rows[0].Cells["id_Equipo"].Value.ToString();
            txtMouse.Text = gridMouse.Rows[0].Cells["Inventario_Mouse"].Value.ToString();
            txtEstado.Text = gridMouse.Rows[0].Cells["estado"].Value.ToString();
            txtMarca.Text = gridMouse.Rows[0].Cells["marca"].Value.ToString();
            txtModelo.Text = gridMouse.Rows[0].Cells["modelo"].Value.ToString();
            txtSerie.Text = gridMouse.Rows[0].Cells["serie"].Value.ToString();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Regulador(), mainPrincipal.contenedor);
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Teclado(), mainPrincipal.contenedor);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void guardarCsvMenuItem_Click(object sender, EventArgs e)
        {
            login log;
            switch (FuncionesUtiles.ventanaDialogo())
            {

                case "Yes":

                    guardar();
                    log = new login();
                    log.Show();
                    this.Visible = false;
                    FuncionesUtiles.form1.Visible = false;
                    FuncionesUtiles.INVENTARIO_EQUIPO = "";
                    return;

                case "No":
                    log = new login();
                    log.Show();
                    this.Visible = false;
                    FuncionesUtiles.form1.Visible = false;
                    FuncionesUtiles.INVENTARIO_EQUIPO = "";
                    return;

                case "Cancel":
                    return;

                default:
                    return;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (FuncionesUtiles.ventanaDialogo())
            {
                case "Yes":

                    guardar();
                    this.Close();
                    return;

                case "No":
                    this.Close();
                    return;

                case "Cancel":
                    return;

                default:
                    return;
            }
        }

        private void guardar()
        {
            string sql = "update va set va.Inventario_Mouse='" + txtMouse.Text + "'" +
               " from Equipo e,Mouse va where e.Mouse = va.ID and e.id_Equipo = '" + txtEquipo.Text + "';";


            Datos.Insertar(sql);

            sql = "update car set car.estado='" + txtEstado.Text + "',car.marca = '" + txtMarca.Text + "',car.modelo='" + txtModelo.Text + "',car.serie='" + txtSerie.Text + "' " +
                  " from Equipo e,Mouse va, Caracteristicas car " +
                  " where e.Mouse = va.ID and car.id_caracteristica = va.Caracteristicas and e.id_Equipo = '" + txtEquipo.Text + "'; ";


            Datos.Insertar(sql);
        }

        private void guardarMenuItem_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ventanaNuevoRegistro registro;
            switch (FuncionesUtiles.ventanaDialogo())
            {
                case "Yes":

                    guardar();
                    this.Close();
                    registro = new ventanaNuevoRegistro();
                    registro.Show();

                    return;

                case "No":
                    this.Close();
                    registro = new ventanaNuevoRegistro();
                    registro.Show();

                    return;

                case "Cancel":
                    return;

                default:
                    return;
            }
        }
    }
}
