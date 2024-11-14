﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MYSQL_C_.Clases
{
    internal class ClaseAlumnos
    {
        public void MostrarAlumnos(DataGridView tablaAlumnos)
        {
            try{
                ClaseConexion objetoConexion = new ClaseConexion();
                string query = "select * from alumnos";
                tablaAlumnos.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query,objetoConexion.EstablecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaAlumnos.DataSource = dt;
                objetoConexion.CerrarConexion();
            }
            catch(Exception ex) {
                MessageBox.Show("No se pudo mostrar la información de la tabla. Error: " + ex.ToString());
            }
        }
        public void guardarAlumnos(TextBox nombres,TextBox apellido
            )
        {
            try
            {
                ClaseConexion objetoConexion = new ClaseConexion();
                string query = "insert into alumnos (nombres,apellido)" + 
                    "values ('" + nombres.Text + "','" + apellido.Text + "');";
                MySqlCommand command = new MySqlCommand(query,objetoConexion.EstablecerConexion());
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Los datos se guardaron con ÉXITO");
                objetoConexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la información. Error: " + ex.ToString());
            }
        }
    }
}
