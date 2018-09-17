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
        public static string INVENTARIO_EQUIPO;

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

    }
}
