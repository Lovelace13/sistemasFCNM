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
            txtEquipo.Text = FuncionesUtiles.INVENTARIO_EQUIPO;
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.impresoraTableAdapter.FillBy(this.sistemasFCNMDataSet.Impresora, FuncionesUtiles.ID_IMPRESORA);
            }

        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Proyector());
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Parlante());
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
            //Update Inventario
            try
            {

                if (this.impresoraTableAdapter.ObtenerIdImpresora(txtImpresora.Text.Trim()).ToString().Length != 0 && this.InventarioAnterior != txtImpresora.Text.Trim())
                {
                    if (txtImpresora.Enabled)
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
            if (FuncionesUtiles.INVENTARIO_EQUIPO == "" || FuncionesUtiles.INVENTARIO_EQUIPO == null) { return; }
            FuncionesUtiles.OBSERVACION += "Impresora: " + Microsoft.VisualBasic.Interaction.InputBox("OBSERVACION", "Ingrese Su Observacion", "", 600) + " ; ";
            FuncionesEquipo.ActualizarInventario(FuncionesUtiles.OBSERVACION);


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
            switch (FuncionesUtiles.ventanaDialogo())
            {

                case "Yes":

                    guardar();
                    this.gridImpresora.Enabled = true;
                    this.ApagarBotones();
                    Impresora_Load(sender, e);
                    return;

                case "No":
                    this.gridImpresora.Enabled = true;
                    this.ApagarBotones();
                    Impresora_Load(sender, e);
                    return;

                case "Cancel":
                    return;

                default:
                    return;
            }


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
            comboMarca.Items.Clear();
            comboModelo.Items.Clear();
            comboEstado.Items.Clear();

            comboEstado.Items.AddRange(Datos._obtenerEstado());
            comboMarca.Items.AddRange(Datos._obtenerMarcaImpresora());
            comboModelo.Items.AddRange(Datos._obtenerModeloImpresora());

            this.InventarioAnterior = txtImpresora.Text.Trim();
            this.SerieAnterior = txtSerie.Text.Trim();

            gridImpresora.Enabled = false;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string NuevoInventario = Microsoft.VisualBasic.Interaction.InputBox("NUEVA IMPRESORA", "Ingrese Numero de Inventario Impresora", "", 600);
            if (NuevoInventario == "") { return; }
            try
            {
                if (this.impresoraTableAdapter.ObtenerInventario(NuevoInventario).ToString().Length != 0) { MessageBox.Show("Inventario Existe"); return; }
            }
            catch (NullReferenceException)
            {
                this.impresoraTableAdapter.InsertInventarioImpresora(NuevoInventario);
                int var0 = (int)FuncionesEquipo.estado.ObtenerEstado("BUENO");
                int var1 = (int)this.impresoraTableAdapter.ObtenerMarca("N/A");
                int var2 = (int)this.impresoraTableAdapter.ObtenerModelo("N/A");
                int var3 = (int)this.impresoraTableAdapter.ObtenerSerie("N/A");
                int var5 = (int)this.impresoraTableAdapter.ObtenerIdInventarioImpresora(NuevoInventario);


                this.impresoraTableAdapter.InsertImpresora(var5, var1, var2, var3, var0);
                MessageBox.Show("Nuevo Inventario Creado!!");
                this.impresoraTableAdapter.Fill(this.sistemasFCNMDataSet.Impresora);
                this.impresoraTableAdapter.FillBy(this.sistemasFCNMDataSet.Impresora, (int)this.impresoraTableAdapter.ObtenerIdImpresora(NuevoInventario));

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string var = Microsoft.VisualBasic.Interaction.InputBox("NUEVO MARCA", "Ingrese Marca", "", 600);
            if ((int)this.impresoraTableAdapter.ObtenerMarca(var).ToString().Length != 0)
            {
                MessageBox.Show("Dato ya Existe!!"); return;
            }
            this.impresoraTableAdapter.InsertMarca(var);
            comboMarca.Items.Clear();
            comboMarca.Items.AddRange(Datos._obtenerMarcaImpresora());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string var = Microsoft.VisualBasic.Interaction.InputBox("NUEVO MODELO", "Ingrese Modelo", "", 600);
            if ((int)this.impresoraTableAdapter.ObtenerModelo(var).ToString().Length != 0)
            {
                MessageBox.Show("Dato ya Existe!!"); return;
            }
            this.impresoraTableAdapter.InsertModelo(var);
            comboModelo.Items.Clear();
            comboModelo.Items.AddRange(Datos._obtenerModeloImpresora());
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            String Text = Environment.UserName;
            Datos.writeCSV(gridImpresora, "C:\\Users\\"+Text+"\\Downloads\\ImpresoraReporte.csv");
            MessageBox.Show("Descargado!!");
        }
    }
}
