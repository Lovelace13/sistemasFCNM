using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sistemaFCNM
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new mainPrincipal();
            Application.Run(form1);
        }

        public static mainPrincipal form1 ;
    }

}
