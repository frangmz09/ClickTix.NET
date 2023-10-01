using ClickTix.Conexion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.UserControls
{
    public partial class ABM_EMPLEADOS_UC : UserControl
    {
        MyConexion c;
        public ABM_EMPLEADOS_UC()
        {
            InitializeComponent();
            ABM_EMPLEADOS_UC_Load(grid_empleados);
            c = new MyConexion("localhost", "clicktix", "root", "");

            ABM_EMPLEADOS_UC_Load(grid_empleados);
        }

        public ABM_EMPLEADOS_UC(int id)
        {
            InitializeComponent();
            ABM_EMPLEADOS_UC_Load(grid_empleados);
            c = new MyConexion("localhost", "clicktix", "root", "");

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
            if (e.ColumnIndex == grid_empleados.Columns["Modificar"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(grid_empleados.Rows[e.RowIndex].Cells["id"].Value);

                MessageBox.Show("id : " + id);
                FORM_EMPLEADOS_UC formempleados_uc = new FORM_EMPLEADOS_UC(id);

                Index_Admin.addUserControl(formempleados_uc);

            }

            else if (e.ColumnIndex == grid_empleados.Columns["Borrar"].Index && e.RowIndex >= 0)
            {

                int id = Convert.ToInt32(grid_empleados.Rows[e.RowIndex].Cells["id"].Value);


                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    EliminarRegistro(id);
                    ABM_EMPLEADOS_UC_Load(grid_empleados);
                }
            }
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

        public bool EliminarRegistro(int id)
        {
            try
            {
                using (MySqlConnection mysqlConnection = MyConexion.ObtenerConexion())
                {
                    mysqlConnection.Open();
                    string query = "DELETE FROM usuario_sistema WHERE id = @id";

                    using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ABM_EMPLEADOS_UC_Load(object sender, EventArgs e)
        {

        }
    }
}
