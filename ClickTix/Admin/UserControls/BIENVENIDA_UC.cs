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
    public partial class BIENVENIDA_UC : UserControl
    {
        public BIENVENIDA_UC()
        {
            InitializeComponent();
        }

        private void BIENVENIDA_UC_Load(object sender, EventArgs e)
        {
            title.Text = $"Bienvenido al sistema de ClicTix, {Program.logeado.Nombre}";
        }
    }
}
