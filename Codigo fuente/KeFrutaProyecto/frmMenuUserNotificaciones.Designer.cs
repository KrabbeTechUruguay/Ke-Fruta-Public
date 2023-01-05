namespace Presentacion
{
    partial class frmMenuUserNotificaciones
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
            this.lblNotificacionError = new System.Windows.Forms.Label();
            this.gridNotificaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloSoporte
            // 
            this.lblTituloSoporte.AutoSize = true;
            this.lblTituloSoporte.Font = new System.Drawing.Font("Rockwell", 16F);
            this.lblTituloSoporte.Location = new System.Drawing.Point(407, 22);
            this.lblTituloSoporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloSoporte.Name = "lblTituloSoporte";
            this.lblTituloSoporte.Size = new System.Drawing.Size(187, 31);
            this.lblTituloSoporte.TabIndex = 59;
            this.lblTituloSoporte.Text = "Notificaciones";
            // 
            // lblNotificacionError
            // 
            this.lblNotificacionError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacionError.ForeColor = System.Drawing.Color.Red;
            this.lblNotificacionError.Location = new System.Drawing.Point(39, 567);
            this.lblNotificacionError.Name = "lblNotificacionError";
            this.lblNotificacionError.Size = new System.Drawing.Size(976, 23);
            this.lblNotificacionError.TabIndex = 60;
            this.lblNotificacionError.Text = "* Error al cargar notificaciones*";
            this.lblNotificacionError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNotificacionError.Visible = false;
            // 
            // gridNotificaciones
            // 
            this.gridNotificaciones.AllowUserToAddRows = false;
            this.gridNotificaciones.AllowUserToDeleteRows = false;
            this.gridNotificaciones.AllowUserToOrderColumns = true;
            this.gridNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNotificaciones.Location = new System.Drawing.Point(43, 74);
            this.gridNotificaciones.Name = "gridNotificaciones";
            this.gridNotificaciones.ReadOnly = true;
            this.gridNotificaciones.RowHeadersWidth = 51;
            this.gridNotificaciones.RowTemplate.Height = 24;
            this.gridNotificaciones.Size = new System.Drawing.Size(972, 470);
            this.gridNotificaciones.TabIndex = 58;
            // 
            // frmMenuUserNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1055, 615);
            this.Controls.Add(this.lblTituloSoporte);
            this.Controls.Add(this.lblNotificacionError);
            this.Controls.Add(this.gridNotificaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenuUserNotificaciones";
            this.Text = "FrmUsuarioMenu";
            ((System.ComponentModel.ISupportInitialize)(this.gridNotificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloSoporte;
        private System.Windows.Forms.Label lblNotificacionError;
        private System.Windows.Forms.DataGridView gridNotificaciones;
    }
}