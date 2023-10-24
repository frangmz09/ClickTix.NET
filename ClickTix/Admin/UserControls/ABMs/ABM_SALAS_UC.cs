using ClickTix.Admin.UserControls.Formularios;
using ClickTix.Conexion;
using ClickTix.Controller;
using ClickTix.Modelo;
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

            cargarSalas();
            //Sucursal_Controller.Sucursal_Load(grid_salas);
        }
        private void cargarSalas()
        {

            grid_salas.Rows.Clear();

            List<Sala> dimensiones = Sala_Controller.obtenerTodos(idSucursalSeleccionada);

            foreach (Sala sala in dimensiones)
            {
                int rowIndex = grid_salas.Rows.Add();
                grid_salas.Rows[rowIndex].Cells[0].Value = sala.Id.ToString();
                grid_salas.Rows[rowIndex].Cells[1].Value = sala.Nro_Sala.ToString();
                grid_salas.Rows[rowIndex].Cells[2].Value = sala.Filas.ToString();
                grid_salas.Rows[rowIndex].Cells[3].Value = sala.Columnas.ToString();
                grid_salas.Rows[rowIndex].Cells[4].Value = sala.Capacidad.ToString();
                grid_salas.Rows[rowIndex].Cells[5].Value = "Modificar";
                grid_salas.Rows[rowIndex].Cells[6].Value = "Eliminar";

            }
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
                int id = Convert.ToInt32(grid_salas.Rows[e.RowIndex].Cells["IdSala"].Value);


                FORM_SALAS_UC formModificarSucursal = new FORM_SALAS_UC(id,this.idSucursalSeleccionada);

                Index_Admin.addUserControl(formModificarSucursal);

            }

            else if (e.ColumnIndex == grid_salas.Columns["Borrar"].Index && e.RowIndex >= 0)
            {

                int id = Convert.ToInt32(grid_salas.Rows[e.RowIndex].Cells["IdSala"].Value);


                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    Sala_Controller.EliminarRegistroSala(id);
                    Sala_Controller.Salas_Load(this.grid_salas, idSucursalSeleccionada);

                    //Sucursal_Controller.EliminarRegistroSucursal(id);


                    //Sucursal_Controller.Sucursal_Load(this.grid_salas);

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
