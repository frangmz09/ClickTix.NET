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
    public partial class ABM_EMPLEADOS_UC : UserControl
    {
        public ABM_EMPLEADOS_UC()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void add_empleado_Click(object sender, EventArgs e)
        {
            FORM_EMPLEADOS_UC formempleados_uc = new FORM_EMPLEADOS_UC();
            Index_Admin.addUserControl(formempleados_uc);

        }

        private void grid_empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
