using sistemaFCNM.Clases;
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
    public partial class login : Form
    {
        private Usuario user;
        public login()
        {
            InitializeComponent();
        }

        private void panelCabecera_Paint(object sender, PaintEventArgs e)
        {
            MouseMovimiento mouseMove = new MouseMovimiento(this);
            this.panelCabecera.MouseMove += new System.Windows.Forms.MouseEventHandler(mouseMove.Form1_MouseMove);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            user = new Usuario(txtUsuario.Text);
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Ingrese Usuario", "Error");
                txtUsuario.Focus();
                return;
            }
            if (txtClave.Text == "")
            {
                MessageBox.Show("Ingrese Clave", "Error");
                txtClave.Focus();
                return;
            }

            
            if (user.ValidarUsuario(txtUsuario.Text, txtClave.Text))
            {
                MessageBox.Show("BIENVENIDO " + user.NombreUsuario);
                this.Visible = false;
                FuncionesUtiles.USUARIO = user.IdUsuario;
                FuncionesUtiles.form1 = new mainPrincipal();
                FuncionesUtiles.form1.Show();
                
            }

            else
            {
                MessageBox.Show(Datos.Mensaje);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

    }
}
