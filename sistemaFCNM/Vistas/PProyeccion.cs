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
    public partial class PProyeccion : Form
    {
        private string InventarioAnterior;
        private string SerieAnterior;

        public PProyeccion()
        {
            InitializeComponent();
        }

        private void PProyeccion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.PantallaProyeccion' Puede moverla o quitarla según sea necesario.
            this.pantallaProyeccionTableAdapter.Fill(this.sistemasFCNMDataSet.PantallaProyeccion);
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.pantallaProyeccionTableAdapter.FillBy(this.sistemasFCNMDataSet.PantallaProyeccion, FuncionesUtiles.ID_PANTALLAPROY);
            }
          
        }

      

        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Radio(), mainPrincipal.contenedor);
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Telefono(), mainPrincipal.contenedor);
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
                if (this.pantallaProyeccionTableAdapter.ObtenerIdPP(txtPproyeccion.Text.Trim()).ToString().Length != 0 && this.InventarioAnterior != txtPproyeccion.Text.Trim())
                {
                    MessageBox.Show("Inventario Repetido ");
                }
            }
            catch (NullReferenceException)
            {
                this.pantallaProyeccionTableAdapter.UpdateInventario(txtPproyeccion.Text.Trim(), this.InventarioAnterior);


            }
            //Update Serie
            try
            {
                if (txtSerie.Text.Trim() != "N/A")
                {
                    if (this.pantallaProyeccionTableAdapter.ObtenerSerie(txtSerie.Text.Trim()).ToString().Length != 0 && this.SerieAnterior != "N/A")
                    {
                        this.pantallaProyeccionTableAdapter.UpdateSerie(txtSerie.Text.Trim(), txtPproyeccion.Text.Trim());
                    }
                    else
                    {
                        try
                        {
                            this.pantallaProyeccionTableAdapter.UpdateTablaPPSerie((int)this.pantallaProyeccionTableAdapter.ObtenerSerie(txtSerie.Text), txtPproyeccion.Text.Trim());
                        }
                        catch (InvalidOperationException)
                        {

                            this.pantallaProyeccionTableAdapter.InsertSerie(txtSerie.Text.Trim());
                            this.pantallaProyeccionTableAdapter.UpdateTablaPPSerie((int)this.pantallaProyeccionTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtPproyeccion.Text.Trim());
                        }

                    }

                }
                else
                {

                    this.pantallaProyeccionTableAdapter.UpdateTablaPPSerie((int)this.pantallaProyeccionTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtPproyeccion.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.pantallaProyeccionTableAdapter.InsertSerie(txtSerie.Text.Trim());
                this.pantallaProyeccionTableAdapter.UpdateTablaPPSerie((int)this.pantallaProyeccionTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtPproyeccion.Text.Trim());
            }
            //Update Combos
            try
            {
                this.pantallaProyeccionTableAdapter.UpdateTablaPP(this.pantallaProyeccionTableAdapter.ObtenerMarca(comboMarca.SelectedItem.ToString()),
                this.pantallaProyeccionTableAdapter.ObtenerModelo(comboModelo.SelectedItem.ToString()),
                this.pantallaProyeccionTableAdapter.ObtenerEstado(comboEstado.SelectedItem.ToString()),
                this.pantallaProyeccionTableAdapter.ObtenerDimensiones(comboDimensiones.SelectedItem.ToString()), txtPproyeccion.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.pantallaProyeccionTableAdapter.UpdateTablaPP(this.pantallaProyeccionTableAdapter.ObtenerMarca(comboMarca.Text),
                 this.pantallaProyeccionTableAdapter.ObtenerModelo(comboModelo.Text),
                 this.pantallaProyeccionTableAdapter.ObtenerEstado(comboEstado.Text),
                 this.pantallaProyeccionTableAdapter.ObtenerDimensiones(comboDimensiones.Text), txtPproyeccion.Text.Trim());
            }

            FuncionesUtiles.OBSERVACION += "Pantalla Proyeccion: " + Microsoft.VisualBasic.Interaction.InputBox("OBSERVACION", "Ingrese Su Observacion", "", 600) + " ; ";
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
            
            txtPproyeccion.Enabled = true;
            comboDimensiones.Enabled = true;
            comboEstado.Enabled = true;
            comboMarca.Enabled = true;
            comboModelo.Enabled = true;
            txtSerie.Enabled = true;
        }

        private void pantallaProyeccionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            switch (FuncionesUtiles.ventanaDialogo())
            {

                case "Yes":

                    guardar();
                    this.pantallaProyeccionTableAdapter.Fill(this.sistemasFCNMDataSet.PantallaProyeccion);
                    ApagarBotones();
                    gridPP.Enabled = true;
                    return;

                case "No":
                    this.pantallaProyeccionTableAdapter.Fill(this.sistemasFCNMDataSet.PantallaProyeccion);
                    ApagarBotones();
                    gridPP.Enabled = true;
                    return;

                case "Cancel":
                    return;

                default:
                    return;
            }

           

        }

        private void ApagarBotones()
        {
            txtPproyeccion.Enabled = false;
            comboDimensiones.Enabled = false;
            comboEstado.Enabled = false;
            comboMarca.Enabled = false;
            comboModelo.Enabled = false;
            txtSerie.Enabled = false;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            habilitarBotones();
            comboEstado.Items.AddRange(Datos._obtenerEstado());
            comboMarca.Items.AddRange(Datos._obtenerMarcaPP());
            comboModelo.Items.AddRange(Datos._obtenerModeloPP());
            comboDimensiones.Items.AddRange(Datos._obtenerDimensionesPP());

            this.InventarioAnterior = txtPproyeccion.Text.Trim();
            this.SerieAnterior = txtSerie.Text.Trim();

            gridPP.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string NuevoInventario = Microsoft.VisualBasic.Interaction.InputBox("NUEVA PANTALLA PROYECCION", "Ingrese Numero de Inventario Pantalla Proyeccion", "", 600);
            if (NuevoInventario == "") { return; }
            try
            {
                if (this.pantallaProyeccionTableAdapter.ObtenerInventario(NuevoInventario).ToString().Length != 0) { MessageBox.Show("Inventario Existe"); return; }
            }
            catch (NullReferenceException)
            {
                pantallaProyeccionTableAdapter.InsertInventarioPP(NuevoInventario);
                int var0 = (int)FuncionesEquipo.estado.ObtenerEstado("BUENO");
                int var1 = (int)this.pantallaProyeccionTableAdapter.ObtenerMarca("N/A");
                int var2 = (int)this.pantallaProyeccionTableAdapter.ObtenerModelo("N/A");
                int var3 = (int)this.pantallaProyeccionTableAdapter.ObtenerSerie("N/A");
                int var4 = (int)this.pantallaProyeccionTableAdapter.ObtenerDimensiones("N/A");
                int var5 = (int)this.pantallaProyeccionTableAdapter.ObtenerIdInventarioPP(NuevoInventario);


                this.pantallaProyeccionTableAdapter.InsertPP(var5, var4, var1, var2, var3, var0);
                MessageBox.Show("Nuevo Inventario Creado!!");
                this.pantallaProyeccionTableAdapter.Fill(this.sistemasFCNMDataSet.PantallaProyeccion);
                this.pantallaProyeccionTableAdapter.FillBy(this.sistemasFCNMDataSet.PantallaProyeccion, (int)this.pantallaProyeccionTableAdapter.ObtenerIdPP(NuevoInventario));

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string var = Microsoft.VisualBasic.Interaction.InputBox("NUEVO MARCA", "Ingrese Marca", "", 600);
            if ((int)this.pantallaProyeccionTableAdapter.ObtenerMarca(var).ToString().Length != 0)
            {
                MessageBox.Show("Dato ya Existe!!"); return;
            }
            this.pantallaProyeccionTableAdapter.InsertMarca(var);
            comboMarca.Items.Clear();
            comboMarca.Items.AddRange(Datos._obtenerMarcaPP());
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
            if ((int)this.pantallaProyeccionTableAdapter.ObtenerModelo(var).ToString().Length != 0)
            {
                MessageBox.Show("Dato ya Existe!!"); return;
            }
            this.pantallaProyeccionTableAdapter.InsertModelo(var);
            comboModelo.Items.Clear();
            comboModelo.Items.AddRange(Datos._obtenerModeloPP());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string var = Microsoft.VisualBasic.Interaction.InputBox("NUEVO DIMENSIONES", "Ingrese Dimensiones", "", 600);
            if ((int)this.pantallaProyeccionTableAdapter.ObtenerDimensiones(var).ToString().Length != 0)
            {
                MessageBox.Show("Dato ya Existe!!"); return;
            }
            this.pantallaProyeccionTableAdapter.InsertDimensiones(var);
            comboDimensiones.Items.Clear();
            comboDimensiones.Items.AddRange(Datos._obtenerDimensionesPP());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            String Text = Environment.UserName;
            Datos.writeCSV(gridPP, "C:\\Users\\"+Text+"\\Downloads\\PantallaProyeccionReporte.csv");
            MessageBox.Show("Descargado!!");
        }
    }
}
