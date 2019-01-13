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
    public partial class Radio : Form
    {
       
        public Radio()
        {
            InitializeComponent();
        }

        private void Radio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Radio' Puede moverla o quitarla según sea necesario.
            this.radioTableAdapter.Fill(this.sistemasFCNMDataSet.Radio);
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.radioTableAdapter.FillBy(this.sistemasFCNMDataSet.Radio, FuncionesUtiles.ID_RADIO);
            }
    
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new PProyeccion(), mainPrincipal.contenedor);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            
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
            string sql = "update va set va.Inventario_Radio='" + txtRadio.Text + "'" +
              " from Equipo e,Radio va where e.Radios = va.ID and e.id_Equipo = '" + txtEquipo.Text + "';";


            Datos.Insertar(sql);

            sql = "update car set car.estado='" + txtEstado.Text + "',car.marca = '" + txtMarca.Text + "',car.modelo='" + txtModelo.Text + "',car.serie='" + txtSerie.Text + "' " +
                  " from Equipo e,Radio va, Caracteristicas car " +
                  " where e.Radios = va.ID and car.id_caracteristica = va.Caracteristicas and e.id_Equipo = '" + txtEquipo.Text + "'; ";


            Datos.Insertar(sql);
        }

        private void guardarMenuItem_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.INVENTARIO_EQUIPO = Microsoft.VisualBasic.Interaction.InputBox("Inventario Equipo", "Registrar Busqueda", "", 600);
            string sql = "select e.id_Equipo, pro.Inventario_Radio,car.estado,car.marca," +
        "car.modelo,car.serie from  Equipo e, Radio pro," +
        "Caracteristicas car where " +
        " e.Radios = pro.ID and car.id_caracteristica = pro.caracteristicas and e.id_Equipo = '" + FuncionesUtiles.INVENTARIO_EQUIPO + "'; ";


            Datos.llenarGrid(sql, gridRadio);
            

            sql = "select e.id_Equipo, pro.Inventario_Radio,car.estado,car.marca," +
        "car.modelo,car.serie from  Equipo e, Radio pro," +
        "Caracteristicas car where " +
        " e.Radios = pro.ID and car.id_caracteristica = pro.caracteristicas ; ";


            Datos.llenarGrid(sql, gridRadio);


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
        }
        private void habilitarBotones()
        {
            txtRadio.Enabled = true;            
            txtEstado.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtSerie.Enabled = true;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.OBSERVACION = Microsoft.VisualBasic.Interaction.InputBox("OBSERVACION", "Ingrese Su Observacion", "", 600);


            mainPrincipal.btn13.Enabled = true;
            mainPrincipal.btn1.Enabled = true;
            mainPrincipal.btn2.Enabled = true;
            mainPrincipal.btn3.Enabled = true;
            mainPrincipal.btn4.Enabled = true;
            mainPrincipal.btn5.Enabled = true;
            mainPrincipal.btn6.Enabled = true;
            mainPrincipal.btn7.Enabled = true;
            mainPrincipal.btn8.Enabled = true;
            mainPrincipal.btn9.Enabled = true;
            mainPrincipal.btn10.Enabled = true;
            mainPrincipal.btn11.Enabled = true;
            mainPrincipal.btn12.Enabled = true;
            FuncionesUtiles.siguienteActiva = false;
            FuncionesUtiles.INVENTARIO_EQUIPO = "";
            FuncionesUtiles.masdetallesActiva = false;
        }

        private void radioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.radioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemasFCNMDataSet);

        }
    }
}
