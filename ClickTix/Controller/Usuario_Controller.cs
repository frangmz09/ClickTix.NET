using ClickTix.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickTix.Conexion
{
    class Usuario_Controller
    {
        public static bool autenticar(string user, string pass, bool hasheado)
        {
            MyConexion.AbrirConexion();
            Usuario usuario = null;
            string query = "select * from usuario_sistema where usuario = @user and pass = @pass";

            MySqlCommand cmd = new MySqlCommand(query, MyConexion.ObtenerConexion());
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);

            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                            usuario = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), "", reader.GetString(5),
                                reader.GetInt32(6), reader.GetInt32(4));
                        }
                    }
                }

                MyConexion.conexion.Close();

                if (usuario != null)
                {
                    Program.logeado = usuario;
                    return true; 
                }
                else
                {
                    return false; 
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la consulta: " + ex.Message);
            }
        }






    }
}
