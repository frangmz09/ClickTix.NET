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
        

        public TICKET_UC(int idP, int idF, int idB)
        {
            InitializeComponent();
            id_pelicula.Text = idP.ToString();
            id_funcion.Text = idF.ToString();
            id_butaca.Text = idB.ToString();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void Ticket_Load()
        {

            MyConexion.AbrirConexion();


            

            
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
    }
}
