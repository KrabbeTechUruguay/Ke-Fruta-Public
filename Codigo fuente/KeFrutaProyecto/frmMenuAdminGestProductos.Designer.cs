namespace Presentacion
{
    partial class frmMenuAdminGestProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdminGestProductos));
            this.tabModificarProductos = new System.Windows.Forms.TabControl();
            this.tabConsultarProductos = new System.Windows.Forms.TabPage();
            this.grpConsultaCargarProductos = new System.Windows.Forms.GroupBox();
            this.cboConsultaTipo = new System.Windows.Forms.ComboBox();
            this.cboConsultaCategoria = new System.Windows.Forms.ComboBox();
            this.lblConsultarTipo = new System.Windows.Forms.Label();
            this.lblConsultaCategoria = new System.Windows.Forms.Label();
            this.btnConsultarTodos = new System.Windows.Forms.Button();
            this.lblConsultaError = new System.Windows.Forms.Label();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.tabCrearProductos = new System.Windows.Forms.TabPage();
            this.grpCrearProductos = new System.Windows.Forms.GroupBox();
            this.txtCrearEventoId = new System.Windows.Forms.TextBox();
            this.lblCrearIdEvento = new System.Windows.Forms.Label();
            this.txtCrearProductorCi = new System.Windows.Forms.TextBox();
            this.lblCrearProductor = new System.Windows.Forms.Label();
            this.lblCrearTipo = new System.Windows.Forms.Label();
            this.cboCrearTipo = new System.Windows.Forms.ComboBox();
            this.numCrearCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCrearCategoria = new System.Windows.Forms.Label();
            this.cboCrearCategoria = new System.Windows.Forms.ComboBox();
            this.lblCrearCantidad = new System.Windows.Forms.Label();
            this.txtCrearPrecio = new System.Windows.Forms.TextBox();
            this.lblCrearPrecio = new System.Windows.Forms.Label();
            this.txtCrearDescripcion = new System.Windows.Forms.TextBox();
            this.lblCrearDescripcion = new System.Windows.Forms.Label();
            this.txtCrearPeso = new System.Windows.Forms.TextBox();
            this.lblCrearPeso = new System.Windows.Forms.Label();
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.txtCrearNombre = new System.Windows.Forms.TextBox();
            this.lblCrearNombre = new System.Windows.Forms.Label();
            this.picCrear = new System.Windows.Forms.PictureBox();
            this.lblCrearError = new System.Windows.Forms.Label();
            this.txtModificarPrecio = new System.Windows.Forms.TabPage();
            this.grpModificarProducto = new System.Windows.Forms.GroupBox();
            this.txtModificarEventoId = new System.Windows.Forms.TextBox();
            this.lblModificarEvento = new System.Windows.Forms.Label();
            this.txtModificarProductorCi = new System.Windows.Forms.TextBox();
            this.lblModificarProductor = new System.Windows.Forms.Label();
            this.lblModificarTipo = new System.Windows.Forms.Label();
            this.cboModificarTipo = new System.Windows.Forms.ComboBox();
            this.numModificarCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblModificarCategoria = new System.Windows.Forms.Label();
            this.cboModificarCategoria = new System.Windows.Forms.ComboBox();
            this.lblModificarCantidad = new System.Windows.Forms.Label();
            this.txtModificarPrecioi = new System.Windows.Forms.TextBox();
            this.lblModificarPrecio = new System.Windows.Forms.Label();
            this.txtModificarDescripcion = new System.Windows.Forms.TextBox();
            this.lblModificarDescripcion = new System.Windows.Forms.Label();
            this.txtModificarPeso = new System.Windows.Forms.TextBox();
            this.lblModificarPeso = new System.Windows.Forms.Label();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.txtModificarNombre = new System.Windows.Forms.TextBox();
            this.lblModificarNombre = new System.Windows.Forms.Label();
            this.picProductos = new System.Windows.Forms.PictureBox();
            this.lblModificarError = new System.Windows.Forms.Label();
            this.tabBaja = new System.Windows.Forms.TabPage();
            this.lblBajaError = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAltaProducto = new System.Windows.Forms.Button();
            this.btnBajaProducto = new System.Windows.Forms.Button();
            this.txtBajaCodigo = new System.Windows.Forms.TextBox();
            this.lblBajaCodigo = new System.Windows.Forms.Label();
            this.lblTituloSoporte = new System.Windows.Forms.Label();
            this.tabModificarProductos.SuspendLayout();
            this.tabConsultarProductos.SuspendLayout();
            this.grpConsultaCargarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.tabCrearProductos.SuspendLayout();
            this.grpCrearProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCrearCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCrear)).BeginInit();
            this.txtModificarPrecio.SuspendLayout();
            this.grpModificarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numModificarCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductos)).BeginInit();
            this.tabBaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabModificarProductos
            // 
            this.tabModificarProductos.Controls.Add(this.tabConsultarProductos);
            this.tabModificarProductos.Controls.Add(this.tabCrearProductos);
            this.tabModificarProductos.Controls.Add(this.txtModificarPrecio);
            this.tabModificarProductos.Controls.Add(this.tabBaja);
            this.tabModificarProductos.Location = new System.Drawing.Point(9, 58);
            this.tabModificarProductos.Margin = new System.Windows.Forms.Padding(2);
            this.tabModificarProductos.Name = "tabModificarProductos";
            this.tabModificarProductos.SelectedIndex = 0;
            this.tabModificarProductos.Size = new System.Drawing.Size(773, 427);
            this.tabModificarProductos.TabIndex = 9;
            // 
            // tabConsultarProductos
            // 
            this.tabConsultarProductos.Controls.Add(this.grpConsultaCargarProductos);
            this.tabConsultarProductos.Controls.Add(this.lblConsultaError);
            this.tabConsultarProductos.Controls.Add(this.gridProductos);
            this.tabConsultarProductos.Location = new System.Drawing.Point(4, 22);
            this.tabConsultarProductos.Margin = new System.Windows.Forms.Padding(2);
            this.tabConsultarProductos.Name = "tabConsultarProductos";
            this.tabConsultarProductos.Padding = new System.Windows.Forms.Padding(2);
            this.tabConsultarProductos.Size = new System.Drawing.Size(765, 401);
            this.tabConsultarProductos.TabIndex = 3;
            this.tabConsultarProductos.Text = "Consultar Productos";
            this.tabConsultarProductos.UseVisualStyleBackColor = true;
            // 
            // grpConsultaCargarProductos
            // 
            this.grpConsultaCargarProductos.Controls.Add(this.cboConsultaTipo);
            this.grpConsultaCargarProductos.Controls.Add(this.cboConsultaCategoria);
            this.grpConsultaCargarProductos.Controls.Add(this.lblConsultarTipo);
            this.grpConsultaCargarProductos.Controls.Add(this.lblConsultaCategoria);
            this.grpConsultaCargarProductos.Controls.Add(this.btnConsultarTodos);
            this.grpConsultaCargarProductos.Location = new System.Drawing.Point(18, 19);
            this.grpConsultaCargarProductos.Margin = new System.Windows.Forms.Padding(2);
            this.grpConsultaCargarProductos.Name = "grpConsultaCargarProductos";
            this.grpConsultaCargarProductos.Padding = new System.Windows.Forms.Padding(2);
            this.grpConsultaCargarProductos.Size = new System.Drawing.Size(729, 52);
            this.grpConsultaCargarProductos.TabIndex = 7;
            this.grpConsultaCargarProductos.TabStop = false;
            this.grpConsultaCargarProductos.Text = "Cargar Productos";
            // 
            // cboConsultaTipo
            // 
            this.cboConsultaTipo.FormattingEnabled = true;
            this.cboConsultaTipo.Location = new System.Drawing.Point(488, 20);
            this.cboConsultaTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cboConsultaTipo.Name = "cboConsultaTipo";
            this.cboConsultaTipo.Size = new System.Drawing.Size(206, 21);
            this.cboConsultaTipo.TabIndex = 10;
            // 
            // cboConsultaCategoria
            // 
            this.cboConsultaCategoria.FormattingEnabled = true;
            this.cboConsultaCategoria.Location = new System.Drawing.Point(200, 20);
            this.cboConsultaCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cboConsultaCategoria.Name = "cboConsultaCategoria";
            this.cboConsultaCategoria.Size = new System.Drawing.Size(206, 21);
            this.cboConsultaCategoria.TabIndex = 9;
            // 
            // lblConsultarTipo
            // 
            this.lblConsultarTipo.AutoSize = true;
            this.lblConsultarTipo.Location = new System.Drawing.Point(445, 23);
            this.lblConsultarTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsultarTipo.Name = "lblConsultarTipo";
            this.lblConsultarTipo.Size = new System.Drawing.Size(34, 13);
            this.lblConsultarTipo.TabIndex = 8;
            this.lblConsultarTipo.Text = "Tipo: ";
            // 
            // lblConsultaCategoria
            // 
            this.lblConsultaCategoria.AutoSize = true;
            this.lblConsultaCategoria.Location = new System.Drawing.Point(139, 24);
            this.lblConsultaCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsultaCategoria.Name = "lblConsultaCategoria";
            this.lblConsultaCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblConsultaCategoria.TabIndex = 7;
            this.lblConsultaCategoria.Text = "Categoria:";
            // 
            // btnConsultarTodos
            // 
            this.btnConsultarTodos.Location = new System.Drawing.Point(4, 17);
            this.btnConsultarTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarTodos.Name = "btnConsultarTodos";
            this.btnConsultarTodos.Size = new System.Drawing.Size(98, 28);
            this.btnConsultarTodos.TabIndex = 6;
            this.btnConsultarTodos.Text = "Todos";
            this.btnConsultarTodos.UseVisualStyleBackColor = true;
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
            this.lblConsultaError.Text = "* Error al cargar Productos*";
            this.lblConsultaError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblConsultaError.Visible = false;
            // 
            // gridProductos
            // 
            this.gridProductos.AllowUserToAddRows = false;
            this.gridProductos.AllowUserToDeleteRows = false;
            this.gridProductos.AllowUserToOrderColumns = true;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(18, 76);
            this.gridProductos.Margin = new System.Windows.Forms.Padding(2);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.RowHeadersWidth = 51;
            this.gridProductos.RowTemplate.Height = 24;
            this.gridProductos.Size = new System.Drawing.Size(729, 276);
            this.gridProductos.TabIndex = 5;
            // 
            // tabCrearProductos
            // 
            this.tabCrearProductos.Controls.Add(this.grpCrearProductos);
            this.tabCrearProductos.Controls.Add(this.picCrear);
            this.tabCrearProductos.Controls.Add(this.lblCrearError);
            this.tabCrearProductos.Location = new System.Drawing.Point(4, 22);
            this.tabCrearProductos.Margin = new System.Windows.Forms.Padding(2);
            this.tabCrearProductos.Name = "tabCrearProductos";
            this.tabCrearProductos.Padding = new System.Windows.Forms.Padding(2);
            this.tabCrearProductos.Size = new System.Drawing.Size(765, 401);
            this.tabCrearProductos.TabIndex = 0;
            this.tabCrearProductos.Text = "Crear Producto";
            this.tabCrearProductos.UseVisualStyleBackColor = true;
            // 
            // grpCrearProductos
            // 
            this.grpCrearProductos.Controls.Add(this.txtCrearEventoId);
            this.grpCrearProductos.Controls.Add(this.lblCrearIdEvento);
            this.grpCrearProductos.Controls.Add(this.txtCrearProductorCi);
            this.grpCrearProductos.Controls.Add(this.lblCrearProductor);
            this.grpCrearProductos.Controls.Add(this.lblCrearTipo);
            this.grpCrearProductos.Controls.Add(this.cboCrearTipo);
            this.grpCrearProductos.Controls.Add(this.numCrearCantidad);
            this.grpCrearProductos.Controls.Add(this.lblCrearCategoria);
            this.grpCrearProductos.Controls.Add(this.cboCrearCategoria);
            this.grpCrearProductos.Controls.Add(this.lblCrearCantidad);
            this.grpCrearProductos.Controls.Add(this.txtCrearPrecio);
            this.grpCrearProductos.Controls.Add(this.lblCrearPrecio);
            this.grpCrearProductos.Controls.Add(this.txtCrearDescripcion);
            this.grpCrearProductos.Controls.Add(this.lblCrearDescripcion);
            this.grpCrearProductos.Controls.Add(this.txtCrearPeso);
            this.grpCrearProductos.Controls.Add(this.lblCrearPeso);
            this.grpCrearProductos.Controls.Add(this.btnCrearProducto);
            this.grpCrearProductos.Controls.Add(this.txtCrearNombre);
            this.grpCrearProductos.Controls.Add(this.lblCrearNombre);
            this.grpCrearProductos.Location = new System.Drawing.Point(19, 13);
            this.grpCrearProductos.Margin = new System.Windows.Forms.Padding(2);
            this.grpCrearProductos.Name = "grpCrearProductos";
            this.grpCrearProductos.Padding = new System.Windows.Forms.Padding(2);
            this.grpCrearProductos.Size = new System.Drawing.Size(586, 331);
            this.grpCrearProductos.TabIndex = 60;
            this.grpCrearProductos.TabStop = false;
            this.grpCrearProductos.Text = "Datos de Producto";
            // 
            // txtCrearEventoId
            // 
            this.txtCrearEventoId.Location = new System.Drawing.Point(286, 231);
            this.txtCrearEventoId.Margin = new System.Windows.Forms.Padding(2);
            this.txtCrearEventoId.MaxLength = 8;
            this.txtCrearEventoId.Name = "txtCrearEventoId";
            this.txtCrearEventoId.Size = new System.Drawing.Size(158, 20);
            this.txtCrearEventoId.TabIndex = 30;
            // 
            // lblCrearIdEvento
            // 
            this.lblCrearIdEvento.AutoSize = true;
            this.lblCrearIdEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblCrearIdEvento.Location = new System.Drawing.Point(164, 234);
            this.lblCrearIdEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearIdEvento.Name = "lblCrearIdEvento";
            this.lblCrearIdEvento.Size = new System.Drawing.Size(126, 13);
            this.lblCrearIdEvento.TabIndex = 32;
            this.lblCrearIdEvento.Text = "Producido en evento (id):";
            // 
            // txtCrearProductorCi
            // 
            this.txtCrearProductorCi.Location = new System.Drawing.Point(232, 204);
            this.txtCrearProductorCi.Margin = new System.Windows.Forms.Padding(2);
            this.txtCrearProductorCi.MaxLength = 50;
            this.txtCrearProductorCi.Name = "txtCrearProductorCi";
            this.txtCrearProductorCi.Size = new System.Drawing.Size(235, 20);
            this.txtCrearProductorCi.TabIndex = 36;
            // 
            // lblCrearProductor
            // 
            this.lblCrearProductor.AutoSize = true;
            this.lblCrearProductor.Location = new System.Drawing.Point(164, 208);
            this.lblCrearProductor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearProductor.Name = "lblCrearProductor";
            this.lblCrearProductor.Size = new System.Drawing.Size(56, 13);
            this.lblCrearProductor.TabIndex = 35;
            this.lblCrearProductor.Text = "Productor:";
            // 
            // lblCrearTipo
            // 
            this.lblCrearTipo.AutoSize = true;
            this.lblCrearTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblCrearTipo.Location = new System.Drawing.Point(164, 83);
            this.lblCrearTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearTipo.Name = "lblCrearTipo";
            this.lblCrearTipo.Size = new System.Drawing.Size(31, 13);
            this.lblCrearTipo.TabIndex = 28;
            this.lblCrearTipo.Text = "Tipo:";
            // 
            // cboCrearTipo
            // 
            this.cboCrearTipo.FormattingEnabled = true;
            this.cboCrearTipo.Location = new System.Drawing.Point(232, 80);
            this.cboCrearTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cboCrearTipo.Name = "cboCrearTipo";
            this.cboCrearTipo.Size = new System.Drawing.Size(236, 21);
            this.cboCrearTipo.TabIndex = 27;
            // 
            // numCrearCantidad
            // 
            this.numCrearCantidad.Location = new System.Drawing.Point(232, 172);
            this.numCrearCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.numCrearCantidad.Name = "numCrearCantidad";
            this.numCrearCantidad.Size = new System.Drawing.Size(90, 20);
            this.numCrearCantidad.TabIndex = 26;
            // 
            // lblCrearCategoria
            // 
            this.lblCrearCategoria.AutoSize = true;
            this.lblCrearCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblCrearCategoria.Location = new System.Drawing.Point(164, 52);
            this.lblCrearCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearCategoria.Name = "lblCrearCategoria";
            this.lblCrearCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCrearCategoria.TabIndex = 25;
            this.lblCrearCategoria.Text = "Categoria:";
            // 
            // cboCrearCategoria
            // 
            this.cboCrearCategoria.FormattingEnabled = true;
            this.cboCrearCategoria.Location = new System.Drawing.Point(232, 50);
            this.cboCrearCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cboCrearCategoria.Name = "cboCrearCategoria";
            this.cboCrearCategoria.Size = new System.Drawing.Size(235, 21);
            this.cboCrearCategoria.TabIndex = 24;
            // 
            // lblCrearCantidad
            // 
            this.lblCrearCantidad.AutoSize = true;
            this.lblCrearCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblCrearCantidad.Location = new System.Drawing.Point(164, 176);
            this.lblCrearCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearCantidad.Name = "lblCrearCantidad";
            this.lblCrearCantidad.Size = new System.Drawing.Size(55, 13);
            this.lblCrearCantidad.TabIndex = 23;
            this.lblCrearCantidad.Text = "Cantidad: ";
            // 
            // txtCrearPrecio
            // 
            this.txtCrearPrecio.Location = new System.Drawing.Point(232, 141);
            this.txtCrearPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtCrearPrecio.MaxLength = 8;
            this.txtCrearPrecio.Name = "txtCrearPrecio";
            this.txtCrearPrecio.Size = new System.Drawing.Size(158, 20);
            this.txtCrearPrecio.TabIndex = 11;
            // 
            // lblCrearPrecio
            // 
            this.lblCrearPrecio.AutoSize = true;
            this.lblCrearPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblCrearPrecio.Location = new System.Drawing.Point(164, 142);
            this.lblCrearPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearPrecio.Name = "lblCrearPrecio";
            this.lblCrearPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblCrearPrecio.TabIndex = 12;
            this.lblCrearPrecio.Text = "Precio:";
            // 
            // txtCrearDescripcion
            // 
            this.txtCrearDescripcion.Location = new System.Drawing.Point(232, 110);
            this.txtCrearDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtCrearDescripcion.MaxLength = 50;
            this.txtCrearDescripcion.Name = "txtCrearDescripcion";
            this.txtCrearDescripcion.Size = new System.Drawing.Size(235, 20);
            this.txtCrearDescripcion.TabIndex = 16;
            // 
            // lblCrearDescripcion
            // 
            this.lblCrearDescripcion.AutoSize = true;
            this.lblCrearDescripcion.Location = new System.Drawing.Point(164, 113);
            this.lblCrearDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearDescripcion.Name = "lblCrearDescripcion";
            this.lblCrearDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lblCrearDescripcion.TabIndex = 15;
            this.lblCrearDescripcion.Text = "Descripcion: ";
            // 
            // txtCrearPeso
            // 
            this.txtCrearPeso.Location = new System.Drawing.Point(379, 172);
            this.txtCrearPeso.Margin = new System.Windows.Forms.Padding(2);
            this.txtCrearPeso.Name = "txtCrearPeso";
            this.txtCrearPeso.Size = new System.Drawing.Size(92, 20);
            this.txtCrearPeso.TabIndex = 14;
            // 
            // lblCrearPeso
            // 
            this.lblCrearPeso.AutoSize = true;
            this.lblCrearPeso.Location = new System.Drawing.Point(341, 176);
            this.lblCrearPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearPeso.Name = "lblCrearPeso";
            this.lblCrearPeso.Size = new System.Drawing.Size(34, 13);
            this.lblCrearPeso.TabIndex = 13;
            this.lblCrearPeso.Text = "Peso:";
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProducto.Location = new System.Drawing.Point(199, 275);
            this.btnCrearProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(225, 34);
            this.btnCrearProducto.TabIndex = 21;
            this.btnCrearProducto.Text = "Crear producto";
            this.btnCrearProducto.UseVisualStyleBackColor = true;
            // 
            // txtCrearNombre
            // 
            this.txtCrearNombre.Location = new System.Drawing.Point(232, 20);
            this.txtCrearNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtCrearNombre.MaxLength = 25;
            this.txtCrearNombre.Name = "txtCrearNombre";
            this.txtCrearNombre.Size = new System.Drawing.Size(235, 20);
            this.txtCrearNombre.TabIndex = 11;
            // 
            // lblCrearNombre
            // 
            this.lblCrearNombre.AutoSize = true;
            this.lblCrearNombre.Location = new System.Drawing.Point(164, 22);
            this.lblCrearNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearNombre.Name = "lblCrearNombre";
            this.lblCrearNombre.Size = new System.Drawing.Size(50, 13);
            this.lblCrearNombre.TabIndex = 10;
            this.lblCrearNombre.Text = "Nombre: ";
            // 
            // picCrear
            // 
            this.picCrear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCrear.BackgroundImage")));
            this.picCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCrear.Location = new System.Drawing.Point(609, 17);
            this.picCrear.Margin = new System.Windows.Forms.Padding(2);
            this.picCrear.Name = "picCrear";
            this.picCrear.Size = new System.Drawing.Size(138, 327);
            this.picCrear.TabIndex = 34;
            this.picCrear.TabStop = false;
            // 
            // lblCrearError
            // 
            this.lblCrearError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearError.ForeColor = System.Drawing.Color.Red;
            this.lblCrearError.Location = new System.Drawing.Point(14, 367);
            this.lblCrearError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearError.Name = "lblCrearError";
            this.lblCrearError.Size = new System.Drawing.Size(735, 19);
            this.lblCrearError.TabIndex = 25;
            this.lblCrearError.Text = "* Error al crear producto*";
            this.lblCrearError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCrearError.Visible = false;
            // 
            // txtModificarPrecio
            // 
            this.txtModificarPrecio.Controls.Add(this.grpModificarProducto);
            this.txtModificarPrecio.Controls.Add(this.picProductos);
            this.txtModificarPrecio.Controls.Add(this.lblModificarError);
            this.txtModificarPrecio.Location = new System.Drawing.Point(4, 22);
            this.txtModificarPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtModificarPrecio.Name = "txtModificarPrecio";
            this.txtModificarPrecio.Padding = new System.Windows.Forms.Padding(2);
            this.txtModificarPrecio.Size = new System.Drawing.Size(765, 401);
            this.txtModificarPrecio.TabIndex = 1;
            this.txtModificarPrecio.Text = "Modificar Producto";
            this.txtModificarPrecio.UseVisualStyleBackColor = true;
            // 
            // grpModificarProducto
            // 
            this.grpModificarProducto.Controls.Add(this.txtModificarEventoId);
            this.grpModificarProducto.Controls.Add(this.lblModificarEvento);
            this.grpModificarProducto.Controls.Add(this.txtModificarProductorCi);
            this.grpModificarProducto.Controls.Add(this.lblModificarProductor);
            this.grpModificarProducto.Controls.Add(this.lblModificarTipo);
            this.grpModificarProducto.Controls.Add(this.cboModificarTipo);
            this.grpModificarProducto.Controls.Add(this.numModificarCantidad);
            this.grpModificarProducto.Controls.Add(this.lblModificarCategoria);
            this.grpModificarProducto.Controls.Add(this.cboModificarCategoria);
            this.grpModificarProducto.Controls.Add(this.lblModificarCantidad);
            this.grpModificarProducto.Controls.Add(this.txtModificarPrecioi);
            this.grpModificarProducto.Controls.Add(this.lblModificarPrecio);
            this.grpModificarProducto.Controls.Add(this.txtModificarDescripcion);
            this.grpModificarProducto.Controls.Add(this.lblModificarDescripcion);
            this.grpModificarProducto.Controls.Add(this.txtModificarPeso);
            this.grpModificarProducto.Controls.Add(this.lblModificarPeso);
            this.grpModificarProducto.Controls.Add(this.btnModificarProducto);
            this.grpModificarProducto.Controls.Add(this.txtModificarNombre);
            this.grpModificarProducto.Controls.Add(this.lblModificarNombre);
            this.grpModificarProducto.Location = new System.Drawing.Point(19, 13);
            this.grpModificarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.grpModificarProducto.Name = "grpModificarProducto";
            this.grpModificarProducto.Padding = new System.Windows.Forms.Padding(2);
            this.grpModificarProducto.Size = new System.Drawing.Size(586, 331);
            this.grpModificarProducto.TabIndex = 63;
            this.grpModificarProducto.TabStop = false;
            this.grpModificarProducto.Text = "Datos de Producto";
            // 
            // txtModificarEventoId
            // 
            this.txtModificarEventoId.Location = new System.Drawing.Point(286, 231);
            this.txtModificarEventoId.Margin = new System.Windows.Forms.Padding(2);
            this.txtModificarEventoId.MaxLength = 8;
            this.txtModificarEventoId.Name = "txtModificarEventoId";
            this.txtModificarEventoId.Size = new System.Drawing.Size(158, 20);
            this.txtModificarEventoId.TabIndex = 30;
            // 
            // lblModificarEvento
            // 
            this.lblModificarEvento.AutoSize = true;
            this.lblModificarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblModificarEvento.Location = new System.Drawing.Point(164, 234);
            this.lblModificarEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarEvento.Name = "lblModificarEvento";
            this.lblModificarEvento.Size = new System.Drawing.Size(126, 13);
            this.lblModificarEvento.TabIndex = 32;
            this.lblModificarEvento.Text = "Producido en evento (id):";
            // 
            // txtModificarProductorCi
            // 
            this.txtModificarProductorCi.Location = new System.Drawing.Point(232, 204);
            this.txtModificarProductorCi.Margin = new System.Windows.Forms.Padding(2);
            this.txtModificarProductorCi.MaxLength = 50;
            this.txtModificarProductorCi.Name = "txtModificarProductorCi";
            this.txtModificarProductorCi.Size = new System.Drawing.Size(235, 20);
            this.txtModificarProductorCi.TabIndex = 36;
            // 
            // lblModificarProductor
            // 
            this.lblModificarProductor.AutoSize = true;
            this.lblModificarProductor.Location = new System.Drawing.Point(164, 208);
            this.lblModificarProductor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarProductor.Name = "lblModificarProductor";
            this.lblModificarProductor.Size = new System.Drawing.Size(56, 13);
            this.lblModificarProductor.TabIndex = 35;
            this.lblModificarProductor.Text = "Productor:";
            // 
            // lblModificarTipo
            // 
            this.lblModificarTipo.AutoSize = true;
            this.lblModificarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblModificarTipo.Location = new System.Drawing.Point(164, 83);
            this.lblModificarTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarTipo.Name = "lblModificarTipo";
            this.lblModificarTipo.Size = new System.Drawing.Size(31, 13);
            this.lblModificarTipo.TabIndex = 28;
            this.lblModificarTipo.Text = "Tipo:";
            // 
            // cboModificarTipo
            // 
            this.cboModificarTipo.FormattingEnabled = true;
            this.cboModificarTipo.Location = new System.Drawing.Point(232, 80);
            this.cboModificarTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cboModificarTipo.Name = "cboModificarTipo";
            this.cboModificarTipo.Size = new System.Drawing.Size(236, 21);
            this.cboModificarTipo.TabIndex = 27;
            // 
            // numModificarCantidad
            // 
            this.numModificarCantidad.Location = new System.Drawing.Point(232, 172);
            this.numModificarCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.numModificarCantidad.Name = "numModificarCantidad";
            this.numModificarCantidad.Size = new System.Drawing.Size(90, 20);
            this.numModificarCantidad.TabIndex = 26;
            // 
            // lblModificarCategoria
            // 
            this.lblModificarCategoria.AutoSize = true;
            this.lblModificarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblModificarCategoria.Location = new System.Drawing.Point(164, 52);
            this.lblModificarCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarCategoria.Name = "lblModificarCategoria";
            this.lblModificarCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblModificarCategoria.TabIndex = 25;
            this.lblModificarCategoria.Text = "Categoria:";
            // 
            // cboModificarCategoria
            // 
            this.cboModificarCategoria.FormattingEnabled = true;
            this.cboModificarCategoria.Location = new System.Drawing.Point(232, 50);
            this.cboModificarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cboModificarCategoria.Name = "cboModificarCategoria";
            this.cboModificarCategoria.Size = new System.Drawing.Size(235, 21);
            this.cboModificarCategoria.TabIndex = 24;
            // 
            // lblModificarCantidad
            // 
            this.lblModificarCantidad.AutoSize = true;
            this.lblModificarCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblModificarCantidad.Location = new System.Drawing.Point(164, 176);
            this.lblModificarCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarCantidad.Name = "lblModificarCantidad";
            this.lblModificarCantidad.Size = new System.Drawing.Size(55, 13);
            this.lblModificarCantidad.TabIndex = 23;
            this.lblModificarCantidad.Text = "Cantidad: ";
            // 
            // txtModificarPrecioi
            // 
            this.txtModificarPrecioi.Location = new System.Drawing.Point(232, 141);
            this.txtModificarPrecioi.Margin = new System.Windows.Forms.Padding(2);
            this.txtModificarPrecioi.MaxLength = 8;
            this.txtModificarPrecioi.Name = "txtModificarPrecioi";
            this.txtModificarPrecioi.Size = new System.Drawing.Size(158, 20);
            this.txtModificarPrecioi.TabIndex = 11;
            // 
            // lblModificarPrecio
            // 
            this.lblModificarPrecio.AutoSize = true;
            this.lblModificarPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblModificarPrecio.Location = new System.Drawing.Point(164, 142);
            this.lblModificarPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarPrecio.Name = "lblModificarPrecio";
            this.lblModificarPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblModificarPrecio.TabIndex = 12;
            this.lblModificarPrecio.Text = "Precio:";
            // 
            // txtModificarDescripcion
            // 
            this.txtModificarDescripcion.Location = new System.Drawing.Point(232, 110);
            this.txtModificarDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtModificarDescripcion.MaxLength = 50;
            this.txtModificarDescripcion.Name = "txtModificarDescripcion";
            this.txtModificarDescripcion.Size = new System.Drawing.Size(235, 20);
            this.txtModificarDescripcion.TabIndex = 16;
            // 
            // lblModificarDescripcion
            // 
            this.lblModificarDescripcion.AutoSize = true;
            this.lblModificarDescripcion.Location = new System.Drawing.Point(164, 113);
            this.lblModificarDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarDescripcion.Name = "lblModificarDescripcion";
            this.lblModificarDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lblModificarDescripcion.TabIndex = 15;
            this.lblModificarDescripcion.Text = "Descripcion: ";
            // 
            // txtModificarPeso
            // 
            this.txtModificarPeso.Location = new System.Drawing.Point(379, 172);
            this.txtModificarPeso.Margin = new System.Windows.Forms.Padding(2);
            this.txtModificarPeso.Name = "txtModificarPeso";
            this.txtModificarPeso.Size = new System.Drawing.Size(92, 20);
            this.txtModificarPeso.TabIndex = 14;
            // 
            // lblModificarPeso
            // 
            this.lblModificarPeso.AutoSize = true;
            this.lblModificarPeso.Location = new System.Drawing.Point(341, 176);
            this.lblModificarPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarPeso.Name = "lblModificarPeso";
            this.lblModificarPeso.Size = new System.Drawing.Size(34, 13);
            this.lblModificarPeso.TabIndex = 13;
            this.lblModificarPeso.Text = "Peso:";
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.Location = new System.Drawing.Point(199, 275);
            this.btnModificarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(225, 34);
            this.btnModificarProducto.TabIndex = 21;
            this.btnModificarProducto.Text = "Modificar producto";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // txtModificarNombre
            // 
            this.txtModificarNombre.Location = new System.Drawing.Point(232, 20);
            this.txtModificarNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtModificarNombre.MaxLength = 25;
            this.txtModificarNombre.Name = "txtModificarNombre";
            this.txtModificarNombre.Size = new System.Drawing.Size(235, 20);
            this.txtModificarNombre.TabIndex = 11;
            // 
            // lblModificarNombre
            // 
            this.lblModificarNombre.AutoSize = true;
            this.lblModificarNombre.Location = new System.Drawing.Point(164, 22);
            this.lblModificarNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarNombre.Name = "lblModificarNombre";
            this.lblModificarNombre.Size = new System.Drawing.Size(50, 13);
            this.lblModificarNombre.TabIndex = 10;
            this.lblModificarNombre.Text = "Nombre: ";
            // 
            // picProductos
            // 
            this.picProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picProductos.BackgroundImage")));
            this.picProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picProductos.Location = new System.Drawing.Point(609, 17);
            this.picProductos.Margin = new System.Windows.Forms.Padding(2);
            this.picProductos.Name = "picProductos";
            this.picProductos.Size = new System.Drawing.Size(138, 327);
            this.picProductos.TabIndex = 62;
            this.picProductos.TabStop = false;
            // 
            // lblModificarError
            // 
            this.lblModificarError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarError.ForeColor = System.Drawing.Color.Red;
            this.lblModificarError.Location = new System.Drawing.Point(16, 368);
            this.lblModificarError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarError.Name = "lblModificarError";
            this.lblModificarError.Size = new System.Drawing.Size(735, 19);
            this.lblModificarError.TabIndex = 61;
            this.lblModificarError.Text = "* Error al crear producto*";
            this.lblModificarError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblModificarError.Visible = false;
            // 
            // tabBaja
            // 
            this.tabBaja.Controls.Add(this.lblBajaError);
            this.tabBaja.Controls.Add(this.lblInfo);
            this.tabBaja.Controls.Add(this.btnAltaProducto);
            this.tabBaja.Controls.Add(this.btnBajaProducto);
            this.tabBaja.Controls.Add(this.txtBajaCodigo);
            this.tabBaja.Controls.Add(this.lblBajaCodigo);
            this.tabBaja.Location = new System.Drawing.Point(4, 22);
            this.tabBaja.Margin = new System.Windows.Forms.Padding(2);
            this.tabBaja.Name = "tabBaja";
            this.tabBaja.Size = new System.Drawing.Size(765, 401);
            this.tabBaja.TabIndex = 4;
            this.tabBaja.Text = "Baja Producto";
            this.tabBaja.UseVisualStyleBackColor = true;
            // 
            // lblBajaError
            // 
            this.lblBajaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBajaError.ForeColor = System.Drawing.Color.Red;
            this.lblBajaError.Location = new System.Drawing.Point(16, 370);
            this.lblBajaError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBajaError.Name = "lblBajaError";
            this.lblBajaError.Size = new System.Drawing.Size(735, 19);
            this.lblBajaError.TabIndex = 26;
            this.lblBajaError.Text = "* Error al dar baja a producto*";
            this.lblBajaError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBajaError.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(166, 284);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(453, 13);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Información:  Al dar de baja un producto no se eliminarán sus datos, solo se le r" +
    "estringe su uso.";
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProducto.Location = new System.Drawing.Point(434, 172);
            this.btnAltaProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(127, 28);
            this.btnAltaProducto.TabIndex = 3;
            this.btnAltaProducto.Text = "Cancelar baja";
            this.btnAltaProducto.UseVisualStyleBackColor = true;
            // 
            // btnBajaProducto
            // 
            this.btnBajaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaProducto.Location = new System.Drawing.Point(206, 172);
            this.btnBajaProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnBajaProducto.Name = "btnBajaProducto";
            this.btnBajaProducto.Size = new System.Drawing.Size(128, 28);
            this.btnBajaProducto.TabIndex = 2;
            this.btnBajaProducto.Text = "Dar de baja";
            this.btnBajaProducto.UseVisualStyleBackColor = true;
            // 
            // txtBajaCodigo
            // 
            this.txtBajaCodigo.Location = new System.Drawing.Point(302, 85);
            this.txtBajaCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBajaCodigo.MaxLength = 8;
            this.txtBajaCodigo.Name = "txtBajaCodigo";
            this.txtBajaCodigo.Size = new System.Drawing.Size(260, 20);
            this.txtBajaCodigo.TabIndex = 1;
            // 
            // lblBajaCodigo
            // 
            this.lblBajaCodigo.AutoSize = true;
            this.lblBajaCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBajaCodigo.Location = new System.Drawing.Point(206, 87);
            this.lblBajaCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBajaCodigo.Name = "lblBajaCodigo";
            this.lblBajaCodigo.Size = new System.Drawing.Size(94, 15);
            this.lblBajaCodigo.TabIndex = 0;
            this.lblBajaCodigo.Text = "Ingrese codigo: ";
            // 
            // lblTituloSoporte
            // 
            this.lblTituloSoporte.AutoSize = true;
            this.lblTituloSoporte.Font = new System.Drawing.Font("Rockwell", 16F);
            this.lblTituloSoporte.Location = new System.Drawing.Point(250, 15);
            this.lblTituloSoporte.Name = "lblTituloSoporte";
            this.lblTituloSoporte.Size = new System.Drawing.Size(326, 25);
            this.lblTituloSoporte.TabIndex = 10;
            this.lblTituloSoporte.Text = "Panel de gestion de productos";
            // 
            // frmMenuAdminGestProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(791, 500);
            this.Controls.Add(this.tabModificarProductos);
            this.Controls.Add(this.lblTituloSoporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuAdminGestProductos";
            this.Text = "FrmGestionMenu";
            this.tabModificarProductos.ResumeLayout(false);
            this.tabConsultarProductos.ResumeLayout(false);
            this.grpConsultaCargarProductos.ResumeLayout(false);
            this.grpConsultaCargarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.tabCrearProductos.ResumeLayout(false);
            this.grpCrearProductos.ResumeLayout(false);
            this.grpCrearProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCrearCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCrear)).EndInit();
            this.txtModificarPrecio.ResumeLayout(false);
            this.grpModificarProducto.ResumeLayout(false);
            this.grpModificarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numModificarCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductos)).EndInit();
            this.tabBaja.ResumeLayout(false);
            this.tabBaja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabModificarProductos;
        private System.Windows.Forms.TabPage tabConsultarProductos;
        private System.Windows.Forms.GroupBox grpConsultaCargarProductos;
        private System.Windows.Forms.ComboBox cboConsultaTipo;
        private System.Windows.Forms.ComboBox cboConsultaCategoria;
        private System.Windows.Forms.Label lblConsultarTipo;
        private System.Windows.Forms.Label lblConsultaCategoria;
        private System.Windows.Forms.Button btnConsultarTodos;
        private System.Windows.Forms.Label lblConsultaError;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.TabPage tabCrearProductos;
        private System.Windows.Forms.PictureBox picCrear;
        private System.Windows.Forms.Label lblCrearError;
        private System.Windows.Forms.TabPage txtModificarPrecio;
        private System.Windows.Forms.PictureBox picProductos;
        private System.Windows.Forms.Label lblModificarError;
        private System.Windows.Forms.TabPage tabBaja;
        private System.Windows.Forms.Label lblBajaError;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAltaProducto;
        private System.Windows.Forms.Button btnBajaProducto;
        private System.Windows.Forms.TextBox txtBajaCodigo;
        private System.Windows.Forms.Label lblBajaCodigo;
        private System.Windows.Forms.Label lblTituloSoporte;
        private System.Windows.Forms.GroupBox grpCrearProductos;
        private System.Windows.Forms.TextBox txtCrearEventoId;
        private System.Windows.Forms.Label lblCrearIdEvento;
        private System.Windows.Forms.TextBox txtCrearProductorCi;
        private System.Windows.Forms.Label lblCrearProductor;
        private System.Windows.Forms.Label lblCrearTipo;
        private System.Windows.Forms.ComboBox cboCrearTipo;
        private System.Windows.Forms.NumericUpDown numCrearCantidad;
        private System.Windows.Forms.Label lblCrearCategoria;
        private System.Windows.Forms.ComboBox cboCrearCategoria;
        private System.Windows.Forms.Label lblCrearCantidad;
        private System.Windows.Forms.TextBox txtCrearPrecio;
        private System.Windows.Forms.Label lblCrearPrecio;
        private System.Windows.Forms.TextBox txtCrearDescripcion;
        private System.Windows.Forms.Label lblCrearDescripcion;
        private System.Windows.Forms.TextBox txtCrearPeso;
        private System.Windows.Forms.Label lblCrearPeso;
        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.TextBox txtCrearNombre;
        private System.Windows.Forms.Label lblCrearNombre;
        private System.Windows.Forms.GroupBox grpModificarProducto;
        private System.Windows.Forms.TextBox txtModificarEventoId;
        private System.Windows.Forms.Label lblModificarEvento;
        private System.Windows.Forms.TextBox txtModificarProductorCi;
        private System.Windows.Forms.Label lblModificarProductor;
        private System.Windows.Forms.Label lblModificarTipo;
        private System.Windows.Forms.ComboBox cboModificarTipo;
        private System.Windows.Forms.NumericUpDown numModificarCantidad;
        private System.Windows.Forms.Label lblModificarCategoria;
        private System.Windows.Forms.ComboBox cboModificarCategoria;
        private System.Windows.Forms.Label lblModificarCantidad;
        private System.Windows.Forms.TextBox txtModificarPrecioi;
        private System.Windows.Forms.Label lblModificarPrecio;
        private System.Windows.Forms.TextBox txtModificarDescripcion;
        private System.Windows.Forms.Label lblModificarDescripcion;
        private System.Windows.Forms.TextBox txtModificarPeso;
        private System.Windows.Forms.Label lblModificarPeso;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.TextBox txtModificarNombre;
        private System.Windows.Forms.Label lblModificarNombre;
    }
}