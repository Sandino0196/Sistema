namespace Sistema_Empenos_Anderson
{
    partial class Ingreso_de_Articulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingreso_de_Articulo));
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod_Recibo = new System.Windows.Forms.TextBox();
            this.txtNumero_Serie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipo_Articulo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clndrFecha = new System.Windows.Forms.MonthCalendar();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgvArticulos = new System.Windows.Forms.DataGridView();
            this.Numero_Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnIngresoArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(233, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sistema de Empeños Anderson";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo de Recibo:";
            // 
            // txtCod_Recibo
            // 
            this.txtCod_Recibo.Location = new System.Drawing.Point(240, 163);
            this.txtCod_Recibo.Name = "txtCod_Recibo";
            this.txtCod_Recibo.Size = new System.Drawing.Size(116, 20);
            this.txtCod_Recibo.TabIndex = 11;
            this.txtCod_Recibo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_Recibo_KeyPress);
            // 
            // txtNumero_Serie
            // 
            this.txtNumero_Serie.Location = new System.Drawing.Point(240, 196);
            this.txtNumero_Serie.Name = "txtNumero_Serie";
            this.txtNumero_Serie.Size = new System.Drawing.Size(116, 20);
            this.txtNumero_Serie.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Numero de Serie de Articulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tipo de Articulo:";
            // 
            // cmbTipo_Articulo
            // 
            this.cmbTipo_Articulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo_Articulo.FormattingEnabled = true;
            this.cmbTipo_Articulo.Items.AddRange(new object[] {
            "Electrodomestico",
            "Entretenimiento",
            "Joyeria",
            "Vehiculo"});
            this.cmbTipo_Articulo.Location = new System.Drawing.Point(644, 124);
            this.cmbTipo_Articulo.Name = "cmbTipo_Articulo";
            this.cmbTipo_Articulo.Size = new System.Drawing.Size(140, 21);
            this.cmbTipo_Articulo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha:";
            // 
            // clndrFecha
            // 
            this.clndrFecha.Enabled = false;
            this.clndrFecha.Location = new System.Drawing.Point(631, 163);
            this.clndrFecha.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.clndrFecha.Name = "clndrFecha";
            this.clndrFecha.TabIndex = 17;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(189, 289);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(116, 20);
            this.txtDescripcion.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Descripcion:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(189, 315);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(116, 20);
            this.txtMarca.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Marca:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(189, 341);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(116, 20);
            this.txtModelo.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Modelo:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(189, 367);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(116, 20);
            this.txtMonto.TabIndex = 25;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Monto a Prestar:";
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(189, 393);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(116, 20);
            this.txtTasa.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tasa de Interes:";
            // 
            // dtgvArticulos
            // 
            this.dtgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_Serie,
            this.Articulo,
            this.Tipo,
            this.Marca,
            this.Modelo});
            this.dtgvArticulos.Location = new System.Drawing.Point(317, 328);
            this.dtgvArticulos.Name = "dtgvArticulos";
            this.dtgvArticulos.Size = new System.Drawing.Size(635, 134);
            this.dtgvArticulos.TabIndex = 28;
            // 
            // Numero_Serie
            // 
            this.Numero_Serie.HeaderText = "Numero_Serie";
            this.Numero_Serie.Name = "Numero_Serie";
            this.Numero_Serie.ReadOnly = true;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(48, 468);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(87, 23);
            this.btnVolver.TabIndex = 29;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAvanzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvanzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvanzar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAvanzar.Location = new System.Drawing.Point(864, 468);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(87, 23);
            this.btnAvanzar.TabIndex = 30;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = false;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(189, 430);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 23);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnIngresoArticulo
            // 
            this.btnIngresoArticulo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIngresoArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoArticulo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnIngresoArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresoArticulo.Image")));
            this.btnIngresoArticulo.Location = new System.Drawing.Point(240, 58);
            this.btnIngresoArticulo.Name = "btnIngresoArticulo";
            this.btnIngresoArticulo.Size = new System.Drawing.Size(523, 50);
            this.btnIngresoArticulo.TabIndex = 32;
            this.btnIngresoArticulo.Text = "Ingreso de Artículo";
            this.btnIngresoArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresoArticulo.UseVisualStyleBackColor = false;
            // 
            // Ingreso_de_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(966, 503);
            this.Controls.Add(this.btnIngresoArticulo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtgvArticulos);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clndrFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipo_Articulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumero_Serie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCod_Recibo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Ingreso_de_Articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de Articulo";
            this.Load += new System.EventHandler(this.Ingreso_de_Articulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCod_Recibo;
        private System.Windows.Forms.TextBox txtNumero_Serie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipo_Articulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar clndrFecha;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgvArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnIngresoArticulo;
    }
}