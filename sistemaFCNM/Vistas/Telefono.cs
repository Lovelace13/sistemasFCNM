﻿using sistemaFCNM.Clases;
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
    public partial class Telefono : Form
    {
        public Telefono()
        {
            InitializeComponent();
        }

        private void Telefono_Load(object sender, EventArgs e)
        {
            if (FuncionesUtiles.masdetallesActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
            }
            else
            {
                FuncionesUtiles.INVENTARIO_EQUIPO = Microsoft.VisualBasic.Interaction.InputBox("Inventario Equipo", "Registrar Busqueda", "", 600);

            }


            string sql = "select e.id_Equipo, reg.Inventario_Regulador,reg.tipo,car.estado,car.marca," +
                "car.modelo,car.serie from  Equipo e, Regulador reg," +
                "Caracteristicas car where " +
                "e.Regulador = reg.ID and car.id_caracteristica = reg.caracteristicas and e.id_Equipo = '" + FuncionesUtiles.INVENTARIO_EQUIPO + "'; ";

            Datos.llenarGrid(sql, grid);
            llenarCampos();
        }

        private void llenarCampos()
        {

            if (grid.Rows.Count == 1)
            {
                return;
            }
            txtTelefono.Text = grid.Rows[0].Cells["Inventario_Regulador"].Value.ToString();
            txtTipo.Text = grid.Rows[0].Cells["tipo"].Value.ToString();
            txtExtension.Text = grid.Rows[0].Cells["tipo"].Value.ToString();
            txtEstado.Text = grid.Rows[0].Cells["estado"].Value.ToString();
            txtMarca.Text = grid.Rows[0].Cells["marca"].Value.ToString();
            txtModelo.Text = grid.Rows[0].Cells["modelo"].Value.ToString();
            txtSerie.Text = grid.Rows[0].Cells["serie"].Value.ToString();

        }
    }
}
