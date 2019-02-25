using sistemaFCNM.Clases;
using sistemaFCNM.Controlador;
using sistemaFCNM.sistemasFCNMDataSetTableAdapters;
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
    public partial class Parlante : Form
    {
        private string InventarioAnterior;
        private string SerieAnterior;

        public Parlante()
        {
            InitializeComponent();
        }

        private void Parlante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Parlante' Puede moverla o quitarla según sea necesario.
            this.parlanteTableAdapter.Fill(this.sistemasFCNMDataSet.Parlante);
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.parlanteTableAdapter.FillBy(this.sistemasFCNMDataSet.Parlante, FuncionesUtiles.ID_PARLANTE);
            }

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Impresora(), mainPrincipal.contenedor);
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Regulador(), mainPrincipal.contenedor);
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

        private void guardar()
        {
            //Update Inventario
            try
            {

                if (this.parlanteTableAdapter.ObtenerIdParlante(txtParlante.Text.Trim()).ToString().Length != 0 && this.InventarioAnterior != txtParlante.Text.Trim())
                {
                    MessageBox.Show("Inventario Repetido ");
                }

            }
            catch (NullReferenceException)
            {
                this.parlanteTableAdapter.UpdateInventario(txtParlante.Text.Trim(), this.InventarioAnterior);


            }
            //Update Serie
            try
            {
                if (txtSerie.Text.Trim() != "N/A")
                {
                    if (this.parlanteTableAdapter.ObtenerSerie(txtSerie.Text.Trim()).ToString().Length != 0 && this.SerieAnterior != "N/A")
                    {
                        this.parlanteTableAdapter.UpdateSerie(txtSerie.Text.Trim(), txtParlante.Text.Trim());
                    }
                    else
                    {
                        try
                        {
                            this.parlanteTableAdapter.UpdateTablaParlanteSerie((int)this.parlanteTableAdapter.ObtenerSerie(txtSerie.Text), txtParlante.Text.Trim());
                        }
                        catch (InvalidOperationException)
                        {

                            this.parlanteTableAdapter.InsertSerie(txtSerie.Text.Trim());
                            this.parlanteTableAdapter.UpdateTablaParlanteSerie((int)this.parlanteTableAdapter.ObtenerSerie(txtSerie.Text), txtParlante.Text.Trim());
                        }

                    }

                }
                else
                {
                    this.parlanteTableAdapter.UpdateTablaParlanteSerie((int)this.parlanteTableAdapter.ObtenerSerie(txtSerie.Text), txtParlante.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.parlanteTableAdapter.InsertSerie(txtSerie.Text.Trim());
                this.parlanteTableAdapter.UpdateTablaParlanteSerie((int)this.parlanteTableAdapter.ObtenerSerie(txtSerie.Text), txtParlante.Text.Trim());
            }

            //Update Combos
            try
            {
                this.parlanteTableAdapter.UpdateTablaParlante(this.parlanteTableAdapter.ObtenerMarca(comboMarca.SelectedItem.ToString()),
                this.parlanteTableAdapter.ObtenerModelo(comboModelo.SelectedItem.ToString()),
                this.parlanteTableAdapter.ObtenerEstado(comboEstado.SelectedItem.ToString()), txtParlante.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.parlanteTableAdapter.UpdateTablaParlante(this.parlanteTableAdapter.ObtenerMarca(comboMarca.Text),
                this.parlanteTableAdapter.ObtenerModelo(comboModelo.Text),
                this.parlanteTableAdapter.ObtenerEstado(comboEstado.Text), txtSerie.Text.Trim());
            }
            FuncionesUtiles.OBSERVACION += "Parlante: " + Microsoft.VisualBasic.Interaction.InputBox("OBSERVACION", "Ingrese Su Observacion", "", 600) + " ; ";
            FuncionesEquipo.ActualizarInventario(FuncionesUtiles.OBSERVACION);
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

            txtParlante.Enabled = true;
            comboEstado.Enabled = true;
            comboMarca.Enabled = true;
            comboModelo.Enabled = true;
            txtSerie.Enabled = true;
        }

        private void parlanteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            switch (FuncionesUtiles.ventanaDialogo())
            {

                case "Yes":

                    guardar();
                    this.parlanteTableAdapter.Fill(this.sistemasFCNMDataSet.Parlante);
                    ApagarBotones();
                    gridParlante.Enabled = true;
                    return;

                case "No":
                    this.parlanteTableAdapter.Fill(this.sistemasFCNMDataSet.Parlante);
                    ApagarBotones();
                    gridParlante.Enabled = true;
                    return;

                case "Cancel":
                    return;

                default:
                    return;
            }
           


        }

        private void ApagarBotones()
        {
            txtParlante.Enabled = false;
            comboEstado.Enabled = false;
            comboMarca.Enabled = false;
            comboModelo.Enabled = false;
            txtSerie.Enabled = false;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            habilitarBotones();
            comboEstado.Items.AddRange(Datos._obtenerEstado());
            comboMarca.Items.AddRange(Datos._obtenerMarcaParlante());
            comboModelo.Items.AddRange(Datos._obtenerModeloParlante());

            this.InventarioAnterior = txtParlante.Text.Trim();
            this.SerieAnterior = txtSerie.Text.Trim();

            gridParlante.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string NuevoInventario = Microsoft.VisualBasic.Interaction.InputBox("NUEVA PARLANTE", "Ingrese Numero de Inventario Parlante", "", 600);
            if (NuevoInventario == "") { return; }
            try
            {
                if (this.parlanteTableAdapter.ObtenerInventario(NuevoInventario).ToString().Length != 0) { MessageBox.Show("Inventario Existe"); return; }
            }
            catch (NullReferenceException)
            {
                this.parlanteTableAdapter.InsertInventarioParlante(NuevoInventario);
                int var0 = (int)FuncionesEquipo.estado.ObtenerEstado("BUENO");
                int var1 = (int)this.parlanteTableAdapter.ObtenerMarca("N/A");
                int var2 = (int)this.parlanteTableAdapter.ObtenerModelo("N/A");
                int var3 = (int)this.parlanteTableAdapter.ObtenerSerie("N/A");
                int var5 = (int)this.parlanteTableAdapter.ObtenerIdInventarioParlante(NuevoInventario);


                this.parlanteTableAdapter.InsertParlante(var5, var1, var2, var3, var0);
                MessageBox.Show("Nuevo Inventario Creado!!");
                this.parlanteTableAdapter.Fill(this.sistemasFCNMDataSet.Parlante);
                this.parlanteTableAdapter.FillBy(this.sistemasFCNMDataSet.Parlante, (int)this.parlanteTableAdapter.ObtenerIdParlante(NuevoInventario));

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string var = Microsoft.VisualBasic.Interaction.InputBox("NUEVO MARCA", "Ingrese Marca", "", 600);
            if ((int)this.parlanteTableAdapter.ObtenerMarca(var).ToString().Length != 0)
            {
                MessageBox.Show("Dato ya Existe!!"); return;
            }
            this.parlanteTableAdapter.InsertMarca(var);
            comboMarca.Items.Clear();
            comboMarca.Items.AddRange(Datos._obtenerMarcaParlante());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string var = Microsoft.VisualBasic.Interaction.InputBox("NUEVO ESTADO", "Ingrese Estado", "", 600);
            if (FuncionesEquipo.estado.ObtenerEstado(var).ToString().Length != 0)
            {
                MessageBox.Show("Dato ya Existe!!"); return;
            }
            FuncionesEquipo.estado.InsertEstado(var);
            comboEstado.Items.Clear();
            comboEstado.Items.AddRange(Datos._obtenerEstado());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string var = Microsoft.VisualBasic.Interaction.InputBox("NUEVO MODELO", "Ingrese Modelo", "", 600);
            if ((int)this.parlanteTableAdapter.ObtenerModelo(var).ToString().Length != 0)
            {
                MessageBox.Show("Dato ya Existe!!"); return;
            }
            this.parlanteTableAdapter.InsertModelo(var);
            comboModelo.Items.Clear();
            comboModelo.Items.AddRange(Datos._obtenerModeloParlante());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            String Text = Environment.UserName;
            Datos.writeCSV(gridParlante, "C:\\Users\\"+Text+"\\Downloads\\ParlanteReporte.csv");
            MessageBox.Show("Descargado!!");
        }
    }
}
