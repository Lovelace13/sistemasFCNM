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
    public partial class Telefono : Form
    {
        private string InventarioAnterior;
        private string SerieAnterior;
        private string ExtensionAnterior;

        public Telefono()
        {
            InitializeComponent();
        }

        private void Telefono_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Telefono' Puede moverla o quitarla según sea necesario.
            this.telefonoTableAdapter.Fill(this.sistemasFCNMDataSet.Telefono);
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.telefonoTableAdapter.FillBy(this.sistemasFCNMDataSet.Telefono, FuncionesUtiles.ID_TELEFONO);
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new PProyeccion(), mainPrincipal.contenedor);
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Microfono(), mainPrincipal.contenedor);
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

                    guardar();
                    FuncionesUtiles.siguienteActiva = false;
                    FuncionesUtiles.activarMenu();
                    FuncionesUtiles.INVENTARIO_EQUIPO = "";
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
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
        }
        private void habilitarBotones()
        {
            
            txtTelefono.Enabled = true;
            comboTipo.Enabled = true;
            txtExtension.Enabled = true;
            comboEstado.Enabled = true;
            comboMarca.Enabled = true;
            comboModelo.Enabled = true;
            txtSerie.Enabled = true;
        }

        private void telefonoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Update Inventario
            try
            {
                if (this.telefonoTableAdapter.ObtenerIdTelefono(txtTelefono.Text.Trim()).ToString().Length != 0 && this.InventarioAnterior != txtTelefono.Text.Trim())
                {
                    MessageBox.Show("Inventario Repetido ");
                }
            }
            catch (NullReferenceException)
            {
                this.telefonoTableAdapter.UpdateInventario(txtTelefono.Text.Trim(), this.InventarioAnterior);


            }
            //Update Serie
            try
            {
                if (txtSerie.Text.Trim() != "N/A")
                {
                    if (this.telefonoTableAdapter.ObtenerSerie(txtSerie.Text.Trim()).ToString().Length != 0 && this.SerieAnterior != "N/A")
                    {
                        this.telefonoTableAdapter.UpdateSerie(txtSerie.Text.Trim(), txtTelefono.Text.Trim());
                    }
                    else
                    {
                        try
                        {
                            this.telefonoTableAdapter.UpdateTablaTelefonoSerie((int)this.telefonoTableAdapter.ObtenerSerie(txtSerie.Text), txtTelefono.Text.Trim());
                        }
                        catch (InvalidOperationException)
                        {

                            this.telefonoTableAdapter.InsertSerie(txtSerie.Text.Trim());
                            this.telefonoTableAdapter.UpdateTablaTelefonoSerie((int)this.telefonoTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtTelefono.Text.Trim());
                        }

                    }

                }
                else
                {

                    this.telefonoTableAdapter.UpdateTablaTelefonoSerie((int)this.telefonoTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtTelefono.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.telefonoTableAdapter.InsertSerie(txtSerie.Text.Trim());
                this.telefonoTableAdapter.UpdateTablaTelefonoSerie((int)this.telefonoTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtTelefono.Text.Trim());
            }
            //Update Extension
            try
            {
                if (txtExtension.Text.Trim() != "N/A")
                {
                    if (this.telefonoTableAdapter.ObtenerExtension(txtExtension.Text.Trim()).ToString().Length != 0 && this.ExtensionAnterior != "N/A")
                    {
                        this.telefonoTableAdapter.UpdateExtension(txtExtension.Text.Trim(), txtTelefono.Text.Trim());
                    }
                    else
                    {
                        try
                        {
                            this.telefonoTableAdapter.UpdateTablaTelefonoExtension((int)this.telefonoTableAdapter.ObtenerExtension(txtExtension.Text), txtTelefono.Text.Trim());
                        }
                        catch (InvalidOperationException)
                        {

                            this.telefonoTableAdapter.InsertExtencion(txtExtension.Text.Trim());
                            this.telefonoTableAdapter.UpdateTablaTelefonoExtension((int)this.telefonoTableAdapter.ObtenerExtension(txtExtension.Text.Trim()), txtTelefono.Text.Trim());
                        }

                    }

                }
                else
                {

                    this.telefonoTableAdapter.UpdateTablaTelefonoExtension((int)this.telefonoTableAdapter.ObtenerExtension(txtExtension.Text.Trim()), txtTelefono.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.telefonoTableAdapter.InsertExtencion(txtExtension.Text.Trim());
                this.telefonoTableAdapter.UpdateTablaTelefonoExtension((int)this.telefonoTableAdapter.ObtenerExtension(txtExtension.Text.Trim()), txtTelefono.Text.Trim());
            }
            //Update Combos
            try
            {
                this.telefonoTableAdapter.UpdateTablaTelefono(this.telefonoTableAdapter.ObtenerMarca(comboMarca.SelectedItem.ToString()),
                this.telefonoTableAdapter.ObtenerModelo(comboModelo.SelectedItem.ToString()),
                this.telefonoTableAdapter.ObtenerEstado(comboEstado.SelectedItem.ToString()),
                this.telefonoTableAdapter.ObtenerTipo(comboTipo.SelectedItem.ToString()), txtTelefono.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.telefonoTableAdapter.UpdateTablaTelefono(this.telefonoTableAdapter.ObtenerMarca(comboMarca.Text),
                this.telefonoTableAdapter.ObtenerModelo(comboModelo.Text),
                this.telefonoTableAdapter.ObtenerEstado(comboEstado.Text),
                this.telefonoTableAdapter.ObtenerTipo(comboTipo.Text), txtTelefono.Text.Trim());
            }



            this.telefonoTableAdapter.Fill(this.sistemasFCNMDataSet.Telefono);
            ApagarBotones();
            gridTelefono.Enabled = true;

        }

        private void ApagarBotones()
        {
            txtTelefono.Enabled = false;
            comboTipo.Enabled = false;
            txtExtension.Enabled = false;
            comboEstado.Enabled = false;
            comboMarca.Enabled = false;
            comboModelo.Enabled = false;
            txtSerie.Enabled = false;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            habilitarBotones();
            comboEstado.Items.AddRange(Datos._obtenerEstado());
            comboMarca.Items.AddRange(Datos._obtenerMarcaTelefono());
            comboModelo.Items.AddRange(Datos._obtenerModeloTelefono());
            comboTipo.Items.AddRange(Datos._obtenerTipoTelefono());

            this.InventarioAnterior = txtTelefono.Text.Trim();
            this.SerieAnterior = txtSerie.Text.Trim();
            this.ExtensionAnterior = txtExtension.Text.Trim();

            gridTelefono.Enabled = false;
        }
    }
}
