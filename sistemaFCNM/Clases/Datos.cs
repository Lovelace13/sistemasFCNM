using LibConexionBD;
using LibLlenarGrids;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistemaFCNM.Clases
{
    class Datos
    {
        
        #region Listas Datos Frecuentes
        private LinkedList<String> oficina = new LinkedList<string>();
        private LinkedList<String> edificio = new LinkedList<string>();
        private LinkedList<String> estado = new LinkedList<string>();
        private LinkedList<String> tipoPC = new LinkedList<string>();
        private LinkedList<String> perfil = new LinkedList<string>();
        private LinkedList<String> marcaCpu = new LinkedList<string>();
        private LinkedList<String> procesador = new LinkedList<string>();
        private LinkedList<String> memoria = new LinkedList<string>();
        private LinkedList<String> disco = new LinkedList<string>();
        private LinkedList<String> marcaPantalla = new LinkedList<string>();
        private LinkedList<String> modeloPantalla = new LinkedList<string>();
        private LinkedList<String> pulgadas = new LinkedList<string>();
        private LinkedList<String> marcaTeclado = new LinkedList<string>();
        private LinkedList<String> modeloTeclado = new LinkedList<string>();
        private LinkedList<String> marcaMouse = new LinkedList<string>();
        private LinkedList<String> modeloMouse = new LinkedList<string>();
        private LinkedList<String> marcaParlante = new LinkedList<string>();
        private LinkedList<String> modeloParlante = new LinkedList<string>();
        private LinkedList<String> marcaRegulador = new LinkedList<string>();
        private LinkedList<String> tipoRegulador = new LinkedList<string>();
        private LinkedList<String> marcaTelefono = new LinkedList<string>();
        private LinkedList<String> tipoTelefono = new LinkedList<string>();
        private LinkedList<String> marcaImpresora = new LinkedList<string>();
        #endregion

        #region Variables y metodos de la clase Datos

        private static ConexionBD conexion = new ConexionBD("Parametros.xml");
        private static string mensaje;
        public static string Mensaje { get { return mensaje; } }
        private string ruta;

        #endregion

        #region Funciones de Base Datos
        public static void Insertar(string cadena)
        {
            if (!conexion.AbrirConexion()) //Garantizamos conexion Base Datos
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return;
            }

            conexion.SQL = cadena;
            if (!conexion.EjecutarSentencia(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return;
            }

            mensaje = "Ingreso Correcto";
            conexion.CerrarConexion();
            return;

        }
        public static void llenarGrid(string sql, DataGridView gridInventario)
        {
            LlenarGrids llenarGrids = new LlenarGrids("Parametros.xml");
            gridInventario.DataSource = null;
            llenarGrids.SQL = sql;
            llenarGrids.LlenarGridWindows(gridInventario);
        }
        private static bool ExisteDato(string cadena, string tabla, string campo, string valor)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;

            }

            conexion.SQL = System.String.Format(cadena, tabla, campo, valor);
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
            conexion.CerrarConexion();
            return true;
        }
        private void validarEstados()
        {
            if (!estado.Contains("DAÑADO"))
            {
                estado.AddFirst("DAÑADO");
            }
            if (!estado.Contains("EN-MANTENIMIENTO"))
            {
                estado.AddFirst("EN-MANTENIMIENTO");
            }
            if (!estado.Contains("BUENO"))
            {
                estado.AddFirst("BUENO");
            }
            if (!estado.Contains("REGULAR"))
            {
                estado.AddFirst("REGULAR");
            }
        }
        private void agregarDatosFijos(string cadenaSql, string nombreTabla, string campo, LinkedList<string> lista)
        {
            foreach (string item in lista)
            {
                InsertarTablas(cadenaSql, nombreTabla, campo, item);

            }
        }
        private void InsertarTablas(string cadenaSql, string nombreTabla, string campo, string item)
        {
            if (!ExisteDato("SELECT ID FROM {0} WHERE {1} = '{2}';", nombreTabla, campo, item))
            {
                Datos.Insertar(System.String.Format(cadenaSql, nombreTabla, campo, item));
            }
        }
        private void InsertarTablas(string cadenaVerificacion, string cadenaSql, string nombreTabla, string campo, string item)
        {
            if (!ExisteDato(cadenaVerificacion, nombreTabla, campo, item))
            {
                Datos.Insertar(System.String.Format(cadenaSql, nombreTabla, campo, item));
            }
        }
        private void IngresoSql(int num, String[] campos, string nombreTabla, string campo)
        {
            InsertarTablas("INSERT INTO {0}({1}) VALUES ('{2}');", nombreTabla, campo, reemplazar(campos[num]));
        }
        private void IngresoSql(string cadenaVerificacion, string nombreTabla, string campo, string values)
        {
            InsertarTablas(cadenaVerificacion, "INSERT INTO {0}({1}) VALUES ({2});", nombreTabla, campo, values);
        }
        private void IngresoSql(string nombreTabla, string campo, string values)
        {
            InsertarTablas("INSERT INTO {0}({1}) VALUES ('{2}');", nombreTabla, campo, values);
        }
        #endregion

        #region Funciones de Texto Plano
        private string abrirDocumento()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos csv (*.csv)|*.csv";
            ofd.Title = "Abrir";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName);
            }
            ofd.Dispose();

            return ofd.FileName;
        }
        private void agregar(LinkedList<String> lista, int num, String[] campos)
        {
            if (campos[num].Length != 0 && !lista.Contains(reemplazar(campos[num])))
            {
                lista.AddFirst(reemplazar(campos[num]));
            }

        }
        public static String reemplazar(String dato)
        {
            if (dato == "NO APLICA " || dato == "no aplica" ||
            dato == "" || dato == "NOAPLICA" || dato == "NO APLICA" || dato == "NO")
            {
                return "N/A";
            }
            else
            {
                return dato.ToUpper();
            }

        }
        public void crearListaObjetos()
        {
            ruta = abrirDocumento();
            try
            {
                StreamReader objReader = new StreamReader(ruta);

                string linea = "";
                while (linea != null)
                {
                    linea = objReader.ReadLine();

                    String[] campos = linea.Split(';');
                    agregar(oficina, 3, campos);
                    agregar(edificio, 2, campos);
                    agregar(tipoPC, 8, campos);
                    agregar(estado, 9, campos);
                    agregar(marcaCpu, 10, campos);
                    agregar(procesador, 15, campos);
                    agregar(memoria, 16, campos);
                    agregar(disco, 17, campos);
                    agregar(perfil, 11, campos);
                    agregar(marcaPantalla, 20, campos);
                    agregar(modeloPantalla, 21, campos);
                    agregar(pulgadas, 24, campos);
                    agregar(marcaTeclado, 25, campos);
                    agregar(modeloTeclado, 25, campos);
                    agregar(marcaMouse, 29, campos);
                    agregar(modeloMouse, 30, campos);
                    agregar(marcaParlante, 33, campos);
                    agregar(modeloParlante, 34, campos);
                    agregar(marcaRegulador, 44, campos);
                    agregar(tipoRegulador, 43, campos);
                    agregar(tipoTelefono, 55, campos);
                    agregar(marcaTelefono, 56, campos);
                    agregar(marcaImpresora, 64, campos);
                    validarEstados();
                    tablasSistema(campos);

                    Console.WriteLine(campos[2]);



                }
                objReader.Close();
            }
            catch (Exception)
            {

            }
            subirSetListas();
            subirTablas();

        }
        private void subirSetListas()
        {
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "Edificio", "Bloque", edificio);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuTipo", "TipoPC", tipoPC);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuPerfil", "Perfil", perfil);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuDisco", "Disco", disco);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuProcesador", "Procesador", procesador);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuMemoria", "Memoria", memoria);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuMarca", "Marca", marcaCpu);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "PantallaMarca", "Marca", marcaPantalla);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "PantallaModelo", "Modelo", modeloPantalla);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "PantallaPulgadas", "Pulgadas", pulgadas);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "Estado", "Estado", estado);
        }
        private void subirTablas()
        {
            try
            {
                StreamReader objReader = new StreamReader(ruta);

                string linea = "";
                while (linea != null)
                {
                    linea = objReader.ReadLine();
                    String[] campos = linea.Split(';');
                    tablaCpu(campos);
                    tablaPantalla(campos);
                }
                objReader.Close();
            }

            catch (Exception)
            {


            }
        }
        #endregion

        #region Funciones para Guardar Tablas Sistema
        private void tablasSistema(String[] campos)
        {
            IngresoSql(6, campos, "CpuNombre", "NombrePC");
            IngresoSql(12, campos, "CpuSerie", "Serie");
            IngresoSql(13, campos, "CpuTag", "Tag");
            IngresoSql(14, campos, "CpuCode", "Code");
            IngresoSql(18, campos, "CpuAdicionalLote", "AdicionalLote");
            IngresoSql("CpuModelo", "Modelo", "N/A");

            IngresoSql(22, campos, "PantallaSerie", "Serie");
        }
        private void tablaCpu(String[] campos)
        {
            string pcNombre = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "CpuNombre", "NombrePC", reemplazar(campos[6]));
            string tipoPc = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "CpuTipo", "TipoPC", reemplazar(campos[8]));
            string perfil = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "CpuPerfil", "Perfil", reemplazar(campos[11]));
            string tag = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "CpuTag", "Tag", reemplazar(campos[13]));
            string code = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "CpuCode", "Code", reemplazar(campos[14]));
            string procesador = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "CpuProcesador", "Procesador", reemplazar(campos[15]));
            string memoria = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "CpuMemoria", "Memoria", reemplazar(campos[16]));
            string discoDuro = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "CpuDisco", "Disco", reemplazar(campos[17]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar(campos[9]));
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "CpuMarca", "Marca", reemplazar(campos[10]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "CpuSerie", "Serie", reemplazar(campos[12]));
            string adicional = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "CpuAdicionalLote", "AdicionalLote", reemplazar(campos[18]));

            string values = System.String.Format("({0}),'{1}',({2}),({3}),({4}),({5}),({6}),({7}),({8}),({9}),({10}),'{11}',({12}),({13})", pcNombre, reemplazar(campos[7]), tipoPc, perfil, tag, code, procesador, memoria, discoDuro, adicional, marca, "1", estado, serie);
            string campo = "NombrePC,Inventario,TipoPC,perfil,tag,code,procesador,memoria,disco,AdicionalLote,Marca,Modelo,Estado,Serie";
            string cadenaVeriificacion = System.String.Format("SELECT ID FROM {0} WHERE {1} = '{2}';", "Cpu", "Inventario", reemplazar(campos[7]));
            IngresoSql(cadenaVeriificacion, "Cpu", campo, values);
        }
        private void tablaPantalla(string[] campos)
        {
            string inventario = reemplazar(campos[23]);
            string pulgadas = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "PantallaPulgadas", "Pulgadas", reemplazar(campos[24]));
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "PantallaMarca", "Marca", reemplazar(campos[20]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "PantallaModelo", "Modelo", reemplazar(campos[21]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "PantallaSerie", "Serie", reemplazar(campos[22]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar(campos[19]));

            string values = System.String.Format("({0}),({1}),({2}),({3}),'{4}',({5})", estado, marca, modelo, serie, inventario, pulgadas);
            string campo = "Estado, Marca, Modelo, Serie, Inventario, Pulgadas";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = '{2}';", "Pantalla", "Inventario", reemplazar(campos[23]));
            IngresoSql(cadenaVerf, "Pantalla", campo, values);

        }
        #endregion
    }

}