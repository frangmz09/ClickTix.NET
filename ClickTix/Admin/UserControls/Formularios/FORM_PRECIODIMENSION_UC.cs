using ClickTix.Admin.UserControls.ABMs;
using ClickTix.Conexion;
using ClickTix.Modelo;
using ClickTix.UserControls;
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

namespace ClickTix.Admin.UserControls.Formularios
{
    public partial class FORM_PRECIODIMENSION_UC : UserControl
    {

        private int idDelPanel;
        public FORM_PRECIODIMENSION_UC()
        {
            InitializeComponent();

            this.adddimension_btn.Click += new System.EventHandler(this.adddimension_btn_Click);
        }

        public FORM_PRECIODIMENSION_UC(int id)
        {
            InitializeComponent();
            this.adddimension_btn.Click += new System.EventHandler(this.adddimension_btn_Click2);
            idDelPanel = id;
            this.idDelPanel = id;
            int dimensionlID = id;

            MessageBox.Show("id : " + id);
            CargarDatosPrecioDimension(dimensionlID);


        }




        private void adddimension_btn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(input_nombre.Text) || input_precio.Value <= 0)
            {
                MessageBox.Show("Los campos deben estar llenos ");
            }
            else
            {
                PrecioDimension pd = new PrecioDimension();

                pd.id = 0;
                pd.precio = input_precio.Value;
                pd.dimension = input_nombre.Text;

                PrecioDimension_Controller.CrearDimension(pd);
            }
            

        }

        private void adddimension_btn_Click2(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(input_nombre.Text) || input_precio.Value <= 0)
            {
                MessageBox.Show("Los campos deben estar llenos ");
            }
            else
            {
                PrecioDimension pd = new PrecioDimension();

                pd.id = this.idDelPanel;
                pd.precio = input_precio.Value;
                pd.dimension = input_nombre.Text;

                PrecioDimension_Controller.ActualizarDimension(pd);
            }

            

        }




        private void back_dimension_Click(object sender, EventArgs e)
        {
            ABM_PRECIODIMENSION_UC abmPrecioDimension = new ABM_PRECIODIMENSION_UC();
            Index_Admin.addUserControl(abmPrecioDimension);
        }





        private void CargarDatosPrecioDimension(int dimensionID)
        {
            try
            {
                string consulta = "SELECT dimension, precio FROM dimension WHERE id = @id";

                ManagerConnection.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(consulta, ManagerConnection.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@id", dimensionID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            input_nombre.Text = reader["dimension"].ToString();
                            input_precio.Value = Convert.ToDecimal(reader["precio"]);
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
            ManagerConnection.CloseConnection();

        }


    }
}

