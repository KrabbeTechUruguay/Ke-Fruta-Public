using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EInsumo : EItem
    {
        private int codigo;
        private decimal peso;
        private string nombre;
        private string descripcion;
        private int cantidad;
        private decimal precio;
        private bool baja;
        private string categInsumo;
        private string tipoInsumo;

        public override int Codigo { get => codigo; set => codigo = value; }
        public override decimal Peso { get => peso; set => peso = value; }
        public override string Nombre { get => nombre; set => nombre = value; }
        public override string Descripcion { get => descripcion; set => descripcion = value; }
        public override int Cantidad { get => cantidad; set => cantidad = value; }
        public override decimal Precio { get => precio; set => precio = value; }
        public override bool Baja { get => baja; set => baja = value; }
        public string CategoriaInsumo { get => categInsumo; set => categInsumo = value; }
        public string TipoInsumo { get => tipoInsumo; set => tipoInsumo = value; }

        public EInsumo() { }

        public EInsumo(int codigo, decimal peso, string nombre, string descrip, int cant, decimal precio, bool baja) : base(codigo, peso, nombre, descrip, cant, precio, baja)
        {
            this.Codigo = codigo;
            this.Peso = peso;
            this.Nombre = nombre;
            this.Descripcion = descrip;
            this.Cantidad = cant;
            this.Precio = precio;
            this.Baja = baja;
            this.CategoriaInsumo = categInsumo;
            this.TipoInsumo = tipoInsumo;
        }
    }
}
