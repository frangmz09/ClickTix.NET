using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickTix.Modelo
{
    public class EmpleadoA
    {

        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Pass { get; set; }
        public int Id_Sucursal { get; set; }

        public string Usuario { get; set; }

        public EmpleadoA() { }

        public EmpleadoA(int id, string nombre, string apellido, string pass, int id_Sucursal, string usuario)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Pass = pass;
            Id_Sucursal = id_Sucursal;
            Usuario = usuario;
        }












    }
}
