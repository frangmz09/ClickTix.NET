using ClickTix.Conexion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Modelo
{
    public class Funcion_Controller
    {


        public static void llenarCamposAddFuncion(ComboBox peliculas, ComboBox turnos, ComboBox sucursal, ComboBox dimension,ComboBox idioma) {
            llenarPeliculas(peliculas);
            llenarTurnos(turnos);
            llenarSucursales(sucursal);
            llenarDimensiones(dimension);
            llenarIdiomas(idioma);
        }


        private static void llenarPeliculas(ComboBox combobox_pelicula)
        {
            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                mysqlConnection.Open();
                string query = "SELECT * FROM pelicula;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        combobox_pelicula.Items.Add(reader.GetString(1));
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
        }

        public static int obtenerIdPelicula(ComboBox combobox_pelicula) {

            int idReturn=0;

            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                mysqlConnection.Open();
                string query = "SELECT id FROM pelicula where titulo=@nombre_seleccionado;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@nombre_seleccionado",combobox_pelicula.SelectedItem.ToString());
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        idReturn = reader.GetInt32(0);
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
            return idReturn;
        }
        public static int obtenerIdIdioma(ComboBox combobox_idioma) {
            int idReturn = 0;
            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                mysqlConnection.Open();
                string query = "SELECT id FROM idioma where idioma=@idioma_seleccionado;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@idioma_seleccionado", combobox_idioma.SelectedItem.ToString());
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        idReturn = reader.GetInt32(0);
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
            return idReturn;        
        }

        public static int obtenerIdDimension(ComboBox combobox_dimension)
        {
            int idReturn = 0;
            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                mysqlConnection.Open();
                string query = "SELECT id FROM dimension where dimension=@dimension_seleccionada;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@dimension_seleccionada", combobox_dimension.SelectedItem.ToString());
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        idReturn = reader.GetInt32(0);
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
            return idReturn;
        }
        public static int obtenerIdTurno(ComboBox combobox_turno)
        {

            int idReturn = 0;

            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                mysqlConnection.Open();
                string query = "SELECT id FROM turno where hora=@fecha_seleccionada;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@fecha_seleccionada", combobox_turno.SelectedItem.ToString());
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        idReturn = reader.GetInt32(0);
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
            return idReturn;
        }
        public static int obtenerIdSala(ComboBox combobox_sala, ComboBox combobox_sucursal) { 

            int idReturn =0;

            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                mysqlConnection.Open();
                string query = "select nro_sala, sala.id from sucursal " +
                    "inner join sala " +
                    "on sucursal.id = sala.id_sucursal " +
                    "where sucursal.nombre = @nombre_sucursal and sala.nro_sala=@sala_seleccionada;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@nombre_sucursal", combobox_sucursal.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@sala_seleccionada", combobox_sala.SelectedItem);

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        idReturn = reader.GetInt32(1);
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }

            return idReturn;
        }

        public static void llenarSalas(ComboBox combobox_sucursal, ComboBox combobox_sala)
        {
            combobox_sala.Items.Clear();
            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                mysqlConnection.Open();
                string query = "select nro_sala from sucursal " +
                    "inner join sala " +
                    "on sucursal.id = sala.id_sucursal " +
                    "where sucursal.nombre = @nombre_sucursal;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@nombre_sucursal", combobox_sucursal.SelectedItem.ToString());

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        combobox_sala.Items.Add(reader.GetInt32(0));
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
            combobox_sala.Enabled = true;
        }

        private static void llenarTurnos(ComboBox combobox_turno) {
            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                mysqlConnection.Open();
                string query = "SELECT * FROM turno;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        combobox_turno.Items.Add(reader.GetTimeSpan(1));
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
        }

        private static void llenarIdiomas(ComboBox combobox_idioma)
        {
            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                mysqlConnection.Open();
                string query = "SELECT * FROM idioma;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        combobox_idioma.Items.Add(reader.GetString(1));
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
        }
        private static void llenarDimensiones(ComboBox combobox_dimension)
        {
            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                mysqlConnection.Open();
                string query = "SELECT * FROM dimension;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        combobox_dimension.Items.Add(reader.GetString(1));
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
        }

        private static void llenarSucursales(ComboBox combobox_sucursal)
        {
            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                mysqlConnection.Open();
                string query = "SELECT * FROM sucursal where id <> 0;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        combobox_sucursal.Items.Add(reader.GetString(1));
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
        }
        public static int crearFuncion(Funcion funcion)
        {

            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {


                    string consulta = "INSERT INTO funcion (id,fecha,id_dimension,id_sala,id_pelicula,idioma_funcion,turno_id) " +
                                  "VALUES (@id,@fecha,@id_dimension,@id_sala,@id_pelicula,@idioma_funcion,@turno_id)";
                    int id = GetMaxIDFuncion()+1;
                    using (MySqlCommand cmd = new MySqlCommand(consulta, mysqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@fecha", funcion.Fecha);
                        cmd.Parameters.AddWithValue("@id_dimension", funcion.Id_Dimension);
                        cmd.Parameters.AddWithValue("@id_sala", funcion.Id_Sala);
                        cmd.Parameters.AddWithValue("@id_pelicula", funcion.Id_Pelicula);
                        cmd.Parameters.AddWithValue("@idioma_funcion", funcion.Id_Idioma);
                        cmd.Parameters.AddWithValue("@turno_id", funcion.Id_Turno);


                        cmd.ExecuteNonQuery();
                    }

                    return id;



            }


        }
        private static int GetMaxIDFuncion()
        {
            int maxID = -1;

            try
            {
                MyConexion.AbrirConexion();

                string query = "SELECT MAX(id) FROM funcion";

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


        public static void Funcion_Load(DataGridView tabla)
        {
            MyConexion.AbrirConexion();

            string query = "SELECT id , fecha, id_dimension as dimension , id_pelicula as pelicula , id_sala as sala ,idioma_funcion as idioma" +
                ", turno_id as turno FROM funcion";

            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    tabla.DataSource = dt;
                }
            }
        }

        public static bool EliminarRegistroFuncion(int id)
        {
            try
            {
                using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
                {
                    mysqlConnection.Open();

                    
                    string deleteAsientoQuery = "DELETE FROM asiento WHERE id_funcion = @id";
                    using (MySqlCommand deleteAsientoCommand = new MySqlCommand(deleteAsientoQuery, mysqlConnection))
                    {
                        deleteAsientoCommand.Parameters.AddWithValue("@id", id);
                        deleteAsientoCommand.ExecuteNonQuery();
                    }

                    
                    string deleteFuncionQuery = "DELETE FROM funcion WHERE id = @id";
                    using (MySqlCommand deleteFuncionCommand = new MySqlCommand(deleteFuncionQuery, mysqlConnection))
                    {
                        deleteFuncionCommand.Parameters.AddWithValue("@id", id);
                        int rowsAffected = deleteFuncionCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                MyConexion.conexion.Close();
            }
        }



        public static bool ActualizarFuncion(Funcion funcion)
        {
            string query = "UPDATE funcion " +
                           "SET id , fecha, id_dimension , id_pelicula  , id_sala  ,idioma_funcion, turno_id WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(query, MyConexion.conexion);

            cmd.Parameters.AddWithValue("@id",funcion.Id);
            cmd.Parameters.AddWithValue("@fecha", funcion.Fecha);
            cmd.Parameters.AddWithValue("@id_dimension", funcion.Id_Dimension);
            cmd.Parameters.AddWithValue("@id_sala", funcion.Id_Sala);
            cmd.Parameters.AddWithValue("@id_pelicula", funcion.Id_Pelicula);
            cmd.Parameters.AddWithValue("@idioma_funcion", funcion.Id_Idioma);
            cmd.Parameters.AddWithValue("@turno_id", funcion.Id_Turno);

            try
            {

                int filasActualizadas = cmd.ExecuteNonQuery();


                return filasActualizadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la sucursal: " + ex.Message);
            }
            finally
            {
                MyConexion.conexion.Close();
            }
        }




        






















    }
}
