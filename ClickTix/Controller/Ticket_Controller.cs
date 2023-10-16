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
    }
}
