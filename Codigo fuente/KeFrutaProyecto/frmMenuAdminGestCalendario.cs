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
    public partial class frmMenuAdminGestCalendario : Form
    {
        public frmMenuAdminGestCalendario()
        {
            InitializeComponent();
            dtpConsultarFecha.Value = DateTime.Now;
        }

        private void btnConsultar_CargarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Logica.LCalendario.LConsultarEventosTodos();
                if (dt.Columns.Count > 0)
                {
                    gridEventos.DataSource = dt;
                    /*
                    gridEventos.Columns[0].HeaderCell.Value = "id";
                    gridEventos.Columns[1].HeaderCell.Value = "sector";
                    gridEventos.Columns[2].HeaderCell.Value = "predio";
                    gridEventos.Columns[3].HeaderCell.Value = "tipo";
                    gridEventos.Columns[4].HeaderCell.Value = "productor";
                    gridEventos.Columns[5].HeaderCell.Value = "inicio";
                    gridEventos.Columns[6].HeaderCell.Value = "fin";
                    gridEventos.Columns[7].HeaderCell.Value = "categoria";
                    gridEventos.Columns[8].HeaderCell.Value = "producto";
                    gridEventos.Columns[9].HeaderCell.Value = "producto";
                    gridEventos.Columns[10].HeaderCell.Value = "gestionado";
                    gridEventos.Columns[11].HeaderCell.Value = "estado";
                    gridEventos.Columns[12].HeaderCell.Value = "antecesor";
                    */
                }
                else
                {
                    lblConsultaError.Text = "No se encontraron eventos.";
                    lblConsultaError.Show();
                }
            }
            catch (Exception ex)
            {
                lblConsultaError.Text = ex.Message;
                lblConsultaError.Show();
            }
        }

        private void dtpConsultarFecha_ValueChanged(object sender, EventArgs e)
        {
            BuscarPorFecha();
        }

        private void btnConsultaBuscar_Click(object sender, EventArgs e)
        {
            BuscarPorFecha();
        }

        private void BuscarPorFecha()
        {
            try
            {
                string fecha = dtpConsultarFecha.Value.ToString("yyyy-MM-dd");
                DataTable dt = Logica.LCalendario.LConsultarEventosPorFecha(fecha);
                if (dt.Columns.Count > 0)
                {
                    gridEventos.DataSource = dt;
                }
                else
                {
                    lblConsultaError.Text = "No se encontraron eventos.";
                    lblConsultaError.Show();
                }
            }
            catch (Exception ex)
            {
                lblConsultaError.Text = ex.Message;
                lblConsultaError.Show();
            }
        }

        private void cboModificarCargarSectores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
