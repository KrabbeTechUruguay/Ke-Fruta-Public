using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EAdministrativo : EUsuario
    {
        private string ci;
        private string primerNombre;
        private string segundoNombre;
        private string primerApellido;
        private string segundoApellido;
        private List<string> listaTelefonos;
        private string mail;
        private string user;
        private string pass;
        private string calleA;
        private string calleB;
        private string numeroPuerta;
        private bool baja;
        private string cargo;

        public override string Ci
        {
            get { return ci; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Debe ingresar cedula");
                }
                else
                {
                    ci = value;
                }
            }
        }
        public override string PrimerNombre
        {
            get { return primerNombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Debe ingresar primer nombre");
                }
                else
                {
                    primerNombre = value.ToUpper();
                }
            }
        }
        public override string SegundoNombre
        {
            get { return segundoNombre; }
            set { segundoNombre = value.ToUpper(); }
        }
        public override string PrimerApellido
        {
            get { return primerApellido; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Debe ingresar ambos apellidos");
                }
                else
                {
                    primerApellido = value.ToUpper();
                }
            }
        }
        public override string SegundoApellido
        {
            get { return segundoApellido; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Debe ingresar ambos apellidos");
                }
                else
                {
                    segundoApellido = value.ToUpper();
                }
            }
        }
        public override List<string> ListaTelefonos { get => listaTelefonos; set => listaTelefonos = value; }
        public override string Mail
        {
            get { return mail; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Debe ingresar mail");
                }
                else
                {
                    mail = value;
                }
            }
        }
        public override string User
        {
            get { return user; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Debe ingresar nombre de usuario");
                }
                else
                {
                    user = value;
                }
            }
        }
        public override string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public override string CalleA { get => calleA; set => calleA = value; }
        public override string CalleB { get => calleB; set => calleB = value; }
        public override string NumeroPuerta { get => numeroPuerta; set => numeroPuerta = value; }
        public override bool Baja { get => baja; set => baja = value; }
        public string Cargo
        {
            get { return cargo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Debe ingresar cargo");
                }
                else
                {
                    cargo = value.ToUpper();
                }
            }
        }

        public EAdministrativo() { }

        public EAdministrativo(string ci, string nom_a, string nom_b, string ape_a, string ape_b, List<string> tels, string mail, string user, string pass, string calle_a, string calle_b, string nro_puerta, bool baja, string cargo) : base(ci, nom_a, nom_b, ape_a, ape_b, tels, mail, user, pass, calle_a, calle_b, nro_puerta, baja)
        {
            this.Ci = ci;
            this.PrimerNombre = nom_a;
            this.SegundoNombre = nom_b;
            this.PrimerApellido = ape_a;
            this.SegundoNombre = ape_b;
            this.ListaTelefonos = tels;
            this.Mail = mail;
            this.User = user;
            this.Pass = pass;
            this.CalleA = calle_a;
            this.CalleB = calle_b;
            this.NumeroPuerta = nro_puerta;
            this.Baja = baja;
            this.Cargo = cargo;
        }

        public override string ToString()
        {
            return
                (
                "Nombre completo: " + primerNombre + " " + segundoNombre + " " + primerApellido + " " + segundoApellido + System.Environment.NewLine +
                "Cargo: " + cargo + System.Environment.NewLine +
                "Cedula: " + ci + System.Environment.NewLine +
                "Telefonos: " + string.Join(",", listaTelefonos) + System.Environment.NewLine +
                "Email: " + mail + System.Environment.NewLine +
                "Usuario: " + user + System.Environment.NewLine +
                "Contraseña: " + pass + System.Environment.NewLine +
                "Dirección: " + calleA + " " + numeroPuerta + " esq. " + calleB + System.Environment.NewLine +
                "Estado de baja: " + baja + System.Environment.NewLine
                );
        }
    }
}
