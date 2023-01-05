namespace Presentacion
{
    partial class frmMenuProdCalendario
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
            this.lblTituloSoporte = new System.Windows.Forms.Label();
            this.tabCrearEventos = new System.Windows.Forms.TabPage();
            this.grpSeleccionarPredioSector = new System.Windows.Forms.GroupBox();
            this.cboCrearPredios = new System.Windows.Forms.ComboBox();
            this.lblCrearPredio = new System.Windows.Forms.Label();
            this.lblCrearSector = new System.Windows.Forms.Label();
            this.cboCrearSector = new System.Windows.Forms.ComboBox();
            this.grpCargarEvento = new System.Windows.Forms.GroupBox();
            this.lblSolicitarInfo = new System.Windows.Forms.Label();
            this.btnSolicitarEvento = new System.Windows.Forms.Button();
            this.lblCargarEvento = new System.Windows.Forms.Label();
            this.lblCrearInfo = new System.Windows.Forms.Label();
            this.cboCargarEvento = new System.Windows.Forms.ComboBox();
            this.txtCrearInfo = new System.Windows.Forms.TextBox();
            this.lblCrearProduce = new System.Windows.Forms.Label();
            this.cboCrearTipoProduce = new System.Windows.Forms.ComboBox();
            this.dtpCrearFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblCargarTipoEvento = new System.Windows.Forms.Label();
            this.lblCrearFechaFin = new System.Windows.Forms.Label();
            this.cboCrearTipoEvento = new System.Windows.Forms.ComboBox();
            this.lblCrearFechaInicio = new System.Windows.Forms.Label();
            this.dtpCrearFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblCrearError = new System.Windows.Forms.Label();
            this.tabGestionarEventosPredios = new System.Windows.Forms.TabControl();
            this.tabConsultarEventos = new System.Windows.Forms.TabPage();
            this.btnConsultaBuscar = new System.Windows.Forms.Button();
            this.lblConsultarPorFecha = new System.Windows.Forms.Label();
            this.dtpConsultarFecha = new System.Windows.Forms.DateTimePicker();
            this.btnConsultarCargarTodos = new System.Windows.Forms.Button();
            this.lblConsultaError = new System.Windows.Forms.Label();
            this.gridEventos = new System.Windows.Forms.DataGridView();
            this.tabModificarEvento = new System.Windows.Forms.TabPage();
            this.grpModificarPredioSector = new System.Windows.Forms.GroupBox();
            this.lblModificarPredio = new System.Windows.Forms.Label();
            this.cboModificarPredio = new System.Windows.Forms.ComboBox();
            this.lblModificarSector = new System.Windows.Forms.Label();
            this.cboModificarSector = new System.Windows.Forms.ComboBox();
            this.grpModificarEventos = new System.Windows.Forms.GroupBox();
            this.btnModificarEvento = new System.Windows.Forms.Button();
            this.lblModificarEvento = new System.Windows.Forms.Label();
            this.lblModificarDescripcion = new System.Windows.Forms.Label();
            this.cboModificarEvento = new System.Windows.Forms.ComboBox();
            this.txtModificarDescripcion = new System.Windows.Forms.TextBox();
            this.cboModificarEstado = new System.Windows.Forms.ComboBox();
            this.lblModificarProduce = new System.Windows.Forms.Label();
            this.lblModificarEstado = new System.Windows.Forms.Label();
            this.cboModificarProduce = new System.Windows.Forms.ComboBox();
            this.dtpModificarFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblModificarTipo = new System.Windows.Forms.Label();
            this.lblModificarFechaFin = new System.Windows.Forms.Label();
            this.cboModificarTipo = new System.Windows.Forms.ComboBox();
            this.lblModificarFechaIni = new System.Windows.Forms.Label();
            this.dtpModificarFechaIni = new System.Windows.Forms.DateTimePicker();
            this.lblModificarError = new System.Windows.Forms.Label();
            this.lblModificarGestionado = new System.Windows.Forms.Label();
            this.txtModificarGestor = new System.Windows.Forms.TextBox();
            this.tabCrearEventos.SuspendLayout();
            this.grpSeleccionarPredioSector.SuspendLayout();
            this.grpCargarEvento.SuspendLayout();
            this.tabGestionarEventosPredios.SuspendLayout();
            this.tabConsultarEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEventos)).BeginInit();
            this.tabModificarEvento.SuspendLayout();
            this.grpModificarPredioSector.SuspendLayout();
            this.grpModificarEventos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloSoporte
            // 
            this.lblTituloSoporte.AutoSize = true;
            this.lblTituloSoporte.Font = new System.Drawing.Font("Rockwell", 16F);
            this.lblTituloSoporte.Location = new System.Drawing.Point(292, 20);
            this.lblTituloSoporte.Name = "lblTituloSoporte";
            this.lblTituloSoporte.Size = new System.Drawing.Size(213, 25);
            this.lblTituloSoporte.TabIndex = 10;
            this.lblTituloSoporte.Text = "Agenda de eventos";
            // 
            // tabCrearEventos
            // 
            this.tabCrearEventos.Controls.Add(this.grpSeleccionarPredioSector);
            this.tabCrearEventos.Controls.Add(this.grpCargarEvento);
            this.tabCrearEventos.Controls.Add(this.lblCrearError);
            this.tabCrearEventos.Location = new System.Drawing.Point(4, 22);
            this.tabCrearEventos.Margin = new System.Windows.Forms.Padding(2);
            this.tabCrearEventos.Name = "tabCrearEventos";
            this.tabCrearEventos.Padding = new System.Windows.Forms.Padding(2);
            this.tabCrearEventos.Size = new System.Drawing.Size(765, 408);
            this.tabCrearEventos.TabIndex = 3;
            this.tabCrearEventos.Text = "Solicitar Evento";
            this.tabCrearEventos.UseVisualStyleBackColor = true;
            // 
            // grpSeleccionarPredioSector
            // 
            this.grpSeleccionarPredioSector.Controls.Add(this.cboCrearPredios);
            this.grpSeleccionarPredioSector.Controls.Add(this.lblCrearPredio);
            this.grpSeleccionarPredioSector.Controls.Add(this.lblCrearSector);
            this.grpSeleccionarPredioSector.Controls.Add(this.cboCrearSector);
            this.grpSeleccionarPredioSector.Location = new System.Drawing.Point(10, 5);
            this.grpSeleccionarPredioSector.Margin = new System.Windows.Forms.Padding(2);
            this.grpSeleccionarPredioSector.Name = "grpSeleccionarPredioSector";
            this.grpSeleccionarPredioSector.Padding = new System.Windows.Forms.Padding(2);
            this.grpSeleccionarPredioSector.Size = new System.Drawing.Size(737, 110);
            this.grpSeleccionarPredioSector.TabIndex = 84;
            this.grpSeleccionarPredioSector.TabStop = false;
            this.grpSeleccionarPredioSector.Text = "Seleccionar predio y sector:";
            // 
            // cboCrearPredios
            // 
            this.cboCrearPredios.FormattingEnabled = true;
            this.cboCrearPredios.Location = new System.Drawing.Point(67, 32);
            this.cboCrearPredios.Margin = new System.Windows.Forms.Padding(2);
            this.cboCrearPredios.Name = "cboCrearPredios";
            this.cboCrearPredios.Size = new System.Drawing.Size(649, 21);
            this.cboCrearPredios.TabIndex = 58;
            // 
            // lblCrearPredio
            // 
            this.lblCrearPredio.AutoSize = true;
            this.lblCrearPredio.Location = new System.Drawing.Point(17, 34);
            this.lblCrearPredio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearPredio.Name = "lblCrearPredio";
            this.lblCrearPredio.Size = new System.Drawing.Size(40, 13);
            this.lblCrearPredio.TabIndex = 59;
            this.lblCrearPredio.Text = "Predio:";
            // 
            // lblCrearSector
            // 
            this.lblCrearSector.AutoSize = true;
            this.lblCrearSector.Location = new System.Drawing.Point(16, 66);
            this.lblCrearSector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearSector.Name = "lblCrearSector";
            this.lblCrearSector.Size = new System.Drawing.Size(41, 13);
            this.lblCrearSector.TabIndex = 61;
            this.lblCrearSector.Text = "Sector:";
            // 
            // cboCrearSector
            // 
            this.cboCrearSector.FormattingEnabled = true;
            this.cboCrearSector.Location = new System.Drawing.Point(67, 64);
            this.cboCrearSector.Margin = new System.Windows.Forms.Padding(2);
            this.cboCrearSector.Name = "cboCrearSector";
            this.cboCrearSector.Size = new System.Drawing.Size(649, 21);
            this.cboCrearSector.TabIndex = 60;
            // 
            // grpCargarEvento
            // 
            this.grpCargarEvento.Controls.Add(this.lblSolicitarInfo);
            this.grpCargarEvento.Controls.Add(this.btnSolicitarEvento);
            this.grpCargarEvento.Controls.Add(this.lblCargarEvento);
            this.grpCargarEvento.Controls.Add(this.lblCrearInfo);
            this.grpCargarEvento.Controls.Add(this.cboCargarEvento);
            this.grpCargarEvento.Controls.Add(this.txtCrearInfo);
            this.grpCargarEvento.Controls.Add(this.lblCrearProduce);
            this.grpCargarEvento.Controls.Add(this.cboCrearTipoProduce);
            this.grpCargarEvento.Controls.Add(this.dtpCrearFechaFin);
            this.grpCargarEvento.Controls.Add(this.lblCargarTipoEvento);
            this.grpCargarEvento.Controls.Add(this.lblCrearFechaFin);
            this.grpCargarEvento.Controls.Add(this.cboCrearTipoEvento);
            this.grpCargarEvento.Controls.Add(this.lblCrearFechaInicio);
            this.grpCargarEvento.Controls.Add(this.dtpCrearFechaInicio);
            this.grpCargarEvento.Location = new System.Drawing.Point(10, 120);
            this.grpCargarEvento.Margin = new System.Windows.Forms.Padding(2);
            this.grpCargarEvento.Name = "grpCargarEvento";
            this.grpCargarEvento.Padding = new System.Windows.Forms.Padding(2);
            this.grpCargarEvento.Size = new System.Drawing.Size(737, 231);
            this.grpCargarEvento.TabIndex = 82;
            this.grpCargarEvento.TabStop = false;
            this.grpCargarEvento.Text = "Agenda de eventos:";
            // 
            // lblSolicitarInfo
            // 
            this.lblSolicitarInfo.AutoSize = true;
            this.lblSolicitarInfo.Location = new System.Drawing.Point(229, 203);
            this.lblSolicitarInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSolicitarInfo.Name = "lblSolicitarInfo";
            this.lblSolicitarInfo.Size = new System.Drawing.Size(279, 13);
            this.lblSolicitarInfo.TabIndex = 83;
            this.lblSolicitarInfo.Text = "*Los eventos deben ser confirmados por un administrativo";
            // 
            // btnSolicitarEvento
            // 
            this.btnSolicitarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitarEvento.Location = new System.Drawing.Point(256, 156);
            this.btnSolicitarEvento.Margin = new System.Windows.Forms.Padding(2);
            this.btnSolicitarEvento.Name = "btnSolicitarEvento";
            this.btnSolicitarEvento.Size = new System.Drawing.Size(225, 34);
            this.btnSolicitarEvento.TabIndex = 82;
            this.btnSolicitarEvento.Text = "Enviar solicitud";
            this.btnSolicitarEvento.UseVisualStyleBackColor = true;
            // 
            // lblCargarEvento
            // 
            this.lblCargarEvento.AutoSize = true;
            this.lblCargarEvento.Location = new System.Drawing.Point(14, 27);
            this.lblCargarEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargarEvento.Name = "lblCargarEvento";
            this.lblCargarEvento.Size = new System.Drawing.Size(44, 13);
            this.lblCargarEvento.TabIndex = 81;
            this.lblCargarEvento.Text = "Evento:";
            // 
            // lblCrearInfo
            // 
            this.lblCrearInfo.AutoSize = true;
            this.lblCrearInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearInfo.Location = new System.Drawing.Point(79, 89);
            this.lblCrearInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearInfo.Name = "lblCrearInfo";
            this.lblCrearInfo.Size = new System.Drawing.Size(75, 15);
            this.lblCrearInfo.TabIndex = 69;
            this.lblCrearInfo.Text = "Descripción:";
            // 
            // cboCargarEvento
            // 
            this.cboCargarEvento.FormattingEnabled = true;
            this.cboCargarEvento.Location = new System.Drawing.Point(67, 24);
            this.cboCargarEvento.Margin = new System.Windows.Forms.Padding(2);
            this.cboCargarEvento.Name = "cboCargarEvento";
            this.cboCargarEvento.Size = new System.Drawing.Size(649, 21);
            this.cboCargarEvento.TabIndex = 80;
            // 
            // txtCrearInfo
            // 
            this.txtCrearInfo.Location = new System.Drawing.Point(158, 87);
            this.txtCrearInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCrearInfo.MaxLength = 35;
            this.txtCrearInfo.Name = "txtCrearInfo";
            this.txtCrearInfo.Size = new System.Drawing.Size(558, 20);
            this.txtCrearInfo.TabIndex = 68;
            // 
            // lblCrearProduce
            // 
            this.lblCrearProduce.AutoSize = true;
            this.lblCrearProduce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearProduce.Location = new System.Drawing.Point(312, 59);
            this.lblCrearProduce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearProduce.Name = "lblCrearProduce";
            this.lblCrearProduce.Size = new System.Drawing.Size(56, 15);
            this.lblCrearProduce.TabIndex = 71;
            this.lblCrearProduce.Text = "Produce:";
            // 
            // cboCrearTipoProduce
            // 
            this.cboCrearTipoProduce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCrearTipoProduce.Enabled = false;
            this.cboCrearTipoProduce.FormattingEnabled = true;
            this.cboCrearTipoProduce.Items.AddRange(new object[] {
            "Cereal",
            "Fruta",
            "Verdura"});
            this.cboCrearTipoProduce.Location = new System.Drawing.Point(372, 56);
            this.cboCrearTipoProduce.Margin = new System.Windows.Forms.Padding(2);
            this.cboCrearTipoProduce.Name = "cboCrearTipoProduce";
            this.cboCrearTipoProduce.Size = new System.Drawing.Size(192, 21);
            this.cboCrearTipoProduce.TabIndex = 70;
            // 
            // dtpCrearFechaFin
            // 
            this.dtpCrearFechaFin.CustomFormat = "dd-MM-yyyy";
            this.dtpCrearFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCrearFechaFin.Location = new System.Drawing.Point(450, 118);
            this.dtpCrearFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCrearFechaFin.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpCrearFechaFin.Name = "dtpCrearFechaFin";
            this.dtpCrearFechaFin.Size = new System.Drawing.Size(91, 20);
            this.dtpCrearFechaFin.TabIndex = 77;
            this.dtpCrearFechaFin.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // lblCargarTipoEvento
            // 
            this.lblCargarTipoEvento.AutoSize = true;
            this.lblCargarTipoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargarTipoEvento.Location = new System.Drawing.Point(64, 59);
            this.lblCargarTipoEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargarTipoEvento.Name = "lblCargarTipoEvento";
            this.lblCargarTipoEvento.Size = new System.Drawing.Size(90, 15);
            this.lblCargarTipoEvento.TabIndex = 72;
            this.lblCargarTipoEvento.Text = "Tipo de evento:";
            // 
            // lblCrearFechaFin
            // 
            this.lblCrearFechaFin.AutoSize = true;
            this.lblCrearFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearFechaFin.Location = new System.Drawing.Point(369, 119);
            this.lblCrearFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearFechaFin.Name = "lblCrearFechaFin";
            this.lblCrearFechaFin.Size = new System.Drawing.Size(77, 15);
            this.lblCrearFechaFin.TabIndex = 76;
            this.lblCrearFechaFin.Text = "Fecha de fin:";
            this.lblCrearFechaFin.Click += new System.EventHandler(this.lblCrearFechaFin_Click);
            // 
            // cboCrearTipoEvento
            // 
            this.cboCrearTipoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCrearTipoEvento.Enabled = false;
            this.cboCrearTipoEvento.FormattingEnabled = true;
            this.cboCrearTipoEvento.Location = new System.Drawing.Point(158, 56);
            this.cboCrearTipoEvento.Margin = new System.Windows.Forms.Padding(2);
            this.cboCrearTipoEvento.Name = "cboCrearTipoEvento";
            this.cboCrearTipoEvento.Size = new System.Drawing.Size(134, 21);
            this.cboCrearTipoEvento.TabIndex = 73;
            // 
            // lblCrearFechaInicio
            // 
            this.lblCrearFechaInicio.AutoSize = true;
            this.lblCrearFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearFechaInicio.Location = new System.Drawing.Point(171, 119);
            this.lblCrearFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearFechaInicio.Name = "lblCrearFechaInicio";
            this.lblCrearFechaInicio.Size = new System.Drawing.Size(93, 15);
            this.lblCrearFechaInicio.TabIndex = 75;
            this.lblCrearFechaInicio.Text = "Fecha de inicio:";
            // 
            // dtpCrearFechaInicio
            // 
            this.dtpCrearFechaInicio.CustomFormat = "dd-MM-yyyy";
            this.dtpCrearFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCrearFechaInicio.Location = new System.Drawing.Point(268, 118);
            this.dtpCrearFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCrearFechaInicio.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpCrearFechaInicio.Name = "dtpCrearFechaInicio";
            this.dtpCrearFechaInicio.Size = new System.Drawing.Size(91, 20);
            this.dtpCrearFechaInicio.TabIndex = 74;
            this.dtpCrearFechaInicio.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // lblCrearError
            // 
            this.lblCrearError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearError.ForeColor = System.Drawing.Color.Red;
            this.lblCrearError.Location = new System.Drawing.Point(15, 366);
            this.lblCrearError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearError.Name = "lblCrearError";
            this.lblCrearError.Size = new System.Drawing.Size(732, 19);
            this.lblCrearError.TabIndex = 57;
            this.lblCrearError.Text = "* Error al crear evento*";
            this.lblCrearError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCrearError.Visible = false;
            // 
            // tabGestionarEventosPredios
            // 
            this.tabGestionarEventosPredios.Controls.Add(this.tabConsultarEventos);
            this.tabGestionarEventosPredios.Controls.Add(this.tabCrearEventos);
            this.tabGestionarEventosPredios.Controls.Add(this.tabModificarEvento);
            this.tabGestionarEventosPredios.Location = new System.Drawing.Point(9, 56);
            this.tabGestionarEventosPredios.Margin = new System.Windows.Forms.Padding(2);
            this.tabGestionarEventosPredios.Name = "tabGestionarEventosPredios";
            this.tabGestionarEventosPredios.SelectedIndex = 0;
            this.tabGestionarEventosPredios.Size = new System.Drawing.Size(773, 434);
            this.tabGestionarEventosPredios.TabIndex = 9;
            // 
            // tabConsultarEventos
            // 
            this.tabConsultarEventos.Controls.Add(this.btnConsultaBuscar);
            this.tabConsultarEventos.Controls.Add(this.lblConsultarPorFecha);
            this.tabConsultarEventos.Controls.Add(this.dtpConsultarFecha);
            this.tabConsultarEventos.Controls.Add(this.btnConsultarCargarTodos);
            this.tabConsultarEventos.Controls.Add(this.lblConsultaError);
            this.tabConsultarEventos.Controls.Add(this.gridEventos);
            this.tabConsultarEventos.Location = new System.Drawing.Point(4, 22);
            this.tabConsultarEventos.Margin = new System.Windows.Forms.Padding(2);
            this.tabConsultarEventos.Name = "tabConsultarEventos";
            this.tabConsultarEventos.Padding = new System.Windows.Forms.Padding(2);
            this.tabConsultarEventos.Size = new System.Drawing.Size(765, 408);
            this.tabConsultarEventos.TabIndex = 5;
            this.tabConsultarEventos.Text = "Consultar Eventos";
            this.tabConsultarEventos.UseVisualStyleBackColor = true;
            // 
            // btnConsultaBuscar
            // 
            this.btnConsultaBuscar.Location = new System.Drawing.Point(691, 24);
            this.btnConsultaBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultaBuscar.Name = "btnConsultaBuscar";
            this.btnConsultaBuscar.Size = new System.Drawing.Size(56, 19);
            this.btnConsultaBuscar.TabIndex = 64;
            this.btnConsultaBuscar.Text = "Buscar";
            this.btnConsultaBuscar.UseVisualStyleBackColor = true;
            // 
            // lblConsultarPorFecha
            // 
            this.lblConsultarPorFecha.AutoSize = true;
            this.lblConsultarPorFecha.Location = new System.Drawing.Point(447, 27);
            this.lblConsultarPorFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsultarPorFecha.Name = "lblConsultarPorFecha";
            this.lblConsultarPorFecha.Size = new System.Drawing.Size(142, 13);
            this.lblConsultarPorFecha.TabIndex = 63;
            this.lblConsultarPorFecha.Text = "Eventos activos en la fecha:";
            // 
            // dtpConsultarFecha
            // 
            this.dtpConsultarFecha.CustomFormat = "dd-MM-yyyy";
            this.dtpConsultarFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpConsultarFecha.Location = new System.Drawing.Point(592, 24);
            this.dtpConsultarFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpConsultarFecha.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpConsultarFecha.Name = "dtpConsultarFecha";
            this.dtpConsultarFecha.Size = new System.Drawing.Size(91, 20);
            this.dtpConsultarFecha.TabIndex = 62;
            this.dtpConsultarFecha.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // btnConsultarCargarTodos
            // 
            this.btnConsultarCargarTodos.Location = new System.Drawing.Point(18, 19);
            this.btnConsultarCargarTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarCargarTodos.Name = "btnConsultarCargarTodos";
            this.btnConsultarCargarTodos.Size = new System.Drawing.Size(121, 28);
            this.btnConsultarCargarTodos.TabIndex = 61;
            this.btnConsultarCargarTodos.Text = "Historico de eventos";
            this.btnConsultarCargarTodos.UseVisualStyleBackColor = true;
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
            // gridEventos
            // 
            this.gridEventos.AllowUserToAddRows = false;
            this.gridEventos.AllowUserToDeleteRows = false;
            this.gridEventos.AllowUserToOrderColumns = true;
            this.gridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEventos.Location = new System.Drawing.Point(18, 52);
            this.gridEventos.Margin = new System.Windows.Forms.Padding(2);
            this.gridEventos.Name = "gridEventos";
            this.gridEventos.ReadOnly = true;
            this.gridEventos.RowHeadersWidth = 51;
            this.gridEventos.RowTemplate.Height = 24;
            this.gridEventos.Size = new System.Drawing.Size(729, 300);
            this.gridEventos.TabIndex = 5;
            // 
            // tabModificarEvento
            // 
            this.tabModificarEvento.Controls.Add(this.grpModificarPredioSector);
            this.tabModificarEvento.Controls.Add(this.grpModificarEventos);
            this.tabModificarEvento.Controls.Add(this.lblModificarError);
            this.tabModificarEvento.Location = new System.Drawing.Point(4, 22);
            this.tabModificarEvento.Margin = new System.Windows.Forms.Padding(2);
            this.tabModificarEvento.Name = "tabModificarEvento";
            this.tabModificarEvento.Padding = new System.Windows.Forms.Padding(2);
            this.tabModificarEvento.Size = new System.Drawing.Size(765, 408);
            this.tabModificarEvento.TabIndex = 4;
            this.tabModificarEvento.Text = "Modificar Evento";
            this.tabModificarEvento.UseVisualStyleBackColor = true;
            // 
            // grpModificarPredioSector
            // 
            this.grpModificarPredioSector.Controls.Add(this.lblModificarPredio);
            this.grpModificarPredioSector.Controls.Add(this.cboModificarPredio);
            this.grpModificarPredioSector.Controls.Add(this.lblModificarSector);
            this.grpModificarPredioSector.Controls.Add(this.cboModificarSector);
            this.grpModificarPredioSector.Location = new System.Drawing.Point(10, 6);
            this.grpModificarPredioSector.Margin = new System.Windows.Forms.Padding(2);
            this.grpModificarPredioSector.Name = "grpModificarPredioSector";
            this.grpModificarPredioSector.Padding = new System.Windows.Forms.Padding(2);
            this.grpModificarPredioSector.Size = new System.Drawing.Size(737, 109);
            this.grpModificarPredioSector.TabIndex = 83;
            this.grpModificarPredioSector.TabStop = false;
            this.grpModificarPredioSector.Text = "Seleccionar predio y sector:";
            // 
            // lblModificarPredio
            // 
            this.lblModificarPredio.AutoSize = true;
            this.lblModificarPredio.Location = new System.Drawing.Point(17, 33);
            this.lblModificarPredio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarPredio.Name = "lblModificarPredio";
            this.lblModificarPredio.Size = new System.Drawing.Size(40, 13);
            this.lblModificarPredio.TabIndex = 59;
            this.lblModificarPredio.Text = "Predio:";
            this.lblModificarPredio.Click += new System.EventHandler(this.lblModificarPredio_Click);
            // 
            // cboModificarPredio
            // 
            this.cboModificarPredio.FormattingEnabled = true;
            this.cboModificarPredio.Location = new System.Drawing.Point(67, 31);
            this.cboModificarPredio.Margin = new System.Windows.Forms.Padding(2);
            this.cboModificarPredio.Name = "cboModificarPredio";
            this.cboModificarPredio.Size = new System.Drawing.Size(649, 21);
            this.cboModificarPredio.TabIndex = 58;
            // 
            // lblModificarSector
            // 
            this.lblModificarSector.AutoSize = true;
            this.lblModificarSector.Location = new System.Drawing.Point(16, 65);
            this.lblModificarSector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarSector.Name = "lblModificarSector";
            this.lblModificarSector.Size = new System.Drawing.Size(41, 13);
            this.lblModificarSector.TabIndex = 61;
            this.lblModificarSector.Text = "Sector:";
            this.lblModificarSector.Click += new System.EventHandler(this.lblModificarSector_Click);
            // 
            // cboModificarSector
            // 
            this.cboModificarSector.FormattingEnabled = true;
            this.cboModificarSector.Location = new System.Drawing.Point(67, 63);
            this.cboModificarSector.Margin = new System.Windows.Forms.Padding(2);
            this.cboModificarSector.Name = "cboModificarSector";
            this.cboModificarSector.Size = new System.Drawing.Size(649, 21);
            this.cboModificarSector.TabIndex = 60;
            // 
            // grpModificarEventos
            // 
            this.grpModificarEventos.Controls.Add(this.txtModificarGestor);
            this.grpModificarEventos.Controls.Add(this.lblModificarGestionado);
            this.grpModificarEventos.Controls.Add(this.btnModificarEvento);
            this.grpModificarEventos.Controls.Add(this.lblModificarEvento);
            this.grpModificarEventos.Controls.Add(this.lblModificarDescripcion);
            this.grpModificarEventos.Controls.Add(this.cboModificarEvento);
            this.grpModificarEventos.Controls.Add(this.txtModificarDescripcion);
            this.grpModificarEventos.Controls.Add(this.cboModificarEstado);
            this.grpModificarEventos.Controls.Add(this.lblModificarProduce);
            this.grpModificarEventos.Controls.Add(this.lblModificarEstado);
            this.grpModificarEventos.Controls.Add(this.cboModificarProduce);
            this.grpModificarEventos.Controls.Add(this.dtpModificarFechaFin);
            this.grpModificarEventos.Controls.Add(this.lblModificarTipo);
            this.grpModificarEventos.Controls.Add(this.lblModificarFechaFin);
            this.grpModificarEventos.Controls.Add(this.cboModificarTipo);
            this.grpModificarEventos.Controls.Add(this.lblModificarFechaIni);
            this.grpModificarEventos.Controls.Add(this.dtpModificarFechaIni);
            this.grpModificarEventos.Location = new System.Drawing.Point(10, 120);
            this.grpModificarEventos.Margin = new System.Windows.Forms.Padding(2);
            this.grpModificarEventos.Name = "grpModificarEventos";
            this.grpModificarEventos.Padding = new System.Windows.Forms.Padding(2);
            this.grpModificarEventos.Size = new System.Drawing.Size(737, 231);
            this.grpModificarEventos.TabIndex = 82;
            this.grpModificarEventos.TabStop = false;
            this.grpModificarEventos.Text = "Agenda de eventos:";
            // 
            // btnModificarEvento
            // 
            this.btnModificarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEvento.Location = new System.Drawing.Point(258, 186);
            this.btnModificarEvento.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarEvento.Name = "btnModificarEvento";
            this.btnModificarEvento.Size = new System.Drawing.Size(225, 34);
            this.btnModificarEvento.TabIndex = 82;
            this.btnModificarEvento.Text = "Modificar evento";
            this.btnModificarEvento.UseVisualStyleBackColor = true;
            // 
            // lblModificarEvento
            // 
            this.lblModificarEvento.AutoSize = true;
            this.lblModificarEvento.Location = new System.Drawing.Point(14, 27);
            this.lblModificarEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarEvento.Name = "lblModificarEvento";
            this.lblModificarEvento.Size = new System.Drawing.Size(44, 13);
            this.lblModificarEvento.TabIndex = 81;
            this.lblModificarEvento.Text = "Evento:";
            // 
            // lblModificarDescripcion
            // 
            this.lblModificarDescripcion.AutoSize = true;
            this.lblModificarDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarDescripcion.Location = new System.Drawing.Point(79, 89);
            this.lblModificarDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarDescripcion.Name = "lblModificarDescripcion";
            this.lblModificarDescripcion.Size = new System.Drawing.Size(75, 15);
            this.lblModificarDescripcion.TabIndex = 69;
            this.lblModificarDescripcion.Text = "Descripción:";
            // 
            // cboModificarEvento
            // 
            this.cboModificarEvento.FormattingEnabled = true;
            this.cboModificarEvento.Location = new System.Drawing.Point(67, 24);
            this.cboModificarEvento.Margin = new System.Windows.Forms.Padding(2);
            this.cboModificarEvento.Name = "cboModificarEvento";
            this.cboModificarEvento.Size = new System.Drawing.Size(649, 21);
            this.cboModificarEvento.TabIndex = 80;
            // 
            // txtModificarDescripcion
            // 
            this.txtModificarDescripcion.Location = new System.Drawing.Point(158, 87);
            this.txtModificarDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtModificarDescripcion.MaxLength = 35;
            this.txtModificarDescripcion.Name = "txtModificarDescripcion";
            this.txtModificarDescripcion.Size = new System.Drawing.Size(558, 20);
            this.txtModificarDescripcion.TabIndex = 68;
            // 
            // cboModificarEstado
            // 
            this.cboModificarEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModificarEstado.Enabled = false;
            this.cboModificarEstado.FormattingEnabled = true;
            this.cboModificarEstado.Location = new System.Drawing.Point(119, 153);
            this.cboModificarEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cboModificarEstado.Name = "cboModificarEstado";
            this.cboModificarEstado.Size = new System.Drawing.Size(192, 21);
            this.cboModificarEstado.TabIndex = 79;
            // 
            // lblModificarProduce
            // 
            this.lblModificarProduce.AutoSize = true;
            this.lblModificarProduce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarProduce.Location = new System.Drawing.Point(312, 59);
            this.lblModificarProduce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarProduce.Name = "lblModificarProduce";
            this.lblModificarProduce.Size = new System.Drawing.Size(56, 15);
            this.lblModificarProduce.TabIndex = 71;
            this.lblModificarProduce.Text = "Produce:";
            // 
            // lblModificarEstado
            // 
            this.lblModificarEstado.AutoSize = true;
            this.lblModificarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarEstado.Location = new System.Drawing.Point(64, 155);
            this.lblModificarEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarEstado.Name = "lblModificarEstado";
            this.lblModificarEstado.Size = new System.Drawing.Size(51, 15);
            this.lblModificarEstado.TabIndex = 78;
            this.lblModificarEstado.Text = "Estado: ";
            // 
            // cboModificarProduce
            // 
            this.cboModificarProduce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModificarProduce.Enabled = false;
            this.cboModificarProduce.FormattingEnabled = true;
            this.cboModificarProduce.Items.AddRange(new object[] {
            "Cereal",
            "Fruta",
            "Verdura"});
            this.cboModificarProduce.Location = new System.Drawing.Point(372, 56);
            this.cboModificarProduce.Margin = new System.Windows.Forms.Padding(2);
            this.cboModificarProduce.Name = "cboModificarProduce";
            this.cboModificarProduce.Size = new System.Drawing.Size(192, 21);
            this.cboModificarProduce.TabIndex = 70;
            // 
            // dtpModificarFechaFin
            // 
            this.dtpModificarFechaFin.CustomFormat = "dd-MM-yyyy";
            this.dtpModificarFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModificarFechaFin.Location = new System.Drawing.Point(450, 118);
            this.dtpModificarFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpModificarFechaFin.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpModificarFechaFin.Name = "dtpModificarFechaFin";
            this.dtpModificarFechaFin.Size = new System.Drawing.Size(91, 20);
            this.dtpModificarFechaFin.TabIndex = 77;
            this.dtpModificarFechaFin.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // lblModificarTipo
            // 
            this.lblModificarTipo.AutoSize = true;
            this.lblModificarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarTipo.Location = new System.Drawing.Point(64, 59);
            this.lblModificarTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarTipo.Name = "lblModificarTipo";
            this.lblModificarTipo.Size = new System.Drawing.Size(90, 15);
            this.lblModificarTipo.TabIndex = 72;
            this.lblModificarTipo.Text = "Tipo de evento:";
            // 
            // lblModificarFechaFin
            // 
            this.lblModificarFechaFin.AutoSize = true;
            this.lblModificarFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarFechaFin.Location = new System.Drawing.Point(369, 119);
            this.lblModificarFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarFechaFin.Name = "lblModificarFechaFin";
            this.lblModificarFechaFin.Size = new System.Drawing.Size(77, 15);
            this.lblModificarFechaFin.TabIndex = 76;
            this.lblModificarFechaFin.Text = "Fecha de fin:";
            // 
            // cboModificarTipo
            // 
            this.cboModificarTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModificarTipo.Enabled = false;
            this.cboModificarTipo.FormattingEnabled = true;
            this.cboModificarTipo.Location = new System.Drawing.Point(158, 56);
            this.cboModificarTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cboModificarTipo.Name = "cboModificarTipo";
            this.cboModificarTipo.Size = new System.Drawing.Size(134, 21);
            this.cboModificarTipo.TabIndex = 73;
            // 
            // lblModificarFechaIni
            // 
            this.lblModificarFechaIni.AutoSize = true;
            this.lblModificarFechaIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarFechaIni.Location = new System.Drawing.Point(171, 119);
            this.lblModificarFechaIni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarFechaIni.Name = "lblModificarFechaIni";
            this.lblModificarFechaIni.Size = new System.Drawing.Size(93, 15);
            this.lblModificarFechaIni.TabIndex = 75;
            this.lblModificarFechaIni.Text = "Fecha de inicio:";
            // 
            // dtpModificarFechaIni
            // 
            this.dtpModificarFechaIni.CustomFormat = "dd-MM-yyyy";
            this.dtpModificarFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModificarFechaIni.Location = new System.Drawing.Point(268, 118);
            this.dtpModificarFechaIni.Margin = new System.Windows.Forms.Padding(2);
            this.dtpModificarFechaIni.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpModificarFechaIni.Name = "dtpModificarFechaIni";
            this.dtpModificarFechaIni.Size = new System.Drawing.Size(91, 20);
            this.dtpModificarFechaIni.TabIndex = 74;
            this.dtpModificarFechaIni.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // lblModificarError
            // 
            this.lblModificarError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarError.ForeColor = System.Drawing.Color.Red;
            this.lblModificarError.Location = new System.Drawing.Point(15, 366);
            this.lblModificarError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarError.Name = "lblModificarError";
            this.lblModificarError.Size = new System.Drawing.Size(732, 19);
            this.lblModificarError.TabIndex = 57;
            this.lblModificarError.Text = "* Error al modificar evento *";
            this.lblModificarError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblModificarError.Visible = false;
            // 
            // lblModificarGestionado
            // 
            this.lblModificarGestionado.AutoSize = true;
            this.lblModificarGestionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarGestionado.Location = new System.Drawing.Point(349, 155);
            this.lblModificarGestionado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarGestionado.Name = "lblModificarGestionado";
            this.lblModificarGestionado.Size = new System.Drawing.Size(94, 15);
            this.lblModificarGestionado.TabIndex = 83;
            this.lblModificarGestionado.Text = "Gestionado por:";
            // 
            // txtModificarGestor
            // 
            this.txtModificarGestor.Location = new System.Drawing.Point(448, 154);
            this.txtModificarGestor.Name = "txtModificarGestor";
            this.txtModificarGestor.Size = new System.Drawing.Size(268, 20);
            this.txtModificarGestor.TabIndex = 84;
            // 
            // frmMenuProdCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(791, 500);
            this.Controls.Add(this.tabGestionarEventosPredios);
            this.Controls.Add(this.lblTituloSoporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenuProdCalendario";
            this.Text = "frmMenuProdCalendario";
            this.tabCrearEventos.ResumeLayout(false);
            this.grpSeleccionarPredioSector.ResumeLayout(false);
            this.grpSeleccionarPredioSector.PerformLayout();
            this.grpCargarEvento.ResumeLayout(false);
            this.grpCargarEvento.PerformLayout();
            this.tabGestionarEventosPredios.ResumeLayout(false);
            this.tabConsultarEventos.ResumeLayout(false);
            this.tabConsultarEventos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEventos)).EndInit();
            this.tabModificarEvento.ResumeLayout(false);
            this.grpModificarPredioSector.ResumeLayout(false);
            this.grpModificarPredioSector.PerformLayout();
            this.grpModificarEventos.ResumeLayout(false);
            this.grpModificarEventos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTituloSoporte;
        private System.Windows.Forms.TabPage tabCrearEventos;
        private System.Windows.Forms.GroupBox grpCargarEvento;
        private System.Windows.Forms.Label lblCargarEvento;
        private System.Windows.Forms.Label lblCrearInfo;
        private System.Windows.Forms.ComboBox cboCargarEvento;
        private System.Windows.Forms.TextBox txtCrearInfo;
        private System.Windows.Forms.Label lblCrearProduce;
        private System.Windows.Forms.ComboBox cboCrearTipoProduce;
        private System.Windows.Forms.DateTimePicker dtpCrearFechaFin;
        private System.Windows.Forms.Label lblCargarTipoEvento;
        private System.Windows.Forms.Label lblCrearFechaFin;
        private System.Windows.Forms.ComboBox cboCrearTipoEvento;
        private System.Windows.Forms.Label lblCrearFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpCrearFechaInicio;
        private System.Windows.Forms.Label lblCrearSector;
        private System.Windows.Forms.ComboBox cboCrearSector;
        private System.Windows.Forms.Label lblCrearPredio;
        private System.Windows.Forms.ComboBox cboCrearPredios;
        private System.Windows.Forms.Label lblCrearError;
        private System.Windows.Forms.TabControl tabGestionarEventosPredios;
        private System.Windows.Forms.Button btnSolicitarEvento;
        private System.Windows.Forms.TabPage tabModificarEvento;
        private System.Windows.Forms.GroupBox grpModificarEventos;
        private System.Windows.Forms.Button btnModificarEvento;
        private System.Windows.Forms.Label lblModificarEvento;
        private System.Windows.Forms.Label lblModificarDescripcion;
        private System.Windows.Forms.ComboBox cboModificarEvento;
        private System.Windows.Forms.TextBox txtModificarDescripcion;
        private System.Windows.Forms.ComboBox cboModificarEstado;
        private System.Windows.Forms.Label lblModificarProduce;
        private System.Windows.Forms.Label lblModificarEstado;
        private System.Windows.Forms.ComboBox cboModificarProduce;
        private System.Windows.Forms.DateTimePicker dtpModificarFechaFin;
        private System.Windows.Forms.Label lblModificarTipo;
        private System.Windows.Forms.Label lblModificarFechaFin;
        private System.Windows.Forms.ComboBox cboModificarTipo;
        private System.Windows.Forms.Label lblModificarFechaIni;
        private System.Windows.Forms.DateTimePicker dtpModificarFechaIni;
        private System.Windows.Forms.Label lblModificarSector;
        private System.Windows.Forms.ComboBox cboModificarSector;
        private System.Windows.Forms.Label lblModificarPredio;
        private System.Windows.Forms.ComboBox cboModificarPredio;
        private System.Windows.Forms.Label lblModificarError;
        private System.Windows.Forms.TabPage tabConsultarEventos;
        private System.Windows.Forms.Label lblConsultaError;
        private System.Windows.Forms.DataGridView gridEventos;
        private System.Windows.Forms.GroupBox grpModificarPredioSector;
        private System.Windows.Forms.GroupBox grpSeleccionarPredioSector;
        private System.Windows.Forms.Button btnConsultaBuscar;
        private System.Windows.Forms.Label lblConsultarPorFecha;
        private System.Windows.Forms.DateTimePicker dtpConsultarFecha;
        private System.Windows.Forms.Button btnConsultarCargarTodos;
        private System.Windows.Forms.Label lblSolicitarInfo;
        private System.Windows.Forms.TextBox txtModificarGestor;
        private System.Windows.Forms.Label lblModificarGestionado;
    }
}