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
    public partial class FORM_PELICULAS_UC : UserControl
    {

        MyConexion c ;
        private int id;

        public FORM_PELICULAS_UC()
        {
            InitializeComponent();
            c = new MyConexion("localhost", "clicktix", "root", "");


        }

 

            public FORM_PELICULAS_UC(int id)
            {
                InitializeComponent();
                int peliculaID = id; 
                                
                CargarDatosPelicula(peliculaID);
            }



        private void FORM_PELICULAS_UC_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Addpelicula_btn_Click(object sender, EventArgs e)
        {

            int id = GetMaxID() + 1;

            InsertarPelicula(id,input_titulo.Text,input_director.Text, input_duracion.Value,input_descripcion.Text,1,1,"imagen",input_estreno.Value);

        }

        private void input_genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void input_clasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }




        

        private bool InsertarPelicula(int id,string titulo, string director, decimal duracion, string descripcion,int categoria, int clasificacion, string portada, DateTime fechaEstreno)
        {

            try
            {
               
                string consulta = "INSERT INTO pelicula (id,titulo, director, duracion,descripcion, id_categoria, id_clasificacion, portada, fecha_estreno) " +
                                  "VALUES (@id,@titulo, @director, @duracion,@descripcion ,@categoria, @clasificacion, @portada, @fechaEstreno)";
                c.AbrirConexion();
                using (MySqlCommand cmd = new MySqlCommand(consulta, c.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@director", director);
                    cmd.Parameters.AddWithValue("@duracion", duracion);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@clasificacion", clasificacion);
                    cmd.Parameters.AddWithValue("@portada", portada);
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


        



        private void back_pelicula_Click(object sender, EventArgs e)
        {
            ABM_PELICULAS_UC abmpeliculas = new ABM_PELICULAS_UC();
            Index_Admin.addUserControl(abmpeliculas);
        }

        public int GetMaxID()
        {
            int maxID = -1; 
            
            
                try
                {
                c.AbrirConexion();

                    string query = "SELECT MAX(id) FROM pelicula"; 

                    MySqlCommand command = new MySqlCommand(query, c.ObtenerConexion());
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


        private bool ActualizarPelicula(int id, string titulo, string director, decimal duracion, string descripcion, int categoria, int clasificacion, string portada, DateTime fechaEstreno)
        {
            try
            {
                string consulta = "UPDATE pelicula SET titulo = @titulo, director = @director, duracion = @duracion, descripcion = @descripcion, id_categoria = @categoria, id_clasificacion = @clasificacion, portada = @portada, fecha_estreno = @fechaEstreno WHERE id = @id";

                c.AbrirConexion();
                using (MySqlCommand cmd = new MySqlCommand(consulta, c.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@director", director);
                    cmd.Parameters.AddWithValue("@duracion", duracion);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@clasificacion", clasificacion);
                    cmd.Parameters.AddWithValue("@portada", portada);
                    cmd.Parameters.AddWithValue("@fechaEstreno", fechaEstreno);

                    int filasActualizadas = cmd.ExecuteNonQuery();

                    if (filasActualizadas > 0)
                    {
                        return true; // Actualización exitosa
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún registro para actualizar.");
                        return false; // No se encontraron registros para actualizar
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                return false; // Error en la actualización
            }
        }

        private void CargarDatosPelicula(int peliculaID)
        {
            try
            {
               
                string consulta = "SELECT titulo, director, duracion, descripcion, id_categoria, id_clasificacion, portada, fecha_estreno FROM pelicula WHERE id = @id";

                
                c.AbrirConexion();

                using (MySqlCommand cmd = new MySqlCommand(consulta, c.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@id", peliculaID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            
                            input_titulo.Text = reader["titulo"].ToString();
                            input_director.Text = reader["director"].ToString();
                            input_duracion.Value = Convert.ToDecimal(reader["duracion"]);
                            input_descripcion.Text = reader["descripcion"].ToString();
                            
                            if (DateTime.TryParse(reader["fecha_estreno"].ToString(), out DateTime fechaEstreno))
                            {
                                input_estreno.Value = fechaEstreno;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la película con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la película: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

   

   
}

