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
    public partial class Pantalla : Form
    {
        private String InventarioAnterior;
        private string SerieAnterior;

        public Pantalla()
        {
            InitializeComponent();
        }

        private void Pantalla_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Pantalla' Puede moverla o quitarla según sea necesario.
            this.pantallaTableAdapter.Fill(this.sistemasFCNMDataSet.Pantalla);
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.pantallaTableAdapter.FillBy(this.sistemasFCNMDataSet.Pantalla, FuncionesUtiles.ID_PANTALLA);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Teclado(), mainPrincipal.contenedor);
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new CPU(), mainPrincipal.contenedor);
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

        private void guardarMenuItem_Click(object sender, EventArgs e)
        {
            guardar();
        }
        public void guardar()
        {
            //Update Inventario
            try
            {
                if (this.pantallaTableAdapter.ObtenerIdPantalla(txtPantalla.Text.Trim()).ToString().Length != 0 && this.InventarioAnterior != txtPantalla.Text.Trim())
                {
                    MessageBox.Show("Inventario Repetido ");
                }
            }
            catch (NullReferenceException)
            {
                this.pantallaTableAdapter.UpdatePantalla(txtPantalla.Text.Trim(), this.InventarioAnterior);


            }
            //Update Serie
            try
            {
                if (txtSerie.Text.Trim() != "N/A")
                {
                    if (this.pantallaTableAdapter.ObtenerSerie(txtSerie.Text.Trim()).ToString().Length != 0 && this.SerieAnterior != "N/A")
                    {
                        this.pantallaTableAdapter.UpdateSerie(txtSerie.Text.Trim(), txtPantalla.Text.Trim());
                    }
                    else
                    {
                        try
                        {
                            this.pantallaTableAdapter.UpdateTablaPantallaSerie((int)this.pantallaTableAdapter.ObtenerSerie(txtSerie.Text), txtPantalla.Text.Trim());
                        }
                        catch (InvalidOperationException)
                        {

                            this.pantallaTableAdapter.InsertSerie(txtSerie.Text.Trim());
                            this.pantallaTableAdapter.UpdateTablaPantallaSerie((int)this.pantallaTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtPantalla.Text.Trim());
                        }

                    }

                }
                else
                {

                    this.pantallaTableAdapter.UpdateTablaPantallaSerie((int)this.pantallaTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtPantalla.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.pantallaTableAdapter.InsertSerie(txtSerie.Text.Trim());
                this.pantallaTableAdapter.UpdateTablaPantallaSerie((int)this.pantallaTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtPantalla.Text.Trim());
            }
            //Update Combos
            try
            {
                this.pantallaTableAdapter.UpdateTablaPantalla(this.pantallaTableAdapter.ObtenerMarca(comboMarca.SelectedItem.ToString()),
                this.pantallaTableAdapter.ObtenerPulgadas(comboPulgadas.SelectedItem.ToString()), this.pantallaTableAdapter.ObtenerModelo(comboModelo.SelectedItem.ToString()),
                this.pantallaTableAdapter.ObtenerEstado(comboEstado.SelectedItem.ToString()), txtPantalla.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.pantallaTableAdapter.UpdateTablaPantalla(this.pantallaTableAdapter.ObtenerMarca(comboMarca.Text),
                 this.pantallaTableAdapter.ObtenerPulgadas(comboPulgadas.Text), this.pantallaTableAdapter.ObtenerModelo(comboModelo.Text),
                 this.pantallaTableAdapter.ObtenerEstado(comboEstado.Text), txtPantalla.Text.Trim());
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
           
            txtPantalla.Enabled = true;
            comboPulgadas.Enabled = true;
            comboEstado.Enabled = true;
            comboMarca.Enabled = true;
            comboModelo.Enabled = true;
            txtSerie.Enabled = true;

            comboEstado.Items.AddRange(Datos._obtenerEstado());
            comboPulgadas.Items.AddRange(Datos._obtenerPulgadas());
            comboMarca.Items.AddRange(Datos._obtenerMarcaPantalla());
            comboModelo.Items.AddRange(Datos._obtenerModeloPantalla());

            this.InventarioAnterior = txtPantalla.Text.Trim();
            this.SerieAnterior = txtSerie.Text.Trim();

            gridPantalla.Enabled = false;
        }
        public void ApagarBotones()
        {
            txtPantalla.Enabled = false;
            comboPulgadas.Enabled = false;
            comboEstado.Enabled = false;
            comboMarca.Enabled = false;
            comboModelo.Enabled = false;
            txtSerie.Enabled = false;
        }
        private void pantallaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            switch (FuncionesUtiles.ventanaDialogo())
            {

                case "Yes":

                    guardar();
                    this.gridPantalla.Enabled = true;
                    this.ApagarBotones();
                    this.pantallaTableAdapter.Fill(this.sistemasFCNMDataSet.Pantalla);
                    return;

                case "No":
                    ApagarBotones();
                    gridPantalla.Enabled = true;
                    this.pantallaTableAdapter.Fill(this.sistemasFCNMDataSet.Pantalla);
                    return;

                case "Cancel":
                    return;

                default:
                    return;
            }
           
           

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string NuevoInventario = Microsoft.VisualBasic.Interaction.InputBox("NUEVA PANTALLA", "Ingrese Numero de Inventario Pantalla", "", 600);
            if (NuevoInventario == "") { return; }
            try
            {
                if (this.pantallaTableAdapter.ObtenerInventario(NuevoInventario).ToString().Length != 0) { MessageBox.Show("Inventario Existe"); return; }
            }
            catch (NullReferenceException)
            {
                this.pantallaTableAdapter.InsertInventarioPantalla(NuevoInventario);
                int var0 = (int)FuncionesEquipo.estado.ObtenerEstado("BUENO");
                int var1 = (int)this.pantallaTableAdapter.ObtenerMarca("N/A");
                int var2 = (int)this.pantallaTableAdapter.ObtenerModelo("N/A");
                int var3 = (int)this.pantallaTableAdapter.ObtenerSerie("N/A");
                int var4 = (int)this.pantallaTableAdapter.ObtenerPulgadas("N/A");
                int var5 = (int)this.pantallaTableAdapter.ObtenerIdTablaInventario(NuevoInventario);
                

                this.pantallaTableAdapter.InsertPantalla(var5,var4,var1,var2,var3,var0);
                MessageBox.Show("Nuevo Inventario Creado!!");
                this.pantallaTableAdapter.Fill(this.sistemasFCNMDataSet.Pantalla);
                this.pantallaTableAdapter.FillBy(this.sistemasFCNMDataSet.Pantalla, (int)this.pantallaTableAdapter.ObtenerIdPantalla(NuevoInventario));

            }
        }
    }
}
