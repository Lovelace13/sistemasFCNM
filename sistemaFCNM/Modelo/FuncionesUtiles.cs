using sistemaFCNM.Vistas;
using System;
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
        public static Main form1;
        public static String NOMBRE_ADMIN = "";
        #endregion

        #region Funciones Estaticas para navegar entre ventanas
        public static void abrirVentanas(Form ventana)
        {
            ventana.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            ventana.ControlBox = true;
            ventana.WindowState = FormWindowState.Normal;
            ventana.StartPosition = FormStartPosition.CenterScreen;
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
            Main.btn13.Enabled = false;
            Main.btn1.Enabled = false;
            Main.btn2.Enabled = false;
            Main.btn3.Enabled = false;
            Main.btn4.Enabled = false;
            Main.btn5.Enabled = false;
            Main.btn6.Enabled = false;
            Main.btn7.Enabled = false;
            Main.btn8.Enabled = false;
            Main.btn9.Enabled = false;
            Main.btn10.Enabled = false;
            Main.btn11.Enabled = false;
            Main.btn12.Enabled = false;
        }
        public static void activarMenu()
        {
            Main.btn13.Enabled = true;
            Main.btn1.Enabled = true;
            Main.btn2.Enabled = true;
            Main.btn3.Enabled = true;
            Main.btn4.Enabled = true;
            Main.btn5.Enabled = true;
            Main.btn6.Enabled = true;
            Main.btn7.Enabled = true;
            Main.btn8.Enabled = true;
            Main.btn9.Enabled = true;
            Main.btn10.Enabled = true;
            Main.btn11.Enabled = true;
            Main.btn12.Enabled = true;
        }
        #endregion

    }
}
