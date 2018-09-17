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
    public partial class Teclado : Form
    {
        public Teclado()
        {
            InitializeComponent();
        }

        private void Teclado_Load(object sender, EventArgs e)
        {
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
            }
            else
            {
                FuncionesUtiles.INVENTARIO_EQUIPO = Microsoft.VisualBasic.Interaction.InputBox("Inventario Equipo", "Registrar Busqueda", "", 600);

            }


            string sql = "select e.id_Equipo, t.Inventario_teclado,car.estado,car.marca,"+
                         "car.modelo,car.serie from  Equipo e, Teclado t, CPU ,"+
                         "Caracteristicas car where e.Inventario_CPU = CPU.ID and"+
                         " e.Teclado = t.ID and car.id_caracteristica = t.caracteristicas and e.id_Equipo = '" + FuncionesUtiles.INVENTARIO_EQUIPO + "'; ";

            Datos.llenarGrid(sql, gridTeclado);
            llenarCampos();
        }

        private void llenarCampos()
        {

            if (gridTeclado.Rows.Count == 1)
            {
                return;
            }
            txtTeclado.Text = gridTeclado.Rows[0].Cells["Inventario_teclado"].Value.ToString();
            txtEstado.Text = gridTeclado.Rows[0].Cells["estado"].Value.ToString();
            txtMarca.Text = gridTeclado.Rows[0].Cells["marca"].Value.ToString();
            txtModelo.Text = gridTeclado.Rows[0].Cells["modelo"].Value.ToString();
            txtSerie.Text = gridTeclado.Rows[0].Cells["serie"].Value.ToString();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Mouse(), mainPrincipal.contenedor);
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Pantalla(), mainPrincipal.contenedor);
        }
    }
}
