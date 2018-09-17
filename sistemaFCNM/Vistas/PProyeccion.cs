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
    public partial class PProyeccion : Form
    {
        public PProyeccion()
        {
            InitializeComponent();
        }

        private void PProyeccion_Load(object sender, EventArgs e)
        {
            if (FuncionesUtiles.masdetallesActiva || FuncionesUtiles.siguienteActiva)
            {
                FuncionesUtiles.masdetallesActiva = false;
            }
            else
            {
                FuncionesUtiles.INVENTARIO_EQUIPO = Microsoft.VisualBasic.Interaction.InputBox("Inventario Equipo", "Registrar Busqueda", "", 600);

            }


            string sql = "select e.id_Equipo, pro.Inventario_PantallaProyeccion,pro.Dimensiones,car.estado,car.marca," +
                "car.modelo,car.serie from  Equipo e, Pantalla_Proyeccion pro," +
                "Caracteristicas car where " +
                " e.PantallaProyeccion=pro.ID and car.id_caracteristica = pro.caracteristicas and e.id_Equipo = '" + FuncionesUtiles.INVENTARIO_EQUIPO + "'; ";

            Datos.llenarGrid(sql, grid);
            llenarCampos();
        }

        private void llenarCampos()
        {

            if (grid.Rows.Count == 1)
            {
                return;
            }
            txtEquipo.Text = grid.Rows[0].Cells["id_Equipo"].Value.ToString();
            txtPproyeccion.Text = grid.Rows[0].Cells["Inventario_PantallaProyeccion"].Value.ToString();
            txtDimensiones.Text = grid.Rows[0].Cells["Dimensiones"].Value.ToString();
            txtEstado.Text = grid.Rows[0].Cells["estado"].Value.ToString();
            txtMarca.Text = grid.Rows[0].Cells["marca"].Value.ToString();
            txtModelo.Text = grid.Rows[0].Cells["modelo"].Value.ToString();
            txtSerie.Text = grid.Rows[0].Cells["serie"].Value.ToString();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Radio(), mainPrincipal.contenedor);
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            FuncionesUtiles.abrirVentanas(new Telefono(), mainPrincipal.contenedor);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string sql = "update va set va.Inventario_PantallaProyeccion='" + txtPproyeccion.Text + "', va.Dimensiones = '" + txtDimensiones.Text + "'" +
              " from Equipo e,Pantalla_Proyeccion va where e.PantallaProyeccion = va.ID and e.id_Equipo = '" + txtEquipo.Text + "';";


            Datos.Insertar(sql);

            sql = "update car set car.estado='" + txtEstado.Text + "',car.marca = '" + txtMarca.Text + "',car.modelo='" + txtModelo.Text + "',car.serie='" + txtSerie.Text + "' " +
                  " from Equipo e,Pantalla_Proyeccion va, Caracteristicas car " +
                  " where e.PantallaProyeccion = va.ID and car.id_caracteristica = va.Caracteristicas and e.id_Equipo = '" + txtEquipo.Text + "'; ";


            Datos.Insertar(sql);
        }
    }
}
