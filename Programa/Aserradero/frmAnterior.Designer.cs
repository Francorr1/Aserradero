namespace Aserradero
{
    partial class frmAnterior
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnterior));
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.pbTitulo = new System.Windows.Forms.PictureBox();
            this.tabABMLPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvListadoUsuarios = new System.Windows.Forms.DataGridView();
            this.lblResultadoRegistrarUsuario = new System.Windows.Forms.Label();
            this.lblExplicacionNiveles = new System.Windows.Forms.Label();
            this.lblUsuarioNivel = new System.Windows.Forms.Label();
            this.lblUsuarioCorreo = new System.Windows.Forms.Label();
            this.lblUsuarioTelefono = new System.Windows.Forms.Label();
            this.lblUsuarioClave = new System.Windows.Forms.Label();
            this.lblUsuarioNombre = new System.Windows.Forms.Label();
            this.lblUsuarioCi = new System.Windows.Forms.Label();
            this.txtUsuarioNivel = new System.Windows.Forms.TextBox();
            this.txtUsuarioCorreo = new System.Windows.Forms.TextBox();
            this.txtUsuarioTelefono = new System.Windows.Forms.TextBox();
            this.txtUsuarioClave = new System.Windows.Forms.TextBox();
            this.txtUsuarioNombre = new System.Windows.Forms.TextBox();
            this.txtUsuarioCi = new System.Windows.Forms.TextBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).BeginInit();
            this.tabABMLPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNombre.Location = new System.Drawing.Point(9, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 25);
            this.lblNombre.TabIndex = 0;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.pnlSuperior.Controls.Add(this.btnCerrarVentana);
            this.pnlSuperior.Controls.Add(this.btnMinimizar);
            this.pnlSuperior.Controls.Add(this.pbTitulo);
            this.pnlSuperior.Location = new System.Drawing.Point(0, -1);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(802, 21);
            this.pnlSuperior.TabIndex = 1;
            this.pnlSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseMove);
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarVentana.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(29)))), ((int)(((byte)(60)))));
            this.btnCerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVentana.ForeColor = System.Drawing.Color.White;
            this.btnCerrarVentana.Location = new System.Drawing.Point(769, 3);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(24, 19);
            this.btnCerrarVentana.TabIndex = 2;
            this.btnCerrarVentana.Text = "X";
            this.btnCerrarVentana.UseVisualStyleBackColor = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(29)))), ((int)(((byte)(60)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(739, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 19);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pbTitulo
            // 
            this.pbTitulo.Enabled = false;
            this.pbTitulo.Image = ((System.Drawing.Image)(resources.GetObject("pbTitulo.Image")));
            this.pbTitulo.Location = new System.Drawing.Point(12, 3);
            this.pbTitulo.Name = "pbTitulo";
            this.pbTitulo.Size = new System.Drawing.Size(47, 17);
            this.pbTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTitulo.TabIndex = 1;
            this.pbTitulo.TabStop = false;
            // 
            // tabABMLPrincipal
            // 
            this.tabABMLPrincipal.Controls.Add(this.tabPage1);
            this.tabABMLPrincipal.Location = new System.Drawing.Point(12, 76);
            this.tabABMLPrincipal.Name = "tabABMLPrincipal";
            this.tabABMLPrincipal.SelectedIndex = 0;
            this.tabABMLPrincipal.Size = new System.Drawing.Size(776, 362);
            this.tabABMLPrincipal.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvListadoUsuarios);
            this.tabPage1.Controls.Add(this.lblResultadoRegistrarUsuario);
            this.tabPage1.Controls.Add(this.lblExplicacionNiveles);
            this.tabPage1.Controls.Add(this.lblUsuarioNivel);
            this.tabPage1.Controls.Add(this.lblUsuarioCorreo);
            this.tabPage1.Controls.Add(this.lblUsuarioTelefono);
            this.tabPage1.Controls.Add(this.lblUsuarioClave);
            this.tabPage1.Controls.Add(this.lblUsuarioNombre);
            this.tabPage1.Controls.Add(this.lblUsuarioCi);
            this.tabPage1.Controls.Add(this.txtUsuarioNivel);
            this.tabPage1.Controls.Add(this.txtUsuarioCorreo);
            this.tabPage1.Controls.Add(this.txtUsuarioTelefono);
            this.tabPage1.Controls.Add(this.txtUsuarioClave);
            this.tabPage1.Controls.Add(this.txtUsuarioNombre);
            this.tabPage1.Controls.Add(this.txtUsuarioCi);
            this.tabPage1.Controls.Add(this.btnCrearUsuario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(768, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvListadoUsuarios
            // 
            this.dgvListadoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoUsuarios.Location = new System.Drawing.Point(16, 18);
            this.dgvListadoUsuarios.Name = "dgvListadoUsuarios";
            this.dgvListadoUsuarios.Size = new System.Drawing.Size(485, 307);
            this.dgvListadoUsuarios.TabIndex = 3;
            // 
            // lblResultadoRegistrarUsuario
            // 
            this.lblResultadoRegistrarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(29)))), ((int)(((byte)(60)))));
            this.lblResultadoRegistrarUsuario.Location = new System.Drawing.Point(602, 311);
            this.lblResultadoRegistrarUsuario.Name = "lblResultadoRegistrarUsuario";
            this.lblResultadoRegistrarUsuario.Size = new System.Drawing.Size(151, 14);
            this.lblResultadoRegistrarUsuario.TabIndex = 2;
            this.lblResultadoRegistrarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblExplicacionNiveles
            // 
            this.lblExplicacionNiveles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(29)))), ((int)(((byte)(60)))));
            this.lblExplicacionNiveles.Location = new System.Drawing.Point(596, 18);
            this.lblExplicacionNiveles.Name = "lblExplicacionNiveles";
            this.lblExplicacionNiveles.Size = new System.Drawing.Size(151, 69);
            this.lblExplicacionNiveles.TabIndex = 2;
            this.lblExplicacionNiveles.Text = "Niveles De Rol:\r\n1 - Administrador Avanzado\r\n2 - Administrador Carpintería\r\n3 - A" +
    "dministrador Forestal\r\n4 - Estándar\r\n";
            this.lblExplicacionNiveles.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUsuarioNivel
            // 
            this.lblUsuarioNivel.AutoSize = true;
            this.lblUsuarioNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(29)))), ((int)(((byte)(60)))));
            this.lblUsuarioNivel.Location = new System.Drawing.Point(553, 239);
            this.lblUsuarioNivel.Name = "lblUsuarioNivel";
            this.lblUsuarioNivel.Size = new System.Drawing.Size(34, 13);
            this.lblUsuarioNivel.TabIndex = 2;
            this.lblUsuarioNivel.Text = "Nivel:";
            // 
            // lblUsuarioCorreo
            // 
            this.lblUsuarioCorreo.AutoSize = true;
            this.lblUsuarioCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(29)))), ((int)(((byte)(60)))));
            this.lblUsuarioCorreo.Location = new System.Drawing.Point(550, 213);
            this.lblUsuarioCorreo.Name = "lblUsuarioCorreo";
            this.lblUsuarioCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblUsuarioCorreo.TabIndex = 2;
            this.lblUsuarioCorreo.Text = "Correo:";
            // 
            // lblUsuarioTelefono
            // 
            this.lblUsuarioTelefono.AutoSize = true;
            this.lblUsuarioTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(29)))), ((int)(((byte)(60)))));
            this.lblUsuarioTelefono.Location = new System.Drawing.Point(544, 187);
            this.lblUsuarioTelefono.Name = "lblUsuarioTelefono";
            this.lblUsuarioTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblUsuarioTelefono.TabIndex = 2;
            this.lblUsuarioTelefono.Text = "Teléfono:";
            // 
            // lblUsuarioClave
            // 
            this.lblUsuarioClave.AutoSize = true;
            this.lblUsuarioClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(29)))), ((int)(((byte)(60)))));
            this.lblUsuarioClave.Location = new System.Drawing.Point(538, 161);
            this.lblUsuarioClave.Name = "lblUsuarioClave";
            this.lblUsuarioClave.Size = new System.Drawing.Size(64, 13);
            this.lblUsuarioClave.TabIndex = 2;
            this.lblUsuarioClave.Text = "Contraseña:";
            // 
            // lblUsuarioNombre
            // 
            this.lblUsuarioNombre.AutoSize = true;
            this.lblUsuarioNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(29)))), ((int)(((byte)(60)))));
            this.lblUsuarioNombre.Location = new System.Drawing.Point(547, 135);
            this.lblUsuarioNombre.Name = "lblUsuarioNombre";
            this.lblUsuarioNombre.Size = new System.Drawing.Size(47, 13);
            this.lblUsuarioNombre.TabIndex = 2;
            this.lblUsuarioNombre.Text = "Nombre:";
            // 
            // lblUsuarioCi
            // 
            this.lblUsuarioCi.AutoSize = true;
            this.lblUsuarioCi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(29)))), ((int)(((byte)(60)))));
            this.lblUsuarioCi.Location = new System.Drawing.Point(560, 109);
            this.lblUsuarioCi.Name = "lblUsuarioCi";
            this.lblUsuarioCi.Size = new System.Drawing.Size(20, 13);
            this.lblUsuarioCi.TabIndex = 2;
            this.lblUsuarioCi.Text = "CI:";
            // 
            // txtUsuarioNivel
            // 
            this.txtUsuarioNivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioNivel.Location = new System.Drawing.Point(605, 237);
            this.txtUsuarioNivel.MaxLength = 1;
            this.txtUsuarioNivel.Name = "txtUsuarioNivel";
            this.txtUsuarioNivel.Size = new System.Drawing.Size(141, 20);
            this.txtUsuarioNivel.TabIndex = 1;
            // 
            // txtUsuarioCorreo
            // 
            this.txtUsuarioCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioCorreo.Location = new System.Drawing.Point(605, 211);
            this.txtUsuarioCorreo.Name = "txtUsuarioCorreo";
            this.txtUsuarioCorreo.Size = new System.Drawing.Size(141, 20);
            this.txtUsuarioCorreo.TabIndex = 1;
            // 
            // txtUsuarioTelefono
            // 
            this.txtUsuarioTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioTelefono.Location = new System.Drawing.Point(605, 185);
            this.txtUsuarioTelefono.Name = "txtUsuarioTelefono";
            this.txtUsuarioTelefono.Size = new System.Drawing.Size(141, 20);
            this.txtUsuarioTelefono.TabIndex = 1;
            // 
            // txtUsuarioClave
            // 
            this.txtUsuarioClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioClave.Location = new System.Drawing.Point(605, 159);
            this.txtUsuarioClave.Name = "txtUsuarioClave";
            this.txtUsuarioClave.Size = new System.Drawing.Size(141, 20);
            this.txtUsuarioClave.TabIndex = 1;
            // 
            // txtUsuarioNombre
            // 
            this.txtUsuarioNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioNombre.Location = new System.Drawing.Point(605, 133);
            this.txtUsuarioNombre.Name = "txtUsuarioNombre";
            this.txtUsuarioNombre.Size = new System.Drawing.Size(141, 20);
            this.txtUsuarioNombre.TabIndex = 1;
            // 
            // txtUsuarioCi
            // 
            this.txtUsuarioCi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioCi.Location = new System.Drawing.Point(605, 107);
            this.txtUsuarioCi.Name = "txtUsuarioCi";
            this.txtUsuarioCi.Size = new System.Drawing.Size(141, 20);
            this.txtUsuarioCi.TabIndex = 1;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(29)))), ((int)(((byte)(60)))));
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Location = new System.Drawing.Point(624, 263);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(103, 36);
            this.btnCrearUsuario.TabIndex = 0;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabABMLPrincipal);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).EndInit();
            this.tabABMLPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Button btnCerrarVentana;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.PictureBox pbTitulo;
        private System.Windows.Forms.TabControl tabABMLPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblUsuarioNivel;
        private System.Windows.Forms.Label lblUsuarioCorreo;
        private System.Windows.Forms.Label lblUsuarioTelefono;
        private System.Windows.Forms.Label lblUsuarioClave;
        private System.Windows.Forms.Label lblUsuarioNombre;
        private System.Windows.Forms.Label lblUsuarioCi;
        private System.Windows.Forms.TextBox txtUsuarioNivel;
        private System.Windows.Forms.TextBox txtUsuarioCorreo;
        private System.Windows.Forms.TextBox txtUsuarioTelefono;
        private System.Windows.Forms.TextBox txtUsuarioClave;
        private System.Windows.Forms.TextBox txtUsuarioNombre;
        private System.Windows.Forms.TextBox txtUsuarioCi;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Label lblExplicacionNiveles;
        private System.Windows.Forms.Label lblResultadoRegistrarUsuario;
        private System.Windows.Forms.DataGridView dgvListadoUsuarios;
    }
}