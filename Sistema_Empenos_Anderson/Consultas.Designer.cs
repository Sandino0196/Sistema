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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            this.labelseleccion = new System.Windows.Forms.Label();
            this.lblcambio = new System.Windows.Forms.Label();
            this.cmbseleccion = new System.Windows.Forms.ComboBox();
            this.cmbtipartic = new System.Windows.Forms.ComboBox();
            this.txtingreso = new System.Windows.Forms.TextBox();
            this.btnregresar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.dtConsultas = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelseleccion
            // 
            this.labelseleccion.AutoSize = true;
            this.labelseleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelseleccion.Location = new System.Drawing.Point(18, 110);
            this.labelseleccion.Name = "labelseleccion";
            this.labelseleccion.Size = new System.Drawing.Size(178, 13);
            this.labelseleccion.TabIndex = 1;
            this.labelseleccion.Text = "Seleccione Tipo de Consulta: ";
            // 
            // lblcambio
            // 
            this.lblcambio.AutoSize = true;
            this.lblcambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcambio.Location = new System.Drawing.Point(18, 161);
            this.lblcambio.Name = "lblcambio";
            this.lblcambio.Size = new System.Drawing.Size(41, 13);
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
            this.btnregresar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnregresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnregresar.Location = new System.Drawing.Point(21, 431);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(88, 49);
            this.btnregresar.TabIndex = 7;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnaceptar.Location = new System.Drawing.Point(21, 323);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(88, 49);
            this.btnaceptar.TabIndex = 8;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // dtConsultas
            // 
            this.dtConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtConsultas.Location = new System.Drawing.Point(204, 161);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(272, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sistema de Empeños Anderson";
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.Location = new System.Drawing.Point(278, 71);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(397, 52);
            this.btnConsulta.TabIndex = 14;
            this.btnConsulta.Text = "Consultas";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.UseVisualStyleBackColor = false;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1208, 532);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dtConsultas);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.txtingreso);
            this.Controls.Add(this.cmbtipartic);
            this.Controls.Add(this.cmbseleccion);
            this.Controls.Add(this.lblcambio);
            this.Controls.Add(this.labelseleccion);
            this.MaximizeBox = false;
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelseleccion;
        private System.Windows.Forms.Label lblcambio;
        private System.Windows.Forms.ComboBox cmbseleccion;
        private System.Windows.Forms.ComboBox cmbtipartic;
        private System.Windows.Forms.TextBox txtingreso;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.DataGridView dtConsultas;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConsulta;
    }
}