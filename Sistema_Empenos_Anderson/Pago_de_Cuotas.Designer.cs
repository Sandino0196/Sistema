namespace Sistema_Empenos_Anderson
{
    partial class Pago_de_Cuotas
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIntereses = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumRecibo = new System.Windows.Forms.Label();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtNumRecibo = new System.Windows.Forms.TextBox();
            this.bttBuscar = new System.Windows.Forms.Button();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(379, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sistema de Empeños Anderson";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMeses);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIntereses);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnConsulta);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNumRecibo);
            this.groupBox1.Controls.Add(this.lblNumSerie);
            this.groupBox1.Controls.Add(this.txtNumSerie);
            this.groupBox1.Controls.Add(this.txtNumRecibo);
            this.groupBox1.Controls.Add(this.bttBuscar);
            this.groupBox1.Controls.Add(this.txtArticulo);
            this.groupBox1.Controls.Add(this.lblArticulo);
            this.groupBox1.Location = new System.Drawing.Point(18, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 311);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Articulo";
            // 
            // txtMeses
            // 
            this.txtMeses.Enabled = false;
            this.txtMeses.Location = new System.Drawing.Point(107, 268);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(162, 20);
            this.txtMeses.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Meses en deuda";
            // 
            // txtIntereses
            // 
            this.txtIntereses.Enabled = false;
            this.txtIntereses.Location = new System.Drawing.Point(107, 231);
            this.txtIntereses.Name = "txtIntereses";
            this.txtIntereses.Size = new System.Drawing.Size(162, 20);
            this.txtIntereses.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Intereses por mes";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(285, 76);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 31;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(107, 195);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(162, 20);
            this.txtMonto.TabIndex = 28;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(107, 154);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(162, 20);
            this.txtEstado.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
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
            // lblNumRecibo
            // 
            this.lblNumRecibo.AutoSize = true;
            this.lblNumRecibo.Location = new System.Drawing.Point(12, 33);
            this.lblNumRecibo.Name = "lblNumRecibo";
            this.lblNumRecibo.Size = new System.Drawing.Size(84, 13);
            this.lblNumRecibo.TabIndex = 3;
            this.lblNumRecibo.Text = "Número Recibo:";
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Location = new System.Drawing.Point(14, 79);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(74, 13);
            this.lblNumSerie.TabIndex = 2;
            this.lblNumSerie.Text = "Número Serie:";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(107, 79);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(162, 20);
            this.txtNumSerie.TabIndex = 4;
            // 
            // txtNumRecibo
            // 
            this.txtNumRecibo.Location = new System.Drawing.Point(107, 30);
            this.txtNumRecibo.Name = "txtNumRecibo";
            this.txtNumRecibo.Size = new System.Drawing.Size(162, 20);
            this.txtNumRecibo.TabIndex = 5;
            // 
            // bttBuscar
            // 
            this.bttBuscar.Location = new System.Drawing.Point(285, 25);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttBuscar.TabIndex = 6;
            this.bttBuscar.Text = "Buscar";
            this.bttBuscar.UseVisualStyleBackColor = true;
            this.bttBuscar.Click += new System.EventHandler(this.bttBuscar_Click_1);
            // 
            // txtArticulo
            // 
            this.txtArticulo.Enabled = false;
            this.txtArticulo.Location = new System.Drawing.Point(107, 115);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(162, 20);
            this.txtArticulo.TabIndex = 8;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(258, 383);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(89, 39);
            this.btnAvanzar.TabIndex = 30;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pago_de_Cuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 434);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Pago_de_Cuotas";
            this.Text = "Pago de Cuotas";
            this.Load += new System.EventHandler(this.Pago_de_Cuotas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumRecibo;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtNumRecibo;
        private System.Windows.Forms.Button bttBuscar;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIntereses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAvanzar;
    }
}