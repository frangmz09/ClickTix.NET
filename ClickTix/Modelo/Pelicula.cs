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
        public string titulo { get; set; }
        public string director { get; set; }
        public int duracion { get; set; }
        public string imagen { get; set; }
        public int Genero { get; set; }
        public int Clasificacion {  get; set; }
        public string descripcion { get; set; }
        
    }
}
