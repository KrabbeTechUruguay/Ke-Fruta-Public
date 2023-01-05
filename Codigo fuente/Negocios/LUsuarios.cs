using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static Entidades.EProductor;
using static Entidades.EAdministrativo;
using static Datos.DAdministrativo;
using static Datos.DUsuario;
using static Datos.DProductor;
using static Datos.DConector;
using Entidades;

namespace Logica
{
    public class LUsuarios
    {
        public static List<string> LConsultaTelefonos(string ci)
        {
            List<string> listaTelefonos = new List<string>();
            DataTable dt = DConsultaTelefonos(ci);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listaTelefonos.Add(dt.Rows[i][0].ToString());
                }
            }
            return listaTelefonos;
        }

        public static bool LConsultaExisteCi(string ci)
        {
            return Convert.ToBoolean(DConsultaExisteCi(ci));
        }

        public static bool LConsultaExisteUsuario(string username)
        {
            return Convert.ToBoolean(DConsultaExisteUSuario(username));
        }

        public static string LConsultarUserName(string ci)
        {
            string userName = null;
            DataTable dt = DConsultaUserName(ci);
            if (dt.Rows.Count > 0)
            {
                userName = dt.Rows[0][1].ToString();
            }
            return userName;
        }

        public static bool LEsAdministrativo(string usuario)
        {
            return Convert.ToBoolean(DConsultaEsAdministrativo(usuario));
        }
        public static bool LEsProductor(string usuario)
        {
            return Convert.ToBoolean(DConsultaEsProductor(usuario));
        }

        internal static string LConsultarCedula(string username) // devuelve la cedula
        {
            DataTable dt = Datos.DUsuario.DConsultaCedula(username);
            dt.Rows[0][0].ToString();
            return dt.Rows[0][0].ToString();
        }

        public static Entidades.EAdministrativo LConsultarDatosAdministrativo(string ci)
        {
            Entidades.EAdministrativo eAdmin = DConsultaAdministrativo(ci);
            eAdmin.ListaTelefonos = LConsultaTelefonos(ci); // le agrego los telefonos
            return eAdmin;
        }
        public static Entidades.EProductor LConsultarDatosProductor(string ci)
        {
            Entidades.EProductor eProd = DConsultaProductor(ci);
            eProd.ListaTelefonos = LConsultaTelefonos(ci); // le agrego los telefonos
            return eProd;
        }

        public static Entidades.EProductor LConsultarDatosUsuario(string ci)
        {
            Entidades.EProductor eUser = DConsultaUsuario(ci);
            eUser.ListaTelefonos = LConsultaTelefonos(ci); // le agrego los telefonos
            return eUser;
        }

        public static DataTable LConsultarUsuariosTodos()
        {
            DataTable dt = DConsultarUsuariosTodos();
            return dt;
        }
        public static DataTable LConsultarUsuariosProds()
        {
            DataTable dt = DConsultarUsuariosProds();
            return dt;
        }
        public static DataTable LConsultarUsuariosAdmins()
        {
            DataTable dt = DConsultarUsuariosAdmins();
            return dt;
        }
        public static DataTable LConsultarUsuariosProdsYAdmins()
        {
            DataTable dt = DConsultarUsuariosProdsYAdmins();
            return dt;
        }

        public static bool LConsultaUsuarioEsBaja(string ci)
        {
            return DConsultaBaja(ci);
        }

        public static string LModificarProductor(Entidades.EProductor eProd)
        {
            int resultadoModificarUser = Datos.DProductor.DModificarUsuario(eProd);
            int resutladoModificarProd = Datos.DProductor.DModificarProductor(eProd);

            if (resultadoModificarUser == -1)
            {
                throw new Exception("Error al modificar datos de usuario");
            }
            if (resutladoModificarProd == -1)
            {
                throw new Exception("Error al modificar rol de productor");
            }
            if (eProd.ListaTelefonos.Count > 0)
            {
                int resultadoModificarTels = Datos.DUsuario.DModificarTelefonos(eProd.Ci, eProd.ListaTelefonos);
                if (resultadoModificarTels == -1)
                {
                    throw new Exception("Error al modificar telefono/s");
                }
            }
            return "Productor modificado con éxito";
        }

        public static string LModificarAdministrativo(Entidades.EAdministrativo eAdmin)
        {
            int resultadoModificarUser = Datos.DAdministrativo.DModificarUsuario(eAdmin);
            int resutladoModificarProd = Datos.DAdministrativo.DModificarAdministrativo(eAdmin);

            if (resultadoModificarUser == -1)
            {
                throw new Exception("Error al modificar datos de usuario");
            }
            if (resutladoModificarProd == -1)
            {
                throw new Exception("Error al modificar datos de productor");
            }
            if (eAdmin.ListaTelefonos.Count > 0)
            {
                int resultadoModificarTels = Datos.DUsuario.DModificarTelefonos(eAdmin.Ci, eAdmin.ListaTelefonos);
                if (resultadoModificarTels == -1)
                {
                    throw new Exception("Error al modificar telefono/s");
                }
            }
            return "Productor modificado con éxito";
        }

        public static string LModificarAmbosRoles(Entidades.EProductor eProd, string cargoAdmin)
        {
            EAdministrativo eAdmin = new EAdministrativo
            {
                Ci = eProd.Ci,
                Cargo = cargoAdmin
            };

            int resultadoModificarUser = Datos.DProductor.DModificarUsuario(eProd);
            int resutladoModificarProd = Datos.DProductor.DModificarProductor(eProd);
            int resultadoModificarAdmin = Datos.DAdministrativo.DModificarAdministrativo(eAdmin);

            if (resultadoModificarUser == -1)
            {
                throw new Exception("Error al modificar datos de usuario");
            }
            if (resutladoModificarProd == -1)
            {
                throw new Exception("Error al modificar rol de productor");
            }
            if (resultadoModificarAdmin == -1)
            {
                throw new Exception("Error al modificar rol de administrativo");
            }
            if (eProd.ListaTelefonos.Count > 0)
            {
                int resultadoModificarTels = Datos.DUsuario.DModificarTelefonos(eProd.Ci, eProd.ListaTelefonos);
                if (resultadoModificarTels == -1)
                {
                    throw new Exception("Error al modificar telefono/s");
                }
            }
            return "Usuario modificado con éxito";
        }

        public static void LEliminarRolAdministrativo(string ci)
        {
            Datos.DAdministrativo.DDeleteRolAdministrativo(ci);
        }

        public static void LEliminarRolProductor(string ci)
        {
            Datos.DProductor.DDeleteRolProductor(ci);
        }

        public static string LCrearUsuario(EProductor eUsuarioSinRol)
        {
            string mensaje;
            try
            {
                int resultadoInsert = Datos.DUsuario.DCrearUsuarioNuevo(eUsuarioSinRol);
                if (resultadoInsert == 1)
                {
                    mensaje = eUsuarioSinRol.User + " creado con éxito.";
                }
                else if (resultadoInsert == 0)
                {
                    mensaje = "No se ha creado ningun usuario.";
                }
                else
                {
                    mensaje = "Error al registrar usuario";
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

        public static string LCrearAdministrativo(EAdministrativo eAdministrativo)
        {
            string mensaje;
            try
            {
                int resultadoInsert = Datos.DAdministrativo.DCrearRolAdministrativo(eAdministrativo);
                if (resultadoInsert == 1)
                {
                    mensaje = eAdministrativo.Cargo + " creado con éxito.";
                }
                else if (resultadoInsert == 0)
                {
                    mensaje = "No se ha creado rol de usuario.";
                }
                else
                {
                    mensaje = "Error al registrar rol";
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

        public static string LCrearProductor(EProductor eProductor)
        {
            string mensaje;
            try
            {
                int resultadoInsert = Datos.DProductor.DCrearRolProductor(eProductor);
                if (resultadoInsert == 1)
                {
                    mensaje = "productor de " + eProductor.Produce + " creado con éxito.";
                }
                else if (resultadoInsert == 0)
                {
                    mensaje = "No se ha creado rol de usuario.";
                }
                else
                {
                    mensaje = "Error al registrar rol";
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

        public static string LCancelarBajaCi(string ci)
        {
            string msg = "";
            int updateResult = Datos.DUsuario.DModificarDarBaja(ci);
            
            if (updateResult == 1)
            {
                msg = "Cedula " + ci + " ya no se encuentra de baja.";
            }
            if (updateResult == 0)
            {
                msg = "No se ha realizado la baja.";
            }
            if (updateResult == -1)
            {
                msg = "Error al realizar la baja.";
            }

            return msg;
        }

        public static bool LConsultarExisteProductor(string ci)
        {
            int result = Datos.DProductor.DConsultaExisteProductor(ci);

            if (result == 1)
            {
                return true;
            }
            return false;
        }
    }
}
