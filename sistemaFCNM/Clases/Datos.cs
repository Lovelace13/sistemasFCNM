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

        public static bool Insertar()
        {
            if (!conexion.AbrirConexion()) //Garantizamos conexion Base Datos
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }

            conexion.SQL = "";
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