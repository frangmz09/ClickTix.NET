using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickTix.Modelo
{
    public class Asiento
    {
        public int Id { get; set; }
        public int Fila { get; set; }
        public int Columna { get; set; }
        public bool Disponible { get; set; }
        public int Id_Funcion { get; set; }

        public Asiento(int id, int fila, int columna, bool disponible, int id_Funcion)
        {
            Id = id;
            Fila = fila;
            Columna = columna;
            Disponible = disponible;
            Id_Funcion = id_Funcion;
        }

        public Asiento()
        {

        }
    }
}

