namespace Sistema_Empenos_Anderson
{
    partial class Consulta_Articulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Articulos));
            this.gbConsArti = new System.Windows.Forms.GroupBox();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbRecibo = new System.Windows.Forms.RadioButton();
            this.lbl = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.bttBuscar = new System.Windows.Forms.Button();
            this.dtgConsultaArticulo = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnCerrarConsulta = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.MaskedTextBox();
            this.gbConsArti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsArti
            // 
            this.gbConsArti.Controls.Add(this.rbCliente);
            this.gbConsArti.Controls.Add(this.rbRecibo);
            this.gbConsArti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsArti.Location = new System.Drawing.Point(69, 136);
            this.gbConsArti.Name = "gbConsArti";
            this.gbConsArti.Size = new System.Drawing.Size(333, 82);
            this.gbConsArti.TabIndex = 0;
            this.gbConsArti.TabStop = false;
            this.gbConsArti.Text = "Busqueda de Artículos";
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCliente.Location = new System.Drawing.Point(191, 38);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(129, 17);
            this.rbCliente.TabIndex = 1;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Buscar por Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // rbRecibo
            // 
            this.rbRecibo.AutoSize = true;
            this.rbRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRecibo.Location = new System.Drawing.Point(22, 38);
            this.rbRecibo.Name = "rbRecibo";
            this.rbRecibo.Size = new System.Drawing.Size(130, 17);
            this.rbRecibo.TabIndex = 0;
            this.rbRecibo.TabStop = true;
            this.rbRecibo.Text = "Buscar por Recibo";
            this.rbRecibo.UseVisualStyleBackColor = true;
            this.rbRecibo.CheckedChanged += new System.EventHandler(this.rbRecibo_CheckedChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(15, 113);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 1;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(219, 236);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(124, 20);
            this.txtCod.TabIndex = 2;
            // 
            // bttBuscar
            // 
            this.bttBuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bttBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.bttBuscar.Location = new System.Drawing.Point(361, 228);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(75, 35);
            this.bttBuscar.TabIndex = 3;
            this.bttBuscar.Text = "Buscar";
            this.bttBuscar.UseVisualStyleBackColor = false;
            this.bttBuscar.Click += new System.EventHandler(this.bttBuscar_Click);
            // 
            // dtgConsultaArticulo
            // 
            this.dtgConsultaArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultaArticulo.Location = new System.Drawing.Point(69, 274);
            this.dtgConsultaArticulo.Name = "dtgConsultaArticulo";
            this.dtgConsultaArticulo.ReadOnly = true;
            this.dtgConsultaArticulo.Size = new System.Drawing.Size(464, 148);
            this.dtgConsultaArticulo.TabIndex = 4;
            this.dtgConsultaArticulo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConsultaArticulo_CellClick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(66, 236);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "label1";
            // 
            // btnCerrarConsulta
            // 
            this.btnCerrarConsulta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCerrarConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarConsulta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrarConsulta.Location = new System.Drawing.Point(260, 440);
            this.btnCerrarConsulta.Name = "btnCerrarConsulta";
            this.btnCerrarConsulta.Size = new System.Drawing.Size(75, 37);
            this.btnCerrarConsulta.TabIndex = 7;
            this.btnCerrarConsulta.Text = "Cerrar";
            this.btnCerrarConsulta.UseVisualStyleBackColor = false;
            this.btnCerrarConsulta.Click += new System.EventHandler(this.btnCerrarConsulta_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.Location = new System.Drawing.Point(69, 52);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(397, 52);
            this.btnConsulta.TabIndex = 11;
            this.btnConsulta.Text = "Consultas";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(53, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sistema de Empeños Anderson";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(219, 236);
            this.txtCodCliente.Mask = "0000-0000-00000";
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(124, 20);
            this.txtCodCliente.TabIndex = 13;
            // 
            // Consulta_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 489);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnCerrarConsulta);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dtgConsultaArticulo);
            this.Controls.Add(this.bttBuscar);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.gbConsArti);
            this.MaximizeBox = false;
            this.Name = "Consulta_Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Artículos";
            this.Load += new System.EventHandler(this.Consulta_Facturacion_Load);
            this.gbConsArti.ResumeLayout(false);
            this.gbConsArti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsArti;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbRecibo;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button bttBuscar;
        private System.Windows.Forms.DataGridView dtgConsultaArticulo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnCerrarConsulta;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCodCliente;
    }
}