using ClickTix.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btn_peliculas_Click(object sender, EventArgs e)
        {
            PELICULAS_UC peliculas_uc = new PELICULAS_UC();

            peliculas_uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(peliculas_uc);
            peliculas_uc.BringToFront();

        }

        private void btn_sucur_Click(object sender, EventArgs e)
        {
            SUCURSALES_UC sucursales_uc = new SUCURSALES_UC();

            sucursales_uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(sucursales_uc);
            sucursales_uc.BringToFront();
        }

        private void btn_funciones_Click(object sender, EventArgs e)
        {
            FUNCIONES_UC funciones_uc = new FUNCIONES_UC();

            funciones_uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(funciones_uc);
            funciones_uc.BringToFront();
        }
    }
}
