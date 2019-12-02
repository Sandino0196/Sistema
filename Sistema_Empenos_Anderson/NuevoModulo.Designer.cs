namespace Sistema_Empenos_Anderson
{
    partial class NuevoModulo
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
            this.lblInventario = new System.Windows.Forms.Label();
            this.dtArticulos = new System.Windows.Forms.DataGridView();
            this.cmbTipo_Articulo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.Location = new System.Drawing.Point(226, 20);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(225, 25);
            this.lblInventario.TabIndex = 0;
            this.lblInventario.Text = "Inventario de Artículos";
            // 
            // dtArticulos
            // 
            this.dtArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtArticulos.Location = new System.Drawing.Point(231, 132);
            this.dtArticulos.Name = "dtArticulos";
            this.dtArticulos.Size = new System.Drawing.Size(456, 284);
            this.dtArticulos.TabIndex = 1;
            this.dtArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbTipo_Articulo
            // 
            this.cmbTipo_Articulo.FormattingEnabled = true;
            this.cmbTipo_Articulo.Items.AddRange(new object[] {
            "Joyeria",
            "Transporte",
            "Electrodomestico",
            "Mueble",
            "Electronico",
            "Entretenimiento"});
            this.cmbTipo_Articulo.Location = new System.Drawing.Point(13, 132);
            this.cmbTipo_Articulo.Name = "cmbTipo_Articulo";
            this.cmbTipo_Articulo.Size = new System.Drawing.Size(182, 21);
            this.cmbTipo_Articulo.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(12, 221);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 52);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolver.Location = new System.Drawing.Point(12, 342);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(108, 57);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(9, 96);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(243, 16);
            this.lblSelect.TabIndex = 5;
            this.lblSelect.Text = "Seleccione el Tipo de Articulo a Buscar";
            // 
            // NuevoModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(699, 495);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbTipo_Articulo);
            this.Controls.Add(this.dtArticulos);
            this.Controls.Add(this.lblInventario);
            this.Name = "NuevoModulo";
            this.Text = "NuevoModulo";
            this.Load += new System.EventHandler(this.NuevoModulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.DataGridView dtArticulos;
        private System.Windows.Forms.ComboBox cmbTipo_Articulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblSelect;
    }
}