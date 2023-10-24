using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using AForge.Video.DirectShow;
using AForge.Video;

using System.Windows.Forms;
using System.Timers;
using ZXing;
using AForge.Controls;
using iTextSharp.text.xml;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;
using ClickTix.Modelo;
using MySqlX.XDevAPI.Common;
using MySql.Data.MySqlClient;
using ClickTix.Conexion;
using System.IO;

namespace ClickTix.Empleado.UserControls
{
    public partial class LECTORQR_UC : UserControl
    {

        FilterInfoCollection dispositivos;
        public static VideoCaptureDevice fuenteVideo;
        Image imagenNone;

        public LECTORQR_UC()
        {
            InitializeComponent();
            button1.Enabled = false;
            string rutaImagen = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources\\img\\icons\\none.png");
            try
            {
                if (File.Exists(rutaImagen))
                {
                    imagenNone = Image.FromFile(rutaImagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
            pictureBox1.Image = imagenNone;
        }

        private void LECTORQR_UC_Load(object sender, EventArgs e)
        {
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (dispositivos.Count > 0)
            {
                foreach (FilterInfo dispositivo in dispositivos)
                {
                    comboBox1.Items.Add(dispositivo.Name);
                }
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.Items.Clear();
                comboBox1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.Enabled = false;
                error1.Visible = true;
            }
        }

        private void LECTORQR_UC_Leave(object sender, EventArgs e)
        {
            DetenerCamara();
        }

        public static void DetenerCamara()
        {
            if (fuenteVideo != null && fuenteVideo.IsRunning)
            {
                fuenteVideo.SignalToStop();
                fuenteVideo.WaitForStop();
                fuenteVideo = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CambiarCamara(comboBox1.SelectedIndex);
        }

        private void CambiarCamara(int nuevaCamaraIndex)
        {
            DetenerCamara();

            fuenteVideo = new VideoCaptureDevice(dispositivos[nuevaCamaraIndex].MonikerString);
            fuenteVideo.NewFrame += CaptureDevice_NewFrame;
            fuenteVideo.Start();
            timer1.Start();
            button1.Enabled = false;
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                if (pictureBox1.InvokeRequired)
                {
                    pictureBox1.Invoke(new MethodInvoker(() =>
                    {
                        pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
                    }));
                }
                else
                {
                    pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la imagen: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetenerCamara();
            pictureBox1.Image = imagenNone;
            button1.Enabled = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("El campo donde se ingresa el Nro de Ticket está vacío, por favor ingrese un valor.");
            }
            else if (!int.TryParse(textBox2.Text, out int idTicket))
            {
                MessageBox.Show("El valor ingresado no es un número, por favor ingrese un valor del tipo numerico.");
            }

            else
            {
                int idTicketInput = int.Parse(textBox2.Text);
                if (validarExistenciaTicket(idTicketInput))
                {
                    Trace.WriteLine("EL ID TICKET ES: " + idTicketInput);
                    TICKET_UC ticket = new TICKET_UC(idTicketInput);
                    Index_User.addUserControlUsuario(ticket);
                }
                else
                {
                    MessageBox.Show("No se encontró un ticket con ese Nro de Ticket.");
                }

            }
        }

        private bool validarExistenciaTicket(int id) {

                try
                {
                    ManagerConnection.OpenConnection();

                    string query = "SELECT id FROM ticket where id=@id";

                    MySqlCommand command = new MySqlCommand(query, ManagerConnection.getInstance());

                    command.Parameters.AddWithValue("@id", id);

                    object resultado = command.ExecuteScalar();

                    if (resultado == null || resultado == DBNull.Value)
                    {
                    ManagerConnection.CloseConnection();
                    return false;
                    }
                ManagerConnection.CloseConnection();
                return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                ManagerConnection.CloseConnection();
                return false;
                }
            
        }

        private void back_pelicula_Click(object sender, EventArgs e)
        {
            MENU_UC menuUser = new MENU_UC();
            Index_User.addUserControlUsuario(menuUser);
        }
    }
}
