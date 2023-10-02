using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Modelo
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string usuario { get; set; }
        public string pass { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Is_admin { get; set; }
        public object Id_sucursal { get; internal set; }

        public Usuario(int id, string nombre, string apellido, string pass, string username, int is_admin)
        {
            Id = id;
            usuario = username;
            this.pass = pass;
            Nombre = nombre;
            Apellido = apellido;
            Is_admin = is_admin;


        }

        public Usuario() { }

        public Usuario(int id, string nombre, string apellido, string pass, string username, int is_admin, int id_sucursal)
        {
            Id = id;
            usuario = username;
            this.pass = pass;
            Nombre = nombre;
            Apellido = apellido;
            Id_sucursal = id_sucursal;
            Is_admin = is_admin;


        }

    }
}
