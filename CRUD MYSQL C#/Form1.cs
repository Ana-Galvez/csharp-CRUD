using System;
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

        private void btnprueba_Click(object sender, EventArgs e)
        {
            Clases.ClaseConexion objetoConexion = new Clases.ClaseConexion();
            objetoConexion.EstablecerConexion();
        }
    }
}
