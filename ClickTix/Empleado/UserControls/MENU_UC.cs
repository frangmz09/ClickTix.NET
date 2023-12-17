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
           ELEGIR_FUNCION_UC eleigr_funcion = new ELEGIR_FUNCION_UC();  
            Index_User.addUserControlUsuario(eleigr_funcion);
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
                Form formularioPadre = this.FindForm();
                if (formularioPadre != null)
                {
                    formularioPadre.Close();
                }
                Program.login.Show();
            }
            else if (result == DialogResult.No)
            {
            }
        }
    }
}
