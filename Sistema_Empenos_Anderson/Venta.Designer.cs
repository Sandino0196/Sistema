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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.gbInfoComp.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(118, 409);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 33;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Location = new System.Drawing.Point(118, 379);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPagar.TabIndex = 32;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(118, 313);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 31;
            // 
            // txtISV
            // 
            this.txtISV.Enabled = false;
            this.txtISV.Location = new System.Drawing.Point(118, 345);
            this.txtISV.Name = "txtISV";
            this.txtISV.Size = new System.Drawing.Size(100, 20);
            this.txtISV.TabIndex = 30;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(57, 416);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 28;
            this.lblMonto.Text = "Monto:";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(23, 382);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(74, 13);
            this.lblTotalPagar.TabIndex = 27;
            this.lblTotalPagar.Text = "Total a Pagar:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(48, 316);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 26;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblISV
            // 
            this.lblISV.AutoSize = true;
            this.lblISV.Location = new System.Drawing.Point(64, 348);
            this.lblISV.Name = "lblISV";
            this.lblISV.Size = new System.Drawing.Size(33, 13);
            this.lblISV.TabIndex = 25;
            this.lblISV.Text = "I.S.V.";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(11, 285);
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
            this.gbInfoComp.Enabled = false;
            this.gbInfoComp.Location = new System.Drawing.Point(26, 5);
            this.gbInfoComp.Name = "gbInfoComp";
            this.gbInfoComp.Size = new System.Drawing.Size(328, 187);
            this.gbInfoComp.TabIndex = 34;
            this.gbInfoComp.TabStop = false;
            this.gbInfoComp.Text = "Información Cliente";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(121, 115);
            this.txtTelefono.Mask = "0000-9999";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(58, 20);
            this.txtTelefono.TabIndex = 40;
            // 
            // txtIDComp
            // 
            this.txtIDComp.Location = new System.Drawing.Point(121, 26);
            this.txtIDComp.Mask = "0000-9999-00000";
            this.txtIDComp.Name = "txtIDComp";
            this.txtIDComp.Size = new System.Drawing.Size(88, 20);
            this.txtIDComp.TabIndex = 40;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(232, 66);
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
            this.txtVendedor.Location = new System.Drawing.Point(118, 245);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtVendedor.TabIndex = 7;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(48, 248);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(56, 13);
            this.lblVendedor.TabIndex = 3;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(335, 359);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 58);
            this.btnVolver.TabIndex = 35;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(335, 285);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 58);
            this.btnAceptar.TabIndex = 36;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(335, 212);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(90, 58);
            this.btnIngresar.TabIndex = 37;
            this.btnIngresar.Text = "Ingresar Cliente";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(118, 206);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Codigo Factura";
            // 
            // dateFechaVenta
            // 
            this.dateFechaVenta.Enabled = false;
            this.dateFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaVenta.Location = new System.Drawing.Point(118, 279);
            this.dateFechaVenta.Name = "dateFechaVenta";
            this.dateFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dateFechaVenta.TabIndex = 40;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 438);
            this.Controls.Add(this.dateFechaVenta);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbInfoComp);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtISV);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblISV);
            this.Controls.Add(this.lblFechaVenta);
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            this.gbInfoComp.ResumeLayout(false);
            this.gbInfoComp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtISV;
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
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtIDComp;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker dateFechaVenta;
    }
}