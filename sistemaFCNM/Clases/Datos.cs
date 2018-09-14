using LibConexionBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistemaFCNM.Clases
{
    class Datos
    {
        private static string mensaje;
        private static ConexionBD conexion = new ConexionBD("Parametros.xml");

        public static string Mensaje { get { return mensaje; } }

        public static bool ValidarUsuario(string usuario, string clave)
        {

            if (!conexion.AbrirConexion()) //Garantizamos conexion Base Datos
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            MessageBox.Show("Conecta");
            conexion.SQL = "";

            if (!conexion.ConsultarValorUnico(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }

            if (conexion.ValorUnico == null)
            {
                mensaje = "";
                conexion.CerrarConexion();
                return false;
            }

            conexion.CerrarConexion();
            return true;
        }

        public static bool Insertar(string dato)
        {
            if (!conexion.AbrirConexion()) //Garantizamos conexion Base Datos
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }

            conexion.SQL = "select e.id_Equipo, p.Inventario_Pantalla,p.pulgadas,car.estado,car.marca,car.modelo,car.serie "+
                "from Equipo e, Pantalla p, Mouse m, Teclado t, CPU, "+
                "Caracteristicas car where e.Inventario_CPU = CPU.ID and e.Pantalla = p.ID "+
                "and e.Mouse = m.ID and e.Teclado = t.ID and car.id_caracteristica = p.caracteristicas  and p.Inventario_Pantalla like '"+dato+"%'; ";
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }

            mensaje = "Ingreso Correcto";
            conexion.CerrarConexion();
            return true;

        }
    }
}