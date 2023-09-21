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
    public partial class ABMPELICULAS_UC : UserControl
    {
        public ABMPELICULAS_UC()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void add_pelicula_Click(object sender, EventArgs e)
        {
            FORMPELICULAS_UC formpeliculas_uc = new FORMPELICULAS_UC();
            ///Index.addUserControl(formpeliculas_uc);

        }


    }
}
