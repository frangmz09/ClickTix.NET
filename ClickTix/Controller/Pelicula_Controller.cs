using ClickTix.Conexion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Controller
{
    internal class Pelicula_Controller
    {


        public static string obtenerFileName(int idPelicula)
        {

            string fileName = "";
            try
            {

                string consulta = "SELECT portada FROM pelicula WHERE id = @id";


                ManagerConnection.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(consulta, ManagerConnection.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@id", idPelicula);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            fileName = reader.GetString(0);

                        }
                        else
                        {
                            MessageBox.Show("No se encontró la película con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la película: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }

            return fileName;
        }
        public static int obtenerIdPorNombre(string nombrePelicula)
        {

            int idRetorno = 0;
            try
            {

                string consulta = "SELECT id FROM pelicula WHERE titulo = @nombrePelicula";


                ManagerConnection.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(consulta, ManagerConnection.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@nombrePelicula", nombrePelicula);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            idRetorno = reader.GetInt32(0);

                        }
                        else
                        {
                            MessageBox.Show("No se encontró la película con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la película: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }

            return idRetorno;
        }
    }
}
