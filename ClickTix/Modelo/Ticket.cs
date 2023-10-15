using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickTix.Modelo
{
    internal class Ticket
    {
        public int id { get; set; }
        public int id_funcion { get; set; }
        public DateTime fecha{ get; set; }
        public int fila { get; set; }
        public int columna { get; set; }
        public double precio { get; set; }

    }
}
