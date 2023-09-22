using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.UserControls
{
    public partial class ABM_FUNCION_UC : UserControl
    {
        public ABM_FUNCION_UC()
        {
            InitializeComponent();
        }

        private void grid_funciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void ABM_FUNCION_UC_Load(object sender, EventArgs e)
        {

        }

        private void add_funcion_Click(object sender, EventArgs e)
        {
            FORM_FUNCIONES_UC formfunciones_uc = new FORM_FUNCIONES_UC();
            Index_Admin.addUserControl(formfunciones_uc);
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void grid_funciones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
