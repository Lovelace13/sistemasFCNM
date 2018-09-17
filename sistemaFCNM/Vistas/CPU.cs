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
    public partial class CPU : Form
    {
        public CPU()
        {
            InitializeComponent();
        }

        private void CPU_Load(object sender, EventArgs e)
        {
            if (FuncionesUtiles.masdetallesActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
            }
            else
            {
                FuncionesUtiles.INVENTARIO_EQUIPO = Microsoft.VisualBasic.Interaction.InputBox("Inventario Equipo", "Registrar Busqueda", "", 600);
                
            }


            string sql = "select e.id_Equipo, c.inventario_cpu,c.nombre_PC,c.adicional_lote," +
                   "c.tipo_PC,c.tag,c.code,c.perfil,c.procesador,c.memoria,c.disco," +
                   "car.estado,car.marca,car.modelo,car.serie from  Equipo e, CPU c," +
                   "Caracteristicas car where e.Inventario_CPU = c.ID and "+
                   "car.id_caracteristica = c.caracteristicas and e.id_Equipo = '" + FuncionesUtiles.INVENTARIO_EQUIPO + "'; ";
            Datos.llenarGrid(sql, gridCpu);
            llenarCampos();
        }

        private void llenarCampos()
        {

            if (gridCpu.Rows.Count == 1)
            {
                return;
            }
            txtCpu.Text= gridCpu.Rows[0].Cells["inventario_cpu"].Value.ToString();
            txtNombre.Text = gridCpu.Rows[0].Cells["nombre_PC"].Value.ToString();
            txtTipo.Text = gridCpu.Rows[0].Cells["tipo_PC"].Value.ToString();
            txtTag.Text = gridCpu.Rows[0].Cells["tag"].Value.ToString();
            txtCode.Text = gridCpu.Rows[0].Cells["code"].Value.ToString();
            txtPerfil.Text = gridCpu.Rows[0].Cells["perfil"].Value.ToString();
            txtProcesador.Text = gridCpu.Rows[0].Cells["procesador"].Value.ToString();
            txtMemoria.Text = gridCpu.Rows[0].Cells["memoria"].Value.ToString();
            txtDisco.Text = gridCpu.Rows[0].Cells["disco"].Value.ToString();
            txtEstado.Text = gridCpu.Rows[0].Cells["estado"].Value.ToString();
            txtMarca.Text = gridCpu.Rows[0].Cells["marca"].Value.ToString();
            txtModelo.Text = gridCpu.Rows[0].Cells["modelo"].Value.ToString();
            txtSerie.Text = gridCpu.Rows[0].Cells["serie"].Value.ToString();
            txtLote.Text = gridCpu.Rows[0].Cells["adicional_lote"].Value.ToString();
        }
    }
}
