namespace Presentacion
{
    partial class frmMenuAdminGestCalendario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdminGestCalendario));
            this.btnCerrar = new System.Windows.Forms.Label();
            this.tabGestionCalendario = new System.Windows.Forms.TabControl();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.btnConsultaBuscar = new System.Windows.Forms.Button();
            this.lblConsultarPorFecha = new System.Windows.Forms.Label();
            this.dtpConsultarFecha = new System.Windows.Forms.DateTimePicker();
            this.lblConsultaError = new System.Windows.Forms.Label();
            this.btnConsultar_CargarTodos = new System.Windows.Forms.Button();
            this.gridEventos = new System.Windows.Forms.DataGridView();
            this.tabAlta = new System.Windows.Forms.TabPage();
            this.picCrear = new System.Windows.Forms.PictureBox();
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.cboAltaEstado = new System.Windows.Forms.ComboBox();
            this.lblAltaEstado = new System.Windows.Forms.Label();
            this.lblAltaTipo = new System.Windows.Forms.Label();
            this.txtAltaTipo = new System.Windows.Forms.TextBox();
            this.dtpAltaFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnAltaCrearEvento = new System.Windows.Forms.Button();
            this.lblAltaFechaFin = new System.Windows.Forms.Label();
            this.lblAltaFechaInicio = new System.Windows.Forms.Label();
            this.dtpAltaFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cboAltaEvento = new System.Windows.Forms.ComboBox();
            this.lblAltaTipoEvento = new System.Windows.Forms.Label();
            this.cboAltaProduceTipo = new System.Windows.Forms.ComboBox();
            this.lblProduce = new System.Windows.Forms.Label();
            this.cboAltaPredio = new System.Windows.Forms.ComboBox();
            this.lblAltaPredio = new System.Windows.Forms.Label();
            this.lblAltaCedula = new System.Windows.Forms.Label();
            this.cboAltaSector = new System.Windows.Forms.ComboBox();
            this.txtAltaCedula = new System.Windows.Forms.TextBox();
            this.lblAltaSector = new System.Windows.Forms.Label();
            this.txtAltaInfo = new System.Windows.Forms.TextBox();
            this.lblAltaInfo = new System.Windows.Forms.Label();
            this.lblAltaError = new System.Windows.Forms.Label();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.picModificar = new System.Windows.Forms.PictureBox();
            this.grpDatosEvento = new System.Windows.Forms.GroupBox();
            this.txtModificarIdAnterior = new System.Windows.Forms.TextBox();
            this.lblModificarAnterior = new System.Windows.Forms.Label();
            this.cboModificarEstadoEvento = new System.Windows.Forms.ComboBox();
            this.lblModificarEstado = new System.Windows.Forms.Label();
            this.lblModificarTipo = new System.Windows.Forms.Label();
            this.txtModificarTipoProductor = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnModificarEvento = new System.Windows.Forms.Button();
            this.lblModificarFFin = new System.Windows.Forms.Label();
            this.lblModificarFIni = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cboModificarTipoEvento = new System.Windows.Forms.ComboBox();
            this.lblModificarTipoEvento = new System.Windows.Forms.Label();
            this.cboModificarProduceCategoria = new System.Windows.Forms.ComboBox();
            this.lblModificarProduce = new System.Windows.Forms.Label();
            this.cboModificarPredio = new System.Windows.Forms.ComboBox();
            this.lblModificarPredio = new System.Windows.Forms.Label();
            this.lblModificarProductor = new System.Windows.Forms.Label();
            this.cboModificarSector = new System.Windows.Forms.ComboBox();
            this.txtModificarProductorCi = new System.Windows.Forms.TextBox();
            this.lblModificarSector = new System.Windows.Forms.Label();
            this.txtModificarInfo = new System.Windows.Forms.TextBox();
            this.lblModificarDescripcion = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTituloSoporte = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabGestionCalendario.SuspendLayout();
            this.tabConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEventos)).BeginInit();
            this.tabAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCrear)).BeginInit();
            this.grpDatosPersonales.SuspendLayout();
            this.tabModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).BeginInit();
            this.grpDatosEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(0, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 23);
            this.btnCerrar.TabIndex = 0;
            // 
            // tabGestionCalendario
            // 
            this.tabGestionCalendario.Controls.Add(this.tabConsultar);
            this.tabGestionCalendario.Controls.Add(this.tabAlta);
            this.tabGestionCalendario.Controls.Add(this.tabModificar);
            this.tabGestionCalendario.Location = new System.Drawing.Point(9, 58);
            this.tabGestionCalendario.Margin = new System.Windows.Forms.Padding(2);
            this.tabGestionCalendario.Name = "tabGestionCalendario";
            this.tabGestionCalendario.SelectedIndex = 0;
            this.tabGestionCalendario.Size = new System.Drawing.Size(773, 427);
            this.tabGestionCalendario.TabIndex = 5;
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.btnConsultaBuscar);
            this.tabConsultar.Controls.Add(this.lblConsultarPorFecha);
            this.tabConsultar.Controls.Add(this.dtpConsultarFecha);
            this.tabConsultar.Controls.Add(this.lblConsultaError);
            this.tabConsultar.Controls.Add(this.btnConsultar_CargarTodos);
            this.tabConsultar.Controls.Add(this.gridEventos);
            this.tabConsultar.Location = new System.Drawing.Point(4, 22);
            this.tabConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Padding = new System.Windows.Forms.Padding(2);
            this.tabConsultar.Size = new System.Drawing.Size(765, 401);
            this.tabConsultar.TabIndex = 3;
            this.tabConsultar.Text = "Consultar Eventos";
            this.tabConsultar.UseVisualStyleBackColor = true;
            // 
            // btnConsultaBuscar
            // 
            this.btnConsultaBuscar.Location = new System.Drawing.Point(691, 22);
            this.btnConsultaBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultaBuscar.Name = "btnConsultaBuscar";
            this.btnConsultaBuscar.Size = new System.Drawing.Size(56, 19);
            this.btnConsultaBuscar.TabIndex = 60;
            this.btnConsultaBuscar.Text = "Buscar";
            this.btnConsultaBuscar.UseVisualStyleBackColor = true;
            this.btnConsultaBuscar.Click += new System.EventHandler(this.btnConsultaBuscar_Click);
            // 
            // lblConsultarPorFecha
            // 
            this.lblConsultarPorFecha.AutoSize = true;
            this.lblConsultarPorFecha.Location = new System.Drawing.Point(447, 25);
            this.lblConsultarPorFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsultarPorFecha.Name = "lblConsultarPorFecha";
            this.lblConsultarPorFecha.Size = new System.Drawing.Size(142, 13);
            this.lblConsultarPorFecha.TabIndex = 59;
            this.lblConsultarPorFecha.Text = "Eventos activos en la fecha:";
            // 
            // dtpConsultarFecha
            // 
            this.dtpConsultarFecha.CustomFormat = "dd-MM-yyyy";
            this.dtpConsultarFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpConsultarFecha.Location = new System.Drawing.Point(592, 22);
            this.dtpConsultarFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpConsultarFecha.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpConsultarFecha.Name = "dtpConsultarFecha";
            this.dtpConsultarFecha.Size = new System.Drawing.Size(91, 20);
            this.dtpConsultarFecha.TabIndex = 58;
            this.dtpConsultarFecha.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            this.dtpConsultarFecha.ValueChanged += new System.EventHandler(this.dtpConsultarFecha_ValueChanged);
            // 
            // lblConsultaError
            // 
            this.lblConsultaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaError.ForeColor = System.Drawing.Color.Red;
            this.lblConsultaError.Location = new System.Drawing.Point(15, 366);
            this.lblConsultaError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsultaError.Name = "lblConsultaError";
            this.lblConsultaError.Size = new System.Drawing.Size(732, 19);
            this.lblConsultaError.TabIndex = 57;
            this.lblConsultaError.Text = "* Error al cargar eventos*";
            this.lblConsultaError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblConsultaError.Visible = false;
            // 
            // btnConsultar_CargarTodos
            // 
            this.btnConsultar_CargarTodos.Location = new System.Drawing.Point(18, 17);
            this.btnConsultar_CargarTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar_CargarTodos.Name = "btnConsultar_CargarTodos";
            this.btnConsultar_CargarTodos.Size = new System.Drawing.Size(121, 28);
            this.btnConsultar_CargarTodos.TabIndex = 6;
            this.btnConsultar_CargarTodos.Text = "Historico de eventos";
            this.btnConsultar_CargarTodos.UseVisualStyleBackColor = true;
            this.btnConsultar_CargarTodos.Click += new System.EventHandler(this.btnConsultar_CargarTodos_Click);
            // 
            // gridEventos
            // 
            this.gridEventos.AllowUserToAddRows = false;
            this.gridEventos.AllowUserToDeleteRows = false;
            this.gridEventos.AllowUserToOrderColumns = true;
            this.gridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEventos.Location = new System.Drawing.Point(18, 60);
            this.gridEventos.Margin = new System.Windows.Forms.Padding(2);
            this.gridEventos.Name = "gridEventos";
            this.gridEventos.ReadOnly = true;
            this.gridEventos.RowHeadersWidth = 51;
            this.gridEventos.RowTemplate.Height = 24;
            this.gridEventos.Size = new System.Drawing.Size(729, 292);
            this.gridEventos.TabIndex = 5;
            // 
            // tabAlta
            // 
            this.tabAlta.Controls.Add(this.picCrear);
            this.tabAlta.Controls.Add(this.grpDatosPersonales);
            this.tabAlta.Controls.Add(this.lblAltaError);
            this.tabAlta.Location = new System.Drawing.Point(4, 22);
            this.tabAlta.Margin = new System.Windows.Forms.Padding(2);
            this.tabAlta.Name = "tabAlta";
            this.tabAlta.Padding = new System.Windows.Forms.Padding(2);
            this.tabAlta.Size = new System.Drawing.Size(765, 401);
            this.tabAlta.TabIndex = 0;
            this.tabAlta.Text = "Crear Evento";
            this.tabAlta.UseVisualStyleBackColor = true;
            // 
            // picCrear
            // 
            this.picCrear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCrear.BackgroundImage")));
            this.picCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCrear.Location = new System.Drawing.Point(614, 19);
            this.picCrear.Margin = new System.Windows.Forms.Padding(2);
            this.picCrear.Name = "picCrear";
            this.picCrear.Size = new System.Drawing.Size(138, 327);
            this.picCrear.TabIndex = 34;
            this.picCrear.TabStop = false;
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.textBox1);
            this.grpDatosPersonales.Controls.Add(this.label1);
            this.grpDatosPersonales.Controls.Add(this.cboAltaEstado);
            this.grpDatosPersonales.Controls.Add(this.lblAltaEstado);
            this.grpDatosPersonales.Controls.Add(this.lblAltaTipo);
            this.grpDatosPersonales.Controls.Add(this.txtAltaTipo);
            this.grpDatosPersonales.Controls.Add(this.dtpAltaFechaFin);
            this.grpDatosPersonales.Controls.Add(this.btnAltaCrearEvento);
            this.grpDatosPersonales.Controls.Add(this.lblAltaFechaFin);
            this.grpDatosPersonales.Controls.Add(this.lblAltaFechaInicio);
            this.grpDatosPersonales.Controls.Add(this.dtpAltaFechaInicio);
            this.grpDatosPersonales.Controls.Add(this.cboAltaEvento);
            this.grpDatosPersonales.Controls.Add(this.lblAltaTipoEvento);
            this.grpDatosPersonales.Controls.Add(this.cboAltaProduceTipo);
            this.grpDatosPersonales.Controls.Add(this.lblProduce);
            this.grpDatosPersonales.Controls.Add(this.cboAltaPredio);
            this.grpDatosPersonales.Controls.Add(this.lblAltaPredio);
            this.grpDatosPersonales.Controls.Add(this.lblAltaCedula);
            this.grpDatosPersonales.Controls.Add(this.cboAltaSector);
            this.grpDatosPersonales.Controls.Add(this.txtAltaCedula);
            this.grpDatosPersonales.Controls.Add(this.lblAltaSector);
            this.grpDatosPersonales.Controls.Add(this.txtAltaInfo);
            this.grpDatosPersonales.Controls.Add(this.lblAltaInfo);
            this.grpDatosPersonales.Location = new System.Drawing.Point(14, 15);
            this.grpDatosPersonales.Margin = new System.Windows.Forms.Padding(2);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Padding = new System.Windows.Forms.Padding(2);
            this.grpDatosPersonales.Size = new System.Drawing.Size(595, 331);
            this.grpDatosPersonales.TabIndex = 28;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos de evento";
            // 
            // cboAltaEstado
            // 
            this.cboAltaEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAltaEstado.Enabled = false;
            this.cboAltaEstado.FormattingEnabled = true;
            this.cboAltaEstado.Location = new System.Drawing.Point(387, 141);
            this.cboAltaEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cboAltaEstado.Name = "cboAltaEstado";
            this.cboAltaEstado.Size = new System.Drawing.Size(192, 21);
            this.cboAltaEstado.TabIndex = 67;
            // 
            // lblAltaEstado
            // 
            this.lblAltaEstado.AutoSize = true;
            this.lblAltaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaEstado.Location = new System.Drawing.Point(332, 144);
            this.lblAltaEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltaEstado.Name = "lblAltaEstado";
            this.lblAltaEstado.Size = new System.Drawing.Size(51, 15);
            this.lblAltaEstado.TabIndex = 66;
            this.lblAltaEstado.Text = "Estado: ";
            // 
            // lblAltaTipo
            // 
            this.lblAltaTipo.AutoSize = true;
            this.lblAltaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaTipo.Location = new System.Drawing.Point(47, 53);
            this.lblAltaTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltaTipo.Name = "lblAltaTipo";
            this.lblAltaTipo.Size = new System.Drawing.Size(37, 15);
            this.lblAltaTipo.TabIndex = 65;
            this.lblAltaTipo.Text = "Tipo: ";
            // 
            // txtAltaTipo
            // 
            this.txtAltaTipo.Location = new System.Drawing.Point(88, 51);
            this.txtAltaTipo.Margin = new System.Windows.Forms.Padding(2);
            this.txtAltaTipo.MaxLength = 8;
            this.txtAltaTipo.Name = "txtAltaTipo";
            this.txtAltaTipo.Size = new System.Drawing.Size(192, 20);
            this.txtAltaTipo.TabIndex = 64;
            // 
            // dtpAltaFechaFin
            // 
            this.dtpAltaFechaFin.CustomFormat = "dd-MM-yyyy";
            this.dtpAltaFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAltaFechaFin.Location = new System.Drawing.Point(484, 85);
            this.dtpAltaFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpAltaFechaFin.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpAltaFechaFin.Name = "dtpAltaFechaFin";
            this.dtpAltaFechaFin.Size = new System.Drawing.Size(95, 20);
            this.dtpAltaFechaFin.TabIndex = 63;
            this.dtpAltaFechaFin.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // btnAltaCrearEvento
            // 
            this.btnAltaCrearEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCrearEvento.Location = new System.Drawing.Point(365, 291);
            this.btnAltaCrearEvento.Margin = new System.Windows.Forms.Padding(2);
            this.btnAltaCrearEvento.Name = "btnAltaCrearEvento";
            this.btnAltaCrearEvento.Size = new System.Drawing.Size(225, 34);
            this.btnAltaCrearEvento.TabIndex = 18;
            this.btnAltaCrearEvento.Text = "Crear Evento";
            this.btnAltaCrearEvento.UseVisualStyleBackColor = true;
            // 
            // lblAltaFechaFin
            // 
            this.lblAltaFechaFin.AutoSize = true;
            this.lblAltaFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaFechaFin.Location = new System.Drawing.Point(384, 86);
            this.lblAltaFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltaFechaFin.Name = "lblAltaFechaFin";
            this.lblAltaFechaFin.Size = new System.Drawing.Size(77, 15);
            this.lblAltaFechaFin.TabIndex = 62;
            this.lblAltaFechaFin.Text = "Fecha de fin:";
            // 
            // lblAltaFechaInicio
            // 
            this.lblAltaFechaInicio.AutoSize = true;
            this.lblAltaFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaFechaInicio.Location = new System.Drawing.Point(384, 63);
            this.lblAltaFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltaFechaInicio.Name = "lblAltaFechaInicio";
            this.lblAltaFechaInicio.Size = new System.Drawing.Size(93, 15);
            this.lblAltaFechaInicio.TabIndex = 61;
            this.lblAltaFechaInicio.Text = "Fecha de inicio:";
            // 
            // dtpAltaFechaInicio
            // 
            this.dtpAltaFechaInicio.CustomFormat = "dd-MM-yyyy";
            this.dtpAltaFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAltaFechaInicio.Location = new System.Drawing.Point(484, 61);
            this.dtpAltaFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpAltaFechaInicio.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpAltaFechaInicio.Name = "dtpAltaFechaInicio";
            this.dtpAltaFechaInicio.Size = new System.Drawing.Size(95, 20);
            this.dtpAltaFechaInicio.TabIndex = 60;
            this.dtpAltaFechaInicio.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // cboAltaEvento
            // 
            this.cboAltaEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAltaEvento.Enabled = false;
            this.cboAltaEvento.FormattingEnabled = true;
            this.cboAltaEvento.Location = new System.Drawing.Point(387, 27);
            this.cboAltaEvento.Margin = new System.Windows.Forms.Padding(2);
            this.cboAltaEvento.Name = "cboAltaEvento";
            this.cboAltaEvento.Size = new System.Drawing.Size(192, 21);
            this.cboAltaEvento.TabIndex = 40;
            // 
            // lblAltaTipoEvento
            // 
            this.lblAltaTipoEvento.AutoSize = true;
            this.lblAltaTipoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaTipoEvento.Location = new System.Drawing.Point(293, 30);
            this.lblAltaTipoEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltaTipoEvento.Name = "lblAltaTipoEvento";
            this.lblAltaTipoEvento.Size = new System.Drawing.Size(90, 15);
            this.lblAltaTipoEvento.TabIndex = 39;
            this.lblAltaTipoEvento.Text = "Tipo de evento:";
            // 
            // cboAltaProduceTipo
            // 
            this.cboAltaProduceTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAltaProduceTipo.Enabled = false;
            this.cboAltaProduceTipo.FormattingEnabled = true;
            this.cboAltaProduceTipo.Items.AddRange(new object[] {
            "Cereal",
            "Fruta",
            "Verdura"});
            this.cboAltaProduceTipo.Location = new System.Drawing.Point(88, 74);
            this.cboAltaProduceTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cboAltaProduceTipo.Name = "cboAltaProduceTipo";
            this.cboAltaProduceTipo.Size = new System.Drawing.Size(192, 21);
            this.cboAltaProduceTipo.TabIndex = 35;
            // 
            // lblProduce
            // 
            this.lblProduce.AutoSize = true;
            this.lblProduce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduce.Location = new System.Drawing.Point(25, 77);
            this.lblProduce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduce.Name = "lblProduce";
            this.lblProduce.Size = new System.Drawing.Size(59, 15);
            this.lblProduce.TabIndex = 36;
            this.lblProduce.Text = "Produce: ";
            // 
            // cboAltaPredio
            // 
            this.cboAltaPredio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAltaPredio.Enabled = false;
            this.cboAltaPredio.FormattingEnabled = true;
            this.cboAltaPredio.Location = new System.Drawing.Point(88, 116);
            this.cboAltaPredio.Margin = new System.Windows.Forms.Padding(2);
            this.cboAltaPredio.Name = "cboAltaPredio";
            this.cboAltaPredio.Size = new System.Drawing.Size(192, 21);
            this.cboAltaPredio.TabIndex = 36;
            // 
            // lblAltaPredio
            // 
            this.lblAltaPredio.AutoSize = true;
            this.lblAltaPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaPredio.Location = new System.Drawing.Point(35, 119);
            this.lblAltaPredio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltaPredio.Name = "lblAltaPredio";
            this.lblAltaPredio.Size = new System.Drawing.Size(49, 15);
            this.lblAltaPredio.TabIndex = 35;
            this.lblAltaPredio.Text = "Predio: ";
            // 
            // lblAltaCedula
            // 
            this.lblAltaCedula.AutoSize = true;
            this.lblAltaCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaCedula.Location = new System.Drawing.Point(18, 30);
            this.lblAltaCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltaCedula.Name = "lblAltaCedula";
            this.lblAltaCedula.Size = new System.Drawing.Size(66, 15);
            this.lblAltaCedula.TabIndex = 0;
            this.lblAltaCedula.Text = "Productor: ";
            // 
            // cboAltaSector
            // 
            this.cboAltaSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAltaSector.Enabled = false;
            this.cboAltaSector.FormattingEnabled = true;
            this.cboAltaSector.Location = new System.Drawing.Point(88, 141);
            this.cboAltaSector.Margin = new System.Windows.Forms.Padding(2);
            this.cboAltaSector.Name = "cboAltaSector";
            this.cboAltaSector.Size = new System.Drawing.Size(192, 21);
            this.cboAltaSector.TabIndex = 38;
            // 
            // txtAltaCedula
            // 
            this.txtAltaCedula.Location = new System.Drawing.Point(88, 28);
            this.txtAltaCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtAltaCedula.MaxLength = 8;
            this.txtAltaCedula.Name = "txtAltaCedula";
            this.txtAltaCedula.Size = new System.Drawing.Size(192, 20);
            this.txtAltaCedula.TabIndex = 0;
            // 
            // lblAltaSector
            // 
            this.lblAltaSector.AutoSize = true;
            this.lblAltaSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaSector.Location = new System.Drawing.Point(36, 144);
            this.lblAltaSector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltaSector.Name = "lblAltaSector";
            this.lblAltaSector.Size = new System.Drawing.Size(48, 15);
            this.lblAltaSector.TabIndex = 37;
            this.lblAltaSector.Text = "Sector: ";
            // 
            // txtAltaInfo
            // 
            this.txtAltaInfo.Location = new System.Drawing.Point(387, 117);
            this.txtAltaInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtAltaInfo.MaxLength = 35;
            this.txtAltaInfo.Name = "txtAltaInfo";
            this.txtAltaInfo.Size = new System.Drawing.Size(192, 20);
            this.txtAltaInfo.TabIndex = 5;
            // 
            // lblAltaInfo
            // 
            this.lblAltaInfo.AutoSize = true;
            this.lblAltaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaInfo.Location = new System.Drawing.Point(308, 119);
            this.lblAltaInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltaInfo.Name = "lblAltaInfo";
            this.lblAltaInfo.Size = new System.Drawing.Size(75, 15);
            this.lblAltaInfo.TabIndex = 16;
            this.lblAltaInfo.Text = "Descripción:";
            // 
            // lblAltaError
            // 
            this.lblAltaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaError.ForeColor = System.Drawing.Color.Red;
            this.lblAltaError.Location = new System.Drawing.Point(14, 367);
            this.lblAltaError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltaError.Name = "lblAltaError";
            this.lblAltaError.Size = new System.Drawing.Size(735, 19);
            this.lblAltaError.TabIndex = 25;
            this.lblAltaError.Text = "* Error al crear evento *";
            this.lblAltaError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAltaError.Visible = false;
            // 
            // tabModificar
            // 
            this.tabModificar.Controls.Add(this.picModificar);
            this.tabModificar.Controls.Add(this.grpDatosEvento);
            this.tabModificar.Controls.Add(this.label11);
            this.tabModificar.Location = new System.Drawing.Point(4, 22);
            this.tabModificar.Margin = new System.Windows.Forms.Padding(2);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Padding = new System.Windows.Forms.Padding(2);
            this.tabModificar.Size = new System.Drawing.Size(765, 401);
            this.tabModificar.TabIndex = 1;
            this.tabModificar.Text = "Modificar Evento";
            this.tabModificar.UseVisualStyleBackColor = true;
            // 
            // picModificar
            // 
            this.picModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picModificar.BackgroundImage")));
            this.picModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picModificar.Location = new System.Drawing.Point(614, 19);
            this.picModificar.Margin = new System.Windows.Forms.Padding(2);
            this.picModificar.Name = "picModificar";
            this.picModificar.Size = new System.Drawing.Size(138, 327);
            this.picModificar.TabIndex = 37;
            this.picModificar.TabStop = false;
            // 
            // grpDatosEvento
            // 
            this.grpDatosEvento.Controls.Add(this.txtModificarIdAnterior);
            this.grpDatosEvento.Controls.Add(this.lblModificarAnterior);
            this.grpDatosEvento.Controls.Add(this.cboModificarEstadoEvento);
            this.grpDatosEvento.Controls.Add(this.lblModificarEstado);
            this.grpDatosEvento.Controls.Add(this.lblModificarTipo);
            this.grpDatosEvento.Controls.Add(this.txtModificarTipoProductor);
            this.grpDatosEvento.Controls.Add(this.dateTimePicker1);
            this.grpDatosEvento.Controls.Add(this.btnModificarEvento);
            this.grpDatosEvento.Controls.Add(this.lblModificarFFin);
            this.grpDatosEvento.Controls.Add(this.lblModificarFIni);
            this.grpDatosEvento.Controls.Add(this.dateTimePicker2);
            this.grpDatosEvento.Controls.Add(this.cboModificarTipoEvento);
            this.grpDatosEvento.Controls.Add(this.lblModificarTipoEvento);
            this.grpDatosEvento.Controls.Add(this.cboModificarProduceCategoria);
            this.grpDatosEvento.Controls.Add(this.lblModificarProduce);
            this.grpDatosEvento.Controls.Add(this.cboModificarPredio);
            this.grpDatosEvento.Controls.Add(this.lblModificarPredio);
            this.grpDatosEvento.Controls.Add(this.lblModificarProductor);
            this.grpDatosEvento.Controls.Add(this.cboModificarSector);
            this.grpDatosEvento.Controls.Add(this.txtModificarProductorCi);
            this.grpDatosEvento.Controls.Add(this.lblModificarSector);
            this.grpDatosEvento.Controls.Add(this.txtModificarInfo);
            this.grpDatosEvento.Controls.Add(this.lblModificarDescripcion);
            this.grpDatosEvento.Location = new System.Drawing.Point(14, 81);
            this.grpDatosEvento.Margin = new System.Windows.Forms.Padding(2);
            this.grpDatosEvento.Name = "grpDatosEvento";
            this.grpDatosEvento.Padding = new System.Windows.Forms.Padding(2);
            this.grpDatosEvento.Size = new System.Drawing.Size(595, 265);
            this.grpDatosEvento.TabIndex = 36;
            this.grpDatosEvento.TabStop = false;
            this.grpDatosEvento.Text = "Datos de evento";
            // 
            // txtModificarIdAnterior
            // 
            this.txtModificarIdAnterior.Location = new System.Drawing.Point(387, 186);
            this.txtModificarIdAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.txtModificarIdAnterior.MaxLength = 35;
            this.txtModificarIdAnterior.Name = "txtModificarIdAnterior";
            this.txtModificarIdAnterior.Size = new System.Drawing.Size(192, 20);
            this.txtModificarIdAnterior.TabIndex = 68;
            // 
            // lblModificarAnterior
            // 
            this.lblModificarAnterior.AutoSize = true;
            this.lblModificarAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarAnterior.Location = new System.Drawing.Point(293, 184);
            this.lblModificarAnterior.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarAnterior.Name = "lblModificarAnterior";
            this.lblModificarAnterior.Size = new System.Drawing.Size(92, 15);
            this.lblModificarAnterior.TabIndex = 69;
            this.lblModificarAnterior.Text = "Evento anterior:";
            // 
            // cboModificarEstadoEvento
            // 
            this.cboModificarEstadoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModificarEstadoEvento.Enabled = false;
            this.cboModificarEstadoEvento.FormattingEnabled = true;
            this.cboModificarEstadoEvento.Location = new System.Drawing.Point(387, 141);
            this.cboModificarEstadoEvento.Margin = new System.Windows.Forms.Padding(2);
            this.cboModificarEstadoEvento.Name = "cboModificarEstadoEvento";
            this.cboModificarEstadoEvento.Size = new System.Drawing.Size(192, 21);
            this.cboModificarEstadoEvento.TabIndex = 67;
            // 
            // lblModificarEstado
            // 
            this.lblModificarEstado.AutoSize = true;
            this.lblModificarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarEstado.Location = new System.Drawing.Point(332, 144);
            this.lblModificarEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarEstado.Name = "lblModificarEstado";
            this.lblModificarEstado.Size = new System.Drawing.Size(51, 15);
            this.lblModificarEstado.TabIndex = 66;
            this.lblModificarEstado.Text = "Estado: ";
            // 
            // lblModificarTipo
            // 
            this.lblModificarTipo.AutoSize = true;
            this.lblModificarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarTipo.Location = new System.Drawing.Point(47, 53);
            this.lblModificarTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarTipo.Name = "lblModificarTipo";
            this.lblModificarTipo.Size = new System.Drawing.Size(37, 15);
            this.lblModificarTipo.TabIndex = 65;
            this.lblModificarTipo.Text = "Tipo: ";
            // 
            // txtModificarTipoProductor
            // 
            this.txtModificarTipoProductor.Location = new System.Drawing.Point(88, 51);
            this.txtModificarTipoProductor.Margin = new System.Windows.Forms.Padding(2);
            this.txtModificarTipoProductor.MaxLength = 8;
            this.txtModificarTipoProductor.Name = "txtModificarTipoProductor";
            this.txtModificarTipoProductor.Size = new System.Drawing.Size(192, 20);
            this.txtModificarTipoProductor.TabIndex = 64;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(484, 85);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 63;
            this.dateTimePicker1.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // btnModificarEvento
            // 
            this.btnModificarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEvento.Location = new System.Drawing.Point(365, 223);
            this.btnModificarEvento.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarEvento.Name = "btnModificarEvento";
            this.btnModificarEvento.Size = new System.Drawing.Size(225, 34);
            this.btnModificarEvento.TabIndex = 18;
            this.btnModificarEvento.Text = "Modificar Evento";
            this.btnModificarEvento.UseVisualStyleBackColor = true;
            // 
            // lblModificarFFin
            // 
            this.lblModificarFFin.AutoSize = true;
            this.lblModificarFFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarFFin.Location = new System.Drawing.Point(384, 86);
            this.lblModificarFFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarFFin.Name = "lblModificarFFin";
            this.lblModificarFFin.Size = new System.Drawing.Size(77, 15);
            this.lblModificarFFin.TabIndex = 62;
            this.lblModificarFFin.Text = "Fecha de fin:";
            // 
            // lblModificarFIni
            // 
            this.lblModificarFIni.AutoSize = true;
            this.lblModificarFIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarFIni.Location = new System.Drawing.Point(384, 63);
            this.lblModificarFIni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarFIni.Name = "lblModificarFIni";
            this.lblModificarFIni.Size = new System.Drawing.Size(93, 15);
            this.lblModificarFIni.TabIndex = 61;
            this.lblModificarFIni.Text = "Fecha de inicio:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(484, 61);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker2.TabIndex = 60;
            this.dateTimePicker2.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // cboModificarTipoEvento
            // 
            this.cboModificarTipoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModificarTipoEvento.Enabled = false;
            this.cboModificarTipoEvento.FormattingEnabled = true;
            this.cboModificarTipoEvento.Location = new System.Drawing.Point(387, 27);
            this.cboModificarTipoEvento.Margin = new System.Windows.Forms.Padding(2);
            this.cboModificarTipoEvento.Name = "cboModificarTipoEvento";
            this.cboModificarTipoEvento.Size = new System.Drawing.Size(192, 21);
            this.cboModificarTipoEvento.TabIndex = 40;
            // 
            // lblModificarTipoEvento
            // 
            this.lblModificarTipoEvento.AutoSize = true;
            this.lblModificarTipoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarTipoEvento.Location = new System.Drawing.Point(293, 30);
            this.lblModificarTipoEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarTipoEvento.Name = "lblModificarTipoEvento";
            this.lblModificarTipoEvento.Size = new System.Drawing.Size(90, 15);
            this.lblModificarTipoEvento.TabIndex = 39;
            this.lblModificarTipoEvento.Text = "Tipo de evento:";
            // 
            // cboModificarProduceCategoria
            // 
            this.cboModificarProduceCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModificarProduceCategoria.Enabled = false;
            this.cboModificarProduceCategoria.FormattingEnabled = true;
            this.cboModificarProduceCategoria.Items.AddRange(new object[] {
            "Cereal",
            "Fruta",
            "Verdura"});
            this.cboModificarProduceCategoria.Location = new System.Drawing.Point(88, 74);
            this.cboModificarProduceCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cboModificarProduceCategoria.Name = "cboModificarProduceCategoria";
            this.cboModificarProduceCategoria.Size = new System.Drawing.Size(192, 21);
            this.cboModificarProduceCategoria.TabIndex = 35;
            // 
            // lblModificarProduce
            // 
            this.lblModificarProduce.AutoSize = true;
            this.lblModificarProduce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarProduce.Location = new System.Drawing.Point(25, 77);
            this.lblModificarProduce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarProduce.Name = "lblModificarProduce";
            this.lblModificarProduce.Size = new System.Drawing.Size(59, 15);
            this.lblModificarProduce.TabIndex = 36;
            this.lblModificarProduce.Text = "Produce: ";
            // 
            // cboModificarPredio
            // 
            this.cboModificarPredio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModificarPredio.Enabled = false;
            this.cboModificarPredio.FormattingEnabled = true;
            this.cboModificarPredio.Location = new System.Drawing.Point(88, 116);
            this.cboModificarPredio.Margin = new System.Windows.Forms.Padding(2);
            this.cboModificarPredio.Name = "cboModificarPredio";
            this.cboModificarPredio.Size = new System.Drawing.Size(192, 21);
            this.cboModificarPredio.TabIndex = 36;
            // 
            // lblModificarPredio
            // 
            this.lblModificarPredio.AutoSize = true;
            this.lblModificarPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarPredio.Location = new System.Drawing.Point(35, 119);
            this.lblModificarPredio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarPredio.Name = "lblModificarPredio";
            this.lblModificarPredio.Size = new System.Drawing.Size(49, 15);
            this.lblModificarPredio.TabIndex = 35;
            this.lblModificarPredio.Text = "Predio: ";
            // 
            // lblModificarProductor
            // 
            this.lblModificarProductor.AutoSize = true;
            this.lblModificarProductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarProductor.Location = new System.Drawing.Point(18, 30);
            this.lblModificarProductor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarProductor.Name = "lblModificarProductor";
            this.lblModificarProductor.Size = new System.Drawing.Size(66, 15);
            this.lblModificarProductor.TabIndex = 0;
            this.lblModificarProductor.Text = "Productor: ";
            // 
            // cboModificarSector
            // 
            this.cboModificarSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModificarSector.Enabled = false;
            this.cboModificarSector.FormattingEnabled = true;
            this.cboModificarSector.Location = new System.Drawing.Point(88, 141);
            this.cboModificarSector.Margin = new System.Windows.Forms.Padding(2);
            this.cboModificarSector.Name = "cboModificarSector";
            this.cboModificarSector.Size = new System.Drawing.Size(192, 21);
            this.cboModificarSector.TabIndex = 38;
            // 
            // txtModificarProductorCi
            // 
            this.txtModificarProductorCi.Location = new System.Drawing.Point(88, 28);
            this.txtModificarProductorCi.Margin = new System.Windows.Forms.Padding(2);
            this.txtModificarProductorCi.MaxLength = 8;
            this.txtModificarProductorCi.Name = "txtModificarProductorCi";
            this.txtModificarProductorCi.Size = new System.Drawing.Size(192, 20);
            this.txtModificarProductorCi.TabIndex = 0;
            // 
            // lblModificarSector
            // 
            this.lblModificarSector.AutoSize = true;
            this.lblModificarSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarSector.Location = new System.Drawing.Point(36, 144);
            this.lblModificarSector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarSector.Name = "lblModificarSector";
            this.lblModificarSector.Size = new System.Drawing.Size(48, 15);
            this.lblModificarSector.TabIndex = 37;
            this.lblModificarSector.Text = "Sector: ";
            // 
            // txtModificarInfo
            // 
            this.txtModificarInfo.Location = new System.Drawing.Point(387, 117);
            this.txtModificarInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtModificarInfo.MaxLength = 35;
            this.txtModificarInfo.Name = "txtModificarInfo";
            this.txtModificarInfo.Size = new System.Drawing.Size(192, 20);
            this.txtModificarInfo.TabIndex = 5;
            // 
            // lblModificarDescripcion
            // 
            this.lblModificarDescripcion.AutoSize = true;
            this.lblModificarDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarDescripcion.Location = new System.Drawing.Point(308, 119);
            this.lblModificarDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarDescripcion.Name = "lblModificarDescripcion";
            this.lblModificarDescripcion.Size = new System.Drawing.Size(75, 15);
            this.lblModificarDescripcion.TabIndex = 16;
            this.lblModificarDescripcion.Text = "Descripción:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(14, 368);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(735, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "* Error al crear evento *";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Visible = false;
            // 
            // lblTituloSoporte
            // 
            this.lblTituloSoporte.AutoSize = true;
            this.lblTituloSoporte.Font = new System.Drawing.Font("Rockwell", 16F);
            this.lblTituloSoporte.Location = new System.Drawing.Point(234, 15);
            this.lblTituloSoporte.Name = "lblTituloSoporte";
            this.lblTituloSoporte.Size = new System.Drawing.Size(332, 25);
            this.lblTituloSoporte.TabIndex = 6;
            this.lblTituloSoporte.Text = "Panel de gestion de calendario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(387, 186);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 35;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 71;
            this.label1.Text = "Evento anterior:";
            // 
            // frmMenuAdminGestCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(791, 500);
            this.Controls.Add(this.tabGestionCalendario);
            this.Controls.Add(this.lblTituloSoporte);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuAdminGestCalendario";
            this.Text = "FrmVentaMenu";
            this.tabGestionCalendario.ResumeLayout(false);
            this.tabConsultar.ResumeLayout(false);
            this.tabConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEventos)).EndInit();
            this.tabAlta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCrear)).EndInit();
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.tabModificar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).EndInit();
            this.grpDatosEvento.ResumeLayout(false);
            this.grpDatosEvento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.TabControl tabGestionCalendario;
        private System.Windows.Forms.TabPage tabConsultar;
        private System.Windows.Forms.Label lblConsultaError;
        private System.Windows.Forms.Button btnConsultar_CargarTodos;
        private System.Windows.Forms.DataGridView gridEventos;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.TabPage tabAlta;
        private System.Windows.Forms.PictureBox picCrear;
        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.Label lblAltaCedula;
        private System.Windows.Forms.TextBox txtAltaCedula;
        private System.Windows.Forms.TextBox txtAltaInfo;
        private System.Windows.Forms.Label lblAltaInfo;
        private System.Windows.Forms.Label lblAltaError;
        private System.Windows.Forms.Button btnAltaCrearEvento;
        private System.Windows.Forms.Label lblTituloSoporte;
        private System.Windows.Forms.Label lblConsultarPorFecha;
        private System.Windows.Forms.DateTimePicker dtpConsultarFecha;
        private System.Windows.Forms.Button btnConsultaBuscar;
        private System.Windows.Forms.ComboBox cboAltaPredio;
        private System.Windows.Forms.Label lblAltaPredio;
        private System.Windows.Forms.ComboBox cboAltaSector;
        private System.Windows.Forms.Label lblAltaSector;
        private System.Windows.Forms.ComboBox cboAltaEvento;
        private System.Windows.Forms.Label lblAltaTipoEvento;
        private System.Windows.Forms.ComboBox cboAltaProduceTipo;
        private System.Windows.Forms.Label lblProduce;
        private System.Windows.Forms.DateTimePicker dtpAltaFechaFin;
        private System.Windows.Forms.Label lblAltaFechaFin;
        private System.Windows.Forms.Label lblAltaFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpAltaFechaInicio;
        private System.Windows.Forms.Label lblAltaTipo;
        private System.Windows.Forms.TextBox txtAltaTipo;
        private System.Windows.Forms.ComboBox cboAltaEstado;
        private System.Windows.Forms.Label lblAltaEstado;
        private System.Windows.Forms.PictureBox picModificar;
        private System.Windows.Forms.GroupBox grpDatosEvento;
        private System.Windows.Forms.ComboBox cboModificarEstadoEvento;
        private System.Windows.Forms.Label lblModificarEstado;
        private System.Windows.Forms.Label lblModificarTipo;
        private System.Windows.Forms.TextBox txtModificarTipoProductor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnModificarEvento;
        private System.Windows.Forms.Label lblModificarFFin;
        private System.Windows.Forms.Label lblModificarFIni;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cboModificarTipoEvento;
        private System.Windows.Forms.Label lblModificarTipoEvento;
        private System.Windows.Forms.ComboBox cboModificarProduceCategoria;
        private System.Windows.Forms.Label lblModificarProduce;
        private System.Windows.Forms.ComboBox cboModificarPredio;
        private System.Windows.Forms.Label lblModificarPredio;
        private System.Windows.Forms.Label lblModificarProductor;
        private System.Windows.Forms.ComboBox cboModificarSector;
        private System.Windows.Forms.TextBox txtModificarProductorCi;
        private System.Windows.Forms.Label lblModificarSector;
        private System.Windows.Forms.TextBox txtModificarInfo;
        private System.Windows.Forms.Label lblModificarDescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtModificarIdAnterior;
        private System.Windows.Forms.Label lblModificarAnterior;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}