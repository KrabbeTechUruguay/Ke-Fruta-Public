using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EFertiliza
    {
        public int Id { get; set; }
        public int IdEvento { get; set; }
        public DateTime Fecha { get; set; }
        public decimal EstadioZ { get; set; }
        public decimal NitratoSuelo { get; set; }
        public decimal NitrogenoSuelo { get; set; }
        public decimal NitrogenoPlanta { get; set; }
        public decimal NivelCritico { get; set; }
        public decimal EquivFertilizante { get; set; }

        public EFertiliza() { }

        public EFertiliza(int id, int idEvento, DateTime fecha, decimal estadioZ, decimal nitratoSuelo, decimal nitrogenoSuelo, decimal nitrogenoPlanta, decimal nivelCritico, decimal equivFertilizante)
        {
            this.Id = id;
            this.IdEvento = idEvento;
            this.Fecha = fecha;
            this.EstadioZ = estadioZ;
            this.NitratoSuelo = nitratoSuelo;
            this.NitrogenoSuelo = nitrogenoSuelo;
            this.NitrogenoPlanta = nitrogenoPlanta;
            this.NivelCritico = nivelCritico;
            this.EquivFertilizante = equivFertilizante;
        }
    }
}
