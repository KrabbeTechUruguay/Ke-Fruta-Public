using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Datos.DConector;

namespace Datos
{
    public class DEvento
    {
        public static DataTable DConsultarEventosTodos()
        {
            DataTable dt = SelectTablaCommand("Evento");
            return dt;
        }

        public static DataTable DConsultarEventosPorFecha(string fecha)
        {
            string query = "SELECT * FROM Evento WHERE ('" + fecha + "' BETWEEN f_ini AND f_fin);";
            DataTable dt = SelectCommand(query);
            return dt;
        }
    }
}
