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
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Teclado' Puede moverla o quitarla según sea necesario.
            this.tecladoTableAdapter.Fill(this.sistemasFCNMDataSet.Teclado);
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.tecladoTableAdapter.FillBy(this.sistemasFCNMDataSet.Teclado, FuncionesUtiles.ID_TECLADO);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Mouse(), mainPrincipal.contenedor);
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Pantalla(), mainPrincipal.contenedor);
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
                    FuncionesUtiles.siguienteActiva = false;
                    FuncionesUtiles.activarMenu();
                    FuncionesUtiles.INVENTARIO_EQUIPO = "";
                    guardar();
                    this.Close();
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
            string sql = "update va set va.Inventario_teclado='" + txtTeclado.Text + "' " +
               " from Equipo e,Teclado va where e.Teclado= va.ID and e.id_Equipo = '" + txtEquipo.Text + "';";


            Datos.Insertar(sql);

            sql = "update car set car.estado='" + txtEstado.Text + "',car.marca = '" + txtMarca.Text + "',car.modelo='" + txtModelo.Text + "',car.serie='" + txtSerie.Text + "' " +
                  " from Equipo e,Teclado va, Caracteristicas car " +
                  " where e.Teclado = va.ID and car.id_caracteristica = va.Caracteristicas and e.id_Equipo = '" + txtEquipo.Text + "'; ";


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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.INVENTARIO_EQUIPO = Microsoft.VisualBasic.Interaction.InputBox("Inventario Equipo", "Registrar Busqueda", "", 600);
            string sql = "select e.id_Equipo, t.Inventario_teclado,car.estado,car.marca," +
                         "car.modelo,car.serie from  Equipo e, Teclado t, CPU ," +
                         "Caracteristicas car where e.Inventario_CPU = CPU.ID and" +
                         " e.Teclado = t.ID and car.id_caracteristica = t.caracteristicas and e.id_Equipo = '" + FuncionesUtiles.INVENTARIO_EQUIPO + "'; ";

            Datos.llenarGrid(sql, gridTeclado);

            sql = "select e.id_Equipo, t.Inventario_teclado,car.estado,car.marca," +
                         "car.modelo,car.serie from  Equipo e, Teclado t, CPU ," +
                         "Caracteristicas car where e.Inventario_CPU = CPU.ID and" +
                         " e.Teclado = t.ID and car.id_caracteristica = t.caracteristicas ; ";

            Datos.llenarGrid(sql, gridTeclado);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
        }
        private void habilitarBotones()
        {
            
            txtTeclado.Enabled = true;
            txtEstado.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtSerie.Enabled = true;
        }

        private void tecladoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tecladoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemasFCNMDataSet);

        }
    }
}
