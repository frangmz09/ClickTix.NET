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


        private void Index_Load(object sender, EventArgs e)
        {
            BIENVENIDA_UC bienvenida_uc = new BIENVENIDA_UC();
            addUserControl(bienvenida_uc);
        }

        private void btn_peliculas_Click(object sender, EventArgs e)
        {
            ABMPELICULAS_UC abmpeliculas_uc = new ABMPELICULAS_UC();
            addUserControl(abmpeliculas_uc);

        }

        private void btn_sucur_Click(object sender, EventArgs e)
        {
            FORMSUCURSALES_UC sucursales_uc = new FORMSUCURSALES_UC();
            addUserControl(sucursales_uc);
        }

        private void btn_funciones_Click(object sender, EventArgs e)
        {
            FORMFUNCIONES_UC funciones_uc = new FORMFUNCIONES_UC();
            addUserControl(funciones_uc);
        }


        private void btn_empleado_Click(object sender, EventArgs e)
        {
            FORMEMPLEADOS_UC empleados_uc = new FORMEMPLEADOS_UC();
            addUserControl(empleados_uc);

        }

        public void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
