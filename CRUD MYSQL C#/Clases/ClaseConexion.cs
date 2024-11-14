using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MYSQL_C_.Clases
{
    internal class ClaseConexion
    {
        MySqlConnection conexion = new MySqlConnection();

        static string server = "localhost";
        static string user = "root";
        static string password = "yanina1982";
        static string port = "3306";
        static string db = "escuela";

        string cadenaConexion = "server: " + server + ";" + "port: " + port + ";" + "user: " + user + ";" + "password: " + password + ";" + "database: " + db + ";";

        public MySqlConnection EstablecerConexion(){
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                MessageBox.Show("Conexión EXITOSA");
            }
            catch(Exception ex) {
                 MessageBox.Show("No se puedo conectar a la base de datos. Error: " + ex.ToString());
            }
            return conexion;
        }

        public void CerrarConexion()
        {
            conexion.Close();
        }
    }
}
