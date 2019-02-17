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
    public partial class Impresora : Form
    {
        private string InventarioAnterior;
        private string SerieAnterior;

        public Impresora()
        {
            InitializeComponent();
        }

        private void Impresora_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Impresora' Puede moverla o quitarla según sea necesario.
            this.impresoraTableAdapter.Fill(this.sistemasFCNMDataSet.Impresora);
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Impresora' Puede moverla o quitarla según sea necesario.

            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.impresoraTableAdapter.FillBy(this.sistemasFCNMDataSet.Impresora, FuncionesUtiles.ID_IMPRESORA);
            }
    
        }

     

        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Proyector(), mainPrincipal.contenedor);
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Parlante(), mainPrincipal.contenedor);
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

        private void guardar()
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
           
            txtImpresora.Enabled = true;
            comboEstado.Enabled = true;
            comboMarca.Enabled = true;
            comboModelo.Enabled = true;
            txtSerie.Enabled = true;
        }

        private void impresoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Update Inventario
            try
            {
               
                if (this.impresoraTableAdapter.ObtenerIdImpresora(txtImpresora.Text.Trim()).ToString().Length != 0 && this.InventarioAnterior != txtImpresora.Text.Trim())
                {
                    MessageBox.Show("Inventario Repetido ");
                }
               
            }
            catch (NullReferenceException)
            {
                this.impresoraTableAdapter.UpdateInventario(txtImpresora.Text.Trim(), this.InventarioAnterior);


            }
            //Update Serie
            try
            {
                if (txtSerie.Text.Trim() != "N/A")
                {
                    if (this.impresoraTableAdapter.ObtenerSerie(txtSerie.Text.Trim()).ToString().Length != 0 && this.SerieAnterior != "N/A")
                    {
                        this.impresoraTableAdapter.UpdateSerie(txtSerie.Text.Trim(), txtImpresora.Text.Trim());
                    }
                    else
                    {
                        try
                        {
                            this.impresoraTableAdapter.UpdateTablaImpresoraSerie((int)this.impresoraTableAdapter.ObtenerSerie(txtSerie.Text), txtImpresora.Text.Trim());
                        }
                        catch (InvalidOperationException)
                        {

                            this.impresoraTableAdapter.InsertSerie(txtSerie.Text.Trim());
                            this.impresoraTableAdapter.UpdateTablaImpresoraSerie((int)this.impresoraTableAdapter.ObtenerSerie(txtSerie.Text), txtImpresora.Text.Trim());
                        }

                    }

                }
                else
                {
                    this.impresoraTableAdapter.UpdateTablaImpresoraSerie((int)this.impresoraTableAdapter.ObtenerSerie(txtSerie.Text), txtImpresora.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.impresoraTableAdapter.InsertSerie(txtSerie.Text.Trim());
                this.impresoraTableAdapter.UpdateTablaImpresoraSerie((int)this.impresoraTableAdapter.ObtenerSerie(txtSerie.Text), txtImpresora.Text.Trim());
            }

            //Update Combos
            try
            {
                this.impresoraTableAdapter.UpdateTablaImpresora(this.impresoraTableAdapter.ObtenerMarca(comboMarca.SelectedItem.ToString()),
                this.impresoraTableAdapter.ObtenerModelo(comboModelo.SelectedItem.ToString()),
                this.impresoraTableAdapter.ObtenerEstado(comboEstado.SelectedItem.ToString()), txtImpresora.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.impresoraTableAdapter.UpdateTablaImpresora(this.impresoraTableAdapter.ObtenerMarca(comboMarca.Text),
                this.impresoraTableAdapter.ObtenerModelo(comboModelo.Text),
                this.impresoraTableAdapter.ObtenerEstado(comboEstado.Text), txtSerie.Text.Trim());
            }

            this.impresoraTableAdapter.Fill(this.sistemasFCNMDataSet.Impresora);
            ApagarBotones();
            gridImpresora.Enabled = true;

        }

        private void ApagarBotones()
        {
            txtImpresora.Enabled = false;
            comboEstado.Enabled = false;
            comboMarca.Enabled = false;
            comboModelo.Enabled = false;
            txtSerie.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            comboEstado.Items.AddRange(Datos._obtenerEstado());
            comboMarca.Items.AddRange(Datos._obtenerMarcaImpresora());
            comboModelo.Items.AddRange(Datos._obtenerModeloImpresora());

            this.InventarioAnterior = txtImpresora.Text.Trim();
            this.SerieAnterior = txtSerie.Text.Trim();

            gridImpresora.Enabled = false;

        }
    }
}
