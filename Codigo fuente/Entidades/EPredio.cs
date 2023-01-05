using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EPredio
    {
        public int Id { get; set; }
        public string Ci { get; set; }
        public string Nombre { get; set; }
        public int Hectareas { get; set; }
        public string Ubicacion { get; set; }

        public EPredio() { }

        public EPredio(int id, string ci, string nombre, int hectareas, string ubicacion)
        {
            Id = id;
            Ci = ci;
            Nombre = nombre;
            Hectareas = hectareas;
            Ubicacion = ubicacion;
        }

        public override string ToString()
        {
            return (Id + " " + Nombre);
        }
    }
}
