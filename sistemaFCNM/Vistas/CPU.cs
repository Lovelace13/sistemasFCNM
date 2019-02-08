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
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Cpu' Puede moverla o quitarla según sea necesario.
            this.cpuTableAdapter.Fill(this.sistemasFCNMDataSet.Cpu);
           
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.cpuTableAdapter.FillBy(this.sistemasFCNMDataSet.Cpu,FuncionesUtiles.ID_CPU);
            }

           

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
           

        }

       
        private void habilitarBotones()
        {
            
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

        private void cpuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gridCpu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.habilitarBotones();
        }
    }
}
