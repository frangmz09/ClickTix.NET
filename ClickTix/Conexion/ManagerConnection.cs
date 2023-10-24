using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Conexion
{
    internal class ManagerConnection
    {

        private static MySqlConnection connection;
        private static ManagerConnection instance;
        private static string cadenaConexion;


        private ManagerConnection(string servidor, string baseDeDatos, string usuario, string contraseña)
        {
            createInitialConnection(servidor,baseDeDatos,usuario,contraseña);
        }

        private void createInitialConnection(string servidor, string baseDeDatos, string usuario, string contraseña)
        {
            try
            {
                cadenaConexion = $"Server={servidor};Database={baseDeDatos};Uid={usuario};Pwd={contraseña}; convert zero datetime=True;";
                connection = new MySqlConnection(cadenaConexion);

            }
            catch (Exception e)
            {
                MessageBox.Show("Error en crear la conexion inicial de la Base de Datos");
                
            }
        }

        public static MySqlConnection getInstance()
        {

            if (instance == null)
            {
                instance = new ManagerConnection("localhost", "clicktix", "root", "");
            }
            return connection;
        }
        public static void OpenConnection()
        {
         
                if (connection != null && connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            

        }
        public static void CloseConnection()
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión a la base de datos: " + ex.Message);
            }
        }

    }
}
