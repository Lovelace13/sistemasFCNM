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
        public static EquipoTableAdapter equipo = new EquipoTableAdapter();
        public static CpuTableAdapter cpu = new CpuTableAdapter();
        public static ImpresoraTableAdapter impresora = new ImpresoraTableAdapter();
        public static MouseTableAdapter mouse = new MouseTableAdapter();
        public static MicrofonoTableAdapter micro = new MicrofonoTableAdapter();
        public static PantallaProyeccionTableAdapter pp = new PantallaProyeccionTableAdapter();
        public static PantallaTableAdapter pantalla = new PantallaTableAdapter();
        public static ParlanteTableAdapter parlante = new ParlanteTableAdapter();
        public static ProyectorTableAdapter proyector = new ProyectorTableAdapter();
        public static RadioTableAdapter radio = new RadioTableAdapter();
        public static ReguladorTableAdapter regulador = new ReguladorTableAdapter();
        public static TecladoTableAdapter teclado = new TecladoTableAdapter();
        public static TelefonoTableAdapter telefono = new TelefonoTableAdapter();


        public static void buscarEquipo(string inventario)
        {
            equipo.GetDataByData(inventario);
        }
        public static void _actualizarInventarioImpresora(String InventarioEquipo, String Impresora)
        { 
            equipo.actualizarImpresora((int)impresora.ObtenerIdImpresora(Impresora), InventarioEquipo);
           
        }
        public static void _actualizarInventarioCPU(String InventarioEquipo, String CPU)
        {
            equipo.actualizarCpu((int)cpu.ObtenerIDCPU(CPU), InventarioEquipo);

        }
        public static void _actualizarInventarioMicro(String InventarioEquipo, String microfono)
        {
            equipo.actualizarMicrofono((int)micro.ObtenerIdMicro(microfono), InventarioEquipo);

        }
        public static void _actualizarInventarioMouse(String InventarioEquipo, String mous)
        {
            equipo.actualizarMouse((int)mouse.ObtenerIdMouse(mous), InventarioEquipo);

        }
        public static void _actualizarInventarioPantlla(String InventarioEquipo, String Pantalla)
        {
            equipo.actualizarPantalla((int)pantalla.ObtenerIdPantalla(Pantalla), InventarioEquipo);

        }
        public static void _actualizarInventarioPantallaProy(String InventarioEquipo, String PP)
        {
            equipo.actualizarPantallaProyeccion((int)pp.ObtenerIdPP(PP), InventarioEquipo);

        }
        public static void _actualizarInventarioRadio(String InventarioEquipo, String Radio)
        {
            equipo.actualizarRadio((int)radio.ObtenerIdRadio(Radio), InventarioEquipo);

        }
        public static void _actualizarInventarioProyector(String InventarioEquipo, String Proyector)
        {
            equipo.actualizarProyector((int)proyector.ObtenerIdProyector(Proyector), InventarioEquipo);

        }
        public static void _actualizarInventarioRegulador(String InventarioEquipo, String Regulador)
        {
            equipo.actualizarRegulador((int)regulador.ObtenerIdRegulador(Regulador), InventarioEquipo);

        }
        public static void _actualizarInventarioTelefono(String InventarioEquipo, String Telefono)
        {
            equipo.actualizarTelefono((int)telefono.ObtenerIdTelefono(Telefono), InventarioEquipo);

        }
        public static void _actualizarInventarioTeclado(String InventarioEquipo, String Teclado)
        {
            equipo.actualizarTeclado((int)teclado.ObtenerIdTeclado(Teclado), InventarioEquipo);

        }
        public static void _actualizarInventarioParlante(String InventarioEquipo, String Parlante)
        {
            equipo.actualizarParlante((int)parlante.ObtenerIdParlante(Parlante), InventarioEquipo);

        }
        public static void _actualizarInventarioEquipo(string NuevoInventario, string InventarioEquipo)
        {
            equipo.actualizarEquipo(NuevoInventario, InventarioEquipo);
        }
        public static void _actualizarOficina(String NombreOficina, String InventarioEquipo)
        {
            equipo.actualizarOficina(equipo.ObtenerIdOficina(NombreOficina), InventarioEquipo);
        }
    }
}
