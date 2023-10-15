using ClickTix.Conexion;
using ClickTix.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Controller
{
    internal class Sala_Controller
    {

        public static bool CrearSala(Sala sala)
        {
            string query = "INSERT INTO sala (id,id_sucursal, filas, columnas, capacidad, nro_sala) " +
                           "VALUES (@id,@id_sucursal, @filas, @columnas, @capacidad, @nro_sala)";

            MySqlCommand cmd = new MySqlCommand(query, MyConexion.conexion);

            cmd.Parameters.AddWithValue("@id", ObtenerMaxIdSala() + 1);
            cmd.Parameters.AddWithValue("@id_sucursal", sala.Id_Sucursal);
            cmd.Parameters.AddWithValue("@filas", sala.Filas);
            cmd.Parameters.AddWithValue("@columnas", sala.Columnas);
            cmd.Parameters.AddWithValue("@capacidad", sala.Capacidad);
            cmd.Parameters.AddWithValue("@nro_sala", sala.Nro_Sala);
            try
            {
                MyConexion.conexion.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la sala: " + ex.Message);
            }
            finally
            {
                MyConexion.conexion.Close();
            }
        }

        public static bool ActualizarSala(Sala sala)
        {
            string query = "UPDATE sala " +
                           "SET filas = @filas, columnas = @columnas, capacidad = @capacidad, nro_sala = @nro_sala " +
                           "WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(query, MyConexion.conexion);

            cmd.Parameters.AddWithValue("@id", sala.Id);
            cmd.Parameters.AddWithValue("@filas", sala.Filas);
            cmd.Parameters.AddWithValue("@columna", sala.Columnas);
            cmd.Parameters.AddWithValue("@capacidad", sala.Capacidad);
            cmd.Parameters.AddWithValue("@nro_sala", sala.Nro_Sala);

            try
            {
                int filasActualizadas = cmd.ExecuteNonQuery();
                return filasActualizadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la sala: " + ex.Message);
            }
            finally
            {
                MyConexion.conexion.Close();
            }
        }

        public static void Salas_Load(DataGridView tabla, int id_sucursal)
        {
            try
            {
                MyConexion.conexion.Open();
                string query = "SELECT id, filas, columnas, capacidad, nro_sala FROM sala WHERE id_sucursal = @id_sucursal";
                using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
                {
                    using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                    {
                        command.Parameters.AddWithValue("@id_sucursal", id_sucursal);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        tabla.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las salas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MyConexion.conexion.Close();
            }
        }

        public static bool EliminarRegistroSala(int id)
        {
            try
            {
                using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
                {
                    mysqlConnection.Open();
                    string query = "DELETE FROM sala WHERE id = @id";
                    using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sala eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la sala a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la sala: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                MyConexion.conexion.Close();
            }
        }

        public static int ObtenerMaxIdSala()
        {
            MyConexion.AbrirConexion();
            int maxId = 0;
            string query = "SELECT MAX(id) FROM sala";

            MySqlCommand cmd = new MySqlCommand(query, MyConexion.conexion);

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
                MyConexion.conexion.Close();
            }
        }

        public static int ObtenerMaxNroSala(int id_sucursal)
        {
            MyConexion.AbrirConexion();
            int maxNroSala = 0;
            string query = "SELECT MAX(nro_sala) FROM sala WHERE id_sucursal = @id_sucursal";

            MySqlCommand cmd = new MySqlCommand(query, MyConexion.conexion);
            cmd.Parameters.AddWithValue("@id_sucursal", id_sucursal);

            try
            {
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    maxNroSala = Convert.ToInt32(result);
                }

                return maxNroSala;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el máximo número de sala: " + ex.Message);
            }
            finally
            {
                MyConexion.conexion.Close();
            }
        }



    }
}
