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
using BarcodeLib.BarcodeReader;

using System.Windows.Forms;
using System.Timers;

namespace ClickTix.Empleado.UserControls
{
    public partial class LECTORQR_UC : UserControl
    {

        private FilterInfoCollection dispositivos;
        private VideoCaptureDevice fuenteVideo;




        public LECTORQR_UC()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LECTORQR_UC_Load(object sender, EventArgs e)
        {
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo dispositivo in dispositivos) { 
                combobox_camara.Items.Add(dispositivo.Name);
            }
            combobox_camara.SelectedIndex = 0;
        }

        private void iniciar_scaneo_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            fuenteVideo = new VideoCaptureDevice(dispositivos[combobox_camara.SelectedIndex].MonikerString);

            videoSourcePlayer1.VideoSource = fuenteVideo;
            videoSourcePlayer1.Start();

        }

        private void detener_scaneo_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            videoSourcePlayer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (videoSourcePlayer1.GetCurrentVideoFrame() != null)
            {
                Bitmap img = new Bitmap(videoSourcePlayer1.GetCurrentVideoFrame());
                String[] results = BarcodeReader.read(img, BarcodeReader.QRCODE);
                img.Dispose();

                if (results != null && results.Length > 0)
                {
                    string qrCodeValue = results[0].ToString();

                    textBox1.Text = qrCodeValue;
                }
            }
        }



        private void combobox_camara_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            videoSourcePlayer1.Stop();
        }
    }
}
