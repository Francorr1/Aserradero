namespace VentanaPrincipal1
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pbCosocoTitulo = new System.Windows.Forms.PictureBox();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnEspecies = new System.Windows.Forms.Button();
            this.btnRodales = new System.Windows.Forms.Button();
            this.lblCincuentas = new System.Windows.Forms.Label();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.pbUtu = new System.Windows.Forms.PictureBox();
            this.pbCosoco = new System.Windows.Forms.PictureBox();
            this.btnTrozas = new System.Windows.Forms.Button();
            this.btnAlmacenaje = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnTemporizador = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.pnlPedidos = new System.Windows.Forms.Panel();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnAltaPedido = new System.Windows.Forms.Button();
            this.btnBajaPedido = new System.Windows.Forms.Button();
            this.btnModificarPedido = new System.Windows.Forms.Button();
            this.btnListarPedido = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCosocoTitulo)).BeginInit();
            this.pnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUtu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCosoco)).BeginInit();
            this.pnlPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.pnlTitulo.Controls.Add(this.btnMinimizar);
            this.pnlTitulo.Controls.Add(this.btnCerrar);
            this.pnlTitulo.Controls.Add(this.pbCosocoTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(837, 19);
            this.pnlTitulo.TabIndex = 11;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(775, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 19);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(805, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 19);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbCosocoTitulo
            // 
            this.pbCosocoTitulo.Image = ((System.Drawing.Image)(resources.GetObject("pbCosocoTitulo.Image")));
            this.pbCosocoTitulo.Location = new System.Drawing.Point(12, 2);
            this.pbCosocoTitulo.Name = "pbCosocoTitulo";
            this.pbCosocoTitulo.Size = new System.Drawing.Size(47, 17);
            this.pbCosocoTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCosocoTitulo.TabIndex = 0;
            this.pbCosocoTitulo.TabStop = false;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(16)))), ((int)(((byte)(37)))));
            this.pnlLateral.Controls.Add(this.btnAjustes);
            this.pnlLateral.Controls.Add(this.btnTemporizador);
            this.pnlLateral.Controls.Add(this.btnStock);
            this.pnlLateral.Controls.Add(this.btnProducto);
            this.pnlLateral.Controls.Add(this.btnAlmacenaje);
            this.pnlLateral.Controls.Add(this.btnTrozas);
            this.pnlLateral.Controls.Add(this.btnEspecies);
            this.pnlLateral.Controls.Add(this.btnRodales);
            this.pnlLateral.Controls.Add(this.lblCincuentas);
            this.pnlLateral.Controls.Add(this.btnPedidos);
            this.pnlLateral.Controls.Add(this.pbUtu);
            this.pnlLateral.Controls.Add(this.pbCosoco);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 19);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(182, 488);
            this.pnlLateral.TabIndex = 12;
            // 
            // btnEspecies
            // 
            this.btnEspecies.Location = new System.Drawing.Point(12, 122);
            this.btnEspecies.Name = "btnEspecies";
            this.btnEspecies.Size = new System.Drawing.Size(160, 25);
            this.btnEspecies.TabIndex = 12;
            this.btnEspecies.Text = "Especies";
            this.btnEspecies.UseVisualStyleBackColor = true;
            // 
            // btnRodales
            // 
            this.btnRodales.Location = new System.Drawing.Point(12, 91);
            this.btnRodales.Name = "btnRodales";
            this.btnRodales.Size = new System.Drawing.Size(160, 25);
            this.btnRodales.TabIndex = 11;
            this.btnRodales.Text = "Rodales";
            this.btnRodales.UseVisualStyleBackColor = true;
            this.btnRodales.Click += new System.EventHandler(this.btnRodales_Click);
            // 
            // lblCincuentas
            // 
            this.lblCincuentas.AutoSize = true;
            this.lblCincuentas.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCincuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCincuentas.ForeColor = System.Drawing.Color.White;
            this.lblCincuentas.Location = new System.Drawing.Point(0, 0);
            this.lblCincuentas.Name = "lblCincuentas";
            this.lblCincuentas.Padding = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.lblCincuentas.Size = new System.Drawing.Size(131, 44);
            this.lblCincuentas.TabIndex = 10;
            this.lblCincuentas.Text = "Cincuentas®";
            this.lblCincuentas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCincuentas.UseCompatibleTextRendering = true;
            // 
            // btnPedidos
            // 
            this.btnPedidos.Location = new System.Drawing.Point(12, 60);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(160, 25);
            this.btnPedidos.TabIndex = 9;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pbUtu
            // 
            this.pbUtu.Image = ((System.Drawing.Image)(resources.GetObject("pbUtu.Image")));
            this.pbUtu.Location = new System.Drawing.Point(103, 435);
            this.pbUtu.Margin = new System.Windows.Forms.Padding(10);
            this.pbUtu.Name = "pbUtu";
            this.pbUtu.Padding = new System.Windows.Forms.Padding(5);
            this.pbUtu.Size = new System.Drawing.Size(69, 41);
            this.pbUtu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUtu.TabIndex = 8;
            this.pbUtu.TabStop = false;
            // 
            // pbCosoco
            // 
            this.pbCosoco.Image = ((System.Drawing.Image)(resources.GetObject("pbCosoco.Image")));
            this.pbCosoco.Location = new System.Drawing.Point(12, 435);
            this.pbCosoco.Name = "pbCosoco";
            this.pbCosoco.Size = new System.Drawing.Size(70, 41);
            this.pbCosoco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCosoco.TabIndex = 7;
            this.pbCosoco.TabStop = false;
            // 
            // btnTrozas
            // 
            this.btnTrozas.Location = new System.Drawing.Point(12, 153);
            this.btnTrozas.Name = "btnTrozas";
            this.btnTrozas.Size = new System.Drawing.Size(160, 25);
            this.btnTrozas.TabIndex = 13;
            this.btnTrozas.Text = "Tipos de trozas";
            this.btnTrozas.UseVisualStyleBackColor = true;
            // 
            // btnAlmacenaje
            // 
            this.btnAlmacenaje.Location = new System.Drawing.Point(12, 184);
            this.btnAlmacenaje.Name = "btnAlmacenaje";
            this.btnAlmacenaje.Size = new System.Drawing.Size(160, 25);
            this.btnAlmacenaje.TabIndex = 14;
            this.btnAlmacenaje.Text = "Lugar de almacenaje";
            this.btnAlmacenaje.UseVisualStyleBackColor = true;
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(12, 215);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(160, 25);
            this.btnProducto.TabIndex = 15;
            this.btnProducto.Text = "Producto";
            this.btnProducto.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(12, 246);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(160, 25);
            this.btnStock.TabIndex = 16;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // btnTemporizador
            // 
            this.btnTemporizador.Location = new System.Drawing.Point(12, 277);
            this.btnTemporizador.Name = "btnTemporizador";
            this.btnTemporizador.Size = new System.Drawing.Size(160, 25);
            this.btnTemporizador.TabIndex = 17;
            this.btnTemporizador.Text = "Temporizador";
            this.btnTemporizador.UseVisualStyleBackColor = true;
            // 
            // btnAjustes
            // 
            this.btnAjustes.Location = new System.Drawing.Point(12, 308);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(160, 25);
            this.btnAjustes.TabIndex = 18;
            this.btnAjustes.Text = "Ajustes";
            this.btnAjustes.UseVisualStyleBackColor = true;
            // 
            // pnlPedidos
            // 
            this.pnlPedidos.Controls.Add(this.btnListarPedido);
            this.pnlPedidos.Controls.Add(this.btnModificarPedido);
            this.pnlPedidos.Controls.Add(this.btnBajaPedido);
            this.pnlPedidos.Controls.Add(this.btnAltaPedido);
            this.pnlPedidos.Controls.Add(this.dgvPedidos);
            this.pnlPedidos.Controls.Add(this.lblPedidos);
            this.pnlPedidos.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPedidos.Location = new System.Drawing.Point(185, 19);
            this.pnlPedidos.Name = "pnlPedidos";
            this.pnlPedidos.Size = new System.Drawing.Size(652, 488);
            this.pnlPedidos.TabIndex = 13;
            this.pnlPedidos.Visible = false;
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.BackColor = System.Drawing.SystemColors.Control;
            this.lblPedidos.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.Color.Black;
            this.lblPedidos.Location = new System.Drawing.Point(0, 0);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Padding = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.lblPedidos.Size = new System.Drawing.Size(87, 44);
            this.lblPedidos.TabIndex = 11;
            this.lblPedidos.Text = "Pedidos";
            this.lblPedidos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPedidos.UseCompatibleTextRendering = true;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(7, 47);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(637, 400);
            this.dgvPedidos.TabIndex = 12;
            // 
            // btnAltaPedido
            // 
            this.btnAltaPedido.Location = new System.Drawing.Point(12, 453);
            this.btnAltaPedido.Name = "btnAltaPedido";
            this.btnAltaPedido.Size = new System.Drawing.Size(75, 23);
            this.btnAltaPedido.TabIndex = 13;
            this.btnAltaPedido.Text = "Alta";
            this.btnAltaPedido.UseVisualStyleBackColor = true;
            // 
            // btnBajaPedido
            // 
            this.btnBajaPedido.Location = new System.Drawing.Point(93, 453);
            this.btnBajaPedido.Name = "btnBajaPedido";
            this.btnBajaPedido.Size = new System.Drawing.Size(75, 23);
            this.btnBajaPedido.TabIndex = 14;
            this.btnBajaPedido.Text = "Baja";
            this.btnBajaPedido.UseVisualStyleBackColor = true;
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.Location = new System.Drawing.Point(174, 453);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnModificarPedido.TabIndex = 15;
            this.btnModificarPedido.Text = "Modificar";
            this.btnModificarPedido.UseVisualStyleBackColor = true;
            // 
            // btnListarPedido
            // 
            this.btnListarPedido.Location = new System.Drawing.Point(255, 453);
            this.btnListarPedido.Name = "btnListarPedido";
            this.btnListarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnListarPedido.TabIndex = 16;
            this.btnListarPedido.Text = "Listar";
            this.btnListarPedido.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 507);
            this.Controls.Add(this.pnlPedidos);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gestor";
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCosocoTitulo)).EndInit();
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUtu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCosoco)).EndInit();
            this.pnlPedidos.ResumeLayout(false);
            this.pnlPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pbCosocoTitulo;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.PictureBox pbUtu;
        private System.Windows.Forms.PictureBox pbCosoco;
        private System.Windows.Forms.Button btnEspecies;
        private System.Windows.Forms.Button btnRodales;
        private System.Windows.Forms.Label lblCincuentas;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Button btnTemporizador;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnAlmacenaje;
        private System.Windows.Forms.Button btnTrozas;
        private System.Windows.Forms.Panel pnlPedidos;
        private System.Windows.Forms.Button btnListarPedido;
        private System.Windows.Forms.Button btnModificarPedido;
        private System.Windows.Forms.Button btnBajaPedido;
        private System.Windows.Forms.Button btnAltaPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblPedidos;
    }
}

