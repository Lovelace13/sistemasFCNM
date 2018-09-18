using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaFCNM.Clases
{
    class FuncionesUtiles
    {
        public static bool masdetallesActiva = false;
        public static bool siguienteActiva = false;
        public static bool anteriorActiva = false;
        public static string INVENTARIO_EQUIPO;
        public static bool nuevoRegistro = false;
        
        public static mainPrincipal form1;

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
    }
}
