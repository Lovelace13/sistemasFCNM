using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaFCNM.Clases
{
    class FuncionesUtiles
    {
        public static bool masdetallesActiva = false;
        public static bool siguienteActiva = false;
        public static bool anteriorActiva = false;
        public static string INVENTARIO_EQUIPO;
        public static string USUARIO;
        public static string OBSERVACION;
        public static bool nuevoRegistro = false;
        
        public static mainPrincipal form1;

        public static void abrirVentanas(Form ventana, FlowLayoutPanel panelContenedor)
        {
            if (panelContenedor.Controls.Count > 0)
            {
                panelContenedor.Controls.RemoveAt(0);

            }
            ventana.TopLevel = false;
            ventana.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(ventana);
            panelContenedor.Tag = ventana;
            ventana.Show();
        }
        public static string ventanaDialogo()
        {
            // Configure the message box to be displayed
            string messageBoxText = "Guardar Cambios?";
            string caption = "Guardar";
            MessageBoxButtons button = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
                      

           String result = MessageBox.Show(messageBoxText, caption, button, icon).ToString();


            // Process message box results
            return result;
                
        }

        public static void desactivarMenu()
        {
            mainPrincipal.btn13.Enabled = false;
            mainPrincipal.btn1.Enabled = false;
            mainPrincipal.btn2.Enabled = false;
            mainPrincipal.btn3.Enabled = false;
            mainPrincipal.btn4.Enabled = false;
            mainPrincipal.btn5.Enabled = false;
            mainPrincipal.btn6.Enabled = false;
            mainPrincipal.btn7.Enabled = false;
            mainPrincipal.btn8.Enabled = false;
            mainPrincipal.btn9.Enabled = false;
            mainPrincipal.btn10.Enabled = false;
            mainPrincipal.btn11.Enabled = false;
            mainPrincipal.btn12.Enabled = false;
        }

        public static void activarMenu()
        {
            mainPrincipal.btn13.Enabled = true;
            mainPrincipal.btn1.Enabled = true;
            mainPrincipal.btn2.Enabled = true;
            mainPrincipal.btn3.Enabled = true;
            mainPrincipal.btn4.Enabled = true;
            mainPrincipal.btn5.Enabled = true;
            mainPrincipal.btn6.Enabled = true;
            mainPrincipal.btn7.Enabled = true;
            mainPrincipal.btn8.Enabled = true;
            mainPrincipal.btn9.Enabled = true;
            mainPrincipal.btn10.Enabled = true;
            mainPrincipal.btn11.Enabled = true;
            mainPrincipal.btn12.Enabled = true;
        }

        public static void agregar(LinkedList<String> lista, int num, String[] campos)
        {
            if (campos[num].Length != 0 && !lista.Contains(reemplazar(campos[num])))
            {
                lista.AddFirst(reemplazar(campos[num]));
            }
            
        }
        public static String reemplazar(String dato)
        {
            if (dato == "NO APLICA " || dato == "no aplica" || 
                dato == "" || dato == "NOAPLICA" || dato == "NO APLICA" ||dato== "NO")
            {
                return "N/A";
            }
            else
            {
                return dato.ToUpper();
            }

        }

        public static void crearListaObjetos()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos csv (*.csv)|*.csv";
            ofd.Title = "Abrir";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName);
            }
            ofd.Dispose();


            StreamReader objReader = new StreamReader(ofd.FileName);
            string linea = "";
            LinkedList<String> oficina = new LinkedList<string>();
            LinkedList<String> edificio = new LinkedList<string>();
            LinkedList<String> tipoPC = new LinkedList<string>();
            LinkedList<String> estado = new LinkedList<string>();
            LinkedList<String> perfil = new LinkedList<string>();
            LinkedList<String> marcaCpu = new LinkedList<string>();
            LinkedList<String> procesador = new LinkedList<string>();
            LinkedList<String> memoria = new LinkedList<string>();
            LinkedList<String> disco = new LinkedList<string>();

            LinkedList<String> marcaPantalla = new LinkedList<string>();
            LinkedList<String> modeloPantalla = new LinkedList<string>();
            LinkedList<String> pulgadas = new LinkedList<string>();

            LinkedList<String> marcaTeclado = new LinkedList<string>();
            LinkedList<String> modeloTeclado = new LinkedList<string>();

            LinkedList<String> marcaMouse = new LinkedList<string>();
            LinkedList<String> modeloMouse = new LinkedList<string>();

            LinkedList<String> marcaParlante = new LinkedList<string>();
            LinkedList<String> modeloParlante = new LinkedList<string>();

            LinkedList<String> marcaRegulador = new LinkedList<string>();
            LinkedList<String> tipoRegulador = new LinkedList<string>();

            LinkedList<String> marcaTelefono = new LinkedList<string>();
            LinkedList<String> tipoTelefono = new LinkedList<string>();

            LinkedList<String> marcaImpresora = new LinkedList<string>();
            
            while (linea != null)
            {
                linea = objReader.ReadLine();
                try
                {
                    String[] campos = linea.Split(';');
                    FuncionesUtiles.agregar(oficina, 3, campos);
                    FuncionesUtiles.agregar(edificio, 2, campos);
                    FuncionesUtiles.agregar(tipoPC, 8, campos);
                    FuncionesUtiles.agregar(estado, 9, campos);
                    FuncionesUtiles.agregar(marcaCpu, 10, campos);
                    FuncionesUtiles.agregar(procesador, 15, campos);
                    FuncionesUtiles.agregar(memoria, 16, campos);
                    FuncionesUtiles.agregar(disco, 17, campos);
                    FuncionesUtiles.agregar(perfil, 11, campos);
                    FuncionesUtiles.agregar(marcaPantalla, 20, campos);
                    FuncionesUtiles.agregar(modeloPantalla, 21, campos);
                    FuncionesUtiles.agregar(pulgadas, 24, campos);
                    FuncionesUtiles.agregar(marcaTeclado, 25, campos);
                    FuncionesUtiles.agregar(modeloTeclado, 25, campos);
                    FuncionesUtiles.agregar(marcaMouse, 29, campos);
                    FuncionesUtiles.agregar(modeloMouse, 30, campos);
                    FuncionesUtiles.agregar(marcaParlante, 33, campos);
                    FuncionesUtiles.agregar(modeloParlante, 34, campos);
                    FuncionesUtiles.agregar(marcaRegulador, 44, campos);
                    FuncionesUtiles.agregar(tipoRegulador, 43, campos);
                    FuncionesUtiles.agregar(tipoTelefono, 55, campos);
                    FuncionesUtiles.agregar(marcaTelefono, 56, campos);
                    FuncionesUtiles.agregar(marcaImpresora, 64, campos);
                    

                }
                catch (NullReferenceException)
                {

                }
            }
            objReader.Close();
            foreach (String list in edificio)
            {
                Console.WriteLine(list);
            }
        }


    }
}
}
