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
        public FORM_PELICULAS_UC()
        {
            InitializeComponent();
            c = new MyConexion("localhost", "clicktix", "root", "tiago26");


        }

        private void PELICULAS_UC_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Addpelicula_btn_Click(object sender, EventArgs e)
        {

            InsertarPelicula(input_titulo.Text,input_director.Text, input_duracion.Value,input_descripcion.Text,10,10,"imagen",input_estreno.Text);

        }

        private void input_genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void input_clasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }




        

        private bool InsertarPelicula(string titulo, string director, decimal duracion, string descripcion,int categoria, int clasificacion, string portada, string fechaEstreno)
        {

            try
            {
               
                string consulta = "INSERT INTO pelicula (titulo, director, duracion,descripcion, id_categoria, id_clasificacion, portada, fecha_estreno) " +
                                  "VALUES (@titulo, @director, @duracion,@descripcion ,@categoria, @clasificacion, @portada, @fechaEstreno)";
                c.AbrirConexion();
                using (MySqlCommand cmd = new MySqlCommand(consulta, c.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@director", director);
                    cmd.Parameters.AddWithValue("@duracion", duracion);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@id_categoria", categoria);
                    cmd.Parameters.AddWithValue("@id_clasificacion", clasificacion);
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
    }

   

   
}

