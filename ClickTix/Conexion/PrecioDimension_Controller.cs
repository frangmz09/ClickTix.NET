﻿using ClickTix.Modelo;
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
    public class PrecioDimension_Controller
    {
        public static bool CrearDimension(PrecioDimension precioDimension)
        {
            string query = "INSERT INTO dimension (id, dimension, precio) " +
                           "VALUES (@id, @dimension, @precio)";

            MySqlCommand cmd = new MySqlCommand(query, MyConexion.conexion);
            cmd.Parameters.AddWithValue("@id", ObtenerMaxIdDimension() + 1);
            cmd.Parameters.AddWithValue("@dimension", precioDimension.dimension);
            cmd.Parameters.AddWithValue("@precio", precioDimension.precio);

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

        public static int ObtenerMaxIdDimension()
        {
            int maxId = 0;
            string query = "SELECT MAX(id) FROM dimension";

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
                throw new Exception("Error al obtener el máximo ID: " + ex.Message);
            }
            finally
            {
                MyConexion.conexion.Close();
            }
        }

        public static bool ActualizarDimension(PrecioDimension precioDimension)
        {
            string query = "UPDATE dimension " +
                           "SET dimension = @dimension, precio = @precio " +
                           "WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(query, MyConexion.conexion);
            cmd.Parameters.AddWithValue("@dimension", precioDimension.dimension);
            cmd.Parameters.AddWithValue("@precio", precioDimension.precio);
            cmd.Parameters.AddWithValue("@id", precioDimension.id);

            try
            {
                
                int filasActualizadas = cmd.ExecuteNonQuery();
                

                return filasActualizadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la dimensión: " + ex.Message);
            }
            finally
            {
                MyConexion.conexion.Close();
            }
        }

        public static void Dimension_Load(DataGridView tabla)
        {

            MyConexion.AbrirConexion();


            string query = "SELECT  id,dimension, precio FROM dimension";

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


        public static bool EliminarRegistroDimension(int id)
        {
            try
            {
                using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
                {
                    mysqlConnection.Open();
                    string query = "DELETE FROM dimension WHERE id = @id";

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
