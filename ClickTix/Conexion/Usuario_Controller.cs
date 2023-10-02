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
                        reader.GetInt32(6), reader.GetInt32(4));

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

        

        


    }
}
