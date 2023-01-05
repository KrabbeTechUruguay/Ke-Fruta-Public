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
    public partial class frmLoginTipoUsuario : Form
    {

        public frmLoginTipoUsuario()
        {
            InitializeComponent();
            lblBienvenido.Text = "Bienvenido " + sesionUsuarioLogueado;
        }

        private void btnAdministrativo_Click(object sender, EventArgs e)
        {
            sesionRolLogueado = "Administrativo";
            Application.OpenForms["frmLogin"].Hide();
            this.Close();
            Form MenuPrincipal = new frmMenu();
            MenuPrincipal.Show();
        }

        private void btnProductor_Click(object sender, EventArgs e)
        {
            sesionRolLogueado = "Productor";
            Application.OpenForms["frmLogin"].Hide();
            this.Close();
            Form MenuPrincipal = new frmMenu();
            MenuPrincipal.Show();
        }

        private void frmLoginTipoUsuario_Load(object sender, EventArgs e)
        {
            btnAdministrativo.Focus();
        }
    }
}
