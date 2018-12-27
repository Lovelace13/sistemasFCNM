using sistemaFCNM.sistemasFCNMDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaFCNM.Controlador
{
    class FuncionesEquipo
    {
        private static EquipoTableAdapter equipo = new EquipoTableAdapter();
        public static void buscarEquipo(string inventario)
        {
            equipo.GetDataBy(inventario);
        }
    }
}
