namespace Sistema_Empenos_Anderson
{
    partial class Venta
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
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtISV = new System.Windows.Forms.TextBox();
            this.txtFechaVenta = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblISV = new System.Windows.Forms.Label();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.gbInfoComp = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtIDComp = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbIDComp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Facturacion = new System.Windows.Forms.GroupBox();
            this.gbInfoComp.SuspendLayout();
            this.Facturacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(112, 230);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 33;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Location = new System.Drawing.Point(112, 200);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPagar.TabIndex = 32;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(112, 134);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 31;
            // 
            // txtISV
            // 
            this.txtISV.Enabled = false;
            this.txtISV.Location = new System.Drawing.Point(112, 166);
            this.txtISV.Name = "txtISV";
            this.txtISV.Size = new System.Drawing.Size(100, 20);
            this.txtISV.TabIndex = 30;
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.Enabled = false;
            this.txtFechaVenta.Location = new System.Drawing.Point(112, 99);
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.Size = new System.Drawing.Size(100, 20);
            this.txtFechaVenta.TabIndex = 29;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(51, 237);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 28;
            this.lblMonto.Text = "Monto:";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(17, 203);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(74, 13);
            this.lblTotalPagar.TabIndex = 27;
            this.lblTotalPagar.Text = "Total a Pagar:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(42, 137);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 26;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblISV
            // 
            this.lblISV.AutoSize = true;
            this.lblISV.Location = new System.Drawing.Point(58, 169);
            this.lblISV.Name = "lblISV";
            this.lblISV.Size = new System.Drawing.Size(33, 13);
            this.lblISV.TabIndex = 25;
            this.lblISV.Text = "I.S.V.";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(5, 106);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(86, 13);
            this.lblFechaVenta.TabIndex = 24;
            this.lblFechaVenta.Text = "Fecha de Venta:";
            // 
            // gbInfoComp
            // 
            this.gbInfoComp.Controls.Add(this.txtTelefono);
            this.gbInfoComp.Controls.Add(this.txtIDComp);
            this.gbInfoComp.Controls.Add(this.btnAdd);
            this.gbInfoComp.Controls.Add(this.txtCorreo);
            this.gbInfoComp.Controls.Add(this.btnBuscarCliente);
            this.gbInfoComp.Controls.Add(this.label5);
            this.gbInfoComp.Controls.Add(this.lbIDComp);
            this.gbInfoComp.Controls.Add(this.label4);
            this.gbInfoComp.Controls.Add(this.txtApellido);
            this.gbInfoComp.Controls.Add(this.label3);
            this.gbInfoComp.Controls.Add(this.label2);
            this.gbInfoComp.Controls.Add(this.txtNombre);
            this.gbInfoComp.Location = new System.Drawing.Point(236, 18);
            this.gbInfoComp.Name = "gbInfoComp";
            this.gbInfoComp.Size = new System.Drawing.Size(328, 187);
            this.gbInfoComp.TabIndex = 34;
            this.gbInfoComp.TabStop = false;
            this.gbInfoComp.Text = "Información Cliente";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(121, 115);
            this.txtTelefono.Mask = "0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 47;
            // 
            // txtIDComp
            // 
            this.txtIDComp.Location = new System.Drawing.Point(121, 23);
            this.txtIDComp.Mask = "0000-0000-00000";
            this.txtIDComp.Name = "txtIDComp";
            this.txtIDComp.Size = new System.Drawing.Size(100, 20);
            this.txtIDComp.TabIndex = 46;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(232, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(121, 142);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 44;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(232, 23);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 24);
            this.btnBuscarCliente.TabIndex = 8;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Correo Electronico:";
            // 
            // lbIDComp
            // 
            this.lbIDComp.AutoSize = true;
            this.lbIDComp.Location = new System.Drawing.Point(12, 29);
            this.lbIDComp.Name = "lbIDComp";
            this.lbIDComp.Size = new System.Drawing.Size(103, 13);
            this.lbIDComp.TabIndex = 2;
            this.lbIDComp.Text = "Identidad del Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Telefono:";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(121, 89);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(121, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 38;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Enabled = false;
            this.txtVendedor.Location = new System.Drawing.Point(112, 66);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtVendedor.TabIndex = 7;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(42, 69);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(56, 13);
            this.lblVendedor.TabIndex = 3;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(453, 225);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 58);
            this.btnVolver.TabIndex = 35;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(270, 225);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 58);
            this.btnAceptar.TabIndex = 36;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(112, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Codigo Factura";
            // 
            // Facturacion
            // 
            this.Facturacion.Controls.Add(this.txtCodigo);
            this.Facturacion.Controls.Add(this.lblFechaVenta);
            this.Facturacion.Controls.Add(this.label1);
            this.Facturacion.Controls.Add(this.lblISV);
            this.Facturacion.Controls.Add(this.lblSubtotal);
            this.Facturacion.Controls.Add(this.lblTotalPagar);
            this.Facturacion.Controls.Add(this.lblMonto);
            this.Facturacion.Controls.Add(this.txtFechaVenta);
            this.Facturacion.Controls.Add(this.txtVendedor);
            this.Facturacion.Controls.Add(this.txtISV);
            this.Facturacion.Controls.Add(this.txtMonto);
            this.Facturacion.Controls.Add(this.txtSubtotal);
            this.Facturacion.Controls.Add(this.lblVendedor);
            this.Facturacion.Controls.Add(this.txtTotalPagar);
            this.Facturacion.Location = new System.Drawing.Point(12, 18);
            this.Facturacion.Name = "Facturacion";
            this.Facturacion.Size = new System.Drawing.Size(218, 265);
            this.Facturacion.TabIndex = 40;
            this.Facturacion.TabStop = false;
            this.Facturacion.Text = "Facturacion";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 296);
            this.Controls.Add(this.Facturacion);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbInfoComp);
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            this.gbInfoComp.ResumeLayout(false);
            this.gbInfoComp.PerformLayout();
            this.Facturacion.ResumeLayout(false);
            this.Facturacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtISV;
        private System.Windows.Forms.TextBox txtFechaVenta;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblISV;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.GroupBox gbInfoComp;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lbIDComp;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtIDComp;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.GroupBox Facturacion;
    }
}