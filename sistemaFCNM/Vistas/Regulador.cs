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
    public partial class Regulador : Form
    {
        private string InventarioAnterior;

        public string SerieAnterior { get; private set; }

        public Regulador()
        {
            InitializeComponent();
        }

        private void Regulador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Regulador' Puede moverla o quitarla según sea necesario.
            this.reguladorTableAdapter.Fill(this.sistemasFCNMDataSet.Regulador);
            txtEquipo.Text = FuncionesUtiles.INVENTARIO_EQUIPO;
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.reguladorTableAdapter.FillBy(this.sistemasFCNMDataSet.Regulador, FuncionesUtiles.ID_REGULADOR);
            }
      
        }

       
        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Parlante());
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Mouse());
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
                if (this.reguladorTableAdapter.ObtenerIdRegulador(txtRegulador.Text.Trim()).ToString().Length != 0 && this.InventarioAnterior != txtRegulador.Text.Trim())
                {
                    if (txtRegulador.Enabled)
                        MessageBox.Show("Inventario Repetido ");
                }
            }
            catch (NullReferenceException)
            {
                this.reguladorTableAdapter.UpdateRegulador(txtRegulador.Text.Trim(), this.InventarioAnterior);


            }
            //Update Serie
            try
            {
                if (txtSerie.Text.Trim() != "N/A")
                {
                    if (this.reguladorTableAdapter.ObtenerSerie(txtSerie.Text.Trim()).ToString().Length != 0 && this.SerieAnterior != "N/A")
                    {
                        this.reguladorTableAdapter.UpdateSerie(txtSerie.Text.Trim(), txtRegulador.Text.Trim());
                    }
                    else
                    {
                        try
                        {
                            this.reguladorTableAdapter.UpdateTablaReguladorSerie((int)this.reguladorTableAdapter.ObtenerSerie(txtSerie.Text), txtRegulador.Text.Trim());
                        }
                        catch (InvalidOperationException)
                        {

                            this.reguladorTableAdapter.InsertSerie(txtSerie.Text.Trim());
                            this.reguladorTableAdapter.UpdateTablaReguladorSerie((int)this.reguladorTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtRegulador.Text.Trim());
                        }

                    }

                }
                else
                {

                    this.reguladorTableAdapter.UpdateTablaReguladorSerie((int)this.reguladorTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtRegulador.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.reguladorTableAdapter.InsertSerie(txtSerie.Text.Trim());
                this.reguladorTableAdapter.UpdateTablaReguladorSerie((int)this.reguladorTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtRegulador.Text.Trim());
            }
            //Update Combos
            try
            {
                this.reguladorTableAdapter.UpdateTablaRegulador(this.reguladorTableAdapter.ObtenerMarca(comboMarca.SelectedItem.ToString()),
                this.reguladorTableAdapter.ObtenerModelo(comboModelo.SelectedItem.ToString()),
                this.reguladorTableAdapter.ObtenerEstado(comboEstado.SelectedItem.ToString()),
                this.reguladorTableAdapter.ObtenerTipo(comboTipo.SelectedItem.ToString()), txtRegulador.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.reguladorTableAdapter.UpdateTablaRegulador(this.reguladorTableAdapter.ObtenerMarca(comboMarca.Text),
                this.reguladorTableAdapter.ObtenerModelo(comboModelo.Text),
                 this.reguladorTableAdapter.ObtenerEstado(comboEstado.Text),
                 this.reguladorTableAdapter.ObtenerTipo(comboTipo.Text), txtRegulador.Text.Trim());
            }
            if (FuncionesUtiles.INVENTARIO_EQUIPO == "" || FuncionesUtiles.INVENTARIO_EQUIPO == null) { return; }
            FuncionesUtiles.OBSERVACION += "Regulador: " + Microsoft.VisualBasic.Interaction.InputBox("OBSERVACION", "Ingrese Su Observacion", "", 600) + " ; ";
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
            
            txtRegulador.Enabled = true;
            comboTipo.Enabled = true;
            comboEstado.Enabled = true;
            comboMarca.Enabled = true;
            comboModelo.Enabled = true;
            txtSerie.Enabled = true;
        }

        private void reguladorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            switch (FuncionesUtiles.ventanaDialogo())
            {

                case "Yes":

                    guardar();
                    Regulador_Load( sender,  e);
                    ApagarBotones();
                    gridRegulador.Enabled = true;
                    return;

                case "No":
                    Regulador_Load( sender,  e);
                    ApagarBotones();
                    gridRegulador.Enabled = true;
                    return;

                case "Cancel":
                    return;

                default:
                    return;
            }
           

        }

        private void ApagarBotones()
        {
            txtRegulador.Enabled = false;
            comboTipo.Enabled = false;
            comboEstado.Enabled = false;
            comboMarca.Enabled = false;
            comboModelo.Enabled = false;
            txtSerie.Enabled = false;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            habilitarBotones();
            comboEstado.Items.AddRange(Datos._obtenerEstado());
            comboMarca.Items.AddRange(Datos._obtenerMarcaRegulador());
            comboModelo.Items.AddRange(Datos._obtenerModeloregulador());
            comboTipo.Items.AddRange(Datos._obtenerTipoRegulador());

            this.InventarioAnterior = txtRegulador.Text.Trim();
            this.SerieAnterior = txtSerie.Text.Trim();

            gridRegulador.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string NuevoInventario = Microsoft.VisualBasic.Interaction.InputBox("NUEVO REGULADOR", "Ingrese Numero de Inventario Regulador", "", 600);
            if (NuevoInventario == "") { return; }
            try
            {
                if (this.reguladorTableAdapter.ObtenerInventario(NuevoInventario).ToString().Length != 0) { MessageBox.Show("Inventario Existe"); return; }
            }
            catch (NullReferenceException)
            {
                this.reguladorTableAdapter.InsertInventarioRegulador(NuevoInventario);
                int var0 = (int)FuncionesEquipo.estado.ObtenerEstado("BUENO");
                int var1 = (int)this.reguladorTableAdapter.ObtenerMarca("N/A");
                int var2 = (int)this.reguladorTableAdapter.ObtenerModelo("N/A");
                int var3 = (int)this.reguladorTableAdapter.ObtenerSerie("N/A");
                int var4 = (int)this.reguladorTableAdapter.ObtenerTipo("N/A");
                int var5 = (int)this.reguladorTableAdapter.ObtenerInventarioRegulador(NuevoInventario);


                this.reguladorTableAdapter.InsertRegulador(var5, var4, var1, var2, var3, var0);
                MessageBox.Show("Nuevo Inventario Creado!!");
                this.reguladorTableAdapter.Fill(this.sistemasFCNMDataSet.Regulador);
                this.reguladorTableAdapter.FillBy(this.sistemasFCNMDataSet.Regulador, (int)this.reguladorTableAdapter.ObtenerIdRegulador(NuevoInventario));

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string var = Microsoft.VisualBasic.Interaction.InputBox("NUEVO MARCA", "Ingrese Marca", "", 600);
            if ((int)this.reguladorTableAdapter.ObtenerMarca(var).ToString().Length != 0)
            {
                MessageBox.Show("Dato ya Existe!!"); return;
            }
            this.reguladorTableAdapter.InsertMarca(var);
            comboMarca.Items.Clear();
            comboMarca.Items.AddRange(Datos._obtenerMarcaRegulador());
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
            if ((int)this.reguladorTableAdapter.ObtenerModelo(var).ToString().Length != 0)
            {
                MessageBox.Show("Dato ya Existe!!"); return;
            }
            this.reguladorTableAdapter.InsertModelo(var);
            comboModelo.Items.Clear();
            comboModelo.Items.AddRange(Datos._obtenerModeloregulador());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string var = Microsoft.VisualBasic.Interaction.InputBox("NUEVO TIPO", "Ingrese Tipo", "", 600);
            if ((int)this.reguladorTableAdapter.ObtenerTipo(var).ToString().Length != 0)
            {
                MessageBox.Show("Dato ya Existe!!"); return;
            }
            this.reguladorTableAdapter.InsertTipo(var);
            comboTipo.Items.Clear();
            comboTipo.Items.AddRange(Datos._obtenerTipoRegulador());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            String Text = Environment.UserName;
            Datos.writeCSV(gridRegulador, "C:\\Users\\"+Text+"\\Downloads\\ReguladorReporte.csv");
            MessageBox.Show("Descargado!!");
        }
    }
}
