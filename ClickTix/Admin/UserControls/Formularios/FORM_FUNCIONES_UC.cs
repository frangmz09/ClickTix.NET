using ClickTix.Conexion;
using ClickTix.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.UserControls
{
    public partial class FORM_FUNCIONES_UC : UserControl
    {


        Funcion funcionActual;

        public FORM_FUNCIONES_UC()
        {
            InitializeComponent();
        }

        private void FUNCIONES_UC_Load(object sender, EventArgs e)
        {

            MyConexion c = new MyConexion("localhost", "clicktix", "root", "");

            funcionActual = new Funcion();
            funcionActual.Fecha = combobox_fecha.Value.Date;
            Funcion_Controller.llenarCamposAddFuncion(combobox_pelicula, combobox_turno, combobox_sucursal, combobox_dimension,combobox_idioma);
            
            
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
            funcionActual.Id_Pelicula = Funcion_Controller.obtenerIdPelicula(combobox_pelicula);
            Trace.WriteLine(funcionActual.Id_Pelicula);

        }
        private void cambioFecha(object sender, EventArgs e)
        {
            funcionActual.Fecha = combobox_fecha.Value.Date;

        }
        private void cambioSucursal(object sender, EventArgs e)
        {
            Funcion_Controller.llenarSalas(combobox_sucursal, combobox_sala);
            funcionActual.Id_Sala = 0;
            combobox_sala.SelectedItem = null;
            combobox_sala.Text = "";
        }
        private void cambioTurno(object sender, EventArgs e)
        {
            funcionActual.Id_Turno = Funcion_Controller.obtenerIdTurno(combobox_turno);
        }
        private void cambioSala(object sender, EventArgs e)
        {
            funcionActual.Id_Sala = Funcion_Controller.obtenerIdSala(combobox_sala,combobox_sucursal);
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
        private void addfuncion_btn_Click(object sender, EventArgs e)
        {
            Funcion_Controller.crearFuncion(funcionActual);
            Asiento_Controller.crearDisponibilidad(funcionActual);



        }
    }
}
