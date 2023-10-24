using ClickTix.Conexion;
using ClickTix.Controller;
using ClickTix.Modelo;
using ClickTix.UserControls;
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

namespace ClickTix.Empleado.UserControls
{
    public partial class CARTELERA_UC : UserControl
    {

        private int back = 0;

        public CARTELERA_UC()
        {
            InitializeComponent();
            Trace.WriteLine(back);
            cargarPeliculas();
        }
        private void cargarPeliculas()
        {

            cartelera_grid.Rows.Clear();
            List<Pelicula> peliculas = Pelicula_Controller.obtenerTodosCartelera();

            foreach (Pelicula pelicula in peliculas)
            {
                int rowIndex = cartelera_grid.Rows.Add();
                cartelera_grid.Rows[rowIndex].Cells[0].Value = pelicula.id.ToString();

                string rutaImagen = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources\\img\\peliculas\\" + pelicula.imagen.ToString());
                Image ImagenCargada;
                try
                {

                    if (File.Exists(rutaImagen))
                    {

                        ImagenCargada = Image.FromFile(rutaImagen);

                        cartelera_grid.Rows[rowIndex].Cells[1].Value = ImagenCargada;

                    }

                }
                catch
                {

                }
                cartelera_grid.Rows[rowIndex].Cells[2].Value = pelicula.titulo.ToString();
                cartelera_grid.Rows[rowIndex].Cells[3].Value = pelicula.director.ToString();

                cartelera_grid.Rows[rowIndex].Cells[4].Value = "Seleccionar";

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void volverAlMenu() {
            MENU_UC menuUser = new MENU_UC();
            Index_User.addUserControlUsuario(menuUser);
        }
        private void cartelera_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==cartelera_grid.Columns["Seleccionar"].Index && e.RowIndex >= 0)
            {
                string titulo = Convert.ToString(cartelera_grid.Rows[e.RowIndex].Cells["tituloo"].Value);
                int id = Convert.ToInt32(cartelera_grid.Rows[e.RowIndex].Cells["idPel"].Value);

                ELEGIR_FUNCION_UC eLEGIR_FUNCION_UC = new ELEGIR_FUNCION_UC(titulo,id);
                Index_User.addUserControlUsuario(eLEGIR_FUNCION_UC);

            }
            
        }
        private void llenarDataGrid(DataGridView tabla)
        {
            back = 0;
            ManagerConnection.OpenConnection();

            string query = "select p.id, p.titulo, p.director from pelicula p inner join funcion f on f.id_pelicula = p.id inner join sala s on f.id_sala = s.id where s.id_sucursal = @id_sucursal and  f.fecha > NOW();";

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@id_sucursal", Program.logeado.Id_sucursal);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        tabla.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No hay películas disponibles en cartelera.");
                        back = 1;
                    }
                }
            }
            ManagerConnection.CloseConnection();
            if (back == 1)
            {
                volverAlMenu();
            }
        }

        private void CARTELERA_UC_Load(object sender, EventArgs e)
        {
            if (back == 1)
            {
                volverAlMenu();
            }
        }

        private void back_pelicula_Click(object sender, EventArgs e)
        {
            MENU_UC menuUser = new MENU_UC();
            Index_User.addUserControlUsuario(menuUser);
        }
    }
}
