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
    public partial class Regulador : Form
    {
        
        public Regulador()
        {
            InitializeComponent();
        }

        private void Regulador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Regulador' Puede moverla o quitarla según sea necesario.
            this.reguladorTableAdapter.Fill(this.sistemasFCNMDataSet.Regulador);
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.reguladorTableAdapter.FillBy(this.sistemasFCNMDataSet.Regulador, FuncionesUtiles.ID_REGULADOR);
            }
      
        }

       
        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Parlante(), mainPrincipal.contenedor);
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Mouse(), mainPrincipal.contenedor);
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
            string sql = "update va set va.Inventario_Regulador='" + txtRegulador.Text + "', va.tipo = '" + txtTipo.Text + "'" +
                " from Equipo e,Regulador va where e.Regulador = va.ID and e.id_Equipo = '" + txtEquipo.Text + "';";


            Datos.Insertar(sql);

            sql = "update car set car.estado='" + txtEstado.Text + "',car.marca = '" + txtMarca.Text + "',car.modelo='" + txtModelo.Text + "',car.serie='" + txtSerie.Text + "' " +
                  " from Equipo e,Regulador va, Caracteristicas car " +
                  " where e.Regulador = va.ID and car.id_caracteristica = va.Caracteristicas and e.id_Equipo = '" + txtEquipo.Text + "'; ";


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
            string sql = "select e.id_Equipo, reg.Inventario_Regulador,reg.tipo,car.estado,car.marca," +
                "car.modelo,car.serie from  Equipo e, Regulador reg," +
                "Caracteristicas car where " +
                "e.Regulador = reg.ID and car.id_caracteristica = reg.caracteristicas and e.id_Equipo = '" + FuncionesUtiles.INVENTARIO_EQUIPO + "'; ";

            Datos.llenarGrid(sql, gridRegulador);
           

            sql = "select e.id_Equipo, reg.Inventario_Regulador,reg.tipo,car.estado,car.marca," +
                "car.modelo,car.serie from  Equipo e, Regulador reg," +
                "Caracteristicas car where " +
                "e.Regulador = reg.ID and car.id_caracteristica = reg.caracteristicas ; ";

            Datos.llenarGrid(sql, gridRegulador);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
        }
        private void habilitarBotones()
        {
            
            txtRegulador.Enabled = true;
            txtTipo.Enabled = true;
            txtEstado.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtSerie.Enabled = true;
        }

        private void reguladorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reguladorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemasFCNMDataSet);

        }
    }
}
