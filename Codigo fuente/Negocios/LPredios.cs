using Entidades;
using System;
using System.Data;

namespace Logica
{
    public class LPredios
    {
        // DATOS DE PREDIOS

        public static DataTable LConsultarPredios()
        {
            DataTable dt = Datos.DPredio.DConsultarPrediosTodos();
            return dt;
        }

        public static DataTable LConsultarPrediosOcupados()
        {
            DataTable dt = Datos.DPredio.DConsultarPrediosOcupados();
            return dt;
        }
        public static DataTable LConsultarPrediosLibres()
        {
            DataTable dt = Datos.DPredio.DConsultarPrediosLibres();
            return dt;
        }
        
        public static DataTable LConsultarPrediosPorCi(string ci)
        {
            DataTable dt = Datos.DPredio.DConsultarPrediosPorCi(ci);
            return dt;
        }

        public static DataTable LConsultarPrediosPorId(string id)
        {
            DataTable dt = Datos.DPredio.DConsultarPrediosPorId(id);
            return dt;
        }

        //DATOS DE SECTORES

        public static DataTable LConsultarSectores(string idPredio)
        {
            return Datos.DPredio.DConsultarSectores(idPredio);
        }

        public static string LModificarPredio(EPredio ePredioModificado)
        {
            string msg = "";
            int updateResult = Datos.DPredio.DUpdatePredio(ePredioModificado);
            if (updateResult == 0)
            {
                msg = "No se ha midificado algun predio.";
            }
            else if (updateResult == 1)
            {
                msg = "Predio '" + ePredioModificado.Id + " - " + ePredioModificado.Nombre + "' modificado con éxito.";
            }
            else if (updateResult == -1)
            {
                msg = "Error al actualizar predio en la base de datos.";
            }

            return msg;
        }

        public static string LModificarSector(ESector eSectorModificado)
        {
            string msg = "";
            int updateResult = Datos.DPredio.DUpdateSector(eSectorModificado);
            if (updateResult == 0)
            {
                msg = "No se ha midificado algun predio.";
            }
            else if (updateResult == 1)
            {
                msg = "Predio '" + eSectorModificado.Id + " - " + eSectorModificado.Nombre + "' modificado con éxito.";
            }
            else if (updateResult == -1)
            {
                msg = "Error al actualizar predio en la base de datos.";
            }

            return msg;
        }

        public static string LConsultarPrediosIdLibre()
        {
            DataTable dt = Datos.DPredio.DConsultarPrediosIdLibre();

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return "Error al cargar nueva Id de predios";
            }
        }

        public static string LCrearPredio(EPredio ePredio)
        {
            string msg = "";

            int result = Datos.DPredio.DInsertPredio(ePredio);

            if (result == 0)
            {
                msg = "No fue posible registrar este predio, compruebe los datos";
            }
            else if (result == 1)
            {
                msg = "Predio " + ePredio.Nombre + " ingresado con éxito.";
            }
            else if (result == -1)
            {
                msg = "Error al insertar predio, corrobore sus datos.";
            }

            return msg;
        }

        public static int LConsultarSectorUltimaIdLibre(int id_predio)
        {
            DataTable dt = Datos.DPredio.DConsultarSectorIdLibre(id_predio);

            if (dt.Rows.Count > 0)
            {
                if (int.TryParse(dt.Rows[0][0].ToString(), out int id))
                {
                    return Convert.ToInt32(dt.Rows[0][0].ToString()) + 1;
                }
                else
                {
                    return 1;//si no hay sectores registrados para el predio la id 1 esta libre
                }
            }
            else
            {
                return -1; 
            }
        }

        public static string LCrearSector(ESector eNuevoSector)
        {
            string msg = "";

            int result = Datos.DPredio.DInsertSector(eNuevoSector);

            if (result == 0)
            {
                msg = "No fue posible registrar este sector, compruebe los datos";
            }
            else if (result == 1)
            {
                string nombreSector = eNuevoSector.Nombre + " ";
                msg = "Nuevo predio " + nombreSector + "ingresado con éxito.";
            }
            else if (result == -1)
            {
                msg = "Error al insertar predio, corrobore sus datos.";
            }

            return msg;
        }
    }
}