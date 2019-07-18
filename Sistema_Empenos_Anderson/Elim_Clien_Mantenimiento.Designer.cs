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
            this.bttBuscar = new System.Windows.Forms.Button();
            this.bttElim = new System.Windows.Forms.Button();
            this.bttLimpiar = new System.Windows.Forms.Button();
            this.Regresarbtt = new System.Windows.Forms.Button();
            this.txtID_Cliente = new System.Windows.Forms.MaskedTextBox();
            this.btnActivar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
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
            // bttBuscar
            // 
            this.bttBuscar.Location = new System.Drawing.Point(129, 81);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttBuscar.TabIndex = 4;
            this.bttBuscar.Text = "Buscar";
            this.bttBuscar.UseVisualStyleBackColor = true;
            this.bttBuscar.Click += new System.EventHandler(this.bttBuscar_Click);
            // 
            // bttElim
            // 
            this.bttElim.Location = new System.Drawing.Point(54, 272);
            this.bttElim.Name = "bttElim";
            this.bttElim.Size = new System.Drawing.Size(75, 23);
            this.bttElim.TabIndex = 5;
            this.bttElim.Text = "Eliminar";
            this.bttElim.UseVisualStyleBackColor = true;
            // 
            // bttLimpiar
            // 
            this.bttLimpiar.Location = new System.Drawing.Point(183, 231);
            this.bttLimpiar.Name = "bttLimpiar";
            this.bttLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bttLimpiar.TabIndex = 6;
            this.bttLimpiar.Text = "Limpiar";
            this.bttLimpiar.UseVisualStyleBackColor = true;
            // 
            // Regresarbtt
            // 
            this.Regresarbtt.Location = new System.Drawing.Point(183, 272);
            this.Regresarbtt.Name = "Regresarbtt";
            this.Regresarbtt.Size = new System.Drawing.Size(75, 23);
            this.Regresarbtt.TabIndex = 7;
            this.Regresarbtt.Text = "Regresar";
            this.Regresarbtt.UseVisualStyleBackColor = true;
            // 
            // txtID_Cliente
            // 
            this.txtID_Cliente.Location = new System.Drawing.Point(114, 55);
            this.txtID_Cliente.Mask = "0000-0000-00000";
            this.txtID_Cliente.Name = "txtID_Cliente";
            this.txtID_Cliente.Size = new System.Drawing.Size(100, 20);
            this.txtID_Cliente.TabIndex = 8;
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(54, 231);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 23);
            this.btnActivar.TabIndex = 9;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Estado Cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(129, 123);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(129, 161);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(170, 20);
            this.txtEstado.TabIndex = 13;
            // 
            // Elim_Clien_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 307);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.txtID_Cliente);
            this.Controls.Add(this.Regresarbtt);
            this.Controls.Add(this.bttLimpiar);
            this.Controls.Add(this.bttElim);
            this.Controls.Add(this.bttBuscar);
            this.Controls.Add(this.ID_Clientelbl);
            this.Controls.Add(this.Titulolbl);
            this.Name = "Elim_Clien_Mantenimiento";
            this.Text = "Elim_Clien_Mantenimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulolbl;
        private System.Windows.Forms.Label ID_Clientelbl;
        private System.Windows.Forms.Button bttBuscar;
        private System.Windows.Forms.Button bttElim;
        private System.Windows.Forms.Button bttLimpiar;
        private System.Windows.Forms.Button Regresarbtt;
        private System.Windows.Forms.MaskedTextBox txtID_Cliente;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEstado;
    }
}