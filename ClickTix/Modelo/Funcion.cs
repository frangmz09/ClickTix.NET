using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickTix.Modelo
{
    public class Funcion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Dimension { get; set; }
        public int Id_Pelicula { get; set; }
        public int Id_Sala { get; set; }
        public int Id_Idioma { get; set; }
        public int Id_Turno { get; set; }

        public int nroSala { get; set; }
        public string dimension { get; set; }
        public string idioma { get; set; }
        public TimeSpan hora{ get; set; }
        public decimal precio { get; set; }

        public string peliculaNombre { get; set; }

        public string sucursalNombre { get; set; }

        public Funcion(int id, DateTime fecha, int id_Dimension, int id_Pelicula, int id_Sala, int id_Idioma, int id_Turno)
        {
            Id = id;
            Fecha = fecha;
            Id_Dimension = id_Dimension;
            Id_Pelicula = id_Pelicula;
            Id_Sala = id_Sala;
            Id_Idioma = id_Idioma;
            Id_Turno = id_Turno;
        }

        public Funcion()
        {

        }
    }
}
