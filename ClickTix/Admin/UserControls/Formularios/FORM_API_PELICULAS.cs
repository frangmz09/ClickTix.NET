using ClickTix.Modelo;
using ClickTix.UserControls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Admin.UserControls.Formularios
{
    public partial class FORM_API_PELICULAS : UserControl
    {
        public FORM_API_PELICULAS()
        {
            InitializeComponent();
            grid_peliculas.CellContentClick += dataGridViewMovies_CellContentClick;
        }


    
        private async Task SearchMovies(string searchTerm)
        {
            HttpClient client = new HttpClient();
            double minPopularity = 700.0;

            string baseUrl = "https://api.themoviedb.org";
            string apiKey = "44f9ad3c77d25563ced721e526744397";
            string language = "es-ES";
            string region = "AR";

            string url = $"{baseUrl}/3/search/movie" +
                         $"?api_key={apiKey}" +
                         $"&language={language}" +
                         $"&query={Uri.EscapeDataString(searchTerm)}" +
                         $"&region={region}" +
                         $"&popularity.gte={minPopularity}";

            Console.WriteLine(url);

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();

                    List<Pelicula> peliculas = DeserializarJson(responseData);

                    grid_peliculas.Rows.Clear();

                    foreach (Pelicula pelicula in peliculas)
                    {
                        grid_peliculas.Rows.Add(pelicula.titulo, pelicula.fEstreno, pelicula.imagen, pelicula.descripcion, "Seleccionar");
                    }
                }
                else
                {
                    MessageBox.Show($"Error en la respuesta: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            button1.Enabled = true;
            loadingText.Visible = false;
        }

        private async Task LoadMovies()
        {
            HttpClient client = new HttpClient();
            double minPopularity = 700.0;

            string baseUrl = "https://api.themoviedb.org";
            string apiKey = "44f9ad3c77d25563ced721e526744397";
            string language = "es-ES";
            string region = "AR";

            string url = $"{baseUrl}/3/movie/now_playing" +
                         $"?api_key={apiKey}" +
                         $"&language={language}" +
                         $"&region={region}" +
                         $"&popularity.gte={minPopularity}";

            Console.WriteLine(url);

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();

                    List<Pelicula> peliculas = DeserializarJson(responseData);

                    grid_peliculas.Rows.Clear();

                    foreach (Pelicula pelicula in peliculas)
                    {
                        grid_peliculas.Rows.Add(pelicula.titulo, pelicula.fEstreno,pelicula.imagen,pelicula.descripcion, "Seleccionar");
                    }
                }
                else
                {
                    MessageBox.Show($"Error en la respuesta: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            button1.Enabled = true;
            loadingText.Visible = false;

        }

        private List<Pelicula> DeserializarJson(string json)
        {
            try
            {
                var container = new { Results = new List<Pelicula>() };
                container = JsonConvert.DeserializeAnonymousType(json, container);

                return container.Results;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error al deserializar el JSON: {ex.Message}");
                return new List<Pelicula>();
            }
        }

        private void dataGridViewMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_peliculas.Columns["Seleccionar"].Index && e.RowIndex >= 0)
            {
                string titulo = grid_peliculas.Rows[e.RowIndex].Cells["titulo"].Value.ToString();
                string fechaEstreno = grid_peliculas.Rows[e.RowIndex].Cells["FechaDeEstreno"].Value.ToString();
                string imagen = grid_peliculas.Rows[e.RowIndex].Cells["imagen"].Value.ToString();
                string descripcion = grid_peliculas.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();

                Pelicula peliculaApi = new Pelicula();

                peliculaApi.titulo = titulo;
                peliculaApi.fEstreno = fechaEstreno;
                peliculaApi.imagen = imagen;
                peliculaApi.descripcion = descripcion;

                FORM_PELICULAS_UC peliculaApiForm = new FORM_PELICULAS_UC(peliculaApi);

                Index_Admin.addUserControl(peliculaApiForm);
            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            loadingText.Visible = true;
            grid_peliculas.Rows.Clear();
            if (search_films.Text == "")
            {
                await LoadMovies();

            }
            else
            {
                string searchTerm = search_films.Text;
                await SearchMovies(searchTerm);
            }

        }

        private void back_pelicula_Click(object sender, EventArgs e)
        {
            FORM_PELICULAS_UC peliculaForm = new FORM_PELICULAS_UC();

            Index_Admin.addUserControl(peliculaForm);
        }
    }
}
