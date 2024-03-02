using ClickTix.Conexion;
using ClickTix.Controller;
using ClickTix.Modelo;
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
        public ABM_EMPLEADOS_UC()
        {
            InitializeComponent();
            cargarEmpleados();
            search_employees.TextChanged += TxtSearch_TextChanged;


        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = search_employees.Text.Trim().ToLower();
            List<EmpleadoA> empleadosEncontrados = Empleado_Controller.BuscarEmpleados(searchTerm);
            CargarEmpleadosEnGrid(empleadosEncontrados);
        }

        private void CargarEmpleadosEnGrid(List<EmpleadoA> empleados)
        {
            grid_empleados.Rows.Clear();

            foreach (EmpleadoA empleado in empleados)
            {
                int rowIndex = grid_empleados.Rows.Add();

                grid_empleados.Rows[rowIndex].Cells[0].Value = empleado.Id.ToString();
                grid_empleados.Rows[rowIndex].Cells[1].Value = empleado.Nombre.ToString();
                grid_empleados.Rows[rowIndex].Cells[2].Value = empleado.Apellido.ToString();
                grid_empleados.Rows[rowIndex].Cells[3].Value = Sucursal_Controller.ObtenerNombreSucursalPorID(empleado.Id_Sucursal);
                grid_empleados.Rows[rowIndex].Cells[4].Value = empleado.Usuario.ToString();
                if (empleado.is_admin.ToString() == "1")
                {
                    grid_empleados.Rows[rowIndex].Cells[5].Value = "Administrador";

                }
                else
                {

                    grid_empleados.Rows[rowIndex].Cells[5].Value = "Empleado";
                }
                grid_empleados.Rows[rowIndex].Cells[6].Value = "Modificar";
                grid_empleados.Rows[rowIndex].Cells[7].Value = "Eliminar";

            }
        }

        public ABM_EMPLEADOS_UC(int id)
        {
            InitializeComponent();
            cargarEmpleados();

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

                FORM_EMPLEADOS_UC formempleados_uc = new FORM_EMPLEADOS_UC(id);

                Index_Admin.addUserControl(formempleados_uc);

            }
            else if (e.ColumnIndex == grid_empleados.Columns["Borrar"].Index && e.RowIndex >= 0)
            {


                int id2 = Convert.ToInt32(grid_empleados.Rows[e.RowIndex].Cells["id"].Value);


                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    EliminarRegistro(id2);
                    cargarEmpleados();
                }
            }
        }


        private void cargarEmpleados()
        {
            grid_empleados.Rows.Clear();

            List<EmpleadoA> empleados = Empleado_Controller.obtenerTodos();
            foreach (EmpleadoA empleado in empleados)
            {
                int rowIndex = grid_empleados.Rows.Add();

                grid_empleados.Rows[rowIndex].Cells[0].Value = empleado.Id.ToString();
                grid_empleados.Rows[rowIndex].Cells[1].Value = empleado.Nombre.ToString();
                grid_empleados.Rows[rowIndex].Cells[2].Value = empleado.Apellido.ToString();
                grid_empleados.Rows[rowIndex].Cells[3].Value = Sucursal_Controller.ObtenerNombreSucursalPorID(empleado.Id_Sucursal);
                grid_empleados.Rows[rowIndex].Cells[4].Value = empleado.Usuario.ToString();
                if (empleado.is_admin.ToString() == "1")
                {
                    grid_empleados.Rows[rowIndex].Cells[5].Value = "Administrador";

                }
                else
                {

                    grid_empleados.Rows[rowIndex].Cells[5].Value = "Empleado";
                }   
                grid_empleados.Rows[rowIndex].Cells[6].Value = "Modificar";
                grid_empleados.Rows[rowIndex].Cells[7].Value = "Eliminar";

            }
        }

        public bool EliminarRegistro(int id)
        {
            try
            {
                using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
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
