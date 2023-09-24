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
            Usuario usuario = new Usuario();
            string query = "select * from usuario_sistema where usuario = @user and pass = @pass";

            MySqlCommand cmd = new MySqlCommand(query, MyConexion.ObtenerConexion());
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            if (hasheado )
            {
               
            }
            else 
            {
                //cmd.Parameters.AddWithValue("@pass", hc.PassHash(pass));
            }

            try
            {
               
                
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                    usuario = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),"", reader.GetString(5),
                        reader.GetInt32(6));

                }
                reader.Close();
                MyConexion.conexion.Close();
                Program.logeado = usuario;
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }

        public static bool crearUsuario(Usuario user)
        {
            string query = "INSERT INTO usuario_sistema VALUES" +
                "(@id, " +
                "@name, " +
                "@lastname, " + 
                "@pass, " +
                "@username, " +
                "@id_sucursal, " + 
                "@is_admin)";    

            MySqlCommand cmd = new MySqlCommand(query, MyConexion.conexion);
            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@name", user.Nombre);
            cmd.Parameters.AddWithValue("@lastname", user.Apellido); 
            cmd.Parameters.AddWithValue("@pass", user.Contraseña);
            cmd.Parameters.AddWithValue("@username", user.usuario);
            cmd.Parameters.AddWithValue("@id_sucursal", user.Id_sucursal);
            cmd.Parameters.AddWithValue("@is_admin", user.Is_admin);

            try
            {
                MyConexion.conexion.Open();
                cmd.ExecuteNonQuery();
                MyConexion.conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }

        public static int obtenerMaxId()
        {
            int MaxId =0;
            string query = "select max(id) from usuario_sistema;";

            MySqlCommand cmd = new MySqlCommand(query, MyConexion.conexion);

            try
            {
                MyConexion.conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MaxId = reader.GetInt32(0);
                }
                reader.Close();
                MyConexion.conexion.Close();
                return MaxId;
            }catch (Exception ex)
            {
                throw new Exception("Hay un error en la query" +ex.Message);
            }
        }

        internal static bool crearUsuario(object usuario)
        {
            throw new NotImplementedException();
        }
    }
}
