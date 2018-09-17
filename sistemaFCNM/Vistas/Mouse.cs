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
    }
}
