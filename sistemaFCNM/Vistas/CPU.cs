using sistemaFCNM.Clases;
using sistemaFCNM.Controlador;
using sistemaFCNM.sistemasFCNMDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaFCNM.Vistas
{
    public partial class CPU : Form
    {
        private string InventarioAnterior;
        private string LoteAnterior;
        private string CodeAnterior;
        private string NombreAnterior;
        private string SerieAnterior;
        private string TagAnterior;

        public CPU()
        {
            InitializeComponent();
            
        }
        void myButton_Click(Object sender, System.EventArgs e)
        {
            MessageBox.Show("Click");
        }
        private void CPU_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemasFCNMDataSet.Cpu' Puede moverla o quitarla según sea necesario.
            this.cpuTableAdapter.Fill(this.sistemasFCNMDataSet.Cpu);
           
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
                this.cpuTableAdapter.FillBy(this.sistemasFCNMDataSet.Cpu,FuncionesUtiles.ID_CPU);
            }

           

        }

     
        private void btnNext_Click(object sender, EventArgs e)
        {
            
            FuncionesUtiles.abrirVentanas(new Pantalla(), mainPrincipal.contenedor);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            guardar();
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            switch (FuncionesUtiles.ventanaDialogo())
            {
                case "Yes":

                    guardar();
                    this.Close();
                    FuncionesUtiles.siguienteActiva = false;
                    FuncionesUtiles.activarMenu();
                    FuncionesUtiles.INVENTARIO_EQUIPO = "";
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
                if (this.cpuTableAdapter.ObtenerIDCPU(txtCpu.Text.Trim()).ToString().Length != 0 && this.InventarioAnterior != txtCpu.Text.Trim())
                {
                    MessageBox.Show("Inventario Repetido ");
                }
            }
            catch (NullReferenceException)
            {
                this.cpuTableAdapter.UpdateInventario(txtCpu.Text.Trim(), this.InventarioAnterior);


            }
            //Update Adicional Lote
            try
            {
                if (txtLote.Text.Trim() != "N/A")
                {
                    if (this.cpuTableAdapter.ObtenerAdicionalLote(txtLote.Text.Trim()).ToString().Length != 0 && this.LoteAnterior != "N/A")
                    {
                        this.cpuTableAdapter.UpdateAdicionalLote(txtLote.Text.Trim(), txtCpu.Text.Trim());
                    }
                    else
                    {

                        this.cpuTableAdapter.UpdateTablaCpuLote((int)this.cpuTableAdapter.ObtenerAdicionalLote(txtLote.Text.Trim()), txtCpu.Text.Trim());
                    }

                }
                else
                {

                    this.cpuTableAdapter.UpdateTablaCpuLote((int)this.cpuTableAdapter.ObtenerAdicionalLote(txtLote.Text.Trim()), txtCpu.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.cpuTableAdapter.InsertAdicionalote(txtLote.Text.Trim());
                this.cpuTableAdapter.UpdateTablaCpuLote((int)this.cpuTableAdapter.ObtenerAdicionalLote(txtLote.Text.Trim()), txtCpu.Text.Trim());
            }
            //Update CODE
            try
            {
                if (txtCode.Text.Trim() != "N/A")
                {
                    if (this.cpuTableAdapter.ObtenerCode(txtCode.Text.Trim()).ToString().Length != 0 && this.CodeAnterior != "N/A")
                    {
                        this.cpuTableAdapter.UpdateCode(txtCode.Text.Trim(), txtCpu.Text.Trim());
                    }
                    else
                    {

                        this.cpuTableAdapter.UpdateTablaCpuCode((int)this.cpuTableAdapter.ObtenerCode(txtCode.Text.Trim()), txtCpu.Text.Trim());
                    }
                }
                else
                {

                    this.cpuTableAdapter.UpdateTablaCpuCode((int)this.cpuTableAdapter.ObtenerCode(txtCode.Text.Trim()), txtCpu.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.cpuTableAdapter.InsertCode(txtCode.Text.Trim());
                this.cpuTableAdapter.UpdateTablaCpuCode((int)this.cpuTableAdapter.ObtenerCode(txtCode.Text.Trim()), txtCpu.Text.Trim());
            }
            //Update Nombre
            try
            {
                if (txtNombre.Text.Trim() != "N/A")
                {
                    if (this.cpuTableAdapter.ObtenerNombrePc(txtNombre.Text.Trim()).ToString().Length != 0 && this.NombreAnterior != "N/A")
                    {
                        this.cpuTableAdapter.UpdateNombrePc(txtNombre.Text.Trim(), txtCpu.Text.Trim());
                    }
                    else
                    {

                        this.cpuTableAdapter.UpdateTablaCpuNombre((int)this.cpuTableAdapter.ObtenerNombrePc(txtNombre.Text.Trim()), txtCpu.Text.Trim());
                    }
                }
                else
                {

                    this.cpuTableAdapter.UpdateTablaCpuNombre((int)this.cpuTableAdapter.ObtenerNombrePc(txtNombre.Text.Trim()), txtCpu.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.cpuTableAdapter.InsertNombre(txtNombre.Text.Trim());
                this.cpuTableAdapter.UpdateTablaCpuNombre((int)this.cpuTableAdapter.ObtenerNombrePc(txtNombre.Text.Trim()), txtCpu.Text.Trim());
            }

            //Update Serie
            try
            {
                if (txtSerie.Text.Trim() != "N/A")
                {
                    if (this.cpuTableAdapter.ObtenerSerie(txtSerie.Text.Trim()).ToString().Length != 0 && this.SerieAnterior != "N/A")
                    {
                        this.cpuTableAdapter.UpdateSerie(txtSerie.Text.Trim(), txtCpu.Text.Trim());
                    }
                    else
                    {
                        this.cpuTableAdapter.UpdateTablaCpuSerie((int)this.cpuTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtCpu.Text.Trim());
                    }
                }
                else
                {

                    this.cpuTableAdapter.UpdateTablaCpuSerie((int)this.cpuTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtCpu.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.cpuTableAdapter.InsertSerie(txtSerie.Text.Trim());
                this.cpuTableAdapter.UpdateTablaCpuSerie((int)this.cpuTableAdapter.ObtenerSerie(txtSerie.Text.Trim()), txtCpu.Text.Trim());
            }

            //Update Tag
            try
            {
                if (txtTag.Text.Trim() != "N/A")
                {
                    if (this.cpuTableAdapter.ObtenerTag(txtTag.Text.Trim()).ToString().Length != 0 && this.TagAnterior != "N/A")
                    {
                        this.cpuTableAdapter.UpdateTag(txtTag.Text.Trim(), txtCpu.Text.Trim());
                    }
                    else
                    {
                        this.cpuTableAdapter.UpdateTablaCpuTag((int)this.cpuTableAdapter.ObtenerTag(txtTag.Text.Trim()), txtCpu.Text.Trim());
                    }
                }
                else
                {

                    this.cpuTableAdapter.UpdateTablaCpuTag((int)this.cpuTableAdapter.ObtenerTag(txtTag.Text.Trim()), txtCpu.Text.Trim());
                }
            }
            catch (NullReferenceException)
            {

                this.cpuTableAdapter.InsertTag(txtTag.Text.Trim());
                this.cpuTableAdapter.UpdateTablaCpuTag((int)this.cpuTableAdapter.ObtenerTag(txtTag.Text.Trim()), txtCpu.Text.Trim());
            }
            //Guardado TipoPC
            try
            {
                this.cpuTableAdapter.UpdateTablaCpuTipo(this.cpuTableAdapter.ObtenerTipo(comboTipo.SelectedItem.ToString()), txtCpu.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.cpuTableAdapter.UpdateTablaCpuTipo(this.cpuTableAdapter.ObtenerTipo(comboTipo.Text), txtCpu.Text.Trim());
            }

            //Guardado Perfil
            try
            {
                this.cpuTableAdapter.UpdateTablaCpuPerfil(this.cpuTableAdapter.ObtenerPerfil(comboPerfil.SelectedItem.ToString()), txtCpu.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.cpuTableAdapter.UpdateTablaCpuPerfil(this.cpuTableAdapter.ObtenerPerfil(comboPerfil.Text), txtCpu.Text.Trim());
            }
            //Guardado Estado
            try
            {
                this.cpuTableAdapter.UpdateTablaCpuEstado(FuncionesEquipo.estado.ObtenerEstado(comboEstado.SelectedItem.ToString()), txtCpu.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.cpuTableAdapter.UpdateTablaCpuEstado(FuncionesEquipo.estado.ObtenerEstado(comboEstado.Text), txtCpu.Text.Trim());
            }
            //Guardado Procesador
            try
            {
                this.cpuTableAdapter.UpdateTablaCpuProcesador(this.cpuTableAdapter.ObtenerProcesador(comboProcesador.SelectedItem.ToString()), txtCpu.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.cpuTableAdapter.UpdateTablaCpuProcesador(this.cpuTableAdapter.ObtenerProcesador(comboProcesador.Text), txtCpu.Text.Trim());
            }
            //Guardado Memoria
            try
            {
                this.cpuTableAdapter.UpdateTablaCpuMemoria(this.cpuTableAdapter.ObtenerMemoria(comboMemoria.SelectedItem.ToString()), txtCpu.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.cpuTableAdapter.UpdateTablaCpuMemoria(this.cpuTableAdapter.ObtenerMemoria(comboMemoria.Text), txtCpu.Text.Trim());
            }
            //Guardado Disco
            try
            {
                this.cpuTableAdapter.UpdateTablaCpuDisco(this.cpuTableAdapter.ObtenerDisco(comboDisco.SelectedItem.ToString()), txtCpu.Text.Trim());
            }
            catch (NullReferenceException)
            {

                this.cpuTableAdapter.UpdateTablaCpuDisco(this.cpuTableAdapter.ObtenerDisco(comboDisco.Text), txtCpu.Text.Trim());
            }

            FechaInventarioTableAdapter fecha = new FechaInventarioTableAdapter();
            int var16 = 0;
            try
            {
                if (fecha.ObtenerFecha(DateTime.Now.ToString("yyyy-MM-dd")).ToString().Length != 0)
                {
                    var16 = (int)fecha.ObtenerFecha(DateTime.Now.ToString("yyyy-MM-dd"));
                }
                else
                {
                    fecha.InsertFecha(DateTime.Now.ToString("yyyy-MM-dd"));
                    var16 = (int)fecha.ObtenerFecha(DateTime.Now.ToString("yyyy-MM-dd"));
                }
            }
            catch (NullReferenceException)
            {

                fecha.InsertFecha(DateTime.Now.ToString("yyyy-MM-dd"));
                var16 = (int)fecha.ObtenerFecha(DateTime.Now.ToString("yyyy-MM-dd"));
            }
            if(FuncionesUtiles.INVENTARIO_EQUIPO == "" || FuncionesUtiles.INVENTARIO_EQUIPO == null) { return; }

            UsuarioTableAdapter usuario = new UsuarioTableAdapter();
            int var17 = (int)usuario.ObtenerIDUsuario(FuncionesUtiles.USUARIO);

            EquipoTableAdapter equipo = new EquipoTableAdapter();
            int var18 = (int) equipo.getIdEquipo(FuncionesUtiles.INVENTARIO_EQUIPO);

            InventarioTableAdapter inventario = new InventarioTableAdapter();
            inventario.InsertInventario(var16, var17, "", var18);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           

        }

       
        private void habilitarBotones()
        {
            
            txtCpu.Enabled = true;
            txtNombre.Enabled = true;
            comboTipo.Enabled = true;
            txtTag.Enabled = true;
            txtCode.Enabled = true;
            comboPerfil.Enabled = true;
            comboProcesador.Enabled = true;
            comboMemoria.Enabled = true;
            comboDisco.Enabled = true;
            comboEstado.Enabled = true;
            comboMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtSerie.Enabled = true;
            txtLote.Enabled = true;
        }
        private void ApagarBotones()
        {

            txtCpu.Enabled = false;
            txtNombre.Enabled = false;
            comboTipo.Enabled = false;
            txtTag.Enabled = false;
            txtCode.Enabled = false;
            comboPerfil.Enabled = false;
            comboProcesador.Enabled = false;
            comboMemoria.Enabled = false;
            comboDisco.Enabled = false;
            comboEstado.Enabled = false;
            comboMarca.Enabled = false;
            txtModelo.Enabled = false;
            txtSerie.Enabled = false;
            txtLote.Enabled = false;
        }

        private void cpuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            switch (FuncionesUtiles.ventanaDialogo())
            {

                case "Yes":

                    guardar();
                    this.gridCpu.Enabled = true;
                    this.ApagarBotones();
                    this.cpuTableAdapter.Fill(this.sistemasFCNMDataSet.Cpu);
                    return;

                case "No":
                    this.cpuTableAdapter.Fill(this.sistemasFCNMDataSet.Cpu);
                    return;

                case "Cancel":
                    return;

                default:
                    return;
            }

           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gridCpu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string NuevoInventario = Microsoft.VisualBasic.Interaction.InputBox("NUEVO CPU", "Ingrese Numero de Inventario Cpu", "", 600);
            if(NuevoInventario == "") { return; }
            try
            {
                if (this.cpuTableAdapter.obtenerInventario(NuevoInventario).ToString().Length != 0) { MessageBox.Show("Inventario Existe"); return; }
            }
            catch (NullReferenceException)
            {
                this.cpuTableAdapter.InsertInventario(NuevoInventario);
                int var0 = (int)FuncionesEquipo.estado.ObtenerEstado("BUENO");
                int var1 = (int)this.cpuTableAdapter.ObtenerAdicionalLote("N/A");
                int var2 = (int)this.cpuTableAdapter.ObtenerCode("N/A");
                int var3 = (int)this.cpuTableAdapter.ObtenerDisco("N/A");
                int var4 = (int)this.cpuTableAdapter.ObtenerMarca("N/A");
                int var5 = (int)this.cpuTableAdapter.ObtenerMemoria("N/A");
                int var6 = (int)this.cpuTableAdapter.ObtenerNombrePc("N/A");
                int var7 = (int)this.cpuTableAdapter.ObtenerPerfil("N/A");
                int var8 = (int)this.cpuTableAdapter.ObtenerProcesador("N/A");
                int var9 = (int)this.cpuTableAdapter.ObtenerSerie("N/A");
                int var10 = (int)this.cpuTableAdapter.ObtenerTag("N/A");
                int var11 = (int)this.cpuTableAdapter.ObtenerTipo("N/A");
                int var12 = (int)this.cpuTableAdapter.ObtenerIDCpuInventario(NuevoInventario);

                this.cpuTableAdapter.InsertCpu(var12,var6,var11,var7,var10,var2,var8,var5,var3,var1,var4,var9,var0);
                MessageBox.Show("Nuevo Inventario Creado!!");
                this.cpuTableAdapter.Fill(this.sistemasFCNMDataSet.Cpu);
                this.cpuTableAdapter.FillBy(this.sistemasFCNMDataSet.Cpu, (int)this.cpuTableAdapter.ObtenerIDCPU(NuevoInventario));

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.habilitarBotones();
            this.InventarioAnterior = txtCpu.Text.Trim();
            this.LoteAnterior = txtLote.Text.Trim();
            this.CodeAnterior = txtCode.Text.Trim();
            this.NombreAnterior = txtNombre.Text.Trim();
            this.SerieAnterior = txtSerie.Text.Trim();
            this.TagAnterior = txtTag.Text.Trim();

            this.gridCpu.Enabled = false;

            comboTipo.Items.AddRange(Datos._obtenerTipoPC());
            comboPerfil.Items.AddRange(Datos._obtenerPerfil());
            comboMarca.Items.AddRange(Datos._obtenerMarca());
            comboEstado.Items.AddRange(Datos._obtenerEstado());
            comboProcesador.Items.AddRange(Datos._obtenerProcesador());
            comboDisco.Items.AddRange(Datos._obtenerDisco());
            comboMemoria.Items.AddRange(Datos._obtenerMemoria());
        }
    }
}
