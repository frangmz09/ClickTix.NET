using ClickTix.Conexion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Modelo
{
    internal class Empleado_Controller
    {
        public static List<EmpleadoA> BuscarEmpleados(string searchTerm)
        {
            List<EmpleadoA> empleados = new List<EmpleadoA>();

            try
            {
                using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
                {
                    ManagerConnection.OpenConnection();

                    string query = "SELECT u.id, u.nombre, u.apellido, u.usuario, u.is_admin, u.id_sucursal, s.nombre AS nombre_sucursal FROM usuario_sistema u JOIN sucursal s ON u.id_sucursal = s.id WHERE LOWER(u.nombre) LIKE @searchTerm OR LOWER(u.apellido) LIKE @searchTerm OR LOWER(s.nombre) LIKE @searchTerm";

                    using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                    {
                        command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm.ToLower() + "%");

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmpleadoA empleado = new EmpleadoA();

                                empleado.Id = reader.GetInt32("id");
                                empleado.Nombre = reader.GetString("nombre");
                                empleado.Apellido = reader.GetString("apellido");
                                empleado.Usuario = reader.GetString("usuario");
                                empleado.is_admin = reader.GetInt32("is_admin");
                                empleado.Id_Sucursal = reader.GetInt32("id_sucursal");

                                empleados.Add(empleado);
                            }
                        }
                    }
                }
                ManagerConnection.CloseConnection();

            }
            catch (Exception ex)
            {
            }

            return empleados;
        }
        public static List<EmpleadoA> obtenerTodos()
        {
            List<EmpleadoA> empleados = new List<EmpleadoA>();
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();

                string query = "SELECT id, nombre, apellido, usuario, is_admin, id_sucursal FROM usuario_sistema"; 

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmpleadoA empleado = new EmpleadoA();

                            empleado.Id = reader.GetInt32("id");
                            empleado.Nombre = reader.GetString("nombre");
                            empleado.Apellido = reader.GetString("apellido");
                            empleado.Usuario = reader.GetString("usuario");
                            empleado.is_admin = reader.GetInt32("is_admin");
                            empleado.Id_Sucursal = reader.GetInt32("id_sucursal");
                            
                            empleados.Add(empleado);
                        }
                    }
                }
                ManagerConnection.CloseConnection();

            }

            return empleados;
        }
        public static string nombreSucursalFuncion(int idFuncion) {
            string sucursalNombre="";

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                string query = "select sucursal.nombre from sala inner join sucursal on sucursal.id = sala.id_sucursal inner join funcion on funcion.id_sala = sala.id where funcion.id = @idFuncion;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    ManagerConnection.OpenConnection();

                    command.Parameters.AddWithValue("@idFuncion", idFuncion);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        sucursalNombre = reader.GetString(0);
                    }
                    reader.Close();
                    ManagerConnection.CloseConnection();
                }


            }
            return sucursalNombre;
        }


        public static string cuitSucursalFuncion(int idFuncion)
        {
            string cuitSucursal = "";

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                string query = "select sucursal.cuit from sala inner join sucursal on sucursal.id = sala.id_sucursal inner join funcion on funcion.id_sala = sala.id where funcion.id = @idFuncion;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    ManagerConnection.OpenConnection();

                    command.Parameters.AddWithValue("@idFuncion", idFuncion);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cuitSucursal = reader.GetString(0);
                    }
                    reader.Close();
                    ManagerConnection.CloseConnection();
                }


            }
            return cuitSucursal;
        }
        public static bool CrearEmpleado(EmpleadoA empleado)
        {
            string query = "INSERT INTO usuario_sistema (id,nombre, apellido, pass, id_sucursal, usuario, is_admin) " +
                           "VALUES (@id,@nombre, @apellido, @pass, @id_sucursal, @usuario, @is_admin)";

            MySqlCommand cmd = new MySqlCommand(query, ManagerConnection.getInstance()) ;
            cmd.Parameters.AddWithValue("@id", ObtenerMaxIdEmpleado() + 1);
            cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@apellido", empleado.Apellido);
            cmd.Parameters.AddWithValue("@pass", empleado.Pass);
            cmd.Parameters.AddWithValue("@id_sucursal", empleado.Id_Sucursal);
            cmd.Parameters.AddWithValue("@usuario", empleado.Usuario);
            cmd.Parameters.AddWithValue("@is_admin", empleado.is_admin);


            try
            {
                ManagerConnection.OpenConnection();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }
        }


        public static int ObtenerMaxIdEmpleado()
        {
            ManagerConnection.OpenConnection();
            int maxId = 0;
            string query = "SELECT MAX(id) FROM usuario_sistema";

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
                throw new Exception("Error al obtener el máximo ID de empleado: " + ex.Message);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }
        }

        public static bool ActualizarEmpleado(EmpleadoA empleado)
        {
            ManagerConnection.OpenConnection();
            string query = "UPDATE usuario_sistema " +
                           "SET nombre = @nombre, apellido = @apellido, pass = @pass, id_sucursal = @id_sucursal, usuario = @usuario, is_admin = @is_admin " +
                           "WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(query, ManagerConnection.getInstance());
            cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@apellido", empleado.Apellido);
            cmd.Parameters.AddWithValue("@pass", empleado.Pass);
            cmd.Parameters.AddWithValue("@id_sucursal", empleado.Id_Sucursal);
            cmd.Parameters.AddWithValue("@usuario", empleado.Usuario);
            cmd.Parameters.AddWithValue("@is_admin", empleado.is_admin);  // Asegúrate de que el objeto EmpleadoA tenga la propiedad Is_Admin
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
                ManagerConnection.CloseConnection();
            }
        }



        public static void Empleado_Load(DataGridView tabla)
        {
            ManagerConnection.OpenConnection();

            string query = "SELECT id, nombre, apellido, pass, id_sucursal, usuario FROM usuario_sistema";

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
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
                using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
                {
                    ManagerConnection.OpenConnection();
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
                ManagerConnection.CloseConnection();
            }
        }


        public static int ObtenerIdSucursal(string nombreSucursal)
        {
            int idSucursal2 = -1; 

                using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
                {
                ManagerConnection.OpenConnection();
                string query = "SELECT id FROM sucursal WHERE nombre = @nombreSucursal";

                    using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                    {
                        Trace.WriteLine(nombreSucursal);
                        command.Parameters.AddWithValue("@nombreSucursal", nombreSucursal);

                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {

                            idSucursal2 = reader.GetInt32(0);

                            Trace.WriteLine(reader.GetInt32(0));


                        }

                        reader.Close();
                    ManagerConnection.CloseConnection();
                }
                }
            


            return idSucursal2;
        }































































    }
}
