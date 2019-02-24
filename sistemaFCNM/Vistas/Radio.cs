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
    public partial class Radio : Form
    {
        private string InventarioAnterior;


        public string SerieAnterior { get; private set; }

        public Radio()
        {
            InitializeComponent();
        }

        private void Radio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Radio' Puede moverla o quitarla según sea necesario.
            this.radioTableAdapter.Fill(this.sistemasFCNMDataSet.Radio);
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.radioTableAdapter.FillBy(this.sistemasFCNMDataSet.Radio, FuncionesUtiles.ID_RADIO);
            }
    
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new PProyeccion(), mainPrincipal.contenedor);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            
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
                if (this.radioTableAdapter.ObtenerIdRadio(txtRadio.Text.Trim()).ToString().Length != 0 && this.InventarioAnterior != txtRadio.Text.Trim())
                {
                    MessageBox.Show("Inventario Repetido ");
                }
            }
            catch (NullReferenceException)
            {
                this.radioTableAdapter.UpdateInventario(txtRadio.Text.Trim(), this.InventarioAnterior);


            }
            //Update Serie
            try
            {
                if (txtSerie.Text.Trim() != "N/A")
                {
                    if (this.radioTableAdapter.ObtenerSerie(txtSerie.Text.Trim()).ToString().Length != 0 && this.SerieAnterior != "N/A")
                    {
                        this.radioTableAdapter.UpdateSerie(txtSerie.Text.Trim(), txtRadio.Text.Trim());
                    }
                    else
                    {
                        try
                        {
                            this.radioTableAdapter.UpdateTablaRadioSerie((int)this.radioTableAdapter.ObtenerSerie(txtSerie.Text), txtRadio.Text.Trim());
                        }
                        catch (InvalidOperationException)
                        {

                            this.radioTableAdapter.InsertSerie(txtSerie.Text.Trim());
                            this.radioTableAdapter.UpdateTablaRadioSerie((int)this.radioTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtRadio.Text.Trim());
                        }

                    }

                }
                else
                {

                    this.radioTableAdapter.UpdateTablaRadioSerie((int)this.radioTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtRadio.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.radioTableAdapter.InsertSerie(txtSerie.Text.Trim());
                this.radioTableAdapter.UpdateTablaRadioSerie((int)this.radioTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtRadio.Text.Trim());
            }
            //Update Combos
            try
            {
                this.radioTableAdapter.UpdateTablaRadio(this.radioTableAdapter.ObtenerMarca(comboMarca.SelectedItem.ToString()),
                (int)this.radioTableAdapter.ObtenerModelo(comboModelo.SelectedItem.ToString()),
                this.radioTableAdapter.ObtenerEstado(comboEstado.SelectedItem.ToString()), txtRadio.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.radioTableAdapter.UpdateTablaRadio(this.radioTableAdapter.ObtenerMarca(comboMarca.Text),
               (int)this.radioTableAdapter.ObtenerModelo(comboModelo.Text),
                 this.radioTableAdapter.ObtenerEstado(comboEstado.Text), txtRadio.Text.Trim());
            }
            FuncionesUtiles.OBSERVACION += "Radio: "+Microsoft.VisualBasic.Interaction.InputBox("OBSERVACION", "Ingrese Su Observacion", "", 600)+" ; ";
            FuncionesEquipo.ActualizarInventario(FuncionesUtiles.OBSERVACION);
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
            txtRadio.Enabled = true;            
            comboEstado.Enabled = true;
            comboMarca.Enabled = true;
            comboModelo.Enabled = true;
            txtSerie.Enabled = true;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            


            mainPrincipal.btn13.Visible = true;
            mainPrincipal.btn1.Visible = true;
            mainPrincipal.btn2.Visible = true;
            mainPrincipal.btn3.Visible = true;
            mainPrincipal.btn4.Visible = true;
            mainPrincipal.btn5.Visible = true;
            mainPrincipal.btn6.Visible = true;
            mainPrincipal.btn7.Visible = true;
            mainPrincipal.btn8.Visible = true;
            mainPrincipal.btn9.Visible = true;
            mainPrincipal.btn10.Visible = true;
            mainPrincipal.btn11.Visible = true;
            mainPrincipal.btn12.Visible = true;
            FuncionesUtiles.siguienteActiva = false;
            FuncionesUtiles.INVENTARIO_EQUIPO = "";
            FuncionesUtiles.masdetallesActiva = false;
            FuncionesUtiles.OBSERVACION = "";
            MessageBox.Show("Inventario Finalizado");
            this.Visible = false;
            FuncionesUtiles.form1 = new mainPrincipal();
            FuncionesUtiles.form1.Show();
        }

        private void radioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            switch (FuncionesUtiles.ventanaDialogo())
            {

                case "Yes":

                    guardar();
                    this.radioTableAdapter.Fill(this.sistemasFCNMDataSet.Radio);
                    ApagarBotones();
                    gridRadio.Enabled = true;
                    return;

                case "No":
                    this.radioTableAdapter.Fill(this.sistemasFCNMDataSet.Radio);
                    ApagarBotones();
                    gridRadio.Enabled = true;
                    return;

                case "Cancel":
                    return;

                default:
                    return;
            }
            

        }

        private void ApagarBotones()
        {
            txtRadio.Enabled = false;
            comboEstado.Enabled = false;
            comboMarca.Enabled = false;
            comboModelo.Enabled = false;
            txtSerie.Enabled = false;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            habilitarBotones();
            comboEstado.Items.AddRange(Datos._obtenerEstado());
            comboMarca.Items.AddRange(Datos._obtenerMarcaRadio());
            comboModelo.Items.AddRange(Datos._obtenerModeloRadio());

            this.InventarioAnterior = txtRadio.Text.Trim();
            this.SerieAnterior = txtSerie.Text.Trim();

            gridRadio.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string NuevoInventario = Microsoft.VisualBasic.Interaction.InputBox("NUEVA RADIO", "Ingrese Numero de Inventario Radio", "", 600);
            if (NuevoInventario == "") { return; }
            try
            {
                if (this.radioTableAdapter.ObtenerInventario(NuevoInventario).ToString().Length != 0) { MessageBox.Show("Inventario Existe"); return; }
            }
            catch (NullReferenceException)
            {
                this.radioTableAdapter.InsertInventarioRadio(NuevoInventario);
                int var0 = (int)FuncionesEquipo.estado.ObtenerEstado("BUENO");
                int var1 = (int)this.radioTableAdapter.ObtenerMarca("N/A");
                int var2 = (int)this.radioTableAdapter.ObtenerModelo("N/A");
                int var3 = (int)this.radioTableAdapter.ObtenerSerie("N/A");
                int var5 = (int)this.radioTableAdapter.ObtenerIdInventarioRadio(NuevoInventario);


                this.radioTableAdapter.InsertRadio(var5, var1, var2, var3, var0);
                MessageBox.Show("Nuevo Inventario Creado!!");
                this.radioTableAdapter.Fill(this.sistemasFCNMDataSet.Radio);
                this.radioTableAdapter.FillBy(this.sistemasFCNMDataSet.Radio, (int)this.radioTableAdapter.ObtenerIdRadio(NuevoInventario));

            }
        }
    }
}
