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
using ClickTix.Modelo;
using ZXing;
using System.Diagnostics;

namespace ClickTix.Empleado.UserControls
{
    public partial class TICKET_UC : UserControl
    {
        MyConexion c;

        int nroSala = 0;
        string titulo = "";
        DateTime fecha;
        string hora = "";
        string idioma = "";
        double precio= 0;
        int fila = 0;
        int columna = 0;


        public TICKET_UC(int idFuncion, int filaRecibida, int columnaRecibida)
        {
            c = new MyConexion("localhost", "clicktix", "root", "");
            InitializeComponent();
            loadTicketStrings(idFuncion);
            Trace.WriteLine(nroSala+ titulo+fecha+ hora+ idioma + precio);
            fila = filaRecibida;
            columna = columnaRecibida;

            nombre_pelicula_ticket.Text = titulo;
            nrosala_ticket.Text = nroSala.ToString();
            fecha_ticket.Text = fecha.ToShortDateString();
            hora_ticket.Text = hora;
            fila_ticket.Text = fila.ToString();
            columna_ticket.Text = columna.ToString();
            idioma_ticket.Text = idioma;
            precio_ticket.Text = precio.ToString();


        }

       

        private void button1_Click(object sender, EventArgs e)
        {
  
        }

        private void loadTicketStrings(int idFuncion)
        {
            try
            {
                MyConexion.AbrirConexion();

                string query = "select s.nro_sala, p.titulo, fecha, t.hora, d.precio, i.idioma from funcion f inner join sala s on f.id_sala = s.id inner join dimension d  on f.id_dimension = d.id inner join pelicula p on f.id_pelicula = p.id inner join idioma i on f.idioma_funcion = i.id inner join turno t on f.turno_id = t.id where f.id=@id_funcion;;";

                using (MySqlCommand command = new MySqlCommand(query, MyConexion.ObtenerConexion()))
                {
                    command.Parameters.AddWithValue("@id_funcion", idFuncion);

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        nroSala = reader.GetInt32(0);
                        titulo = reader.GetString(1);
                        fecha = reader.GetDateTime(2);
                        hora = reader.GetString(3);
                        precio = reader.GetDouble(4);
                        idioma = reader.GetString(5);

                    }                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }


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
