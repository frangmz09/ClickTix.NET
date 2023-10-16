using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Conexion
{
    internal class MyConexion
    {
        private string cadenaConexion;
        public static MySqlConnection conexion;

        public static MySqlConnection ObtenerConexion()
        {
            return conexion;
        }
    }


}
