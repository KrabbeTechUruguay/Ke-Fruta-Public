namespace Presentacion
{
    partial class frmMenuProdCompraInsumos
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
            this.cboSeleccionarInsumo = new System.Windows.Forms.ComboBox();
            this.lblComprarInsumo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarInsumo = new System.Windows.Forms.Button();
            this.lblComprarError = new System.Windows.Forms.Label();
            this.gridCarrito = new System.Windows.Forms.DataGridView();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.lblCarrito = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloSoporte
            // 
            this.lblTituloSoporte.AutoSize = true;
            this.lblTituloSoporte.Font = new System.Drawing.Font("Rockwell", 16F);
            this.lblTituloSoporte.Location = new System.Drawing.Point(391, 22);
            this.lblTituloSoporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloSoporte.Name = "lblTituloSoporte";
            this.lblTituloSoporte.Size = new System.Drawing.Size(233, 31);
            this.lblTituloSoporte.TabIndex = 5;
            this.lblTituloSoporte.Text = "Comprar Insumos";
            // 
            // cboSeleccionarInsumo
            // 
            this.cboSeleccionarInsumo.FormattingEnabled = true;
            this.cboSeleccionarInsumo.Location = new System.Drawing.Point(143, 98);
            this.cboSeleccionarInsumo.Name = "cboSeleccionarInsumo";
            this.cboSeleccionarInsumo.Size = new System.Drawing.Size(867, 24);
            this.cboSeleccionarInsumo.TabIndex = 11;
            // 
            // lblComprarInsumo
            // 
            this.lblComprarInsumo.AutoSize = true;
            this.lblComprarInsumo.Location = new System.Drawing.Point(53, 102);
            this.lblComprarInsumo.Name = "lblComprarInsumo";
            this.lblComprarInsumo.Size = new System.Drawing.Size(53, 16);
            this.lblComprarInsumo.TabIndex = 10;
            this.lblComprarInsumo.Text = "Inusmo:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(53, 166);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 16);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(143, 160);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 22);
            this.numCantidad.TabIndex = 13;
            // 
            // btnAgregarInsumo
            // 
            this.btnAgregarInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInsumo.Location = new System.Drawing.Point(710, 186);
            this.btnAgregarInsumo.Name = "btnAgregarInsumo";
            this.btnAgregarInsumo.Size = new System.Drawing.Size(300, 42);
            this.btnAgregarInsumo.TabIndex = 22;
            this.btnAgregarInsumo.Text = "Agregar";
            this.btnAgregarInsumo.UseVisualStyleBackColor = true;
            // 
            // lblComprarError
            // 
            this.lblComprarError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprarError.ForeColor = System.Drawing.Color.Red;
            this.lblComprarError.Location = new System.Drawing.Point(30, 561);
            this.lblComprarError.Name = "lblComprarError";
            this.lblComprarError.Size = new System.Drawing.Size(980, 23);
            this.lblComprarError.TabIndex = 62;
            this.lblComprarError.Text = "* Error al comprar insumo *";
            this.lblComprarError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblComprarError.Visible = false;
            // 
            // gridCarrito
            // 
            this.gridCarrito.AllowUserToAddRows = false;
            this.gridCarrito.AllowUserToDeleteRows = false;
            this.gridCarrito.AllowUserToOrderColumns = true;
            this.gridCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarrito.Location = new System.Drawing.Point(38, 317);
            this.gridCarrito.Name = "gridCarrito";
            this.gridCarrito.ReadOnly = true;
            this.gridCarrito.RowHeadersWidth = 51;
            this.gridCarrito.RowTemplate.Height = 24;
            this.gridCarrito.Size = new System.Drawing.Size(972, 113);
            this.gridCarrito.TabIndex = 63;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.Location = new System.Drawing.Point(370, 461);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(300, 42);
            this.btnFinalizarCompra.TabIndex = 64;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Location = new System.Drawing.Point(42, 288);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(49, 16);
            this.lblCarrito.TabIndex = 65;
            this.lblCarrito.Text = "Carrito:";
            // 
            // frmMenuProdCompraInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1055, 615);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.gridCarrito);
            this.Controls.Add(this.lblComprarError);
            this.Controls.Add(this.btnAgregarInsumo);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cboSeleccionarInsumo);
            this.Controls.Add(this.lblComprarInsumo);
            this.Controls.Add(this.lblTituloSoporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuProdCompraInsumos";
            this.Text = "frmMenuProdCompraInsumos";
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloSoporte;
        private System.Windows.Forms.ComboBox cboSeleccionarInsumo;
        private System.Windows.Forms.Label lblComprarInsumo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnAgregarInsumo;
        private System.Windows.Forms.Label lblComprarError;
        private System.Windows.Forms.DataGridView gridCarrito;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Label lblCarrito;
    }
}