using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Empleado.UserControls
{
    public partial class MENU_UC : UserControl
    {
        public MENU_UC()
        {
            InitializeComponent();
        }

        private void comprar_Click(object sender, EventArgs e)
        {
           CARTELERA_UC cARTELERA_UC = new CARTELERA_UC();  
            Index_User.addUserControlUsuario(cARTELERA_UC);
        }

        private void retirar_Click(object sender, EventArgs e)
        {
            LECTORQR_UC lector = new LECTORQR_UC();
            Index_User.addUserControlUsuario(lector);
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cerrar sesión?", "Confirmar Cierre de Sesión",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                Parent.Parent.Hide();
            }
            else if (result == DialogResult.No)
            {
            }
        }
    }
}
