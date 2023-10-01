using ClickTix.Admin.UserControls.Formularios;
using ClickTix.Conexion;
using ClickTix.UserControls;
using MySql.Data.MySqlClient;
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
            PrecioDimension_Controller.Dimension_Load(grid_dimension);
        }

        private void add_dimension_Click(object sender, EventArgs e)
        {
            FORM_PRECIODIMENSION_UC preciodimension_uc = new FORM_PRECIODIMENSION_UC();
            Index_Admin.addUserControl(preciodimension_uc);
        }

        private void grid_dimension_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_dimension.Columns["Modificar"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(grid_dimension.Rows[e.RowIndex].Cells["id"].Value);


                FORM_PRECIODIMENSION_UC formModificarDimension = new FORM_PRECIODIMENSION_UC(id);

                Index_Admin.addUserControl(formModificarDimension);

            }

            else if (e.ColumnIndex == grid_dimension.Columns["Borrar"].Index && e.RowIndex >= 0)
            {

                int id = Convert.ToInt32(grid_dimension.Rows[e.RowIndex].Cells["id"].Value);


                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    PrecioDimension_Controller.EliminarRegistroDimension(id);

                    PrecioDimension_Controller.Dimension_Load(this.grid_dimension);

                }
            }
        }






    }
}
