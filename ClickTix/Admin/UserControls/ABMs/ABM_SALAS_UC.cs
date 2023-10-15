using ClickTix.Admin.UserControls.Formularios;
using ClickTix.Conexion;
using ClickTix.Controller;
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
    public partial class ABM_SALAS_UC : UserControl
    {

        private int idSucursalSeleccionada;
        public ABM_SALAS_UC(int id)
        {

            this.idSucursalSeleccionada = id;
            InitializeComponent();

            Sala_Controller.Salas_Load(grid_salas,id);
            //Sucursal_Controller.Sucursal_Load(grid_salas);
        }

        private void add_salas_Click(object sender, EventArgs e)
        {
            FORM_SALAS_UC formsalas_uc = new FORM_SALAS_UC(this.idSucursalSeleccionada);
            Index_Admin.addUserControl(formsalas_uc);
        }

        private void grid_salas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_salas.Columns["Modificar"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(grid_salas.Rows[e.RowIndex].Cells["id"].Value);


                FORM_SALAS_UC formModificarSucursal = new FORM_SALAS_UC(id);

                Index_Admin.addUserControl(formModificarSucursal);

            }

            else if (e.ColumnIndex == grid_salas.Columns["Borrar"].Index && e.RowIndex >= 0)
            {

                int id = Convert.ToInt32(grid_salas.Rows[e.RowIndex].Cells["id"].Value);


                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    Sucursal_Controller.EliminarRegistroSucursal(id);


                    Sucursal_Controller.Sucursal_Load(this.grid_salas);

                }
            }
            



        }

        private void back_button_Click_SalaToSucursales(object sender, EventArgs e)
        {
            ABM_SUCURSALES_UC sucursales_uc = new ABM_SUCURSALES_UC();
            Index_Admin.addUserControl(sucursales_uc);

        }

       
    }
}
