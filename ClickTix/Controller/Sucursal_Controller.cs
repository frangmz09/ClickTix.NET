using ClickTix.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Conexion
{
     class Sucursal_Controller
    {


        public static bool CrearSucursal(Sucursal sucursal)
        {
            string query = "INSERT INTO sucursal (id, nombre, cuit,direccion,numerosalas) " +
                           "VALUES (@id, @nombre, @cuit,@direccion,@numerosalas)";

            MySqlCommand cmd = new MySqlCommand(query, MyConexion.conexion);
            cmd.Parameters.AddWithValue("@id",ObtenerMaxIdSucursal()+1);
            cmd.Parameters.AddWithValue("@nombre", sucursal.nombre);
            cmd.Parameters.AddWithValue("@cuit", sucursal.cuit);
            cmd.Parameters.AddWithValue("@direccion", sucursal.direccion);
            cmd.Parameters.AddWithValue("@numerosalas", sucursal.numerosalas);
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

        public static int ObtenerMaxIdSucursal()
        {
            int maxId = 0;
            string query = "SELECT MAX(id) FROM sucursal";

            MySqlCommand cmd = new MySqlCommand(query, MyConexion.conexion);

            try
            {
                if (MyConexion.conexion.State != ConnectionState.Open)
                {
                    MyConexion.conexion.Open();
                }

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    maxId = Convert.ToInt32(result);
                }

                return maxId;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el máximo ID: " + ex.Message);
            }
            finally
            {
                if (MyConexion.conexion.State == ConnectionState.Open)
                {
                    MyConexion.conexion.Close();
                }
            }
        }

        public static bool ActualizarSucursal(Sucursal sucursal)
        {
            string query = "UPDATE sucursal " +
                           "SET nombre = @nombre, cuit = @cuit, direccion = @direccion, numerosalas = @numerosalas " +
                           "WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(query, MyConexion.conexion);

            cmd.Parameters.AddWithValue("@id", sucursal.id);
            cmd.Parameters.AddWithValue("@nombre", sucursal.nombre);
            cmd.Parameters.AddWithValue("@cuit", sucursal.cuit);
            cmd.Parameters.AddWithValue("@direccion", sucursal.direccion);
            cmd.Parameters.AddWithValue("@numerosalas", sucursal.numerosalas);

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

        public static void Sucursal_Load(DataGridView tabla)
        {
            try
            {
                MyConexion.conexion.Open();


                string query = "SELECT  id, nombre, cuit,direccion,numerosalas FROM sucursal";

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
            catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            finally
            {
                MyConexion.conexion.Close();
            }
            
        }


        public static bool EliminarRegistroSucursal(int id)
        {
            try
            {
                using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
                {
                    mysqlConnection.Open();
                    string query = "DELETE FROM sucursal WHERE id = @id";

                    using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        int rowsAffected = command.ExecuteNonQuery();

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

        


    }
}
