using sistemaFCNM.Clases;
using sistemaFCNM.sistemasFCNMDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaFCNM.Vistas
{
    public partial class RegistroOficina : Form
    {
        public RegistroOficina()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            string area = "";
            string edificio = "";
            if(comboBox2.SelectedIndex != 0)
            {
                area = comboBox2.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione Area");
                return;
            }
            if (comboBox2.SelectedIndex != 0)
            {
                edificio = comboBox1.SelectedItem.ToString();
            }else
            {
                MessageBox.Show("Seleccione Edificio");
                return;
            }
            if (textBox1.Text.Length != 0)
            {
                NombreOficinaTableAdapter nombre = new NombreOficinaTableAdapter();
                nombre.InsertNombreOficina(textBox1.Text);

                nombre.InsertOficina((int)nombre.ObtenerNombre(textBox1.Text), (int)nombre.ObtenerEdificio(edificio),(int) nombre.ObtenerArea(area));
                MessageBox.Show("Oficina Agregada");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese Nombre Oficina");
                return;
            }
           
        }

        private void RegistroOficina_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            comboBox1.Items.AddRange(Datos._obtenerEdificio());
            comboBox2.Items.AddRange(Datos._obtenerArea());


        }
    }
}
