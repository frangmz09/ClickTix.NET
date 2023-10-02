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

namespace ClickTix.Empleado
{
    public partial class ELEGIR_FUNCION_UC : UserControl
    {
        public ELEGIR_FUNCION_UC()
        {
            InitializeComponent();
        }


        public ELEGIR_FUNCION_UC(string titulo)
        {
            InitializeComponent();
            MyConexion.AbrirConexion();
            //CARTELERA_UC_LOAD(dataGridView1, titulo);


            
        }

        /*private void CARTELERA_UC_LOAD(DataGridView tabla, string titulo)
        {
            MyConexion.AbrirConexion();



            string query = "select  sala.nro_sala , dimension.dimension, idioma.idioma, dimension.precio,funcion.fecha, turno.hora from funcion " +
                "left join sala on funcion.id_sala = sala.id left join pelicula on funcion.id_pelicula = pelicula.id " +
                "left join dimension on funcion.id_dimension = dimension.id left join idioma  on funcion.idioma_funcion = idioma.id " +
                "left join turno on funcion.turno_id = turno.id where pelicula.titulo = @titulo and sala.id_sucursal = @id_sucursal;";

            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@titulo", titulo);
                    command.Parameters.AddWithValue("@id_sucursal", Program.logeado.Id_sucursal);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();


                    adapter.Fill(dt);


                    tabla.DataSource = dt;
                }
            }
        }*/
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cartelera_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
