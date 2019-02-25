using sistemaFCNM.Clases;
using sistemaFCNM.sistemasFCNMDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaFCNM.Vistas
{
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BIENVENIDO " + FuncionesUtiles.NOMBRE_ADMIN);
            this.Visible = false;
            FuncionesUtiles.form1 = new mainPrincipal();
            FuncionesUtiles.form1.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCargarDoc_Click(object sender, EventArgs e)
        {
            new Datos().crearListaObjetos();
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            new AllInventory().Show();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            new RegistrarUsuario().Show();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            string dellUser = Microsoft.VisualBasic.Interaction.InputBox("ELIMINAR USUARIO", "Ingrese Usuario Espol", "", 600);
            UsuarioTableAdapter user = new UsuarioTableAdapter();
            user.UpdateTipo(3,dellUser);
            MessageBox.Show("Permisos Eliminados");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dellUser = Microsoft.VisualBasic.Interaction.InputBox("Otorgar Permiso Usuario", "Ingrese Usuario Espol", "", 600);
            UsuarioTableAdapter user = new UsuarioTableAdapter();
            user.UpdateTipo(1, dellUser);
            MessageBox.Show("Permisos Otorgados");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dellUser = Microsoft.VisualBasic.Interaction.InputBox("Otorgar Permiso Usuario", "Ingrese Usuario Espol", "", 600);
            UsuarioTableAdapter user = new UsuarioTableAdapter();
            user.UpdateTipo(2, dellUser);
            MessageBox.Show("Permisos Administrador Otorgados");
        }
    }
}
