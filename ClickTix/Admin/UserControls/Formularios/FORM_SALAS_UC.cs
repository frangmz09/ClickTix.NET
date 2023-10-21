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
        private int idDeSucursal;
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
            this.back_pelicula.Click += new System.EventHandler(this.back_pelicula_Click_Crear);
            int valor = Sala_Controller.ObtenerMaxNroSala(id)+1;
            this.valorNroSala.Text = valor.ToString();
            //CargarDatosSala(id);
            this.addsala_btn.Text = "agregar";
                

        }

        public FORM_SALAS_UC(int idSalaAModificar ,int idSucursal )
        {


            //MessageBox.Show("id de sala  a modificar : " + idSalaAModificar);

            //MessageBox.Show("id de sucursal: " + idSucursal);



            this.idDeSucursal = idSucursal;
            this.idDelPanel = idSalaAModificar;
            InitializeComponent();
            this.addsala_btn.Click += new System.EventHandler(this.addsala_btn_Click2);
            this.back_pelicula.Click += new System.EventHandler(this.back_pelicula_Click_Actualizar);
            int valor = Sala_Controller.ObtenerNroSala(idSalaAModificar);
            this.valorNroSala.Text = valor.ToString();
            
            this.addsala_btn.Text = "modificar";

            CargarDatosSala(idSalaAModificar);

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

            Sala s = new Sala();

            MessageBox.Show("id sucursal : " + this.idDelPanel);


            s.Id = this.idDelPanel;
            s.Filas = (int)input_filas.Value;
            s.Columnas = (int)input_columnas.Value;
            s.Capacidad = (int)input_columnas.Value * (int)input_filas.Value;

            int valor = Sala_Controller.ObtenerNroSala(this.idDelPanel);
            s.Nro_Sala = valor ;

            //PrecioDimension_Controller.ActualizarDimension(s);

            Sala_Controller.ActualizarSala(s);


        }





        private void CargarDatosSala(int salaID)
        {
            try
            {
                string consulta = "SELECT id, filas, columnas FROM sala WHERE id = @id";

                ManagerConnection.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(consulta, ManagerConnection.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@id", salaID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            input_filas.Text = reader["filas"].ToString();
                            input_columnas.Text = reader["columnas"].ToString();
                            
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
                ManagerConnection.CloseConnection();
            }
        }

        private void label_cuit_Click(object sender, EventArgs e)
        {

        }

        private void label_titulo_Click(object sender, EventArgs e)
        {

        }

        private void back_pelicula_Click_Crear(object sender, EventArgs e)
        {
            ABM_SALAS_UC abm_salas_uc = new ABM_SALAS_UC(this.idDelPanel);
            Index_Admin.addUserControl(abm_salas_uc);

        }

        private void back_pelicula_Click_Actualizar(object sender, EventArgs e)
        {
            ABM_SALAS_UC abm_salas_uc = new ABM_SALAS_UC(this.idDeSucursal);
            Index_Admin.addUserControl(abm_salas_uc);

        }

        private void addsala_btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
