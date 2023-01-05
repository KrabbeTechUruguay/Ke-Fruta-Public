using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Datos.DAdministrativo;
using static Datos.DProductor;
using static Datos.DUsuario;
using static Logica.LLogin;
using static Entidades.EAdministrativo;
using static Logica.LUsuarios;

namespace Logica
{
    public static class LSesion // Guarda los datos de la sesion activa, es visible e instanciable desde Presentacion y Logica.
    {
        public static string sesionUsuarioLogueado = null; // Username del usario logueado
        public static string sesionRolLogueado = null; // Tipo de usuario logueado, debe ser: "Administrativo" o "Productor"
        public static bool sesionEsAdministrativo = false;
        public static bool sesionEsProductor= false;
        public static int sesionIntentosLogin = 0; // Conteo de intentos al ingresar usuario y pwd
        public static string sesionCiUsuarioLogueado = "";

        public static void LVerificarRoles(string usuario)
        {
            sesionEsAdministrativo = LUsuarios.LEsAdministrativo(usuario);
            sesionEsProductor = LUsuarios.LEsProductor(usuario);
        }

        public static void LInicializarDatosSesion(string usuario)
        {
            
            sesionUsuarioLogueado = usuario;
            LVerificarRoles(usuario);
            sesionIntentosLogin = 0;
        }

        public static void LCargarUsuarioLogueado()
        {
            sesionCiUsuarioLogueado = Logica.LUsuarios.LConsultarCedula(sesionUsuarioLogueado);
        }
    }
}
