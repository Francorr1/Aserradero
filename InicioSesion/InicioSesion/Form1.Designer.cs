namespace InicioSesion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbCosoco = new System.Windows.Forms.PictureBox();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.pbUtu = new System.Windows.Forms.PictureBox();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbTitulo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblInciarSesion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCosoco)).BeginInit();
            this.pnlInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUtu)).BeginInit();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCosoco
            // 
            this.pbCosoco.Image = ((System.Drawing.Image)(resources.GetObject("pbCosoco.Image")));
            this.pbCosoco.Location = new System.Drawing.Point(12, 3);
            this.pbCosoco.Name = "pbCosoco";
            this.pbCosoco.Size = new System.Drawing.Size(70, 41);
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
            this.pnlInferior.Location = new System.Drawing.Point(0, 224);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(288, 47);
            this.pnlInferior.TabIndex = 9;
            // 
            // pbUtu
            // 
            this.pbUtu.Image = ((System.Drawing.Image)(resources.GetObject("pbUtu.Image")));
            this.pbUtu.Location = new System.Drawing.Point(205, 3);
            this.pbUtu.Margin = new System.Windows.Forms.Padding(10);
            this.pbUtu.Name = "pbUtu";
            this.pbUtu.Padding = new System.Windows.Forms.Padding(5);
            this.pbUtu.Size = new System.Drawing.Size(69, 41);
            this.pbUtu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUtu.TabIndex = 8;
            this.pbUtu.TabStop = false;
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.pnlBarraTitulo.Controls.Add(this.pictureBox5);
            this.pnlBarraTitulo.Controls.Add(this.pictureBox4);
            this.pnlBarraTitulo.Controls.Add(this.pbTitulo);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(288, 19);
            this.pnlBarraTitulo.TabIndex = 10;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(224, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(254, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pbTitulo
            // 
            this.pbTitulo.Image = ((System.Drawing.Image)(resources.GetObject("pbTitulo.Image")));
            this.pbTitulo.Location = new System.Drawing.Point(12, 2);
            this.pbTitulo.Name = "pbTitulo";
            this.pbTitulo.Size = new System.Drawing.Size(47, 17);
            this.pbTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTitulo.TabIndex = 0;
            this.pbTitulo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnContinuar);
            this.panel3.Controls.Add(this.lblContraseña);
            this.panel3.Controls.Add(this.txtContraseña);
            this.panel3.Controls.Add(this.lblCedula);
            this.panel3.Controls.Add(this.txtCedula);
            this.panel3.Controls.Add(this.lblInciarSesion);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 205);
            this.panel3.TabIndex = 11;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.btnContinuar.Location = new System.Drawing.Point(14, 161);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(260, 26);
            this.btnContinuar.TabIndex = 7;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.lblContraseña.Location = new System.Drawing.Point(14, 107);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(76, 20);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblContraseña.UseCompatibleTextRendering = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtContraseña.Location = new System.Drawing.Point(14, 130);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(260, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.lblCedula.Location = new System.Drawing.Point(14, 48);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(49, 20);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "Cédula";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCedula.UseCompatibleTextRendering = true;
            // 
            // txtCedula
            // 
            this.txtCedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCedula.Location = new System.Drawing.Point(14, 71);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(260, 20);
            this.txtCedula.TabIndex = 1;
            // 
            // lblInciarSesion
            // 
            this.lblInciarSesion.AutoSize = true;
            this.lblInciarSesion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblInciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.lblInciarSesion.Location = new System.Drawing.Point(0, 0);
            this.lblInciarSesion.Name = "lblInciarSesion";
            this.lblInciarSesion.Padding = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.lblInciarSesion.Size = new System.Drawing.Size(132, 44);
            this.lblInciarSesion.TabIndex = 0;
            this.lblInciarSesion.Text = "Iniciar sesión";
            this.lblInciarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInciarSesion.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(288, 271);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.pnlInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pbCosoco)).EndInit();
            this.pnlInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUtu)).EndInit();
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbCosoco;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.PictureBox pbUtu;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblInciarSesion;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.PictureBox pbTitulo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

