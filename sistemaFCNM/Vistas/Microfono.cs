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
            //Update Inventario
            try
            {

                if (this.microfonoTableAdapter.ObtenerIdMicro(txtMicro.Text.Trim()).ToString().Length != 0 && this.InventarioAnterior != txtMicro.Text.Trim())
                {
                    MessageBox.Show("Inventario Repetido ");
                }
                else if (this.microfonoTableAdapter.ObtenerIdMicro(txtMicro.Text.Trim()).ToString().Length == 0 && this.InventarioAnterior != txtMicro.Text.Trim())
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

            FuncionesUtiles.OBSERVACION += "Microfono: " + Microsoft.VisualBasic.Interaction.InputBox("OBSERVACION", "Ingrese Su Observacion", "", 600) + " ; ";
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
            switch (FuncionesUtiles.ventanaDialogo())
            {

                case "Yes":

                    guardar();
                    this.microfonoTableAdapter.Fill(this.sistemasFCNMDataSet.Microfono);
                    ApagarBotones();
                    gridMicrofono.Enabled = true;
                    return;

                case "No":
                    this.microfonoTableAdapter.Fill(this.sistemasFCNMDataSet.Microfono);
                    ApagarBotones();
                    gridMicrofono.Enabled = true;
                    return;

                case "Cancel":
                    return;

                default:
                    return;
            }


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
            comboTipo.Items.Clear();
            comboMarca.Items.Clear();
            comboEstado.Items.Clear();

            comboEstado.Items.AddRange(Datos._obtenerEstado());
            comboMarca.Items.AddRange(Datos._obtenerMarcaMicro());
            comboTipo.Items.AddRange(Datos._obtenerTipoMicro());

            this.InventarioAnterior = txtMicro.Text.Trim();
            this.SerieAnterior = txtSerie.Text.Trim();

            gridMicrofono.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string NuevoInventario = Microsoft.VisualBasic.Interaction.InputBox("NUEVA MICROFONO", "Ingrese Numero de Inventario Microfono", "", 600);
            if (NuevoInventario == "") { return; }
            try
            {
                if (this.microfonoTableAdapter.ObtenerInventario(NuevoInventario).ToString().Length != 0) { MessageBox.Show("Inventario Existe"); return; }
            }
            catch (NullReferenceException)
            {
                this.microfonoTableAdapter.InsertInventarioMicro(NuevoInventario);
                int var0 = (int)FuncionesEquipo.estado.ObtenerEstado("BUENO");
                int var1 = (int)this.microfonoTableAdapter.ObtenerMarca("N/A");
                int var2 = (int)this.microfonoTableAdapter.ObtenerTipo("N/A");
                int var3 = (int)this.microfonoTableAdapter.ObtenerSerie("N/A");
                int var5 = (int)this.microfonoTableAdapter.ObtenerIdInventarioMicro(NuevoInventario);


                this.microfonoTableAdapter.InsertMicro(var5, var1, var2, var3, var0);
                MessageBox.Show("Nuevo Inventario Creado!!");
                this.microfonoTableAdapter.Fill(this.sistemasFCNMDataSet.Microfono);
                this.microfonoTableAdapter.FillBy(this.sistemasFCNMDataSet.Microfono, (int)this.microfonoTableAdapter.ObtenerIdMicro(NuevoInventario));

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            String Text = Environment.UserName;
            Datos.writeCSV(gridMicrofono, "C:\\Users\\"+Text+"\\Downloads\\MicrofonoReporte.csv");
            MessageBox.Show("Descargado!!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string var = Microsoft.VisualBasic.Interaction.InputBox("NUEVO TIPO", "Ingrese Tipo", "", 600);
            if ((int)this.microfonoTableAdapter.ObtenerTipo(var).ToString().Length != 0)
            {
                MessageBox.Show("Dato ya Existe!!"); return;
            }


            this.microfonoTableAdapter.Inserttipo(var);
            comboTipo.Items.Clear();
            comboTipo.Items.AddRange(Datos._obtenerTipoMicro());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string var = Microsoft.VisualBasic.Interaction.InputBox("NUEVO MARCA", "Ingrese Marca", "", 600);
            if ((int)this.microfonoTableAdapter.ObtenerMarca(var).ToString().Length != 0)
            {
                MessageBox.Show("Dato ya Existe!!"); return;
            }


            this.microfonoTableAdapter.InsertMarca(var);
            comboMarca.Items.Clear();
            comboMarca.Items.AddRange(Datos._obtenerMarcaMicro());
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
    }
}
