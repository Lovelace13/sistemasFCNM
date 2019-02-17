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
    public partial class Microfono : Form
    {
        private string InventarioAnterior;
        private string SerieAnterior;

        public Microfono()
        {
            InitializeComponent();
        }

        private void Microfono_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Microfono' Puede moverla o quitarla según sea necesario.
           
            this.microfonoTableAdapter.Fill(this.sistemasFCNMDataSet.Microfono);
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.microfonoTableAdapter.FillBy(this.sistemasFCNMDataSet.Microfono, FuncionesUtiles.ID_MICROFONO);
            }
            

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Telefono(), mainPrincipal.contenedor);
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Proyector(), mainPrincipal.contenedor);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
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

        private void guardar()
        {
        }

        private void guardarMenuItem_Click(object sender, EventArgs e)
        {
            guardar();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
        }
        private void habilitarBotones()
        {
                   
            comboTipo.Enabled = true;
            txtMicro.Enabled = true;
            comboEstado.Enabled = true;
            comboMarca.Enabled = true;
            txtSerie.Enabled = true;
        }

        private void microfonoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Update Inventario
            try
            {
                
                if (this.microfonoTableAdapter.ObtenerIdMicro(txtMicro.Text.Trim()).ToString().Length != 0 && this.InventarioAnterior != txtMicro.Text.Trim())
                {
                    MessageBox.Show("Inventario Repetido ");
                }
                else if (this.microfonoTableAdapter.ObtenerIdMicro(txtMicro.Text.Trim()).ToString().Length== 0 && this.InventarioAnterior != txtMicro.Text.Trim())
                {
                    this.microfonoTableAdapter.UpdateInventario(txtMicro.Text.Trim(), this.InventarioAnterior);
                }
            }
            catch (NullReferenceException)
            {
                this.microfonoTableAdapter.UpdateInventario(txtMicro.Text.Trim(), this.InventarioAnterior);


            }
            //Update Serie
            try
            {
                if (txtSerie.Text.Trim() != "N/A")
                {
                    if (this.microfonoTableAdapter.ObtenerSerie(txtSerie.Text.Trim()).ToString().Length != 0 && this.SerieAnterior != "N/A")
                    {
                        this.microfonoTableAdapter.UpdateSerie(txtSerie.Text.Trim(), txtMicro.Text.Trim());
                    }
                    else
                    {
                        try
                        {
                            this.microfonoTableAdapter.UpdateTablaMicrofonoSerie((int)this.microfonoTableAdapter.ObtenerSerie(txtSerie.Text), txtMicro.Text.Trim());
                        }
                        catch (InvalidOperationException)
                        {

                            this.microfonoTableAdapter.InsertSerie(txtSerie.Text.Trim());
                            this.microfonoTableAdapter.UpdateTablaMicrofonoSerie((int)this.microfonoTableAdapter.ObtenerSerie(txtSerie.Text), txtMicro.Text.Trim());
                        }

                    }

                }
                else
                {
                    this.microfonoTableAdapter.UpdateTablaMicrofonoSerie((int)this.microfonoTableAdapter.ObtenerSerie(txtSerie.Text), txtMicro.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.microfonoTableAdapter.InsertSerie(txtSerie.Text.Trim());
                this.microfonoTableAdapter.UpdateTablaMicrofonoSerie((int)this.microfonoTableAdapter.ObtenerSerie(txtSerie.Text), txtMicro.Text.Trim());
            }

            //Update Combos
            try
            {
                this.microfonoTableAdapter.UpdateTablaMicrofono(this.microfonoTableAdapter.ObtenerMarca(comboMarca.SelectedItem.ToString()),
                this.microfonoTableAdapter.ObtenerTipo(comboTipo.SelectedItem.ToString()),
                this.microfonoTableAdapter.ObtenerEstado(comboEstado.SelectedItem.ToString()), txtMicro.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.microfonoTableAdapter.UpdateTablaMicrofono(this.microfonoTableAdapter.ObtenerMarca(comboMarca.Text),
                this.microfonoTableAdapter.ObtenerTipo(comboTipo.Text),
                this.microfonoTableAdapter.ObtenerEstado(comboEstado.Text), txtSerie.Text.Trim());
            }

            this.microfonoTableAdapter.Fill(this.sistemasFCNMDataSet.Microfono);
            ApagarBotones();
            gridMicrofono.Enabled = true;

        }

        private void ApagarBotones()
        {
            comboTipo.Enabled = false;
            txtMicro.Enabled = false;
            comboEstado.Enabled = false;
            comboMarca.Enabled = false;
            txtSerie.Enabled = false;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            habilitarBotones();
            comboEstado.Items.AddRange(Datos._obtenerEstado());
            comboMarca.Items.AddRange(Datos._obtenerMarcaMicro());
            comboTipo.Items.AddRange(Datos._obtenerTipoMicro());

            this.InventarioAnterior = txtMicro.Text.Trim();
            this.SerieAnterior = txtSerie.Text.Trim();

            gridMicrofono.Enabled = false;
        }
    }
}
