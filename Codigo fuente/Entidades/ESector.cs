using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ESector
    {
        private int id;
        private int id_predio;
        private string ci_prod;
        private string nombre;
        private int hectareas;
        private string ubicacion;
        private string estado;

        public int Id { get => id; set => id = value; }
        public int Id_predio { get => id_predio; set => id_predio = value; }
        public string Ci_prod { get => ci_prod; set => ci_prod = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Hectareas { get => hectareas; set => hectareas = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Estado 
        {
            get { return estado; }
            set
            {
                estado = value.ToUpper();
                if (estado.Contains("DISP"))//(estado == "DISPO" || estado == "DISPONIBLE" || estado == "DISPONIB")
                {
                    estado = "DISP";
                }
                else if (estado.Contains("DESC"))//(estado == "DESCA" || estado == "DESCANSO" || estado == "DESCAN")
                {
                    estado = "DESC";
                }
                else if (estado.Contains("OCUP"))//(estado == "OCUPA" || estado == "OCUPADO" || estado == "OCUPAD")
                {
                    estado = "OCUP";
                }
            }
        }
        



        public ESector() { }

        public ESector(int id, int id_predio, string ci_prod, string nombre, int hectareas, string ubicacion, string estado)
        {
            this.Id = id;
            this.Id_predio = id_predio;
            this.Ci_prod = ci_prod;
            this.Nombre = nombre;
            this.Hectareas = hectareas;
            this.Ubicacion = ubicacion;
            this.Estado = estado;
        }
    }
}
