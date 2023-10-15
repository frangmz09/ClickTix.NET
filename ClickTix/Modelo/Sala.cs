using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickTix.Modelo
{
    internal class Sala
    {
        public int Id { get; set; }
        public int Id_Sucursal { get; set; }
        public int Columnas { get; set; }
        public int Filas { get; set; }
        public int Capacidad { get; set; }
        public int Nro_Sala { get; set; }

        public Sala() { }
        public Sala(int id, int id_Sucursal, int columnas, int filas, int capacidad, int nroSalas)
        {
            Id = id;
            this.Id_Sucursal = id_Sucursal;
            this.Columnas = columnas;
            this.Filas = filas;
            this.Capacidad = capacidad;
            this.Nro_Sala = nroSalas;
        }




    }
}
