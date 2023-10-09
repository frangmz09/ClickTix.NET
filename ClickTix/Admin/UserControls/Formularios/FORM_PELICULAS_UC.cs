﻿using ClickTix.Conexion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.UserControls
{
    public partial class FORM_PELICULAS_UC : UserControl
    {

        MyConexion c;
        private int idDelPanel;
        Image ImagenCargada;

        public FORM_PELICULAS_UC()
        {
            InitializeComponent();
            c = new MyConexion("localhost", "clicktix", "root", "");
            this.addpelicula_btn.Click += new System.EventHandler(this.Addpelicula_btn_Click);

        }



        public FORM_PELICULAS_UC(int id)
        {

            this.idDelPanel = id;

            int peliculaID = id;
            c = new MyConexion("localhost", "clicktix", "root", "");
            InitializeComponent();
            addpelicula_btn.Click += new EventHandler(this.Addpelicula_btn_Click2);
            addpelicula_btn.Text = "modificar";
            this.title.Text = "INGRESE DATOS PARA ACTUALIZAR UNA PELICULA";


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

            InsertarPelicula(id, input_titulo.Text, input_director.Text, input_duracion.Value, input_descripcion.Text, 1, 1, "imagen", input_estreno.Value);

        }

        private void Addpelicula_btn_Click2(object sender, EventArgs e)
        {
            Trace.WriteLine("editt");
            int idpelicula = idDelPanel;
            MessageBox.Show("id : " + idpelicula);
            ActualizarPelicula(idpelicula, input_titulo.Text, input_director.Text, input_duracion.Value, input_descripcion.Text, 1, 1, "imagen", input_estreno.Value);

        }
        private void input_genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void input_clasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {


        }






        private bool InsertarPelicula(int id, string titulo, string director, decimal duracion, string descripcion, int categoria, int clasificacion, string portada, DateTime fechaEstreno)
        {

            try
            {

                string consulta = "INSERT INTO pelicula (id,titulo, director, duracion,descripcion, id_categoria, id_clasificacion, portada, fecha_estreno) " +
                                  "VALUES (@id,@titulo, @director, @duracion,@descripcion ,@categoria, @clasificacion, @portada, @fechaEstreno)";
                MyConexion.AbrirConexion();
                using (MySqlCommand cmd = new MySqlCommand(consulta, MyConexion.ObtenerConexion()))
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
                MyConexion.AbrirConexion();

                string query = "SELECT MAX(id) FROM pelicula";

                MySqlCommand command = new MySqlCommand(query, MyConexion.ObtenerConexion());
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

        private bool ActualizarPelicula(int idParaActualizar, string titulo, string director, decimal duracion, string descripcion, int categoria, int clasificacion, string portada, DateTime fechaEstreno)
        {
            try
            {


                string consulta = "UPDATE pelicula SET titulo = @titulo, director = @director, duracion = @duracion, descripcion = @descripcion, id_categoria = @categoria, id_clasificacion = @clasificacion, portada = @portada, fecha_estreno = @fechaEstreno WHERE id = @idParaActualizar";

                MyConexion.AbrirConexion();
                using (MySqlCommand cmd = new MySqlCommand(consulta, MyConexion.ObtenerConexion()))
                {
                    Trace.WriteLine(idParaActualizar);
                    cmd.Parameters.AddWithValue("@idParaActualizar", idParaActualizar);
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
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún registro para actualizar.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                return false;
            }
        }


        private void CargarDatosPelicula(int peliculaID)
        {
            try
            {

                string consulta = "SELECT titulo, director, duracion, descripcion, id_categoria, id_clasificacion, portada, fecha_estreno FROM pelicula WHERE id = @id";


                MyConexion.AbrirConexion();

                using (MySqlCommand cmd = new MySqlCommand(consulta, MyConexion.ObtenerConexion()))
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void addimage_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccionar una imagen";
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png\"";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImagenCargada = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = ImagenCargada;
            }
        }

        private void addpelicula_btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}

   

   


