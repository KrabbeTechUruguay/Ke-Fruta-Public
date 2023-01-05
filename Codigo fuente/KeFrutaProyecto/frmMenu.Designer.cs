namespace Presentacion
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnlMenuCambiarCuenta = new System.Windows.Forms.Panel();
            this.lblCambiarCuenta = new System.Windows.Forms.Label();
            this.lblNombreRol = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.pnlSuperiorMenu = new System.Windows.Forms.Panel();
            this.picHerramientas = new System.Windows.Forms.PictureBox();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.pnlMostrarMenu = new System.Windows.Forms.Panel();
            this.pnlMenuCambiarCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.pnlSuperiorMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHerramientas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuCambiarCuenta
            // 
            this.pnlMenuCambiarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.pnlMenuCambiarCuenta.Controls.Add(this.lblCambiarCuenta);
            this.pnlMenuCambiarCuenta.Controls.Add(this.lblNombreRol);
            this.pnlMenuCambiarCuenta.Controls.Add(this.lblNombreUsuario);
            this.pnlMenuCambiarCuenta.Controls.Add(this.picUser);
            this.pnlMenuCambiarCuenta.Location = new System.Drawing.Point(0, 573);
            this.pnlMenuCambiarCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuCambiarCuenta.Name = "pnlMenuCambiarCuenta";
            this.pnlMenuCambiarCuenta.Size = new System.Drawing.Size(277, 104);
            this.pnlMenuCambiarCuenta.TabIndex = 0;
            // 
            // lblCambiarCuenta
            // 
            this.lblCambiarCuenta.AutoSize = true;
            this.lblCambiarCuenta.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblCambiarCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCambiarCuenta.Font = new System.Drawing.Font("Rockwell", 10.15F, System.Drawing.FontStyle.Bold);
            this.lblCambiarCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.lblCambiarCuenta.Location = new System.Drawing.Point(102, 68);
            this.lblCambiarCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCambiarCuenta.Name = "lblCambiarCuenta";
            this.lblCambiarCuenta.Size = new System.Drawing.Size(146, 20);
            this.lblCambiarCuenta.TabIndex = 10;
            this.lblCambiarCuenta.Text = "Cambiar cuenta";
            this.lblCambiarCuenta.Click += new System.EventHandler(this.lblCambiarCuenta_Click);
            // 
            // lblNombreRol
            // 
            this.lblNombreRol.AutoSize = true;
            this.lblNombreRol.Font = new System.Drawing.Font("Rockwell", 10F);
            this.lblNombreRol.ForeColor = System.Drawing.Color.Black;
            this.lblNombreRol.Location = new System.Drawing.Point(102, 36);
            this.lblNombreRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreRol.Name = "lblNombreRol";
            this.lblNombreRol.Size = new System.Drawing.Size(73, 20);
            this.lblNombreRol.TabIndex = 12;
            this.lblNombreRol.Text = "Rango...";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Rockwell", 11F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblNombreUsuario.Location = new System.Drawing.Point(102, 15);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(96, 21);
            this.lblNombreUsuario.TabIndex = 11;
            this.lblNombreUsuario.Text = "Usuario...";
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(4, 15);
            this.picUser.Margin = new System.Windows.Forms.Padding(4);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(89, 75);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 10;
            this.picUser.TabStop = false;
            // 
            // pnlSuperiorMenu
            // 
            this.pnlSuperiorMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.pnlSuperiorMenu.Controls.Add(this.picHerramientas);
            this.pnlSuperiorMenu.Controls.Add(this.lblNombreEmpresa);
            this.pnlSuperiorMenu.Controls.Add(this.picMinimizar);
            this.pnlSuperiorMenu.Controls.Add(this.picCerrar);
            this.pnlSuperiorMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSuperiorMenu.Name = "pnlSuperiorMenu";
            this.pnlSuperiorMenu.Size = new System.Drawing.Size(1336, 62);
            this.pnlSuperiorMenu.TabIndex = 2;
            // 
            // picHerramientas
            // 
            this.picHerramientas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHerramientas.Image = ((System.Drawing.Image)(resources.GetObject("picHerramientas.Image")));
            this.picHerramientas.Location = new System.Drawing.Point(9, 9);
            this.picHerramientas.Margin = new System.Windows.Forms.Padding(4);
            this.picHerramientas.Name = "picHerramientas";
            this.picHerramientas.Size = new System.Drawing.Size(47, 43);
            this.picHerramientas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHerramientas.TabIndex = 4;
            this.picHerramientas.TabStop = false;
            this.picHerramientas.Click += new System.EventHandler(this.picHerramientas_Click);
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.lblNombreEmpresa.Location = new System.Drawing.Point(519, 11);
            this.lblNombreEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(294, 35);
            this.lblNombreEmpresa.TabIndex = 0;
            this.lblNombreEmpresa.Text = "Coperativa Ke Fruta";
            // 
            // picMinimizar
            // 
            this.picMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picMinimizar.Image")));
            this.picMinimizar.Location = new System.Drawing.Point(1221, 9);
            this.picMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(44, 41);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimizar.TabIndex = 2;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // picCerrar
            // 
            this.picCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picCerrar.Image")));
            this.picCerrar.Location = new System.Drawing.Point(1273, 9);
            this.picCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(44, 41);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 1;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // pnlMostrarMenu
            // 
            this.pnlMostrarMenu.Location = new System.Drawing.Point(0, 62);
            this.pnlMostrarMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMostrarMenu.Name = "pnlMostrarMenu";
            this.pnlMostrarMenu.Size = new System.Drawing.Size(1332, 615);
            this.pnlMostrarMenu.TabIndex = 0;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1333, 677);
            this.Controls.Add(this.pnlMenuCambiarCuenta);
            this.Controls.Add(this.pnlMostrarMenu);
            this.Controls.Add(this.pnlSuperiorMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                            ";
            this.pnlMenuCambiarCuenta.ResumeLayout(false);
            this.pnlMenuCambiarCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.pnlSuperiorMenu.ResumeLayout(false);
            this.pnlSuperiorMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHerramientas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuCambiarCuenta;
        private System.Windows.Forms.Panel pnlSuperiorMenu;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Panel pnlMostrarMenu;
        private System.Windows.Forms.PictureBox picHerramientas;
        private System.Windows.Forms.Label lblCambiarCuenta;
        private System.Windows.Forms.Label lblNombreRol;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox picUser;
    }
}