using ClickTix.Conexion;
using ClickTix.Controller;
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
            this.addsala_btn.Click += new System.EventHandler(this.addsala_btn_Click);

        }

        public FORM_SALAS_UC(int id)
        {
            this.idDelPanel = id;
            InitializeComponent();
            this.addsala_btn.Click += new System.EventHandler(this.addsala_btn_Click);
            //CargarDatosSala(id);

        }





        private void addsala_btn_Click(object sender, EventArgs e)
        {
            Sala s = new Sala();


            MessageBox.Show("id: "+ idDelPanel);
            s.Id_Sucursal = this.idDelPanel;
            s.Filas = (int)input_filas.Value;
            s.Columnas = (int)input_columnas.Value;
            s.Capacidad = (int)input_columnas.Value * (int)input_filas.Value;
            s.Nro_Sala = Sala_Controller.ObtenerMaxNroSala(idDelPanel) + 1;


            Sala_Controller.CrearSala(s);
        }

        private void addsala_btn_Click2(object sender, EventArgs e)
        {


        }





        private void CargarDatosSala(int salaID)
        {
            try
            {
                string consulta = "SELECT id, filas, columna, capacidad, nro_sala FROM sala WHERE id = @id";

                MyConexion.AbrirConexion();

                using (MySqlCommand cmd = new MySqlCommand(consulta, MyConexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@id", salaID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            input_filas.Text = reader["filas"].ToString();
                            input_columnas.Text = reader["columna"].ToString();
                            valorCapacidad.Text = reader["capacidad"].ToString();
                            valorNroSala.Text = reader["nro_sala"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la sala con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la sala: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //MyConexion.CerrarConexion();
            }
        }

        private void label_cuit_Click(object sender, EventArgs e)
        {

        }

        private void label_titulo_Click(object sender, EventArgs e)
        {

        }

        private void back_pelicula_Click_1(object sender, EventArgs e)
        {
            ABM_SALAS_UC sucursales_uc = new ABM_SALAS_UC(this.idDelPanel);
            Index_Admin.addUserControl(sucursales_uc);

        }

        private void addsala_btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
