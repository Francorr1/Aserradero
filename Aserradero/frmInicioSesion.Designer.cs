namespace Aserradero
{
    partial class frmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pbTitulo = new System.Windows.Forms.PictureBox();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.lblErrorInicio = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblInciarSesion = new System.Windows.Forms.Label();
            this.pbUtu = new System.Windows.Forms.PictureBox();
            this.pbCosoco = new System.Windows.Forms.PictureBox();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).BeginInit();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUtu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCosoco)).BeginInit();
            this.pnlInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.pnlSuperior.Controls.Add(this.pictureBox1);
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Controls.Add(this.pbTitulo);
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(384, 23);
            this.pnlSuperior.TabIndex = 0;
            this.pnlSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(337, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(43, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbTitulo
            // 
            this.pbTitulo.Enabled = false;
            this.pbTitulo.Image = ((System.Drawing.Image)(resources.GetObject("pbTitulo.Image")));
            this.pbTitulo.Location = new System.Drawing.Point(16, 0);
            this.pbTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbTitulo.Name = "pbTitulo";
            this.pbTitulo.Size = new System.Drawing.Size(63, 21);
            this.pbTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTitulo.TabIndex = 1;
            this.pbTitulo.TabStop = false;
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.White;
            this.pnlFondo.Controls.Add(this.btnContinuar);
            this.pnlFondo.Controls.Add(this.lblErrorInicio);
            this.pnlFondo.Controls.Add(this.lblClave);
            this.pnlFondo.Controls.Add(this.txtClave);
            this.pnlFondo.Controls.Add(this.lblCedula);
            this.pnlFondo.Controls.Add(this.txtCedula);
            this.pnlFondo.Controls.Add(this.lblInciarSesion);
            this.pnlFondo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pnlFondo.Location = new System.Drawing.Point(0, 23);
            this.pnlFondo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(384, 252);
            this.pnlFondo.TabIndex = 12;
            // 
            // btnContinuar
            // 
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.btnContinuar.Location = new System.Drawing.Point(19, 198);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(347, 32);
            this.btnContinuar.TabIndex = 7;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // lblErrorInicio
            // 
            this.lblErrorInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.lblErrorInicio.Location = new System.Drawing.Point(19, 231);
            this.lblErrorInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorInicio.Name = "lblErrorInicio";
            this.lblErrorInicio.Size = new System.Drawing.Size(347, 25);
            this.lblErrorInicio.TabIndex = 4;
            this.lblErrorInicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblErrorInicio.UseCompatibleTextRendering = true;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.lblClave.Location = new System.Drawing.Point(19, 132);
            this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(95, 24);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Contraseña";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblClave.UseCompatibleTextRendering = true;
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtClave.Location = new System.Drawing.Point(19, 160);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '✱';
            this.txtClave.Size = new System.Drawing.Size(345, 22);
            this.txtClave.TabIndex = 3;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.lblCedula.Location = new System.Drawing.Point(19, 59);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(61, 24);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "Cédula";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCedula.UseCompatibleTextRendering = true;
            // 
            // txtCedula
            // 
            this.txtCedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCedula.Location = new System.Drawing.Point(19, 87);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(345, 22);
            this.txtCedula.TabIndex = 1;
            // 
            // lblInciarSesion
            // 
            this.lblInciarSesion.AutoSize = true;
            this.lblInciarSesion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblInciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.lblInciarSesion.Location = new System.Drawing.Point(0, 0);
            this.lblInciarSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInciarSesion.Name = "lblInciarSesion";
            this.lblInciarSesion.Padding = new System.Windows.Forms.Padding(7, 18, 0, 0);
            this.lblInciarSesion.Size = new System.Drawing.Size(166, 53);
            this.lblInciarSesion.TabIndex = 0;
            this.lblInciarSesion.Text = "Iniciar sesión";
            this.lblInciarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInciarSesion.UseCompatibleTextRendering = true;
            // 
            // pbUtu
            // 
            this.pbUtu.Image = ((System.Drawing.Image)(resources.GetObject("pbUtu.Image")));
            this.pbUtu.Location = new System.Drawing.Point(273, 4);
            this.pbUtu.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pbUtu.Name = "pbUtu";
            this.pbUtu.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pbUtu.Size = new System.Drawing.Size(92, 50);
            this.pbUtu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUtu.TabIndex = 8;
            this.pbUtu.TabStop = false;
            // 
            // pbCosoco
            // 
            this.pbCosoco.Image = ((System.Drawing.Image)(resources.GetObject("pbCosoco.Image")));
            this.pbCosoco.Location = new System.Drawing.Point(16, 4);
            this.pbCosoco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCosoco.Name = "pbCosoco";
            this.pbCosoco.Size = new System.Drawing.Size(93, 50);
            this.pbCosoco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCosoco.TabIndex = 7;
            this.pbCosoco.TabStop = false;
            // 
            // pnlInferior
            // 
            this.pnlInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.pnlInferior.Controls.Add(this.pbUtu);
            this.pnlInferior.Controls.Add(this.pbCosoco);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 276);
            this.pnlInferior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(384, 58);
            this.pnlInferior.TabIndex = 13;
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(384, 334);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlFondo);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).EndInit();
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUtu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCosoco)).EndInit();
            this.pnlInferior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.PictureBox pbTitulo;
        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblInciarSesion;
        private System.Windows.Forms.PictureBox pbUtu;
        private System.Windows.Forms.PictureBox pbCosoco;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Label lblErrorInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}

