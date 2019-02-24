using sistemaFCNM.Clases;
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
            MessageBox.Show("BIENVENIDO " + FuncionesUtiles.USUARIO);
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
    }
}
