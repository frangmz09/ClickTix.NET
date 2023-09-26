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

            Funcion_Controller.llenarCamposAddFuncion(combobox_pelicula, combobox_turno, combobox_sucursal, combobox_dimension,combobox_idioma);
            
            
            /*combobox_pelicula.SelectedIndexChanged += ComboBoxSucursal_SelectedIndexChanged;
            combobox_fecha.SelectedIndexChanged += ComboBoxSucursal_SelectedIndexChanged;
            combobox_turno.SelectedIndexChanged += ComboBoxSucursal_SelectedIndexChanged;
            combobox_sucursal.SelectedIndexChanged += ComboBoxSucursal_SelectedIndexChanged;
            combobox_sala.SelectedIndexChanged += ComboBoxSucursal_SelectedIndexChanged;
            combobox_idioma.SelectedIndexChanged += ComboBoxSucursal_SelectedIndexChanged;
            combobox_dimension.SelectedIndexChanged += ComboBoxSucursal_SelectedIndexChanged;*/


        }

        private void back_pelicula_Click(object sender, EventArgs e)
        {
            ABM_FUNCION_UC abmfuncion = new ABM_FUNCION_UC();
            Index_Admin.addUserControl(abmfuncion);
        }


        private void ComboBoxSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Funcion_Controller.llenarSalas(combobox_sucursal, combobox_sala);
        }




        private void addfuncion_btn_Click(object sender, EventArgs e)
        {
            Funcion_Controller.crearFuncion(funcionActual);
        }
    }
}
