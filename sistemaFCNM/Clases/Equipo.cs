using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaFCNM.Clases
{
    class Equipo
    {
        public Equipo(string fecha, string grupo, string e, string oficina, string area, string nombreUsuario)
        {
            Fecha = fecha;
            Grupo = grupo;
            Edificio = e;
            Oficina = oficina;
            Area = area;
            NombreUsuario = nombreUsuario;
        }

        private string Fecha { get; set; }
        private string Grupo { get; set; }
        private string Edificio { get; set; }
        private string Oficina { get; set; }
        private string Area { get; set; }
        private string NombreUsuario { get; set; }

       

        
    }
}
