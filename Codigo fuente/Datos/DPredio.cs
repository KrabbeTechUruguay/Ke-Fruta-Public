using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Datos.DConector;

namespace Datos
{
    public class DPredio
    {
        public static DataTable DConsultarPrediosTodos()
        {
            DataTable dt = SelectTablaCommand("Predio");
            return dt;
        }

        public static DataTable DConsultarPrediosOcupados()
        {
            string query = "SELECT * FROM Predio WHERE ci_prod IS NOT NULL";
            DataTable dt = SelectCommand(query);
            return dt;
        }

        public static DataTable DConsultarPrediosLibres()
        {
            string query = "SELECT * FROM Predio WHERE ci_prod IS NULL";
            DataTable dt = SelectCommand(query);
            return dt;
        }
        public static DataTable DConsultarPrediosPorCi(string ci)
        {
            string query = "SELECT * FROM Predio WHERE ci_prod = " + ci + ";";
            DataTable dt = SelectCommand(query);
            return dt;
        }

        public static DataTable DConsultarPrediosPorId(string id)
        {
            string query = "SELECT * FROM Predio WHERE id_pred = " + id + ";";
            DataTable dt = SelectCommand(query);
            return dt;
        }

        public static DataTable DConsultarSectores(string idPredio)
        {
            string query = "SELECT * FROM Sector WHERE id_pred = " + idPredio + ";";
            return SelectCommand(query);
        }

        public static int DUpdatePredio(EPredio ePredioModificado)
        {
            string queryCi = "";
            string queryUb = "";

            if (!string.IsNullOrEmpty(ePredioModificado.Ci))
            {
                queryCi = "ci_prod = '" + ePredioModificado.Ci + "', ";
            }
            if (!string.IsNullOrEmpty(ePredioModificado.Ubicacion))
            {
                queryUb = ", ub_pred = '" + ePredioModificado.Ubicacion + "'";
            }

            string query = "UPDATE Predio SET " + queryCi + 
                                           "nom_pred = '" + ePredioModificado.Nombre + "'" +
                                         ", hect_pred = " + ePredioModificado.Hectareas +
                                         queryUb +
                                      " WHERE id_pred = " + ePredioModificado.Id + ";";
            return InsertCommand(query);
        }

        public static int DUpdateSector(ESector eSectorModificado)
        {
            string queryCi = "";
            string queryUb = "";
            string queryNom = "";

            if (!string.IsNullOrEmpty(eSectorModificado.Ci_prod))
            {
                queryCi = "ci_prod = '" + eSectorModificado.Ci_prod + "', ";
            }
            if (!string.IsNullOrEmpty(eSectorModificado.Nombre))
            {
                queryNom = "nom_sect = '" + eSectorModificado.Nombre + "', ";
            }
            if (!string.IsNullOrEmpty(eSectorModificado.Ubicacion))
            {
                queryUb = "ub_sect = '" + eSectorModificado.Ubicacion + "', ";
            }

            string query = "UPDATE Sector SET " +
                                              queryCi +
                                             queryNom +
                                           "hect_sect = " + eSectorModificado.Hectareas + ", " +
                                              queryUb +
                                              "estado_sect = '" + eSectorModificado.Estado + "'" +
                                      " WHERE id_sect = " + eSectorModificado.Id + " AND id_pred = " + eSectorModificado.Id_predio + ";";
            return InsertCommand(query);
        }

        public static int DInsertPredio(EPredio ePredio)
        {
            string queryCi = "";
            string queryUb = "";
            string ci_prod = "";
            string ub_pred = "";

            if (!string.IsNullOrEmpty(ePredio.Ci))
            {
                queryCi = ePredio.Ci + ", ";
                ci_prod = "ci_prod, ";
            }
            if (!string.IsNullOrEmpty(ePredio.Ubicacion))
            {
                queryUb = ", '" + ePredio.Ubicacion + "'";
                ub_pred = ", ub_pred";
            }

            string query = "INSERT INTO Predio(" + ci_prod + "nom_pred, hect_pred" + ub_pred + ") " +
                                        "VALUES(" + queryCi + "'" + ePredio.Nombre + "', " + ePredio.Hectareas + queryUb + ");";

            return InsertCommand(query);
        }

        public static DataTable DConsultarPrediosIdLibre()
        {
            string query = "SELECT MAX(id_pred) FROM Predio;";
            return SelectCommand(query);
        }

        public static DataTable DConsultarSectorIdLibre(int id_predio)
        {
            string query = "SELECT MAX(id_sect) FROM Sector WHERE id_pred = " + id_predio + ";";
            return SelectCommand(query);
        }

        public static int DInsertSector(ESector eNuevoSector)
        {
            // no necesita cedula, nombre, ubicacion
            string queryCi = "";
            string queryNom = "";
            string queryUb = "";
            string ci_prod = "";
            string nom_sect = "";
            string ub_sect = "";

            if (!string.IsNullOrEmpty(eNuevoSector.Ci_prod))
            {
                queryCi = eNuevoSector.Ci_prod + ", ";
                ci_prod = "ci_prod, ";
            }
            if (!string.IsNullOrEmpty(eNuevoSector.Ubicacion))
            {
                queryNom = "'" + eNuevoSector.Nombre + "', ";
                nom_sect = "nom_sect, ";
            }
            if (!string.IsNullOrEmpty(eNuevoSector.Ubicacion))
            {
                queryUb = "'" + eNuevoSector.Ubicacion + "', ";
                ub_sect = "ub_sect, ";
            }

            string query = "INSERT INTO Sector(id_pred, id_sect, " + ci_prod + nom_sect + "hect_sect, " + ub_sect + "estado_sect) VALUES(" + 
                                                eNuevoSector.Id_predio.ToString() + ", " +
                                                eNuevoSector.Id.ToString() + ", " +
                                                queryCi +
                                                queryNom + 
                                                eNuevoSector.Hectareas.ToString() + ", " +
                                                queryUb +
                                          "'" + eNuevoSector.Estado + "'" + 
                                              ");";

            return InsertCommand(query);
        }

    }
}
