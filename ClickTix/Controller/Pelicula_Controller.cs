using ClickTix.Conexion;
using ClickTix.Modelo;
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
        public static List<Pelicula> obtenerTodos()
        {
            List<Pelicula> peliculas = new List<Pelicula>();
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();

                string query = "SELECT id,portada,titulo, director FROM pelicula";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pelicula pelicula = new Pelicula();

                            pelicula.id = reader.GetInt32("id");
                            pelicula.imagen = reader.GetString("portada");
                            pelicula.titulo = reader.GetString("titulo");
                            pelicula.imagen = reader.GetString("portada");
                            pelicula.director = reader.GetString("director");

                            peliculas.Add(pelicula);
                        }
                    }
                }
                ManagerConnection.CloseConnection();

            }

            return peliculas;
        }


        public static List<Pelicula> obtenerTodosCartelera()
        {
            List<Pelicula> peliculas = new List<Pelicula>();
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();

                string query = "select p.id, p.titulo,p.portada, p.director from pelicula p inner join funcion f on f.id_pelicula = p.id inner join sala s on f.id_sala = s.id where s.id_sucursal = @id_sucursal and  f.fecha > NOW();";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@id_sucursal", Program.logeado.Id_sucursal);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pelicula pelicula = new Pelicula();

                            pelicula.id = reader.GetInt32("id");
                            pelicula.imagen = reader.GetString("portada");
                            pelicula.titulo = reader.GetString("titulo");
                            pelicula.director = reader.GetString("director");

                            peliculas.Add(pelicula);
                        }
                    }
                }
                ManagerConnection.CloseConnection();

            }

            return peliculas;
        }
        public static string ObtenerNombrePeliculaPorID(int idPelicula)
        {
            string nombrePelicula = "";
            ManagerConnection.OpenConnection();
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                string query = "SELECT titulo FROM pelicula WHERE id = @idPelicula";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@idPelicula", idPelicula);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        nombrePelicula = result.ToString();
                    }
                }
            }
            ManagerConnection.CloseConnection();

            return nombrePelicula;

        }

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
