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
            this.rdbConsulta = new System.Windows.Forms.RadioButton();
            this.rdbVender = new System.Windows.Forms.RadioButton();
            this.rdbRetirarArticulo = new System.Windows.Forms.RadioButton();
            this.rdbPagoIntereses = new System.Windows.Forms.RadioButton();
            this.rdbIngresarArticulo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbConsulta);
            this.groupBox1.Controls.Add(this.rdbVender);
            this.groupBox1.Controls.Add(this.rdbRetirarArticulo);
            this.groupBox1.Controls.Add(this.rdbPagoIntereses);
            this.groupBox1.Controls.Add(this.rdbIngresarArticulo);
            this.groupBox1.Location = new System.Drawing.Point(54, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU";
            // 
            // rdbConsulta
            // 
            this.rdbConsulta.AutoSize = true;
            this.rdbConsulta.Location = new System.Drawing.Point(71, 223);
            this.rdbConsulta.Name = "rdbConsulta";
            this.rdbConsulta.Size = new System.Drawing.Size(69, 17);
            this.rdbConsulta.TabIndex = 4;
            this.rdbConsulta.Text = "Consultar";
            this.rdbConsulta.UseVisualStyleBackColor = true;
            // 
            // rdbVender
            // 
            this.rdbVender.AutoSize = true;
            this.rdbVender.Location = new System.Drawing.Point(71, 178);
            this.rdbVender.Name = "rdbVender";
            this.rdbVender.Size = new System.Drawing.Size(97, 17);
            this.rdbVender.TabIndex = 3;
            this.rdbVender.Text = "Vender Articulo";
            this.rdbVender.UseVisualStyleBackColor = true;
            // 
            // rdbRetirarArticulo
            // 
            this.rdbRetirarArticulo.AutoSize = true;
            this.rdbRetirarArticulo.Location = new System.Drawing.Point(71, 133);
            this.rdbRetirarArticulo.Name = "rdbRetirarArticulo";
            this.rdbRetirarArticulo.Size = new System.Drawing.Size(94, 17);
            this.rdbRetirarArticulo.TabIndex = 2;
            this.rdbRetirarArticulo.Text = "Retirar Articulo";
            this.rdbRetirarArticulo.UseVisualStyleBackColor = true;
            this.rdbRetirarArticulo.CheckedChanged += new System.EventHandler(this.rdbRetirarArticulo_CheckedChanged);
            // 
            // rdbPagoIntereses
            // 
            this.rdbPagoIntereses.AutoSize = true;
            this.rdbPagoIntereses.Location = new System.Drawing.Point(71, 89);
            this.rdbPagoIntereses.Name = "rdbPagoIntereses";
            this.rdbPagoIntereses.Size = new System.Drawing.Size(111, 17);
            this.rdbPagoIntereses.TabIndex = 1;
            this.rdbPagoIntereses.Text = "Pago de Intereses";
            this.rdbPagoIntereses.UseVisualStyleBackColor = true;
            // 
            // rdbIngresarArticulo
            // 
            this.rdbIngresarArticulo.AutoSize = true;
            this.rdbIngresarArticulo.Location = new System.Drawing.Point(71, 41);
            this.rdbIngresarArticulo.Name = "rdbIngresarArticulo";
            this.rdbIngresarArticulo.Size = new System.Drawing.Size(136, 17);
            this.rdbIngresarArticulo.TabIndex = 0;
            this.rdbIngresarArticulo.Text = "Ingresar Articulo Nuevo";
            this.rdbIngresarArticulo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Empeños Anderson";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BIENVENIDO";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(338, 388);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 433);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbConsulta;
        private System.Windows.Forms.RadioButton rdbVender;
        private System.Windows.Forms.RadioButton rdbRetirarArticulo;
        private System.Windows.Forms.RadioButton rdbPagoIntereses;
        private System.Windows.Forms.RadioButton rdbIngresarArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Aceptar;
    }
}