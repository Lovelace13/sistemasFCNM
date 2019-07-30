﻿using System;
using System.Windows.Forms;

namespace sistemaFCNM.Clases
{
    class FuncionesUtiles
    {
        #region Variables estaticas sistema
        public static bool masdetallesActiva = false;
        public static bool siguienteActiva = false;
        public static bool anteriorActiva = false;
        public static string INVENTARIO_EQUIPO;
        public static Int32 ID_CPU;
        public static Int32 ID_PANTALLA;
        public static Int32 ID_MOUSE;
        public static Int32 ID_TECLADO;
        public static Int32 ID_PARLANTE;
        public static Int32 ID_REGULADOR;
        public static Int32 ID_IMPRESORA;
        public static Int32 ID_PROYECTOR;
        public static Int32 ID_MICROFONO;
        public static Int32 ID_TELEFONO;
        public static Int32 ID_PANTALLAPROY;
        public static Int32 ID_RADIO;
        public static string USUARIO;
        public static string OBSERVACION;
        public static bool nuevoRegistro = false;
        public static mainPrincipal form1;
        public static String NOMBRE_ADMIN = "";
        #endregion

        #region Funciones Estaticas para navegar entre ventanas
        public static void abrirVentanas(Form ventana, FlowLayoutPanel panelContenedor)
        {
            if (panelContenedor.Controls.Count > 0)
            {
                panelContenedor.Controls.RemoveAt(0);

            }
            ventana.TopLevel = false;
            ventana.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(ventana);
            panelContenedor.Tag = ventana;
            ventana.Show();
        }
        public static string ventanaDialogo()
        {
            // Configure the message box to be displayed
            string messageBoxText = "Guardar Cambios?";
            string caption = "Guardar";
            MessageBoxButtons button = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon icon = MessageBoxIcon.Warning;


            String result = MessageBox.Show(messageBoxText, caption, button, icon).ToString();


            // Process message box results
            return result;

        }
        public static void desactivarMenu()
        {
            mainPrincipal.btn13.Enabled = false;
            mainPrincipal.btn1.Enabled = false;
            mainPrincipal.btn2.Enabled = false;
            mainPrincipal.btn3.Enabled = false;
            mainPrincipal.btn4.Enabled = false;
            mainPrincipal.btn5.Enabled = false;
            mainPrincipal.btn6.Enabled = false;
            mainPrincipal.btn7.Enabled = false;
            mainPrincipal.btn8.Enabled = false;
            mainPrincipal.btn9.Enabled = false;
            mainPrincipal.btn10.Enabled = false;
            mainPrincipal.btn11.Enabled = false;
            mainPrincipal.btn12.Enabled = false;
        }
        public static void activarMenu()
        {
            mainPrincipal.btn13.Enabled = true;
            mainPrincipal.btn1.Enabled = true;
            mainPrincipal.btn2.Enabled = true;
            mainPrincipal.btn3.Enabled = true;
            mainPrincipal.btn4.Enabled = true;
            mainPrincipal.btn5.Enabled = true;
            mainPrincipal.btn6.Enabled = true;
            mainPrincipal.btn7.Enabled = true;
            mainPrincipal.btn8.Enabled = true;
            mainPrincipal.btn9.Enabled = true;
            mainPrincipal.btn10.Enabled = true;
            mainPrincipal.btn11.Enabled = true;
            mainPrincipal.btn12.Enabled = true;
        }
        #endregion

    }
}
