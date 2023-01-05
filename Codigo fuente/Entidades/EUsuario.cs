using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Entidades
{
    public abstract class EUsuario
    {
        // propiedades:
        public abstract string Ci { get; set; }
        public abstract string PrimerNombre { get; set; }
        public abstract string SegundoNombre { get; set; }
        public abstract string PrimerApellido { get; set; }
        public abstract string SegundoApellido { get; set; }
        public abstract List<string> ListaTelefonos { get; set; }
        public abstract string Mail { get; set; }
        public abstract string User { get; set; }
        public abstract string Pass { get; set; }
        public abstract string CalleA { get; set; }
        public abstract string CalleB { get; set; }
        public abstract string NumeroPuerta { get; set; }
        public abstract bool Baja { get; set; }

        // constructores:
        public EUsuario() { }
        public EUsuario(string ci, string nom_a, string nom_b, string ape_a, string ape_b, List<string> tels, string mail, string user, string pass, string calle_a, string calle_b, string nro_puerta, bool baja)
        {
            Ci = ci;
            PrimerNombre = nom_a;
            SegundoNombre = nom_b;
            PrimerApellido = ape_a;
            SegundoApellido = ape_b;
            ListaTelefonos = tels;
            Mail = mail;
            User = user;
            Pass = pass;
            CalleA = calle_a;
            CalleB = calle_b;
            NumeroPuerta = nro_puerta;
            Baja = baja;
        }

        public override string ToString()
        {
            return
                (
                "Nombre completo: " + PrimerNombre + " " + SegundoNombre + " " + PrimerApellido + " " + SegundoApellido + System.Environment.NewLine +
                "Cedula: " + Ci + System.Environment.NewLine +
                "Telefonos: " + string.Join(",", ListaTelefonos) + System.Environment.NewLine +
                "Email: " + Mail + System.Environment.NewLine +
                "Usuario: " + User + System.Environment.NewLine +
                "Contraseña: " + Pass + System.Environment.NewLine +
                "Dirección: " + CalleA + " " + NumeroPuerta + " esq. " + CalleB + System.Environment.NewLine +
                "Estado de baja: " + Baja + System.Environment.NewLine
                );
        }

        public static string EncriptarPass(string pass)
        {
            if (string.IsNullOrEmpty(pass))
            {
                throw new Exception("Dato incorrecto para contraseña");
            }
            else if (pass.Length < 4)
            {
                throw new Exception("La contraseña debe tener al menos caracteres");
            }
            else
            {
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    UTF8Encoding utf8 = new UTF8Encoding();
                    byte[] data = md5.ComputeHash(utf8.GetBytes(pass));
                    return Convert.ToBase64String(data);
                }
            }
        }

        public static bool ValidarEmail(string email)
        {
            //cadena o expresion regular que verifica a un formato de correo electrónico
            //string expresion = "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[com])$"; //valida solo para correos con .com
            string expresion = "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$";
            //verifica que el email ingresado corresponda con la expresion válida
            if (Regex.IsMatch(email, expresion))
            {//verifica que la direccion corresponda y que la longitud de la cadena no esté vacía
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
