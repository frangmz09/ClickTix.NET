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

namespace ClickTix.Admin.UserControls.ABMs
{
    public partial class ABM_PRECIODIMENSION_UC : UserControl
    {
        public ABM_PRECIODIMENSION_UC()
        {
            InitializeComponent();
        }

        private void add_dimension_Click(object sender, EventArgs e)
        {
            FORM_PRECIODIMENSION_UC preciodimension_uc = new FORM_PRECIODIMENSION_UC();
            Index_Admin.addUserControl(preciodimension_uc);
        }
    }
}
