using ClickTix.Admin.UserControls.Formularios;
using ClickTix.Conexion;
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
            Sucursal_Controller.Sucursal_Load(grid_sucursal);
        }

        private void add_sucursal_Click(object sender, EventArgs e)
        {
            FORM_SUCURSALES_UC formsucursales_uc = new FORM_SUCURSALES_UC();
            Index_Admin.addUserControl(formsucursales_uc);
        }

        private void grid_sucursal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_sucursal.Columns["Modificar"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(grid_sucursal.Rows[e.RowIndex].Cells["id"].Value);


                FORM_SUCURSALES_UC formModificarSucursal = new FORM_SUCURSALES_UC(id);

                Index_Admin.addUserControl(formModificarSucursal);

            }

            else if (e.ColumnIndex == grid_sucursal.Columns["Borrar"].Index && e.RowIndex >= 0)
            {

                int id = Convert.ToInt32(grid_sucursal.Rows[e.RowIndex].Cells["id"].Value);


                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    Sucursal_Controller.EliminarRegistroSucursal(id);


                    Sucursal_Controller.Sucursal_Load(this.grid_sucursal);

                }
            }
        }
    }
}
