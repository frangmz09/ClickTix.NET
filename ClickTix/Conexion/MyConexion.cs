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
        private MySqlConnection conexion;

        public MyConexion(string servidor, string baseDeDatos, string usuario, string contraseña)
        {
            // Configura la cadena de conexión a MySQL
            cadenaConexion = $"Server={servidor};Database={baseDeDatos};Uid={usuario};Pwd={contraseña};";
            conexion = new MySqlConnection(cadenaConexion);
        }

        public void AbrirConexion()
        {
            try
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();

                    MessageBox.Show("Conexión abierta.");
                    Console.WriteLine("Conexión abierta.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                    Console.WriteLine("Conexión cerrada.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }

        public MySqlConnection ObtenerConexion()
        {
            return conexion;
        }
    }


}
