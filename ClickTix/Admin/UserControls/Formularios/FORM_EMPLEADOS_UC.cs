using ClickTix.Conexion;
using ClickTix.Modelo;
using ClickTix.UserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix
{
    public partial class FORM_EMPLEADOS_UC : UserControl
    {
        internal static DialogResult showdialog;
        private Usuario usuario;
        private int idDelPanel;
        public DialogResult Dialogresult { get; private set; }

        public FORM_EMPLEADOS_UC(int id)
        {
            this.idDelPanel = id;
            int empleadoId = id;


            InitializeComponent();
            LlenarComboBoxSucursales();
            
            CargarDatosEmpleado(empleadoId);
            this.addempleado_btn.Click += new System.EventHandler(this.addempleado_btn_Click2);
        }
        public FORM_EMPLEADOS_UC()
        {
            InitializeComponent();
            LlenarComboBoxSucursales();
            this.addempleado_btn.Click += new System.EventHandler(this.addempleado_btn_Click);
           
        }

        private void addempleado_btn_Click2(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(input_nombre.Text) || string.IsNullOrWhiteSpace(input_apellido.Text)
               || string.IsNullOrWhiteSpace(input_usuario.Text) || string.IsNullOrWhiteSpace(input_contraseña.Text)
               || string.IsNullOrWhiteSpace(input_sucursal.Text))
            {
                MessageBox.Show("Los campos deben estar llenos ");
            }
            else
            {

                EmpleadoA em = new EmpleadoA();


                em.Id = this.idDelPanel;

                em.Nombre = input_nombre.Text;
                em.Apellido = input_apellido.Text;
                em.Usuario = input_usuario.Text;
                em.Pass = input_contraseña.Text;

                int idSucursal = Empleado_Controller.ObtenerIdSucursal(input_nombre.Text);
                em.Id_Sucursal = idSucursal;



                Empleado_Controller.ActualizarEmpleado(em);
                ABM_EMPLEADOS_UC abmempleados = new ABM_EMPLEADOS_UC();
                Index_Admin.addUserControl(abmempleados);
            }




           
            


        }

        private void back_pelicula_Click(object sender, EventArgs e)
        {
            ABM_EMPLEADOS_UC abmempleados = new ABM_EMPLEADOS_UC();
            Index_Admin.addUserControl(abmempleados);
        }

        private void addempleado_btn_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(input_nombre.Text) || string.IsNullOrWhiteSpace(input_apellido.Text ) 
                || string.IsNullOrWhiteSpace(input_usuario.Text )|| string.IsNullOrWhiteSpace(input_contraseña.Text )
                || string.IsNullOrWhiteSpace(input_sucursal.Text))
            {
                MessageBox.Show("Los campos deben estar llenos ");
            }
            else
            {
                MessageBox.Show("value " + input_sucursal.Text);
                EmpleadoA em = new EmpleadoA();
                int idSucursal = 0;
                em.Id = 0;
                em.Nombre = input_nombre.Text;
                em.Apellido = input_apellido.Text;
                em.Usuario = input_usuario.Text;
                em.Pass = input_contraseña.Text;

                idSucursal = Empleado_Controller.ObtenerIdSucursal(input_sucursal.Text);


                em.Id_Sucursal = idSucursal;

                Trace.WriteLine(idSucursal);

                Empleado_Controller.CrearEmpleado(em);
                ABM_EMPLEADOS_UC abmempleados = new ABM_EMPLEADOS_UC();
                Index_Admin.addUserControl(abmempleados);

            }



            
            


        }

        private void input_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarDatosEmpleado(int empleadoId)
        {
            try
            {

                string consulta = "SELECT nombre, apellido, pass, id_sucursal, usuario  FROM usuario_sistema WHERE id =" + empleadoId;


                ManagerConnection.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(consulta, ManagerConnection.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@id", empleadoId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())


                    {
                        if (reader.Read())
                        {


                            input_nombre.Text = reader["nombre"].ToString();
                            input_apellido.Text = reader["apellido"].ToString();
                            input_contraseña.Text = reader["pass"].ToString();
                            input_usuario.Text = reader["usuario"].ToString();


                        }
                        else
                        {
                            MessageBox.Show("No se encontró al empleado con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ManagerConnection.CloseConnection();
        }

        internal static DialogResult Showdialog()
        {
            throw new NotImplementedException();
        }

        private void FORM_EMPLEADOS_UC_Load(object sender, EventArgs e)
        {

        }


        private void LlenarComboBoxSucursales()
        {
            try
            {
                ManagerConnection.OpenConnection();
                string consultaSucursales = "SELECT id, nombre FROM sucursal"; 

                using (MySqlCommand cmdSucursales = new MySqlCommand(consultaSucursales, ManagerConnection.getInstance()))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmdSucursales.ExecuteReader());

                    
                    input_sucursal.DataSource = dt;

                   
                    input_sucursal.DisplayMember = "nombre";

                   
                    input_sucursal.ValueMember = "id";

                    
                    //input_sucursal.SelectedValue = idSucursalSeleccionada;

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox de sucursales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ManagerConnection.CloseConnection();

        }
    }
}
