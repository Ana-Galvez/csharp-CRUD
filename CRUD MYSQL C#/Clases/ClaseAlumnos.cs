using MySql.Data.MySqlClient;
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
        public void guardarAlumnos(TextBox nombres,TextBox apellido)
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
        public void seleccionarAlumnos(DataGridView tablaAlumnos, TextBox id, TextBox nombres, TextBox apellido)
        {
            try
            {
                id.Text= tablaAlumnos.CurrentRow.Cells[0].Value.ToString();
                nombres.Text= tablaAlumnos.CurrentRow.Cells[1].Value.ToString();
                apellido.Text= tablaAlumnos.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo seleccionar la información. Error: " + ex.ToString());
            }
        }
        public void modificarAlumno(TextBox id,TextBox nombres, TextBox apellido)
        {
            try
            {
                ClaseConexion objetoConexion = new ClaseConexion();
                string query = "update alumnos set nombres='" +
                    nombres.Text + "' , apellido='" + apellido.Text + "' where id='" + id.Text+"';";
                MySqlCommand command = new MySqlCommand(query, objetoConexion.EstablecerConexion());
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Los datos se modificaron con ÉXITO");

                objetoConexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar la información. Error: " + ex.ToString());
            }
        }
        public void eliminarAlumno(TextBox id)
        {
            try
            {
                ClaseConexion objetoConexion = new ClaseConexion();
                string query = "delete from alumnos where id='" + id.Text + "';";
                MySqlCommand command = new MySqlCommand(query, objetoConexion.EstablecerConexion());
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Los datos se eliminaron con ÉXITO");

                objetoConexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la información. Error: " + ex.ToString());
            }
        }
        public void limpiarTextBox(TextBox id, TextBox nombres, TextBox apellido)
        {
            id.Text = "";
            nombres.Text = "";
            apellido.Text = "";
        }
        public void buscarAlumnoXNombre(TextBox buscarNombre)
        {
            try
            {
                ClaseConexion objetoConexion = new ClaseConexion();
                DataGridView tablaAlumnos = new DataGridView();
                DataTable dataTable = new DataTable();
                tablaAlumnos.DataSource = dataTable;
                DataView dv = dataTable.DefaultView;
                dv.RowFilter = string.Format("nombres like '%{0}%'",buscarNombre.Text);
                tablaAlumnos.DataSource = dv.ToTable();
                //string query = "select * from alumnos where nombres like '" + buscarNombre + "%';";

                objetoConexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la información solicitada. Error: " + ex.Message);
            }
        }
    }
}
