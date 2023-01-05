using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Logica.LUsuarios;
using static Entidades.EAdministrativo;
using static Entidades.EUsuario;
using static Entidades.EProductor;
using Entidades;
using static Logica.LValidacion;

namespace Presentacion
{
    public partial class frmMenuAdminGestUsuario : Form
    {
        public frmMenuAdminGestUsuario()
        {
            InitializeComponent();
        }

        /*
         *      **********************************************
         *      *               CONSULTAR TAB                *
         *      **********************************************
         */

        private void btnConsultar_CargarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = LConsultarUsuariosTodos();
                if (dt.Columns.Count > 0)
                {
                    gridUsuarios.DataSource = dt;
                }
                else
                {
                    lblConsultaError.Text = "No se encontraron usuarios.";
                    lblConsultaError.Show();
                }
            }
            catch (Exception ex)
            {
                lblConsultaError.Text = ex.Message;
                lblConsultaError.Show();
            }
        }
        private void btnConsultar_CargarProd_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = LConsultarUsuariosProds();
                if (dt.Columns.Count > 0)
                {
                    gridUsuarios.DataSource = dt;
                }
                else
                {
                    lblConsultaError.Text = "No se encontraron usuarios.";
                    lblConsultaError.Show();
                }
            }
            catch (Exception ex)
            {
                lblConsultaError.Text = ex.Message;
                lblConsultaError.Show();
            }
        }

        private void btnConsultar_CargarAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = LConsultarUsuariosAdmins();
                if (dt.Columns.Count > 0)
                {
                    gridUsuarios.DataSource = dt;
                }
                else
                {
                    lblConsultaError.Text = "No se encontraron usuarios.";
                    lblConsultaError.Show();
                }
            }
            catch (Exception ex)
            {
                lblConsultaError.Text = ex.Message;
                lblConsultaError.Show();
            }
        }

        private void btnConsultar_CargarProdYAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = LConsultarUsuariosProdsYAdmins();
                if (dt.Columns.Count > 0)
                {
                    gridUsuarios.DataSource = dt;
                }
                else
                {
                    lblConsultaError.Text = "No se encontraron usuarios.";
                    lblConsultaError.Show();
                }
            }
            catch (Exception ex)
            {
                lblConsultaError.Text = ex.Message;
                lblConsultaError.Show();
            }
        }

        /*
         *      **********************************************
         *      *               MODIFICAR TAB                *
         *      **********************************************
         */
        private string pwdMD5Anterior = null; // acá se va aguardar la contrasenia para comparar si la modificó

        private void btnModificar_CargarDatos_Click(object sender, EventArgs e)
        {
            string ci = txtModificarCedula.Text;

            try // dentro del try busco y cargo los datos de la cedula ingresada
            {
                if (ci.Length > 5)
                {
                    if (LConsultaExisteCi(ci))
                    {
                        lblModificarError.Visible = false;
                        EProductor eUser = LConsultarDatosUsuario(ci); // SE USA SOLO PARA USUARIO SIN ROL ASIGNADO (se carga en un productor incompleto)
                        EProductor eProd = LConsultarDatosProductor(ci);
                        EAdministrativo eAdmin = LConsultarDatosAdministrativo(ci);
                        if (!eUser.Baja) // SI NO ESTA DE BAJA PROSIGO
                        {
                            lblModificarError.Visible = false;
                            if (eAdmin.Ci == ci && eProd.Ci == ci) // es productor y administrativo
                            {
                                Modificar_HabilitarControles();
                                Modificar_LimpiarControles();
                                Modificar_LlenarControlesProdYAdmin(eProd,eAdmin);
                                pwdMD5Anterior = eProd.Pass;
                            }
                            else if (eProd.Ci == ci && eAdmin.Ci != ci) // es solo productor
                            {
                                Modificar_HabilitarControles();
                                Modificar_LimpiarControles();
                                Modificar_LlenarControlesProd(eProd);
                                pwdMD5Anterior = eProd.Pass;
                                chkModificarEsAdministrativo.Checked = false;
                            }
                            else if (eAdmin.Ci == ci && eProd.Ci != ci) // es solo administrativo
                            {
                                Modificar_HabilitarControles();
                                Modificar_LimpiarControles();
                                Modificar_LlenarControlesAdmin(eAdmin);
                                pwdMD5Anterior = eAdmin.Pass;
                                chkModificarEsProductor.Checked = false;
                            }
                            else // es usuario sin rol
                            {
                                Modificar_HabilitarControles();
                                Modificar_LimpiarControles();
                                Modificar_LlenarControlesSinRol(eUser);
                                lblModificarError.Visible = true;
                                lblModificarError.Text = "Advertencia: No tiene rol asignado";
                                pwdMD5Anterior = eUser.Pass;
                                chkModificarEsAdministrativo.Checked = false;
                                chkModificarEsProductor.Checked = false;
                            }
                        }
                        else
                        {
                            lblModificarError.Visible = true;
                            lblModificarError.Text = "El usuario se encuentra dado de baja.";
                        }
                    }
                    else
                    {
                        lblModificarError.Visible = true;
                        lblModificarError.Text = "No se ha encontrado la cedula";
                    }
                }
                else
                {
                    lblModificarError.Visible = true;
                    lblModificarError.Text = "Debe ingresar una cedula válida";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                System.Console.WriteLine(ex.Message);
                //lblModificarError.Text = ex.Message;
                lblModificarError.Text = "Error de base de datos, consulte al servicio técnico.";
            }
        }

        private void txtModificarCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) //Validacion solo numeros, backspace y enter
            {
                e.Handled = true;
            }
            if (txtModificarCedula.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnModificarLimpiar_Click(object sender, EventArgs e)
        {
            Modificar_DeshabilitarControles();
            txtModificarCedula.Enabled = true;
            txtModificarCedula.Clear();
            Modificar_LimpiarControles();
            txtModificarCedula.Focus();
            txtModificarCargo.Clear();
            txtModificarCargo.Enabled = false;
        }

        private void Modificar_HabilitarControles()
        {
            //datos personales
            txtModificarCedula.Enabled = true;
            txtModificarNomA.Enabled = true;
            txtModificarNomB.Enabled = true;
            txtModificarApeA.Enabled = true;
            txtModificarApeB.Enabled = true;
            txtModificarDireccion.Enabled = true;
            txtModificarNroPuerta.Enabled = true;
            txtModificarEsquina.Enabled = true;
            txtModificarEmail.Enabled = true;
            txtModificarTelefono.Enabled = true;
            txtModificarCelular.Enabled = true;
            //datos de usuario
            txtModificarUsuario.Enabled = true;
            txtModificarContrasenia.Enabled = true;
            //tipo de usuario: administrativo
            chkModificarEsAdministrativo.Enabled = true;
            txtModificarCargo.Enabled = true;
            //tipo de usuario: productor
            chkModificarEsProductor.Enabled = true;
            txtModificarRut.Enabled = true;
            cboModificarProduce.Enabled = true;
            btnModificarGuardarCambios.Enabled = true;
        }

        private void Modificar_DeshabilitarControles()
        {
            //datos personales
            //txtModificarCedula.Enabled = false; // no deshabilito la cedula
            txtModificarNomA.Enabled = false;
            txtModificarNomB.Enabled = false;
            txtModificarApeA.Enabled = false;
            txtModificarApeB.Enabled = false;
            txtModificarDireccion.Enabled = false;
            txtModificarNroPuerta.Enabled = false;
            txtModificarEsquina.Enabled = false;
            txtModificarEmail.Enabled = false;
            txtModificarTelefono.Enabled = false;
            txtModificarCelular.Enabled = false;
            //datos de usuario
            txtModificarUsuario.Enabled = false;
            txtModificarContrasenia.Enabled = false;
            //tipo de usuario: administrativo
            chkModificarEsAdministrativo.Enabled = false;
            txtModificarCargo.Enabled = false;
            //tipo de usuario: productor
            chkModificarEsProductor.Enabled = false;
            txtModificarRut.Enabled = false;
            cboModificarProduce.Enabled = false;
            btnModificarGuardarCambios.Enabled = false;
        }

        private void Modificar_LimpiarControles()
        {
            //datos personales
            //txtModificarCedula.Clear(); no limpio la cedula
            txtModificarNomA.Clear();
            txtModificarNomB.Clear();
            txtModificarApeA.Clear();
            txtModificarApeB.Clear();
            txtModificarDireccion.Clear();
            txtModificarNroPuerta.Clear();
            txtModificarEsquina.Clear();
            txtModificarEmail.Clear();
            txtModificarTelefono.Clear();
            txtModificarCelular.Clear();
            //datos de usuario
            txtModificarUsuario.Clear();
            txtModificarContrasenia.Clear();
            //tipo de usuario: administrativo
            chkModificarEsAdministrativo.Checked = false;
            txtModificarCargo.Clear();
            //tipo de usuario: productor
            chkModificarEsProductor.Checked = false;
            txtModificarRut.Clear();
            cboModificarProduce.SelectedIndex = -1;
        }

        private void Modificar_LlenarControlesSinRol(Entidades.EProductor eProd)
        {
            //datos personales
            txtModificarCedula.Enabled = false;
            txtModificarNomA.Text = eProd.PrimerNombre;
            txtModificarNomB.Text = eProd.SegundoNombre;
            txtModificarApeA.Text = eProd.PrimerApellido;
            txtModificarApeB.Text = eProd.SegundoApellido;
            txtModificarDireccion.Text = eProd.CalleA;
            txtModificarNroPuerta.Text = eProd.NumeroPuerta;
            txtModificarEsquina.Text = eProd.CalleB;
            txtModificarEmail.Text = eProd.Mail;
            //datos de usuario
            txtModificarUsuario.Text = eProd.User;
            txtModificarContrasenia.Text = "********"; // 8 asteriscos
            //tipo de usuario: administrativo
            chkModificarEsAdministrativo.Checked = false;
            txtModificarCargo.Clear();
            txtModificarCargo.Enabled = false;
            //tipo de usuario: productor
            chkModificarEsProductor.Checked = false;
            txtModificarRut.Clear();
            txtModificarRut.Enabled = false;
            cboModificarProduce.SelectedIndex = -1;
            cboModificarProduce.Enabled = false;

            if (eProd.ListaTelefonos.Count > 0)
            {
                txtModificarTelefono.Text = eProd.ListaTelefonos[0];
            }
            if (eProd.ListaTelefonos.Count > 1)
            {
                txtModificarCelular.Text = eProd.ListaTelefonos[1];
            }
        }

        private void Modificar_LlenarControlesAdmin(Entidades.EAdministrativo eAdmin)
        {
            //datos personales
            txtModificarCedula.Enabled = false;
            txtModificarNomA.Text = eAdmin.PrimerNombre;
            txtModificarNomB.Text = eAdmin.SegundoNombre;
            txtModificarApeA.Text = eAdmin.PrimerApellido;
            txtModificarApeB.Text = eAdmin.SegundoApellido;
            txtModificarDireccion.Text = eAdmin.CalleA;
            txtModificarNroPuerta.Text = eAdmin.NumeroPuerta;
            txtModificarEsquina.Text = eAdmin.CalleB;
            txtModificarEmail.Text = eAdmin.Mail;
            //datos de usuario
            txtModificarUsuario.Text = eAdmin.User;
            txtModificarContrasenia.Text = "********"; // 8 asteriscos
            //tipo de usuario: administrativo
            chkModificarEsAdministrativo.Checked = true;
            txtModificarCargo.Text = eAdmin.Cargo;
            //tipo de usuario: productor
            chkModificarEsProductor.Checked = false;
            txtModificarRut.Clear();
            cboModificarProduce.SelectedIndex = -1;
            cboModificarProduce.Enabled = false;
            txtModificarRut.Enabled = false;
            cboModificarProduce.Enabled = false;

            if (eAdmin.ListaTelefonos.Count > 0)
            {
                txtModificarTelefono.Text = eAdmin.ListaTelefonos[0];
            }
            if (eAdmin.ListaTelefonos.Count > 1)
            {
                txtModificarCelular.Text = eAdmin.ListaTelefonos[1];
            }
        }

        private void Modificar_LlenarControlesProd(Entidades.EProductor eProd)
        {
            //datos personales
            txtModificarCedula.Enabled = false;
            txtModificarNomA.Text = eProd.PrimerNombre;
            txtModificarNomB.Text = eProd.SegundoNombre;
            txtModificarApeA.Text = eProd.PrimerApellido;
            txtModificarApeB.Text = eProd.SegundoApellido;
            txtModificarDireccion.Text = eProd.CalleA;
            txtModificarNroPuerta.Text = eProd.NumeroPuerta;
            txtModificarEsquina.Text = eProd.CalleB;
            txtModificarEmail.Text = eProd.Mail;
            //datos de usuario
            txtModificarUsuario.Text = eProd.User;
            txtModificarContrasenia.Text = "********"; // 8 asteriscos
            //tipo de usuario: administrativo
            chkModificarEsAdministrativo.Checked = false;
            txtModificarCargo.Clear();
            txtModificarCargo.Enabled = false;
            //tipo de usuario: productor
            chkModificarEsProductor.Checked = true;
            txtModificarRut.Text = eProd.Rut;
            if (eProd.Produce == "CER")
            {
                cboModificarProduce.SelectedIndex = 0; // orden: cer, fru, ver
                cboModificarProduce.Text = "Cereal";
            }
            else if (eProd.Produce == "FRU")
            {
                cboModificarProduce.SelectedIndex = 1;
                cboModificarProduce.Text = "Fruta";
            }
            else // VER
            {
                cboModificarProduce.SelectedIndex = 2;
                cboModificarProduce.Text = "Verdura";
            }
            txtModificarRut.Text = eProd.Rut.ToString();

            if (eProd.ListaTelefonos.Count > 0)
            {
                txtModificarTelefono.Text = eProd.ListaTelefonos[0];
            }
            if (eProd.ListaTelefonos.Count > 1)
            {
                txtModificarCelular.Text = eProd.ListaTelefonos[1];
            }
        }

        private void Modificar_LlenarControlesProdYAdmin(EProductor eProd, EAdministrativo eAdmin)
        {
            Modificar_LlenarControlesProd(eProd);
            chkModificarEsAdministrativo.Checked = true;
            txtModificarCargo.Text = eAdmin.Cargo;
        }

        private void chkModificarEsAdministrativo_CheckedChanged(object sender, EventArgs e)
        {
            txtModificarCargo.Clear();
            if (chkModificarEsAdministrativo.Checked)
            {
                txtModificarCargo.Text = "Empleado";
                txtModificarCargo.Enabled = true;
            }
            else
            {
                chkModificarEsProductor.Checked = true;
                txtModificarCargo.Enabled = false;
            }
        }

        private void chkModificarEsProductor_CheckedChanged(object sender, EventArgs e)
        {
            cboModificarProduce.SelectedIndex = -1;
            txtModificarRut.Clear();
            if (chkModificarEsProductor.Checked)
            {
                cboModificarProduce.SelectedIndex = 0;
                cboModificarProduce.Enabled = true;
                txtModificarRut.Enabled = true;
            }
            else
            {
                chkModificarEsAdministrativo.Checked = true;
                cboModificarProduce.Enabled = false;
                txtModificarRut.Enabled = false;
            }
        }

        private void btnModificarGuardarCambios_Click(object sender, EventArgs e)
        {
            //string ci = txtModificarCedula.Text;
            bool esAdmin = chkModificarEsAdministrativo.Checked;
            bool esProd = chkModificarEsProductor.Checked;

            try
            {
                // cargo los datos sin rol antes de verificar el mismo
                string modificarCi = txtModificarCedula.Text;
                string modificarPrimerNombre = txtModificarNomA.Text;
                string modificarSegundoNombre = txtModificarNomB.Text;
                string modificarPrimerApellido = txtModificarApeA.Text;
                string modificarSegundoApellido = txtModificarApeB.Text;
                string modificarCargo = txtModificarCargo.Text;
                string modificarProduce = cboModificarProduce.Text;
                string moficiarRut = txtModificarRut.Text;
                List<string> modificarListaTelefonos = new List<string> { txtModificarCelular.Text , txtModificarTelefono.Text };
                string modificarMail = txtModificarEmail.Text;
                string modificarUser = txtModificarUsuario.Text;
                string modificarPass = txtModificarContrasenia.Text;
                string modificarCalleA = txtModificarDireccion.Text;
                string modificarCalleB = txtModificarEsquina.Text;
                string modificarNumeroPuerta = txtModificarNroPuerta.Text;
                bool modificarBaja = false;
                lblModificarError.Hide();

                // valido el rol y guardo los datos
                if (pwdMD5Anterior == EncriptarPass(modificarPass)) // si escribió la misma contraseña
                {
                    lblModificarError.Text = "La contraseña debe ser diferente a la anterior";
                    lblModificarError.Show();
                }
                else if (esAdmin && !esProd) // si es solo Administrativo
                {
                    if (txtModificarCargo.Text.Length < 5)
                    {
                        throw new Exception("Cargo no válido, 5 caracteres mínimo");
                    }

                    EAdministrativo eNuevoAdmin = new EAdministrativo
                    {
                        Ci = modificarCi,
                        PrimerNombre = modificarPrimerNombre,
                        SegundoNombre = modificarSegundoNombre,
                        PrimerApellido = modificarPrimerApellido,
                        SegundoApellido = modificarSegundoApellido,
                        Cargo = modificarCargo,
                        ListaTelefonos = modificarListaTelefonos,
                        Mail = modificarMail,
                        User = modificarUser,
                        Pass = modificarPass,
                        CalleA = modificarCalleA,
                        CalleB = modificarCalleB,
                        NumeroPuerta = modificarNumeroPuerta,
                        Baja = modificarBaja
                    };
                    if (MessageBox.Show("Desea modificar los siguientes datos?:" + System.Environment.NewLine + System.Environment.NewLine +
                                        eNuevoAdmin.ToString() + System.Environment.NewLine +
                                        "Es productor: NO" + System.Environment.NewLine +
                                        "Es administrativo: SI",
                                        "Desea modificar el usuario?",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes) // confirmo los cambios
                    {
                        if (modificarPass != "********" && !string.IsNullOrEmpty(modificarPass)) // si cambio el pass lo guardo
                        {
                            eNuevoAdmin.Pass = EncriptarPass(modificarPass);
                        }
                        string resultadoMensaje = Logica.LUsuarios.LModificarAdministrativo(eNuevoAdmin); // guardo los datos en la DB
                        Logica.LUsuarios.LEliminarRolProductor(eNuevoAdmin.Ci);
                        MessageBox.Show(resultadoMensaje, "Información: ");
                    }
                    lblModificarError.Hide();
                }
                else if (!esAdmin && esProd) // es solo Productor
                {
                    EProductor eNuevoProd = new EProductor
                    {
                        Ci = modificarCi,
                        PrimerNombre = modificarPrimerNombre,
                        SegundoNombre = modificarSegundoNombre,
                        PrimerApellido = modificarPrimerApellido,
                        SegundoApellido = modificarSegundoApellido,
                        Rut = moficiarRut,
                        Produce = modificarProduce,
                        ListaTelefonos = modificarListaTelefonos,
                        Mail = modificarMail,
                        User = modificarUser,
                        Pass = modificarPass,
                        CalleA = modificarCalleA,
                        CalleB = modificarCalleB,
                        NumeroPuerta = modificarNumeroPuerta,
                        Baja = modificarBaja
                    };
                    if (MessageBox.Show("Desea modificar los siguientes datos?:" + System.Environment.NewLine + System.Environment.NewLine +
                                        eNuevoProd.ToString() + System.Environment.NewLine +
                                        "Es productor: SI" + System.Environment.NewLine +
                                        "Es administrativo: NO",
                                        "Confirmación de modificación:",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes) // confirmo los cambios
                    {
                        if (modificarPass != "********" && !string.IsNullOrEmpty(modificarPass)) // si cambio el pass
                        {
                            eNuevoProd.Pass = EncriptarPass(txtModificarContrasenia.Text);
                        }
                        string resultadoMensaje = Logica.LUsuarios.LModificarProductor(eNuevoProd); // guardo los datos en la DB
                        Logica.LUsuarios.LEliminarRolAdministrativo(eNuevoProd.Ci);
                        MessageBox.Show(resultadoMensaje, "Información: ");
                    }
                    lblModificarError.Hide();
                }
                else if (esAdmin && esProd) // si tiene ambos roles
                {
                    EProductor eNuevoProdAdmin = new EProductor
                    {
                        Ci = modificarCi,
                        PrimerNombre = modificarPrimerNombre,
                        SegundoNombre = modificarSegundoNombre,
                        PrimerApellido = modificarPrimerApellido,
                        SegundoApellido = modificarSegundoApellido,
                        Rut = moficiarRut,
                        Produce = modificarProduce,
                        ListaTelefonos = modificarListaTelefonos,
                        Mail = modificarMail,
                        User = modificarUser,
                        Pass = modificarPass,
                        CalleA = modificarCalleA,
                        CalleB = modificarCalleB,
                        NumeroPuerta = modificarNumeroPuerta,
                        Baja = modificarBaja
                    };
                    if (txtModificarCargo.Text.Length < 4)
                    {
                        throw new Exception("Cargo no válido");
                    }
                    if (MessageBox.Show("Desea modificar los siguientes datos?:" + System.Environment.NewLine + System.Environment.NewLine +
                                        eNuevoProdAdmin.ToString() +
                                        "Cargo: " + modificarCargo + System.Environment.NewLine + System.Environment.NewLine +
                                        "Es productor: SI" + System.Environment.NewLine +
                                        "Es administrativo: SI",    
                                        "Desea modificar el usuario?",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes) // confirmo los cambios
                    {
                        if (modificarPass != "********" && !string.IsNullOrEmpty(modificarPass)) // si cambio el pass
                        {
                            eNuevoProdAdmin.Pass = EncriptarPass(txtModificarContrasenia.Text);
                        }
                        string resultadoMensaje = Logica.LUsuarios.LModificarAmbosRoles(eNuevoProdAdmin, txtModificarCargo.Text); // guardo los datos en la DB
                        MessageBox.Show(resultadoMensaje, "Información: ");
                    }
                    lblModificarError.Hide();
                }
                else // si no tiene nungun rol
                {
                    lblModificarError.Text = "Error, debe asignarle un Rol al usuario";
                    lblModificarError.Show();
                }
            }
            catch (Exception ex)
            {
                lblModificarError.Text = ex.Message;
                lblModificarError.Show();
            }
        }

        private void txtModificarEmail_Leave(object sender, EventArgs e)
        {
            if (!ValidarEmail(txtModificarEmail.Text))
            {
                lblModificarError.Text = "Dirección de correo no válida";
                lblModificarError.Show();
                txtModificarEmail.SelectAll();
                txtModificarEmail.Focus();
            }
            else
            {
                lblModificarError.Hide();
            }
        }

        private void txtModificarNomA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                lblModificarError.Text = "Solo se admiten letras";
                lblModificarError.Show();
            }
            if (e.Handled == false)
            {
                lblModificarError.Hide();
            }
        }

        private void txtModificarNomB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblModificarError.Text = "Solo se admiten letras";
                lblModificarError.Show();
            }
            if (e.Handled == false)
            {
                lblModificarError.Hide();
            }
        }

        private void txtModificarApeA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblModificarError.Text = "Solo se admiten letras";
                lblModificarError.Show();
            }
            if (e.Handled == false)
            {
                lblModificarError.Hide();
            }
        }

        private void txtModificarApeB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblModificarError.Text = "Solo se admiten letras";
                lblModificarError.Show();
            }
            if (e.Handled == false)
            {
                lblModificarError.Hide();
            }
        }

        private void txtModificarDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblModificarError.Text = "Solo se admiten letras";
                lblModificarError.Show();
            }
            if (e.Handled == false)
            {
                lblModificarError.Hide();
            }
        }

        private void txtModificarNroPuerta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblModificarError.Text = "Solo se admiten datos numéricos";
                lblModificarError.Show();
            }
            if (e.Handled == false)
            {
                lblModificarError.Hide();
            }
        }

        private void txtModificarEsquina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblModificarError.Text = "Solo se admiten letras";
                lblModificarError.Show();
            }
            if (e.Handled == false)
            {
                lblModificarError.Hide();
            }
        }

        private void txtModificarCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '+') && (!txtModificarCelular.Text.Contains("+")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                lblModificarError.Text = "Solo se admite numero telefónico";
                lblModificarError.Show();
            }
            if (e.Handled == false)
            {
                lblModificarError.Hide();
            }
        }

        private void txtModificarTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '+') && (!txtModificarCelular.Text.Contains("+")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                lblModificarError.Text = "Solo se admite numero telefónicos";
                lblModificarError.Show();
            }
            if (e.Handled == false)
            {
                lblModificarError.Hide();
            }
        }

        private void txtModificarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblModificarError.Text = "El usuario debe contener solo letras";
                lblModificarError.Show();
            }
            if (e.Handled == false)
            {
                lblModificarError.Hide();
            }
        }

        private void txtModificarContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblModificarError.Text = "Solo se admite contraseña de letras y núemros";
                lblModificarError.Show();
            }
            if (e.Handled == false)
            {
                lblModificarError.Hide();
            }
        }

        private void txtModificarCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblModificarError.Text = "El usuario debe contener solo letras";
                lblModificarError.Show();
            }
            if (e.Handled == false)
            {
                lblModificarError.Hide();
            }
        }

        private void txtModificarRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtModificarRut.Text.Length >= 12 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lblModificarError.Text = "Ya llegó al largo máximo de rut, 12 caracteres";
                lblModificarError.Show();
            }
            else
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    lblModificarError.Text = "Solo se admiten datos numéricos";
                    lblModificarError.Show();
                }
                if (e.Handled == false)
                {
                    lblModificarError.Hide();
                }
            }
        }

        private void chkModificarEsAdministrativo_Click(object sender, EventArgs e)
        {
            if (chkModificarEsAdministrativo.Checked == false)
            {
                MessageBox.Show("Si quita el rol Administrativo se eliminarán todos los Items y Eventos relacionados al mismo." + System.Environment.NewLine + "Si no sabe lo que hace no continúe." + System.Environment.NewLine + System.Environment.NewLine + "SE RECOMIENDA NO GUARDAR LOS CAMBIOS", "ALERTA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkModificarEsProductor_Click(object sender, EventArgs e)
        {
            if (chkModificarEsAdministrativo.Checked == false)
            {
                MessageBox.Show("Si quita el rol Productor se eliminarán todos los Predios, Sectores, Eventos y Productos relacionados a éste." + System.Environment.NewLine + "Si no sabe lo que hace no continúe." + System.Environment.NewLine + "SE RECOMIENDA NO GUARDAR LOS CAMBIOS", "ALERTA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*
         *      **********************************************
         *      *                 ALTA TAB                  *
         *      **********************************************
         */

        private void txtAltaCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) //Validacion solo numeros, backspace y enter
            {
                e.Handled = true;
            }
            if (txtAltaCedula.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAltaEmail_Leave(object sender, EventArgs e)
        {
            if (!ValidarEmail(txtAltaEmail.Text))
            {
                lblAltaError.Text = "Dirección de correo no válida";
                lblAltaError.Show();
                txtAltaEmail.SelectAll();
                txtAltaEmail.Focus();
            }
            else
            {
                lblAltaError.Hide();
            }
        }

        private void txtAltaPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                lblAltaError.Text = "Solo se admiten letras";
                lblAltaError.Show();
            }
            if (e.Handled == false)
            {
                lblAltaError.Hide();
            }
        }

        private void txtAltaSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblAltaError.Text = "Solo se admiten letras";
                lblAltaError.Show();
            }
            if (e.Handled == false)
            {
                lblAltaError.Hide();
            }
        }

        private void txtAltaPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblAltaError.Text = "Solo se admiten letras";
                lblAltaError.Show();
            }
            if (e.Handled == false)
            {
                lblAltaError.Hide();
            }
        }

        private void txtAltaSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblAltaError.Text = "Solo se admiten letras";
                lblAltaError.Show();
            }
            if (e.Handled == false)
            {
                lblAltaError.Hide();
            }
        }

        private void txtAltaCalleA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblAltaError.Text = "Solo se admiten letras";
                lblAltaError.Show();
            }
            if (e.Handled == false)
            {
                lblAltaError.Hide();
            }
        }

        private void txtAltaNroPuerta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblAltaError.Text = "Solo se admiten datos numéricos";
                lblAltaError.Show();
            }
            if (e.Handled == false)
            {
                lblAltaError.Hide();
            }
        }

        private void txtAltaEsquina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblAltaError.Text = "Solo se admiten letras";
                lblAltaError.Show();
            }
            if (e.Handled == false)
            {
                lblAltaError.Hide();
            }
        }

        private void txtAltaCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '+') && (!txtAltaCelular.Text.Contains("+")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                lblAltaError.Text = "Solo se admite numero telefónico";
                lblAltaError.Show();
            }
            if (e.Handled == false)
            {
                lblAltaError.Hide();
            }
        }

        private void txtAltaTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '+') && (!txtModificarTelefono.Text.Contains("+")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                lblAltaError.Text = "Solo se admite numero telefónicos";
                lblAltaError.Show();
            }
            if (e.Handled == false)
            {
                lblAltaError.Hide();
            }
        }

        private void txtAltaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblAltaError.Text = "El usuario debe contener solo letras";
                lblAltaError.Show();
            }
            if (e.Handled == false)
            {
                lblAltaError.Hide();
            }
        }

        private void txtAltaClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblAltaError.Text = "Solo se admite contraseña de letras y núemros";
                lblAltaError.Show();
            }
            if (e.Handled == false)
            {
                lblAltaError.Hide();
            }
        }

        private void txtAltaCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                lblAltaError.Text = "El usuario debe contener solo letras";
                lblAltaError.Show();
            }
            if (e.Handled == false)
            {
                lblAltaError.Hide();
            }
        }

        private void txtAltaRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAltaRut.Text.Length >= 12 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lblAltaError.Text = "Ya llegó al largo máximo de rut, 12 caracteres";
                lblAltaError.Show();
            }
            else
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    lblAltaError.Text = "Solo se admiten datos numéricos";
                    lblAltaError.Show();
                }
                if (e.Handled == false)
                {
                    lblAltaError.Hide();
                }
            }
        }

        private void btnAltaCrearUsuario_Click(object sender, EventArgs e)
        {
            string mensaje = "Usuario no creado: ";
            EProductor eUsuarioSinRol = new EProductor(); // Usuario sin rol (productor incompleto)
            EAdministrativo eAdministrativo = new EAdministrativo();
            EProductor eProductor = new EProductor();


            if (!string.IsNullOrEmpty(txtAltaCedula.Text)) 
            {
                if (!LConsultaExisteCi(txtAltaCedula.Text))
                {
                    if (!string.IsNullOrEmpty(txtAltaPrimerNombre.Text))
                    {
                        if (!string.IsNullOrEmpty(txtAltaPrimerApellido.Text) && !string.IsNullOrEmpty(txtAltaSegundoApellido.Text))
                        {
                            if (!string.IsNullOrEmpty(txtAltaEmail.Text))
                            {
                                List<string> validarTels = new List<string>();
                                if (!string.IsNullOrEmpty(txtAltaTelefono.Text))
                                {
                                    validarTels.Add(txtAltaTelefono.Text);
                                }
                                if (!string.IsNullOrEmpty(txtAltaCelular.Text))
                                {
                                    validarTels.Add(txtAltaCelular.Text);
                                }

                                if (validarTels.Count > 0)
                                {
                                    if (!string.IsNullOrEmpty(txtAltaUsuario.Text) && !string.IsNullOrEmpty(txtAltaClave.Text))
                                    {
                                        if (!LConsultaExisteUsuario(txtAltaUsuario.Text))
                                        {

                                            if ((!string.IsNullOrEmpty(txtAltaCalleA.Text) && !string.IsNullOrEmpty(txtAltaNroPuerta.Text)) || (string.IsNullOrEmpty(txtAltaCalleA.Text) && string.IsNullOrEmpty(txtAltaNroPuerta.Text) && string.IsNullOrEmpty(txtAltaEsquina.Text)))
                                            {
                                                if (chkAltaAdministrativo.Checked == true || chkAltaProductor.Checked == true)
                                                {
                                                    // CARGAR DATOS EN USUARIO GENERICO (productor incumpleto, "sin rol"):

                                                    eUsuarioSinRol.Ci = txtAltaCedula.Text;
                                                    eUsuarioSinRol.PrimerNombre = txtAltaPrimerNombre.Text;
                                                    eUsuarioSinRol.SegundoNombre = txtAltaSegundoNombre.Text;
                                                    eUsuarioSinRol.PrimerApellido = txtAltaPrimerApellido.Text;
                                                    eUsuarioSinRol.SegundoApellido = txtAltaSegundoApellido.Text;
                                                    eUsuarioSinRol.Mail = txtAltaEmail.Text;
                                                    if (!string.IsNullOrEmpty(txtAltaCalleA.Text))
                                                    {
                                                        eUsuarioSinRol.CalleA = txtAltaCalleA.Text;
                                                        eUsuarioSinRol.NumeroPuerta = txtAltaNroPuerta.Text;
                                                        if (!string.IsNullOrEmpty(txtAltaEsquina.Text))
                                                        {
                                                            eUsuarioSinRol.CalleB = txtAltaEsquina.Text;
                                                        }
                                                    }
                                                    if (!string.IsNullOrEmpty(txtAltaTelefono.Text) || !string.IsNullOrEmpty(txtAltaCelular.Text))
                                                    {
                                                        eUsuarioSinRol.ListaTelefonos = validarTels;
                                                    }
                                                    eUsuarioSinRol.User = txtAltaUsuario.Text;
                                                    eUsuarioSinRol.Pass = EncriptarPass(txtAltaClave.Text);
                                                    eUsuarioSinRol.Baja = false;


                                                    if (chkAltaAdministrativo.Checked == true)
                                                    {
                                                        if (!string.IsNullOrEmpty(txtAltaCargo.Text))
                                                        {
                                                            // CARGAR DATOS EN USUARIO ROL ADMINISTRATIVO:

                                                            eAdministrativo.Ci = txtAltaCedula.Text;
                                                            eAdministrativo.Cargo = txtAltaCargo.Text;
                                                        }
                                                        else
                                                        {
                                                            lblAltaError.Text = mensaje + "Debe ingresar cargo";
                                                            lblAltaError.Show();
                                                        }
                                                    }

                                                    if (chkAltaProductor.Checked == true)
                                                    {
                                                        if (cboAltaProduce.SelectedIndex != -1)
                                                        {
                                                            //CARGAR DATOS EN USUARIO ROL PRODUCTOR

                                                            eProductor.Ci = txtAltaCedula.Text;
                                                            eProductor.Produce = cboAltaProduce.Text;
                                                            if (string.IsNullOrEmpty(txtAltaRut.Text)) // rut opcional
                                                            {
                                                                eProductor.Rut = txtAltaRut.Text;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            lblAltaError.Text = mensaje + "Debe seleccionar un valor para produce";
                                                            lblAltaError.Show();
                                                        }
                                                    }

                                                    // REALIZAR ALTA A DB

                                                    if (!string.IsNullOrEmpty(eAdministrativo.Cargo) || !string.IsNullOrEmpty(eProductor.Produce))
                                                    {
                                                        try
                                                        {
                                                            // ALTA PRODUCTOR Y ADMINISTRATIVO
                                                            if (!string.IsNullOrEmpty(eAdministrativo.Cargo) && !string.IsNullOrEmpty(eProductor.Produce))
                                                            {
                                                                string msg1 = Logica.LUsuarios.LCrearUsuario(eUsuarioSinRol) + System.Environment.NewLine;
                                                                string msg2 = Logica.LUsuarios.LCrearAdministrativo(eAdministrativo) + System.Environment.NewLine;
                                                                string msg3 = Logica.LUsuarios.LCrearProductor(eProductor);
                                                                MessageBox.Show("Usuario: " + msg1 + "Administrativo: " + msg2 + "Productor: " + msg3);
                                                            }

                                                            // ALTA SOLO PRODUCTOR
                                                            if (string.IsNullOrEmpty(eAdministrativo.Cargo) && !string.IsNullOrEmpty(eProductor.Produce))
                                                            {
                                                                string msg1 = Logica.LUsuarios.LCrearUsuario(eUsuarioSinRol) + System.Environment.NewLine;
                                                                string msg2 = Logica.LUsuarios.LCrearProductor(eProductor);
                                                                MessageBox.Show("Usuario: " + msg1 + "Productor: " + msg2);
                                                            }

                                                            // ALTA SOLO ADMINISTRATIVO
                                                            if (string.IsNullOrEmpty(eProductor.Produce) && !string.IsNullOrEmpty(eAdministrativo.Cargo))
                                                            {
                                                                string msg1 = Logica.LUsuarios.LCrearUsuario(eUsuarioSinRol) + System.Environment.NewLine;
                                                                string msg2 = Logica.LUsuarios.LCrearAdministrativo(eAdministrativo);
                                                                MessageBox.Show("Usuario: " + msg1 + "Administrativo: " + msg2);
                                                            }
                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            MessageBox.Show(ex.Message);
                                                            System.Console.WriteLine(ex.Message);
                                                            lblAltaError.Text = "Error de base de datos, consulte al servicio técnico.";
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    lblAltaError.Text = mensaje + "Debe seleccionar un rol de usuario";
                                                    lblAltaError.Show();
                                                }
                                            }
                                            else
                                            {
                                                lblAltaError.Text = mensaje + "Si registra direccion debe ingresar calle y numero";
                                                lblAltaError.Show();
                                            }
                                        }
                                        else
                                        {
                                            lblAltaError.Text = mensaje + "El alias de usuario ya se encuentra registrado.";
                                            lblAltaError.Show();
                                        }
                                    }
                                    else
                                    {
                                        lblAltaError.Text = mensaje + "Debe ingresar usuario y contraseña";
                                        lblAltaError.Show();
                                    }
                                }
                                else
                                {
                                    lblAltaError.Text = mensaje + "Debe ingresar al menos un telefono";
                                    lblAltaError.Show();
                                }
                            }
                            else
                            {
                                lblAltaError.Text = mensaje + "Debe ingresar email";
                                lblAltaError.Show();
                            }
                        }
                        else
                        {
                            lblAltaError.Text = mensaje + "Debe ingresar ambos apellidos";
                            lblAltaError.Show();
                        }
                    }
                    else
                    {
                        lblAltaError.Text = mensaje + "Debe ingresar primer nombre";
                        lblAltaError.Show();
                    }
                }
                else
                {
                    lblAltaError.Text = mensaje + "La cedula ya se encuentra registrada";
                    lblAltaError.Show();
                }
            }
            else
            {
                lblAltaError.Text = mensaje + "Debe ingresar cedula";
                lblAltaError.Show();
            }
        }

        private void chkAltaAdministrativo_CheckedChanged(object sender, EventArgs e)
        {
            txtAltaCargo.Enabled = chkAltaAdministrativo.Checked;
            txtAltaCargo.Clear();
        }

        private void chkAltaProductor_CheckedChanged(object sender, EventArgs e)
        {
            txtAltaRut.Enabled = chkAltaProductor.Checked;
            txtAltaRut.Clear();
            cboAltaProduce.Enabled = chkAltaProductor.Checked;
            cboAltaProduce.SelectedIndex = -1;
        }


        /*
         *      **********************************************
         *      *                 BAJA TAB                   *
         *      **********************************************
         */

        private void txtBaja_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) //Validacion solo numeros, backspace y enter
            {
                e.Handled = true;
            }
            if (txtAltaCedula.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBaja_BajarUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBaja_Cedula.Text))
            {
                lblBajaError.Hide();
                if (LConsultaExisteCi(txtBaja_Cedula.Text))
                {
                    string msg = Logica.LUsuarios.LCancelarBajaCi(txtBaja_Cedula.Text);
                    MessageBox.Show(msg);
                }
                else
                {
                    lblBajaError.Text = "No se ha encontrado la cedula ingresada";
                    lblBajaError.Show();
                }
            }
            else
            {
                lblBajaError.Text = "Debe ingresar una cedula";
                lblBajaError.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBaja_Cedula.Text))
            {
                lblBajaError.Hide();
                if (LConsultaExisteCi(txtBaja_Cedula.Text))
                {
                    string msg = Logica.LUsuarios.LCancelarBajaCi(txtBaja_Cedula.Text);
                    MessageBox.Show(msg);
                }
                else
                {
                    lblBajaError.Text = "No se ha encontrado la cedula ingresada";
                    lblBajaError.Show();
                }
            }
            else
            {
                lblBajaError.Text = "Debe ingresar una cedula";
                lblBajaError.Show();
            }
        }
    }
}
