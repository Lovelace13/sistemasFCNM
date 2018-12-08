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
        //Ubicacion 
        private LinkedList<String> oficina = new LinkedList<string>();
        private LinkedList<String> edificio = new LinkedList<string>();

        //Estados 
        private LinkedList<String> estado = new LinkedList<string>();

        //Campos Cpu
        private LinkedList<String> InventarioCpu = new LinkedList<string>();
        private LinkedList<String> pcNombre = new LinkedList<string>();
        private LinkedList<String> serieCpu = new LinkedList<string>();
        private LinkedList<String> tag = new LinkedList<string>();
        private LinkedList<String> code = new LinkedList<string>();
        private LinkedList<String> tipoPC = new LinkedList<string>();
        private LinkedList<String> perfil = new LinkedList<string>();
        private LinkedList<String> marcaCpu = new LinkedList<string>();
        private LinkedList<String> modeloCpu = new LinkedList<string>();
        private LinkedList<String> adicionalLote = new LinkedList<string>();
        private LinkedList<String> procesador = new LinkedList<string>();
        private LinkedList<String> memoria = new LinkedList<string>();
        private LinkedList<String> disco = new LinkedList<string>();

        //Campos Pantalla 
        private LinkedList<String> InventarioPantalla = new LinkedList<string>();
        private LinkedList<String> marcaPantalla = new LinkedList<string>();
        private LinkedList<String> modeloPantalla = new LinkedList<string>();
        private LinkedList<String> pulgadas = new LinkedList<string>();
        private LinkedList<String> seriePantalla = new LinkedList<string>();

        //Campos Teclado
        private LinkedList<String> InventarioTeclado = new LinkedList<string>();
        private LinkedList<String> marcaTeclado = new LinkedList<string>();
        private LinkedList<String> modeloTeclado = new LinkedList<string>();
        private LinkedList<String> serieTeclado = new LinkedList<string>();

        //Campos Mouse 
        private LinkedList<String> InventarioMouse = new LinkedList<string>();
        private LinkedList<String> marcaMouse = new LinkedList<string>();
        private LinkedList<String> modeloMouse = new LinkedList<string>();
        private LinkedList<String> serieMouse = new LinkedList<string>();

        //Campos Parlate
        private LinkedList<String> InventarioParlante = new LinkedList<string>();
        private LinkedList<String> marcaParlante = new LinkedList<string>();
        private LinkedList<String> modeloParlante = new LinkedList<string>();
        private LinkedList<String> serieParlante = new LinkedList<string>();

        //Campos Regulador
        private LinkedList<String> InventarioRegulador = new LinkedList<string>();
        private LinkedList<String> marcaRegulador = new LinkedList<string>();
        private LinkedList<String> modeloRegulador = new LinkedList<string>();
        private LinkedList<String> tipoRegulador = new LinkedList<string>();
        private LinkedList<String> serieRegulador = new LinkedList<string>();

        //Campos Proyector 
        private LinkedList<String> InventarioProyectorEspol = new LinkedList<string>();
        private LinkedList<String> InventarioProyectorEspolTech = new LinkedList<string>();
        private LinkedList<String> modeloProyector = new LinkedList<string>();
        private LinkedList<String> marcaProyector = new LinkedList<string>();
        private LinkedList<String> serieProyector = new LinkedList<string>();

        //Campos Telefono
        private LinkedList<String> InventarioTelefono = new LinkedList<string>();
        private LinkedList<String> marcaTelefono = new LinkedList<string>();
        private LinkedList<String> modeloTelefono = new LinkedList<string>();
        private LinkedList<String> extensionTelefono = new LinkedList<string>();
        private LinkedList<String> tipoTelefono = new LinkedList<string>();
        private LinkedList<String> serieTelefono = new LinkedList<string>();

        //Campos Impresora
        private LinkedList<String> InventarioImpresora = new LinkedList<string>();
        private LinkedList<String> marcaImpresora = new LinkedList<string>();
        private LinkedList<String> modeloImpresora = new LinkedList<string>();
        private LinkedList<String> serieImpresora = new LinkedList<string>();

        //Campos Microfono
        private LinkedList<String> InventarioMicrofonos = new LinkedList<string>();
        private LinkedList<String> marcaMicrofonos = new LinkedList<string>();
        private LinkedList<String> modeloMicrofonos = new LinkedList<string>();
        private LinkedList<String> serieMicrofono = new LinkedList<string>();

        //Campos Pantalla Proyeccion
        private LinkedList<String> InventarioPP = new LinkedList<string>();
        private LinkedList<String> marcaPP = new LinkedList<string>();
        private LinkedList<String> modeloPP = new LinkedList<string>();
        private LinkedList<String> seriePP = new LinkedList<string>();

        //Campos Radios
        private LinkedList<String> InventarioRadio = new LinkedList<string>();
        private LinkedList<String> marcaRadio = new LinkedList<string>();
        private LinkedList<String> modeloRadio = new LinkedList<string>();
        private LinkedList<String> serieRadio = new LinkedList<string>();
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
            if (!estado.Contains("MANTENIMIENTO"))
            {
                estado.AddFirst("MANTENIMIENTO");
            }
            if (!estado.Contains("BUENO"))
            {
                estado.AddFirst("BUENO");
            }
            if (!estado.Contains("REGULAR"))
            {
                estado.AddFirst("REGULAR");
            }
            if (!estado.Contains("REVISION"))
            {
                estado.AddFirst("REVISION");
            }
            if (!estado.Contains("GARANTIA"))
            {
                estado.AddFirst("GARANTIA");
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
            dato == "" || dato == "NOAPLICA" || dato == "NO APLICA" || dato == "NO" || dato == "NO TIENE")
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
                    agregar(InventarioCpu, 7, campos);
                    agregar(pcNombre, 6, campos);
                    agregar(serieCpu, 12, campos);
                    agregar(tag, 13, campos);
                    agregar(code, 14, campos);
                    agregar(adicionalLote, 18, campos);

                    agregar(marcaPantalla, 20, campos);
                    agregar(modeloPantalla, 21, campos);
                    agregar(pulgadas, 24, campos);
                    agregar(InventarioPantalla, 23, campos);
                    agregar(seriePantalla, 22, campos);

                    agregar(marcaTeclado, 25, campos);
                    agregar(modeloTeclado, 26, campos);
                    agregar(InventarioTeclado, 28, campos);
                    agregar(serieTeclado, 27, campos);

                    agregar(marcaMouse, 29, campos);
                    agregar(modeloMouse, 30, campos);
                    agregar(InventarioMouse, 32, campos);
                    agregar(serieMouse, 31, campos);

                    agregar(marcaParlante, 33, campos);
                    agregar(modeloParlante, 34, campos);
                    agregar(InventarioParlante, 36, campos);
                    agregar(serieParlante, 35, campos);

                    agregar(marcaProyector, 38, campos);
                    agregar(modeloProyector, 39, campos);
                    agregar(InventarioProyectorEspol, 42, campos);
                    agregar(InventarioProyectorEspolTech, 41, campos);
                    agregar(seriePantalla, 40, campos);

                    agregar(marcaRegulador, 44, campos);
                    agregar(modeloRegulador, 45, campos);
                    agregar(tipoRegulador, 43, campos);
                    agregar(InventarioRegulador, 47, campos);
                    agregar(serieRegulador, 46, campos);

                    agregar(tipoTelefono, 55, campos);
                    agregar(marcaTelefono, 56, campos);
                    agregar(modeloTelefono, 57, campos);
                    agregar(extensionTelefono, 59, campos);
                    agregar(InventarioTelefono, 60, campos);
                    agregar(serieTelefono, 58, campos);

                    agregar(marcaImpresora, 64, campos);

                    validarEstados();
                    tablasSistema(campos);


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
            //Cpu
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "Edificio", "Bloque", edificio);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuTipo", "TipoPC", tipoPC);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuPerfil", "Perfil", perfil);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuDisco", "Disco", disco);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuProcesador", "Procesador", procesador);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuMemoria", "Memoria", memoria);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuMarca", "Marca", marcaCpu);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuInventario", "Inventario", InventarioCpu);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuNombre", "NombrePC", pcNombre);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuTag", "Tag", tag);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuCode", "Code", code);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuAdicionalLote", "AdicionalLote", adicionalLote);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuModelo", "Modelo", modeloCpu);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "CpuSerie", "Serie", serieCpu);

            //Pantalla
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "PantallaMarca", "Marca", marcaPantalla);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "PantallaModelo", "Modelo", modeloPantalla);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "PantallaPulgadas", "Pulgadas", pulgadas);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TecladoMarca", "Marca", marcaTeclado);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TecladoModelo", "Modelo", modeloTeclado);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "MouseMarca", "Marca", marcaMouse);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "MouseModelo", "Modelo", modeloMouse);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ParlanteMarca", "Marca", marcaParlante);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ParlanteModelo", "Modelo", modeloParlante);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ProyectorMarca", "Marca", marcaProyector);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ProyectorModelo", "Modelo", modeloProyector);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ReguladorMarca", "Marca", marcaRegulador);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ReguladorModelo", "Modelo", modeloRegulador);        
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ReguladorTipo", "Tipo", tipoRegulador);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TelefonoMarca", "Marca", marcaRegulador);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TelefonoModelo", "Modelo", modeloTelefono);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TelefonoTipo", "Tipo", tipoTelefono);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TelefonoExtension", "Extension", extensionTelefono);
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
                    tablaTeclado(campos);
                    tablaMouse(campos);
                    tablaParlante(campos);
                    tablaProyector(campos);
                    tablaRegulador(campos);
                    tablaTelefono(campos);
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
            
            IngresoSql("CpuModelo", "Modelo", "N/A");

            IngresoSql(22, campos, "PantallaSerie", "Serie");
            IngresoSql(27, campos, "TecladoSerie", "Serie");
            IngresoSql(31, campos, "MouseSerie", "Serie");
            IngresoSql(35, campos, "ParlanteSerie", "Serie");
            IngresoSql(40, campos, "ProyectorSerie", "Serie");
            IngresoSql(46, campos, "ReguladorSerie", "Serie");
            IngresoSql(58, campos, "TelefonoSerie", "Serie");


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
        private void tablaTeclado(string[] campos)
        {
            string inventario = reemplazar(campos[28]);
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TecladoMarca", "Marca", reemplazar(campos[25]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TecladoModelo", "Modelo", reemplazar(campos[26]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TecladoSerie", "Serie", reemplazar(campos[27]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar("BUENO"));

            string values = System.String.Format("({0}),({1}),({2}),({3}),'{4}'", estado, marca, modelo, serie, inventario);
            string campo = "Estado, Marca, Modelo, Serie, Inventario";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = '{2}';", "Teclado", "Inventario", reemplazar(campos[28]));
            IngresoSql(cadenaVerf, "Teclado", campo, values);

        }
        private void tablaMouse(string[] campos)
        {
            string inventario = reemplazar(campos[32]);
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "MouseMarca", "Marca", reemplazar(campos[29]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "MouseModelo", "Modelo", reemplazar(campos[30]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "MouseSerie", "Serie", reemplazar(campos[31]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar("BUENO"));

            string values = System.String.Format("({0}),({1}),({2}),({3}),'{4}'", estado, marca, modelo, serie, inventario);
            string campo = "Estado, Marca, Modelo, Serie, Inventario";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = '{2}';", "Mouse", "Inventario", reemplazar(campos[32]));
            IngresoSql(cadenaVerf, "Mouse", campo, values);

        }
        private void tablaParlante(string[] campos)
        {
            string inventario = reemplazar(campos[36]);
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ParlanteMarca", "Marca", reemplazar(campos[33]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ParlanteModelo", "Modelo", reemplazar(campos[34]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ParlanteSerie", "Serie", reemplazar(campos[35]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar("BUENO"));

            string values = System.String.Format("({0}),({1}),({2}),({3}),'{4}'", estado, marca, modelo, serie, inventario);
            string campo = "Estado, Marca, Modelo, Serie, Inventario";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = '{2}';", "Parlante", "Inventario", reemplazar(campos[36]));
            IngresoSql(cadenaVerf, "Parlante", campo, values);

        }
        private void tablaProyector(string[] campos)
        {
            string inventarioEspol = reemplazar(campos[42]);
            string inventarioEspolTech = reemplazar(campos[41]);
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ProyectorMarca", "Marca", reemplazar(campos[38]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ProyectorModelo", "Modelo", reemplazar(campos[39]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ProyectorSerie", "Serie", reemplazar(campos[40]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar(campos[37]));

            string values = System.String.Format("({0}),({1}),({2}),({3}),'{4}','{5}'", estado, marca, modelo, serie, inventarioEspol,inventarioEspolTech);
            string campo = "Estado, Marca, Modelo, Serie, Inventario,InventarioEspoltech";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = '{2}';", "Proyector", "Inventario", reemplazar(campos[42]));
            IngresoSql(cadenaVerf, "Proyector", campo, values);

        }
        private void tablaRegulador(string[] campos)
        {
            string inventario = reemplazar(campos[47]);
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ReguladorMarca", "Marca", reemplazar(campos[44]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ReguladorModelo", "Modelo", reemplazar(campos[45]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ReguladorSerie", "Serie", reemplazar(campos[46]));
            string tipo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ReguladorTipo", "Tipo", reemplazar(campos[43]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar("BUENO"));

            string values = System.String.Format("({0}),({1}),({2}),({3}),'{4}',({5})", estado, marca, modelo, serie, inventario,tipo);
            string campo = "Estado, Marca, Modelo, Serie, Inventario, Tipo";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = '{2}';", "Regulador", "Inventario", reemplazar(campos[47]));
            IngresoSql(cadenaVerf, "Regulador", campo, values);

        }
        private void tablaTelefono(string[] campos)
        {
            string inventario = reemplazar(campos[60]);
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TelefonoMarca", "Marca", reemplazar(campos[56]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TelefonoModelo", "Modelo", reemplazar(campos[57]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TelefonoSerie", "Serie", reemplazar(campos[58]));
            string tipo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TelefonoTipo", "Tipo", reemplazar(campos[55]));
            string extension = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TelefonoExtension", "Extension", reemplazar(campos[59]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar("BUENO"));

            string values = System.String.Format("({0}),({1}),({2}),({3}),'{4}',({5}),({6})", estado, marca, modelo, serie, inventario, tipo,extension);
            string campo = "Estado, Marca, Modelo, Serie, Inventario, Tipo, Extension";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = '{2}';", "TelefonoModelo", "Modelo", reemplazar(campos[57]));
            IngresoSql(cadenaVerf, "Telefono", campo, values);

        }
        #endregion
    }

}