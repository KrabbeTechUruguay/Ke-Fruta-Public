using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Eso se pone para poder mover la pestaña del login
using Logica;
using static Logica.LLogin ;
using static Logica.LSesion;

namespace Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        /// ESTO LO PONEMOS PARA QUE FUNCIONE ARRASTRAR EL LOGIN CON EL MOUSE
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        /// FIN 
        //protected bool userOk = false; //Sirve para hacer un las validaciones | true = User correcta , False = User incorrecta
        //protected bool pwdOk = false; //Sirve para hacer un las validaciones | true = Contraseña correcta , False = Contraseña incorrecta
        //protected bool esAdministrativo = false; //Sirve para saber si el usuario es administrativo   

        // ´Validación´ 
       private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (char.IsDigit(e.KeyChar)) //Validacion solo letra en el Usuario
            {
                e.Handled = true;
                
            }
            else if (Char.IsSeparator(e.KeyChar)) // no se pueden utilizar espacios
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && txtUser.Text != "USUARIO" && txtUser.Text != "") // si presiona enter pasa al txtPwd
            {
                txtPwd.Focus();
            }
        }
        private void TxtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar)) // no se pueden utilizar espacios
            {
                e.Handled = true;
            }/*
            else if (e.KeyChar == (char)13 && txtUser.Text != "USUARIO" && txtUser.Text != "") // si presiona enter pasa al txtPwd
            {
                btnIniciarSesion.Focus();
                //btnIniciarSesion.PerformClick();
                //lblError.Show();
            }*/
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblError.Text = "Solo se admiten letras y núemros";
                lblError.Show();
            }
            if (e.Handled == false)
            {
                lblError.Hide();
            }
            if (e.KeyChar == (char)13 && txtUser.Text != "USUARIO" && txtUser.Text != "") // si presiona enter pasa al txtPwd
            {
                btnIniciarSesion.PerformClick();
            }
        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
            }
        }
        private void TxtPwd_Enter(object sender, EventArgs e)
        {
            if (txtPwd.Text == "CONTRASEÑA")
            {
                txtPwd.Text = "";
                txtPwd.UseSystemPasswordChar = true;
            }
        }
        private void TxtPwd_Leave(object sender, EventArgs e)
        {
            if (txtPwd.Text == "")
            {
                txtPwd.Text = "CONTRASEÑA";
                txtPwd.UseSystemPasswordChar = false;
            }
        }
        // ´Validación´ fin
        
        private void BtnIniciarSesion_Click(object sender, EventArgs e)  ///// ACÁ VAN LOS USUARIOS QUE VAN A PODER ENTRAR, ETC.
        {
            Color colorOriginal = btnIniciarSesion.BackColor;

            string msgErrorLogin = "Error";
            try
            {
                msgErrorLogin = LIniciarSesion(txtUser.Text, txtPwd.Text); // carga al usuario en LSesion o devuelve un mensaje de error
            }
            catch (Exception ex)
            {
                msgErrorLogin = "Error: " + ex.Message;
                MostrarMensajeError();
            }

            if (sesionUsuarioLogueado != null) // comprueba si hay usuario guardado en la sesion
            {
                // COMIENZA VALIDACIÓN DE TIPO DE USUARIO
                if (sesionEsAdministrativo && sesionEsProductor) // si tiene ambos roles
                {
                    lblIniciarSesion.Visible = false;
                    lblIniciarSesion.Enabled = false;
                    txtUser.Visible = false;
                    txtUser.Enabled = false;
                    txtPwd.Visible = false;
                    txtPwd.Enabled = false;
                    picMostrarContra.Visible = false;
                    picMostrarContra.Enabled = false;
                    lblError.Visible = false;
                    lblError.Enabled = false;
                    btnIniciarSesion.Visible = false;
                    btnIniciarSesion.Enabled = false;

                    AbrirOpcionesTipoUser(new frmLoginTipoUsuario());
                }
                else // si tiene un solo rol lo guardo en la sesion e inicializo frmMenu,
                {
                    if (sesionEsAdministrativo && !sesionEsProductor)
                    {
                        this.Hide();
                        sesionRolLogueado = "Administrativo";
                        Form FormMenu = new frmMenu();
                        FormMenu.Show();
                    }
                    else if (sesionEsProductor && !sesionEsAdministrativo)
                    {
                        this.Hide();
                        sesionRolLogueado = "Productor";
                        Form FormMenu = new frmMenu();
                        FormMenu.Show();
                    }
                    else
                    {
                        MostrarMensajeError();
                    }
                }
                // FIN VALIDACION DE TIPO DE USUARIO
            }
            else
            {
                MostrarMensajeError();
            }

            void MostrarMensajeError()
            {
                lblError.Text = msgErrorLogin;
                lblError.Visible = true;
                lblError.Show();

                if (sesionIntentosLogin >= 4) // se deshabilita el login si supera los 3 intentos extra (4 en total)
                {
                    int x = 15;
                    lblError.Text = "Reintente en " + x + " segundos."; ;
                    btnIniciarSesion.BackColor = Color.Gray;
                    btnIniciarSesion.Enabled = false;
                    _ = EsperarXsegundos(x); // se deshabilita durante x segundos
                }
            }

            async Task EsperarXsegundos(int x)
            {
                await Task.Delay(x * 1000);
                btnIniciarSesion.Enabled = true;
                btnIniciarSesion.BackColor = colorOriginal;
                lblError.Text = "";
                sesionIntentosLogin = 0;
            }
        } 

        private void PicCerrar_Click(object sender, EventArgs e) ///// ACÁ SE CONFIGURO PARA CUANDO SE HAGA CLICK EN EL BOTON "CERRAR" SE CIERRE.
        {
            Application.Exit();
        }

        private void PicMinimizar_Click(object sender, EventArgs e)  ///// ACÁ SE CONFIGURO PARA CUANDO SE HAGA CLICK EN EL BOTON "MINIMIZAR" SE MINIMIZE.
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PnlLateral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PicMostrarContra_Click(object sender, EventArgs e)
        {
            if (txtPwd.UseSystemPasswordChar == false )
            {
                txtPwd.UseSystemPasswordChar = true;
            }
            else if (txtPwd.UseSystemPasswordChar == true )
            {
                txtPwd.UseSystemPasswordChar = false;
            }
        }

        public void AbrirOpcionesTipoUser(object formularioHijo) // Esto se utiliza para abrir los forms hijos en el Form Padre sin que se vea mal
        {
            if (this.pnlLoginMenu.Controls.Count > 0) // pregunta si hay algun panel((Opciones del menu)) en el panel para mostrarlos.
                this.pnlLoginMenu.Controls.RemoveAt(0); // en el caso de que haya algun panel abierto, este comando se encargara de eliminar el panel que ya no queremos.

            Form fh = formularioHijo as Form;
            fh.TopLevel = false; // Muestra la ventana en una jerarquía ´inferior´. | Es decir el PanelHijo tendra menos jerarquía que el panel padre.
            fh.Dock = DockStyle.Fill; // Ocupa todo el espacio del form creado en el panelMostrarOpciones.
            this.pnlLoginMenu.Controls.Add(fh); // Añada el form {...} al Panel de mostrar las opciones.
            this.pnlLoginMenu.Tag = fh; // Controla los datos del control.
            fh.Show();
        }
    }
}
