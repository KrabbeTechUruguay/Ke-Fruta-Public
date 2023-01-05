using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Datos.DUsuario;
using static Logica.LSesion;
using Entidades;

namespace Logica
{
    public class LLogin
    {
        public static string LIniciarSesion(string usuario, string contrasenia) // guarda usuario en LSesion si es correcto y devuelve un mensaje
        {
            string mensaje;
            contrasenia = EUsuario.EncriptarPass(contrasenia);
            int resultadoExisteUser = DConsultaExisteUSuario(usuario);

            if (resultadoExisteUser == 1) // primero verifico si existe el usuario
            {
                string ci = Datos.DUsuario.DConsultaUsuarioCi(usuario); // pido la cedula
                if (DConsultaBaja(ci)) // consulto si la cedula esta de baja
                {
                    throw new Exception("Usuario dado de baja");
                }

                int resultadoVerificarPwd = DConsultaUserPwd(usuario, contrasenia);

                if (resultadoVerificarPwd == 1) // despues verifico la contraseña
                {
                    LSesion.LVerificarRoles(usuario);
                    if (!sesionEsAdministrativo && !sesionEsProductor) // verifico si el usuario tiene un rol asignado
                    {
                        mensaje = "Usuario sin rol asignado.";
                    }
                    else // si tiene un rol asignado inicia sesion exitosamente
                    {
                        LSesion.LInicializarDatosSesion(usuario); // guardo nombre de usuario en LSesion, reseteo contador de intentos de login en LSesion
                        mensaje = "Usuario " + usuario + " logueado con exito.";
                    }
                }
                else if (resultadoVerificarPwd == -1 || resultadoVerificarPwd > 1)
                {
                    mensaje = "Error de base de datos, consulte con el servicio técnico.";
                }
                else if (contrasenia == "" || contrasenia == "CONTRASEÑA")
                {
                    mensaje = "Ingrese su contraseña por favor.";
                }
                else
                {
                    sesionIntentosLogin++; // sumo intentos solo cuando se equivoca de contraseña
                    int restantes = 4 - sesionIntentosLogin;
                    if (restantes == 1)
                    {
                        mensaje = "Contraseña incorrecta. (último intento restante)";
                    }
                    else
                    {
                        mensaje = "Contraseña incorrecta. (" + restantes.ToString() + " intentos restantes)";
                    }
                }
            }
            else if (resultadoExisteUser == -1 || resultadoExisteUser > 1)
            {
                mensaje = "Error de base de datos, consulte con el servicio técnico.";
            }
            else if (usuario == "" || usuario == "USUARIO" || contrasenia == "" || contrasenia == "CONTRASEÑA")
            {
                mensaje = "Debe ingresar usuario y contrasenia.";
            }
            else if (resultadoExisteUser == 0)
            {
                mensaje = "Usuario incorrecto.";
            }
            else
            {
                mensaje = "Error de base de datos, consulte con el servicio técnico.";
            }
            return mensaje;
        }
    }
}
