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
        private static readonly object bloqueo = new object();
        private MySqlConnection conexion;

        private ConexionMySql()
        {
            
            string cadenaConexion = "Server=localhost;Database=boleteria;Uid=root;Pwd=;";
            conexion = new MySqlConnection(cadenaConexion);
        }
        public static ConexionMySql Instancia
        {
            get
            {
                if (instancia == null)
                {
                    lock (bloqueo)
                    {
                        if (instancia == null)
                        {
                            instancia = new ConexionMySql();
                        }
                    }
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