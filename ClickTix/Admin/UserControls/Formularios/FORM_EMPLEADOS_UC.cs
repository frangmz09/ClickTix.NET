﻿using ClickTix.Conexion;
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

            input_sucursal.Items.Clear();

            input_sucursal.Items.Add(0);
            input_sucursal.Items.Add(1);
            input_sucursal.Items.Add(2);
            CargarDatosEmpleado(empleadoId);
            this.addempleado_btn.Click += new System.EventHandler(this.addempleado_btn_Click2);
        }
        public FORM_EMPLEADOS_UC()
        {
            InitializeComponent();
            this.addempleado_btn.Click += new System.EventHandler(this.addempleado_btn_Click);
            input_sucursal.Items.Clear();

            input_sucursal.Items.Add(0);
            input_sucursal.Items.Add(1);
            input_sucursal.Items.Add(2);
        }

        private void addempleado_btn_Click2(object sender, EventArgs e)
        {
            Usuario u = new Usuario();

            u.Id = this.idDelPanel;

            u.Nombre = input_nombre.Text;
            u.Apellido = input_apellido.Text;
            u.usuario = input_usuario.Text;
            u.pass = input_contraseña.Text;
            u.Id_sucursal = input_sucursal.Text;




           //Usuario_Controller.ActualizarUsuario(u);
            


        }

        private void back_pelicula_Click(object sender, EventArgs e)
        {
            ABM_EMPLEADOS_UC abmempleados = new ABM_EMPLEADOS_UC();
            Index_Admin.addUserControl(abmempleados);
        }

        private void addempleado_btn_Click(object sender, EventArgs e)
        {

           
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


                MyConexion.AbrirConexion();

                using (MySqlCommand cmd = new MySqlCommand(consulta, MyConexion.ObtenerConexion()))
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
        }

        internal static DialogResult Showdialog()
        {
            throw new NotImplementedException();
        }

        private void FORM_EMPLEADOS_UC_Load(object sender, EventArgs e)
        {

        }
    }
}
