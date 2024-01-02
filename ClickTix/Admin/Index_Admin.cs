using ClickTix.Admin.UserControls.ABMs;
using ClickTix.Admin.UserControls.Formularios;
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
    public partial class Index_Admin : Form
    {
        public Index_Admin()
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
            //ABM_PELICULAS_UC abmpeliculas_uc = new ABM_PELICULAS_UC();
            FORM_API_PELICULAS abmpeliculas_uc = new FORM_API_PELICULAS();

            addUserControl(abmpeliculas_uc);

        }

        private void btn_sucur_Click(object sender, EventArgs e)
        {
            ABM_SUCURSALES_UC sucursales_uc = new ABM_SUCURSALES_UC();
            addUserControl(sucursales_uc);
        }

        private void btn_funciones_Click(object sender, EventArgs e)
        {
            ABM_FUNCION_UC funciones_uc = new ABM_FUNCION_UC();
            addUserControl(funciones_uc);
        }


        private void btn_empleado_Click(object sender, EventArgs e)
        {
            ABM_EMPLEADOS_UC empleados_uc = new ABM_EMPLEADOS_UC();
            addUserControl(empleados_uc);

        }

        private void btn_dimensiones_Click(object sender, EventArgs e)
        {
            ABM_PRECIODIMENSION_UC preciodimension_uc = new ABM_PRECIODIMENSION_UC();
            addUserControl(preciodimension_uc);
        }

        public static void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cerrar sesión?", "Confirmar Cierre de Sesión",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               
                this.Close();
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void Index_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.login.Show();
        }
    }
}
