using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using ClickTix.Conexion;
using MySql.Data.MySqlClient;

namespace ClickTix.Empleado.UserControls
{
    public partial class TICKET_UC : UserControl
    {
        MyConexion c;

        public TICKET_UC(int idP, int idF, int idB)
        {
            c = new MyConexion("localhost", "clicktix", "root", "");
            InitializeComponent();
            id_pelicula.Text = pelicula_Load(idP);
            id_funcion.Text = idF.ToString();
            id_butaca.Text = idB.ToString();
           /* id_precio.Text = idPrecio.ToString();
            id_fecha.Text = idFecha.ToString();
            id_hora.Text = idHora.ToString();*/
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private string pelicula_Load(int id)
        {
            try
            {
                MyConexion.AbrirConexion();

                string query = "SELECT titulo FROM pelicula WHERE id = @id_pelicula;";

                using (MySqlCommand command = new MySqlCommand(query, MyConexion.ObtenerConexion()))
                {
                    command.Parameters.AddWithValue("@id_pelicula", id);
                   
                    object result = command.ExecuteScalar();
                    MessageBox.Show("valor :" + result);
                    return "" + result;
                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            return "";
        }

        /*private string funcion_Load(int id)
        {
            try
            {
                MyConexion.AbrirConexion();

                string query = "SELECT fecha FROM funcion WHERE id = @id_pelicula;";

                using (MySqlCommand command = new MySqlCommand(query, MyConexion.ObtenerConexion()))
                {
                    command.Parameters.AddWithValue("@id_pelicula", id);

                    object result = command.ExecuteScalar();
                    MessageBox.Show("valor :" + result);
                    return "" + result;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return "";
        }*/

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


        }

        private void TICKET_UC_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void id_precio_Click(object sender, EventArgs e)
        {

        }
    }
}
