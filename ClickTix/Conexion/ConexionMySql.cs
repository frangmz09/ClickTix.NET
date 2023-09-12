using ClickTix.Conexion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Conexion
{
    
    internal class ConexionMySql
    {
        private static ConexionMySql instancia = null;
        private MySqlConnection conexion;

        private string servidor = "localhost";
        private string baseDeDatos = "boleteria";
        private string usuario = "root";
        private string contraseña = "tiago26";

        private ConexionMySql()
        {
            string cadenaConexion = $"Server={servidor};Database={baseDeDatos};Uid={usuario};Pwd={contraseña};";
            conexion = new MySqlConnection(cadenaConexion);
        }

        public static ConexionMySql Instancia
        {
            get
            {
                if (instancia == null)
                {
                    
                            instancia = new ConexionMySql();
                    
                }
                return instancia;
            }
        }

        public MySqlConnection ObtenerConexion()
        {
            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }
            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

    }
}