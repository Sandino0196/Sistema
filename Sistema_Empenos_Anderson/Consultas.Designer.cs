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
            this.txtIngresochar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtConsultas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelseleccion
            // 
            this.labelseleccion.AutoSize = true;
            this.labelseleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelseleccion.Location = new System.Drawing.Point(17, 94);
            this.labelseleccion.Name = "labelseleccion";
            this.labelseleccion.Size = new System.Drawing.Size(178, 13);
            this.labelseleccion.TabIndex = 1;
            this.labelseleccion.Text = "Seleccione Tipo de Consulta: ";
            // 
            // lblcambio
            // 
            this.lblcambio.AutoSize = true;
            this.lblcambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcambio.Location = new System.Drawing.Point(17, 145);
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
            this.cmbseleccion.Location = new System.Drawing.Point(20, 110);
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
            this.cmbtipartic.Location = new System.Drawing.Point(20, 174);
            this.cmbtipartic.Name = "cmbtipartic";
            this.cmbtipartic.Size = new System.Drawing.Size(163, 21);
            this.cmbtipartic.TabIndex = 5;
            // 
            // txtingreso
            // 
            this.txtingreso.Location = new System.Drawing.Point(20, 174);
            this.txtingreso.Name = "txtingreso";
            this.txtingreso.ShortcutsEnabled = false;
            this.txtingreso.Size = new System.Drawing.Size(163, 20);
            this.txtingreso.TabIndex = 6;
            this.txtingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtingreso_KeyPress);
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnregresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnregresar.Location = new System.Drawing.Point(20, 422);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(88, 42);
            this.btnregresar.TabIndex = 7;
            this.btnregresar.Text = "Volver";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnaceptar.Location = new System.Drawing.Point(20, 315);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(88, 41);
            this.btnaceptar.TabIndex = 8;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // dtConsultas
            // 
            this.dtConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtConsultas.Location = new System.Drawing.Point(277, 164);
            this.dtConsultas.Name = "dtConsultas";
            this.dtConsultas.ReadOnly = true;
            this.dtConsultas.Size = new System.Drawing.Size(732, 337);
            this.dtConsultas.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(20, 175);
            this.txtID.Mask = "0000-0000-00000";
            this.txtID.Name = "txtID";
            this.txtID.ShortcutsEnabled = false;
            this.txtID.Size = new System.Drawing.Size(163, 20);
            this.txtID.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(271, 9);
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
            this.btnConsulta.Location = new System.Drawing.Point(277, 55);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(397, 52);
            this.btnConsulta.TabIndex = 14;
            this.btnConsulta.Text = "Consultas";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.UseVisualStyleBackColor = false;
            // 
            // txtIngresochar
            // 
            this.txtIngresochar.Location = new System.Drawing.Point(20, 175);
            this.txtIngresochar.MaxLength = 50;
            this.txtIngresochar.Name = "txtIngresochar";
            this.txtIngresochar.ShortcutsEnabled = false;
            this.txtIngresochar.Size = new System.Drawing.Size(163, 20);
            this.txtIngresochar.TabIndex = 15;
            this.txtIngresochar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtIngresochar);
            this.panel1.Controls.Add(this.labelseleccion);
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Controls.Add(this.lblcambio);
            this.panel1.Controls.Add(this.cmbseleccion);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.cmbtipartic);
            this.panel1.Controls.Add(this.dtConsultas);
            this.panel1.Controls.Add(this.txtingreso);
            this.panel1.Controls.Add(this.btnaceptar);
            this.panel1.Controls.Add(this.btnregresar);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 508);
            this.panel1.TabIndex = 16;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1033, 535);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtConsultas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtIngresochar;
        private System.Windows.Forms.Panel panel1;
    }
}