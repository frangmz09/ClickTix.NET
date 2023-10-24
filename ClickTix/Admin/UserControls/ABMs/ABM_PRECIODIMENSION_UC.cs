using ClickTix.Admin.UserControls.Formularios;
using ClickTix.Conexion;
using ClickTix.Modelo;
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
            cargarSucursales();
        }
        private void cargarSucursales()
        {

            grid_dimension.Rows.Clear();

            List<PrecioDimension> dimensiones = PrecioDimension_Controller.obtenerTodos();

            foreach (PrecioDimension dimension in dimensiones)
            {
                int rowIndex = grid_dimension.Rows.Add();
                grid_dimension.Rows[rowIndex].Cells[0].Value = dimension.id.ToString();
                grid_dimension.Rows[rowIndex].Cells[1].Value = dimension.dimension.ToString();
                grid_dimension.Rows[rowIndex].Cells[2].Value = dimension.precio.ToString();
                grid_dimension.Rows[rowIndex].Cells[3].Value = "Modificar";
                grid_dimension.Rows[rowIndex].Cells[4].Value = "Eliminar";

            }
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
                int id = Convert.ToInt32(grid_dimension.Rows[e.RowIndex].Cells["idDimension"].Value);


                FORM_PRECIODIMENSION_UC formModificarDimension = new FORM_PRECIODIMENSION_UC(id);

                Index_Admin.addUserControl(formModificarDimension);

            }

            else if (e.ColumnIndex == grid_dimension.Columns["Borrar"].Index && e.RowIndex >= 0)
            {

                int id = Convert.ToInt32(grid_dimension.Rows[e.RowIndex].Cells["idDimension"].Value);


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
