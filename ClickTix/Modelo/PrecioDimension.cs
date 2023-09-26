using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClickTix.Modelo
{
    public class PrecioDimension
    {
        public PrecioDimension() {}
        public int id { get; set; }
        public string dimension { get; set; }
        public decimal precio { get; set; }


    }
}
