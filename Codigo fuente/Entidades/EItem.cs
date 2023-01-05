using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class EItem
    {
        public abstract int Codigo { get; set; }
        public abstract decimal Peso { get; set; }
        public abstract string Nombre { get; set; }
        public abstract string Descripcion { get; set; }
        public abstract int Cantidad { get; set; }
        public abstract decimal Precio { get; set; }
        public abstract bool Baja { get; set; }

        public EItem() { }

        public EItem(int codigo, decimal peso, string nombre, string descripcion, int cantidad, decimal precio, bool baja)
        {
            this.Codigo = codigo;
            this.Peso = peso;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Baja = baja;
        }
    }
}
