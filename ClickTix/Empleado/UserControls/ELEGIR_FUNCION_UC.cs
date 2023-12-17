using ClickTix.Conexion;
using ClickTix.Controller;
using ClickTix.Empleado.UserControls;
using ClickTix.Modelo;
using ClickTix.UserControls;
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

namespace ClickTix.Empleado
{
    public partial class ELEGIR_FUNCION_UC : UserControl
    {
        private int idPelicula;
        private string tituloP;
        public ELEGIR_FUNCION_UC()
        {
            InitializeComponent();

            cargarFunciones();

            comboBoxDimension.SelectedIndexChanged += aplicarFiltros;
            comboBoxFechas.SelectedIndexChanged += aplicarFiltros;
            comboBoxPeliculas.SelectedIndexChanged += aplicarFiltros;


        }


        public ELEGIR_FUNCION_UC(string titulo,int id)
        {
            this.idPelicula = id;
            InitializeComponent();
            this.tituloP = titulo;
            cargarFunciones();




        }
        private void cargarFunciones()
        {

            grid_funcionesc.Rows.Clear();
            List<Funcion> funciones = Funcion_Controller.obtenerTodosPorSucursal();

            foreach (Funcion funcion in funciones)
            {
                int rowIndex = grid_funcionesc.Rows.Add();
                grid_funcionesc.Rows[rowIndex].Cells[0].Value = funcion.Id.ToString();
                grid_funcionesc.Rows[rowIndex].Cells[1].Value = funcion.peliculaNombre.ToString();
                grid_funcionesc.Rows[rowIndex].Cells[2].Value = funcion.nroSala.ToString();
                grid_funcionesc.Rows[rowIndex].Cells[3].Value = funcion.dimension.ToString();
                grid_funcionesc.Rows[rowIndex].Cells[4].Value = funcion.idioma.ToString();
                grid_funcionesc.Rows[rowIndex].Cells[5].Value = funcion.precio.ToString();
                grid_funcionesc.Rows[rowIndex].Cells[6].Value = funcion.Fecha.ToShortDateString();
                grid_funcionesc.Rows[rowIndex].Cells[7].Value = funcion.hora.ToString();
                grid_funcionesc.Rows[rowIndex].Cells[8].Value = "Seleccionar";

            }
            List<string> peliculas = Funcion_Controller.obtenerTodosTitulosPorSucursal();
            peliculas.Insert(0, "Todas las películas");
            comboBoxPeliculas.DataSource = peliculas;

            List<string> fechas = Funcion_Controller.obtenerTodasFechasPorSucursal();
            fechas.Insert(0, "Todas los dias");
            comboBoxFechas.DataSource = fechas;

            List<string> dimensiones = Funcion_Controller.obtenerTodasDimensionesPorSucursal();
            dimensiones.Insert(0, "Todas las dimensiones");
            comboBoxDimension.DataSource = dimensiones;
            
        }

        private void aplicarFiltros(object sender, EventArgs e)
        {
            Dictionary<string, object> filtros = new Dictionary<string, object>();

            string tituloSeleccionado = comboBoxPeliculas.SelectedItem.ToString();
            string fechaSeleccionada = comboBoxFechas.SelectedItem.ToString();
            string dimensionSeleccionada = comboBoxDimension.SelectedItem.ToString();

            if (tituloSeleccionado != "Todas las películas")
                filtros.Add("Titulo", tituloSeleccionado);

            if (fechaSeleccionada != "Todas los dias")
                filtros.Add("Fecha", DateTime.Parse(fechaSeleccionada));

            if (dimensionSeleccionada != "Todas las dimensiones")
                filtros.Add("Dimension", dimensionSeleccionada);

            List<Funcion> funcionesFiltradas = Funcion_Controller.obtenerPorFiltros(filtros);

            cargarFuncionesEnGrid(funcionesFiltradas);
        }
        private void cargarFuncionesEnGrid(List<Funcion> funciones)
        {
            grid_funcionesc.Rows.Clear();

            foreach (Funcion funcion in funciones)
            {
                int rowIndex = grid_funcionesc.Rows.Add();
                grid_funcionesc.Rows[rowIndex].Cells[0].Value = funcion.Id.ToString();
                grid_funcionesc.Rows[rowIndex].Cells[1].Value = funcion.peliculaNombre.ToString();
                grid_funcionesc.Rows[rowIndex].Cells[2].Value = funcion.nroSala.ToString();
                grid_funcionesc.Rows[rowIndex].Cells[3].Value = funcion.dimension.ToString();
                grid_funcionesc.Rows[rowIndex].Cells[4].Value = funcion.idioma.ToString();
                grid_funcionesc.Rows[rowIndex].Cells[5].Value = funcion.precio.ToString();
                grid_funcionesc.Rows[rowIndex].Cells[6].Value = funcion.Fecha.ToShortDateString();
                grid_funcionesc.Rows[rowIndex].Cells[7].Value = funcion.hora.ToString();
                grid_funcionesc.Rows[rowIndex].Cells[8].Value = "Seleccionar";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cartelera_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_funcionesc.Columns["Seleccionar"].Index && e.RowIndex >= 0)
            {
                int id_funcion = Convert.ToInt32(grid_funcionesc.Rows[e.RowIndex].Cells["idFunSel"].Value);


                BUTACAS_UC butacas = new BUTACAS_UC(id_funcion, idPelicula);
                Trace.WriteLine(idPelicula);
                Trace.WriteLine(id_funcion);

                Index_User.addUserControlUsuario(butacas);

            }
        }

        private void ELEGIR_FUNCION_UC_Load(object sender, EventArgs e)
        {
            
        }

        private void back_pelicula_Click(object sender, EventArgs e)
        {
            MENU_UC menu = new MENU_UC();
            Index_User.addUserControlUsuario(menu);
        }
    }
}
