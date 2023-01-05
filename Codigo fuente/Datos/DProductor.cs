using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static Datos.DConector;
using MySql.Data.MySqlClient;
using static Entidades.EProductor;
using static Datos.DUsuario;
using Entidades;

namespace Datos
{
    public class DProductor
    {
        public static Entidades.EProductor DConsultaProductor(string ci)
        {
            string query = "SELECT Usuario.ci, rut_prod, produce, nom_a, nom_b, ape_a, ape_b, mail, user, pass, calle_a, calle_b, nro_puerta, baja FROM Productor INNER JOIN Usuario ON Usuario.ci = '" + ci + "' WHERE Usuario.ci = Productor.ci;";
            DataTable dt = SelectCommand(query);
            Entidades.EProductor eProd = new Entidades.EProductor();

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString() == ci)
                {
                    eProd.Ci = dt.Rows[0][0].ToString();
                    eProd.Rut = dt.Rows[0][1].ToString();
                    eProd.Produce = dt.Rows[0][2].ToString();
                    eProd.PrimerNombre = dt.Rows[0][3].ToString();
                    eProd.SegundoNombre = dt.Rows[0][4].ToString();
                    eProd.PrimerApellido = dt.Rows[0][5].ToString();
                    eProd.SegundoApellido = dt.Rows[0][6].ToString();
                    eProd.Mail = dt.Rows[0][7].ToString();
                    eProd.User = dt.Rows[0][8].ToString();
                    eProd.Pass = dt.Rows[0][9].ToString();
                    eProd.CalleA = dt.Rows[0][10].ToString();
                    eProd.CalleB = dt.Rows[0][11].ToString();
                    eProd.NumeroPuerta = dt.Rows[0][12].ToString();
                    eProd.Baja = Convert.ToBoolean(dt.Rows[0][13].ToString());
                }
            }

            return eProd;
        }
        
        public static int DModificarUsuario(EProductor eProd) // ya que usuario
        {
            string nom_b = ", nom_b = '" + eProd.SegundoNombre + "'";
            string calle_a = ", calle_a = '" + eProd.CalleA + "'";
            string calle_b = ", calle_b = '" + eProd.CalleB + "'";
            string nro_puerta = ", nro_puerta = '" + eProd.NumeroPuerta + "'";
            string pass = ", pass = '" + eProd.Pass + "'";

            if (string.IsNullOrEmpty(eProd.SegundoNombre))
            {
                nom_b = "";
            }
            if (string.IsNullOrEmpty(eProd.CalleA))
            {
                calle_a = "";
            }
            if (string.IsNullOrEmpty(eProd.CalleB))
            {
                calle_b = "";
            }
            if (string.IsNullOrEmpty(eProd.NumeroPuerta))
            {
                nro_puerta = "";
            }
            if (string.IsNullOrEmpty(eProd.Pass) || eProd.Pass == "********")
            {
                pass = "";
            }

            string query = "UPDATE Usuario SET nom_a = '" + eProd.PrimerNombre + "'" +
                                            nom_b + //", nom_b = '" + eProd.SegundoNombre + "'" +
                                            ", ape_a = '" + eProd.PrimerApellido + "'" +
                                            ", ape_b = '" + eProd.SegundoApellido + "'" +
                                             ", mail = '" + eProd.Mail + "'" +
                                             ", user = '" + eProd.User + "'" +
                                             pass + //", pass = '" + eProd.Pass + "'" +
                                          calle_a + //", calle_a = '" + eProd.CalleA + "'" +
                                          calle_b + //", calle_b = '" + eProd.CalleB + "'" +
                                       nro_puerta + //", nro_puerta = '" + eProd.NumeroPuerta + "'" +
                                             ", baja = " + eProd.Baja +
                                          " WHERE ci = '" + eProd.Ci + "';";
            return InsertCommand(query);
        }

        public static int DModificarProductor(EProductor eProd)
        {
            int intentarUpdate;
            string query0 = "UPDATE Productor SET rut_prod = '" + eProd.Rut + 
                                         "', produce = '" + eProd.Produce + 
                                         "' WHERE ci = '" + eProd.Ci + "';";
            intentarUpdate = InsertCommand(query0);
            if (intentarUpdate == 0)
            {
                if (string.IsNullOrEmpty(eProd.Rut)) // si no tiene rut asociado
                {
                    string query1 = "INSERT INTO Productor(ci, produce) VALUES('" + eProd.Ci + "','" + eProd.Produce + "');";
                    intentarUpdate = InsertCommand(query1);
                }
                else // si tiene rut asociado
                {
                    string query2 = "INSERT INTO Productor(ci, rut_prod, produce) VALUES('" + eProd.Ci + "','" + eProd.Rut + "','" + eProd.Produce + "');";
                    intentarUpdate = InsertCommand(query2);
                }
            }

            return intentarUpdate;
        }

        public static int DDeleteRolProductor(string ci)
        {
            string query = "DELETE FROM Productor WHERE ci = '" + ci + "';";
            int result = InsertCommand(query);
            return result;
        }

        public static int DCrearRolProductor(EProductor eProductor)
        {
            int insertResultado = 0;
            if (!string.IsNullOrEmpty(eProductor.Produce))
            {
                if (string.IsNullOrEmpty(eProductor.Rut)) // si no tiene rut asociado
                {
                    string query1 = "INSERT INTO Productor(ci, produce) VALUES('" + eProductor.Ci + "','" + eProductor.Produce + "');";
                    insertResultado = InsertCommand(query1);
                }
                else // si tiene rut asociado
                {
                    string query2 = "INSERT INTO Productor(ci, rut_prod, produce) VALUES('" + eProductor.Ci + "','" + eProductor.Rut + "','" + eProductor.Produce + "');";
                    insertResultado = InsertCommand(query2);
                }
            }

            return insertResultado;
        }

        public static int DConsultaExisteProductor(string ci)
        {
            string query = "SELECT Count(*) FROM Productor WHERE Ci = " + ci + ";";
            return CountCommand(query);
        }
    }
}
