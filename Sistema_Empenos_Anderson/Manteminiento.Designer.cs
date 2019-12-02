namespace Sistema_Empenos_Anderson
{
    partial class Manteminiento
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClientes.Location = new System.Drawing.Point(12, 7);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(138, 70);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Mantenimiento de Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnArticulos.Location = new System.Drawing.Point(576, 7);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(138, 70);
            this.btnArticulos.TabIndex = 1;
            this.btnArticulos.Text = "Mantenimiento de Artículos";
            this.btnArticulos.UseVisualStyleBackColor = false;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUsuarios.Location = new System.Drawing.Point(12, 115);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(138, 70);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Mantenimiento de Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(223, 132);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(138, 70);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(575, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnArticulos);
            this.panel1.Location = new System.Drawing.Point(13, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 200);
            this.panel1.TabIndex = 4;
            // 
            // Manteminiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(743, 236);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Manteminiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de Manteminiento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Manteminiento_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}