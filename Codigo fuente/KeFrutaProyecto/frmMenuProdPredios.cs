using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentacion
{
    public partial class frmMenuProdPredios : Form
    {
        string ciUsuarioLogueado = "";
        public List<EPredio> listaPrediosCargados = new List<EPredio>();
        public List<ESector> listaSectoresCargados = new List<ESector>();

        public frmMenuProdPredios()
        {
            InitializeComponent();
            try
            {
                Logica.LSesion.LCargarUsuarioLogueado();
                ciUsuarioLogueado = Logica.LSesion.sesionCiUsuarioLogueado;
            }
            catch (Exception ex)
            {
                lblConsultaError.Text = ex.Message;
                lblConsultaError.Show();
            }
            CargarPredios();
        }

        /*
         *      **********************************************
         *      *               CONSULTAR TAB                *
         *      **********************************************
         */

        public void CargarPredios()
        {
            DataTable dtPredios = new DataTable();
            try
            {
                dtPredios = Logica.LPredios.LConsultarPrediosPorCi(ciUsuarioLogueado);
            }
            catch (Exception ex)
            {
                lblConsultaError.Text = ex.Message;
                lblConsultaError.Show();
            }

            if (dtPredios.Rows.Count > 0)
            {
                for (int row = 0; row < dtPredios.Rows.Count; row++) // por cada predio lo guardo en una lista
                {
                    EPredio ePredio = new EPredio
                    {
                        Id = Convert.ToInt32(dtPredios.Rows[row][0].ToString()),
                        Ci = dtPredios.Rows[row][1].ToString(),
                        Nombre = dtPredios.Rows[row][2].ToString(),
                        Hectareas = Convert.ToInt32(dtPredios.Rows[row][3].ToString()),
                        Ubicacion = dtPredios.Rows[row][4].ToString()
                    };

                    listaPrediosCargados.Add(ePredio); // lo agregalo a la lista

                    cboConsultarPredios.Items.Add(ePredio.Id.ToString() + " - " + ePredio.Nombre + " - " + ePredio.Hectareas + " hectareas -  " + ePredio.Ubicacion); // cargo la id en un combobox
                    cboConsultarPredios.SelectedIndex = 0;
                    cboFertilizacionPredio.Items.Add(ePredio.Id.ToString() + " - " + ePredio.Nombre + " - " + ePredio.Hectareas + " hectareas -  " + ePredio.Ubicacion); // cargo la id en un combobox
                }
                cboFertilizacionPredio.SelectedIndex = 0;
                lblConsultaError.Hide();
            }
            else
            {
                lblConsultaError.Text = "No se encontraron predios";
                lblConsultaError.Show();
            }
        }
        private void CargarSectores()
        {
            string idPredio = listaPrediosCargados[cboConsultarPredios.SelectedIndex].Id.ToString();

            try
            {
                DataTable dt = Logica.LPredios.LConsultarSectores(idPredio);
                if (dt.Rows.Count > 0)
                {
                    gridSectores.DataSource = dt;
                }
                else
                {
                    lblConsultaError.Text = "No hay predios registrados para " + ciUsuarioLogueado + ".";
                    lblConsultaError.Show();
                }
            }
            catch (Exception ex)
            {
                lblConsultaError.Text = ex.Message;
                lblConsultaError.Show();
            }
        }

        private void cboConsultarPredios_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSectores();
        }

        /*
         *      **********************************************
         *      *             FERTILIZACION TAB              *
         *      **********************************************
         */

        private void cboFertilizacionPredio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSectoresF();
        }

        private void CargarSectoresF()
        {
            string idPredio = listaPrediosCargados[cboFertilizacionPredio.SelectedIndex].Id.ToString();

            try
            {
                DataTable dtPredios = Logica.LPredios.LConsultarSectores(idPredio);

                if (dtPredios.Rows.Count > 0)
                {
                    cboFertilizacionSector.Items.Clear();
                    for (int row = 0; row < dtPredios.Rows.Count; row++) // por cada predio lo guardo en una lista
                    {
                        ESector eSector = new ESector
                        {
                            Id = Convert.ToInt32(dtPredios.Rows[row][0].ToString()),
                            Id_predio = Convert.ToInt32(dtPredios.Rows[row][1].ToString()),
                            Ci_prod = dtPredios.Rows[row][2].ToString(),
                            Nombre = dtPredios.Rows[row][3].ToString(),
                            Hectareas = Convert.ToInt32(dtPredios.Rows[row][4].ToString()),
                            Ubicacion = dtPredios.Rows[row][5].ToString(),
                            Estado = dtPredios.Rows[row][6].ToString()
                        };
                        cboFertilizacionSector.Items.Add(eSector.Id.ToString() + " - " + eSector.Nombre + " - " + eSector.Hectareas + " hectareas -  " + eSector.Estado); // cargo la id en un combobox
                    }
                    lblConsultaError.Hide();
                    cboFertilizacionSector.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                lblConsultaError.Text = ex.Message;
                lblConsultaError.Show();
            }
        }
    }
}
