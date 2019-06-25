namespace Sistema_Empenos_Anderson
{
    partial class Retiro1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retiro1));
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Aceptar_R1 = new System.Windows.Forms.Button();
            this.Codigo_Retiro1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Calendario_Retiro1 = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rb_Desc_No = new System.Windows.Forms.RadioButton();
            this.Rb_Desc_SI = new System.Windows.Forms.RadioButton();
            this.b_Aceptar_Retiro1 = new System.Windows.Forms.Button();
            this.b_Regresar_Retiro1 = new System.Windows.Forms.Button();
            this.Monto_Desc_Retiro1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 33);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sistema de Empeños Anderson";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-2, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(772, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // Aceptar_R1
            // 
            this.Aceptar_R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aceptar_R1.Location = new System.Drawing.Point(203, 225);
            this.Aceptar_R1.Name = "Aceptar_R1";
            this.Aceptar_R1.Size = new System.Drawing.Size(75, 23);
            this.Aceptar_R1.TabIndex = 32;
            this.Aceptar_R1.Text = "Aceptar";
            this.Aceptar_R1.UseVisualStyleBackColor = true;
            this.Aceptar_R1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Codigo_Retiro1
            // 
            this.Codigo_Retiro1.Location = new System.Drawing.Point(135, 164);
            this.Codigo_Retiro1.Name = "Codigo_Retiro1";
            this.Codigo_Retiro1.Size = new System.Drawing.Size(165, 20);
            this.Codigo_Retiro1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ingrese el Código del Recibo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Código de Recibo",
            "Número de Serie del Artículo",
            "Id del Cliente"});
            this.comboBox1.Location = new System.Drawing.Point(135, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Buscar por:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(94, 306);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(266, 70);
            this.richTextBox1.TabIndex = 35;
            this.richTextBox1.Text = "Identidad del Cliente:\nNombre del Cliente:\nApellido del Cliente:\nCorreo electróni" +
    "co:\nTeléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Datos del Cliente:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(94, 426);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(266, 144);
            this.richTextBox2.TabIndex = 37;
            this.richTextBox2.Text = "Codigo de Serie del Artículo: \nCodigo de Recibo:\nEstado del Artículo:\nTipo de Art" +
    "ículo:\nMarca:\nModelo:\nFecha de Entrada:\nMeses Acumulados al Dia de Hoy:\nMonto Pr" +
    "estado:\nMonto de Intereses:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Datos del Artículo:";
            // 
            // Calendario_Retiro1
            // 
            this.Calendario_Retiro1.Location = new System.Drawing.Point(421, 88);
            this.Calendario_Retiro1.Name = "Calendario_Retiro1";
            this.Calendario_Retiro1.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Seleccione Fecha Actual:(Dia de Hoy)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rb_Desc_No);
            this.groupBox1.Controls.Add(this.Rb_Desc_SI);
            this.groupBox1.Location = new System.Drawing.Point(407, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 68);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Descuento?";
            // 
            // Rb_Desc_No
            // 
            this.Rb_Desc_No.AutoSize = true;
            this.Rb_Desc_No.Location = new System.Drawing.Point(26, 42);
            this.Rb_Desc_No.Name = "Rb_Desc_No";
            this.Rb_Desc_No.Size = new System.Drawing.Size(39, 17);
            this.Rb_Desc_No.TabIndex = 1;
            this.Rb_Desc_No.TabStop = true;
            this.Rb_Desc_No.Text = "No";
            this.Rb_Desc_No.UseVisualStyleBackColor = true;
            // 
            // Rb_Desc_SI
            // 
            this.Rb_Desc_SI.AutoSize = true;
            this.Rb_Desc_SI.Location = new System.Drawing.Point(26, 19);
            this.Rb_Desc_SI.Name = "Rb_Desc_SI";
            this.Rb_Desc_SI.Size = new System.Drawing.Size(34, 17);
            this.Rb_Desc_SI.TabIndex = 0;
            this.Rb_Desc_SI.TabStop = true;
            this.Rb_Desc_SI.Text = "Si";
            this.Rb_Desc_SI.UseVisualStyleBackColor = true;
            // 
            // b_Aceptar_Retiro1
            // 
            this.b_Aceptar_Retiro1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_Aceptar_Retiro1.Location = new System.Drawing.Point(471, 509);
            this.b_Aceptar_Retiro1.Name = "b_Aceptar_Retiro1";
            this.b_Aceptar_Retiro1.Size = new System.Drawing.Size(75, 23);
            this.b_Aceptar_Retiro1.TabIndex = 42;
            this.b_Aceptar_Retiro1.Text = "Aceptar";
            this.b_Aceptar_Retiro1.UseVisualStyleBackColor = true;
            // 
            // b_Regresar_Retiro1
            // 
            this.b_Regresar_Retiro1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_Regresar_Retiro1.Location = new System.Drawing.Point(598, 509);
            this.b_Regresar_Retiro1.Name = "b_Regresar_Retiro1";
            this.b_Regresar_Retiro1.Size = new System.Drawing.Size(75, 23);
            this.b_Regresar_Retiro1.TabIndex = 43;
            this.b_Regresar_Retiro1.Text = "Regresar";
            this.b_Regresar_Retiro1.UseVisualStyleBackColor = true;
            this.b_Regresar_Retiro1.Click += new System.EventHandler(this.button3_Click);
            // 
            // Monto_Desc_Retiro1
            // 
            this.Monto_Desc_Retiro1.Location = new System.Drawing.Point(457, 446);
            this.Monto_Desc_Retiro1.Name = "Monto_Desc_Retiro1";
            this.Monto_Desc_Retiro1.Size = new System.Drawing.Size(165, 20);
            this.Monto_Desc_Retiro1.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Ingrese Monto de Descuento:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Retiro1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 605);
            this.Controls.Add(this.Monto_Desc_Retiro1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.b_Regresar_Retiro1);
            this.Controls.Add(this.b_Aceptar_Retiro1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Calendario_Retiro1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Aceptar_R1);
            this.Controls.Add(this.Codigo_Retiro1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "Retiro1";
            this.Text = "Retiro1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Aceptar_R1;
        private System.Windows.Forms.TextBox Codigo_Retiro1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar Calendario_Retiro1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rb_Desc_No;
        private System.Windows.Forms.RadioButton Rb_Desc_SI;
        private System.Windows.Forms.Button b_Aceptar_Retiro1;
        private System.Windows.Forms.Button b_Regresar_Retiro1;
        private System.Windows.Forms.TextBox Monto_Desc_Retiro1;
        private System.Windows.Forms.Label label7;
    }
}