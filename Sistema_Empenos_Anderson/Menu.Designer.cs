namespace Sistema_Empenos_Anderson
{
    partial class Menu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMantenimiento = new System.Windows.Forms.RadioButton();
            this.rdbConsulta = new System.Windows.Forms.RadioButton();
            this.rdbVenta = new System.Windows.Forms.RadioButton();
            this.rdbRetiro = new System.Windows.Forms.RadioButton();
            this.rdbPago = new System.Windows.Forms.RadioButton();
            this.rdbIngreso = new System.Windows.Forms.RadioButton();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMantenimiento);
            this.groupBox1.Controls.Add(this.rdbConsulta);
            this.groupBox1.Controls.Add(this.rdbVenta);
            this.groupBox1.Controls.Add(this.rdbRetiro);
            this.groupBox1.Controls.Add(this.rdbPago);
            this.groupBox1.Controls.Add(this.rdbIngreso);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(393, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbMantenimiento
            // 
            this.rdbMantenimiento.AutoSize = true;
            this.rdbMantenimiento.Location = new System.Drawing.Point(129, 304);
            this.rdbMantenimiento.Name = "rdbMantenimiento";
            this.rdbMantenimiento.Size = new System.Drawing.Size(94, 17);
            this.rdbMantenimiento.TabIndex = 5;
            this.rdbMantenimiento.Text = "Mantenimiento";
            this.rdbMantenimiento.UseVisualStyleBackColor = true;
            // 
            // rdbConsulta
            // 
            this.rdbConsulta.AutoSize = true;
            this.rdbConsulta.Location = new System.Drawing.Point(129, 258);
            this.rdbConsulta.Name = "rdbConsulta";
            this.rdbConsulta.Size = new System.Drawing.Size(71, 17);
            this.rdbConsulta.TabIndex = 4;
            this.rdbConsulta.Text = "Consultas";
            this.rdbConsulta.UseVisualStyleBackColor = true;
            // 
            // rdbVenta
            // 
            this.rdbVenta.AutoSize = true;
            this.rdbVenta.Location = new System.Drawing.Point(129, 213);
            this.rdbVenta.Name = "rdbVenta";
            this.rdbVenta.Size = new System.Drawing.Size(106, 17);
            this.rdbVenta.TabIndex = 3;
            this.rdbVenta.Text = "Venta de Articulo";
            this.rdbVenta.UseVisualStyleBackColor = true;
            // 
            // rdbRetiro
            // 
            this.rdbRetiro.AutoSize = true;
            this.rdbRetiro.Location = new System.Drawing.Point(129, 167);
            this.rdbRetiro.Name = "rdbRetiro";
            this.rdbRetiro.Size = new System.Drawing.Size(106, 17);
            this.rdbRetiro.TabIndex = 2;
            this.rdbRetiro.Text = "Retiro de Articulo";
            this.rdbRetiro.UseVisualStyleBackColor = true;
            // 
            // rdbPago
            // 
            this.rdbPago.AutoSize = true;
            this.rdbPago.Location = new System.Drawing.Point(129, 119);
            this.rdbPago.Name = "rdbPago";
            this.rdbPago.Size = new System.Drawing.Size(100, 17);
            this.rdbPago.TabIndex = 1;
            this.rdbPago.Text = "Pago de Interes";
            this.rdbPago.UseVisualStyleBackColor = true;
            // 
            // rdbIngreso
            // 
            this.rdbIngreso.AutoSize = true;
            this.rdbIngreso.Location = new System.Drawing.Point(129, 68);
            this.rdbIngreso.Name = "rdbIngreso";
            this.rdbIngreso.Size = new System.Drawing.Size(113, 17);
            this.rdbIngreso.TabIndex = 0;
            this.rdbIngreso.Text = "Ingreso de Articulo";
            this.rdbIngreso.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(71, 444);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 37);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido a Empeños Anderson";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(296, 444);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 37);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "CERRAR SESION";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 493);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbMantenimiento;
        private System.Windows.Forms.RadioButton rdbConsulta;
        private System.Windows.Forms.RadioButton rdbVenta;
        private System.Windows.Forms.RadioButton rdbRetiro;
        private System.Windows.Forms.RadioButton rdbPago;
        private System.Windows.Forms.RadioButton rdbIngreso;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
    }
}