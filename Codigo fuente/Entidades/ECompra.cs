using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ECompra
    {
        private int Codigo { get; set; }
        private string CiCliente { get; set; }
        private DateTime FechaCompra { get; set; }
        private List<int> ListaItemsCod { get; set; }
        private int Cantidad { get; set; }
        private string CiAdministrativo { get; set; }
        private DateTime FechaConfirmacion { get; set; }

        public ECompra() { }

        public ECompra(int codigo, string ciCliente, DateTime fechaCompra, List<int> ListaCodigoItem, int cantidad, string ciAdministrativo, DateTime fechaConfirmacion)
        {
            this.Codigo = codigo;
            this.CiCliente = ciCliente;
            this.FechaCompra = fechaCompra;
            this.ListaItemsCod = ListaCodigoItem;
            this.Cantidad = cantidad;
            this.CiAdministrativo = ciAdministrativo;
            this.FechaConfirmacion = fechaConfirmacion;
        }
    }
}
