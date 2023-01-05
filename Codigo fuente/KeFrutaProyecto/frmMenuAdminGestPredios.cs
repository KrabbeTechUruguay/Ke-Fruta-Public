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
    public partial class frmMenuAdminGestPredios : Form
    {
        public frmMenuAdminGestPredios()
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
                DataTable dt = Logica.LPredios.LConsultarPredios();
                if (dt.Columns.Count > 0)
                {
                    gridPredios.DataSource = dt;
                }
                else
                {
                    lblConsultaError.Text = "No se encontraron predios.";
                    lblConsultaError.Show();
                }
            }
            catch (Exception ex)
            {
                lblConsultaError.Text = ex.Message;
                lblConsultaError.Show();
            }
        }

        private void btnConsultar_CargarOcupados_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Logica.LPredios.LConsultarPrediosOcupados();
                if (dt.Columns.Count > 0)
                {
                    gridPredios.DataSource = dt;
                }
                else
                {
                    lblConsultaError.Text = "No hay predios ocupados.";
                    lblConsultaError.Show();
                }
            }
            catch (Exception ex)
            {
                lblConsultaError.Text = ex.Message;
                lblConsultaError.Show();
            }
        }

        private void btnConsultar_CargarLibres_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Logica.LPredios.LConsultarPrediosLibres();
                if (dt.Columns.Count > 0)
                {
                    gridPredios.DataSource = dt;
                }
                else
                {
                    lblConsultaError.Text = "No hay predios libres.";
                    lblConsultaError.Show();
                }
            }
            catch (Exception ex)
            {
                lblConsultaError.Text = ex.Message;
                lblConsultaError.Show();
            }
        }

        private void btnConsultar_BuscarPorCi_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtConsultaBuscarCi.Text))
                {
                    string ci = txtConsultaBuscarCi.Text;
                    DataTable dt = Logica.LPredios.LConsultarPrediosPorCi(ci);
                    if (dt.Rows.Count > 0)
                    {
                        gridPredios.DataSource = dt;
                    }
                    else
                    {
                        lblConsultaError.Text = "No hay predios registrados para " + ci + ".";
                        lblConsultaError.Show();
                    }
                }
                else
                {
                    lblConsultaError.Text = "Debe ingresar una cedula.";
                    lblConsultaError.Show();
                }
            }
            catch (Exception ex)
            {
                lblConsultaError.Text = ex.Message;
                lblConsultaError.Show();
            }
        }

        private void txtConsultaBuscarCi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) //Validacion solo numeros, backspace y enter
            {
                e.Handled = true;
                lblConsultaError.Text = "Solo ingresar numeros en cedula";
                lblConsultaError.Show();
            }
            else
            {
                lblConsultaError.Hide();
            }
            if (txtConsultaBuscarCi.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)13 && txtConsultaBuscarCi.Text != "") // si presiona enter pasa al txtPwd
            {
                btnConsultar_BuscarPorCi_Click(sender, e);
            }
        }

        /*
         *      **********************************************
         *      *               MODIFICAR TAB                *
         *      **********************************************
         */

        public List<EPredio> listaPrediosCargados = new List<EPredio>();
        public List<ESector> listaSectoresCargados = new List<ESector>();

        private void btnModificarBuscarCi_Click(object sender, EventArgs e)
        {
            cboModificarCargarPredios.Items.Clear();
            cboModificarCargarSectores.Items.Clear();
            listaPrediosCargados.Clear();
            listaSectoresCargados.Clear();
            string buscarCi = txtModificarBuscarCedula.Text;
            string buscarId = txtModificarBuscarID.Text;

            try
            {
                if (string.IsNullOrEmpty(buscarCi) && !string.IsNullOrEmpty(buscarId))
                {
                    DataTable dtPredios = Logica.LPredios.LConsultarPrediosPorId(buscarId); // pido datos de predios
                    CargarPredios(dtPredios);
                }
                else
                {
                    if (buscarCi.Length > 5)
                    {
                        DataTable dtPredios = Logica.LPredios.LConsultarPrediosPorCi(buscarCi); // pido datos de predios
                        CargarPredios(dtPredios);
                    }
                    else
                    {
                        lblModificarError.Text = "Cedula no valida";
                    }
                }
            }
            catch (Exception ex)
            {
                lblModificarError.Text = ex.Message;
                lblModificarError.Show();
            }
        }

        public void CargarPredios(DataTable dtPredios)
        {
            if (dtPredios.Rows.Count > 0)
            {
                cboModificarCargarPredios.Enabled = true;
                btnModificarGuardarPredio.Enabled = true;
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

                    cboModificarCargarPredios.Items.Add(ePredio.Id.ToString() + " - " + ePredio.Nombre); // cargo la id en un combobox
                }
                cboModificarCargarPredios.SelectedIndex = 0;
                txtModificarBuscarCedula.Enabled = false;
                txtModificarBuscarID.Enabled = false;
                lblModificarError.Hide();
                CargarDatosPredio();
                CargarSectores();
            }
            else
            {
                lblModificarError.Text = "No se encontraron predios";
                lblModificarError.Show();
                grpModificarPredio.Enabled = false;
                grpModificarSector.Enabled = false;
            }
        }

        private void btnModificarLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control grp in tabModificar.Controls)
            {
                if (grp is GroupBox)
                {
                    foreach (Control ctrl in grp.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            ctrl.Text = String.Empty;
                        }
                        if (ctrl is ComboBox)
                        {
                            ctrl.Text = String.Empty;
                        }
                    }
                }
            }
            cboModificarCargarPredios.Items.Clear();
            cboModificarCargarSectores.Items.Clear();
            cboModificarCargarPredios.Enabled = false;
            cboModificarCargarSectores.Enabled = false;
            grpModificarPredio.Enabled = false;
            grpModificarSector.Enabled = false;
            txtModificarBuscarID.Enabled = true;
            txtModificarBuscarCedula.Enabled = true;
            txtModificarBuscarID.Clear();
            txtModificarBuscarCedula.Clear();
            listaPrediosCargados.Clear();
            listaSectoresCargados.Clear();
            txtModificarBuscarCedula.Focus();
        }

        private void txtModificarBuscarCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) //Validacion solo numeros, backspace y enter
            {
                e.Handled = true;
                lblModificarError.Text = "Solo ingresar numeros en cedula";
                lblModificarError.Show();
            }
            else
            {
                txtModificarBuscarID.Enabled = false;
                lblModificarError.Hide();
            }
            if (txtModificarBuscarCedula.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)13 && txtModificarBuscarCedula.Text != "") // si presiona enter
            {
                btnModificarBuscarCi_Click(sender, e);
            }
        }

        private void cboModificarCargarPredios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatosPredio();
                listaSectoresCargados.Clear();
                CargarSectores();
            }
            catch (Exception ex)
            {
                lblModificarError.Text = ex.Message;
                lblModificarError.Show();
            }
        }

        public void CargarDatosPredio()
        {
            grpModificarPredio.Enabled = true;

            //if (cboModificarCargarPredios.SelectedIndex != -1)
            if (cboModificarCargarPredios.Text != string.Empty)
            {
                int index = cboModificarCargarPredios.SelectedIndex;
                txtModificarPredioId.Text = listaPrediosCargados[index].Id.ToString();
                txtModificarPredioNombre.Text = listaPrediosCargados[index].Nombre;
                txtModificarPredioHectarea.Text = listaPrediosCargados[index].Hectareas.ToString();
                txtModificarPredioUbicacion.Text = listaPrediosCargados[index].Ubicacion;
                txtModificarPredioProductor.Text = listaPrediosCargados[index].Ci;
            }
        }

        public void CargarSectores()
        {
            cboModificarCargarSectores.Items.Clear();
            cboModificarCargarSectores.Enabled = true;
            grpModificarSector.Enabled = true;
            btnModificarGuardarSector.Enabled = true;

            string idPredio = listaPrediosCargados[cboModificarCargarPredios.SelectedIndex].Id.ToString();
            DataTable dtSectores = Logica.LPredios.LConsultarSectores(idPredio);

            if (dtSectores.Rows.Count > 0)
            {
                for (int row = 0; row < dtSectores.Rows.Count; row++) // por cada predio lo guardo en una lista
                {
                    ESector eSector = new ESector
                    {
                        Id = Convert.ToInt32(dtSectores.Rows[row][0].ToString()),
                        Id_predio = Convert.ToInt32(dtSectores.Rows[row][1].ToString()),
                        Ci_prod = dtSectores.Rows[row][2].ToString(),
                        Nombre = dtSectores.Rows[row][3].ToString(),
                        Hectareas = Convert.ToInt32(dtSectores.Rows[row][4].ToString()),
                        Ubicacion = dtSectores.Rows[row][5].ToString(),
                        Estado = dtSectores.Rows[row][6].ToString()
                    };

                    listaSectoresCargados.Add(eSector); // lo agregalo a la lista

                    cboModificarCargarSectores.Items.Add(eSector.Id.ToString() + " - " + eSector.Nombre); // cargo la id en un combobox
                }
                cboModificarCargarSectores.SelectedIndex = 0;
                txtModificarBuscarCedula.Enabled = false;
                txtModificarBuscarID.Enabled = false;
                lblModificarError.Hide();
                CargarDatosSector();
            }
            else
            {
                lblModificarError.Text = "No se encontraron sectores";
                lblModificarError.Show();
                cboModificarCargarSectores.Items.Clear();
                grpModificarSector.Enabled = false;
                cboModificarCargarSectores.Enabled = false;
            }
        }

        private void txtModificarBuscarID_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar == (char)13 && txtModificarBuscarCedula.Text != "") // si presiona enter
            {
                btnModificarBuscarCi_Click(sender, e);
            }
            if (e.Handled == false)
            {
                txtModificarBuscarCedula.Enabled = false;
                lblModificarError.Hide();
            }
        }

        private void cboModificarCargarSectores_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosSector();
        }

        public void CargarDatosSector()
        {
            if (cboModificarCargarSectores.Text != string.Empty)
            {
                grpModificarSector.Enabled = true;
                int index = cboModificarCargarSectores.SelectedIndex;
                txtModificarSectorId.Text = listaSectoresCargados[index].Id.ToString();
                txtModificarSectorNombre.Text = listaSectoresCargados[index].Nombre;
                txtModificarSectorHectarea.Text = listaSectoresCargados[index].Hectareas.ToString();
                txtModificarSectorUbicacion.Text = listaSectoresCargados[index].Ubicacion;
                if (listaSectoresCargados[index].Estado == "DISP")
                {
                    cboModificarSectorEstado.SelectedIndex = 0;
                    cboModificarSectorEstado.Text = "Disponible";
                }
                else if (listaSectoresCargados[index].Estado == "DESC")
                {
                    cboModificarSectorEstado.SelectedIndex = 1;
                    cboModificarSectorEstado.Text = "En descanso";
                }
                else // OCUP
                {
                    cboModificarSectorEstado.SelectedIndex = 2;
                    cboModificarSectorEstado.Text = "Ocupado";
                }

                btnModificarGuardarPredio.Enabled = true;
            }
        }

        private void btnModificarGuardarPredio_Click(object sender, EventArgs e)
        {
            string msg;
            EPredio ePredioModificado = new EPredio();
            try
            {
                ePredioModificado.Id = Convert.ToInt32(txtModificarPredioId.Text);
                ePredioModificado.Nombre = txtModificarPredioNombre.Text;
                ePredioModificado.Hectareas = Convert.ToInt32(txtModificarPredioHectarea.Text);
                ePredioModificado.Ubicacion = txtModificarPredioUbicacion.Text;
                ePredioModificado.Ci = txtModificarPredioProductor.Text;

                msg = Logica.LPredios.LModificarPredio(ePredioModificado);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            MessageBox.Show(msg);
        }

        private void btnModificarGuardarSector_Click(object sender, EventArgs e)
        {
            string msg;
            ESector eSectorModificado = new ESector();
            try
            {
                eSectorModificado.Id = Convert.ToInt32(txtModificarSectorId.Text);
                eSectorModificado.Nombre = txtModificarSectorNombre.Text;
                eSectorModificado.Hectareas = Convert.ToInt32(txtModificarSectorHectarea.Text);
                eSectorModificado.Ubicacion = txtModificarSectorUbicacion.Text;
                eSectorModificado.Ci_prod = txtModificarPredioProductor.Text;
                eSectorModificado.Estado = cboModificarSectorEstado.Text;
                eSectorModificado.Id_predio = Convert.ToInt32(txtModificarPredioId.Text);

                msg = Logica.LPredios.LModificarSector(eSectorModificado);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            MessageBox.Show(msg);
        }

        /*
         *      **********************************************
         *      *                 CREAR TAB                  *
         *      **********************************************
         */


        // validaciones
        private void txtCrearPredioHect_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) //Validacion solo numeros, backspace y enter
            {
                e.Handled = true;
                lblCrearError.Text = "Solo se admiten numeros";
                lblCrearError.Show();
            }
            else
            {
                e.Handled = false;
            }
            if (e.Handled == false)
            {
                lblCrearError.Hide();
            }
        }

        private void txtCrearPredioProdId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) //Validacion solo numeros, backspace y enter
            {
                e.Handled = true;
                lblCrearError.Text = "Productor solo acepta numero de cedula";
                lblCrearError.Show();
            }
            else
            {
                e.Handled = false;
            }
            if (e.Handled == false)
            {
                lblCrearError.Hide();
            }
        }

        private void txtCrearSectorHect_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) //Validacion solo numeros, backspace y enter
            {
                e.Handled = true;
                lblCrearError.Text = "Solo se admiten numeros";
                lblCrearError.Show();
            }
            else
            {
                e.Handled = false;
            }
            if (e.Handled == false)
            {
                lblCrearError.Hide();
            }
        }

        private void cboCrearSectorBuscarPredId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) //Validacion solo numeros, backspace y enter
            {
                e.Handled = true;
                lblCrearError.Text = "Solo se admiten numeros";
                lblCrearError.Show();
            }
            else
            {
                e.Handled = false;
            }
            if (e.Handled == false)
            {
                lblCrearError.Hide();
            }
        }
        private void txtCrearPredioNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                lblCrearError.Text = "Solo se admiten letras";
                lblCrearError.Show();
            }
            else
            {
                e.Handled = false;
            }
            if (e.Handled == false)
            {
                lblCrearError.Hide();
            }
        }

        private void txtCrearSectorNomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                lblCrearError.Text = "Solo se admiten letras";
                lblCrearError.Show();
            }
            else
            {
                e.Handled = false;
            }
            if (e.Handled == false)
            {
                lblCrearError.Hide();
            }
        }

        public List<EPredio> listaePredios = new List<EPredio>(); //aca se cargaran todos los predios

        //cargar datos iniciales
        private void frmMenuAdminGestPredios_Load(object sender, EventArgs e)
        {
            //cargar ultima id disponible
            try
            {
                ActualizarTxtIdPredio();
            }
            catch
            {
                lblCrearError.Show();
                lblCrearError.Text = "Problemas de base de datos, consulte con servicio técnico";
            }

            //cargar combobox predios
            CargarCboCrearSectorBuscarPredId();
        }
        private void CargarCboCrearSectorBuscarPredId() // carga el combobox con una lista de todos los predios
        {
            try
            {
                listaePredios.Clear(); // limpio la lista
                cboCrearSectorPredId.Items.Clear(); // limpio cbomboox
                DataTable dtPredios = Logica.LPredios.LConsultarPredios();
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

                    listaePredios.Add(ePredio); // lo agregalo a la lista

                    cboCrearSectorPredId.Items.Add(ePredio.Id.ToString() + " - " + ePredio.Nombre); // cargo la id en un combobox
                }
                cboCrearSectorPredId.SelectedIndex = -1;
            }
            catch
            {
                lblCrearError.Show();
                lblCrearError.Text = "Problemas de base de datos, consulte con servicio técnico";
            }
        }

        //CREAR PREDIO
        private void btnCrearPredio_Click(object sender, EventArgs e)
        {
            ActualizarTxtIdPredio();
            if (string.IsNullOrEmpty(txtCrearPredioNombre.Text))
            {
                lblCrearError.Show();
                lblCrearError.Text = "Crear predio: Debe ingresar nombre de predio";
            }
            else if(string.IsNullOrEmpty(txtCrearPredioHect.Text))
            {
                lblCrearError.Show();
                lblCrearError.Text = "Crear predio: Debe ingresar hectareas";
            }
            else if (!string.IsNullOrEmpty(txtCrearPredioProdId.Text))
            {
                if(Logica.LUsuarios.LConsultaExisteCi(txtCrearPredioProdId.Text))
                {
                    if (Logica.LUsuarios.LConsultaUsuarioEsBaja(txtCrearPredioProdId.Text))
                    {
                        lblCrearError.Show();
                        lblCrearError.Text = "El usuario ingresado se encuentra dado de baja";
                    }
                    else if (!Logica.LUsuarios.LConsultarExisteProductor(txtCrearPredioProdId.Text))
                    {
                        lblCrearError.Show();
                        lblCrearError.Text = "La cedula no se encuentra registrada como productor";
                    }
                    else
                    {
                        CrearPredio();
                        txtCrearPredioNombre.Text = string.Empty;
                        txtCrearPredioHect.Text = string.Empty;
                        txtCrearPredioUb.Text = string.Empty;
                        txtCrearPredioProdId.Text = string.Empty;
                    }
                }
                else
                {
                    lblCrearError.Show();
                    lblCrearError.Text = "La cedula no se encuentra registrada";
                }
            }
            else
            {
                CrearPredio();
            }
        }

        private void ActualizarTxtIdPredio()
        {
            string ultimaId = Logica.LPredios.LConsultarPrediosIdLibre();
            if (int.TryParse(ultimaId, out int idDisponible))
            {
                idDisponible++;
                txtCrearPredioId.Text = idDisponible.ToString();
            }
            else
            {
                lblCrearError.Show();
                lblCrearError.Text = string.Empty;
            }
        }

        public void CrearPredio()
        {
            Entidades.EPredio ePredio = new Entidades.EPredio
            {
                //ePredio.Id = txtCrearPredioId.Text; // no cargo el valor porque la DB ya lo genera, evito posibles conflictos
                Nombre = txtCrearPredioNombre.Text,
                Hectareas = Convert.ToInt32(txtCrearPredioHect.Text),
                Ubicacion = txtCrearPredioUb.Text,
                Ci = txtCrearPredioProdId.Text
            };
            string msg = Logica.LPredios.LCrearPredio(ePredio);
            MessageBox.Show(msg);
            lblCrearError.Hide();
            txtCrearPredioNombre.Text = string.Empty;
            txtCrearPredioHect.Text = string.Empty;
            txtCrearPredioUb.Text = string.Empty;
            txtCrearPredioProdId.Text = string.Empty;
            //actualizo txtIdPredio
            ActualizarTxtIdPredio();
            //actualizo combobox Predio
            CargarCboCrearSectorBuscarPredId();
        }

        //CREAR SECTOR
        readonly ESector eNuevoSector = new ESector();
        private void cboCrearSectorBuscarPredId_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCboNuevoSectorPredioyProd();
        }

        private void CargarCboNuevoSectorPredioyProd()
        {
            if (cboCrearSectorPredId.SelectedIndex != -1)
            {
                /*
                txtCrearSectorId.Text = sectorId.ToString();
                int indicePredioeleccionado = cboCrearSectorBuscarPredId.SelectedIndex;
                int idSectorDisponible = Logica.LPredios.LConsultarSectorUltimaIdLibre(eNuevoSector.Id_predio);
                //eNuevoSector.Id_predio = listaePredios[indicePredioeleccionado].Id; // guardo la id del predio seleccionado
                eNuevoSector.Id = idSectorDisponible;
                listaePredios[indicePredioeleccionado].Id = idSectorDisponible;
                string predioProductorId = listaePredios[indicePredioeleccionado].Ci;
                txtCrearSectorProdId.Text = predioProductorId; // muestro el productor asignado al predio seleccionado (en el combobox)
                */
                int predioId = listaePredios[cboCrearSectorPredId.SelectedIndex].Id;
                string prodCi = listaePredios[cboCrearSectorPredId.SelectedIndex].Ci;
                int sectorId = Logica.LPredios.LConsultarSectorUltimaIdLibre(predioId);
                if (predioId != -1)
                {
                    txtCrearSectorId.Text = sectorId.ToString(); // muestro la ultima id disponible para sectores del predio seleccionado
                    txtCrearSectorProdCi.Text = prodCi;
                }
                else
                {
                    lblCrearError.Text = "Error al obtener id de predio disponible para el sector seleccionado";
                    lblCrearError.Show();
                }
            }
            else
            {
                txtCrearPredioProdId.Text = String.Empty;
                txtCrearPredioId.Text = String.Empty;
            }
        }

        private void btnCrearSector_Click(object sender, EventArgs e)
        {
            // no necesita cedula, nombre, ubicacion
            eNuevoSector.Nombre = String.Empty;
            eNuevoSector.Ubicacion = String.Empty;
            if (!string.IsNullOrEmpty(txtCrearSectorId.Text))
            {
                if (!string.IsNullOrEmpty(txtCrearSectorHect.Text))
                {
                    if (!string.IsNullOrEmpty(cboCrearSectorEstado.Text))
                    {
                        eNuevoSector.Id_predio = listaePredios[cboCrearSectorPredId.SelectedIndex].Id;
                        eNuevoSector.Id = Convert.ToInt32(txtCrearSectorId.Text);
                        eNuevoSector.Ci_prod = txtCrearSectorProdCi.Text;
                        eNuevoSector.Nombre = txtCrearSectorNomb.Text;
                        eNuevoSector.Hectareas = Convert.ToInt32(txtCrearSectorHect.Text);
                        eNuevoSector.Ubicacion = txtCrearSectorUb.Text;
                        eNuevoSector.Estado = cboCrearSectorEstado.Text;
                        string msg = Logica.LPredios.LCrearSector(eNuevoSector);
                        MessageBox.Show(msg);
                        CrearLimpiarControles();
                        CargarCboNuevoSectorPredioyProd();
                        ActualizarTxtIdPredio();
                    }
                    else
                    {
                        lblCrearError.Text = "Debe seleccionar un estado para el sector";
                        lblCrearError.Show();
                    }
                }
                else
                {
                    lblCrearError.Text = "Debe ingresar las hectareas del sector";
                    lblCrearError.Show();
                }
            }
            else
            {
                lblCrearError.Text = "Debe seleccionar el predio al que pertenece el sector";
                lblCrearError.Show();
            }
        }

        private void CrearLimpiarControles()
        {
            foreach (Control grp in tabCrear.Controls)
            {
                if (grp is GroupBox)
                {
                    foreach (Control ctrl in grp.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            ctrl.Text = String.Empty;
                        }
                        if (ctrl is ComboBox)
                        {
                            ctrl.Text = String.Empty;
                        }
                    }
                }
            }
            cboCrearSectorEstado.SelectedIndex = 0;
            cboCrearSectorEstado.Text = string.Empty;
            cboCrearSectorPredId.SelectedIndex = 0;
            cboCrearSectorPredId.Text = string.Empty;
        }
    }
}