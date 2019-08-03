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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID_Clientelbl
            // 
            this.ID_Clientelbl.AutoSize = true;
            this.ID_Clientelbl.Location = new System.Drawing.Point(22, 13);
            this.ID_Clientelbl.Name = "ID_Clientelbl";
            this.ID_Clientelbl.Size = new System.Drawing.Size(89, 13);
            this.ID_Clientelbl.TabIndex = 1;
            this.ID_Clientelbl.Text = "Identidad Cliente:";
            // 
            // bttBuscar
            // 
            this.bttBuscar.Location = new System.Drawing.Point(139, 47);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttBuscar.TabIndex = 4;
            this.bttBuscar.Text = "Buscar";
            this.bttBuscar.UseVisualStyleBackColor = true;
            this.bttBuscar.Click += new System.EventHandler(this.bttBuscar_Click);
            // 
            // bttElim
            // 
            this.bttElim.Location = new System.Drawing.Point(64, 238);
            this.bttElim.Name = "bttElim";
            this.bttElim.Size = new System.Drawing.Size(75, 23);
            this.bttElim.TabIndex = 5;
            this.bttElim.Text = "Eliminar";
            this.bttElim.UseVisualStyleBackColor = true;
            this.bttElim.Click += new System.EventHandler(this.bttElim_Click);
            // 
            // bttLimpiar
            // 
            this.bttLimpiar.Location = new System.Drawing.Point(193, 197);
            this.bttLimpiar.Name = "bttLimpiar";
            this.bttLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bttLimpiar.TabIndex = 6;
            this.bttLimpiar.Text = "Limpiar";
            this.bttLimpiar.UseVisualStyleBackColor = true;
            // 
            // Regresarbtt
            // 
            this.Regresarbtt.Location = new System.Drawing.Point(193, 238);
            this.Regresarbtt.Name = "Regresarbtt";
            this.Regresarbtt.Size = new System.Drawing.Size(75, 23);
            this.Regresarbtt.TabIndex = 7;
            this.Regresarbtt.Text = "Regresar";
            this.Regresarbtt.UseVisualStyleBackColor = true;
            // 
            // txtID_Cliente
            // 
            this.txtID_Cliente.Location = new System.Drawing.Point(123, 10);
            this.txtID_Cliente.Mask = "0000-0000-00000";
            this.txtID_Cliente.Name = "txtID_Cliente";
            this.txtID_Cliente.Size = new System.Drawing.Size(100, 20);
            this.txtID_Cliente.TabIndex = 8;
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(64, 197);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 23);
            this.btnActivar.TabIndex = 9;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Estado Cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(139, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(139, 127);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(170, 20);
            this.txtEstado.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 305);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bttElim);
            this.tabPage1.Controls.Add(this.txtEstado);
            this.tabPage1.Controls.Add(this.ID_Clientelbl);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.bttBuscar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.bttLimpiar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Regresarbtt);
            this.tabPage1.Controls.Add(this.btnActivar);
            this.tabPage1.Controls.Add(this.txtID_Cliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.maskedTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(421, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Identidad Cliente:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(107, 9);
            this.maskedTextBox1.Mask = "0000-0000-00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 11;
            // 
            // Elim_Clien_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 425);
            this.Controls.Add(this.tabControl1);
            this.Name = "Elim_Clien_Mantenimiento";
            this.Text = "Elim_Clien_Mantenimiento";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}