﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MYSQL_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void btnprueba_Click(object sender, EventArgs e)
        //{
        //    Clases.ClaseConexion objetoConexion = new Clases.ClaseConexion();
        //    objetoConexion.EstablecerConexion();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            Clases.ClaseAlumnos objetoAlumnos = new Clases.ClaseAlumnos();
            objetoAlumnos.MostrarAlumnos(dgvalumnos);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Clases.ClaseAlumnos objetoAlumnos = new Clases.ClaseAlumnos();
            objetoAlumnos.guardarAlumnos(txtnombres, txtapellido);
            objetoAlumnos.MostrarAlumnos(dgvalumnos);
            objetoAlumnos.limpiarTextBox(txtid, txtnombres, txtapellido);
        }

        private void dgvalumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.ClaseAlumnos objetoAlumnos = new Clases.ClaseAlumnos();
            objetoAlumnos.seleccionarAlumnos(dgvalumnos, txtid, txtnombres, txtapellido);

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Clases.ClaseAlumnos objetoAlumnos = new Clases.ClaseAlumnos();
            objetoAlumnos.modificarAlumno(txtid, txtnombres, txtapellido);
            objetoAlumnos.MostrarAlumnos(dgvalumnos);
            objetoAlumnos.limpiarTextBox(txtid, txtnombres, txtapellido);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Clases.ClaseAlumnos objetoAlumnos = new Clases.ClaseAlumnos();
            objetoAlumnos.eliminarAlumno(txtid);
            objetoAlumnos.MostrarAlumnos(dgvalumnos);
            objetoAlumnos.limpiarTextBox(txtid, txtnombres, txtapellido);
        }
        private void btnmostrartabla_Click(object sender, EventArgs e)
        {
            Clases.ClaseAlumnos objetoAlumnos = new Clases.ClaseAlumnos();
            objetoAlumnos.MostrarAlumnos(dgvalumnos);
        }

        private void txtbuscarnombre_TextChanged(object sender, EventArgs e)
        {
            Clases.ClaseAlumnos objetoAlumnos = new Clases.ClaseAlumnos();
            objetoAlumnos.buscarAlumnoXNombre(dgvalumnos, txtbuscarnombre);
            objetoAlumnos.limpiarTextBox(txtid, txtnombres, txtapellido);
        }

        private void txtbuscarapellido_TextChanged(object sender, EventArgs e)
        {
            Clases.ClaseAlumnos objetoAlumnos = new Clases.ClaseAlumnos();
            objetoAlumnos.buscarAlumnoXApellido(dgvalumnos, txtbuscarapellido);
            objetoAlumnos.limpiarTextBox(txtid, txtnombres, txtapellido);
        }
    }
}
