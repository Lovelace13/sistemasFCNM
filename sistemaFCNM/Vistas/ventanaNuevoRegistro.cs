using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaFCNM.Clases;
using LibLlenarCombos;

namespace sistemaFCNM.Vistas
{
    public partial class ventanaNuevoRegistro : Form
    {
        public ventanaNuevoRegistro()
        {
            InitializeComponent();
        }

        private void panelCabecera_Paint(object sender, PaintEventArgs e)
        {
            MouseMovimiento mouseMove = new MouseMovimiento(this);
            this.panelCabecera.MouseMove += new System.Windows.Forms.MouseEventHandler(mouseMove.Form1_MouseMove);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            caracteristicas();
            crearCpu();
            ///1
            caracteristicas();
            crearPantalla();
            ///2
            caracteristicas();
            crearMouse();
            ///3
            caracteristicas();
            crearTeclado();
            ///4
            caracteristicas();
            crearRegulador();
            ///5
            caracteristicas();
            crearParlante();
            ///6
            caracteristicas();
            crearImpresora();
            ///7
            caracteristicas();
            crearProyector();
            ///8
            caracteristicas();
            crearMicrofono();
            ///9
            caracteristicas();
            crearTelefono();
            ///10
            caracteristicas();
            crearPantallaProy();
            ///11
            caracteristicas();
            crearRadio();
            ///12

            crearEquipo();
            crearInventario();

            
            FuncionesUtiles.INVENTARIO_EQUIPO = txtEquipo.Text.Trim();
            MessageBox.Show("Ingrese Datos de los equipos "+ FuncionesUtiles.INVENTARIO_EQUIPO);
            FuncionesUtiles.form1.Visible = true;
            this.Close();
        }
        private string cambiarFecha(string fecha)
        {
            string[] arr = fecha.Split('/');
            return arr[2]+"/"+ agregarCero(arr[1]) + "/" + agregarCero(arr[0]);
        }
        private string agregarCero(string numero)
        {
            if(numero == "1"|| numero == "2"|| numero == "3"|| numero == "4"
                || numero == "5"|| numero == "6"|| numero == "7"||numero == "8"
                || numero == "9")
            {
                return "0"+numero;
            }
            else
            {
                return numero;
            }
            
        }
        private void crearInventario()
        {
            
            string sql = "INSERT INTO Inventario(fecha_inventario,Ayudante,observacion,Equipo) VALUES ('"+ cambiarFecha(DateTime.Today.ToString("d")) + "','"+FuncionesUtiles.USUARIO+"','"+FuncionesUtiles.OBSERVACION+"','" + txtEquipo.Text.Trim() + "')";
            Datos.Insertar(sql);
            Console.WriteLine(sql);
        }

        private void crearEquipo()
        {
            string sql = "INSERT INTO Equipo(id_Equipo,Inventario_CPU,Oficina,Microfono,Telefono,PantallaProyeccion,Radios,Pantalla,Teclado,Mouse,Parlante,Regulador,Impresora,Proyector)"+
                "VALUES('"+txtEquipo.Text.Trim()+ "', (select MAX(ID) from CPU), (select top 1 id  from Oficina where nombre_oficina = '"+comboOficina.SelectedValue+"'), (select MAX(ID) from Microfonos), (select MAX(ID) from Telefono),(select MAX(ID) from Pantalla_Proyeccion), (select MAX(ID) from Radio), (select MAX(ID) from Pantalla), (select MAX(ID) from Teclado), (select MAX(ID) from Mouse), (select MAX(ID) from Parlante), (select MAX(ID) from Regulador), (select MAX(ID) from Impresora), (select MAX(ID) from Proyector)); ";
            Datos.Insertar(sql);
        }

        private void crearRadio()
        {
            string sql = "INSERT INTO Radio(caracteristicas,Inventario_Radio) VALUES ((select MAX(id_caracteristica) from Caracteristicas),'');";
            Datos.Insertar(sql);
        }

