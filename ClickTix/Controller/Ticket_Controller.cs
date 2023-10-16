using ClickTix.Conexion;
using ClickTix.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickTix.Controller
{
    internal class Ticket_Controller
    {
        public static Ticket buscarTicketPorId(int idTicket)
        {

            Ticket ticketAuxiliar = new Ticket();

            ManagerConnection.OpenConnection();

            string query = "select * from ticket where id=@id";

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@id", idTicket);

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ticketAuxiliar.id = reader.GetInt32(0);
                        ticketAuxiliar.id_funcion = reader.GetInt32(1);
                        ticketAuxiliar.fecha = reader.GetDateTime(2);
                        ticketAuxiliar.fila = reader.GetInt32(3);
                        ticketAuxiliar.columna = reader.GetInt32(4);
                        ticketAuxiliar.precio = reader.GetDouble(5);



                    }

                    reader.Close();

                }
            }

            ManagerConnection.CloseConnection();
            return ticketAuxiliar;
        }
        public static bool crearTicket(int idFuncion, int filas, int columnas)
        {
            string query = "INSERT INTO ticket (id, id_funcion, fecha, fila, columna, precio_al_momento) " +
                           "VALUES (@id,@id_funcion, @fecha ,@filas, @columnas, @precio_al_momento)";

            MySqlCommand cmd = new MySqlCommand(query, ManagerConnection.getInstance());

            cmd.Parameters.AddWithValue("@id", ObtenerMaxIdTicket() + 1);
            cmd.Parameters.AddWithValue("@id_funcion", idFuncion);
            cmd.Parameters.AddWithValue("@filas", filas);
            cmd.Parameters.AddWithValue("@columnas", columnas);
            cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
            cmd.Parameters.AddWithValue("@precio_al_momento", Funcion_Controller.obtenerPrecioFuncion(idFuncion));
            try
            {
                ManagerConnection.OpenConnection();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el ticket: " + ex.Message);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }
        }
        public static int ObtenerMaxIdTicket()
        {
            ManagerConnection.OpenConnection();
            int maxId = 0;
            string query = "SELECT MAX(id) FROM ticket";

            MySqlCommand cmd = new MySqlCommand(query, ManagerConnection.getInstance());

            try
            {
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    maxId = Convert.ToInt32(result);
                }

                return maxId;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el máximo ID de sala: " + ex.Message);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }
        }
    }
}
