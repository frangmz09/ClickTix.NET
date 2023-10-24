using ClickTix.Admin.UserControls.Formularios;
using ClickTix.Conexion;
using ClickTix.Controller;
using ClickTix.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            cargarSucursales();
        }
        private void cargarSucursales() {

            grid_sucursal.Rows.Clear();

            List<Sucursal> sucursales = Sucursal_Controller.obtenerTodos();
            
            foreach (Sucursal sucursal in sucursales)
            {
                int rowIndex = grid_sucursal.Rows.Add();
                grid_sucursal.Rows[rowIndex].Cells[0].Value = sucursal.id.ToString();
                grid_sucursal.Rows[rowIndex].Cells[1].Value = sucursal.nombre.ToString();
                grid_sucursal.Rows[rowIndex].Cells[2].Value = sucursal.cuit.ToString();
                grid_sucursal.Rows[rowIndex].Cells[3].Value = sucursal.direccion.ToString();
                grid_sucursal.Rows[rowIndex].Cells[4].Value = "Salas";
                grid_sucursal.Rows[rowIndex].Cells[6].Value = "Modificar";
                grid_sucursal.Rows[rowIndex].Cells[5].Value = "Eliminar";

            }
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
                int id = Convert.ToInt32(grid_sucursal.Rows[e.RowIndex].Cells["Idd"].Value);

                
                FORM_SUCURSALES_UC formModificarSucursal = new FORM_SUCURSALES_UC(id);

                Index_Admin.addUserControl(formModificarSucursal);

            }

            else if (e.ColumnIndex == grid_sucursal.Columns["Borrar"].Index && e.RowIndex >= 0)
            {

                int id = Convert.ToInt32(grid_sucursal.Rows[e.RowIndex].Cells["Idd"].Value);


                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    Sucursal_Controller.EliminarRegistroSucursal(id);


                    cargarSucursales();
                }
            }
            else if (e.ColumnIndex == grid_sucursal.Columns["Salas"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(grid_sucursal.Rows[e.RowIndex].Cells["Idd"].Value);

               
                ABM_SALAS_UC abmSalas = new ABM_SALAS_UC(id);

                Index_Admin.addUserControl(abmSalas);

            }



        }
    }
}
