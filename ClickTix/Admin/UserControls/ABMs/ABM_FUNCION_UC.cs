using ClickTix.Conexion;
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
    public partial class ABM_FUNCION_UC : UserControl
    {
        public ABM_FUNCION_UC()
        {
            InitializeComponent();
            Funcion_Controller.Funcion_Load(this.grid_funciones);
        }

       

        private void grid_funciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_funciones.Columns["Modificar"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(grid_funciones.Rows[e.RowIndex].Cells["id"].Value);


                FORM_FUNCIONES_UC formModificarFuncion = new FORM_FUNCIONES_UC(id);

                Index_Admin.addUserControl(formModificarFuncion);

            }

            else if (e.ColumnIndex == grid_funciones.Columns["Borrar"].Index && e.RowIndex >= 0)
            {

                int id = Convert.ToInt32(grid_funciones.Rows[e.RowIndex].Cells["id"].Value);


                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    
                    Funcion_Controller.EliminarRegistroFuncion(id);


                    Funcion_Controller.Funcion_Load(this.grid_funciones);

                }
            }
        }





     
        private void add_funcion_Click(object sender, EventArgs e)
        {
            FORM_FUNCIONES_UC formfunciones_uc = new FORM_FUNCIONES_UC();
            Index_Admin.addUserControl(formfunciones_uc);
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        
    }
}
