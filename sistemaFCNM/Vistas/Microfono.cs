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
    public partial class Microfono : Form
    {
        public Microfono()
        {
            InitializeComponent();
        }

        private void Microfono_Load(object sender, EventArgs e)
        {
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
            }
            else
            {
                FuncionesUtiles.INVENTARIO_EQUIPO = Microsoft.VisualBasic.Interaction.InputBox("Inventario Equipo", "Registrar Busqueda", "", 600);

            }


            string sql = "select e.id_Equipo, pro.Inventario_Microfono,pro.tipo,car.estado,car.marca," +
                "car.modelo,car.serie from  Equipo e, Microfonos pro," +
                "Caracteristicas car where " +
                "e.Microfono = pro.ID and car.id_caracteristica = pro.caracteristicas and e.id_Equipo = '" + FuncionesUtiles.INVENTARIO_EQUIPO + "'; ";

            Datos.llenarGrid(sql, grid);
            llenarCampos();
        }

        private void llenarCampos()
        {

            if (grid.Rows.Count == 1)
            {
                return;
            }
            txtMicro.Text = grid.Rows[0].Cells["Inventario_Microfono"].Value.ToString();
            txtTipo.Text = grid.Rows[0].Cells["tipo"].Value.ToString();
            txtEstado.Text = grid.Rows[0].Cells["estado"].Value.ToString();
            txtMarca.Text = grid.Rows[0].Cells["marca"].Value.ToString();
            txtModelo.Text = grid.Rows[0].Cells["modelo"].Value.ToString();
            txtSerie.Text = grid.Rows[0].Cells["serie"].Value.ToString();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Telefono(), mainPrincipal.contenedor);
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Proyector(), mainPrincipal.contenedor);
        }
    }
}
