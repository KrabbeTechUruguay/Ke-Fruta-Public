namespace Presentacion
{
    partial class frmLoginTipoUsuario
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
            this.btnAdministrativo = new System.Windows.Forms.Button();
            this.btnProductor = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdministrativo
            // 
            this.btnAdministrativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.btnAdministrativo.FlatAppearance.BorderSize = 2;
            this.btnAdministrativo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdministrativo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdministrativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrativo.ForeColor = System.Drawing.Color.Black;
            this.btnAdministrativo.Location = new System.Drawing.Point(143, 178);
            this.btnAdministrativo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdministrativo.Name = "btnAdministrativo";
            this.btnAdministrativo.Size = new System.Drawing.Size(285, 57);
            this.btnAdministrativo.TabIndex = 1;
            this.btnAdministrativo.Text = "ADMINISTRATIVO";
            this.btnAdministrativo.UseVisualStyleBackColor = false;
            this.btnAdministrativo.Click += new System.EventHandler(this.btnAdministrativo_Click);
            // 
            // btnProductor
            // 
            this.btnProductor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.btnProductor.FlatAppearance.BorderSize = 2;
            this.btnProductor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnProductor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnProductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductor.ForeColor = System.Drawing.Color.Black;
            this.btnProductor.Location = new System.Drawing.Point(143, 267);
            this.btnProductor.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductor.Name = "btnProductor";
            this.btnProductor.Size = new System.Drawing.Size(285, 57);
            this.btnProductor.TabIndex = 2;
            this.btnProductor.Text = "PRODUCTOR";
            this.btnProductor.UseVisualStyleBackColor = false;
            this.btnProductor.Click += new System.EventHandler(this.btnProductor_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblBienvenido.Location = new System.Drawing.Point(0, 36);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(573, 50);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSeleccionar.Location = new System.Drawing.Point(143, 119);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(285, 25);
            this.lblSeleccionar.TabIndex = 0;
            this.lblSeleccionar.Text = "Ingresar con el rol de usuario:";
            this.lblSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLoginTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(573, 369);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.btnProductor);
            this.Controls.Add(this.btnAdministrativo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginTipoUsuario";
            this.Text = "Seleccionar Usuario";
            this.Load += new System.EventHandler(this.frmLoginTipoUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdministrativo;
        private System.Windows.Forms.Button btnProductor;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblSeleccionar;
    }
}