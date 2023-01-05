using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            AbrirOpcionesMenu(new frmMenuUserNotificaciones());
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            AbrirOpcionesMenu(new frmMenuAdminGestUsuario());
        }
        

        private void btnGestionPredios_Click(object sender, EventArgs e)
        {
            AbrirOpcionesMenu(new frmMenuAdminGestPredios());
        }

        private void btnGestionCalendario_Click(object sender, EventArgs e)
        {
            AbrirOpcionesMenu(new frmMenuAdminGestCalendario());

        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            AbrirOpcionesMenu(new frmMenuAdminGestProductos());
        }

        private void btnGestionInsumos_Click(object sender, EventArgs e)
        {
            AbrirOpcionesMenu(new frmMenuAdminGestInsumos());
        }

        public void AbrirOpcionesMenu(object formularioHijo) // Esto se utiliza para abrir los forms hijos en el Form Padre sin que se vea mal
        {
            if (this.pnlMostrarOpciones.Controls.Count > 0) // pregunta si hay algun panel((Opciones del menu)) en el panel para mostrarlos.
                this.pnlMostrarOpciones.Controls.RemoveAt(0); // en el caso de que haya algun panel abierto, este comando se encargara de eliminar el panel que ya no queremos.

            Form fh = formularioHijo as Form;
            fh.TopLevel = false; // Muestra la ventana en una jerarquía ´inferior´. | Es decir el PanelHijo tendra menos jerarquía que el panel padre.
            fh.Dock = DockStyle.Fill; // Ocupa todo el espacio del form creado en el panelMostrarOpciones.
            this.pnlMostrarOpciones.Controls.Add(fh); // Añada el form {...} al Panel de mostrar las opciones.
            this.pnlMostrarOpciones.Tag = fh; // Controla los datos del control.
            fh.Show();
        }

    }
}
