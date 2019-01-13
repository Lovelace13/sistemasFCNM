using sistemaFCNM.Clases;
using sistemaFCNM.Vistas;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace sistemaFCNM
{
    public partial class Equipos : Form
    {

        private Thread HiloServerQR;
        private ServidorSocket server;
        private LinkedList<String> listaqr = new LinkedList<string>();
        public Equipos()
        {
            InitializeComponent();
        }

        private void txtScanner_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                busqueda();
            }
        }


        private void limpiarTxtandWait()
        {
            try
            {
                Thread.Sleep(1200);
            }
            catch (Exception)
            {

                throw;
            }
            txtScanner.Clear();
        }
        private void btnDetalleCpu_Click(object sender, EventArgs e)
        {
            if (!FuncionesUtiles.masdetallesActiva)
            {
                FuncionesUtiles.masdetallesActiva = true;
            }

            FuncionesUtiles.abrirVentanas(new CPU(), mainPrincipal.contenedor);
        }

        private void btnDetalleTeclado_Click(object sender, EventArgs e)
        {
            if (!FuncionesUtiles.masdetallesActiva)
            {
                FuncionesUtiles.masdetallesActiva = true;
            }
            FuncionesUtiles.abrirVentanas(new Vistas.Teclado(), mainPrincipal.contenedor);
        }

        private void btnDetallePantalla_Click(object sender, EventArgs e)
        {
            if (!FuncionesUtiles.masdetallesActiva)
            {
                FuncionesUtiles.masdetallesActiva = true;
            }
            FuncionesUtiles.abrirVentanas(new Vistas.Pantalla(), mainPrincipal.contenedor);
        }

        private void btnDetalleMouse_Click(object sender, EventArgs e)
        {

            if (!FuncionesUtiles.masdetallesActiva)
            {
                FuncionesUtiles.masdetallesActiva = true;
            }
            FuncionesUtiles.abrirVentanas(new Vistas.Mouse(), mainPrincipal.contenedor);
        }

        private void btnDetalleMicro_Click(object sender, EventArgs e)
        {
            if (!FuncionesUtiles.masdetallesActiva)
            {
                FuncionesUtiles.masdetallesActiva = true;
            }
            FuncionesUtiles.abrirVentanas(new Vistas.Microfono(), mainPrincipal.contenedor);
        }

        private void btnDetallePproyeccion_Click(object sender, EventArgs e)
        {
            if (!FuncionesUtiles.masdetallesActiva)
            {
                FuncionesUtiles.masdetallesActiva = true;
            }
            FuncionesUtiles.abrirVentanas(new PProyeccion(), mainPrincipal.contenedor);
        }

        private void btnDetalleRegulador_Click(object sender, EventArgs e)
        {
            if (!FuncionesUtiles.masdetallesActiva)
            {
                FuncionesUtiles.masdetallesActiva = true;
            }
            FuncionesUtiles.abrirVentanas(new Vistas.Regulador(), mainPrincipal.contenedor);
        }

        private void btnDetalleProyector_Click(object sender, EventArgs e)
        {
            if (!FuncionesUtiles.masdetallesActiva)
            {
                FuncionesUtiles.masdetallesActiva = true;
            }
            FuncionesUtiles.abrirVentanas(new Vistas.Proyector(), mainPrincipal.contenedor);
        }

        private void btnDetalleImpresora_Click(object sender, EventArgs e)
        {
            if (!FuncionesUtiles.masdetallesActiva)
            {
                FuncionesUtiles.masdetallesActiva = true;
            }
            FuncionesUtiles.abrirVentanas(new Vistas.Impresora(), mainPrincipal.contenedor);
        }

        private void btnDetalleParlante_Click(object sender, EventArgs e)
        {
            if (!FuncionesUtiles.masdetallesActiva)
            {
                FuncionesUtiles.masdetallesActiva = true;
            }
            FuncionesUtiles.abrirVentanas(new Vistas.Parlante(), mainPrincipal.contenedor);
        }

        private void btnDetalleTelef_Click(object sender, EventArgs e)
        {
            if (!FuncionesUtiles.masdetallesActiva)
            {
                FuncionesUtiles.masdetallesActiva = true;
            }
            FuncionesUtiles.abrirVentanas(new Vistas.Telefono(), mainPrincipal.contenedor);
        }

        private void btnDetalleRadio_Click(object sender, EventArgs e)
        {
            if (!FuncionesUtiles.masdetallesActiva)
            {
                FuncionesUtiles.masdetallesActiva = true;
            }
            FuncionesUtiles.abrirVentanas(new Vistas.Radio(), mainPrincipal.contenedor);
        }

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.INVENTARIO_EQUIPO = Microsoft.VisualBasic.Interaction.InputBox("Inventario Equipo", "Registrar Busqueda", "", 600);

            string sql = "";
            Datos.llenarGrid(sql, gridInventario);



            sql = "";
            Datos.llenarGrid(sql, gridInventario);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            FuncionesUtiles.form1.Visible = false;
            FuncionesUtiles.siguienteActiva = true;

            FuncionesUtiles.desactivarMenu();

            FuncionesUtiles.abrirVentanas(new CPU(), mainPrincipal.contenedor);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FuncionesUtiles.siguienteActiva = false;
            FuncionesUtiles.activarMenu();
            FuncionesUtiles.INVENTARIO_EQUIPO = "";
        }



       
        private void Equipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);
            this.server = new ServidorSocket("192.168.1.8", 100);
            this.HiloServerQR = new Thread(new ThreadStart(server.StartListening));
            HiloServerQR.Start();
            timer1.Enabled = true; //Inicio Tiempo para leer codigo qr

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (server.Data == null)
            {
                return;
            }

            if (server.Data.Length != 0 && !listaqr.Contains(server.Data))
            {
                listView1.Items.Add(server.Data);
                listaqr.AddFirst(server.Data);
                

            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = listView1.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                txtScanner.Text=(listView1.Items[intselectedindex].Text);
                this.progressBar1.Maximum = 100;
                this.progressBar1.Step = 1;
                this.progressBar1.Value = 0;
                new Thread(new ThreadStart(() =>
                {
                   
                    for (int i = 0; i < 100; i++)
                    {
                        if (this.progressBar1.InvokeRequired)
                            this.progressBar1.Invoke(new ThreadStart(() =>
                            {
                                this.progressBar1.PerformStep();
                            }));
                        else
                            this.progressBar1.PerformStep();
                    }
                })).Start();
                busqueda();
                server.CerrarConexion();
                HiloServerQR.Interrupt();
                HiloServerQR.Join();
            }
        }
        private void busqueda()
        {
            equipoBindingSource.Position = equipoBindingSource.Find("Inventario", txtScanner.Text.Trim());
            try
            {
                this.equipoTableAdapter.FillBy(this.sistemasFCNMDataSet.Equipo, txtScanner.Text.Trim());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            FuncionesUtiles.INVENTARIO_EQUIPO = txtScanner.Text.Trim();
            FuncionesUtiles.ID_CPU = int.Parse(""+ this.equipoTableAdapter.getIdCpu(FuncionesUtiles.INVENTARIO_EQUIPO));
            FuncionesUtiles.ID_PANTALLA = int.Parse("" + this.equipoTableAdapter.getIdPantalla(FuncionesUtiles.INVENTARIO_EQUIPO));
            FuncionesUtiles.ID_MOUSE = int.Parse("" + this.equipoTableAdapter.getIdMouse(FuncionesUtiles.INVENTARIO_EQUIPO));
            FuncionesUtiles.ID_TECLADO = int.Parse("" + this.equipoTableAdapter.getIdTeclado(FuncionesUtiles.INVENTARIO_EQUIPO));
            FuncionesUtiles.ID_PARLANTE = int.Parse("" + this.equipoTableAdapter.getIdParlante(FuncionesUtiles.INVENTARIO_EQUIPO));
            FuncionesUtiles.ID_REGULADOR = int.Parse("" + this.equipoTableAdapter.getIdRegulador(FuncionesUtiles.INVENTARIO_EQUIPO));
            FuncionesUtiles.ID_IMPRESORA = int.Parse("" + this.equipoTableAdapter.getIdImpresora(FuncionesUtiles.INVENTARIO_EQUIPO));
            FuncionesUtiles.ID_PROYECTOR = int.Parse("" + this.equipoTableAdapter.getIdProyector(FuncionesUtiles.INVENTARIO_EQUIPO));
            FuncionesUtiles.ID_MICROFONO = int.Parse("" + this.equipoTableAdapter.getIdMicrofono(FuncionesUtiles.INVENTARIO_EQUIPO));
            FuncionesUtiles.ID_TELEFONO = int.Parse("" + this.equipoTableAdapter.getIdTelefono(FuncionesUtiles.INVENTARIO_EQUIPO));
            FuncionesUtiles.ID_PANTALLAPROY = int.Parse("" + this.equipoTableAdapter.getIdPantallaProyeccion(FuncionesUtiles.INVENTARIO_EQUIPO));
            FuncionesUtiles.ID_RADIO = int.Parse("" + this.equipoTableAdapter.getIdRadio(FuncionesUtiles.INVENTARIO_EQUIPO));
            limpiarTxtandWait();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void equipoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.equipoTableAdapter.actualizarEquipo(txtEquipo.Text.Trim(),FuncionesUtiles.INVENTARIO_EQUIPO);
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.txtCpu.Enabled = true;
            this.txtImpresora.Enabled = true;
            this.txtMicrofono.Enabled = true;
            this.txtMouse.Enabled = true;
            this.txtOficina.Enabled = true;
            this.txtPantalla.Enabled = true;
            this.txtParlante.Enabled = true;
            this.txtProyeccion.Enabled = true;
            this.txtProyector.Enabled = true;
            this.txtRadio.Enabled = true;
            this.txtRegulador.Enabled = true;
            this.txtTeclado.Enabled = true;
            this.txtTelefono.Enabled = true;
            this.txtResponsable.Enabled = true;

        }
    }
}
