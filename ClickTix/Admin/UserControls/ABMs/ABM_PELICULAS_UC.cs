using ClickTix.Conexion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.UserControls
{
    public partial class ABM_PELICULAS_UC : UserControl
    {
        MyConexion c;
        public ABM_PELICULAS_UC()
        {
            InitializeComponent();
            c = new MyConexion("localhost", "clicktix", "root", "tiago26");

            Pelicula_Load(grid_peliculas);
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
                int id = Convert.ToInt32(grid_peliculas.Rows[e.RowIndex].Cells["id"].Value);

               
                FORM_PELICULAS_UC formModificarPelicula = new FORM_PELICULAS_UC(id);

                Index_Admin.addUserControl(formModificarPelicula);

            }

            else if (e.ColumnIndex == grid_peliculas.Columns["Borrar"].Index && e.RowIndex >= 0)
            {
                
                int id = Convert.ToInt32(grid_peliculas.Rows[e.RowIndex].Cells["id"].Value);

                
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    EliminarRegistro(id);
                    Pelicula_Load(grid_peliculas);
                }
            }
        }

        private void Pelicula_Load(DataGridView tabla)
        {
            
            MyConexion.AbrirConexion();

            
            string query = "SELECT  id,titulo, director FROM pelicula";

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


        public bool EliminarRegistro(int id)
        {
            try
            {
                using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
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
                MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ABM_PELICULAS_UC_Load(object sender, EventArgs e)
        {

        }
    }
}

