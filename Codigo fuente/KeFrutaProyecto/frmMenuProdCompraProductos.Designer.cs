namespace Presentacion
{
    partial class frmMenuProdCompraProductos
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
            this.lblCarrito = new System.Windows.Forms.Label();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.gridCarrito = new System.Windows.Forms.DataGridView();
            this.lblComprarError = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cboSeleccionarProducto = new System.Windows.Forms.ComboBox();
            this.lblComprarInsumo = new System.Windows.Forms.Label();
            this.lblTituloSoporte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Location = new System.Drawing.Point(49, 292);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(49, 16);
            this.lblCarrito.TabIndex = 75;
            this.lblCarrito.Text = "Carrito:";
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.Location = new System.Drawing.Point(377, 465);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(300, 42);
            this.btnFinalizarCompra.TabIndex = 74;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            // 
            // gridCarrito
            // 
            this.gridCarrito.AllowUserToAddRows = false;
            this.gridCarrito.AllowUserToDeleteRows = false;
            this.gridCarrito.AllowUserToOrderColumns = true;
            this.gridCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarrito.Location = new System.Drawing.Point(45, 321);
            this.gridCarrito.Name = "gridCarrito";
            this.gridCarrito.ReadOnly = true;
            this.gridCarrito.RowHeadersWidth = 51;
            this.gridCarrito.RowTemplate.Height = 24;
            this.gridCarrito.Size = new System.Drawing.Size(972, 113);
            this.gridCarrito.TabIndex = 73;
            // 
            // lblComprarError
            // 
            this.lblComprarError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprarError.ForeColor = System.Drawing.Color.Red;
            this.lblComprarError.Location = new System.Drawing.Point(37, 565);
            this.lblComprarError.Name = "lblComprarError";
            this.lblComprarError.Size = new System.Drawing.Size(980, 23);
            this.lblComprarError.TabIndex = 72;
            this.lblComprarError.Text = "* Error al comprar producto*";
            this.lblComprarError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblComprarError.Visible = false;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(717, 190);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(300, 42);
            this.btnAgregarProducto.TabIndex = 71;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(150, 164);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 22);
            this.numCantidad.TabIndex = 70;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(60, 170);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 16);
            this.lblCantidad.TabIndex = 69;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // cboSeleccionarProducto
            // 
            this.cboSeleccionarProducto.FormattingEnabled = true;
            this.cboSeleccionarProducto.Location = new System.Drawing.Point(150, 102);
            this.cboSeleccionarProducto.Name = "cboSeleccionarProducto";
            this.cboSeleccionarProducto.Size = new System.Drawing.Size(867, 24);
            this.cboSeleccionarProducto.TabIndex = 68;
            // 
            // lblComprarInsumo
            // 
            this.lblComprarInsumo.AutoSize = true;
            this.lblComprarInsumo.Location = new System.Drawing.Point(60, 106);
            this.lblComprarInsumo.Name = "lblComprarInsumo";
            this.lblComprarInsumo.Size = new System.Drawing.Size(64, 16);
            this.lblComprarInsumo.TabIndex = 67;
            this.lblComprarInsumo.Text = "Producto:";
            // 
            // lblTituloSoporte
            // 
            this.lblTituloSoporte.AutoSize = true;
            this.lblTituloSoporte.Font = new System.Drawing.Font("Rockwell", 16F);
            this.lblTituloSoporte.Location = new System.Drawing.Point(398, 26);
            this.lblTituloSoporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloSoporte.Name = "lblTituloSoporte";
            this.lblTituloSoporte.Size = new System.Drawing.Size(255, 31);
            this.lblTituloSoporte.TabIndex = 66;
            this.lblTituloSoporte.Text = "Comprar Productos";
            // 
            // frmMenuProdCompraProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1055, 615);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.gridCarrito);
            this.Controls.Add(this.lblComprarError);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cboSeleccionarProducto);
            this.Controls.Add(this.lblComprarInsumo);
            this.Controls.Add(this.lblTituloSoporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuProdCompraProductos";
            this.Text = "fmrMenuProdCompraProductos";
            ((System.ComponentModel.ISupportInitialize)(this.gridCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.DataGridView gridCarrito;
        private System.Windows.Forms.Label lblComprarError;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cboSeleccionarProducto;
        private System.Windows.Forms.Label lblComprarInsumo;
        private System.Windows.Forms.Label lblTituloSoporte;
    }
}