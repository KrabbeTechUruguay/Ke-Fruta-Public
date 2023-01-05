namespace Presentacion
{
    partial class frmMenuProdPredios
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
            this.tabFertilizarPredio = new System.Windows.Forms.TabControl();
            this.tabConsultarPredios = new System.Windows.Forms.TabPage();
            this.grpConsultarSectores = new System.Windows.Forms.GroupBox();
            this.gridSectores = new System.Windows.Forms.DataGridView();
            this.grpConsultaCargarPredios = new System.Windows.Forms.GroupBox();
            this.cboConsultarPredios = new System.Windows.Forms.ComboBox();
            this.lblConsultaError = new System.Windows.Forms.Label();
            this.tabFertilizacion = new System.Windows.Forms.TabPage();
            this.btnCalcularFertilizante = new System.Windows.Forms.Button();
            this.lblFertilizacionEquivalenteFertilizante = new System.Windows.Forms.Label();
            this.lblFertilizacionNivelCritico = new System.Windows.Forms.Label();
            this.lblFertilizacionNitratoSuelo = new System.Windows.Forms.Label();
            this.lblFertilizacionNitrogenoPlanta = new System.Windows.Forms.Label();
            this.lblFertilizacionFosforoSuelo = new System.Windows.Forms.Label();
            this.lblFertilizacionNitrogenoSuelo = new System.Windows.Forms.Label();
            this.lblFertilizacionEstadioZ = new System.Windows.Forms.Label();
            this.txtFertilizacionEquivalenteFertilizante = new System.Windows.Forms.TextBox();
            this.txtFertilizacionNivelCritico = new System.Windows.Forms.TextBox();
            this.txtFertilizacionNitrotoSuelo = new System.Windows.Forms.TextBox();
            this.txtFertilizacionNitrogenoPlanta = new System.Windows.Forms.TextBox();
            this.txtFertilizacionNitrogenoSuelo = new System.Windows.Forms.TextBox();
            this.txtFertilizacionFosforoSuelo = new System.Windows.Forms.TextBox();
            this.txtFertilizacionEstadioZ = new System.Windows.Forms.TextBox();
            this.lblFertilizacionFecha = new System.Windows.Forms.Label();
            this.dtpFertilizacionFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFertilizacionEvento = new System.Windows.Forms.Label();
            this.lblFertilizacionSector = new System.Windows.Forms.Label();
            this.cboFertilizacionEvento = new System.Windows.Forms.ComboBox();
            this.cboFertilizacionSector = new System.Windows.Forms.ComboBox();
            this.lblFertilizacionPredio = new System.Windows.Forms.Label();
            this.cboFertilizacionPredio = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTituloSoporte = new System.Windows.Forms.Label();
            this.tabFertilizarPredio.SuspendLayout();
            this.tabConsultarPredios.SuspendLayout();
            this.grpConsultarSectores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSectores)).BeginInit();
            this.grpConsultaCargarPredios.SuspendLayout();
            this.tabFertilizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFertilizarPredio
            // 
            this.tabFertilizarPredio.Controls.Add(this.tabConsultarPredios);
            this.tabFertilizarPredio.Controls.Add(this.tabFertilizacion);
            this.tabFertilizarPredio.Location = new System.Drawing.Point(3, 49);
            this.tabFertilizarPredio.Name = "tabFertilizarPredio";
            this.tabFertilizarPredio.SelectedIndex = 0;
            this.tabFertilizarPredio.Size = new System.Drawing.Size(1031, 516);
            this.tabFertilizarPredio.TabIndex = 7;
            // 
            // tabConsultarPredios
            // 
            this.tabConsultarPredios.Controls.Add(this.grpConsultarSectores);
            this.tabConsultarPredios.Controls.Add(this.grpConsultaCargarPredios);
            this.tabConsultarPredios.Controls.Add(this.lblConsultaError);
            this.tabConsultarPredios.Location = new System.Drawing.Point(4, 25);
            this.tabConsultarPredios.Name = "tabConsultarPredios";
            this.tabConsultarPredios.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultarPredios.Size = new System.Drawing.Size(1023, 487);
            this.tabConsultarPredios.TabIndex = 3;
            this.tabConsultarPredios.Text = "Consultar Predios";
            this.tabConsultarPredios.UseVisualStyleBackColor = true;
            // 
            // grpConsultarSectores
            // 
            this.grpConsultarSectores.Controls.Add(this.gridSectores);
            this.grpConsultarSectores.Location = new System.Drawing.Point(24, 91);
            this.grpConsultarSectores.Name = "grpConsultarSectores";
            this.grpConsultarSectores.Size = new System.Drawing.Size(972, 338);
            this.grpConsultarSectores.TabIndex = 60;
            this.grpConsultarSectores.TabStop = false;
            this.grpConsultarSectores.Text = "Sectores";
            // 
            // gridSectores
            // 
            this.gridSectores.AllowUserToAddRows = false;
            this.gridSectores.AllowUserToDeleteRows = false;
            this.gridSectores.AllowUserToOrderColumns = true;
            this.gridSectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSectores.Location = new System.Drawing.Point(14, 21);
            this.gridSectores.Name = "gridSectores";
            this.gridSectores.ReadOnly = true;
            this.gridSectores.RowHeadersWidth = 51;
            this.gridSectores.RowTemplate.Height = 24;
            this.gridSectores.Size = new System.Drawing.Size(942, 300);
            this.gridSectores.TabIndex = 58;
            // 
            // grpConsultaCargarPredios
            // 
            this.grpConsultaCargarPredios.Controls.Add(this.cboConsultarPredios);
            this.grpConsultaCargarPredios.Location = new System.Drawing.Point(24, 20);
            this.grpConsultaCargarPredios.Name = "grpConsultaCargarPredios";
            this.grpConsultaCargarPredios.Size = new System.Drawing.Size(972, 64);
            this.grpConsultaCargarPredios.TabIndex = 59;
            this.grpConsultaCargarPredios.TabStop = false;
            this.grpConsultaCargarPredios.Text = "Cargar Predios";
            // 
            // cboConsultarPredios
            // 
            this.cboConsultarPredios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsultarPredios.FormattingEnabled = true;
            this.cboConsultarPredios.Location = new System.Drawing.Point(23, 26);
            this.cboConsultarPredios.Name = "cboConsultarPredios";
            this.cboConsultarPredios.Size = new System.Drawing.Size(925, 24);
            this.cboConsultarPredios.TabIndex = 0;
            this.cboConsultarPredios.SelectedIndexChanged += new System.EventHandler(this.cboConsultarPredios_SelectedIndexChanged);
            // 
            // lblConsultaError
            // 
            this.lblConsultaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaError.ForeColor = System.Drawing.Color.Red;
            this.lblConsultaError.Location = new System.Drawing.Point(20, 450);
            this.lblConsultaError.Name = "lblConsultaError";
            this.lblConsultaError.Size = new System.Drawing.Size(976, 23);
            this.lblConsultaError.TabIndex = 57;
            this.lblConsultaError.Text = "* Error al cargar predios *";
            this.lblConsultaError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblConsultaError.Visible = false;
            // 
            // tabFertilizacion
            // 
            this.tabFertilizacion.Controls.Add(this.btnCalcularFertilizante);
            this.tabFertilizacion.Controls.Add(this.lblFertilizacionEquivalenteFertilizante);
            this.tabFertilizacion.Controls.Add(this.lblFertilizacionNivelCritico);
            this.tabFertilizacion.Controls.Add(this.lblFertilizacionNitratoSuelo);
            this.tabFertilizacion.Controls.Add(this.lblFertilizacionNitrogenoPlanta);
            this.tabFertilizacion.Controls.Add(this.lblFertilizacionFosforoSuelo);
            this.tabFertilizacion.Controls.Add(this.lblFertilizacionNitrogenoSuelo);
            this.tabFertilizacion.Controls.Add(this.lblFertilizacionEstadioZ);
            this.tabFertilizacion.Controls.Add(this.txtFertilizacionEquivalenteFertilizante);
            this.tabFertilizacion.Controls.Add(this.txtFertilizacionNivelCritico);
            this.tabFertilizacion.Controls.Add(this.txtFertilizacionNitrotoSuelo);
            this.tabFertilizacion.Controls.Add(this.txtFertilizacionNitrogenoPlanta);
            this.tabFertilizacion.Controls.Add(this.txtFertilizacionNitrogenoSuelo);
            this.tabFertilizacion.Controls.Add(this.txtFertilizacionFosforoSuelo);
            this.tabFertilizacion.Controls.Add(this.txtFertilizacionEstadioZ);
            this.tabFertilizacion.Controls.Add(this.lblFertilizacionFecha);
            this.tabFertilizacion.Controls.Add(this.dtpFertilizacionFecha);
            this.tabFertilizacion.Controls.Add(this.lblFertilizacionEvento);
            this.tabFertilizacion.Controls.Add(this.lblFertilizacionSector);
            this.tabFertilizacion.Controls.Add(this.cboFertilizacionEvento);
            this.tabFertilizacion.Controls.Add(this.cboFertilizacionSector);
            this.tabFertilizacion.Controls.Add(this.lblFertilizacionPredio);
            this.tabFertilizacion.Controls.Add(this.cboFertilizacionPredio);
            this.tabFertilizacion.Controls.Add(this.label11);
            this.tabFertilizacion.Location = new System.Drawing.Point(4, 25);
            this.tabFertilizacion.Name = "tabFertilizacion";
            this.tabFertilizacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabFertilizacion.Size = new System.Drawing.Size(1023, 487);
            this.tabFertilizacion.TabIndex = 8;
            this.tabFertilizacion.Text = "Fertilizacion";
            this.tabFertilizacion.UseVisualStyleBackColor = true;
            // 
            // btnCalcularFertilizante
            // 
            this.btnCalcularFertilizante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularFertilizante.Location = new System.Drawing.Point(365, 389);
            this.btnCalcularFertilizante.Name = "btnCalcularFertilizante";
            this.btnCalcularFertilizante.Size = new System.Drawing.Size(300, 42);
            this.btnCalcularFertilizante.TabIndex = 104;
            this.btnCalcularFertilizante.Text = "Calcular Fertilizante";
            this.btnCalcularFertilizante.UseVisualStyleBackColor = true;
            // 
            // lblFertilizacionEquivalenteFertilizante
            // 
            this.lblFertilizacionEquivalenteFertilizante.AutoSize = true;
            this.lblFertilizacionEquivalenteFertilizante.Location = new System.Drawing.Point(370, 349);
            this.lblFertilizacionEquivalenteFertilizante.Name = "lblFertilizacionEquivalenteFertilizante";
            this.lblFertilizacionEquivalenteFertilizante.Size = new System.Drawing.Size(158, 16);
            this.lblFertilizacionEquivalenteFertilizante.TabIndex = 103;
            this.lblFertilizacionEquivalenteFertilizante.Text = "Equivalente en fertilizante";
            // 
            // lblFertilizacionNivelCritico
            // 
            this.lblFertilizacionNivelCritico.AutoSize = true;
            this.lblFertilizacionNivelCritico.Location = new System.Drawing.Point(606, 289);
            this.lblFertilizacionNivelCritico.Name = "lblFertilizacionNivelCritico";
            this.lblFertilizacionNivelCritico.Size = new System.Drawing.Size(76, 16);
            this.lblFertilizacionNivelCritico.TabIndex = 102;
            this.lblFertilizacionNivelCritico.Text = "Nivel critico";
            // 
            // lblFertilizacionNitratoSuelo
            // 
            this.lblFertilizacionNitratoSuelo.AutoSize = true;
            this.lblFertilizacionNitratoSuelo.Location = new System.Drawing.Point(189, 289);
            this.lblFertilizacionNitratoSuelo.Name = "lblFertilizacionNitratoSuelo";
            this.lblFertilizacionNitratoSuelo.Size = new System.Drawing.Size(100, 16);
            this.lblFertilizacionNitratoSuelo.TabIndex = 101;
            this.lblFertilizacionNitratoSuelo.Text = "Nitrato en suelo";
            // 
            // lblFertilizacionNitrogenoPlanta
            // 
            this.lblFertilizacionNitrogenoPlanta.AutoSize = true;
            this.lblFertilizacionNitrogenoPlanta.Location = new System.Drawing.Point(558, 247);
            this.lblFertilizacionNitrogenoPlanta.Name = "lblFertilizacionNitrogenoPlanta";
            this.lblFertilizacionNitrogenoPlanta.Size = new System.Drawing.Size(124, 16);
            this.lblFertilizacionNitrogenoPlanta.TabIndex = 100;
            this.lblFertilizacionNitrogenoPlanta.Text = "Nitrogeno en planta";
            // 
            // lblFertilizacionFosforoSuelo
            // 
            this.lblFertilizacionFosforoSuelo.AutoSize = true;
            this.lblFertilizacionFosforoSuelo.Location = new System.Drawing.Point(182, 243);
            this.lblFertilizacionFosforoSuelo.Name = "lblFertilizacionFosforoSuelo";
            this.lblFertilizacionFosforoSuelo.Size = new System.Drawing.Size(107, 16);
            this.lblFertilizacionFosforoSuelo.TabIndex = 99;
            this.lblFertilizacionFosforoSuelo.Text = "Fosforo en suelo";
            // 
            // lblFertilizacionNitrogenoSuelo
            // 
            this.lblFertilizacionNitrogenoSuelo.AutoSize = true;
            this.lblFertilizacionNitrogenoSuelo.Location = new System.Drawing.Point(562, 201);
            this.lblFertilizacionNitrogenoSuelo.Name = "lblFertilizacionNitrogenoSuelo";
            this.lblFertilizacionNitrogenoSuelo.Size = new System.Drawing.Size(120, 16);
            this.lblFertilizacionNitrogenoSuelo.TabIndex = 98;
            this.lblFertilizacionNitrogenoSuelo.Text = "Nitrogeno en suelo";
            // 
            // lblFertilizacionEstadioZ
            // 
            this.lblFertilizacionEstadioZ.AutoSize = true;
            this.lblFertilizacionEstadioZ.Location = new System.Drawing.Point(225, 202);
            this.lblFertilizacionEstadioZ.Name = "lblFertilizacionEstadioZ";
            this.lblFertilizacionEstadioZ.Size = new System.Drawing.Size(64, 16);
            this.lblFertilizacionEstadioZ.TabIndex = 97;
            this.lblFertilizacionEstadioZ.Text = "Estadio Z";
            // 
            // txtFertilizacionEquivalenteFertilizante
            // 
            this.txtFertilizacionEquivalenteFertilizante.Location = new System.Drawing.Point(534, 346);
            this.txtFertilizacionEquivalenteFertilizante.Name = "txtFertilizacionEquivalenteFertilizante";
            this.txtFertilizacionEquivalenteFertilizante.Size = new System.Drawing.Size(120, 22);
            this.txtFertilizacionEquivalenteFertilizante.TabIndex = 96;
            // 
            // txtFertilizacionNivelCritico
            // 
            this.txtFertilizacionNivelCritico.Location = new System.Drawing.Point(706, 286);
            this.txtFertilizacionNivelCritico.Name = "txtFertilizacionNivelCritico";
            this.txtFertilizacionNivelCritico.Size = new System.Drawing.Size(120, 22);
            this.txtFertilizacionNivelCritico.TabIndex = 95;
            // 
            // txtFertilizacionNitrotoSuelo
            // 
            this.txtFertilizacionNitrotoSuelo.Location = new System.Drawing.Point(309, 286);
            this.txtFertilizacionNitrotoSuelo.Name = "txtFertilizacionNitrotoSuelo";
            this.txtFertilizacionNitrotoSuelo.Size = new System.Drawing.Size(120, 22);
            this.txtFertilizacionNitrotoSuelo.TabIndex = 94;
            // 
            // txtFertilizacionNitrogenoPlanta
            // 
            this.txtFertilizacionNitrogenoPlanta.Location = new System.Drawing.Point(706, 243);
            this.txtFertilizacionNitrogenoPlanta.Name = "txtFertilizacionNitrogenoPlanta";
            this.txtFertilizacionNitrogenoPlanta.Size = new System.Drawing.Size(120, 22);
            this.txtFertilizacionNitrogenoPlanta.TabIndex = 93;
            // 
            // txtFertilizacionNitrogenoSuelo
            // 
            this.txtFertilizacionNitrogenoSuelo.Location = new System.Drawing.Point(706, 199);
            this.txtFertilizacionNitrogenoSuelo.Name = "txtFertilizacionNitrogenoSuelo";
            this.txtFertilizacionNitrogenoSuelo.Size = new System.Drawing.Size(120, 22);
            this.txtFertilizacionNitrogenoSuelo.TabIndex = 92;
            // 
            // txtFertilizacionFosforoSuelo
            // 
            this.txtFertilizacionFosforoSuelo.Location = new System.Drawing.Point(309, 240);
            this.txtFertilizacionFosforoSuelo.Name = "txtFertilizacionFosforoSuelo";
            this.txtFertilizacionFosforoSuelo.Size = new System.Drawing.Size(120, 22);
            this.txtFertilizacionFosforoSuelo.TabIndex = 91;
            // 
            // txtFertilizacionEstadioZ
            // 
            this.txtFertilizacionEstadioZ.Location = new System.Drawing.Point(309, 197);
            this.txtFertilizacionEstadioZ.Name = "txtFertilizacionEstadioZ";
            this.txtFertilizacionEstadioZ.Size = new System.Drawing.Size(120, 22);
            this.txtFertilizacionEstadioZ.TabIndex = 90;
            // 
            // lblFertilizacionFecha
            // 
            this.lblFertilizacionFecha.AutoSize = true;
            this.lblFertilizacionFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFertilizacionFecha.Location = new System.Drawing.Point(86, 155);
            this.lblFertilizacionFecha.Name = "lblFertilizacionFecha";
            this.lblFertilizacionFecha.Size = new System.Drawing.Size(151, 18);
            this.lblFertilizacionFecha.TabIndex = 89;
            this.lblFertilizacionFecha.Text = "Fecha de fertilizacion:";
            // 
            // dtpFertilizacionFecha
            // 
            this.dtpFertilizacionFecha.CustomFormat = "dd-MM-yyyy";
            this.dtpFertilizacionFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFertilizacionFecha.Location = new System.Drawing.Point(260, 154);
            this.dtpFertilizacionFecha.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpFertilizacionFecha.Name = "dtpFertilizacionFecha";
            this.dtpFertilizacionFecha.Size = new System.Drawing.Size(120, 22);
            this.dtpFertilizacionFecha.TabIndex = 88;
            this.dtpFertilizacionFecha.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // lblFertilizacionEvento
            // 
            this.lblFertilizacionEvento.AutoSize = true;
            this.lblFertilizacionEvento.Location = new System.Drawing.Point(19, 117);
            this.lblFertilizacionEvento.Name = "lblFertilizacionEvento";
            this.lblFertilizacionEvento.Size = new System.Drawing.Size(52, 16);
            this.lblFertilizacionEvento.TabIndex = 81;
            this.lblFertilizacionEvento.Text = "Evento:";
            // 
            // lblFertilizacionSector
            // 
            this.lblFertilizacionSector.AutoSize = true;
            this.lblFertilizacionSector.Location = new System.Drawing.Point(19, 73);
            this.lblFertilizacionSector.Name = "lblFertilizacionSector";
            this.lblFertilizacionSector.Size = new System.Drawing.Size(49, 16);
            this.lblFertilizacionSector.TabIndex = 87;
            this.lblFertilizacionSector.Text = "Sector:";
            // 
            // cboFertilizacionEvento
            // 
            this.cboFertilizacionEvento.FormattingEnabled = true;
            this.cboFertilizacionEvento.Location = new System.Drawing.Point(89, 114);
            this.cboFertilizacionEvento.Name = "cboFertilizacionEvento";
            this.cboFertilizacionEvento.Size = new System.Drawing.Size(916, 24);
            this.cboFertilizacionEvento.TabIndex = 80;
            // 
            // cboFertilizacionSector
            // 
            this.cboFertilizacionSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFertilizacionSector.FormattingEnabled = true;
            this.cboFertilizacionSector.Location = new System.Drawing.Point(89, 70);
            this.cboFertilizacionSector.Name = "cboFertilizacionSector";
            this.cboFertilizacionSector.Size = new System.Drawing.Size(916, 24);
            this.cboFertilizacionSector.TabIndex = 86;
            // 
            // lblFertilizacionPredio
            // 
            this.lblFertilizacionPredio.AutoSize = true;
            this.lblFertilizacionPredio.Location = new System.Drawing.Point(18, 29);
            this.lblFertilizacionPredio.Name = "lblFertilizacionPredio";
            this.lblFertilizacionPredio.Size = new System.Drawing.Size(50, 16);
            this.lblFertilizacionPredio.TabIndex = 85;
            this.lblFertilizacionPredio.Text = "Predio:";
            // 
            // cboFertilizacionPredio
            // 
            this.cboFertilizacionPredio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFertilizacionPredio.FormattingEnabled = true;
            this.cboFertilizacionPredio.Location = new System.Drawing.Point(89, 26);
            this.cboFertilizacionPredio.Name = "cboFertilizacionPredio";
            this.cboFertilizacionPredio.Size = new System.Drawing.Size(916, 24);
            this.cboFertilizacionPredio.TabIndex = 84;
            this.cboFertilizacionPredio.SelectedIndexChanged += new System.EventHandler(this.cboFertilizacionPredio_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(29, 455);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(976, 23);
            this.label11.TabIndex = 83;
            this.label11.Text = "* Error al cargar predios *";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Visible = false;
            // 
            // lblTituloSoporte
            // 
            this.lblTituloSoporte.AutoSize = true;
            this.lblTituloSoporte.Font = new System.Drawing.Font("Rockwell", 16F);
            this.lblTituloSoporte.Location = new System.Drawing.Point(430, 9);
            this.lblTituloSoporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloSoporte.Name = "lblTituloSoporte";
            this.lblTituloSoporte.Size = new System.Drawing.Size(160, 31);
            this.lblTituloSoporte.TabIndex = 8;
            this.lblTituloSoporte.Text = "Mis predios";
            // 
            // frmMenuProdPredios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1037, 568);
            this.Controls.Add(this.tabFertilizarPredio);
            this.Controls.Add(this.lblTituloSoporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuProdPredios";
            this.Text = "frmMenuProdPredios";
            this.tabFertilizarPredio.ResumeLayout(false);
            this.tabConsultarPredios.ResumeLayout(false);
            this.grpConsultarSectores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSectores)).EndInit();
            this.grpConsultaCargarPredios.ResumeLayout(false);
            this.tabFertilizacion.ResumeLayout(false);
            this.tabFertilizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabFertilizarPredio;
        private System.Windows.Forms.TabPage tabConsultarPredios;
        private System.Windows.Forms.Label lblConsultaError;
        private System.Windows.Forms.Label lblTituloSoporte;
        private System.Windows.Forms.GroupBox grpConsultarSectores;
        private System.Windows.Forms.DataGridView gridSectores;
        private System.Windows.Forms.GroupBox grpConsultaCargarPredios;
        private System.Windows.Forms.ComboBox cboConsultarPredios;
        private System.Windows.Forms.TabPage tabFertilizacion;
        private System.Windows.Forms.Button btnCalcularFertilizante;
        private System.Windows.Forms.Label lblFertilizacionEquivalenteFertilizante;
        private System.Windows.Forms.Label lblFertilizacionNivelCritico;
        private System.Windows.Forms.Label lblFertilizacionNitratoSuelo;
        private System.Windows.Forms.Label lblFertilizacionNitrogenoPlanta;
        private System.Windows.Forms.Label lblFertilizacionFosforoSuelo;
        private System.Windows.Forms.Label lblFertilizacionNitrogenoSuelo;
        private System.Windows.Forms.Label lblFertilizacionEstadioZ;
        private System.Windows.Forms.TextBox txtFertilizacionEquivalenteFertilizante;
        private System.Windows.Forms.TextBox txtFertilizacionNivelCritico;
        private System.Windows.Forms.TextBox txtFertilizacionNitrotoSuelo;
        private System.Windows.Forms.TextBox txtFertilizacionNitrogenoPlanta;
        private System.Windows.Forms.TextBox txtFertilizacionNitrogenoSuelo;
        private System.Windows.Forms.TextBox txtFertilizacionFosforoSuelo;
        private System.Windows.Forms.TextBox txtFertilizacionEstadioZ;
        private System.Windows.Forms.Label lblFertilizacionFecha;
        private System.Windows.Forms.DateTimePicker dtpFertilizacionFecha;
        private System.Windows.Forms.Label lblFertilizacionEvento;
        private System.Windows.Forms.Label lblFertilizacionSector;
        private System.Windows.Forms.ComboBox cboFertilizacionEvento;
        private System.Windows.Forms.ComboBox cboFertilizacionSector;
        private System.Windows.Forms.Label lblFertilizacionPredio;
        private System.Windows.Forms.ComboBox cboFertilizacionPredio;
        private System.Windows.Forms.Label label11;
    }
}