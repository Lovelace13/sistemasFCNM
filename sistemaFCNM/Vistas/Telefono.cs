﻿using sistemaFCNM.Clases;
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
    public partial class Telefono : Form
    {
        private string InventarioAnterior;
        private string SerieAnterior;
        private string ExtensionAnterior;


        public Telefono()
        {
            InitializeComponent();
        }

        private void Telefono_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Telefono' Puede moverla o quitarla según sea necesario.
            this.telefonoTableAdapter.Fill(this.sistemasFCNMDataSet.Telefono);
            txtEquipo.Text = FuncionesUtiles.INVENTARIO_EQUIPO;
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.telefonoTableAdapter.FillBy(this.sistemasFCNMDataSet.Telefono, FuncionesUtiles.ID_TELEFONO);
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new PProyeccion());
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Microfono());
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

                    guardar();
                    FuncionesUtiles.siguienteActiva = false;
                    FuncionesUtiles.activarMenu();
                    FuncionesUtiles.INVENTARIO_EQUIPO = "";
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
                if (this.telefonoTableAdapter.ObtenerIdTelefono(txtTelefono.Text.Trim()).ToString().Length != 0 && this.InventarioAnterior != txtTelefono.Text.Trim())
                {
                    if (txtTelefono.Enabled)
                        MessageBox.Show("Inventario Repetido ");
                }
            }
            catch (NullReferenceException)
            {
                this.telefonoTableAdapter.UpdateInventario(txtTelefono.Text.Trim(), this.InventarioAnterior);


            }
            //Update Serie
            try
            {
                if (txtSerie.Text.Trim() != "N/A")
                {
                    if (this.telefonoTableAdapter.ObtenerSerie(txtSerie.Text.Trim()).ToString().Length != 0 && this.SerieAnterior != "N/A")
                    {
                        this.telefonoTableAdapter.UpdateSerie(txtSerie.Text.Trim(), txtTelefono.Text.Trim());
                    }
                    else
                    {
                        try
                        {
                            this.telefonoTableAdapter.UpdateTablaTelefonoSerie((int)this.telefonoTableAdapter.ObtenerSerie(txtSerie.Text), txtTelefono.Text.Trim());
                        }
                        catch (InvalidOperationException)
                        {

                            this.telefonoTableAdapter.InsertSerie(txtSerie.Text.Trim());
                            this.telefonoTableAdapter.UpdateTablaTelefonoSerie((int)this.telefonoTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtTelefono.Text.Trim());
                        }

                    }

                }
                else
                {

                    this.telefonoTableAdapter.UpdateTablaTelefonoSerie((int)this.telefonoTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtTelefono.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.telefonoTableAdapter.InsertSerie(txtSerie.Text.Trim());
                this.telefonoTableAdapter.UpdateTablaTelefonoSerie((int)this.telefonoTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtTelefono.Text.Trim());
            }
            //Update Extension
            try
            {
                if (txtExtension.Text.Trim() != "N/A")
                {
                    if (this.telefonoTableAdapter.ObtenerExtension(txtExtension.Text.Trim()).ToString().Length != 0 && this.ExtensionAnterior != "N/A")
                    {
                        this.telefonoTableAdapter.UpdateExtension(txtExtension.Text.Trim(), txtTelefono.Text.Trim());
                    }
                    else
                    {
                        try
                        {
                            this.telefonoTableAdapter.UpdateTablaTelefonoExtension((int)this.telefonoTableAdapter.ObtenerExtension(txtExtension.Text), txtTelefono.Text.Trim());
                        }
                        catch (InvalidOperationException)
                        {

                            this.telefonoTableAdapter.InsertExtencion(txtExtension.Text.Trim());
                            this.telefonoTableAdapter.UpdateTablaTelefonoExtension((int)this.telefonoTableAdapter.ObtenerExtension(txtExtension.Text.Trim()), txtTelefono.Text.Trim());
                        }

                    }

                }
                else
                {

                    this.telefonoTableAdapter.UpdateTablaTelefonoExtension((int)this.telefonoTableAdapter.ObtenerExtension(txtExtension.Text.Trim()), txtTelefono.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.telefonoTableAdapter.InsertExtencion(txtExtension.Text.Trim());
                this.telefonoTableAdapter.UpdateTablaTelefonoExtension((int)this.telefonoTableAdapter.ObtenerExtension(txtExtension.Text.Trim()), txtTelefono.Text.Trim());
            }
            //Update Combos
            try
            {
                this.telefonoTableAdapter.UpdateTablaTelefono(this.telefonoTableAdapter.ObtenerMarca(comboMarca.SelectedItem.ToString()),
                this.telefonoTableAdapter.ObtenerModelo(comboModelo.SelectedItem.ToString()),
                this.telefonoTableAdapter.ObtenerEstado(comboEstado.SelectedItem.ToString()),
                this.telefonoTableAdapter.ObtenerTipo(comboTipo.SelectedItem.ToString()), txtTelefono.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.telefonoTableAdapter.UpdateTablaTelefono(this.telefonoTableAdapter.ObtenerMarca(comboMarca.Text),
                this.telefonoTableAdapter.ObtenerModelo(comboModelo.Text),
                this.telefonoTableAdapter.ObtenerEstado(comboEstado.Text),
                this.telefonoTableAdapter.ObtenerTipo(comboTipo.Text), txtTelefono.Text.Trim());
            }
            if (FuncionesUtiles.INVENTARIO_EQUIPO == "" || FuncionesUtiles.INVENTARIO_EQUIPO == null) { return; }
            FuncionesUtiles.OBSERVACION += "Telefono: " + Microsoft.VisualBasic.Interaction.InputBox("OBSERVACION", "Ingrese Su Observacion", "", 600) + " ; ";
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
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
        }
        private void habilitarBotones()
        {
            
            txtTelefono.Enabled = true;
            comboTipo.Enabled = true;
            txtExtension.Enabled = true;
            comboEstado.Enabled = true;
            comboMarca.Enabled = true;
            comboModelo.Enabled = true;
            txtSerie.Enabled = true;
        }

        private void telefonoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            switch (FuncionesUtiles.ventanaDialogo())
            {

                case "Yes":

                    guardar();
                    Telefono_Load( sender,  e);
                    ApagarBotones();
                    gridTelefono.Enabled = true;
                    return;

                case "No":
                    Telefono_Load( sender,  e);
                    ApagarBotones();
                    gridTelefono.Enabled = true;
                    return;

                case "Cancel":
                    return;

                default:
                    return;
            }
           

        }

        private void ApagarBotones()
        {
            txtTelefono.Enabled = false;
            comboTipo.Enabled = false;
            txtExtension.Enabled = false;
            comboEstado.Enabled = false;
            comboMarca.Enabled = false;
            comboModelo.Enabled = false;
            txtSerie.Enabled = false;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            habilitarBotones();
            comboEstado.Items.AddRange(Datos._obtenerEstado());
            comboMarca.Items.AddRange(Datos._obtenerMarcaTelefono());
            comboModelo.Items.AddRange(Datos._obtenerModeloTelefono());
            comboTipo.Items.AddRange(Datos._obtenerTipoTelefono());

            this.InventarioAnterior = txtTelefono.Text.Trim();
            this.SerieAnterior = txtSerie.Text.Trim();
            this.ExtensionAnterior = txtExtension.Text.Trim();

            gridTelefono.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string NuevoInventario = Microsoft.VisualBasic.Interaction.InputBox("NUEVO TELEFONO", "Ingrese Numero de Inventario Telefono", "", 600);
            if (NuevoInventario == "") { return; }
            try
            {
                if (this.telefonoTableAdapter.ObtenerInventario(NuevoInventario).ToString().Length != 0) { MessageBox.Show("Inventario Existe"); return; }
            }
            catch (NullReferenceException)
            {
                this.telefonoTableAdapter.InsertInventarioTelefono(NuevoInventario);
                int var0 = (int)FuncionesEquipo.estado.ObtenerEstado("BUENO");
                int var1 = (int)this.telefonoTableAdapter.ObtenerMarca("N/A");
                int var2 = (int)this.telefonoTableAdapter.ObtenerModelo("N/A");
                int var3 = (int)this.telefonoTableAdapter.ObtenerSerie("N/A");
                int var4 = (int)this.telefonoTableAdapter.ObtenerTipo("N/A");
                int var5 = (int)this.telefonoTableAdapter.ObtenerInventarioTelefono(NuevoInventario);
                int var6 = (int)this.telefonoTableAdapter.ObtenerExtension("N/A");


                this.telefonoTableAdapter.InsertTelefono(var5, var6, var4, var1, var2, var3,var0);
                MessageBox.Show("Nuevo Inventario Creado!!");
                this.telefonoTableAdapter.Fill(this.sistemasFCNMDataSet.Telefono);
                this.telefonoTableAdapter.FillBy(this.sistemasFCNMDataSet.Telefono, (int)this.telefonoTableAdapter.ObtenerIdTelefono(NuevoInventario));

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string var = Microsoft.VisualBasic.Interaction.InputBox("NUEVO MARCA", "Ingrese Marca", "", 600);
            if ((int)this.telefonoTableAdapter.ObtenerMarca(var).ToString().Length != 0)
            {
                MessageBox.Show("Dato ya Existe!!"); return;
            }
            this.telefonoTableAdapter.InsertMarca(var);
            comboMarca.Items.Clear();
            comboMarca.Items.AddRange(Datos._obtenerMarcaTelefono());
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
            if ((int)this.telefonoTableAdapter.ObtenerModelo(var).ToString().Length != 0)
            {
                MessageBox.Show("Dato ya Existe!!"); return;
            }
            this.telefonoTableAdapter.InsertModelo(var);
            comboModelo.Items.Clear();
            comboModelo.Items.AddRange(Datos._obtenerModeloTelefono());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string var = Microsoft.VisualBasic.Interaction.InputBox("NUEVO TIPO", "Ingrese Tipo", "", 600);
            if ((int)this.telefonoTableAdapter.ObtenerTipo(var).ToString().Length != 0)
            {
                MessageBox.Show("Dato ya Existe!!"); return;
            }
            this.telefonoTableAdapter.InsertTipo(var);
            comboTipo.Items.Clear();
            comboTipo.Items.AddRange(Datos._obtenerTipoTelefono());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            String Text = Environment.UserName;
            Datos.writeCSV(gridTelefono, "C:\\Users\\"+Text+"\\Downloads\\TelefonoReporte.csv");
            MessageBox.Show("Descargado!!");
        }
    }
}
