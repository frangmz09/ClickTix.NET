using ClickTix.Conexion;
using ClickTix.Modelo;
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
    public partial class FORM_SALAS_UC : UserControl
    {

        private int idDelPanel;
        public FORM_SALAS_UC()
        {
            InitializeComponent();
            this.addsucursal_btn.Click += new System.EventHandler(this.addsucursal_btn_Click);
            
        }

        public FORM_SALAS_UC(int id)
        {
            InitializeComponent();
            
            this.addsucursal_btn.Click += new System.EventHandler(this.addsucursal_btn_Click2);
            this.addsucursal_btn.Text = "Modificar";
            this.idDelPanel = id;
            int sucursalID = id;

            MessageBox.Show("id : " + id);

            CargarDatosSucursal(sucursalID);
           



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void back_pelicula_Click(object sender, EventArgs e)
        {
            ABM_SUCURSALES_UC sucursales_uc = new ABM_SUCURSALES_UC();
            Index_Admin.addUserControl(sucursales_uc);
        }

        private void addsucursal_btn_Click(object sender, EventArgs e)
        {

             
            if (string.IsNullOrWhiteSpace(input_columnas.Text) || string.IsNullOrWhiteSpace(input_filas.Text) 
                || string.IsNullOrWhiteSpace(input_cuit.Text) || input_salas.Value <= 0)
            {
                MessageBox.Show("Los campos deben estar llenos ");
            }
            else
            {
                Sucursal s = new Sucursal();

                s.id = 0;
                s.nombre = input_columnas.Text;
                s.direccion = input_filas.Text;
                s.cuit = input_cuit.Text;
                s.numerosalas = (int)input_salas.Value;

                Sucursal_Controller.CrearSucursal(s);
            }
            
        }

        private void addsucursal_btn_Click2(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(input_columnas.Text) || string.IsNullOrWhiteSpace(input_filas.Text)
                || string.IsNullOrWhiteSpace(input_cuit.Text) || input_salas.Value <= 0)
            {
                MessageBox.Show("Los campos deben estar llenos ");
            }
            else
            {
                Sucursal s = new Sucursal();
                s.id = this.idDelPanel;
                s.nombre = input_columnas.Text;
                s.direccion = input_filas.Text;
                s.cuit = input_cuit.Text;
                s.numerosalas = (int)input_salas.Value;



                Sucursal_Controller.ActualizarSucursal(s);
            }


         
        }

        private void CargarDatosSucursal(int sucursalID)
        {
            try
            {
                string consulta = "SELECT id,nombre,direccion,cuit,numerosalas FROM sucursal WHERE id = @id";

                MyConexion.AbrirConexion();

                using (MySqlCommand cmd = new MySqlCommand(consulta, MyConexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@id", sucursalID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            input_columnas.Text = reader["nombre"].ToString();
                            input_filas.Text = reader["direccion"].ToString();
                            //input_cuit.Text = reader["cuit"].ToString();
                            input_salas.Value = Convert.ToDecimal(reader["numerosalas"]);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la dimensión con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la dimensión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label_cuit_Click(object sender, EventArgs e)
        {

        }

        private void label_titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
