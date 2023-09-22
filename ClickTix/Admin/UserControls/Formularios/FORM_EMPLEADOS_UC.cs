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
    public partial class FORM_EMPLEADOS_UC : UserControl
    {
        public FORM_EMPLEADOS_UC()
        {
            InitializeComponent();
        }

        private void back_pelicula_Click(object sender, EventArgs e)
        {
            ABM_EMPLEADOS_UC abmempleados = new ABM_EMPLEADOS_UC();
            Index_Admin.addUserControl(abmempleados);
        }
    }
}
