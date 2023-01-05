using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Datos.DConector;
using System.Data;
using Entidades;

namespace Datos
{
    public class DUsuario
    {
        public static Entidades.EProductor DConsultaUsuario(string ci) // UTILIZA LA ENTIDAD PRODUCTOR PARA GUARDAR LOS DATOS DE USUARIO SIN ROL ADMINISTRATIVO O PRODUCTOR
        {
            string query = "SELECT ci, nom_a, nom_b, ape_a, ape_b, mail, user, pass, calle_a, calle_b, nro_puerta, baja FROM Usuario WHERE ci = '" + ci + "';";
            DataTable dt = SelectCommand(query);
            Entidades.EProductor eProd = new Entidades.EProductor();
            //var telefonos = new List<string>();

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString() == ci)
                {
                    eProd.Ci = dt.Rows[0][0].ToString();
                    eProd.PrimerNombre = dt.Rows[0][1].ToString();
                    eProd.SegundoNombre = dt.Rows[0][2].ToString();
                    eProd.PrimerApellido = dt.Rows[0][3].ToString();
                    eProd.SegundoApellido = dt.Rows[0][4].ToString();
                    eProd.Mail = dt.Rows[0][5].ToString();
                    eProd.User = dt.Rows[0][6].ToString();
                    eProd.Pass = dt.Rows[0][7].ToString();
                    eProd.CalleA = dt.Rows[0][8].ToString();
                    eProd.CalleB = dt.Rows[0][9].ToString();
                    eProd.NumeroPuerta = dt.Rows[0][10].ToString();
                    eProd.Baja = Convert.ToBoolean(dt.Rows[0][11].ToString());
                }
            }

