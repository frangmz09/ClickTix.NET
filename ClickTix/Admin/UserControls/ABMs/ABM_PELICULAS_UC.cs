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
            c = new MyConexion("localhost", "boleteria", "root", "tiago26");

            Form1_Load(grid_peliculas);
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
            

        }

        private void Form1_Load(DataGridView tabla)
        {
            
            c.AbrirConexion();

            
            string query = "SELECT  id,titulo, director FROM peliculas";

            using (MySqlConnection mysqlConnection = c.ObtenerConexion())
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


    }
}

