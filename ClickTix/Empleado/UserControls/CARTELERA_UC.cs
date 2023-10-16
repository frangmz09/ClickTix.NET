using ClickTix.Conexion;
using ClickTix.UserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Empleado.UserControls
{
    public partial class CARTELERA_UC : UserControl
    {        
        public CARTELERA_UC()
        {
            InitializeComponent();
            llenarDataGrid(cartelera_grid);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cartelera_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==cartelera_grid.Columns["Seleccionar"].Index && e.RowIndex >= 0)
            {
                string titulo = Convert.ToString(cartelera_grid.Rows[e.RowIndex].Cells["titulo"].Value);
                int id = Convert.ToInt32(cartelera_grid.Rows[e.RowIndex].Cells["id"].Value);

                ELEGIR_FUNCION_UC eLEGIR_FUNCION_UC = new ELEGIR_FUNCION_UC(titulo,id);
                Index_User.addUserControlUsuario(eLEGIR_FUNCION_UC);

            }
            
        }
        private void llenarDataGrid(DataGridView tabla)
        {
            ManagerConnection.OpenConnection();

            string query = "SELECT id, titulo from pelicula";

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@id_sucursal", Program.logeado.Id_sucursal);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();


                    adapter.Fill(dt);


                    tabla.DataSource = dt;
                }
            }
            ManagerConnection.CloseConnection();

        }

        private void CARTELERA_UC_Load(object sender, EventArgs e)
        {

        }

        private void back_pelicula_Click(object sender, EventArgs e)
        {
            MENU_UC menuUser = new MENU_UC();
            Index_User.addUserControlUsuario(menuUser);
        }
    }
}
