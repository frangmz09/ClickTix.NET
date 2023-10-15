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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using iTextSharp.tool.xml.html;
using ClickTix.Controller;

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
        public TICKET_UC(int idTicket)
        {
            c = new MyConexion("localhost", "clicktix", "root", "");
            InitializeComponent();
            Ticket ticket = new Ticket();
            ticket = Ticket_Controller.buscarTicketPorId(idTicket);
            Funcion funcionAuxiliar = Funcion_Controller.buscarFuncionPorId(ticket.id_funcion);
            loadTicketStrings(funcionAuxiliar.Id);


            nombre_pelicula_ticket.Text = titulo;
            nrosala_ticket.Text = nroSala.ToString();
            fecha_ticket.Text = fecha.ToShortDateString();
            hora_ticket.Text = hora;
            fila_ticket.Text = ticket.fila.ToString();
            columna_ticket.Text = ticket.columna.ToString();
            idioma_ticket.Text = idioma;
            precio_ticket.Text = precio.ToString();


        }



        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();

            guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

            string html = Properties.Resources.ticket.ToString();

            html = html.Replace("@nroSalaTicket", nrosala_ticket.Text);
            html = html.Replace("@tituloTicket", nombre_pelicula_ticket.Text);
            html = html.Replace("@fechaTicket", fecha_ticket.Text);
            html = html.Replace("@horaTicket", hora_ticket.Text);
            html = html.Replace("@filaTicket", fila_ticket.Text);
            html = html.Replace("@columnaTicket", columna_ticket.Text);
            html = html.Replace("@precioTicket", precio_ticket.Text);
            html = html.Replace("@nombreSucursalTicket",Empleado_Controller.nombreSucursalEmpleado(Program.logeado.Id));
            html = html.Replace("@cuitSucursalTicket", Empleado_Controller.cuitSucursalEmpleado(Program.logeado.Id));


            if (guardar.ShowDialog() == DialogResult.OK)
            {

                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.POSTCARD, 25, 25, 25, 25);
                    PdfWriter Writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo, System.Drawing.Imaging.ImageFormat.Png);
                    
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;


                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);


                    pdfDoc.Add(img);


                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(Writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                }
            }
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
                    reader.Close();
                    MyConexion.conexion.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }



    }
}
