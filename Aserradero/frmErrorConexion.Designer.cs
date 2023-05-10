namespace Aserradero
{
    partial class frmErrorConexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmErrorConexion));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.pbTitulo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.pnlSuperior.Controls.Add(this.btnCerrarVentana);
            this.pnlSuperior.Controls.Add(this.pbTitulo);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(465, 19);
            this.pnlSuperior.TabIndex = 3;
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarVentana.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(29)))), ((int)(((byte)(60)))));
            this.btnCerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVentana.ForeColor = System.Drawing.Color.White;
            this.btnCerrarVentana.Location = new System.Drawing.Point(438, 0);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(24, 19);
            this.btnCerrarVentana.TabIndex = 2;
            this.btnCerrarVentana.Text = "X";
            this.btnCerrarVentana.UseVisualStyleBackColor = false;
            // 
            // pbTitulo
            // 
            this.pbTitulo.Enabled = false;
            this.pbTitulo.Image = ((System.Drawing.Image)(resources.GetObject("pbTitulo.Image")));
            this.pbTitulo.Location = new System.Drawing.Point(12, 0);
            this.pbTitulo.Name = "pbTitulo";
            this.pbTitulo.Size = new System.Drawing.Size(47, 17);
            this.pbTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTitulo.TabIndex = 1;
            this.pbTitulo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 103);
            this.panel1.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(378, 87);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "No se puede conectar con la base de datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Inténtelo de nuevo más tarde";
            // 
            // frmErrorConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 122);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmErrorConexion";
            this.Text = "frmErrorConexion";
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Button btnCerrarVentana;
        private System.Windows.Forms.PictureBox pbTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}