﻿using sistemaFCNM.Clases;
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
        #region Variables Login
        private Usuario user;
        #endregion}

        #region Constructor
        public login()
        {
            InitializeComponent();
        }
        #endregion

        #region Accion Botones Login
        private void panelCabecera_Paint(object sender, PaintEventArgs e)
        {
          
            
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
                if(user.TipoUsuario == "AYUDANTE")
                {
                    MessageBox.Show("BIENVENIDO " + user.NombreUsuario);
                    this.Hide();
                    FuncionesUtiles.USUARIO = user.IdUsuario;
                    FuncionesUtiles.form1 = new Main();
                    FuncionesUtiles.form1.Show();
                   
                   
                }
                else if(user.TipoUsuario == "ADMINISTRADOR")
                {
                    MenuAdministrador admin = new MenuAdministrador();
                    FuncionesUtiles.NOMBRE_ADMIN = user.NombreUsuario;
                    FuncionesUtiles.USUARIO = user.IdUsuario;
                    this.Hide();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("USUARIO NO TIENE PERMISOS !!");
                }
                
                
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
        #endregion

        #region Botones cabecera
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

    }
}
