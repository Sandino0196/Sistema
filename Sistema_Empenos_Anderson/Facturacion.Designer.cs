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
            this.gbInfoComp = new System.Windows.Forms.GroupBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtIDComp = new System.Windows.Forms.TextBox();
            this.txtApeCom = new System.Windows.Forms.TextBox();
            this.txtNomComp = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lbIDComp = new System.Windows.Forms.Label();
            this.lblApellidoCom = new System.Windows.Forms.Label();
            this.lblNomComp = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.lblNumRecibo = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtNumRecibo = new System.Windows.Forms.TextBox();
            this.bttBuscar = new System.Windows.Forms.Button();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblISV = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtFechaVenta = new System.Windows.Forms.TextBox();
            this.txtISV = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.bttRegresar = new System.Windows.Forms.Button();
            this.bttLimpiar = new System.Windows.Forms.Button();
            this.bttAceptar = new System.Windows.Forms.Button();
            this.gbInfoComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfoComp
            // 
            this.gbInfoComp.Controls.Add(this.txtVendedor);
            this.gbInfoComp.Controls.Add(this.txtIDComp);
            this.gbInfoComp.Controls.Add(this.txtApeCom);
            this.gbInfoComp.Controls.Add(this.txtNomComp);
            this.gbInfoComp.Controls.Add(this.lblVendedor);
            this.gbInfoComp.Controls.Add(this.lbIDComp);
            this.gbInfoComp.Controls.Add(this.lblApellidoCom);
            this.gbInfoComp.Controls.Add(this.lblNomComp);
            this.gbInfoComp.Location = new System.Drawing.Point(12, 12);
            this.gbInfoComp.Name = "gbInfoComp";
            this.gbInfoComp.Size = new System.Drawing.Size(487, 100);
            this.gbInfoComp.TabIndex = 0;
            this.gbInfoComp.TabStop = false;
            this.gbInfoComp.Text = "Información Comprador";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(366, 61);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtVendedor.TabIndex = 7;
            // 
            // txtIDComp
            // 
            this.txtIDComp.Location = new System.Drawing.Point(366, 26);
            this.txtIDComp.Name = "txtIDComp";
            this.txtIDComp.Size = new System.Drawing.Size(100, 20);
            this.txtIDComp.TabIndex = 6;
            // 
            // txtApeCom
            // 
            this.txtApeCom.Location = new System.Drawing.Point(112, 61);
            this.txtApeCom.Name = "txtApeCom";
            this.txtApeCom.Size = new System.Drawing.Size(100, 20);
            this.txtApeCom.TabIndex = 5;
            // 
            // txtNomComp
            // 
            this.txtNomComp.Location = new System.Drawing.Point(112, 26);
            this.txtNomComp.Name = "txtNomComp";
            this.txtNomComp.Size = new System.Drawing.Size(100, 20);
            this.txtNomComp.TabIndex = 4;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(290, 64);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(56, 13);
            this.lblVendedor.TabIndex = 3;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lbIDComp
            // 
            this.lbIDComp.AutoSize = true;
            this.lbIDComp.Location = new System.Drawing.Point(238, 29);
            this.lbIDComp.Name = "lbIDComp";
            this.lbIDComp.Size = new System.Drawing.Size(125, 13);
            this.lbIDComp.TabIndex = 2;
            this.lbIDComp.Text = "Identidad del Comprador:";
            // 
            // lblApellidoCom
            // 
            this.lblApellidoCom.AutoSize = true;
            this.lblApellidoCom.Location = new System.Drawing.Point(6, 64);
            this.lblApellidoCom.Name = "lblApellidoCom";
            this.lblApellidoCom.Size = new System.Drawing.Size(101, 13);
            this.lblApellidoCom.TabIndex = 1;
            this.lblApellidoCom.Text = "Apellido Comprador:";
            // 
            // lblNomComp
            // 
            this.lblNomComp.AutoSize = true;
            this.lblNomComp.Location = new System.Drawing.Point(6, 29);
            this.lblNomComp.Name = "lblNomComp";
            this.lblNomComp.Size = new System.Drawing.Size(101, 13);
            this.lblNomComp.TabIndex = 0;
            this.lblNomComp.Text = "Nombre Comprador:";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(18, 135);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(225, 13);
            this.lblBusqueda.TabIndex = 1;
            this.lblBusqueda.Text = "Búsqueda por Número Serie y Número Recibo";
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Location = new System.Drawing.Point(21, 182);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(74, 13);
            this.lblNumSerie.TabIndex = 2;
            this.lblNumSerie.Text = "Número Serie:";
            // 
            // lblNumRecibo
            // 
            this.lblNumRecibo.AutoSize = true;
            this.lblNumRecibo.Location = new System.Drawing.Point(18, 231);
            this.lblNumRecibo.Name = "lblNumRecibo";
            this.lblNumRecibo.Size = new System.Drawing.Size(84, 13);
            this.lblNumRecibo.TabIndex = 3;
            this.lblNumRecibo.Text = "Número Recibo:";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(111, 182);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(100, 20);
            this.txtNumSerie.TabIndex = 4;
            // 
            // txtNumRecibo
            // 
            this.txtNumRecibo.Location = new System.Drawing.Point(111, 228);
            this.txtNumRecibo.Name = "txtNumRecibo";
            this.txtNumRecibo.Size = new System.Drawing.Size(100, 20);
            this.txtNumRecibo.TabIndex = 5;
            // 
            // bttBuscar
            // 
            this.bttBuscar.Location = new System.Drawing.Point(124, 271);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttBuscar.TabIndex = 6;
            this.bttBuscar.Text = "Buscar";
            this.bttBuscar.UseVisualStyleBackColor = true;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(21, 319);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(47, 13);
            this.lblArticulo.TabIndex = 7;
            this.lblArticulo.Text = "Artículo:";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(111, 316);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtArticulo.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // bttAgregar
            // 
            this.bttAgregar.Location = new System.Drawing.Point(258, 374);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(75, 23);
            this.bttAgregar.TabIndex = 10;
            this.bttAgregar.Text = "Agregar";
            this.bttAgregar.UseVisualStyleBackColor = true;
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(258, 446);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(75, 23);
            this.bttEliminar.TabIndex = 11;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(354, 145);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(360, 345);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(86, 13);
            this.lblFechaVenta.TabIndex = 13;
            this.lblFechaVenta.Text = "Fecha de Venta:";
            // 
            // lblISV
            // 
            this.lblISV.AutoSize = true;
            this.lblISV.Location = new System.Drawing.Point(413, 374);
            this.lblISV.Name = "lblISV";
            this.lblISV.Size = new System.Drawing.Size(33, 13);
            this.lblISV.TabIndex = 14;
            this.lblISV.Text = "I.S.V.";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(397, 405);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 15;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(372, 446);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(74, 13);
            this.lblTotalPagar.TabIndex = 16;
            this.lblTotalPagar.Text = "Total a Pagar:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(406, 476);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 17;
            this.lblMonto.Text = "Monto:";
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.Enabled = false;
            this.txtFechaVenta.Location = new System.Drawing.Point(467, 338);
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.Size = new System.Drawing.Size(100, 20);
            this.txtFechaVenta.TabIndex = 18;
            // 
            // txtISV
            // 
            this.txtISV.Enabled = false;
            this.txtISV.Location = new System.Drawing.Point(467, 367);
            this.txtISV.Name = "txtISV";
            this.txtISV.Size = new System.Drawing.Size(100, 20);
            this.txtISV.TabIndex = 19;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(467, 402);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 20;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Location = new System.Drawing.Point(467, 439);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPagar.TabIndex = 21;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(467, 469);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 22;
            // 
            // bttRegresar
            // 
            this.bttRegresar.Location = new System.Drawing.Point(149, 529);
            this.bttRegresar.Name = "bttRegresar";
            this.bttRegresar.Size = new System.Drawing.Size(75, 23);
            this.bttRegresar.TabIndex = 23;
            this.bttRegresar.Text = "Regresar";
            this.bttRegresar.UseVisualStyleBackColor = true;
            this.bttRegresar.Click += new System.EventHandler(this.bttRegresar_Click);
            // 
            // bttLimpiar
            // 
            this.bttLimpiar.Location = new System.Drawing.Point(269, 529);
            this.bttLimpiar.Name = "bttLimpiar";
            this.bttLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bttLimpiar.TabIndex = 24;
            this.bttLimpiar.Text = "Limpiar";
            this.bttLimpiar.UseVisualStyleBackColor = true;
            // 
            // bttAceptar
            // 
            this.bttAceptar.Location = new System.Drawing.Point(391, 529);
            this.bttAceptar.Name = "bttAceptar";
            this.bttAceptar.Size = new System.Drawing.Size(75, 23);
            this.bttAceptar.TabIndex = 25;
            this.bttAceptar.Text = "Aceptar";
            this.bttAceptar.UseVisualStyleBackColor = true;
            this.bttAceptar.Click += new System.EventHandler(this.bttAceptar_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 564);
            this.Controls.Add(this.bttAceptar);
            this.Controls.Add(this.bttLimpiar);
            this.Controls.Add(this.bttRegresar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtISV);
            this.Controls.Add(this.txtFechaVenta);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblISV);
            this.Controls.Add(this.lblFechaVenta);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.bttBuscar);
            this.Controls.Add(this.txtNumRecibo);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.lblNumRecibo);
            this.Controls.Add(this.lblNumSerie);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.gbInfoComp);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.gbInfoComp.ResumeLayout(false);
            this.gbInfoComp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoComp;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox txtIDComp;
        private System.Windows.Forms.TextBox txtApeCom;
        private System.Windows.Forms.TextBox txtNomComp;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lbIDComp;
        private System.Windows.Forms.Label lblApellidoCom;
        private System.Windows.Forms.Label lblNomComp;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.Label lblNumRecibo;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtNumRecibo;
        private System.Windows.Forms.Button bttBuscar;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Label lblISV;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtFechaVenta;
        private System.Windows.Forms.TextBox txtISV;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button bttRegresar;
        private System.Windows.Forms.Button bttLimpiar;
        private System.Windows.Forms.Button bttAceptar;
    }
}