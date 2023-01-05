using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Logica.LSesion;

namespace Presentacion
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            lblNombreUsuario.Text = sesionUsuarioLogueado;
            lblNombreRol.Text = sesionRolLogueado;
            
            if (sesionRolLogueado == "Administrativo")
            {
                AbrirOpcionesMenu(new frmMenuAdmin());
                
            }
            if (sesionRolLogueado == "Productor")
            {
                AbrirOpcionesMenu(new frmMenuProd());
            }
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void lblCambiarCuenta_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void picHerramientas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Herramientas (PRÓXIMAMENTE) ");
        }

        public void AbrirOpcionesMenu(object formularioHijo) // Esto se utiliza para abrir los forms hijos en el Form Padre sin que se vea mal
        {
            if (this.pnlMostrarMenu.Controls.Count > 0) // pregunta si hay algun panel((Opciones del menu)) en el panel para mostrarlos.
                this.pnlMostrarMenu.Controls.RemoveAt(0); // en el caso de que haya algun panel abierto, este comando se encargara de eliminar el panel que ya no queremos.

            Form fh = formularioHijo as Form;
            fh.TopLevel = false; // Muestra la ventana en una jerarquía ´inferior´. | Es decir el PanelHijo tendra menos jerarquía que el panel padre.
            fh.Dock = DockStyle.Fill; // Ocupa todo el espacio del form creado en el panelMostrarOpciones.
            this.pnlMostrarMenu.Controls.Add(fh); // Añada el form {...} al Panel de mostrar las opciones.
            this.pnlMostrarMenu.Tag = fh; // Controla los datos del control.
            fh.Show();
        }
    }
}
