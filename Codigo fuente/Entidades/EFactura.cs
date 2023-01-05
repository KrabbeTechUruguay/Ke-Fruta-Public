using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EFactura
    {
        private int Codigo { get => Codigo; set => Codigo = value; }
        private string Tipo { get => Tipo; set => Tipo = value; }
        private string Rut { get => Rut; set => Rut = value; }
        private decimal Costo { get => Costo; set => Costo = value; }
        private decimal Iva { get => Iva; set => Iva = value; }
        private decimal Total { get => Total; set => Total = value; }
        private DateTime FechaEmision { get => FechaEmision; set => FechaEmision = value; }
        private List<int> ListaItemsCod { get => ListaItemsCod; set => ListaItemsCod = value; }

        public EFactura() { }

        public EFactura(int codigo, string tipo, string rut, decimal costo, decimal iva, decimal total, DateTime fechaEmision, List<int> listaCodigoItems)
        {
            this.Codigo = codigo;
            this.Tipo = tipo;
            this.Rut = rut;
            this.Costo = costo;
            this.Iva = iva;
            this.Total = total;
            this.FechaEmision = fechaEmision;
            this.ListaItemsCod = listaCodigoItems;
        }
    }
}
