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
        MyConexion c;
        public CARTELERA_UC()
        {
            InitializeComponent();
            llenarDataGrid(cartelera_grid);
            c = new MyConexion("localhost", "clicktix", "root", "");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cartelera_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==cartelera_grid.Columns["Seleccionar"].Index && e.RowIndex >= 0)
            {
                string titulo = Convert.ToString(cartelera_grid.Rows[e.RowIndex].Cells["titulo"].Value);


                ELEGIR_FUNCION_UC eLEGIR_FUNCION_UC = new ELEGIR_FUNCION_UC(titulo);
                Index_User.addUserControlUsuario(eLEGIR_FUNCION_UC);

            }
            
        }
        private void llenarDataGrid(DataGridView tabla)
        {
            MyConexion.AbrirConexion();

           

            string query = "SELECT titulo, director from funcion inner join sala on funcion.id = sala.id_sucursal " +
                "inner join pelicula on funcion.id_pelicula = pelicula.id where sala.id_sucursal = @id_sucursal group by pelicula.titulo;";

            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
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
        }

        private void CARTELERA_UC_Load(object sender, EventArgs e)
        {

        }
    }
}
