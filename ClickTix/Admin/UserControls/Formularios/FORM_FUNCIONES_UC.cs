using ClickTix.Conexion;
using ClickTix.Controller;
using ClickTix.Modelo;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClickTix.UserControls
{
    public partial class FORM_FUNCIONES_UC : UserControl
    {


        Funcion funcionActual = new Funcion();
        private int idDelPanel;
        Image imagenCargada;
        List<string> peliculaList;
        public FORM_FUNCIONES_UC()
        {
            funcionActual = null;
            InitializeComponent();
            addfuncion_btn.Click += addfuncion_btn_Click;

            this.combobox_turno.Enabled = false;
            this.combobox_sucursal.Enabled = false;
            this.combobox_sala.Enabled = false;
            this.combobox_fecha.Enabled = false;
            this.combobox_idioma.Enabled = false;
            this.combobox_dimension.Enabled = false;
        }

        public FORM_FUNCIONES_UC(int id)
        {
            InitializeComponent();
            this.idDelPanel = id;
            int funcionId = id;
            CargarDatosFuncion(funcionId);
            string rutaImagen = Pelicula_Controller.obtenerFileName(Pelicula_Controller.obtenerIdPorNombre(combobox_pelicula.Text));


            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] data = webClient.DownloadData(rutaImagen);
                    using (MemoryStream mem = new MemoryStream(data))
                    {
                        Image imagen = Image.FromStream(mem);
                        pictureBox1.Image = imagen;
                    }
                }
            }
            catch
            {

            }
            addfuncion_btn.Text = "Modificar";
            addfuncion_btn.Click += addfuncion_btn_Click2;
        }

        private void addfuncion_btn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(combobox_dimension.Text) || string.IsNullOrWhiteSpace(combobox_fecha.Text)
                || string.IsNullOrWhiteSpace(combobox_idioma.Text)
                || string.IsNullOrWhiteSpace(combobox_pelicula.Text) || string.IsNullOrWhiteSpace(combobox_sala.Text)
                || string.IsNullOrWhiteSpace(combobox_sucursal.Text) || string.IsNullOrWhiteSpace(combobox_turno.Text))
            {
                MessageBox.Show("Por favor llene los campos antes de hacer el alta de funcion.");
            }
            else
            {
                
            funcionActual.Id = Funcion_Controller.crearFuncion(funcionActual);
                Asiento_Controller.crearDisponibilidad(funcionActual);


                ABM_FUNCION_UC abmfuncion = new ABM_FUNCION_UC();
                Index_Admin.addUserControl(abmfuncion);
            }



        }

        private void addfuncion_btn_Click2(object sender, EventArgs e)
        {

            Funcion f = new Funcion();

            f.Id = this.idDelPanel;


            f.Fecha = combobox_fecha.Value;

            f.Id_Dimension = Funcion_Controller.obtenerIdDimension(combobox_dimension);
            
            f.Id_Turno = Funcion_Controller.ObtenerIdTurno(combobox_turno);
            
            f.Id_Pelicula = Funcion_Controller.obtenerIdPelicula(combobox_pelicula);
            if (combobox_sala.Enabled == true)
            {
                f.Id_Sala = Funcion_Controller.obtenerIdSala(combobox_sala, combobox_sucursal);

            }
            else
            {
                f.Id_Sala = Funcion_Controller.obtenerIdSalaporFuncion(f.Id);
            }

            f.Id_Idioma = Funcion_Controller.obtenerIdIdioma(combobox_idioma);




            Trace.WriteLine(f.Id_Dimension);
            Funcion_Controller.ActualizarFuncion(f);


            ABM_FUNCION_UC abmfuncion = new ABM_FUNCION_UC();
            Index_Admin.addUserControl(abmfuncion);

        }







        private void FUNCIONES_UC_Load(object sender, EventArgs e)
        {

            funcionActual = new Funcion();
            funcionActual.Fecha = combobox_fecha.Value.Date;
            this.peliculaList = Funcion_Controller.llenarCamposAddFuncion(combobox_pelicula, combobox_turno, combobox_sucursal, combobox_dimension, combobox_idioma);

            combobox_pelicula.SelectedIndexChanged += cambioPelicula;
            combobox_fecha.ValueChanged += cambioFecha;
            combobox_turno.SelectedIndexChanged += cambioTurno;
            combobox_sucursal.SelectedIndexChanged += cambioSucursal;

            combobox_sala.SelectedIndexChanged += cambioSala;

            combobox_idioma.SelectedIndexChanged += cambioIdioma;
            combobox_dimension.SelectedIndexChanged += cambioDimension;


        }

        private void back_pelicula_Click(object sender, EventArgs e)
        {
            ABM_FUNCION_UC abmfuncion = new ABM_FUNCION_UC();
            Index_Admin.addUserControl(abmfuncion);
        }

        private void cambioPelicula(object sender, EventArgs e)
        {
            int idABuscar = Funcion_Controller.obtenerIdPelicula(combobox_pelicula);

            if (idABuscar!=0)
            {
                funcionActual.Id_Pelicula = idABuscar;
                Trace.WriteLine(funcionActual.Id_Pelicula);


                try
                {
                    string rutaImagen = Pelicula_Controller.obtenerFileName(Pelicula_Controller.obtenerIdPorNombre(combobox_pelicula.Text));
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] data = webClient.DownloadData(rutaImagen);
                        using (MemoryStream mem = new MemoryStream(data))
                        {
                            Image imagen = Image.FromStream(mem);
                            pictureBox1.Image = imagen;
                        }
                    }
                }
                catch
                {

                }
                this.combobox_sucursal.Enabled = true;
                this.combobox_fecha.Enabled = true;
                this.combobox_idioma.Enabled = false;
                this.combobox_dimension.Enabled = false;
                this.combobox_sala.Enabled = false;
                funcionActual.Id_Turno = 0;

                combobox_turno.Enabled = false;
                combobox_turno.SelectedItem = null;
                combobox_turno.Text = "";

            }

        }
        private void cambioFecha(object sender, EventArgs e)
        {
            llenarTurnosDisponibles();
            


            funcionActual.Fecha = combobox_fecha.Value.Date;
            this.combobox_sucursal.Enabled = true;
            
            this.combobox_idioma.Enabled = false;
            combobox_idioma.SelectedItem = null;
            combobox_idioma.Text = "";
            this.combobox_dimension.Enabled = false;
            combobox_dimension.SelectedItem = null;
            combobox_dimension.Text = "";
            this.combobox_sala.Enabled = true;
            combobox_sala.SelectedItem = null;
            combobox_sala.Text = "";

            combobox_turno.Enabled=false;
            combobox_turno.SelectedItem = null;
            combobox_turno.Text = "";
        }
        private void cambioSucursal(object sender, EventArgs e)
        {
            Funcion_Controller.llenarSalas(combobox_sucursal, combobox_sala);
            funcionActual.Id_Sala = 0;
            combobox_sala.SelectedItem = null;
            combobox_sala.Text = "";
            this.combobox_sala.Enabled = true;
            funcionActual.Id_Turno = 0;
            
            combobox_turno.Enabled = false;
            combobox_turno.SelectedItem = null;
            combobox_turno.Text = "";


            this.combobox_turno.Enabled = false;
            this.combobox_fecha.Enabled = true;
            this.combobox_idioma.Enabled = false;
            this.combobox_dimension.Enabled = false;

        }
        private void cambioTurno(object sender, EventArgs e)
        {
            funcionActual.Id_Turno = Funcion_Controller.ObtenerIdTurno(combobox_turno);
            this.combobox_idioma.Enabled = true;
            this.combobox_dimension.Enabled = true;
        }
        private void cambioSala(object sender, EventArgs e)
        {
            funcionActual.Id_Sala = Funcion_Controller.obtenerIdSala(combobox_sala, combobox_sucursal);
            funcionActual.Id_Turno = 0;

            combobox_turno.Enabled = false;
            combobox_turno.SelectedItem = null;
            combobox_turno.Text = "";


            llenarTurnosDisponibles();
        }
        private void cambioIdioma(object sender, EventArgs e)
        {
            funcionActual.Id_Idioma = Funcion_Controller.obtenerIdIdioma(combobox_idioma);
        }
        private void cambioDimension(object sender, EventArgs e)
        {
            funcionActual.Id_Dimension = Funcion_Controller.obtenerIdDimension(combobox_dimension);
            Trace.WriteLine(funcionActual.Id_Dimension);
        }



        private void CargarDatosFuncion(int funcionID)
        {
            try
            {
                string consulta = "SELECT f.fecha, d.dimension, s.nro_sala, p.titulo, i.idioma, t.hora,su.nombre FROM funcion f INNER JOIN sala s ON s.id = f.id_sala  INNER JOIN pelicula p ON p.id = f.id_pelicula  INNER JOIN turno t ON t.id = f.turno_id  INNER JOIN dimension d ON d.id = f.id_dimension INNER JOIN idioma i ON i.id = f.idioma_funcion INNER JOIN sucursal su ON s.id_sucursal = su.id WHERE f.id = @id;";

                ManagerConnection.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(consulta, ManagerConnection.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@id", funcionID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            combobox_fecha.Text = reader["fecha"].ToString();
                            combobox_dimension.Text = reader["dimension"].ToString();
                            combobox_pelicula.Text = reader["titulo"].ToString();
                            combobox_idioma.Text = reader["idioma"].ToString();
                            combobox_turno.Text = reader["hora"].ToString();
                            combobox_sala.Text = reader["nro_sala"].ToString();
                            combobox_sucursal.Text = reader["nombre"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("No se encontró la función con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la función: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ManagerConnection.CloseConnection();

        }

        private void llenarTurnosDisponibles()
        {
            combobox_turno.Items.Clear();
            this.combobox_turno.Enabled = true;
            int idSucursal = Funcion_Controller.ObtenerIdSucursalPorIdSala(Funcion_Controller.obtenerIdSala(combobox_sala, combobox_sucursal));



            List<int> listaTurnosCompleta= Funcion_Controller.ObtenerTodosLosIdsDeTurno();

            List<int> listaTurnosUsados = Funcion_Controller.ObtenerTurnosPorPeliculaYSalaYFecha(Funcion_Controller.obtenerIdPelicula( combobox_pelicula), Funcion_Controller.obtenerIdSala(combobox_sala, combobox_sucursal), combobox_fecha.Value.Date);


            List<int> listaSinRepetidos = listaTurnosCompleta
                .Union(listaTurnosUsados)
                .Except(listaTurnosCompleta.Intersect(listaTurnosUsados))
                .ToList();


            List<int> listaTurnosDisponibles = listaSinRepetidos;

            foreach (int valor in listaTurnosDisponibles)
            {
                Console.WriteLine(valor);
            }


            Funcion_Controller.LlenarTurnos(combobox_turno, listaTurnosDisponibles);



        }

        private void back_pelicula_Click_1(object sender, EventArgs e)
        {
            ABM_FUNCION_UC abmfuncion = new ABM_FUNCION_UC();
            Index_Admin.addUserControl(abmfuncion);
        }
    }
}
