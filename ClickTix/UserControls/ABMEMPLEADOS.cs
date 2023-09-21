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
    public partial class ABMEMPLEADOS : UserControl
    {
        public ABMEMPLEADOS()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void add_empleado_Click(object sender, EventArgs e)
        {
            FORMEMPLEADOS_UC formempleados_uc = new FORMEMPLEADOS_UC();
            Index.addUserControl(formempleados_uc);
        }

        private void grid_empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
