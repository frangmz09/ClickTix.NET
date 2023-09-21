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
    public partial class FORMEMPLEADOS_UC : UserControl
    {
        public FORMEMPLEADOS_UC()
        {
            InitializeComponent();
        }

        private void back_pelicula_Click(object sender, EventArgs e)
        {
            ABM_EMPLEADOS_UC abmempleados = new ABM_EMPLEADOS_UC();
            Index.addUserControl(abmempleados);
        }
    }
}
