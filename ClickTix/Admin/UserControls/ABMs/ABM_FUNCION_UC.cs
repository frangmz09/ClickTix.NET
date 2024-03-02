using ClickTix.Conexion;
using ClickTix.Controller;
using ClickTix.Modelo;
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
    public partial class ABM_FUNCION_UC : UserControl
    {
        public ABM_FUNCION_UC()
        {
            InitializeComponent();
            cargarFunciones();
            search_films.TextChanged += aplicarFiltros;
            comboboxSucursales.SelectedIndexChanged += aplicarFiltros;
            comboboxTiemp.SelectedIndexChanged += aplicarFiltros;

        }

        private void aplicarFiltros(object sender, EventArgs e)
        {
            Dictionary<string, object> filtros = new Dictionary<string, object>();
            string peliculaBuscada = search_films.Text.Trim().ToLower();
            string sucursalSeleccionada = comboboxSucursales.SelectedItem.ToString();
            string tiempoSeleccionado = comboboxTiemp.SelectedItem.ToString();

            if (peliculaBuscada != "") { 
                filtros.Add("Titulo", peliculaBuscada);
             }
            if (sucursalSeleccionada != "Todas las sucursales") {
                int idSucursal = Sucursal_Controller.ObtenerIdPorNombre(sucursalSeleccionada);
                filtros.Add("Sucursal", idSucursal);
            }
            if (tiempoSeleccionado != "Todas") { 
                filtros.Add("Tiempo", tiempoSeleccionado);
            }

            List<Funcion> funcionesFiltradas = Funcion_Controller.obtenerPorFiltrosABM(filtros);

            cargarFuncionesEnGrid(funcionesFiltradas);
        }

        private void cargarFuncionesEnGrid(List<Funcion> funcionesEncontradas)
        {
            notFound.Visible = false;
            grid_funciones.Rows.Clear();
            if (funcionesEncontradas.Count == 0)
            {
                notFound.Visible = true;
            }
            else
            {
                foreach (Funcion funcion in funcionesEncontradas)
                {
                    int rowIndex = grid_funciones.Rows.Add();

                    grid_funciones.Rows[rowIndex].Cells[0].Value = funcion.Id.ToString();
                    grid_funciones.Rows[rowIndex].Cells[1].Value = Pelicula_Controller.ObtenerNombrePeliculaPorID(funcion.Id_Pelicula);
                    grid_funciones.Rows[rowIndex].Cells[2].Value = funcion.Fecha.ToShortDateString();
                    grid_funciones.Rows[rowIndex].Cells[3].Value = Funcion_Controller.ObtenerHorarioPorID(funcion.Id_Turno);
                    grid_funciones.Rows[rowIndex].Cells[4].Value = Sala_Controller.ObtenerNroSala(funcion.Id_Turno);
                    grid_funciones.Rows[rowIndex].Cells[5].Value = Funcion_Controller.ObtenerIdiomaFuncion(funcion.Id_Idioma);
                    grid_funciones.Rows[rowIndex].Cells[6].Value = Funcion_Controller.obtenerDimensionDesdeId(funcion.Id_Dimension);
                    grid_funciones.Rows[rowIndex].Cells[7].Value = Funcion_Controller.obtenerSucursalDesdeIdSala(funcion.Id_Sala);
                    grid_funciones.Rows[rowIndex].Cells[8].Value = "Modificar";
                    grid_funciones.Rows[rowIndex].Cells[9].Value = "Eliminar";

                }
            }
        }



        private void grid_funciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_funciones.Columns["Modificar"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(grid_funciones.Rows[e.RowIndex].Cells["id"].Value);


                FORM_FUNCIONES_UC formModificarFuncion = new FORM_FUNCIONES_UC(id);

                Index_Admin.addUserControl(formModificarFuncion);

            }

            else if (e.ColumnIndex == grid_funciones.Columns["Borrar"].Index && e.RowIndex >= 0)
            {

                int id = Convert.ToInt32(grid_funciones.Rows[e.RowIndex].Cells["id"].Value);


                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    
                    Funcion_Controller.EliminarRegistroFuncion(id);


                    cargarFunciones();

                }
            }
        }





        private void cargarFunciones()
        {
            notFound.Visible = false;

            grid_funciones.Rows.Clear();

            List<Funcion> funciones = Funcion_Controller.obtenerTodos();
            if (funciones.Count == 0)
            {
                notFound.Visible = true;
            }
            else
            {
                foreach (Funcion funcion in funciones)
                {
                    int rowIndex = grid_funciones.Rows.Add();

                    grid_funciones.Rows[rowIndex].Cells[0].Value = funcion.Id.ToString();
                    grid_funciones.Rows[rowIndex].Cells[1].Value = Pelicula_Controller.ObtenerNombrePeliculaPorID(funcion.Id_Pelicula);
                    grid_funciones.Rows[rowIndex].Cells[2].Value = funcion.Fecha.ToShortDateString();
                    grid_funciones.Rows[rowIndex].Cells[3].Value = Funcion_Controller.ObtenerHorarioPorID(funcion.Id_Turno);
                    grid_funciones.Rows[rowIndex].Cells[4].Value = Sala_Controller.ObtenerNroSala(funcion.Id_Turno);
                    grid_funciones.Rows[rowIndex].Cells[5].Value = Funcion_Controller.ObtenerIdiomaFuncion(funcion.Id_Idioma);
                    grid_funciones.Rows[rowIndex].Cells[6].Value = Funcion_Controller.obtenerDimensionDesdeId(funcion.Id_Dimension);
                    grid_funciones.Rows[rowIndex].Cells[7].Value = Funcion_Controller.obtenerSucursalDesdeIdSala(funcion.Id_Sala);
                    grid_funciones.Rows[rowIndex].Cells[8].Value = "Modificar";
                    grid_funciones.Rows[rowIndex].Cells[9].Value = "Eliminar";

                }
            }

            List<string> sucursales = Sucursal_Controller.obtenerNombresSucursalesSinAdministrador();
            sucursales.Insert(0, "Todas las sucursales");
            comboboxSucursales.DataSource = sucursales;

            List<string> funcionesTiemp = new List<string> { "Todas", "Proximas", "Pasadas"};
            comboboxTiemp.DataSource = funcionesTiemp;
        }
        private void add_funcion_Click(object sender, EventArgs e)
        {
            FORM_FUNCIONES_UC formfunciones_uc = new FORM_FUNCIONES_UC();
            Index_Admin.addUserControl(formfunciones_uc);
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        
    }
}
