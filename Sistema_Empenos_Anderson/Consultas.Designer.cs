namespace Sistema_Empenos_Anderson
{
    partial class Consultas
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelseleccion = new System.Windows.Forms.Label();
            this.lblcambio = new System.Windows.Forms.Label();
            this.cmbseleccion = new System.Windows.Forms.ComboBox();
            this.cmbtipartic = new System.Windows.Forms.ComboBox();
            this.txtingreso = new System.Windows.Forms.TextBox();
            this.btnregresar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.dtConsultas = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Empeños Anderson";
            // 
            // labelseleccion
            // 
            this.labelseleccion.AutoSize = true;
            this.labelseleccion.Location = new System.Drawing.Point(18, 110);
            this.labelseleccion.Name = "labelseleccion";
            this.labelseleccion.Size = new System.Drawing.Size(149, 13);
            this.labelseleccion.TabIndex = 1;
            this.labelseleccion.Text = "Seleccione Tipo de Consulta: ";
            // 
            // lblcambio
            // 
            this.lblcambio.AutoSize = true;
            this.lblcambio.Location = new System.Drawing.Point(18, 161);
            this.lblcambio.Name = "lblcambio";
            this.lblcambio.Size = new System.Drawing.Size(35, 13);
            this.lblcambio.TabIndex = 2;
            this.lblcambio.Text = "label3";
            // 
            // cmbseleccion
            // 
            this.cmbseleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbseleccion.FormattingEnabled = true;
            this.cmbseleccion.Items.AddRange(new object[] {
            "Identidad del Cliente",
            "Codigo Recibo",
            "Codigo Factura",
            "Tipo de Articulos",
            "Numero de Serie"});
            this.cmbseleccion.Location = new System.Drawing.Point(21, 126);
            this.cmbseleccion.Name = "cmbseleccion";
            this.cmbseleccion.Size = new System.Drawing.Size(163, 21);
            this.cmbseleccion.TabIndex = 3;
            this.cmbseleccion.SelectedIndexChanged += new System.EventHandler(this.cmbseleccion_SelectedIndexChanged);
            // 
            // cmbtipartic
            // 
            this.cmbtipartic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipartic.FormattingEnabled = true;
            this.cmbtipartic.Items.AddRange(new object[] {
            "Joyería",
            "Transporte",
            "Electrodoméstico",
            "Mueble",
            "Electrónico",
            "Entretenimiento"});
            this.cmbtipartic.Location = new System.Drawing.Point(21, 187);
            this.cmbtipartic.Name = "cmbtipartic";
            this.cmbtipartic.Size = new System.Drawing.Size(163, 21);
            this.cmbtipartic.TabIndex = 5;
            // 
            // txtingreso
            // 
            this.txtingreso.Location = new System.Drawing.Point(21, 188);
            this.txtingreso.Name = "txtingreso";
            this.txtingreso.Size = new System.Drawing.Size(163, 20);
            this.txtingreso.TabIndex = 6;
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(21, 409);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(88, 49);
            this.btnregresar.TabIndex = 7;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(54, 260);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(88, 49);
            this.btnaceptar.TabIndex = 8;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // dtConsultas
            // 
            this.dtConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtConsultas.Location = new System.Drawing.Point(226, 96);
            this.dtConsultas.Name = "dtConsultas";
            this.dtConsultas.Size = new System.Drawing.Size(1047, 337);
            this.dtConsultas.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(21, 188);
            this.txtID.Mask = "0000-0000-00000";
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(163, 20);
            this.txtID.TabIndex = 11;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1295, 470);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dtConsultas);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.txtingreso);
            this.Controls.Add(this.cmbtipartic);
            this.Controls.Add(this.cmbseleccion);
            this.Controls.Add(this.lblcambio);
            this.Controls.Add(this.labelseleccion);
            this.Controls.Add(this.label1);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelseleccion;
        private System.Windows.Forms.Label lblcambio;
        private System.Windows.Forms.ComboBox cmbseleccion;
        private System.Windows.Forms.ComboBox cmbtipartic;
        private System.Windows.Forms.TextBox txtingreso;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.DataGridView dtConsultas;
        private System.Windows.Forms.MaskedTextBox txtID;
    }
}