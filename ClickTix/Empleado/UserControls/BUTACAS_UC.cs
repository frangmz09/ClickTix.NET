using ClickTix.Conexion;
using ClickTix.Controller;
using ClickTix.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Empleado.UserControls
{
    public partial class BUTACAS_UC : UserControl
    {
        private int idPelicula;
        private int idFuncion;
        private string tituloPelicula;
        List<int> asientosSeleccionados = new List<int>();
        List<int> filas = new List<int>();
        List<int> columnas = new List<int>();


        public BUTACAS_UC(int id_funcion, int idPeli)
        {

            this.tituloPelicula = ObtenerTituloDePelicula(idPeli);
            this.idFuncion = id_funcion;
            this.idPelicula = idPeli;
            InitializeComponent();
            llenarButacas(id_funcion);
        }

        private void BUTACAS_UC_Load(object sender, EventArgs e)


        {
        }

        private void llenarButacas(int id_funcion)
        {
            Trace.WriteLine(id_funcion);
            flowLayoutPanel1.Controls.Clear();
            int numFilas = 0;
            int numColumnas = 0;

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                mysqlConnection.Open();
                string query = "select filas, columnas from sala s inner join funcion f on f.id_sala = s.id inner join asiento a on f.id = a.id_funcion where f.id = @id_funcion;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@id_funcion", id_funcion);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        numFilas = reader.GetInt32(0);
                        numColumnas = reader.GetInt32(1);
                    }

                    Trace.WriteLine(numFilas);
                    Trace.WriteLine(numColumnas);

                    reader.Close();
                    mysqlConnection.Close();

                    List<Asiento> list = new List<Asiento>();
                    list = Asiento_Controller.obtenerPorFuncion(id_funcion);
                    Image imagenButaca = Properties.Resources.butaca;

                    int columnCount = 0;
                    
                    FlowLayoutPanel currentRowPanel = new FlowLayoutPanel();
                    currentRowPanel.FlowDirection = FlowDirection.LeftToRight;
                    currentRowPanel.Width = flowLayoutPanel1.Width;
                    currentRowPanel.Height = 30;


                    foreach (Asiento asiento in list)
                    {
                        Button butaca = new Button();
                        butaca.Width = 25;
                        butaca.Height = 25;
                        butaca.Name = $"{asiento.Id}";
                        butaca.BackgroundImage = imagenButaca;
                        butaca.BackgroundImageLayout = ImageLayout.Stretch;

                        butaca.BackColor = Color.LightGray;
                        butaca.Margin = new Padding(5);

                        if (asiento.Disponible == false)
                        {
                            butaca.BackColor = Color.Red;
                            butaca.Enabled = false;
                        }
                        butaca.Click += Butaca_Click;
                        butaca.Anchor = AnchorStyles.None;

                        currentRowPanel.Controls.Add(butaca);
                        columnCount++;

                        if (columnCount == numColumnas)
                        {
                            flowLayoutPanel1.Controls.Add(currentRowPanel);

                            columnCount = 0;
                            currentRowPanel = new FlowLayoutPanel();
                            currentRowPanel.FlowDirection = FlowDirection.LeftToRight;
                            currentRowPanel.Width = flowLayoutPanel1.Width;
                            currentRowPanel.Height = 30;
                        }
                    }

                    if (currentRowPanel.Controls.Count > 0)
                    {
                        flowLayoutPanel1.Controls.Add(currentRowPanel);
                    }
                }
            }
        }
        private void Butaca_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.BackColor == Color.LightGray)
            {
                if (asientosSeleccionados.Count < 4)
                {
                    clickedButton.BackColor = Color.Green;

                    asientosSeleccionados.Add(int.Parse(clickedButton.Name));
                }


            }
            else
            {
                clickedButton.BackColor = Color.LightGray;

                asientosSeleccionados.Remove(int.Parse(clickedButton.Name));
            }
        }

        private void confirmar_asiento_Click(object sender, EventArgs e)
        {
            foreach (int idAsiento in asientosSeleccionados)
            {
                Asiento_Controller.OcuparAsiento(idAsiento);
                filas.Add(Asiento_Controller.ObtenerFilaDelAsiento(idAsiento));
                columnas.Add(Asiento_Controller.ObtenerColumnaDelAsiento(idAsiento));
                Ticket_Controller.crearTicket(idFuncion, Asiento_Controller.ObtenerFilaDelAsiento(idAsiento),Asiento_Controller.ObtenerColumnaDelAsiento(idAsiento));
            }

            TICKET_UC tICKET_UC = new TICKET_UC(idFuncion, filas, columnas);
            Index_User.addUserControlUsuario(tICKET_UC);
           
        }


        public static string ObtenerTituloDePelicula(int idPelicula)
        {
            string titulo = null;
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();

                string consulta = "SELECT Titulo FROM pelicula WHERE Id = @id";
                using (MySqlCommand cmd = new MySqlCommand(consulta, mysqlConnection))
                {
                    cmd.Parameters.AddWithValue("@id", idPelicula);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            titulo = reader["Titulo"].ToString();
                        }
                    }
                }
                ManagerConnection.CloseConnection();
            }
            return titulo;
        }




        private void back_pelicula_Click(object sender, EventArgs e)
        {
            ELEGIR_FUNCION_UC funcionElegir = new ELEGIR_FUNCION_UC(tituloPelicula, idFuncion);
            Index_User.addUserControlUsuario(funcionElegir);
        }
    }
}