            return eProd;
        }

        public static string DConsultaUsuarioCi(string user)
        {
            string query = "SELECT ci FROM Usuario WHERE Usuario.user = '" + user + "';";
            DataTable dt = SelectCommand(query);
            return dt.Rows[0][0].ToString();
        }

        public static DataTable DConsultarUsuariosTodos() // DEVUELVE TODOS LOS USUARIOS
        {
            DataTable dt = SelectTablaCommand("Usuario");
            return dt;
        }

        public static DataTable DConsultarUsuariosProds()
        {
            DataTable dt = SelectCommand("SELECT Usuario.ci, nom_a, nom_b, ape_a, ape_b, Productor.rut_prod, Productor.produce, mail, user, calle_a, calle_b, nro_puerta, baja FROM Usuario INNER JOIN Productor ON Usuario.ci = Productor.ci;");
            return dt;
        }

        public static DataTable DConsultarUsuariosAdmins()
        {
            DataTable dt = SelectCommand("SELECT Usuario.ci, nom_a, nom_b, ape_a, ape_b, Administrativo.cargo, mail, user, calle_a, calle_b, nro_puerta, baja FROM Usuario INNER JOIN Administrativo ON Usuario.ci = Administrativo.ci;");
            return dt;
        }
        
        public static DataTable DConsultarUsuariosProdsYAdmins()
        {
            DataTable dt = SelectCommand("SELECT Usuario.ci, nom_a, nom_b, ape_a, ape_b, Productor.rut_prod, Productor.produce, Administrativo.cargo, mail, user, calle_a, calle_b, nro_puerta, baja  FROM Usuario INNER JOIN Productor ON Usuario.ci = Productor.ci INNER JOIN Administrativo ON Usuario.ci = Administrativo.ci;");
            return dt;
        }

        public static int DConsultaUserPwd(string usuario, string contrasenia) // CUENTA SI EXISTE LA CONTRASEÑA
        {
            string query = "Select Count(*) From Usuario Where user = '" + usuario + "' and pass = '" + contrasenia + "';";
            return CountCommand(query);
        }

        public static int DConsultaExisteCi(string ci) // CUENTA SI EXISTE LA CEDULA
        {
            string query = "Select Count(*) From Usuario Where ci = '" + ci + "';";
            return CountCommand(query);
        }

        public static int DConsultaExisteUSuario(string usuario) // CUENTA SI EXISTE EL USUARIO
        {
            string query = "Select Count(*) From Usuario Where user = '" + usuario + "';";
            return CountCommand(query);
        }

        public static DataTable DConsultaUserName(string ci) // BUSCA EL NOMBRE DE USUARIO CON LA CEDULA
        {
            string query = "SELECT user FROM Usuario WHERE Usuario.ci = '" + ci + "';";
            return SelectCommand(query);
        }

        public static DataTable DConsultaCedula(string username) // BUSCA CEDULA CON EL NOMBRE DE USUARIO
        {
            string query = "SELECT ci FROM Usuario WHERE Usuario.user = '" + username + "';";
            return SelectCommand(query);
        }

        public static int DConsultaEsAdministrativo(string usuario) // BUSCA SI EXISTE EL ADMINISTRATIVO
        {
            string query = "SELECT count(*) FROM Administrativo JOIN Usuario ON Usuario.user = '" + usuario + "' WHERE Usuario.ci = Administrativo.ci;";
            return CountCommand(query);
        }

        public static int DConsultaEsProductor(string usuario) // BUSCA SI EXISTE EL PRODUCTOR
        {
            string query = "SELECT count(*) FROM Productor JOIN Usuario ON Usuario.user = '" + usuario + "' WHERE Usuario.ci = Productor.ci;";
            return CountCommand(query);
        }

        public static DataTable DConsultaTelefonos(string ci)
        {
            string query = "SELECT tel FROM Telefono WHERE ci = '" + ci + "';";
            return SelectCommand(query);
        }

        public static bool DConsultaBaja(string ci)
        {
            string query = "SELECT baja FROM Usuario WHERE ci = '" + ci + "';";
            DataTable dt = SelectCommand(query);
            return Convert.ToBoolean(dt.Rows[0][0].ToString());
        }

        public static int DModificarUsuario(EProductor eUsuario) // UTILIZA UN EProductor, PERO MODIFICA LA TABLA USUARIO
        {
            string nom_b = ", nom_b = '" + eUsuario.SegundoNombre + "'";
            string calle_a = ", calle_a = '" + eUsuario.CalleA + "'";
            string calle_b = ", calle_b = '" + eUsuario.CalleB + "'";
            string nro_puerta = ", nro_puerta = '" + eUsuario.NumeroPuerta + "'";
            string pass = ", pass = '" + eUsuario.Pass + "'";

            if (string.IsNullOrEmpty(eUsuario.SegundoNombre))
            {
                nom_b = "";
            }
            if (string.IsNullOrEmpty(eUsuario.CalleA))
            {
                calle_a = "";
            }
            if (string.IsNullOrEmpty(eUsuario.CalleB))
            {
                calle_b = "";
            }
            if (string.IsNullOrEmpty(eUsuario.NumeroPuerta))
            {
                nro_puerta = "";
            }
            if (string.IsNullOrEmpty(eUsuario.Pass) || eUsuario.Pass == "********")
            {
                pass = "";
            }

            string query = "UPDATE Usuario SET nom_a = '" + eUsuario.PrimerNombre + "'" +
                                            nom_b + //", nom_b = '" + eUsuario.SegundoNombre + "'" +
                                            ", ape_a = '" + eUsuario.PrimerApellido + "'" +
                                            ", ape_b = '" + eUsuario.SegundoApellido + "'" +
                                             ", mail = '" + eUsuario.Mail + "'" +
                                             ", user = '" + eUsuario.User + "'" +
                                             pass + //", pass = '" + eUsuario.Pass + "'" +
                                          calle_a + //", calle_a = '" + eUsuario.CalleA + "'" +
                                          calle_b + //", calle_b = '" + eUsuario.CalleB + "'" +
                                       nro_puerta + //", nro_puerta = '" + eUsuario.NumeroPuerta + "'" +
                                             ", baja = " + eUsuario.Baja +
                                          " WHERE ci = '" + eUsuario.Ci + "';";
            return InsertCommand(query);
        }

        public static int DModificarTelefonos(string ci, List<string> telefonos)
        {
            int filasNuevas = 0;
            if (telefonos.Count > 0)
            {
                string query0 = "DELETE FROM Telefono WHERE Telefono.ci IN(" + ci + ");";
                string query1 = "INSERT INTO Telefono VALUES ('" + ci + "','" + telefonos[0] + "');";
                int filasQuitadas = InsertCommand(query0);
                filasNuevas = InsertCommand(query1);
                if (telefonos.Count > 1 && filasNuevas > 0)
                {
                    string query2 = "INSERT INTO Telefono VALUES ('" + ci + "','" + telefonos[1] + "');";
                    filasNuevas += InsertCommand(query2);
                }
                else
                {
                    return filasQuitadas;
                }
            }

            return filasNuevas;
        }

        public static int DCrearUsuarioNuevo(EProductor eUsuario)  // UTILIZA UN EProductor, PERO MODIFICA LA TABLA USUARIO
        {
            // valores opcionales:
            string nombreSecundario = "";
            string direccion = "";
            string query_nombreSecundario = "";
            string query_direccion = "";

            //valido valores opcionales para agregarlos al query string o no
            if (!string.IsNullOrEmpty(eUsuario.SegundoNombre))
            {
                nombreSecundario = eUsuario.SegundoNombre + "', '";
                query_nombreSecundario = "nom_b, ";
            }
            if (!string.IsNullOrEmpty(eUsuario.CalleA) && !string.IsNullOrEmpty(eUsuario.CalleB) && !string.IsNullOrEmpty(eUsuario.NumeroPuerta))
            {
                direccion = "'" + eUsuario.CalleA + "', '" + eUsuario.CalleB + "', '" + eUsuario.NumeroPuerta + "', ";
                query_direccion = "calle_a, calle_b, nro_puerta, ";
            }
            if (!string.IsNullOrEmpty(eUsuario.CalleA) && !string.IsNullOrEmpty(eUsuario.NumeroPuerta) && string.IsNullOrEmpty(eUsuario.CalleB))
            {
                direccion = "'" + eUsuario.CalleA + "', '" + eUsuario.NumeroPuerta + "', ";
                query_direccion = "calle_a, nro_puerta, ";
            }

            // armo la query por partes:
            string query = "INSERT INTO Usuario("+
                                                "ci, " + 
                                                "nom_a, " +
                                                query_nombreSecundario +
                                                "ape_a, " +
                                                "ape_b, " + 
                                                "mail, " +
                                                "user, " +
                                                "pass, " +
                                                query_direccion +
                                                "baja" +
                                                ") VALUES('" + 
                                                eUsuario.Ci + "', '" +
                                                eUsuario.PrimerNombre + "', '" +
                                                nombreSecundario +
                                                eUsuario.PrimerApellido + "', '" +
                                                eUsuario.SegundoApellido + "', '" +
                                                eUsuario.Mail + "', '" +
                                                eUsuario.User + "', '" +
                                                eUsuario.Pass + "', " +
                                                direccion +
                                                eUsuario.Baja.ToString() + ");";

            int insertResult = InsertCommand(query);

            if (eUsuario.ListaTelefonos.Count > 0)
            {
                List<string> tels = eUsuario.ListaTelefonos;

                tels.ForEach(delegate (string tel) {
                    string query2 = "INSERT INTO Telefono VALUES ('" + eUsuario.Ci + "','" + tel + "');";
                    InsertCommand(query2);
                });
            }

            return insertResult;
        }

        public static int DModificarDarBaja(string ci)
        {
            string query = "UPDATE Usuario SET baja = true WHERE ci = '" + ci + "';";
            return InsertCommand(query);
        }

        public static int DModificarCancelarBaja(string ci)
        {
            string query = "UPDATE Usuario SET baja = false WHERE ci = '" + ci + "';";
            return InsertCommand(query);
        }
    }
}