        private void crearPantallaProy()
        {
            string sql = "INSERT INTO Pantalla_Proyeccion(caracteristicas,Dimensiones,Inventario_PantallaProyeccion) VALUES ((select MAX(id_caracteristica) from Caracteristicas),'','');";
            Datos.Insertar(sql);
        }

        private void crearTelefono()
        {
            string sql = "INSERT INTO Telefono(caracteristicas,tipo,extension,Inventario_Telefono) VALUES((select MAX(id_caracteristica) from Caracteristicas),'','','');";
            Datos.Insertar(sql);
        }

        private void crearMicrofono()
        {
            string sql = "INSERT INTO Microfonos(caracteristicas,tipo,Inventario_Microfono) VALUES ((select MAX(id_caracteristica) from Caracteristicas),'','');";
            Datos.Insertar(sql);
        }

        private void crearProyector()
        {
            string sql = "INSERT INTO Proyector(caracteristicas,Inventario_Espoltech,Inventario_Proyector) VALUES((select MAX(id_caracteristica) from Caracteristicas), '', ''); ";
            Datos.Insertar(sql);
        }

        private void crearImpresora()
        {
            string sql = "INSERT INTO Impresora(caracteristicas,Inventario_Impresora) VALUES ((select MAX(id_caracteristica) from Caracteristicas),'')";
            Datos.Insertar(sql);
        }

        private void crearParlante()
        {
            string sql = "INSERT INTO Parlante(caracteristicas,Inventario_Parlante) VALUES((select MAX(id_caracteristica) from Caracteristicas),'');";
            Datos.Insertar(sql);
        }

        private void crearRegulador()
        {
            string sql = "INSERT INTO Regulador(caracteristicas,tipo,Inventario_Regulador) VALUES((select MAX(id_caracteristica) from Caracteristicas),'',''); ";
            Datos.Insertar(sql);
        }

        private void crearTeclado()
        {
            string sql = "INSERT INTO Teclado(caracteristicas,Inventario_teclado) VALUES((select MAX(id_caracteristica) from Caracteristicas),'');";
            Datos.Insertar(sql);
        }

        private void crearMouse()
        {
            string sql = "INSERT INTO Mouse (caracteristicas,Inventario_Mouse) VALUES((select MAX(id_caracteristica) from Caracteristicas),'');";
            Datos.Insertar(sql);
        }

        private void crearPantalla()
        {
            string sql = "INSERT INTO Pantalla(caracteristicas,Inventario_Pantalla,pulgadas) "+
                "VALUES((select MAX(id_caracteristica) from Caracteristicas), '', ''); ";
            Datos.Insertar(sql);
        }

        private void caracteristicas()
        {
            string sql = "INSERT INTO Caracteristicas (marca,modelo,serie,estado)"+
                         "VALUES('', '', '', ''); ";
            Datos.Insertar(sql);
        }

        private void crearCpu()
        {
            string sql = "INSERT INTO CPU(nombre_PC,inventario_cpu,tipo_PC,Caracteristicas,perfil,tag,code,procesador,memoria,disco,adicional_lote) VALUES('','','',(select MAX(id_caracteristica) from Caracteristicas),'','','','','','','');";
            Datos.Insertar(sql);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FuncionesUtiles.form1.Visible = true;
        }                   

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ventanaNuevoRegistro_Load(object sender, EventArgs e)
        {
            LlenarCombos combos = new LlenarCombos("Parametros.xml");
            combos.SQL = "select bloque from Edificio union select '[Seleccione Edificio]';";
            combos.CampoID = "bloque";
            combos.CampoTexto = "bloque";
            combos.LlenarComboWindows(comboEdificio);

            
            combos.SQL = "SELECT nombre_oficina, COUNT(*) AS RecuentoFilas FROM Oficina GROUP BY nombre_oficina HAVING COUNT(*) > 1 ORDER BY nombre_oficina;";
            combos.CampoID = "nombre_oficina";
            combos.CampoTexto = "nombre_oficina";
            combos.LlenarComboWindows(comboOficina);

        }
    }
}
