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
            this.gbConsArti = new System.Windows.Forms.GroupBox();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbRecibo = new System.Windows.Forms.RadioButton();
            this.lbl = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.bttBuscar = new System.Windows.Forms.Button();
            this.dtgConsultaArticulo = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnCerrarConsulta = new System.Windows.Forms.Button();
            this.gbConsArti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsArti
            // 
            this.gbConsArti.Controls.Add(this.rbCliente);
            this.gbConsArti.Controls.Add(this.rbRecibo);
            this.gbConsArti.Location = new System.Drawing.Point(12, 12);
            this.gbConsArti.Name = "gbConsArti";
            this.gbConsArti.Size = new System.Drawing.Size(333, 82);
            this.gbConsArti.TabIndex = 0;
            this.gbConsArti.TabStop = false;
            this.gbConsArti.Text = "Busqueda de Artículos";
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(191, 38);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(111, 17);
            this.rbCliente.TabIndex = 1;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Buscar por Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // rbRecibo
            // 
            this.rbRecibo.AutoSize = true;
            this.rbRecibo.Location = new System.Drawing.Point(6, 38);
            this.rbRecibo.Name = "rbRecibo";
            this.rbRecibo.Size = new System.Drawing.Size(113, 17);
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
            this.txtCod.Location = new System.Drawing.Point(184, 106);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 2;
            // 
            // bttBuscar
            // 
            this.bttBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttBuscar.Location = new System.Drawing.Point(290, 104);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttBuscar.TabIndex = 3;
            this.bttBuscar.Text = "Buscar";
            this.bttBuscar.UseVisualStyleBackColor = true;
            this.bttBuscar.Click += new System.EventHandler(this.bttBuscar_Click);
            // 
            // dtgConsultaArticulo
            // 
            this.dtgConsultaArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultaArticulo.Location = new System.Drawing.Point(18, 147);
            this.dtgConsultaArticulo.Name = "dtgConsultaArticulo";
            this.dtgConsultaArticulo.ReadOnly = true;
            this.dtgConsultaArticulo.Size = new System.Drawing.Size(464, 148);
            this.dtgConsultaArticulo.TabIndex = 4;
            this.dtgConsultaArticulo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConsultaArticulo_CellClick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(15, 109);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "label1";
            // 
            // btnCerrarConsulta
            // 
            this.btnCerrarConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarConsulta.Location = new System.Drawing.Point(209, 322);
            this.btnCerrarConsulta.Name = "btnCerrarConsulta";
            this.btnCerrarConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarConsulta.TabIndex = 7;
            this.btnCerrarConsulta.Text = "Cerrar";
            this.btnCerrarConsulta.UseVisualStyleBackColor = true;
            this.btnCerrarConsulta.Click += new System.EventHandler(this.btnCerrarConsulta_Click);
            // 
            // Consulta_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 357);
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
    }
}