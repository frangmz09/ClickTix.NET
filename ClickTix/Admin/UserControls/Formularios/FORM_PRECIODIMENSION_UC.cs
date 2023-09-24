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

namespace ClickTix.Admin.UserControls.Formularios
{
    public partial class FORM_PRECIODIMENSION_UC : UserControl
    {
        public FORM_PRECIODIMENSION_UC()
        {
            InitializeComponent();
        }

        private void addempleado_btn_Click(object sender, EventArgs e)
        {

        }

        private void back_dimension_Click(object sender, EventArgs e)
        {
            ABM_EMPLEADOS_UC abmempleados = new ABM_EMPLEADOS_UC();
            Index_Admin.addUserControl(abmempleados);
        }
    }
}
