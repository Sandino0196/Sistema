namespace Sistema_Empenos_Anderson
{
    partial class Estados_Mantenimiento
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
            this.gbCambio_Estado = new System.Windows.Forms.GroupBox();
            this.bttActualizar = new System.Windows.Forms.Button();
            this.lblTipo_Estado = new System.Windows.Forms.Label();
            this.cbxTipo_Art = new System.Windows.Forms.ComboBox();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.lblArt = new System.Windows.Forms.Label();
            this.bttBuscar = new System.Windows.Forms.Button();
            this.Recibotxt = new System.Windows.Forms.TextBox();
            this.Serietxt = new System.Windows.Forms.TextBox();
            this.Num_Reci_lbl = new System.Windows.Forms.Label();
            this.Num_Se_lbl = new System.Windows.Forms.Label();
            this.gbCambio_Estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCambio_Estado
            // 
            this.gbCambio_Estado.Controls.Add(this.bttActualizar);
            this.gbCambio_Estado.Controls.Add(this.lblTipo_Estado);
            this.gbCambio_Estado.Controls.Add(this.cbxTipo_Art);
            this.gbCambio_Estado.Controls.Add(this.txtArticulo);
            this.gbCambio_Estado.Controls.Add(this.lblArt);
            this.gbCambio_Estado.Controls.Add(this.bttBuscar);
            this.gbCambio_Estado.Controls.Add(this.Recibotxt);
            this.gbCambio_Estado.Controls.Add(this.Serietxt);
            this.gbCambio_Estado.Controls.Add(this.Num_Reci_lbl);
            this.gbCambio_Estado.Controls.Add(this.Num_Se_lbl);
            this.gbCambio_Estado.Location = new System.Drawing.Point(5, 21);
            this.gbCambio_Estado.Name = "gbCambio_Estado";
            this.gbCambio_Estado.Size = new System.Drawing.Size(389, 238);
            this.gbCambio_Estado.TabIndex = 1;
            this.gbCambio_Estado.TabStop = false;
            this.gbCambio_Estado.Text = "Cambio de Estado Artículos ";
            // 
            // bttActualizar
            // 
            this.bttActualizar.Location = new System.Drawing.Point(242, 198);
            this.bttActualizar.Name = "bttActualizar";
            this.bttActualizar.Size = new System.Drawing.Size(75, 23);
            this.bttActualizar.TabIndex = 9;
            this.bttActualizar.Text = "Actualizar";
            this.bttActualizar.UseVisualStyleBackColor = true;
            // 
            // lblTipo_Estado
            // 
            this.lblTipo_Estado.AutoSize = true;
            this.lblTipo_Estado.Location = new System.Drawing.Point(6, 165);
            this.lblTipo_Estado.Name = "lblTipo_Estado";
            this.lblTipo_Estado.Size = new System.Drawing.Size(131, 13);
            this.lblTipo_Estado.TabIndex = 8;
            this.lblTipo_Estado.Text = "Seleccione Nuevo Estado";
            // 
            // cbxTipo_Art
            // 
            this.cbxTipo_Art.FormattingEnabled = true;
            this.cbxTipo_Art.Items.AddRange(new object[] {
            "En Prenda",
            "Retirado",
            "Vencido",
            "Vendido"});
            this.cbxTipo_Art.Location = new System.Drawing.Point(215, 162);
            this.cbxTipo_Art.Name = "cbxTipo_Art";
            this.cbxTipo_Art.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo_Art.TabIndex = 7;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(146, 123);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtArticulo.TabIndex = 6;
            // 
            // lblArt
            // 
            this.lblArt.AutoSize = true;
            this.lblArt.Location = new System.Drawing.Point(7, 130);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(47, 13);
            this.lblArt.TabIndex = 5;
            this.lblArt.Text = "Artículo:";
            // 
            // bttBuscar
            // 
            this.bttBuscar.Location = new System.Drawing.Point(10, 87);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttBuscar.TabIndex = 4;
            this.bttBuscar.Text = "Buscar";
            this.bttBuscar.UseVisualStyleBackColor = true;
            // 
            // Recibotxt
            // 
            this.Recibotxt.Location = new System.Drawing.Point(146, 58);
            this.Recibotxt.Name = "Recibotxt";
            this.Recibotxt.Size = new System.Drawing.Size(100, 20);
            this.Recibotxt.TabIndex = 3;
            // 
            // Serietxt
            // 
            this.Serietxt.Location = new System.Drawing.Point(146, 20);
            this.Serietxt.Name = "Serietxt";
            this.Serietxt.Size = new System.Drawing.Size(100, 20);
            this.Serietxt.TabIndex = 2;
            // 
            // Num_Reci_lbl
            // 
            this.Num_Reci_lbl.AutoSize = true;
            this.Num_Reci_lbl.Location = new System.Drawing.Point(7, 58);
            this.Num_Reci_lbl.Name = "Num_Reci_lbl";
            this.Num_Reci_lbl.Size = new System.Drawing.Size(99, 13);
            this.Num_Reci_lbl.TabIndex = 1;
            this.Num_Reci_lbl.Text = "Número de Recibo:";
            // 
            // Num_Se_lbl
            // 
            this.Num_Se_lbl.AutoSize = true;
            this.Num_Se_lbl.Location = new System.Drawing.Point(7, 20);
            this.Num_Se_lbl.Name = "Num_Se_lbl";
            this.Num_Se_lbl.Size = new System.Drawing.Size(89, 13);
            this.Num_Se_lbl.TabIndex = 0;
            this.Num_Se_lbl.Text = "Número de Serie:";
            // 
            // Estados_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 280);
            this.Controls.Add(this.gbCambio_Estado);
            this.Name = "Estados_Mantenimiento";
            this.Text = "Estados_Mantenimiento";
            this.gbCambio_Estado.ResumeLayout(false);
            this.gbCambio_Estado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCambio_Estado;
        private System.Windows.Forms.Button bttActualizar;
        private System.Windows.Forms.Label lblTipo_Estado;
        private System.Windows.Forms.ComboBox cbxTipo_Art;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.Button bttBuscar;
        private System.Windows.Forms.TextBox Recibotxt;
        private System.Windows.Forms.TextBox Serietxt;
        private System.Windows.Forms.Label Num_Reci_lbl;
        private System.Windows.Forms.Label Num_Se_lbl;
    }
}