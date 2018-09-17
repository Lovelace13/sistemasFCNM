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
    public partial class Pantalla : Form
    {
        public Pantalla()
        {
            InitializeComponent();
        }

        private void Pantalla_Load(object sender, EventArgs e)
        {
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
            }
            else
            {
                FuncionesUtiles.INVENTARIO_EQUIPO = Microsoft.VisualBasic.Interaction.InputBox("Inventario Equipo", "Registrar Busqueda", "", 600);

            }


            string sql = "select e.id_Equipo, p.Inventario_Pantalla,p.pulgadas,car.estado,car.marca," +
                         "car.modelo,car.serie from  Equipo e, Pantalla p," +
                         "Caracteristicas car where car.id_caracteristica = p.caracteristicas and " +
                         "e.Pantalla = p.ID and e.id_Equipo = '"+ FuncionesUtiles.INVENTARIO_EQUIPO+ "';";
            
            Datos.llenarGrid(sql, gridPantalla);
            llenarCampos();
        }

        private void llenarCampos()
        {

            if (gridPantalla.Rows.Count == 1)
            {
                return;
            }
            txtPantalla.Text = gridPantalla.Rows[0].Cells["Inventario_Pantalla"].Value.ToString();
            txtPulgadas.Text = gridPantalla.Rows[0].Cells["pulgadas"].Value.ToString();
            txtEstado.Text = gridPantalla.Rows[0].Cells["estado"].Value.ToString();
            txtMarca.Text = gridPantalla.Rows[0].Cells["marca"].Value.ToString();
            txtModelo.Text = gridPantalla.Rows[0].Cells["modelo"].Value.ToString();
            txtSerie.Text = gridPantalla.Rows[0].Cells["serie"].Value.ToString();
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Teclado(), mainPrincipal.contenedor);
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new CPU(), mainPrincipal.contenedor);
        }
    }
}
