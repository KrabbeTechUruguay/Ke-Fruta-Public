using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LCalendario
    {
        public static DataTable LConsultarEventosPorFecha(string fecha)
        {
            DataTable dt = Datos.DEvento.DConsultarEventosPorFecha(fecha);
            return dt;
        }

        public static DataTable LConsultarEventosTodos()
        {
            DataTable dt = Datos.DEvento.DConsultarEventosTodos();
            return dt;
        }
    }
}
