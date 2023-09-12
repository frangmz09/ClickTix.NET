using ClickTix.Conexion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.UserControls
{
    public partial class PELICULAS_UC : UserControl
    {
        MySqlConnection conexion = ConexionMySql.Instancia.ObtenerConexion();

        public PELICULAS_UC()
        {
            InitializeComponent();

            
        }

        private void PELICULAS_UC_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Addpelicula_btn_Click(object sender, EventArgs e)
        {
            InsertarPelicula("ok", "ok", 123, 1, 1, "ok", 123);
        }

        private void input_genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboBox("generos",input_genero);
        }

        private void input_clasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            LlenarComboBox("clasificacion",input_clasificacion);
        }




        private void LlenarComboBox(string nombreTabla, ComboBox comboBox)
        {
            try
            {
               

                    string query = "SELECT nombre FROM "+nombreTabla;

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string item = reader["nombre"].ToString();
                                comboBox.Items.Add(item);
                            }
                        }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
            }
        }

        private bool InsertarPelicula(string titulo, string director, int duracion, int genero, int clasificacion, string imagen, int fechaEstreno)
        {
            try
            {
               
                string consulta = "INSERT INTO peliculas (titulo, director, duracion, genero, clasificacion, imagen, fecha_de_estreno) " +
                                  "VALUES (@titulo, @director, @duracion, @genero, @clasificacion, @imagen, @fechaEstreno)";
                
                using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@director", director);
                    cmd.Parameters.AddWithValue("@duracion", duracion);
                    cmd.Parameters.AddWithValue("@genero", genero);
                    cmd.Parameters.AddWithValue("@clasificacion", clasificacion);
                    cmd.Parameters.AddWithValue("@imagen", imagen);
                    cmd.Parameters.AddWithValue("@fechaEstreno", fechaEstreno);

                    cmd.ExecuteNonQuery();
                    return true; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el registro: " + ex.Message);
                return false; 
            }
           
        }





    }
}
