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
    public partial class ABM_SUCURSALES_UC : UserControl
    {
        public ABM_SUCURSALES_UC()
        {
            InitializeComponent();
        }

        private void add_sucursal_Click(object sender, EventArgs e)
        {
            FORM_SUCURSALES_UC formsucursales_uc = new FORM_SUCURSALES_UC();
            Index_Admin.addUserControl(formsucursales_uc);
        }
    }
}
