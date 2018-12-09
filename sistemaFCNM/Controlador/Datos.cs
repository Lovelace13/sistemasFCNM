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
        private LinkedList<String> area = new LinkedList<string>();

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
        private LinkedList<String> tipoMicrofonos = new LinkedList<string>();
        private LinkedList<String> serieMicrofono = new LinkedList<string>();

        //Campos Pantalla Proyeccion
        private LinkedList<String> InventarioPP = new LinkedList<string>();
        private LinkedList<String> marcaPP = new LinkedList<string>();
        private LinkedList<String> modeloPP = new LinkedList<string>();
        private LinkedList<String> seriePP = new LinkedList<string>();
        private LinkedList<String> dimensionespp = new LinkedList<string>();
        //Campos Radios
        private LinkedList<String> InventarioRadio = new LinkedList<string>();
        private LinkedList<String> marcaRadio = new LinkedList<string>();
        private LinkedList<String> modeloRadio = new LinkedList<string>();
        private LinkedList<String> serieRadio = new LinkedList<string>();
        //Equipo
        private LinkedList<String> InventarioEquipo = new LinkedList<string>();
        //Inventario
        private LinkedList<String> fechaInventario = new LinkedList<string>();
        //Usuarios
        private LinkedList<String> nombreUsuarios = new LinkedList<string>();
        private LinkedList<String> user = new LinkedList<string>();
        private LinkedList<String> grupo = new LinkedList<string>();
        private LinkedList<String> contra = new LinkedList<string>();
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
            agregar(contra, "root1234");
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
        private void agregar(LinkedList<String> lista, String campos)
        {
            if (campos.Length != 0 && !lista.Contains(reemplazar(campos)))
            {
                lista.AddFirst(reemplazar(campos));
            }

        }
        private String reemplazar(String dato)
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
        private String formarUser(string nombre)
        {
            return "ESPOL-"+nombre.Trim();
       
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
                    //Ubicacion
                    agregar(oficina, 3, campos);
                    agregar(edificio, 2, campos);
                    agregar(area, 4, campos);
                    //Cpu
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
                    //Pantalla
                    agregar(marcaPantalla, 20, campos);
                    agregar(modeloPantalla, 21, campos);
                    agregar(pulgadas, 24, campos);
                    agregar(InventarioPantalla, 23, campos);
                    agregar(seriePantalla, 22, campos);
                    //Teclado
                    agregar(marcaTeclado, 25, campos);
                    agregar(modeloTeclado, 26, campos);
                    agregar(InventarioTeclado, 28, campos);
                    agregar(serieTeclado, 27, campos);
                    //Mouse
                    agregar(marcaMouse, 29, campos);
                    agregar(modeloMouse, 30, campos);
                    agregar(InventarioMouse, 32, campos);
                    agregar(serieMouse, 31, campos);
                    //Parlante
                    agregar(marcaParlante, 33, campos);
                    agregar(modeloParlante, 34, campos);
                    agregar(InventarioParlante, 36, campos);
                    agregar(serieParlante, 35, campos);
                    //Proyector
                    agregar(marcaProyector, 38, campos);
                    agregar(modeloProyector, 39, campos);
                    agregar(InventarioProyectorEspol, 42, campos);
                    agregar(InventarioProyectorEspolTech, 41, campos);
                    agregar(serieProyector, 40, campos);
                    //Regulador
                    agregar(marcaRegulador, 44, campos);
                    agregar(modeloRegulador, 45, campos);
                    agregar(tipoRegulador, 43, campos);
                    agregar(InventarioRegulador, 47, campos);
                    agregar(serieRegulador, 46, campos);
                    //Telefono
                    agregar(tipoTelefono, 55, campos);
                    agregar(marcaTelefono, 56, campos);
                    agregar(modeloTelefono, 57, campos);
                    agregar(extensionTelefono, 59, campos);
                    agregar(InventarioTelefono, 60, campos);
                    agregar(serieTelefono, 58, campos);
                    //Impresora
                    agregar(marcaImpresora, 64, campos);
                    agregar(modeloImpresora, 63, campos);
                    agregar(serieImpresora, 61, campos);
                    agregar(InventarioImpresora, 62, campos);
                    //Microfono
                    agregar(marcaMicrofonos, 66, campos);
                    agregar(tipoMicrofonos, 65, campos);
                    agregar(serieMicrofono, 67, campos);
                    agregar(InventarioMicrofonos, 68, campos);
                    //Pantalla Proyeccion
                    agregar(marcaPP, 69, campos);
                    agregar(modeloPP, 72, campos);
                    agregar(seriePP, 70, campos);
                    agregar(InventarioPP, 71, campos);
                    agregar(dimensionespp, 73, campos);
                    //Radios
                    agregar(marcaRadio, 75, campos);
                    agregar(modeloRadio, 76, campos);
                    agregar(serieRadio, 77, campos);
                    agregar(InventarioRadio, 74, campos);
                    //Equipos
                    agregar(InventarioEquipo, 80, campos);
                    //Usuarios
                    agregar(nombreUsuarios, 5, campos);
                    agregar(grupo, 1, campos);
                    agregar(user, formarUser(campos[5]));
                    
                    //Campos Extra
                    validarEstados();


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
            //Ubicacion
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "Edificio", "Bloque", edificio);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "NombreOficina", "NombreOficina", oficina);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "AreaOficina", "Area", area);
            //Cpu
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
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "PantallaInventario", "Inventario", InventarioPantalla);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "PantallaSerie", "Serie", seriePantalla);
            //Teclado
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TecladoMarca", "Marca", marcaTeclado);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TecladoModelo", "Modelo", modeloTeclado);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TecladoInventario", "Inventario", InventarioTeclado);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TecladoSerie", "Serie", serieTeclado);
            //Mouse
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "MouseMarca", "Marca", marcaMouse);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "MouseModelo", "Modelo", modeloMouse);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "MouseInventario", "Inventario", InventarioMouse);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "MouseSerie", "Serie", serieMouse);
            //Parlante
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ParlanteMarca", "Marca", marcaParlante);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ParlanteModelo", "Modelo", modeloParlante);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ParlanteInventario", "Inventario", InventarioParlante);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ParlanteSerie", "Serie", serieParlante);
            //Proyector
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ProyectorMarca", "Marca", marcaProyector);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ProyectorModelo", "Modelo", modeloProyector);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ProyectorInventario", "Inventario", InventarioProyectorEspol);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ProyectorInventarioEspolTech", "Inventario", InventarioProyectorEspolTech);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ProyectorSerie", "Serie", serieProyector);
            //Regulador
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ReguladorMarca", "Marca", marcaRegulador);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ReguladorModelo", "Modelo", modeloRegulador);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ReguladorTipo", "Tipo", tipoRegulador);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ReguladorInventario", "Inventario", InventarioRegulador);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ReguladorSerie", "Serie", serieRegulador);
            //Telefono
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TelefonoInventario", "Inventario", InventarioTelefono);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TelefonoSerie", "Serie", serieTelefono);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TelefonoMarca", "Marca", marcaTelefono);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TelefonoModelo", "Modelo", modeloTelefono);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TelefonoTipo", "Tipo", tipoTelefono);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TelefonoExtension", "Extension", extensionTelefono);
            //Impresora
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ImpresoraMarca", "Marca", marcaImpresora);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ImpresoraModelo", "Modelo", modeloImpresora);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ImpresoraInventario", "Inventario", InventarioImpresora);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ImpresoraSerie", "Serie", serieImpresora);
            //Microfonos
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "MicrofonoMarca", "Marca", marcaMicrofonos);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "MicrofonoTipo", "Tipo", tipoMicrofonos);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "MicrofonoInventario", "Inventario", InventarioMicrofonos);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "MicrofonoSerie", "Serie", serieMicrofono);
            //Pantalla Proyeccion
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "PantallaProyeccionMarca", "Marca", marcaPP);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "PantallaProyeccionModelo", "Modelo", modeloPP);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "PantallaProyeccionInventario", "Inventario", InventarioPP);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "PantallaProyeccionSerie", "Serie", seriePP);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "PantallaProyeccionDimensiones", "Dimensiones", dimensionespp);
            //Radios
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "RadioMarca", "Marca", marcaRadio);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "RadioModelo", "modelo", modeloRadio);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "RadioInventario", "Inventario", InventarioRadio);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "RadioSerie", "Serie", serieRadio);
            //Estados Equipos
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "Estado", "Estado", estado);
            //Equipos 
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "EquipoInventario", "Inventario", InventarioEquipo);
            //Usuarios 
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "IdUsuario", "Usuario", user);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "TipoUsuario", "Tipo", grupo);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "NombreUsuario", "Nombre", nombreUsuarios);
            agregarDatosFijos("INSERT INTO {0} VALUES ('{2}');", "ClaveUsuario", "Clave", contra);

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
                    tablaImpresora(campos);
                    tablaMicrofono(campos);
                    tablaPantallaProyeccion(campos);
                    tablaRadio(campos);
                    tablaOficina(campos);
                    tablaUsuarios(campos);
                    tablaEquipo(campos);
                    
                    
                }
                objReader.Close();
            }

            catch (Exception)
            {


            }
        }
        #endregion

        #region Funciones para Guardar Tablas Sistema
        private void tablaCpu(String[] campos)
        {
            string inventario = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "CpuInventario", "Inventario", reemplazar(campos[7]));
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

            string values = System.String.Format("({0}),({1}),({2}),({3}),({4}),({5}),({6}),({7}),({8}),({9}),({10}),({11}),({12})", pcNombre, inventario, tipoPc, perfil, tag, code, procesador, memoria, discoDuro, adicional, marca, estado, serie);
            string campo = "NombrePC,Inventario,TipoPC,perfil,tag,code,procesador,memoria,disco,AdicionalLote,Marca,Estado,Serie";
            string cadenaVeriificacion = System.String.Format("SELECT ID FROM {0} WHERE {1} = ({2});", "Cpu", "Inventario", inventario);
            IngresoSql(cadenaVeriificacion, "Cpu", campo, values);
        }
        private void tablaPantalla(string[] campos)
        {
            string inventario = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "PantallaInventario", "Inventario", reemplazar(campos[23]));
            string pulgadas = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "PantallaPulgadas", "Pulgadas", reemplazar(campos[24]));
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "PantallaMarca", "Marca", reemplazar(campos[20]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "PantallaModelo", "Modelo", reemplazar(campos[21]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "PantallaSerie", "Serie", reemplazar(campos[22]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar(campos[19]));

            string values = System.String.Format("({0}),({1}),({2}),({3}),({4}),({5})", estado, marca, modelo, serie, inventario, pulgadas);
            string campo = "Estado, Marca, Modelo, Serie, Inventario, Pulgadas";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = ({2});", "Pantalla", "Inventario", inventario);
            IngresoSql(cadenaVerf, "Pantalla", campo, values);

        }
        private void tablaTeclado(string[] campos)
        {
            string inventario = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TecladoInventario", "Inventario", reemplazar(campos[28]));
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TecladoMarca", "Marca", reemplazar(campos[25]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TecladoModelo", "Modelo", reemplazar(campos[26]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TecladoSerie", "Serie", reemplazar(campos[27]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar("BUENO"));

            string values = System.String.Format("({0}),({1}),({2}),({3}),({4})", estado, marca, modelo, serie, inventario);
            string campo = "Estado, Marca, Modelo, Serie, Inventario";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = ({2});", "Teclado", "Inventario", inventario);
            IngresoSql(cadenaVerf, "Teclado", campo, values);

        }
        private void tablaMouse(string[] campos)
        {
            string inventario = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "MouseInventario", "Inventario", reemplazar(campos[32]));
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "MouseMarca", "Marca", reemplazar(campos[29]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "MouseModelo", "Modelo", reemplazar(campos[30]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "MouseSerie", "Serie", reemplazar(campos[31]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar("BUENO"));

            string values = System.String.Format("({0}),({1}),({2}),({3}),({4})", estado, marca, modelo, serie, inventario);
            string campo = "Estado, Marca, Modelo, Serie, Inventario";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = ({2});", "Mouse", "Inventario", inventario);
            IngresoSql(cadenaVerf, "Mouse", campo, values);

        }
        private void tablaParlante(string[] campos)
        {
            string inventario = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ParlanteInventario", "Inventario", reemplazar(campos[36]));
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ParlanteMarca", "Marca", reemplazar(campos[33]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ParlanteModelo", "Modelo", reemplazar(campos[34]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ParlanteSerie", "Serie", reemplazar(campos[35]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar("BUENO"));

            string values = System.String.Format("({0}),({1}),({2}),({3}),({4})", estado, marca, modelo, serie, inventario);
            string campo = "Estado, Marca, Modelo, Serie, Inventario";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = ({2});", "Parlante", "Inventario", inventario);
            IngresoSql(cadenaVerf, "Parlante", campo, values);

        }
        private void tablaProyector(string[] campos)
        {
            string inventarioEspol = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ProyectorInventario", "Inventario", reemplazar(campos[42]));
            string inventarioEspolTech = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ProyectorInventarioEspolTech", "Inventario", reemplazar(campos[41]));
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ProyectorMarca", "Marca", reemplazar(campos[38]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ProyectorModelo", "Modelo", reemplazar(campos[39]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ProyectorSerie", "Serie", reemplazar(campos[40]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar(campos[37]));

            string values = System.String.Format("({0}),({1}),({2}),({3}),({4}),({5})", estado, marca, modelo, serie, inventarioEspol, inventarioEspolTech);
            string campo = "Estado, Marca, Modelo, Serie, Inventario,InventarioEspoltech";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} =({2});", "Proyector", "Inventario", inventarioEspol);
            IngresoSql(cadenaVerf, "Proyector", campo, values);

        }
        private void tablaRegulador(string[] campos)
        {
            string inventario = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ReguladorInventario", "Inventario", reemplazar(campos[47]));
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ReguladorMarca", "Marca", reemplazar(campos[44]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ReguladorModelo", "Modelo", reemplazar(campos[45]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ReguladorSerie", "Serie", reemplazar(campos[46]));
            string tipo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ReguladorTipo", "Tipo", reemplazar(campos[43]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar("BUENO"));

            string values = System.String.Format("({0}),({1}),({2}),({3}),({4}),({5})", estado, marca, modelo, serie, inventario, tipo);
            string campo = "Estado, Marca, Modelo, Serie, Inventario, Tipo";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = ({2});", "Regulador", "Inventario", inventario);
            IngresoSql(cadenaVerf, "Regulador", campo, values);

        }
        private void tablaTelefono(string[] campos)
        {
            string inventario = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TelefonoInventario", "Inventario", reemplazar(campos[60]));
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TelefonoMarca", "Marca", reemplazar(campos[56]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TelefonoModelo", "Modelo", reemplazar(campos[57]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TelefonoSerie", "Serie", reemplazar(campos[58]));
            string tipo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TelefonoTipo", "Tipo", reemplazar(campos[55]));
            string extension = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TelefonoExtension", "Extension", reemplazar(campos[59]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar(campos[54]));

            string values = System.String.Format("({0}),({1}),({2}),({3}),({4}),({5}),({6})", estado, marca, modelo, serie, inventario, tipo, extension);
            string campo = "Estado, Marca, Modelo, Serie, Inventario, Tipo, Extension";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = ({2});", "Telefono", "Inventario", inventario);
            IngresoSql(cadenaVerf, "Telefono", campo, values);

        }
        private void tablaImpresora(string[] campos)
        {
            string inventario = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ImpresoraInventario", "Inventario", reemplazar(campos[62]));
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ImpresoraMarca", "Marca", reemplazar(campos[64]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ImpresoraModelo", "Modelo", reemplazar(campos[63]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ImpresoraSerie", "Serie", reemplazar(campos[61]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar("BUENO"));

            string values = System.String.Format("({0}),({1}),({2}),({3}),({4})", estado, marca, modelo, serie, inventario);
            string campo = "Estado, Marca, Modelo, Serie, Inventario";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = ({2});", "Impresora", "Inventario", inventario);
            IngresoSql(cadenaVerf, "Impresora", campo, values);

        }
        private void tablaMicrofono(string[] campos)
        {
            string inventario = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "MicrofonoInventario", "Inventario", reemplazar(campos[68]));
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "MicrofonoMarca", "Marca", reemplazar(campos[66]));
            string tipo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "MicrofonoTipo", "Tipo", reemplazar(campos[65]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "MicrofonoSerie", "Serie", reemplazar(campos[67]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar("BUENO"));

            string values = System.String.Format("({0}),({1}),({2}),({3}),({4})", estado, marca, tipo, serie, inventario);
            string campo = "Estado, Marca, Tipo, Serie, Inventario";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = ({2});", "Microfono", "Inventario", inventario);
            IngresoSql(cadenaVerf, "Microfono", campo, values);

        }
        private void tablaPantallaProyeccion(string[] campos)
        {
            string inventario = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "PantallaProyeccionInventario", "Inventario", reemplazar(campos[71]));
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "PantallaProyeccionMarca", "Marca", reemplazar(campos[69]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "PantallaProyeccionModelo", "Modelo", reemplazar(campos[72]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "PantallaProyeccionSerie", "Serie", reemplazar(campos[70]));
            string dimensiones = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "PantallaProyeccionDimensiones", "Dimensiones", reemplazar(campos[73]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar("BUENO"));

            string values = System.String.Format("({0}),({1}),({2}),({3}),({4}),({5})", estado, marca, modelo, serie, inventario, dimensiones);
            string campo = "Estado, Marca, Modelo, Serie, Inventario, Dimensiones";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = ({2});", "PantallaProyeccion", "Inventario", inventario);
            IngresoSql(cadenaVerf, "PantallaProyeccion", campo, values);

        }
        private void tablaRadio(string[] campos)
        {
            string inventario = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "RadioInventario", "Inventario", reemplazar(campos[74]));
            string marca = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "RadioMarca", "Marca", reemplazar(campos[75]));
            string modelo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "RadioModelo", "Modelo", reemplazar(campos[76]));
            string serie = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "RadioSerie", "Serie", reemplazar(campos[77]));
            string estado = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Estado", "Estado", reemplazar("BUENO"));

            string values = System.String.Format("({0}),({1}),({2}),({3}),({4})", estado, marca, modelo, serie, inventario);
            string campo = "Estado, Marca, Modelo, Serie, Inventario";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = ({2});", "Radio", "Inventario", inventario);
            IngresoSql(cadenaVerf, "Radio", campo, values);

        }
        private void tablaOficina(string[] campos)
        {
            string edificio = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Edificio", "Bloque", reemplazar(campos[2]));
            string oficina = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "NombreOficina", "NombreOficina", reemplazar(campos[3]));
            string area = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "AreaOficina", "Area", reemplazar(campos[4]));

            string values = System.String.Format("({0}),({1}),({2})", edificio, oficina, area);
            string campo = "Edificio, NombreOficina, Area";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = ({2}) and {3} = ({4})", "Oficina", "NombreOficina", oficina, "Edificio", edificio);
            IngresoSql(cadenaVerf, "Oficina", campo, values);
        }
        private void tablaUsuarios(string[] campos)
        {
            string usuario = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "IdUsuario", "Usuario", formarUser(campos[5]));
            string tipo = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TipoUsuario", "Tipo", reemplazar(campos[1]));
            string nombre = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "NombreUsuario", "Nombre", reemplazar(campos[5]));
            string clv = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ClaveUsuario", "Clave","root1234");

            string values = System.String.Format("({0}),({1}),({2}),({3})", usuario, tipo, nombre,clv);
            string campo = "Usuario, Tipo, Nombre, Clave";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = ({2});", "Usuario", "Usuario", usuario);
            IngresoSql(cadenaVerf, "Usuario", campo, values);
        }
        private void tablaEquipo(string[] campos)
        {
            string Inventario = System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "EquipoInventario", "Inventario", reemplazar(campos[80])); ;
            string Cpu = System.String.Format("SELECT ID FROM {0} WHERE {1}=({2})", "Cpu", "Inventario", System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "CpuInventario", "Inventario", reemplazar(campos[7]))); 
            string Oficina = System.String.Format("SELECT ID FROM {0} WHERE {1} = ({2}) and {3} = ({4})", "Oficina", "NombreOficina", System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "NombreOficina", "NombreOficina", reemplazar(campos[3])), "Edificio", System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "Edificio", "Bloque", reemplazar(campos[2])));
            string Microfono = System.String.Format("SELECT ID FROM {0} WHERE {1}=({2})", "Microfono", "Inventario", System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "MicrofonoInventario", "Inventario", reemplazar(campos[68])));
            string Telefono = System.String.Format("SELECT ID FROM {0} WHERE {1}=({2})", "Telefono", "Inventario", System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TelefonoInventario", "Inventario", reemplazar(campos[60])));
            string PantallaProyeccion = System.String.Format("SELECT ID FROM {0} WHERE {1}=({2})", "PantallaProyeccion", "Inventario", System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "PantallaProyeccionInventario", "Inventario", reemplazar(campos[71])));
            string Radios = System.String.Format("SELECT ID FROM {0} WHERE {1}=({2})", "Radio", "Inventario", System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "RadioInventario", "Inventario", reemplazar(campos[74])));
            string Pantalla = System.String.Format("SELECT ID FROM {0} WHERE {1}=({2})", "Pantalla", "Inventario", System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "PantallaInventario", "Inventario", reemplazar(campos[23])));
            string Teclado = System.String.Format("SELECT ID FROM {0} WHERE {1}=({2})", "Teclado", "Inventario", System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "TecladoInventario", "Inventario", reemplazar(campos[28])));
            string Mouse = System.String.Format("SELECT ID FROM {0} WHERE {1}=({2})", "Mouse", "Inventario", System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "MouseInventario", "Inventario", reemplazar(campos[32])));
            string Parlante = System.String.Format("SELECT ID FROM {0} WHERE {1}=({2})", "Parlante", "Inventario", System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ParlanteInventario", "Inventario", reemplazar(campos[36])));
            string Regulador = System.String.Format("SELECT ID FROM {0} WHERE {1}=({2})", "Regulador", "Inventario", System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ReguladorInventario", "Inventario", reemplazar(campos[47])));
            string Impresora = System.String.Format("SELECT ID FROM {0} WHERE {1}=({2})", "Impresora", "Inventario", System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ImpresoraInventario", "Inventario", reemplazar(campos[62])));
            string Proyector = System.String.Format("SELECT ID FROM {0} WHERE {1}=({2})", "Proyector", "Inventario", System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "ProyectorInventario", "Inventario", reemplazar(campos[42])));
            string Usuario = System.String.Format("SELECT ID FROM {0} WHERE {1}=({2})", "Usuario", "Usuario", System.String.Format("SELECT ID FROM {0} WHERE {1}='{2}'", "IdUsuario", "Usuario", formarUser(campos[5]).ToUpper()));

            string values = System.String.Format("({0}),({1}),({2}),({3}),({4}),({5}),({6}),({7}),({8}),({9}),({10}),({11}),({12}),({13}),({14})",Inventario,
                Cpu,Oficina,Microfono,Telefono,PantallaProyeccion,Radios,Pantalla,Teclado,Mouse,
                Parlante,Regulador,Impresora,Proyector,Usuario);
            string campo = "Inventario,Cpu,Oficina,Microfono,Telefono,PantallaProyeccion,Radios,Pantalla,Teclado,Mouse,Parlante,Regulador,Impresora,Proyector,Usuario";
            string cadenaVerf = System.String.Format("SELECT ID FROM {0} WHERE {1} = ({2});", "Equipo", "Inventario", Inventario);
            IngresoSql(cadenaVerf, "Equipo", campo, values);
            
        }
        #endregion
    }

}