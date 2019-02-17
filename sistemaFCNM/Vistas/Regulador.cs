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
        private string InventarioAnterior;

        public string SerieAnterior { get; private set; }

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
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
        }
        private void habilitarBotones()
        {
            
            txtRegulador.Enabled = true;
            comboTipo.Enabled = true;
            comboEstado.Enabled = true;
            comboMarca.Enabled = true;
            comboModelo.Enabled = true;
            txtSerie.Enabled = true;
        }

        private void reguladorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Update Inventario
            try
            {
                if (this.reguladorTableAdapter.ObtenerIdRegulador(txtRegulador.Text.Trim()).ToString().Length != 0 && this.InventarioAnterior != txtRegulador.Text.Trim())
                {
                    MessageBox.Show("Inventario Repetido ");
                }
            }
            catch (NullReferenceException)
            {
                this.reguladorTableAdapter.UpdateRegulador(txtRegulador.Text.Trim(), this.InventarioAnterior);


            }
            //Update Serie
            try
            {
                if (txtSerie.Text.Trim() != "N/A")
                {
                    if (this.reguladorTableAdapter.ObtenerSerie(txtSerie.Text.Trim()).ToString().Length != 0 && this.SerieAnterior != "N/A")
                    {
                        this.reguladorTableAdapter.UpdateSerie(txtSerie.Text.Trim(), txtRegulador.Text.Trim());
                    }
                    else
                    {
                        try
                        {
                            this.reguladorTableAdapter.UpdateTablaReguladorSerie((int)this.reguladorTableAdapter.ObtenerSerie(txtSerie.Text), txtRegulador.Text.Trim());
                        }
                        catch (InvalidOperationException)
                        {

                            this.reguladorTableAdapter.InsertSerie(txtSerie.Text.Trim());
                            this.reguladorTableAdapter.UpdateTablaReguladorSerie((int)this.reguladorTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtRegulador.Text.Trim());
                        }

                    }

                }
                else
                {

                    this.reguladorTableAdapter.UpdateTablaReguladorSerie((int)this.reguladorTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtRegulador.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.reguladorTableAdapter.InsertSerie(txtSerie.Text.Trim());
                this.reguladorTableAdapter.UpdateTablaReguladorSerie((int)this.reguladorTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtRegulador.Text.Trim());
            }
            //Update Combos
            try
            {
                this.reguladorTableAdapter.UpdateTablaRegulador(this.reguladorTableAdapter.ObtenerMarca(comboMarca.SelectedItem.ToString()),
                this.reguladorTableAdapter.ObtenerModelo(comboModelo.SelectedItem.ToString()),
                this.reguladorTableAdapter.ObtenerEstado(comboEstado.SelectedItem.ToString()),
                this.reguladorTableAdapter.ObtenerTipo(comboTipo.SelectedItem.ToString()), txtRegulador.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.reguladorTableAdapter.UpdateTablaRegulador(this.reguladorTableAdapter.ObtenerMarca(comboMarca.Text),
                this.reguladorTableAdapter.ObtenerModelo(comboModelo.Text),
                 this.reguladorTableAdapter.ObtenerEstado(comboEstado.Text), 
                 this.reguladorTableAdapter.ObtenerTipo(comboTipo.Text), txtRegulador.Text.Trim());
            }



            this.reguladorTableAdapter.Fill(this.sistemasFCNMDataSet.Regulador);
            ApagarBotones();
            gridRegulador.Enabled = true;

        }

        private void ApagarBotones()
        {
            txtRegulador.Enabled = false;
            comboTipo.Enabled = false;
            comboEstado.Enabled = false;
            comboMarca.Enabled = false;
            comboModelo.Enabled = false;
            txtSerie.Enabled = false;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            habilitarBotones();
            comboEstado.Items.AddRange(Datos._obtenerEstado());
            comboMarca.Items.AddRange(Datos._obtenerMarcaRegulador());
            comboModelo.Items.AddRange(Datos._obtenerModeloregulador());
            comboTipo.Items.AddRange(Datos._obtenerTipoRegulador());

            this.InventarioAnterior = txtRegulador.Text.Trim();
            this.SerieAnterior = txtSerie.Text.Trim();

            gridRegulador.Enabled = false;
        }
    }
}
