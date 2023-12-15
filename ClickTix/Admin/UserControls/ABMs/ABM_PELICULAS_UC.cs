using AForge.Controls;
using ClickTix.Conexion;
using ClickTix.Controller;
using ClickTix.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.UserControls
{
    public partial class ABM_PELICULAS_UC : UserControl
    {
        public ABM_PELICULAS_UC()
        {
            InitializeComponent();
            cargarPeliculas();
        }
        private void cargarPeliculas()
        {
            grid_peliculas.Rows.Clear();

            List<Pelicula> peliculas = Pelicula_Controller.obtenerTodos();
            foreach (Pelicula pelicula in peliculas)
            {
                int rowIndex = grid_peliculas.Rows.Add();

                grid_peliculas.Rows[rowIndex].Cells[0].Value = pelicula.id.ToString();

                try
                {

                    //string urlImagen = pelicula.imagen.ToString();

                    //using (WebClient webClient = new WebClient())
                    //{
                    //    byte[] data = webClient.DownloadData(urlImagen);
                    //    using (MemoryStream mem = new MemoryStream(data))
                    //    {
                    //        Image imagen = Image.FromStream(mem);

                    //        grid_peliculas.Rows[rowIndex].Cells[1].Value = imagen;
                    //    }
                    //}

                }
                catch
                {

                }
                grid_peliculas.Rows[rowIndex].Cells[1].Value = pelicula.titulo.ToString();
                grid_peliculas.Rows[rowIndex].Cells[2].Value = pelicula.director.ToString();
                grid_peliculas.Rows[rowIndex].Cells[3].Value = "Modificar";
                grid_peliculas.Rows[rowIndex].Cells[4].Value = "Eliminar";

            }
        }
        private void title_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_pelicula_Click(object sender, EventArgs e)
        {
            FORM_PELICULAS_UC formpeliculas_uc = new FORM_PELICULAS_UC();
            Index_Admin.addUserControl(formpeliculas_uc);
        }

        private void grid_peliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == grid_peliculas.Columns["Modificar"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(grid_peliculas.Rows[e.RowIndex].Cells["IdD"].Value);

               
                FORM_PELICULAS_UC formModificarPelicula = new FORM_PELICULAS_UC(id);

                Index_Admin.addUserControl(formModificarPelicula);

            }

            else if (e.ColumnIndex == grid_peliculas.Columns["Borrar"].Index && e.RowIndex >= 0)
            {
                
                int id = Convert.ToInt32(grid_peliculas.Rows[e.RowIndex].Cells["IdD"].Value);

                
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    EliminarRegistro(id);
                    cargarPeliculas();
                }
            }
        }

        private void Pelicula_Load(DataGridView tabla)
        {
            
            ManagerConnection.OpenConnection();
            string query = "SELECT  id,titulo, director FROM pelicula";

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
            ManagerConnection.CloseConnection();
        }


        public bool EliminarRegistro(int id)
        {
            try
            {
                using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
                {
                    mysqlConnection.Open();
                    string query = "DELETE FROM pelicula WHERE id = @id";

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
                MessageBox.Show("No se puede borrar esta pelicula, ya que ya tiene funciones asociadas a la misma", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ABM_PELICULAS_UC_Load(object sender, EventArgs e)
        {

        }
    }
}

