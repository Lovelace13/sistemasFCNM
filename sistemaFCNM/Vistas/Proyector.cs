using sistemaFCNM.Clases;
using sistemaFCNM.Controlador;
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
    public partial class Proyector : Form
    {
        private string InventarioAnterior;
        private string SerieAnterior;
        private string EspolTechAnterior;

        public Proyector()
        {
            InitializeComponent();
        }

        private void Proyector_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Proyector' Puede moverla o quitarla según sea necesario.
            this.proyectorTableAdapter.Fill(this.sistemasFCNMDataSet.Proyector);
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.proyectorTableAdapter.FillBy(this.sistemasFCNMDataSet.Proyector,FuncionesUtiles.ID_PROYECTOR);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Microfono(), mainPrincipal.contenedor);
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Impresora(), mainPrincipal.contenedor);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           
        }

        private void guardar()
        {
            //Update Inventario
            try
            {
                if (this.proyectorTableAdapter.ObtenerIdProyector(txtProyector.Text.Trim()).ToString().Length != 0 && this.InventarioAnterior != txtProyector.Text.Trim())
                {
                    MessageBox.Show("Inventario Repetido ");
                }
            }
            catch (NullReferenceException)
            {
                this.proyectorTableAdapter.UpdateInventario(txtProyector.Text.Trim(), this.InventarioAnterior);


            }
            //Update Serie
            try
            {
                if (txtSerie.Text.Trim() != "N/A")
                {
                    if (this.proyectorTableAdapter.ObtenerSerie(txtSerie.Text.Trim()).ToString().Length != 0 && this.SerieAnterior != "N/A")
                    {
                        this.proyectorTableAdapter.UpdateSerie(txtSerie.Text.Trim(), txtProyector.Text.Trim());
                    }
                    else
                    {
                        try
                        {
                            this.proyectorTableAdapter.UpdateTablaProyectorSerie((int)this.proyectorTableAdapter.ObtenerSerie(txtSerie.Text), txtProyector.Text.Trim());
                        }
                        catch (InvalidOperationException)
                        {

                            this.proyectorTableAdapter.InsertSerie(txtSerie.Text.Trim());
                            this.proyectorTableAdapter.UpdateTablaProyectorSerie((int)this.proyectorTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtProyector.Text.Trim());
                        }

                    }

                }
                else
                {

                    this.proyectorTableAdapter.UpdateTablaProyectorSerie((int)this.proyectorTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtProyector.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.proyectorTableAdapter.InsertSerie(txtSerie.Text.Trim());
                this.proyectorTableAdapter.UpdateTablaProyectorSerie((int)this.proyectorTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtProyector.Text.Trim());
            }


            //Update EspolTech
            try
            {
                if (txtEspolTech.Text.Trim() != "N/A")
                {
                    if (this.proyectorTableAdapter.ObtenerEspolTech(txtEspolTech.Text.Trim()).ToString().Length != 0 && this.EspolTechAnterior != "N/A")
                    {
                        this.proyectorTableAdapter.UpdateEspolTech(txtEspolTech.Text.Trim(), txtProyector.Text.Trim());
                    }
                    else
                    {
                        try
                        {
                            this.proyectorTableAdapter.UpdateTablaProyectorEspolTech((int)this.proyectorTableAdapter.ObtenerEspolTech(txtEspolTech.Text), txtProyector.Text.Trim());
                        }
                        catch (InvalidOperationException)
                        {

                            this.proyectorTableAdapter.InsertEspolTech(txtEspolTech.Text.Trim());
                            this.proyectorTableAdapter.UpdateTablaProyectorEspolTech((int)this.proyectorTableAdapter.ObtenerEspolTech(txtEspolTech.Text.Trim()), txtProyector.Text.Trim());
                        }

                    }

                }
                else
                {

                    this.proyectorTableAdapter.UpdateTablaProyectorEspolTech((int)this.proyectorTableAdapter.ObtenerEspolTech(txtEspolTech.Text.Trim()), txtProyector.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.proyectorTableAdapter.InsertEspolTech(txtEspolTech.Text.Trim());
                this.proyectorTableAdapter.UpdateTablaProyectorEspolTech((int)this.proyectorTableAdapter.ObtenerEspolTech(txtEspolTech.Text.Trim()), txtProyector.Text.Trim());
            }

            //Update Combos
            try
            {
                this.proyectorTableAdapter.UpdateTablaProyector(this.proyectorTableAdapter.ObtenerMarca(comboMarca.SelectedItem.ToString()),
                this.proyectorTableAdapter.ObtenerModelo(comboModelo.SelectedItem.ToString()),
                this.proyectorTableAdapter.ObtenerEstado(comboEstado.SelectedItem.ToString()), txtProyector.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.proyectorTableAdapter.UpdateTablaProyector(this.proyectorTableAdapter.ObtenerMarca(comboMarca.Text),
                 this.proyectorTableAdapter.ObtenerModelo(comboModelo.Text),
                 this.proyectorTableAdapter.ObtenerEstado(comboEstado.Text), txtProyector.Text.Trim());
            }

            FuncionesUtiles.OBSERVACION += "Proyector: " + Microsoft.VisualBasic.Interaction.InputBox("OBSERVACION", "Ingrese Su Observacion", "", 600) + " ; ";
            FuncionesEquipo.ActualizarInventario(FuncionesUtiles.OBSERVACION);
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

        private void guardarMenuItem_Click(object sender, EventArgs e)
        {
            guardar();
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
            txtProyector.Enabled = true;
            txtEspolTech.Enabled = true;
            comboEstado.Enabled = true;
            comboMarca.Enabled = true;
            comboModelo.Enabled = true;
            txtSerie.Enabled = true;
        }

        private void proyectorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            switch (FuncionesUtiles.ventanaDialogo())
            {

                case "Yes":

                    guardar();
                    this.proyectorTableAdapter.Fill(this.sistemasFCNMDataSet.Proyector);
                    ApagarBotones();
                    gridProyector.Enabled = true;
                    return;

                case "No":
                    this.proyectorTableAdapter.Fill(this.sistemasFCNMDataSet.Proyector);
                    ApagarBotones();
                    gridProyector.Enabled = true;
                    return;

                case "Cancel":
                    return;

                default:
                    return;
            }

            

        }

        private void ApagarBotones()
        {
            txtProyector.Enabled = false;
            txtEspolTech.Enabled = false;
            comboEstado.Enabled = false;
            comboMarca.Enabled = false;
            comboModelo.Enabled = false;
            txtSerie.Enabled = false;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            habilitarBotones();
            comboEstado.Items.AddRange(Datos._obtenerEstado());
            comboMarca.Items.AddRange(Datos._obtenerMarcaProyector());
            comboModelo.Items.AddRange(Datos._obtenerModeloProyector());

            this.InventarioAnterior = txtProyector.Text.Trim();
            this.SerieAnterior = txtSerie.Text.Trim();
            this.EspolTechAnterior = txtEspolTech.Text.Trim();

            gridProyector.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string NuevoInventario = Microsoft.VisualBasic.Interaction.InputBox("NUEVO PROYECTOR", "Ingrese Numero de Inventario Pantalla", "", 600);
            if (NuevoInventario == "") { return; }
            try
            {
                if (this.proyectorTableAdapter.ObtenerInventario(NuevoInventario).ToString().Length != 0) { MessageBox.Show("Inventario Existe"); return; }
            }
            catch (NullReferenceException)
            {
                this.proyectorTableAdapter.InsertInventarioProy(NuevoInventario);
                int var0 = (int)FuncionesEquipo.estado.ObtenerEstado("BUENO");
                int var1 = (int)this.proyectorTableAdapter.ObtenerMarca("N/A");
                int var2 = (int)this.proyectorTableAdapter.ObtenerModelo("N/A");
                int var3 = (int)this.proyectorTableAdapter.ObtenerSerie("N/A");
                int var4 = (int)this.proyectorTableAdapter.ObtenerEspolTech("N/A");
                int var5 = (int)this.proyectorTableAdapter.ObtenerIdInventarioProyector(NuevoInventario);


                this.proyectorTableAdapter.InsertProyector(var5, var4, var1, var2, var3, var0);
                MessageBox.Show("Nuevo Inventario Creado!!");
                this.proyectorTableAdapter.Fill(this.sistemasFCNMDataSet.Proyector);
                this.proyectorTableAdapter.FillBy(this.sistemasFCNMDataSet.Proyector, (int)this.proyectorTableAdapter.ObtenerIdProyector(NuevoInventario));

            }
        }
    }
}
