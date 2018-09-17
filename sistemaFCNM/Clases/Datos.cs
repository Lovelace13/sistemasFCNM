using LibConexionBD;
using LibLlenarGrids;
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

        public static void Insertar(string cadena)
        {
            if (!conexion.AbrirConexion()) //Garantizamos conexion Base Datos
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return ;
            }

            conexion.SQL = cadena ;
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return;
            }

            mensaje = "Ingreso Correcto";
            conexion.CerrarConexion();
            return ;

        }

        public static void llenarGrid(string sql, DataGridView gridInventario)
        {
            LlenarGrids llenarGrids = new LlenarGrids("Parametros.xml");
            gridInventario.DataSource = null;
            llenarGrids.SQL = sql;
            llenarGrids.LlenarGridWindows(gridInventario);
        }
    }
}