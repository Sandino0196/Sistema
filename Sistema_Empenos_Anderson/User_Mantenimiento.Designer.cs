namespace Sistema_Empenos_Anderson
{
    partial class User_Mantenimiento
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
            this.gbCambio_Tipo = new System.Windows.Forms.GroupBox();
            this.lblNom_User = new System.Windows.Forms.Label();
            this.txtNom_User = new System.Windows.Forms.TextBox();
            this.bttBuscar = new System.Windows.Forms.Button();
            this.lblTp_User = new System.Windows.Forms.Label();
            this.cbxTp_User = new System.Windows.Forms.ComboBox();
            this.bttAceptar = new System.Windows.Forms.Button();
            this.bttVolver = new System.Windows.Forms.Button();
            this.gbCambio_Tipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCambio_Tipo
            // 
            this.gbCambio_Tipo.Controls.Add(this.bttVolver);
            this.gbCambio_Tipo.Controls.Add(this.bttAceptar);
            this.gbCambio_Tipo.Controls.Add(this.cbxTp_User);
            this.gbCambio_Tipo.Controls.Add(this.lblTp_User);
            this.gbCambio_Tipo.Controls.Add(this.bttBuscar);
            this.gbCambio_Tipo.Controls.Add(this.txtNom_User);
            this.gbCambio_Tipo.Controls.Add(this.lblNom_User);
            this.gbCambio_Tipo.Location = new System.Drawing.Point(12, 12);
            this.gbCambio_Tipo.Name = "gbCambio_Tipo";
            this.gbCambio_Tipo.Size = new System.Drawing.Size(260, 276);
            this.gbCambio_Tipo.TabIndex = 1;
            this.gbCambio_Tipo.TabStop = false;
            this.gbCambio_Tipo.Text = "Cambio de Tipo";
            // 
            // lblNom_User
            // 
            this.lblNom_User.AutoSize = true;
            this.lblNom_User.Location = new System.Drawing.Point(7, 37);
            this.lblNom_User.Name = "lblNom_User";
            this.lblNom_User.Size = new System.Drawing.Size(103, 13);
            this.lblNom_User.TabIndex = 0;
            this.lblNom_User.Text = "Nombre del Usuario:";
            // 
            // txtNom_User
            // 
            this.txtNom_User.Location = new System.Drawing.Point(142, 34);
            this.txtNom_User.Name = "txtNom_User";
            this.txtNom_User.Size = new System.Drawing.Size(100, 20);
            this.txtNom_User.TabIndex = 1;
            // 
            // bttBuscar
            // 
            this.bttBuscar.Location = new System.Drawing.Point(152, 71);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttBuscar.TabIndex = 2;
            this.bttBuscar.Text = "Buscar";
            this.bttBuscar.UseVisualStyleBackColor = true;
            // 
            // lblTp_User
            // 
            this.lblTp_User.AutoSize = true;
            this.lblTp_User.Location = new System.Drawing.Point(7, 113);
            this.lblTp_User.Name = "lblTp_User";
            this.lblTp_User.Size = new System.Drawing.Size(82, 13);
            this.lblTp_User.TabIndex = 3;
            this.lblTp_User.Text = "Tipo de Usuario";
            // 
            // cbxTp_User
            // 
            this.cbxTp_User.FormattingEnabled = true;
            this.cbxTp_User.Location = new System.Drawing.Point(10, 142);
            this.cbxTp_User.Name = "cbxTp_User";
            this.cbxTp_User.Size = new System.Drawing.Size(121, 21);
            this.cbxTp_User.TabIndex = 4;
            // 
            // bttAceptar
            // 
            this.bttAceptar.Location = new System.Drawing.Point(142, 207);
            this.bttAceptar.Name = "bttAceptar";
            this.bttAceptar.Size = new System.Drawing.Size(75, 23);
            this.bttAceptar.TabIndex = 5;
            this.bttAceptar.Text = "Aceptar";
            this.bttAceptar.UseVisualStyleBackColor = true;
            // 
            // bttVolver
            // 
            this.bttVolver.Location = new System.Drawing.Point(35, 207);
            this.bttVolver.Name = "bttVolver";
            this.bttVolver.Size = new System.Drawing.Size(75, 23);
            this.bttVolver.TabIndex = 6;
            this.bttVolver.Text = "Volver";
            this.bttVolver.UseVisualStyleBackColor = true;
            // 
            // User_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 300);
            this.Controls.Add(this.gbCambio_Tipo);
            this.Name = "User_Mantenimiento";
            this.Text = "User_Mantenimiento";
            this.gbCambio_Tipo.ResumeLayout(false);
            this.gbCambio_Tipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCambio_Tipo;
        private System.Windows.Forms.Button bttVolver;
        private System.Windows.Forms.Button bttAceptar;
        private System.Windows.Forms.ComboBox cbxTp_User;
        private System.Windows.Forms.Label lblTp_User;
        private System.Windows.Forms.Button bttBuscar;
        private System.Windows.Forms.TextBox txtNom_User;
        private System.Windows.Forms.Label lblNom_User;
    }
}