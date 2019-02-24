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
    public partial class Mouse : Form
    {
        private string InventarioAnterior;
        private string SerieAnterior;

        public Mouse()
        {
            InitializeComponent();
        }

        private void Mouse_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Mouse' Puede moverla o quitarla según sea necesario.
            this.mouseTableAdapter.Fill(this.sistemasFCNMDataSet.Mouse);
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.mouseTableAdapter.FillBy(this.sistemasFCNMDataSet.Mouse, FuncionesUtiles.ID_MOUSE);
            }
   
        }

     

        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Regulador(), mainPrincipal.contenedor);
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Teclado(), mainPrincipal.contenedor);
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
            //Update Inventario
            try
            {
                if (this.mouseTableAdapter.ObtenerIdMouse(txtMouse.Text.Trim()).ToString().Length != 0 && this.InventarioAnterior != txtMouse.Text.Trim())
                {
                    MessageBox.Show("Inventario Repetido ");
                }
            }
            catch (NullReferenceException)
            {
                this.mouseTableAdapter.UpdateInventario(txtMouse.Text.Trim(), this.InventarioAnterior);


            }
            //Update Serie
            try
            {
                if (txtSerie.Text.Trim() != "N/A")
                {
                    if (this.mouseTableAdapter.ObtenerSerie(txtSerie.Text.Trim()).ToString().Length != 0 && this.SerieAnterior != "N/A")
                    {
                        this.mouseTableAdapter.UpdateSerie(txtSerie.Text.Trim(), txtMouse.Text.Trim());
                    }
                    else
                    {
                        try
                        {
                            this.mouseTableAdapter.UpdateTablaMouseSerie((int)this.mouseTableAdapter.ObtenerSerie(txtSerie.Text), txtMouse.Text.Trim());
                        }
                        catch (InvalidOperationException)
                        {

                            this.mouseTableAdapter.InsertSerie(txtSerie.Text.Trim());
                            this.mouseTableAdapter.UpdateTablaMouseSerie((int)this.mouseTableAdapter.ObtenerSerie(txtSerie.Text), txtMouse.Text.Trim());
                        }

                    }

                }
                else
                {
                    this.mouseTableAdapter.UpdateTablaMouseSerie((int)this.mouseTableAdapter.ObtenerSerie(txtSerie.Text), txtMouse.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.mouseTableAdapter.InsertSerie(txtSerie.Text.Trim());
                this.mouseTableAdapter.UpdateTablaMouseSerie((int)this.mouseTableAdapter.ObtenerSerie(txtSerie.Text), txtMouse.Text.Trim());
            }

            //Update Combos
            try
            {
                this.mouseTableAdapter.UpdateTablaMouse(this.mouseTableAdapter.ObtenerMarca(comboMarca.SelectedItem.ToString()),
                this.mouseTableAdapter.ObtenerModelo(comboModelo.SelectedItem.ToString()),
                this.mouseTableAdapter.ObtenerEstado(comboEstado.SelectedItem.ToString()), txtMouse.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.mouseTableAdapter.UpdateTablaMouse(this.mouseTableAdapter.ObtenerMarca(comboMarca.Text),
                this.mouseTableAdapter.ObtenerModelo(comboModelo.Text),
                this.mouseTableAdapter.ObtenerEstado(comboEstado.Text), txtSerie.Text.Trim());
            }
            FuncionesUtiles.OBSERVACION += "Mouse: " + Microsoft.VisualBasic.Interaction.InputBox("OBSERVACION", "Ingrese Su Observacion", "", 600) + " ; ";
            FuncionesEquipo.ActualizarInventario(FuncionesUtiles.OBSERVACION);


        }

        private void guardarMenuItem_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           
            switch (FuncionesUtiles.ventanaDialogo())
            {
                case "Yes":

                    guardar();
                    this.Close();
                   
                    FuncionesUtiles.form1.Visible = false;
                    FuncionesUtiles.siguienteActiva = true;
                    FuncionesUtiles.desactivarMenu();
                    FuncionesUtiles.abrirVentanas(new CPU(), mainPrincipal.contenedor);
                    return;

                case "No":
                    this.Close();
                   
                    FuncionesUtiles.form1.Visible = false;
                    FuncionesUtiles.siguienteActiva = true;
                    FuncionesUtiles.desactivarMenu();
                    FuncionesUtiles.abrirVentanas(new CPU(), mainPrincipal.contenedor);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
        }
        private void habilitarBotones()
        {
           
            txtMouse.Enabled = true;
            comboEstado.Enabled = true;
            comboMarca.Enabled = true;
            comboModelo.Enabled = true;
            txtSerie.Enabled = true;
        }

        private void mouseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            switch (FuncionesUtiles.ventanaDialogo())
            {

                case "Yes":

                    guardar();
                    this.mouseTableAdapter.Fill(this.sistemasFCNMDataSet.Mouse);
                    ApagarBotones();
                    gridMouse.Enabled = true;
                    return;

                case "No":
                    this.mouseTableAdapter.Fill(this.sistemasFCNMDataSet.Mouse);
                    ApagarBotones();
                    gridMouse.Enabled = true;
                    return;

                case "Cancel":
                    return;

                default:
                    return;
            }

           

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {

            habilitarBotones();

            comboEstado.Items.AddRange(Datos._obtenerEstado());
            comboMarca.Items.AddRange(Datos._obtenerMarcaMouse());
            comboModelo.Items.AddRange(Datos._obtenerModeloMouse());

            this.InventarioAnterior = txtMouse.Text.Trim();
            this.SerieAnterior = txtSerie.Text.Trim();

            gridMouse.Enabled = false;
        }

        private void ApagarBotones()
        {
            txtMouse.Enabled = false;
            comboEstado.Enabled = false;
            comboMarca.Enabled = false;
            comboModelo.Enabled = false;
            txtSerie.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string NuevoInventario = Microsoft.VisualBasic.Interaction.InputBox("NUEVO MOUSE", "Ingrese Numero de Inventario Mouse", "", 600);
            if (NuevoInventario == "") { return; }
            try
            {
                if (this.mouseTableAdapter.ObtenerInventario(NuevoInventario).ToString().Length != 0) { MessageBox.Show("Inventario Existe"); return; }
            }
            catch (NullReferenceException)
            {
                this.mouseTableAdapter.InsertInventarioMouse(NuevoInventario);
                int var0 = (int)FuncionesEquipo.estado.ObtenerEstado("BUENO");
                int var1 = (int)this.mouseTableAdapter.ObtenerMarca("N/A");
                int var2 = (int)this.mouseTableAdapter.ObtenerModelo("N/A");
                int var3 = (int)this.mouseTableAdapter.ObtenerSerie("N/A");
                int var5 = (int)this.mouseTableAdapter.ObtenerIdInventarioMouse(NuevoInventario);


                this.mouseTableAdapter.InsertMouse(var5, var1, var2, var3, var0);
                MessageBox.Show("Nuevo Inventario Creado!!");
                this.mouseTableAdapter.Fill(this.sistemasFCNMDataSet.Mouse);
                this.mouseTableAdapter.FillBy(this.sistemasFCNMDataSet.Mouse, (int)this.mouseTableAdapter.ObtenerIdMouse(NuevoInventario));

            }
        }
    }
}
