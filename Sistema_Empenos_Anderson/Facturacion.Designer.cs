namespace Sistema_Empenos_Anderson
{
    partial class Facturacion
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
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.lblNumRecibo = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtNumRecibo = new System.Windows.Forms.TextBox();
            this.bttBuscar = new System.Windows.Forms.Button();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvArticulos = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Location = new System.Drawing.Point(12, 30);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(74, 13);
            this.lblNumSerie.TabIndex = 2;
            this.lblNumSerie.Text = "Número Serie:";
            // 
            // lblNumRecibo
            // 
            this.lblNumRecibo.AutoSize = true;
            this.lblNumRecibo.Location = new System.Drawing.Point(12, 79);
            this.lblNumRecibo.Name = "lblNumRecibo";
            this.lblNumRecibo.Size = new System.Drawing.Size(84, 13);
            this.lblNumRecibo.TabIndex = 3;
            this.lblNumRecibo.Text = "Número Recibo:";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(107, 30);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(100, 20);
            this.txtNumSerie.TabIndex = 4;
            // 
            // txtNumRecibo
            // 
            this.txtNumRecibo.Location = new System.Drawing.Point(107, 76);
            this.txtNumRecibo.Name = "txtNumRecibo";
            this.txtNumRecibo.Size = new System.Drawing.Size(100, 20);
            this.txtNumRecibo.TabIndex = 5;
            // 
            // bttBuscar
            // 
            this.bttBuscar.Location = new System.Drawing.Point(232, 25);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttBuscar.TabIndex = 6;
            this.bttBuscar.Text = "Buscar";
            this.bttBuscar.UseVisualStyleBackColor = true;
            this.bttBuscar.Click += new System.EventHandler(this.bttBuscar_Click);
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(14, 118);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(47, 13);
            this.lblArticulo.TabIndex = 7;
            this.lblArticulo.Text = "Artículo:";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Enabled = false;
            this.txtArticulo.Location = new System.Drawing.Point(107, 115);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtArticulo.TabIndex = 8;
            // 
            // bttAgregar
            // 
            this.bttAgregar.Enabled = false;
            this.bttAgregar.Location = new System.Drawing.Point(232, 74);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(75, 23);
            this.bttAgregar.TabIndex = 10;
            this.bttAgregar.Text = "Agregar";
            this.bttAgregar.UseVisualStyleBackColor = true;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(211, 478);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(75, 23);
            this.bttEliminar.TabIndex = 11;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.UseVisualStyleBackColor = true;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsulta);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bttAgregar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNumRecibo);
            this.groupBox1.Controls.Add(this.lblNumSerie);
            this.groupBox1.Controls.Add(this.txtNumSerie);
            this.groupBox1.Controls.Add(this.txtNumRecibo);
            this.groupBox1.Controls.Add(this.bttBuscar);
            this.groupBox1.Controls.Add(this.txtArticulo);
            this.groupBox1.Controls.Add(this.lblArticulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 282);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda por Número Serie y Número Recibo";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(232, 118);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 31;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(107, 235);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Precio Venta:";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(107, 195);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 28;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(107, 154);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Monto Prestado:";
            // 
            // dtgvArticulos
            // 
            this.dtgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Marca,
            this.Modelo,
            this.Precio});
            this.dtgvArticulos.Location = new System.Drawing.Point(12, 311);
            this.dtgvArticulos.Name = "dtgvArticulos";
            this.dtgvArticulos.Size = new System.Drawing.Size(449, 150);
            this.dtgvArticulos.TabIndex = 27;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
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
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(386, 478);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(75, 23);
            this.btnAvanzar.TabIndex = 28;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(27, 478);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 29;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 525);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.dtgvArticulos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bttEliminar);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.Label lblNumRecibo;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtNumRecibo;
        private System.Windows.Forms.Button bttBuscar;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvArticulos;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnVolver;
    }
}