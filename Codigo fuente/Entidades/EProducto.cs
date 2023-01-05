using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EProducto : EItem
    {
        private int codigo;
        private decimal peso;
        private string nombre;
        private string descripcion;
        private int cantidad;
        private decimal precio;
        private bool baja;
        private string categoriaProducto;
        private string tipoProducto;
        private string ciProductor;
        private int idCosecha;
        private DateTime fechaCosecha;

        public override int Codigo { get => codigo; set => codigo = value; }
        public override decimal Peso { get => peso; set => peso = value; }
        public override string Nombre { get => nombre; set => nombre = value; }
        public override string Descripcion { get => descripcion; set => descripcion = value; }
        public override int Cantidad { get => cantidad; set => cantidad = value; }
        public override decimal Precio { get => precio; set => precio = value; }
        public override bool Baja { get => baja; set => baja = value; }
        public string CategoriaProducto { get => categoriaProducto; set => categoriaProducto = value; }
        public string TipoProducto { get => tipoProducto; set => tipoProducto = value; }
        public string CiProductor { get => ciProductor; set => ciProductor = value; }
        public int IdCosecha { get => idCosecha; set => idCosecha = value; }
        public DateTime FechaCosecha { get => fechaCosecha; set => fechaCosecha = value; }

        public EProducto() { }

        public EProducto(int cod, decimal peso, string nom, string descrip, int cant, decimal precio, bool baja, string categProducto, string tipoProducto, string ciProductor, int idCosecha, DateTime fechaCosecha) : base(cod, peso, nom, descrip, cant, precio, baja)
        {
            this.Codigo = cod;
            this.Peso = peso;
            this.Nombre = nom;
            this.Descripcion = descrip;
            this.Cantidad = cant;
            this.Precio = precio;
            this.Baja = baja;
            this.CategoriaProducto = categProducto;
            this.TipoProducto = tipoProducto;
            this.CiProductor = ciProductor;
            this.IdCosecha = idCosecha;
            this.FechaCosecha = fechaCosecha;
        }
    }
}
