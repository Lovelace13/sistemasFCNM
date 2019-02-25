using sistemaFCNM.sistemasFCNMDataSetTableAdapters;
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
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "") { MessageBox.Show("Ingrese Nombre"); return; }
            if (txtApellido.Text == "") { MessageBox.Show("Ingrese Apellido"); return; }
            if (txtUser.Text == "") { MessageBox.Show("Ingrese Usuario"); return; }
            if (txtPass.Text == "") { MessageBox.Show("Ingrese Contraseña"); return; }
            if (txtconfirmPass.Text == "") { MessageBox.Show("Ingrese Confimacion Contraseña"); return; }
            if (txtPass.Text != txtconfirmPass.Text) { MessageBox.Show("Contraseñas no iguales"); return; }
            if (radioAyudante.Checked && radioAdmin.Checked) { MessageBox.Show("Seleccione una opcion"); return; }
            UsuarioTableAdapter user = new UsuarioTableAdapter();
            if (user.ObtenerIDUsuario(txtUser.Text) != null) { if ((int)user.ObtenerIDUsuario(txtUser.Text) != 0) { MessageBox.Show("Usuario Existe"); return; } }

            if (radioAyudante.Checked)
                user.InsertUser(txtUser.Text, 1, txtNombre.Text.ToUpper() + txtApellido.Text.ToUpper(), txtPass.Text);
            if (radioAdmin.Checked)
                user.InsertUser(txtUser.Text, 2, txtNombre.Text.ToUpper() + " " +txtApellido.Text.ToUpper(), txtPass.Text);

            MessageBox.Show("Usuario Creado");
            this.Close();
        }
    }
}
