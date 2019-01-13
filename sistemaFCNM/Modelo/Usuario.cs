using LibConexionBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaFCNM.Clases
{
    class Usuario
    {
        private string idUsuario;
        private string nombreUsuario;
        private string tipoUsuario;

        public Usuario(string idUsuario)
        {
            this.IdUsuario = idUsuario;
            this.NombreUsuario = "";
            this.TipoUsuario = "";
        }

        public string IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        public string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }

            set
            {
                nombreUsuario = value;
            }
        }

        public string TipoUsuario
        {
            get
            {
                return tipoUsuario;
            }

            set
            {
                tipoUsuario = value;
            }
        }

        public bool ValidarUsuario(string usuario, string clave)
        {
            ConexionBD conexion = new ConexionBD("Parametros.xml");
            string mensaje;
            Object[] datos = new Object[2];
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;

            }

            conexion.SQL = System.String.Format("select Nombre from Usuario where Usuario = '{0}' and clave = '{1}';", usuario, clave);
            if (!conexion.ConsultarValorUnico(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
                
            }
            if (conexion.ValorUnico == null)
            {
                mensaje = "No Existe Datos";
                conexion.CerrarConexion();
                return false;
               
            }
            this.nombreUsuario = conexion.ValorUnico.ToString();

            conexion.SQL = System.String.Format("SELECT TipoUsuario.Tipo FROM   Usuario INNER JOIN TipoUsuario ON Usuario.Tipo = TipoUsuario.ID where Usuario = '{0}' and clave = '{1}';", usuario, clave);
            if (!conexion.ConsultarValorUnico(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;

            }
            if (conexion.ValorUnico == null)
            {
                mensaje = "No Existe Datos";
                conexion.CerrarConexion();
                return false;

            }
            this.tipoUsuario = conexion.ValorUnico.ToString(); 
            conexion.CerrarConexion();
            
            
            
            return true;
           
        }

        

    }
}
