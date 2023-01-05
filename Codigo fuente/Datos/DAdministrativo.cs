using System;
using System.Data;
using static Datos.DConector;
using MySql.Data.MySqlClient;
using static Entidades.EAdministrativo;
using Entidades;

namespace Datos
{
    public class DAdministrativo
    {
        public static Entidades.EAdministrativo DConsultaAdministrativo(string ci)
        {
            string query = "SELECT Usuario.ci, cargo, nom_a, nom_b, ape_a, ape_b, mail, user, pass, calle_a, calle_b, nro_puerta, baja FROM Administrativo INNER JOIN Usuario ON Usuario.ci = '" + ci + "' WHERE Usuario.ci = Administrativo.ci;";
            DataTable dt = SelectCommand(query);
            Entidades.EAdministrativo eAdmin = new Entidades.EAdministrativo();

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString() == ci)
                {
                    eAdmin.Ci = dt.Rows[0][0].ToString();
                    eAdmin.Cargo = dt.Rows[0][1].ToString();
                    eAdmin.PrimerNombre = dt.Rows[0][2].ToString();
                    eAdmin.SegundoNombre = dt.Rows[0][3].ToString();
                    eAdmin.PrimerApellido = dt.Rows[0][4].ToString();
                    eAdmin.SegundoApellido = dt.Rows[0][5].ToString();
                    eAdmin.Mail = dt.Rows[0][6].ToString();
                    eAdmin.User = dt.Rows[0][7].ToString();
                    eAdmin.Pass = dt.Rows[0][8].ToString();
                    eAdmin.CalleA = dt.Rows[0][9].ToString();
                    eAdmin.CalleB = dt.Rows[0][10].ToString();
                    eAdmin.NumeroPuerta = dt.Rows[0][11].ToString();
                    eAdmin.Baja = Convert.ToBoolean(dt.Rows[0][12].ToString());
                }
            }

            return eAdmin;
        }

        public static int DModificarUsuario(EAdministrativo eAdmin) // ya que usuario
        {
            string nom_b = ", nom_b = '" + eAdmin.SegundoNombre + "'";
            string calle_a = ", calle_a = '" + eAdmin.CalleA + "'";
            string calle_b = ", calle_b = '" + eAdmin.CalleB + "'";
            string nro_puerta = ", nro_puerta = '" + eAdmin.NumeroPuerta + "'";
            string pass = ", pass = '" + eAdmin.Pass + "'";

            if (string.IsNullOrEmpty(eAdmin.SegundoNombre))
            {
                nom_b = "";
            }
            if (string.IsNullOrEmpty(eAdmin.CalleA))
            {
                calle_a = "";
            }
            if (string.IsNullOrEmpty(eAdmin.CalleB))
            {
                calle_b = "";
            }
            if (string.IsNullOrEmpty(eAdmin.NumeroPuerta))
            {
                nro_puerta = "";
            }
            if (string.IsNullOrEmpty(eAdmin.Pass) || eAdmin.Pass == "********")
            {
                pass = "";
            }

            string query = "UPDATE Usuario SET nom_a = '" + eAdmin.PrimerNombre + "'" +
                                            nom_b + //", nom_b = '" + eAdmin.SegundoNombre + "'" +
                                            ", ape_a = '" + eAdmin.PrimerApellido + "'" +
                                            ", ape_b = '" + eAdmin.SegundoApellido + "'" +
                                             ", mail = '" + eAdmin.Mail + "'" +
                                             ", user = '" + eAdmin.User + "'" +
                                             pass + //", pass = '" + eAdmin.Pass + "'" +
                                          calle_a + //", calle_a = '" + eAdmin.CalleA + "'" +
                                          calle_b + //", calle_b = '" + eAdmin.CalleB + "'" +
                                       nro_puerta + //", nro_puerta = '" + eAdmin.NumeroPuerta + "'" +
                                             ", baja = " + eAdmin.Baja +
                                          " WHERE ci = '" + eAdmin.Ci + "';";
            return InsertCommand(query);
        }

        public static int DModificarAdministrativo(EAdministrativo eAdmin)
        {
            int intentarUpdate;
            string query0 = "UPDATE Administrativo SET cargo = '" + eAdmin.Cargo + "' WHERE ci = '" + eAdmin.Ci + "';";
            intentarUpdate = InsertCommand(query0);
            if (intentarUpdate == 0)
            {
                string query1 = "INSERT INTO Administrativo(ci, cargo) VALUES('" + eAdmin.Ci + "','" + eAdmin.Cargo + "');";
                intentarUpdate = InsertCommand(query1);
            }

            return intentarUpdate;
        }

        public static int DDeleteRolAdministrativo(string ci)
        {
            string query = "DELETE FROM Administrativo WHERE ci = '" + ci + "';";
            int result = InsertCommand(query);
            return result;
        }

        public static int DCrearRolAdministrativo(EAdministrativo eAdministrativo)
        {
            string query = "INSERT INTO Administrativo(ci, cargo) VALUES('" + eAdministrativo.Ci + "','" + eAdministrativo.Cargo + "');";
            return InsertCommand(query);
        }

    }
}
