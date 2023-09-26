using ClickTix.Conexion;
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

namespace ClickTix.UserControls
{
    public partial class ABM_EMPLEADOS_UC : UserControl
    {
        public ABM_EMPLEADOS_UC()
        {
            InitializeComponent();
            ABM_EMPLEADOS_UC_Load(grid_empleados);
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void add_empleado_Click(object sender, EventArgs e)
        {
            FORM_EMPLEADOS_UC formempleados_uc = new FORM_EMPLEADOS_UC();
            Index_Admin.addUserControl(formempleados_uc);

        }

        private void grid_empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ABM_EMPLEADOS_UC_Load(DataGridView tabla)
        {
            MyConexion.AbrirConexion();


            string query = "SELECT  id, nombre, apellido, id_sucursal, is_admin FROM usuario_sistema";

            using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
            {
                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();


                    adapter.Fill(dt);


                    tabla.DataSource = dt;
                }
            }
        }

        private void ABM_EMPLEADOS_UC_Load(object sender, EventArgs e)
        {

        }
    }
}
