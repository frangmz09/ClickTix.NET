using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickTix.Modelo
{
    internal class Pelicula
    {

        public Pelicula()
        { 
        
        }
        public int id { get; set; }
        [JsonProperty("title")]
        public string titulo { get; set; }
        public string director { get; set; }
        public int duracion { get; set; }
        [JsonProperty("poster_path")]
        public string imagen { get; set; }
        public int Genero { get; set; }
        public int Clasificacion {  get; set; }
        [JsonProperty("overview")]

        public string descripcion { get; set; }
        [JsonProperty("release_date")]

        public string fEstreno { get; set; }
        
    }
}
