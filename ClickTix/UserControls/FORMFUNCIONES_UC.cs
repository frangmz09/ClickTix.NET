﻿using System;
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
    public partial class FORMFUNCIONES_UC : UserControl
    {
        public FORMFUNCIONES_UC()
        {
            InitializeComponent();
        }

        private void FUNCIONES_UC_Load(object sender, EventArgs e)
        {

        }

        private void back_pelicula_Click(object sender, EventArgs e)
        {
            ABM_FUNCION_UC abmfuncion = new ABM_FUNCION_UC();
            Index.addUserControl(abmfuncion);
        }
    }
}
