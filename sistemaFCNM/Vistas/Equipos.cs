using sistemaFCNM.Clases;
using sistemaFCNM.Controlador;
using sistemaFCNM.sistemasFCNMDataSetTableAdapters;
using sistemaFCNM.Vistas;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace sistemaFCNM
{
    public partial class Equipos : Form
    {
        #region Variables Inventario
        private Thread HiloServerQR;
        private ServidorSocket server;
        private LinkedList<String> listaqr = new LinkedList<string>();
        private String InventarioAnterior;
        private int IDAnterior;
        private String CpuAnterior;
        private string ImpresoraAnterior;
        private string MouseAnterior;
        private string MicroAnterior;
        private string PPAnterior;
        private string PantallaAnterior;
        private string ParlanteAnterior;
        private string ProyectorAnterior;
        private string RadioAnterior;
        private string ReguladorAnterior;
        private string TecladoAnterior;
        private string TelefonoAnterior;
        #endregion

        public Equipos()
        {
            InitializeComponent();
        }

        #region Funciones Equipo
        private void txtScanner_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                busqueda(txtScanner.Text.Trim());
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
            FuncionesUtiles.INVENTARIO_EQUIPO = "";
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);

            Datos.writeCSV(gridInventario, "C:\\Users\\JULIO\\Downloads\\equipos.csv"); 
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
                txtScanner.Text = (listView1.Items[intselectedindex].Text);
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
                busqueda(txtScanner.Text.Trim());
                server.CerrarConexion();
                HiloServerQR.Interrupt();
                HiloServerQR.Join();
            }
        }
        private void busqueda(string NumeroInventario)
        {
            this.equipoBindingSource.Position = this.equipoBindingSource.Find("Inventario", NumeroInventario);
            try
            {
                this.equipoTableAdapter.FillBy(this.sistemasFCNMDataSet.Equipo, NumeroInventario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            FuncionesUtiles.INVENTARIO_EQUIPO = NumeroInventario;
            FuncionesUtiles.ID_CPU = int.Parse("" + this.equipoTableAdapter.getIdCpu(FuncionesUtiles.INVENTARIO_EQUIPO));
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
            string NuevoInventario = Microsoft.VisualBasic.Interaction.InputBox("NUEVO EQUIPO", "Ingrese Numero de INventario Equipo", "", 600);
            try
            {
                
                if(this.equipoTableAdapter.ObtenerInventarioEquipo(NuevoInventario).ToString().Length != 0)
                {
                    MessageBox.Show("Numero Ingresado ya Exite");
                    return;
                }
                
            }
            catch (NullReferenceException)
            {

                this.equipoTableAdapter.InsertInventario(NuevoInventario);

                int var1 = (int)this.equipoTableAdapter.ObtenerInventarioEquipo(NuevoInventario);
                int var2 = (int)FuncionesEquipo.cpu.ObtenerIDCPU("N/A");
                int var3 = (int)this.equipoTableAdapter.getIdNombreOficina("N/A");
                int var4 = (int)FuncionesEquipo.micro.ObtenerIdMicro("N/A");
                int var5 = (int)FuncionesEquipo.telefono.ObtenerIdTelefono("N/A");
                int var6 = (int)FuncionesEquipo.pp.ObtenerIdPP("N/A");
                int var7 = (int)FuncionesEquipo.radio.ObtenerIdRadio("N/A");
                int var8 = (int)FuncionesEquipo.pantalla.ObtenerIdPantalla("N/A");
                int var9 = (int)FuncionesEquipo.teclado.ObtenerIdTeclado("N/A");
                int var10 = (int)FuncionesEquipo.mouse.ObtenerIdMouse("N/A");
                int var11 = (int)FuncionesEquipo.parlante.ObtenerIdParlante("N/A");
                int var12 = (int)FuncionesEquipo.regulador.ObtenerIdRegulador("N/A");
                int var13 = (int)FuncionesEquipo.impresora.ObtenerIdImpresora("N/A");
                int var14 = (int)FuncionesEquipo.proyector.ObtenerIdProyector("N/A");
                int var15 = (int)this.equipoTableAdapter.getIdPropietario("JOSE FLORES");


                this.equipoTableAdapter.InsertEquipo((int)this.equipoTableAdapter.ObtenerInventarioEquipo(NuevoInventario),
                    (int)FuncionesEquipo.cpu.ObtenerIDCPU("N/A"),(int)this.equipoTableAdapter.getIdNombreOficina("N/A"), (int)FuncionesEquipo.micro.ObtenerIdMicro("N/A"),
                    (int)FuncionesEquipo.telefono.ObtenerIdTelefono("N/A"), (int)FuncionesEquipo.pp.ObtenerIdPP("N/A"),
                    (int)FuncionesEquipo.radio.ObtenerIdRadio("N/A"), (int)FuncionesEquipo.pantalla.ObtenerIdPantalla("N/A"), (int)FuncionesEquipo.teclado.ObtenerIdTeclado("N/A"),
                    (int)FuncionesEquipo.mouse.ObtenerIdMouse("N/A"), (int)FuncionesEquipo.parlante.ObtenerIdParlante("N/A"), (int)FuncionesEquipo.regulador.ObtenerIdRegulador("N/A"),
                    (int)FuncionesEquipo.impresora.ObtenerIdImpresora("N/A"), (int)FuncionesEquipo.proyector.ObtenerIdProyector("N/A"),(int) this.equipoTableAdapter.getIdPropietario("JOSE FLORES"));

                FechaInventarioTableAdapter fecha = new FechaInventarioTableAdapter();
                int var16 = 0;
                try
                {
                    if(fecha.ObtenerFecha(DateTime.Now.ToString("yyyy-MM-dd")).ToString().Length != 0)
                    {
                        var16 = (int)fecha.ObtenerFecha(DateTime.Now.ToString("yyyy-MM-dd"));
                    }
                }
                catch (NullReferenceException)
                {

                    fecha.InsertFecha(DateTime.Now.ToString("yyyy-MM-dd"));
                    var16 = (int)fecha.ObtenerFecha(DateTime.Now.ToString("yyyy-MM-dd"));
                }
                
                UsuarioTableAdapter usuario = new UsuarioTableAdapter();
                int var17 =(int) usuario.ObtenerIDUsuario(FuncionesUtiles.USUARIO);

                int var18 = (int) this.equipoTableAdapter.getIdEquipo(NuevoInventario);

                InventarioTableAdapter inventario = new InventarioTableAdapter();
                inventario.InsertInventario(var16, var17, "", var18);

                this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);
                busqueda(NuevoInventario);
            }
            
        }
        private void equipoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            switch (FuncionesUtiles.ventanaDialogo())
            {
                case "Yes":
                    if (GuardadoValido()){guardado();}
                    return;
                case "No":
                    ApagarBotones();
                    this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);
                    return;
                case "Cancel":
                    return;
                default:
                    return;
            }

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarBotones();

            //LLenar Lista de Oficina
            comboOficina.Items.AddRange(Datos._obtenerCampoNombreOficina());

            //Deshabilitar tabla de inventarios
            gridInventario.Enabled = false;

            //Guardar valores anteriores
            this.CpuAnterior = txtCpu.Text.Trim();
            this.ImpresoraAnterior = txtImpresora.Text.Trim();
            this.MouseAnterior = txtMouse.Text.Trim();
            this.MicroAnterior = txtMicrofono.Text.Trim();
            this.PPAnterior = txtProyeccion.Text.Trim();
            this.PantallaAnterior = txtPantalla.Text.Trim();
            this.ParlanteAnterior = txtParlante.Text.Trim();
            this.ProyectorAnterior = txtProyector.Text.Trim();
            this.RadioAnterior = txtRadio.Text.Trim();
            this.ReguladorAnterior = txtRegulador.Text.Trim();
            this.TecladoAnterior = txtTeclado.Text.Trim();
            this.TelefonoAnterior = txtTelefono.Text.Trim();
        }
        private Boolean GuardadoValido()
        {


            try
            {
                if (FuncionesEquipo.cpu.obtenerInventario(txtCpu.Text.Trim()).Length != 0)
                {

                }

            }
            catch (NullReferenceException)
            {
                this.txtCpu.Focus();
                MessageBox.Show("No se encuentra en Inventario de CPU");
                return false;

            }
            try
            {
                if (FuncionesEquipo.impresora.ObtenerInventario(txtImpresora.Text.Trim()).Length != 0)
                {

                }
            }
            catch (NullReferenceException)
            {
                this.txtImpresora.Focus();
                MessageBox.Show("No se encuentra en Inventario de IMPRESORA");
                return false;
            }
            try
            {
                if (FuncionesEquipo.micro.ObtenerInventario(txtMicrofono.Text.Trim()).ToString().Length != 0)
                {

                }
            }
            catch (NullReferenceException)
            {
                this.txtMicrofono.Focus();
                MessageBox.Show("No se encuentra en Inventario de MICROFONO");
                return false;
            }
            try
            {
                if (FuncionesEquipo.mouse.ObtenerInventario(txtMouse.Text.Trim()).Length != 0)
                {

                }
            }
            catch (NullReferenceException)
            {
                this.txtMouse.Focus();
                MessageBox.Show("No se encuentra en Inventario de MOUSE");
                return false;
            }
            try
            {
                if (FuncionesEquipo.pantalla.ObtenerInventario(txtPantalla.Text.Trim()).Length != 0)
                {

                }
            }
            catch (NullReferenceException)
            {
                this.txtPantalla.Focus();
                MessageBox.Show("No se encuentra en Inventario de PANTALLA");
                return false;
            }

            try
            {
                if (FuncionesEquipo.parlante.ObtenerInventario(txtParlante.Text.Trim()).Length != 0)
                {

                }
            }
            catch (NullReferenceException)
            {
                this.txtParlante.Focus();
                MessageBox.Show("No se encuentra en Inventario de PARLANTE");
                return false;
            }
            try
            {
                if (FuncionesEquipo.pp.ObtenerInventario(txtProyeccion.Text.Trim()).Length != 0)
                {

                }
            }
            catch (NullReferenceException)
            {
                this.txtProyeccion.Focus();
                MessageBox.Show("No se encuentra en Inventario de PANTALLA DE PROYECCION");
                return false;
            }
            try
            {
                if (FuncionesEquipo.proyector.ObtenerInventario(txtProyector.Text.Trim()).Length != 0)
                {

                }
            }
            catch (NullReferenceException)
            {
                this.txtProyector.Focus();
                MessageBox.Show("No se encuentra en Inventario de PROYECTOR");
                return false;
            }
            try
            {
                if (FuncionesEquipo.radio.ObtenerInventario(txtRadio.Text.Trim()).Length != 0)
                {

                }
            }
            catch (NullReferenceException)
            {
                this.txtRadio.Focus();
                MessageBox.Show("No se encuentra en Inventario de RADIO");
                return false;
            }
            try
            {
                if (FuncionesEquipo.regulador.ObtenerInventario(txtRegulador.Text.Trim()).Length != 0)
                {

                }
            }
            catch (NullReferenceException)
            {
                this.txtRegulador.Focus();
                MessageBox.Show("No se encuentra en Inventario de REGULADOR");
                return false;
            }
            try
            {
                if (FuncionesEquipo.teclado.ObtenerInventario(txtTeclado.Text.Trim()).Length != 0)
                {

                }
            }
            catch (NullReferenceException)
            {
                this.txtTeclado.Focus();
                MessageBox.Show("No se encuentra en Inventario de TECLADO");
                return false;
            }
            try
            {
                if (FuncionesEquipo.telefono.ObtenerInventario(txtTelefono.Text.Trim()).Length != 0)
                {

                }
            }
            catch (NullReferenceException)
            {
                this.txtTelefono.Focus();
                MessageBox.Show("No se encuentra en Inventario de TELEFONO");
                return false;
            }
            return true;
        }
        private void HabilitarBotones()
        {
            //Habilitar Cajas de texto
            this.txtCpu.Enabled = true;
            this.txtImpresora.Enabled = true;
            this.txtMicrofono.Enabled = true;
            this.txtMouse.Enabled = true;
            this.comboOficina.Enabled = true;
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
        private void ApagarBotones()
        {
            //Apagar Cajas de texto
            this.txtCpu.Enabled = false;
            this.txtImpresora.Enabled = false;
            this.txtMicrofono.Enabled = false;
            this.txtMouse.Enabled = false;
            this.comboOficina.Enabled = false;
            this.txtPantalla.Enabled = false;
            this.txtParlante.Enabled = false;
            this.txtProyeccion.Enabled = false;
            this.txtProyector.Enabled = false;
            this.txtRadio.Enabled = false;
            this.txtRegulador.Enabled = false;
            this.txtTeclado.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtResponsable.Enabled = false;
            this.txtEquipo.Enabled = false;
        }
        private void btnModifEquipo_Click(object sender, EventArgs e)
        {
            this.txtEquipo.Enabled = true;
            gridInventario.Enabled = false;
            this.InventarioAnterior = txtEquipo.Text.Trim();
            this.IDAnterior = (int)this.equipoTableAdapter.ObtenerIDEquipo(txtEquipo.Text.Trim());
        }
        private void guardado()
        {
            //GUARDADO CPU
            if (txtCpu.Text.Trim() != "N/A")
            {
                try
                {
                    FuncionesEquipo._actualizarInventarioCPU(FuncionesEquipo.equipo.BuscarIDCpu_Inventario(txtCpu.Text.Trim()).ToString()
                    , this.CpuAnterior);


                    FuncionesEquipo._actualizarInventarioCPU(txtEquipo.Text.Trim(), txtCpu.Text.Trim());
                }
                catch (NullReferenceException)
                {
                    FuncionesEquipo._actualizarInventarioCPU(txtEquipo.Text.Trim(), txtCpu.Text.Trim());

                }
            }
            else if (txtCpu.Text.Trim() == "N/A")
            {
                FuncionesEquipo._actualizarInventarioCPU(txtEquipo.Text.Trim(), txtCpu.Text.Trim());
            }

            //GUARDADO IMPRESORA
            if (txtImpresora.Text.Trim() != "N/A")
            {
                try
                {
                    FuncionesEquipo._actualizarInventarioImpresora(FuncionesEquipo.equipo.BuscarIDImpresora_Inventario(txtImpresora.Text.Trim()).ToString()
                    , this.ImpresoraAnterior);


                    FuncionesEquipo._actualizarInventarioImpresora(txtEquipo.Text.Trim(), txtImpresora.Text.Trim());
                }
                catch (NullReferenceException)
                {
                    FuncionesEquipo._actualizarInventarioImpresora(txtEquipo.Text.Trim(), txtImpresora.Text.Trim());

                }
            }
            else if (txtImpresora.Text.Trim() == "N/A")
            {
                FuncionesEquipo._actualizarInventarioImpresora(txtEquipo.Text.Trim(), txtImpresora.Text.Trim());
            }
            //GUARDADO MICROFONO
            if (txtMicrofono.Text.Trim() != "N/A")
            {
                try
                {
                    FuncionesEquipo._actualizarInventarioMicro(FuncionesEquipo.equipo.BuscarIDMicro_Inventario(txtMicrofono.Text.Trim()).ToString()
                    , this.MicroAnterior);


                    FuncionesEquipo._actualizarInventarioMicro(txtEquipo.Text.Trim(), txtMicrofono.Text.Trim());
                }
                catch (NullReferenceException)
                {
                    FuncionesEquipo._actualizarInventarioMicro(txtEquipo.Text.Trim(), txtMicrofono.Text.Trim());

                }
            }
            else if (txtMicrofono.Text.Trim() == "N/A")
            {
                FuncionesEquipo._actualizarInventarioMicro(txtEquipo.Text.Trim(), txtMicrofono.Text.Trim());
            }

            //GUARDADO MOUSE
            if (txtMouse.Text.Trim() != "N/A")
            {
                try
                {
                    FuncionesEquipo._actualizarInventarioMouse(FuncionesEquipo.equipo.BuscarIDMouse_Inventario(txtMouse.Text.Trim()).ToString()
                    , this.MouseAnterior);


                    FuncionesEquipo._actualizarInventarioMouse(txtEquipo.Text.Trim(), txtMouse.Text.Trim());
                }
                catch (NullReferenceException)
                {
                    FuncionesEquipo._actualizarInventarioMouse(txtEquipo.Text.Trim(), txtMouse.Text.Trim());

                }
            }
            else if (txtMouse.Text.Trim() == "N/A")
            {
                FuncionesEquipo._actualizarInventarioMouse(txtEquipo.Text.Trim(), txtMouse.Text.Trim());
            }
            //GUARDADO PANTALLA
            if (txtPantalla.Text.Trim() != "N/A")
            {
                try
                {
                    FuncionesEquipo._actualizarInventarioPantlla(FuncionesEquipo.equipo.BuscarIDPantalla_Inventario(txtPantalla.Text.Trim()).ToString()
                    , this.PantallaAnterior);


                    FuncionesEquipo._actualizarInventarioPantlla(txtEquipo.Text.Trim(), txtPantalla.Text.Trim());
                }
                catch (NullReferenceException)
                {
                    FuncionesEquipo._actualizarInventarioPantlla(txtEquipo.Text.Trim(), txtPantalla.Text.Trim());

                }
            }
            else if (txtPantalla.Text.Trim() == "N/A")
            {
                FuncionesEquipo._actualizarInventarioPantlla(txtEquipo.Text.Trim(), txtPantalla.Text.Trim());
            }
            //GUARDADO PANTALLA PROYECCION
            if (txtProyeccion.Text.Trim() != "N/A")
            {
                try
                {
                    FuncionesEquipo._actualizarInventarioPantallaProy(FuncionesEquipo.equipo.BuscarIDPP_Inventario(txtProyeccion.Text.Trim()).ToString()
                    , this.PPAnterior);


                    FuncionesEquipo._actualizarInventarioPantallaProy(txtEquipo.Text.Trim(), txtProyeccion.Text.Trim());
                }
                catch (NullReferenceException)
                {
                    FuncionesEquipo._actualizarInventarioPantallaProy(txtEquipo.Text.Trim(), txtProyeccion.Text.Trim());

                }
            }
            else if (txtProyeccion.Text.Trim() == "N/A")
            {
                FuncionesEquipo._actualizarInventarioPantallaProy(txtEquipo.Text.Trim(), txtProyeccion.Text.Trim());
            }
            //GUARDADO RADIOS
            if (txtRadio.Text.Trim() != "N/A")
            {
                try
                {
                    FuncionesEquipo._actualizarInventarioRadio(FuncionesEquipo.equipo.BuscarIDRadio_Inventario(txtRadio.Text.Trim()).ToString()
                    , this.RadioAnterior);


                    FuncionesEquipo._actualizarInventarioRadio(txtEquipo.Text.Trim(), txtRadio.Text.Trim());
                }
                catch (NullReferenceException)
                {
                    FuncionesEquipo._actualizarInventarioRadio(txtEquipo.Text.Trim(), txtRadio.Text.Trim());

                }
            }
            else if (txtRadio.Text.Trim() == "N/A")
            {
                FuncionesEquipo._actualizarInventarioRadio(txtEquipo.Text.Trim(), txtRadio.Text.Trim());
            }
            //GUARDADO PROYECTOR
            if (txtProyector.Text.Trim() != "N/A")
            {
                try
                {
                    FuncionesEquipo._actualizarInventarioProyector(FuncionesEquipo.equipo.BuscarIDProyector_Inventario(txtProyector.Text.Trim()).ToString()
                    , this.ProyectorAnterior);


                    FuncionesEquipo._actualizarInventarioProyector(txtEquipo.Text.Trim(), txtProyector.Text.Trim());
                }
                catch (NullReferenceException)
                {
                    FuncionesEquipo._actualizarInventarioProyector(txtEquipo.Text.Trim(), txtProyector.Text.Trim());

                }
            }
            else if (txtProyector.Text.Trim() == "N/A")
            {
                FuncionesEquipo._actualizarInventarioProyector(txtEquipo.Text.Trim(), txtProyector.Text.Trim());
            }
            //GUARDADO REGULADOR 
            if (txtRegulador.Text.Trim() != "N/A")
            {
                try
                {
                    FuncionesEquipo._actualizarInventarioRegulador(FuncionesEquipo.equipo.BuscarIDRegulador_Inventario(txtRegulador.Text.Trim()).ToString()
                    , this.ReguladorAnterior);


                    FuncionesEquipo._actualizarInventarioRegulador(txtEquipo.Text.Trim(), txtRegulador.Text.Trim());
                }
                catch (NullReferenceException)
                {
                    FuncionesEquipo._actualizarInventarioRegulador(txtEquipo.Text.Trim(), txtRegulador.Text.Trim());
                }
            }
            else if (txtRegulador.Text.Trim() == "N/A")
            {
                FuncionesEquipo._actualizarInventarioRegulador(txtEquipo.Text.Trim(), txtRegulador.Text.Trim());
            }
            //GUARDADO TELEFONO
            if (txtTelefono.Text.Trim() != "N/A")
            {
                try
                {
                    FuncionesEquipo._actualizarInventarioTelefono(FuncionesEquipo.equipo.BuscarIDTelefono_Inventario(txtTelefono.Text.Trim()).ToString()
                    , this.TelefonoAnterior);


                    FuncionesEquipo._actualizarInventarioTelefono(txtEquipo.Text.Trim(), txtTelefono.Text.Trim());
                }
                catch (NullReferenceException)
                {
                    FuncionesEquipo._actualizarInventarioTelefono(txtEquipo.Text.Trim(), txtTelefono.Text.Trim());
                }
            }
            else if (txtTelefono.Text.Trim() == "N/A")
            {
                FuncionesEquipo._actualizarInventarioTelefono(txtEquipo.Text.Trim(), txtTelefono.Text.Trim());
            }
            //GUARDADO TECLADO
            if (txtTeclado.Text.Trim() != "N/A")
            {
                try
                {
                    FuncionesEquipo._actualizarInventarioTeclado(FuncionesEquipo.equipo.BuscarIDTeclado_Inventario(txtTeclado.Text.Trim()).ToString()
                    , this.TecladoAnterior);


                    FuncionesEquipo._actualizarInventarioTeclado(txtEquipo.Text.Trim(), txtTeclado.Text.Trim());
                }
                catch (NullReferenceException)
                {
                    FuncionesEquipo._actualizarInventarioTeclado(txtEquipo.Text.Trim(), txtTeclado.Text.Trim());
                }
            }
            else if (txtTeclado.Text.Trim() == "N/A")
            {
                FuncionesEquipo._actualizarInventarioTeclado(txtEquipo.Text.Trim(), txtTeclado.Text.Trim());
            }
            //GUARDADO PARLANTE
            if (txtParlante.Text.Trim() != "N/A")
            {
                try
                {
                    FuncionesEquipo._actualizarInventarioParlante(FuncionesEquipo.equipo.BuscarIDParlante_Inventario(txtParlante.Text.Trim()).ToString()
                    , this.ParlanteAnterior);


                    FuncionesEquipo._actualizarInventarioParlante(txtEquipo.Text.Trim(), txtParlante.Text.Trim());
                }
                catch (NullReferenceException)
                {
                    FuncionesEquipo._actualizarInventarioParlante(txtEquipo.Text.Trim(), txtParlante.Text.Trim());
                }
            }
            else if (txtParlante.Text.Trim() == "N/A")
            {
                FuncionesEquipo._actualizarInventarioParlante(txtEquipo.Text.Trim(), txtParlante.Text.Trim());
            }
            //GUARDADO OFICINA
            try
            {
                FuncionesEquipo._actualizarOficina(comboOficina.SelectedItem.ToString(), txtEquipo.Text.Trim());
            }
            catch (NullReferenceException)
            {

                FuncionesEquipo._actualizarOficina(comboOficina.Text, txtEquipo.Text.Trim());
            }
            
            
            ApagarBotones();
            gridInventario.Enabled = true;
            this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);
        }
        private void btnEncender_Click(object sender, EventArgs e)
        {
            this.server = new ServidorSocket(txtIp.Text.Trim(), 100);
            this.HiloServerQR = new Thread(new ThreadStart(server.StartListening));
            HiloServerQR.Start();
            timer1.Enabled = true; //Inicio Tiempo para leer codigo qr
        }
        #endregion

        #region botones habilitar busqueda
        private void button1_Click(object sender, EventArgs e)
        {
            this.txtCpu.Enabled = true;
            this.txtCpu.Text = "";
            MessageBox.Show("Ingrese Numero de Inventario");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.txtPantalla.Enabled = true;
            this.txtPantalla.Text = "";
            MessageBox.Show("Ingrese Numero de Inventario");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.txtTeclado.Enabled = true;
            this.txtTeclado.Text = "";
            MessageBox.Show("Ingrese Numero de Inventario");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.txtMouse.Enabled = true;
            this.txtMouse.Text = "";
            MessageBox.Show("Ingrese Numero de Inventario");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.txtMicrofono.Enabled = true;
            this.txtMicrofono.Text = "";
            MessageBox.Show("Ingrese Numero de Inventario");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.txtProyeccion.Enabled = true;
            this.txtProyeccion.Text = "";
            MessageBox.Show("Ingrese Numero de Inventario");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            this.txtRegulador.Enabled = true;
            this.txtRegulador.Text = "";
            MessageBox.Show("Ingrese Numero de Inventario");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.txtProyector.Enabled = true;
            this.txtProyector.Text = "";
            MessageBox.Show("Ingrese Numero de Inventario");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.txtImpresora.Enabled = true;
            this.txtImpresora.Text = "";
            MessageBox.Show("Ingrese Numero de Inventario");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.txtParlante.Enabled = true;
            this.txtParlante.Text = "";
            MessageBox.Show("Ingrese Numero de Inventario");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.txtTelefono.Enabled = true;
            this.txtTelefono.Text = "";
            MessageBox.Show("Ingrese Numero de Inventario");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.txtRadio.Enabled = true;
            this.txtRadio.Text = "";
            MessageBox.Show("Ingrese Numero de Inventario");
        }
        #endregion

        #region funciones busqueda Individual
        private void btnBusquedaCpu_Click(object sender, EventArgs e)
        {
            try
            {
                string inventario = this.equipoTableAdapter.ObtenerInventarioEquipoCpu(txtCpu.Text.Trim());
                if (inventario.Length != 0)
                {
                    FuncionesUtiles.INVENTARIO_EQUIPO = inventario;
                    busqueda(FuncionesUtiles.INVENTARIO_EQUIPO);
                }


            }
            catch (NullReferenceException)
            {
                this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);
                MessageBox.Show("Inventario No Extiste!!!");

            }
            this.txtCpu.Enabled = false;
        }
        private void btnBusquedaPantalla_Click(object sender, EventArgs e)
        {
            try
            {
                string inventario = this.equipoTableAdapter.ObtenerInventarioEquipoPantalla(txtPantalla.Text.Trim());
                if (inventario.Length != 0)
                {
                    FuncionesUtiles.INVENTARIO_EQUIPO = inventario;
                    busqueda(FuncionesUtiles.INVENTARIO_EQUIPO);
                }


            }
            catch (NullReferenceException)
            {
                this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);
                MessageBox.Show("Inventario No Extiste!!!");

            }
            this.txtPantalla.Enabled = false;
        }    
        private void btnBusquedaTeclado_Click(object sender, EventArgs e)
        {
            try
            {
                string inventario = this.equipoTableAdapter.ObtenerInventarioEquipoTeclado(txtTeclado.Text.Trim());
                if (inventario.Length != 0)
                {
                    FuncionesUtiles.INVENTARIO_EQUIPO = inventario;
                    busqueda(FuncionesUtiles.INVENTARIO_EQUIPO);
                }


            }
            catch (NullReferenceException)
            {
                this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);
                MessageBox.Show("Inventario No Extiste!!!");

            }
            this.txtTeclado.Enabled = false;
        }
        private void btnBusquedaMouse_Click(object sender, EventArgs e)
        {
            try
            {
                string inventario = this.equipoTableAdapter.ObtenerInventarioEquipoMouse(txtMouse.Text.Trim());
                if (inventario.Length != 0)
                {
                    FuncionesUtiles.INVENTARIO_EQUIPO = inventario;
                    busqueda(FuncionesUtiles.INVENTARIO_EQUIPO);
                }


            }
            catch (NullReferenceException)
            {
                this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);
                MessageBox.Show("Inventario No Extiste!!!");

            }
            this.txtMouse.Enabled = false;
        }
        private void btnBusquedaMicro_Click(object sender, EventArgs e)
        {
            try
            {
                string inventario = this.equipoTableAdapter.ObtenerInventarioEquipoMicro(txtMicrofono.Text.Trim());
                if (inventario.Length != 0)
                {
                    FuncionesUtiles.INVENTARIO_EQUIPO = inventario;
                    busqueda(FuncionesUtiles.INVENTARIO_EQUIPO);
                }


            }
            catch (NullReferenceException)
            {
                this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);
                MessageBox.Show("Inventario No Extiste!!!");

            }
            this.txtMicrofono.Enabled = false;
        }
        private void btnBusquedaPP_Click(object sender, EventArgs e)
        {
            try
            {
                string inventario = this.equipoTableAdapter.ObtenerInventarioEquipoPP(txtProyeccion.Text.Trim());
                if (inventario.Length != 0)
                {
                    FuncionesUtiles.INVENTARIO_EQUIPO = inventario;
                    busqueda(FuncionesUtiles.INVENTARIO_EQUIPO);
                }


            }
            catch (NullReferenceException)
            {
                this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);
                MessageBox.Show("Inventario No Extiste!!!");

            }
            this.txtProyeccion.Enabled = false;
        }
        private void btnBusquedaRegulador_Click(object sender, EventArgs e)
        {
            try
            {
                string inventario = this.equipoTableAdapter.ObtenerInventarioEquipoRegulador(txtRegulador.Text.Trim());
                if (inventario.Length != 0)
                {
                    FuncionesUtiles.INVENTARIO_EQUIPO = inventario;
                    busqueda(FuncionesUtiles.INVENTARIO_EQUIPO);
                }


            }
            catch (NullReferenceException)
            {
                this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);
                MessageBox.Show("Inventario No Extiste!!!");

            }
            this.txtRegulador.Enabled = false;
        }
        private void btnBusquedaProy_Click(object sender, EventArgs e)
        {
            try
            {
                string inventario = this.equipoTableAdapter.ObtenerInventarioEquipoProyector(txtProyector.Text.Trim());
                if (inventario.Length != 0)
                {
                    FuncionesUtiles.INVENTARIO_EQUIPO = inventario;
                    busqueda(FuncionesUtiles.INVENTARIO_EQUIPO);
                }


            }
            catch (NullReferenceException)
            {
                this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);
                MessageBox.Show("Inventario No Extiste!!!");

            }
            this.txtProyector.Enabled = false;
        }
        private void btnBusquedaImpr_Click(object sender, EventArgs e)
        {
            try
            {
                string inventario = this.equipoTableAdapter.ObtenerInventarioEquipoImpresora(txtImpresora.Text.Trim());
                if (inventario.Length != 0)
                {
                    FuncionesUtiles.INVENTARIO_EQUIPO = inventario;
                    busqueda(FuncionesUtiles.INVENTARIO_EQUIPO);
                }


            }
            catch (NullReferenceException)
            {
                this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);
                MessageBox.Show("Inventario No Extiste!!!");

            }
            this.txtImpresora.Enabled = false;
        }
        private void btnBusquedaPar_Click(object sender, EventArgs e)
        {
            try
            {
                string inventario = this.equipoTableAdapter.ObtenerInventarioEquipoParlante(txtParlante.Text.Trim());
                if (inventario.Length != 0)
                {
                    FuncionesUtiles.INVENTARIO_EQUIPO = inventario;
                    busqueda(FuncionesUtiles.INVENTARIO_EQUIPO);
                }


            }
            catch (NullReferenceException)
            {
                this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);
                MessageBox.Show("Inventario No Extiste!!!");

            }
            this.txtParlante.Enabled = false;
        }
        private void btnBusquedaTelef_Click(object sender, EventArgs e)
        {
            try
            {
                string inventario = this.equipoTableAdapter.ObtenerInventarioEquipoTelefono(txtTelefono.Text.Trim());
                if (inventario.Length != 0)
                {
                    FuncionesUtiles.INVENTARIO_EQUIPO = inventario;
                    busqueda(FuncionesUtiles.INVENTARIO_EQUIPO);
                }


            }
            catch (NullReferenceException)
            {
                this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);
                MessageBox.Show("Inventario No Extiste!!!");

            }
            this.txtTelefono.Enabled = false;
        }
        private void btnBusquedaRadio_Click(object sender, EventArgs e)
        {
            try
            {
                string inventario = this.equipoTableAdapter.ObtenerInventarioEquipoRadio(txtRadio.Text.Trim());
                if (inventario.Length != 0)
                {
                    FuncionesUtiles.INVENTARIO_EQUIPO = inventario;
                    busqueda(FuncionesUtiles.INVENTARIO_EQUIPO);
                }


            }
            catch (NullReferenceException)
            {
                this.equipoTableAdapter.Fill(this.sistemasFCNMDataSet.Equipo);
                MessageBox.Show("Inventario No Extiste!!!");

            }
            this.txtRadio.Enabled = false;
        }

        #endregion

       
    }

}
