using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EEvento
    {
        private int id;
        private int idSector;
        private int idPredio;
        private string tipo;
        private string ciProductor;
        private DateTime fechaInicial;
        private DateTime fechaFinal;
        private string categoiraProducto;
        private string tipoProducto;
        private string infoEvento;
        private string ciAdministrativo;
        private DateTime fechaGestion;
        private string estado;
        private int idEventoAnterior;

        public int Id { get => id; set => id = value; }
        public int IdSector { get => idSector; set => idSector = value; }
        public int IdPredio { get => idPredio; set => idPredio = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string CiProductor { get => ciProductor; set => ciProductor = value; }
        public DateTime FechaInicial { get => fechaInicial; set => fechaInicial = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public string CategoiraProducto { get => categoiraProducto; set => categoiraProducto = value; }
        public string TipoProducto { get => tipoProducto; set => tipoProducto = value; }
        public string InfoEvento { get => infoEvento; set => infoEvento = value; }
        public string CiAdministrativo { get => ciAdministrativo; set => ciAdministrativo = value; }
        public DateTime FechaGestion { get => fechaGestion; set => fechaGestion = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdEventoAnterior { get => idEventoAnterior; set => idEventoAnterior = value; }

        public EEvento() { }

        public EEvento(int id, int idSector, int idPredio, string tipo, string ciProductor, DateTime fechaInicial, DateTime fechaFinal, string categoiraProducto, string tipoProducto, string infoEvento, string ciAdministrativo, DateTime fechaGestion, string estado, int idEventoAnterior)
        {
            this.Id = id;
            this.IdSector = idSector;
            this.IdPredio = idPredio;
            this.Tipo = tipo;
            this.CiProductor = ciProductor;
            this.FechaInicial = fechaInicial;
            this.FechaFinal = fechaFinal;
            this.CategoiraProducto = categoiraProducto;
            this.TipoProducto = tipoProducto;
            this.InfoEvento = infoEvento;
            this.CiAdministrativo = ciAdministrativo;
            this.FechaGestion = fechaGestion;
            this.Estado = estado;
            this.IdEventoAnterior = idEventoAnterior;
        }
    }
}
