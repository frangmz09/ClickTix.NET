using ClickTix.Conexion;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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


            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion()) {
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

        public static bool crearDisponibilidad(Funcion funcion)
        {
            int filas = 0;
            int columnas = 0;
            MyConexion.conexion.Open();
            Trace.WriteLine("Datos funcion");

            Trace.WriteLine(funcion.Id_Sala);
            Trace.WriteLine(funcion.Id);
            try
            {
                using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
                {

                    string consulta =
                        "select sala.filas, sala.columnas from funcion inner join sala on funcion.id_sala = sala.id;;";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, mysqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@id_funcion", funcion.Id);
                        cmd.Parameters.AddWithValue("@id_sala", funcion.Id_Sala);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                        
                            filas = reader.GetInt32(0);
                            columnas = reader.GetInt32(1);

                        }

                        reader.Close();
                        mysqlConnection.Close();
                    }
                    Trace.WriteLine("Filas :" + filas);
                    Trace.WriteLine("Columnas :" + columnas);



                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());

            }


            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Asiento auxiliar = new Asiento();
                    auxiliar.Id = GetMaxIDAsiento() + 1;
                    auxiliar.Fila = i + 1;
                    auxiliar.Columna = j + 1;
                    auxiliar.Id_Funcion = funcion.Id;
                    insertAsiento(auxiliar);
                }
            }


            return true;

        }
        public static bool insertAsiento(Asiento asiento) {

       
                using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
                {

                    string consulta = "INSERT INTO asiento (id,fila,disponible,columna,id_funcion) " +
                                      "VALUES (@id,@fila,@disponible,@columna,@id_funcion)";
                    int id = GetMaxIDAsiento() + 1;
                    using (MySqlCommand cmd = new MySqlCommand(consulta, mysqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@fila", asiento.Fila);
                        cmd.Parameters.AddWithValue("@columna", asiento.Columna);
                        cmd.Parameters.AddWithValue("@disponible", 1);
                        cmd.Parameters.AddWithValue("@id_funcion", asiento.Id_Funcion);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            

        }

        private static int GetMaxIDAsiento()
        {
            int maxID = -1;

            try
            {
                MyConexion.AbrirConexion();

                string query = "SELECT MAX(id) FROM asiento";

                MySqlCommand command = new MySqlCommand(query, MyConexion.ObtenerConexion());
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    maxID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el ID máximo: " + ex.Message);
            }


            return maxID;
        }
    }
}
