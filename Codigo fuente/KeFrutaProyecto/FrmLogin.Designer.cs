namespace Presentacion
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlLateralLogin = new System.Windows.Forms.Panel();
            this.lblNombrEmpresa2 = new System.Windows.Forms.Label();
            this.lblNombrEmpresa = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.picMostrarContra = new System.Windows.Forms.PictureBox();
            this.pnlLoginMenu = new System.Windows.Forms.Panel();
            this.pnlLateralLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarContra)).BeginInit();
            this.pnlLoginMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLateralLogin
            // 
            this.pnlLateralLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.pnlLateralLogin.Controls.Add(this.lblNombrEmpresa2);
            this.pnlLateralLogin.Controls.Add(this.lblNombrEmpresa);
            this.pnlLateralLogin.Controls.Add(this.picLogo);
            this.pnlLateralLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateralLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLateralLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLateralLogin.Name = "pnlLateralLogin";
            this.pnlLateralLogin.Size = new System.Drawing.Size(267, 369);
            this.pnlLateralLogin.TabIndex = 0;
            this.pnlLateralLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlLateral_MouseDown);
            // 
            // lblNombrEmpresa2
            // 
            this.lblNombrEmpresa2.AutoSize = true;
            this.lblNombrEmpresa2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrEmpresa2.Location = new System.Drawing.Point(77, 238);
            this.lblNombrEmpresa2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrEmpresa2.Name = "lblNombrEmpresa2";
            this.lblNombrEmpresa2.Size = new System.Drawing.Size(104, 27);
            this.lblNombrEmpresa2.TabIndex = 0;
            this.lblNombrEmpresa2.Text = "Ke Fruta";
            // 
            // lblNombrEmpresa
            // 
            this.lblNombrEmpresa.AutoSize = true;
            this.lblNombrEmpresa.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrEmpresa.Location = new System.Drawing.Point(64, 212);
            this.lblNombrEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrEmpresa.Name = "lblNombrEmpresa";
            this.lblNombrEmpresa.Size = new System.Drawing.Size(136, 27);
            this.lblNombrEmpresa.TabIndex = 0;
            this.lblNombrEmpresa.Text = "Coperativa";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(69, 76);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(133, 123);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Silver;
            this.txtUser.Location = new System.Drawing.Point(62, 110);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(453, 33);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "USUARIO";
            this.txtUser.Enter += new System.EventHandler(this.TxtUser_Enter);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUser_KeyPress);
            this.txtUser.Leave += new System.EventHandler(this.TxtUser_Leave);
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPwd.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.ForeColor = System.Drawing.Color.Silver;
            this.txtPwd.Location = new System.Drawing.Point(62, 180);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(451, 33);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.Text = "CONTRASEÑA";
            this.txtPwd.Enter += new System.EventHandler(this.TxtPwd_Enter);
            this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPwd_KeyPress);
            this.txtPwd.Leave += new System.EventHandler(this.TxtPwd_Leave);
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblIniciarSesion.Location = new System.Drawing.Point(143, 44);
            this.lblIniciarSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(283, 36);
            this.lblIniciarSesion.TabIndex = 0;
            this.lblIniciarSesion.Text = "Inicio de Sesion";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 2;
            this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.Location = new System.Drawing.Point(139, 267);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(285, 57);
            this.btnIniciarSesion.TabIndex = 0;
            this.btnIniciarSesion.Text = "ACCEDER";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // picCerrar
            // 
            this.picCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picCerrar.Image")));
            this.picCerrar.Location = new System.Drawing.Point(531, 14);
            this.picCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(27, 25);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 6;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.PicCerrar_Click);
            // 
            // picMinimizar
            // 
            this.picMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picMinimizar.Image")));
            this.picMinimizar.Location = new System.Drawing.Point(481, 14);
            this.picMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(27, 25);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimizar.TabIndex = 7;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.PicMinimizar_Click);
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(8, 229);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(552, 27);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "*Usuario o contraseña incorrecta. *";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // picMostrarContra
            // 
            this.picMostrarContra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMostrarContra.Image = ((System.Drawing.Image)(resources.GetObject("picMostrarContra.Image")));
            this.picMostrarContra.Location = new System.Drawing.Point(484, 186);
            this.picMostrarContra.Margin = new System.Windows.Forms.Padding(4);
            this.picMostrarContra.Name = "picMostrarContra";
            this.picMostrarContra.Size = new System.Drawing.Size(24, 22);
            this.picMostrarContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMostrarContra.TabIndex = 9;
            this.picMostrarContra.TabStop = false;
            this.picMostrarContra.Click += new System.EventHandler(this.PicMostrarContra_Click);
            // 
            // pnlLoginMenu
            // 
            this.pnlLoginMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoginMenu.Controls.Add(this.lblIniciarSesion);
            this.pnlLoginMenu.Controls.Add(this.picMostrarContra);
            this.pnlLoginMenu.Controls.Add(this.txtUser);
            this.pnlLoginMenu.Controls.Add(this.lblError);
            this.pnlLoginMenu.Controls.Add(this.txtPwd);
            this.pnlLoginMenu.Controls.Add(this.picMinimizar);
            this.pnlLoginMenu.Controls.Add(this.btnIniciarSesion);
            this.pnlLoginMenu.Controls.Add(this.picCerrar);
            this.pnlLoginMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlLoginMenu.Location = new System.Drawing.Point(267, 0);
            this.pnlLoginMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLoginMenu.Name = "pnlLoginMenu";
            this.pnlLoginMenu.Size = new System.Drawing.Size(573, 369);
            this.pnlLoginMenu.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(840, 369);
            this.Controls.Add(this.pnlLoginMenu);
            this.Controls.Add(this.pnlLateralLogin);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.pnlLateralLogin.ResumeLayout(false);
            this.pnlLateralLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarContra)).EndInit();
            this.pnlLoginMenu.ResumeLayout(false);
            this.pnlLoginMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLateralLogin;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNombrEmpresa2;
        private System.Windows.Forms.Label lblNombrEmpresa;
        private System.Windows.Forms.PictureBox picMostrarContra;
        public System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel pnlLoginMenu;
    }
}

