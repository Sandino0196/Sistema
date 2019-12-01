namespace Sistema_Empenos_Anderson
{
    partial class Retirar_Articulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retirar_Articulos));
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtgvInfo = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMontoPagado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.txtRetiro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(75, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sistema de Empeños Anderson";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código de Recibo:";
            // 
            // txtRecibo
            // 
            this.txtRecibo.Location = new System.Drawing.Point(168, 152);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.ShortcutsEnabled = false;
            this.txtRecibo.Size = new System.Drawing.Size(100, 20);
            this.txtRecibo.TabIndex = 11;
            this.txtRecibo.TextChanged += new System.EventHandler(this.txtRecibo_TextChanged);
            this.txtRecibo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecibo_KeyPress);
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(409, 149);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ShortcutsEnabled = false;
            this.txtSerie.Size = new System.Drawing.Size(100, 20);
            this.txtSerie.TabIndex = 13;
            this.txtSerie.TextChanged += new System.EventHandler(this.txtSerie_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Número de Serie:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(245, 200);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 31);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtgvInfo
            // 
            this.dtgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Marca,
            this.Modelo,
            this.Monto});
            this.dtgvInfo.Location = new System.Drawing.Point(43, 258);
            this.dtgvInfo.Name = "dtgvInfo";
            this.dtgvInfo.Size = new System.Drawing.Size(443, 47);
            this.dtgvInfo.TabIndex = 15;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto a Pagar";
            this.Monto.Name = "Monto";
            // 
            // txtMontoPagado
            // 
            this.txtMontoPagado.Location = new System.Drawing.Point(326, 389);
            this.txtMontoPagado.Name = "txtMontoPagado";
            this.txtMontoPagado.ShortcutsEnabled = false;
            this.txtMontoPagado.Size = new System.Drawing.Size(100, 20);
            this.txtMontoPagado.TabIndex = 17;
            this.txtMontoPagado.TextChanged += new System.EventHandler(this.txtMontoPagado_TextChanged);
            this.txtMontoPagado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoPagado_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Monto Pagado por el Cliente:";
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRetirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRetirar.Location = new System.Drawing.Point(365, 437);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(75, 31);
            this.btnRetirar.TabIndex = 18;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVolver.Location = new System.Drawing.Point(151, 437);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 31);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRetiro
            // 
            this.btnRetiro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRetiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetiro.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRetiro.Image = ((System.Drawing.Image)(resources.GetObject("btnRetiro.Image")));
            this.btnRetiro.Location = new System.Drawing.Point(53, 45);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(491, 50);
            this.btnRetiro.TabIndex = 20;
            this.btnRetiro.Text = "Retiro de Artículo";
            this.btnRetiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetiro.UseVisualStyleBackColor = false;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // txtRetiro
            // 
            this.txtRetiro.Location = new System.Drawing.Point(326, 336);
            this.txtRetiro.Name = "txtRetiro";
            this.txtRetiro.ShortcutsEnabled = false;
            this.txtRetiro.Size = new System.Drawing.Size(100, 20);
            this.txtRetiro.TabIndex = 22;
            this.txtRetiro.TextChanged += new System.EventHandler(this.txtRetiro_TextChanged);
            this.txtRetiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRetiro_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Codigo del Retiro";
            // 
            // Retirar_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 489);
            this.Controls.Add(this.txtRetiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.txtMontoPagado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvInfo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRecibo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.Name = "Retirar_Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retirar Artículos";
            this.Load += new System.EventHandler(this.Retirar_Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtgvInfo;
        private System.Windows.Forms.TextBox txtMontoPagado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.TextBox txtRetiro;
        private System.Windows.Forms.Label label4;
    }
}