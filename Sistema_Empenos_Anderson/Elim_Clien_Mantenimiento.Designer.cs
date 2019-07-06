namespace Sistema_Empenos_Anderson
{
    partial class Elim_Clien_Mantenimiento
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
            this.Titulolbl = new System.Windows.Forms.Label();
            this.ID_Clientelbl = new System.Windows.Forms.Label();
            this.txtID_Cliente = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttBuscar = new System.Windows.Forms.Button();
            this.bttElim = new System.Windows.Forms.Button();
            this.bttLimpiar = new System.Windows.Forms.Button();
            this.Regresarbtt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulolbl
            // 
            this.Titulolbl.AutoSize = true;
            this.Titulolbl.Location = new System.Drawing.Point(93, 9);
            this.Titulolbl.Name = "Titulolbl";
            this.Titulolbl.Size = new System.Drawing.Size(78, 13);
            this.Titulolbl.TabIndex = 0;
            this.Titulolbl.Text = "Eliminar Cliente";
            // 
            // ID_Clientelbl
            // 
            this.ID_Clientelbl.AutoSize = true;
            this.ID_Clientelbl.Location = new System.Drawing.Point(13, 58);
            this.ID_Clientelbl.Name = "ID_Clientelbl";
            this.ID_Clientelbl.Size = new System.Drawing.Size(89, 13);
            this.ID_Clientelbl.TabIndex = 1;
            this.ID_Clientelbl.Text = "Identidad Cliente:";
            // 
            // txtID_Cliente
            // 
            this.txtID_Cliente.Location = new System.Drawing.Point(144, 55);
            this.txtID_Cliente.Name = "txtID_Cliente";
            this.txtID_Cliente.Size = new System.Drawing.Size(100, 20);
            this.txtID_Cliente.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(283, 80);
            this.dataGridView1.TabIndex = 3;
            // 
            // bttBuscar
            // 
            this.bttBuscar.Location = new System.Drawing.Point(156, 81);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttBuscar.TabIndex = 4;
            this.bttBuscar.Text = "Buscar";
            this.bttBuscar.UseVisualStyleBackColor = true;
            // 
            // bttElim
            // 
            this.bttElim.Location = new System.Drawing.Point(12, 236);
            this.bttElim.Name = "bttElim";
            this.bttElim.Size = new System.Drawing.Size(75, 23);
            this.bttElim.TabIndex = 5;
            this.bttElim.Text = "Eliminar";
            this.bttElim.UseVisualStyleBackColor = true;
            // 
            // bttLimpiar
            // 
            this.bttLimpiar.Location = new System.Drawing.Point(114, 236);
            this.bttLimpiar.Name = "bttLimpiar";
            this.bttLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bttLimpiar.TabIndex = 6;
            this.bttLimpiar.Text = "Limpiar";
            this.bttLimpiar.UseVisualStyleBackColor = true;
            // 
            // Regresarbtt
            // 
            this.Regresarbtt.Location = new System.Drawing.Point(224, 236);
            this.Regresarbtt.Name = "Regresarbtt";
            this.Regresarbtt.Size = new System.Drawing.Size(75, 23);
            this.Regresarbtt.TabIndex = 7;
            this.Regresarbtt.Text = "Regresar";
            this.Regresarbtt.UseVisualStyleBackColor = true;
            // 
            // Elim_Clien_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 307);
            this.Controls.Add(this.Regresarbtt);
            this.Controls.Add(this.bttLimpiar);
            this.Controls.Add(this.bttElim);
            this.Controls.Add(this.bttBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtID_Cliente);
            this.Controls.Add(this.ID_Clientelbl);
            this.Controls.Add(this.Titulolbl);
            this.Name = "Elim_Clien_Mantenimiento";
            this.Text = "Elim_Clien_Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulolbl;
        private System.Windows.Forms.Label ID_Clientelbl;
        private System.Windows.Forms.TextBox txtID_Cliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttBuscar;
        private System.Windows.Forms.Button bttElim;
        private System.Windows.Forms.Button bttLimpiar;
        private System.Windows.Forms.Button Regresarbtt;
    }
}