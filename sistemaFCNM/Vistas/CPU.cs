using sistemaFCNM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        void myButton_Click(Object sender, System.EventArgs e)
        {
            MessageBox.Show("Click");
        }
        private void CPU_Load(object sender, EventArgs e)
        {
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
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
            txtEquipo.Text = gridCpu.Rows[0].Cells["id_Equipo"].Value.ToString();
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            FuncionesUtiles.abrirVentanas(new Pantalla(), mainPrincipal.contenedor);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
                    FuncionesUtiles.form1.Visible = false;
                    FuncionesUtiles.siguienteActiva = true;
                    FuncionesUtiles.desactivarMenu();
                    FuncionesUtiles.abrirVentanas(new CPU(), mainPrincipal.contenedor);
                    return;

                case "No":
                    this.Close();
                    registro = new ventanaNuevoRegistro();
                    registro.Show();
                    FuncionesUtiles.form1.Visible = false;
                    FuncionesUtiles.siguienteActiva = true;
                    FuncionesUtiles.desactivarMenu();
                    FuncionesUtiles.abrirVentanas(new CPU(), mainPrincipal.contenedor);
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
                    FuncionesUtiles.siguienteActiva = false;
                    FuncionesUtiles.activarMenu();
                    FuncionesUtiles.INVENTARIO_EQUIPO = "";
                    return;

                case "No":
                    FuncionesUtiles.siguienteActiva = false;
                    FuncionesUtiles.activarMenu();
                    FuncionesUtiles.INVENTARIO_EQUIPO = "";
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
            string sql = "update c set c.inventario_cpu='" + txtCpu.Text + "',c.nombre_PC='" + txtNombre.Text + "',c.tipo_PC ='" + txtTipo.Text + "',c.perfil = '" + txtPerfil.Text + "'," +
                "c.tag = '" + txtTag.Text + "',c.code = '" + txtCode.Text + "',c.procesador = '" + txtProcesador.Text + "',c.memoria = '" + txtMemoria.Text + "',c.disco = '" + txtDisco.Text + "',c.adicional_lote = '" + txtLote.Text + "'" +
                " from Equipo e,CPU c where e.Inventario_CPU = c.ID and e.id_Equipo = '" + txtEquipo.Text + "';";

            Datos.Insertar(sql);

            sql = "update car set car.estado='" + txtEstado.Text + "',car.marca = '" + txtMarca.Text + "',car.modelo='" + txtModelo.Text + "',car.serie='" + txtSerie.Text + "' " +
                  "from Equipo e,CPU c, Caracteristicas car " +
                  "where e.Inventario_CPU = c.ID and car.id_caracteristica = c.Caracteristicas and e.id_Equipo = '" + txtEquipo.Text + "'; ";

            Datos.Insertar(sql);
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.INVENTARIO_EQUIPO = Microsoft.VisualBasic.Interaction.InputBox("Inventario Equipo", "Registrar Busqueda", "", 600);

            string sql = "select e.id_Equipo, c.inventario_cpu,c.nombre_PC,c.adicional_lote," +
                  "c.tipo_PC,c.tag,c.code,c.perfil,c.procesador,c.memoria,c.disco," +
                  "car.estado,car.marca,car.modelo,car.serie from  Equipo e, CPU c," +
                  "Caracteristicas car where e.Inventario_CPU = c.ID and " +
                  "car.id_caracteristica = c.caracteristicas and e.id_Equipo = '" + FuncionesUtiles.INVENTARIO_EQUIPO + "'; ";
            Datos.llenarGrid(sql, gridCpu);
            llenarCampos();

            sql = "select e.id_Equipo, c.inventario_cpu,c.nombre_PC,c.adicional_lote," +
                  "c.tipo_PC,c.tag,c.code,c.perfil,c.procesador,c.memoria,c.disco," +
                  "car.estado,car.marca,car.modelo,car.serie from  Equipo e, CPU c," +
                  "Caracteristicas car where e.Inventario_CPU = c.ID and " +
                  "car.id_caracteristica = c.caracteristicas; ";
            Datos.llenarGrid(sql, gridCpu);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
        }
        private void habilitarBotones()
        {
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            txtCpu.Enabled = true;
            txtNombre.Enabled = true;
            txtTipo.Enabled = true;
            txtTag.Enabled = true;
            txtCode.Enabled = true;
            txtPerfil.Enabled = true;
            txtProcesador.Enabled = true;
            txtMemoria.Enabled = true;
            txtDisco.Enabled = true;
            txtEstado.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtSerie.Enabled = true;
            txtLote.Enabled = true;
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
