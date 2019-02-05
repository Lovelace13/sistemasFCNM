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
            equipo.GetDataByData(inventario);
        }
        public static void _actualizarInventarios(String InventarioEquipo, String Cpu, String Impresora, String Microfono, String Mouse
            , String Responsable,  String Pantalla, String Parlante, String Proyector, String Radio,  String Regulador, String Teclado,  String Telefono, String PantallaProy)
        {
            //equipo.actualizarEquipo(NuevoInventario, InventarioEquipo);
            equipo.actualizarCpu(Cpu, InventarioEquipo);
            equipo.actualizarImpresora(Impresora, InventarioEquipo);
            equipo.actualizarMicrofono(Microfono, InventarioEquipo);
            equipo.actualizarMouse(Mouse, InventarioEquipo);
            equipo.actualizarNombre(Responsable, InventarioEquipo);
            equipo.actualizarPantalla(Pantalla, InventarioEquipo);
            equipo.actualizarParlante(Parlante, InventarioEquipo);
            equipo.actualizarProyector(Proyector, InventarioEquipo);
            equipo.actualizarRadio(Radio, InventarioEquipo);
            equipo.actualizarRegulador(Regulador, InventarioEquipo);
            equipo.actualizarTeclado(Teclado, InventarioEquipo);
            equipo.actualizarTelefono(Telefono, InventarioEquipo);
            equipo.actualizarPantallaProyeccion(PantallaProy, InventarioEquipo);
        }
        public static void _actualizarInventarioEquipo(string NuevoInventario, string InventarioEquipo)
        {
            equipo.actualizarEquipo(NuevoInventario, InventarioEquipo);
        }
    }
}
