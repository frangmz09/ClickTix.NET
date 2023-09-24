using ClickTix.Conexion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickTix.Modelo
{
    public class Asiento_Controller
    {
        public static List<Asiento> obtenerPorFuncion(int id_funcion) {

            List<Asiento> list = new List<Asiento>();

            MyConexion c = new MyConexion("localhost", "clicktix", "root", "");


            using (MySqlConnection mysqlConnection = c.ObtenerConexion()) {
                mysqlConnection.Open();
                string query = "SELECT * FROM asiento where asiento.id_funcion = @idfuncion;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection)) {

                    command.Parameters.AddWithValue("@idfuncion", id_funcion);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Asiento auxiliar = new Asiento();
                        auxiliar.Id = reader.GetInt32(0);
                        auxiliar.Fila = reader.GetInt32(1);
                        auxiliar.Columna = reader.GetInt32(3);
                        if (reader.GetInt32(2)== 1)
                        {
                            auxiliar.Disponible = true;                           
                        }
                        else
                        {
                            auxiliar.Disponible = false;
                        }
                        auxiliar.Id_Funcion = reader.GetInt32(4);
                        list.Add(auxiliar);
                    }

                    reader.Close();
                    mysqlConnection.Close();



                }


            }
            return list;
        }
    }
}
