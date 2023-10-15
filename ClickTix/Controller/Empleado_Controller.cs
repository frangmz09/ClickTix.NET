using ClickTix.Conexion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Modelo
{
    internal class Empleado_Controller
    {
        public static string nombreSucursalFuncion(int idFuncion) {
            string sucursalNombre="";

            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                string query = "select sucursal.nombre from sala inner join sucursal on sucursal.id = sala.id_sucursal inner join funcion on funcion.id_sala = sala.id where funcion.id = @idFuncion;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    mysqlConnection.Open();

                    command.Parameters.AddWithValue("@idFuncion", idFuncion);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        sucursalNombre = reader.GetString(0);
                    }
                    reader.Close();
                    mysqlConnection.Close();
                }


            }
            return sucursalNombre;
        }


        public static string cuitSucursalFuncion(int idFuncion)
        {
            string cuitSucursal = "";

            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                string query = "select sucursal.cuit from sala inner join sucursal on sucursal.id = sala.id_sucursal inner join funcion on funcion.id_sala = sala.id where funcion.id = @idFuncion;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    mysqlConnection.Open();

                    command.Parameters.AddWithValue("@idFuncion", idFuncion);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cuitSucursal = reader.GetString(0);
                    }
                    reader.Close();
                    mysqlConnection.Close();
                }


            }
            return cuitSucursal;
        }
        public static bool CrearEmpleado(EmpleadoA empleado)
        {
            string query = "INSERT INTO usuario_sistema (id,nombre, apellido, pass, id_sucursal, usuario) " +
                           "VALUES (@id,@nombre, @apellido, @pass, @id_sucursal, @usuario)";

            MySqlCommand cmd = new MySqlCommand(query, MyConexion.conexion);
            cmd.Parameters.AddWithValue("@id", ObtenerMaxIdEmpleado() + 1);
            cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@apellido", empleado.Apellido);
            cmd.Parameters.AddWithValue("@pass", empleado.Pass);
            cmd.Parameters.AddWithValue("@id_sucursal", empleado.Id_Sucursal);
            cmd.Parameters.AddWithValue("@usuario", empleado.Usuario);

            try
            {
                MyConexion.conexion.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
            finally
            {
                MyConexion.conexion.Close();
            }
        }


        public static int ObtenerMaxIdEmpleado()
        {
            MyConexion.AbrirConexion();
            int maxId = 0;
            string query = "SELECT MAX(id) FROM usuario_sistema";

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
                throw new Exception("Error al obtener el máximo ID de empleado: " + ex.Message);
            }
            finally
            {
                MyConexion.conexion.Close();
            }
        }

        public static bool ActualizarEmpleado(EmpleadoA empleado)
        {
            MyConexion.AbrirConexion();
            string query = "UPDATE usuario_sistema " +
                           "SET nombre = @nombre, apellido = @apellido, pass = @pass, id_sucursal = @id_sucursal, usuario = @usuario " +
                           "WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(query, MyConexion.conexion);
            cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@apellido", empleado.Apellido);
            cmd.Parameters.AddWithValue("@pass", empleado.Pass);
            cmd.Parameters.AddWithValue("@id_sucursal", empleado.Id_Sucursal);
            cmd.Parameters.AddWithValue("@usuario", empleado.Usuario);
            cmd.Parameters.AddWithValue("@id", empleado.Id);

            try
            {
                int filasActualizadas = cmd.ExecuteNonQuery();

                return filasActualizadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el empleado: " + ex.Message);
            }
            finally
            {
                MyConexion.conexion.Close();
            }
        }



        public static void Empleado_Load(DataGridView tabla)
        {
            MyConexion.AbrirConexion();

            string query = "SELECT id, nombre, apellido, pass, id_sucursal, usuario FROM usuario_sistema";

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







        public static bool EliminarEmpleado(int id)
        {
            try
            {
                using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
                {
                    mysqlConnection.Open();
                    string query = "DELETE FROM usuario_sistema WHERE id = @id";

                    using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró al empleado a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar al empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                MyConexion.conexion.Close();
            }
        }


        public static int ObtenerIdSucursal(string nombreSucursal)
        {
            int idSucursal = -1; 

            try
            {
                using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
                {
                    mysqlConnection.Open();
                    string query = "SELECT id FROM sucursal WHERE nombre = @nombre";

                    using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombreSucursal);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            idSucursal = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID de la sucursal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MyConexion.conexion.Close();
            }

            return idSucursal;
        }































































    }
}
