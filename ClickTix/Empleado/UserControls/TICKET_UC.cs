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
using ClickTix.UserControls;

namespace ClickTix.Empleado.UserControls
{
    public partial class TICKET_UC : UserControl
    {
        int nroSala = 0;
        string titulo = "";
        DateTime fecha;
        string hora = "";
        string idioma = "";
        double precio = 0;
        List<int> filas = new List<int>();
        List<int> columnas = new List<int>();
        int idFuncionAux;

        public TICKET_UC(int idFuncion, List<int> filasRecibidas, List<int> columnasRecibidas)
        {
            InitializeComponent();
            loadTicketStrings(idFuncion);
            idFuncionAux = idFuncion;
            Trace.WriteLine(nroSala + titulo + fecha + hora + idioma + precio);
            filas = filasRecibidas;
            columnas = columnasRecibidas;

            nombre_pelicula_ticket.Text = titulo;
            nrosala_ticket.Text = nroSala.ToString();
            fecha_ticket.Text = fecha.ToShortDateString();
            hora_ticket.Text = hora;
            string stringFyC = "";

            for (int i = 0; i < filasRecibidas.Count; i++)
            {
                if (i > 0)
                {
                    stringFyC += " | ";
                    label1.Text = "Filas y Columnas";
                }
                stringFyC += $"{filasRecibidas[i]}-{columnasRecibidas[i]}";
            }

            fila_ticket.Text = stringFyC;
            idioma_ticket.Text = idioma;
            precio_ticket.Text = precio.ToString();
        }

        public TICKET_UC(int idTicket)
        {
            InitializeComponent();
            Ticket ticket = new Ticket();
            ticket = Ticket_Controller.buscarTicketPorId(idTicket);
            Funcion funcionAuxiliar = Funcion_Controller.buscarFuncionPorId(ticket.id_funcion);
            loadTicketStrings(funcionAuxiliar.Id);
            idFuncionAux = funcionAuxiliar.Id;
            nombre_pelicula_ticket.Text = titulo;
            nrosala_ticket.Text = nroSala.ToString();
            fecha_ticket.Text = fecha.ToShortDateString();
            hora_ticket.Text = hora;
            fila_ticket.Text = ticket.fila.ToString() + "-" + ticket.columna.ToString();
            filas.Add(ticket.fila);
            columnas.Add(ticket.columna);
            idioma_ticket.Text = idioma;
            precio_ticket.Text = precio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < filas.Count; i++)
            {
                this.generarPDF(filas[i], columnas[i]);
            }
        }

        private void generarPDF(int fila, int columna)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
            string html = Properties.Resources.ticket;
            html = html.Replace("@nroSalaTicket", nrosala_ticket.Text);
            html = html.Replace("@tituloTicket", nombre_pelicula_ticket.Text);
            html = html.Replace("@fechaTicket", fecha_ticket.Text);
            html = html.Replace("@horaTicket", hora_ticket.Text);
            html = html.Replace("@filaTicket", fila.ToString());
            html = html.Replace("@columnaTicket", columna.ToString());
            html = html.Replace("@precioTicket", precio_ticket.Text);
            html = html.Replace("@nombreSucursalTicket", Empleado_Controller.nombreSucursalFuncion(idFuncionAux));
            html = html.Replace("@cuitSucursalTicket", Empleado_Controller.cuitSucursalFuncion(idFuncionAux));

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.POSTCARD, 25, 25, 25, 25);
                    PdfWriter Writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo, System.Drawing.Imaging.ImageFormat.Png);
                    //img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    //img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    //pdfDoc.Add(img);

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
                ManagerConnection.OpenConnection();
                string query = "select s.nro_sala, p.titulo, fecha, t.hora, d.precio, i.idioma from funcion f inner join sala s on f.id_sala = s.id inner join dimension d on f.id_dimension = d.id inner join pelicula p on f.id_pelicula = p.id inner join idioma i on f.idioma_funcion = i.id inner join turno t on f.turno_id = t.id where f.id=@id_funcion;";
                using (MySqlCommand command = new MySqlCommand(query, ManagerConnection.getInstance()))
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
                    ManagerConnection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_MenuPrincipal_Click(object sender, EventArgs e)
        {
            MENU_UC mENU_UC = new MENU_UC();
            Index_User.addUserControlUsuario(mENU_UC);  

        }
    }
}
