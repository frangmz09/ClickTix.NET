using ClickTix.Conexion;
using Google.Protobuf.WellKnownTypes;
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
        public static int ObtenerTotalAsientosPorFuncion(int idFuncion)
        {
            int totalAsientos = 0;

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();

                string countQuery = "SELECT COUNT(*) FROM asiento WHERE asiento.id_funcion = @idfuncion;";

                using (MySqlCommand countCommand = new MySqlCommand(countQuery, mysqlConnection))
                {
                    countCommand.Parameters.AddWithValue("@idfuncion", idFuncion);
                    totalAsientos = Convert.ToInt32(countCommand.ExecuteScalar());
                }

                ManagerConnection.CloseConnection();

            }

            return totalAsientos;
        }

        public static List<Asiento> obtenerPorFuncion(int id_funcion) {

            List<Asiento> list = new List<Asiento>();



            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance()) {
                ManagerConnection.OpenConnection();
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
                        if (reader.GetInt32(2) == 1)
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
                    ManagerConnection.CloseConnection();



                }


            }
            return list;
        }

        public static bool crearDisponibilidad(Funcion funcion)
        {
            int filas = 0;
            int columnas = 0;
            ManagerConnection.OpenConnection();
            Trace.WriteLine("Datos funcion");

            Trace.WriteLine(funcion.Id_Sala);
            Trace.WriteLine(funcion.Id);
            try
            {
                using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
                {

                    string consulta =
                        "select sala.filas, sala.columnas from funcion inner join sala on funcion.id_sala = sala.id where funcion.id = @id_funcion;";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, mysqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@id_funcion", funcion.Id);
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

            ManagerConnection.CloseConnection();
            return true;

        }
        public static int ObtenerFilaDelAsiento(int idAsiento)
        {
            int fila;
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();

                string consulta = "SELECT fila FROM asiento WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(consulta, mysqlConnection))
                {
                    cmd.Parameters.AddWithValue("@id", idAsiento);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            fila = reader.GetInt32(0);

                        }
                        else
                        {
                            fila = 0;
                        }
                        ManagerConnection.CloseConnection();
                        return fila;
                    }
                }
            }
        }
        public static int ObtenerColumnaDelAsiento(int idAsiento)
        {
            int columna;
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();

                string consulta = "SELECT columna FROM asiento WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(consulta, mysqlConnection))
                {
                    cmd.Parameters.AddWithValue("@id", idAsiento);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            columna = reader.GetInt32(0);
                        }
                        else
                        {
                            columna = 0;
                        }
                    }
                }
                ManagerConnection.CloseConnection();
            }
            return columna;
        }
        public static bool insertAsiento(Asiento asiento) {


            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {

                string consulta = "INSERT INTO asiento (id,fila,disponible,columna,id_funcion) " +
                                      "VALUES (@id,@fila,@disponible,@columna,@id_funcion)";
                int id = GetMaxIDAsiento() + 1;
                using (MySqlCommand cmd = new MySqlCommand(consulta, mysqlConnection))
                {
                    ManagerConnection.OpenConnection();

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@fila", asiento.Fila);
                    cmd.Parameters.AddWithValue("@columna", asiento.Columna);
                    cmd.Parameters.AddWithValue("@disponible", 1);
                    cmd.Parameters.AddWithValue("@id_funcion", asiento.Id_Funcion);

                    cmd.ExecuteNonQuery();
                    ManagerConnection.CloseConnection();

                    return true;
                }
            }


        }

        public static bool OcuparAsiento(int idAsiento)
        {
            ManagerConnection.OpenConnection();
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                string consulta = "UPDATE asiento SET disponible = 0 WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(consulta, mysqlConnection))
                {
                    cmd.Parameters.AddWithValue("@id", idAsiento);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    ManagerConnection.CloseConnection();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

        }
        private static int GetMaxIDAsiento()
        {
            int maxID = -1;

            try
            {
                ManagerConnection.OpenConnection();

                string query = "SELECT MAX(id) FROM asiento";

                MySqlCommand command = new MySqlCommand(query, ManagerConnection.getInstance());
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
            ManagerConnection.CloseConnection();

            return maxID;
        }

        public static void borrarAsientosDeFuncion(int idFuncion) {

            try
            {
                ManagerConnection.OpenConnection();

                string query = "DELETE FROM asiento WHERE id_funcion = @IdFuncion";

                MySqlCommand command = new MySqlCommand(query, ManagerConnection.getInstance());
                command.Parameters.AddWithValue("@IdFuncion", idFuncion);

                int rowsAffected = command.ExecuteNonQuery();
                Trace.WriteLine($"Se eliminaron {rowsAffected} asientos vinculados a la función con ID {idFuncion}.");

            }
            catch (Exception ex)
            {

                Console.WriteLine( ex.Message);
            }

            ManagerConnection.CloseConnection();


        }
        public static int ObtenerAsientosDisponibles(int idFuncion)
        {
            int asientosDisponibles = 0;

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();

                string consulta = "SELECT COUNT(*) FROM asiento WHERE id_funcion = @idFuncion AND disponible = 1";

                using (MySqlCommand cmd = new MySqlCommand(consulta, mysqlConnection))
                {
                    cmd.Parameters.AddWithValue("@idFuncion", idFuncion);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        asientosDisponibles = Convert.ToInt32(result);
                    }
                }

                ManagerConnection.CloseConnection();
            }

            return asientosDisponibles;
        }

    }
}
