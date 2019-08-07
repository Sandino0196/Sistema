namespace Sistema_Empenos_Anderson
{
    partial class Mantenimiento_Clientes
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtID_Cliente = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtTelefonoMod = new System.Windows.Forms.MaskedTextBox();
            this.txtCorreoMod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidoMod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarMod = new System.Windows.Forms.Button();
            this.txtIdentidadMod = new System.Windows.Forms.MaskedTextBox();
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
            this.bttBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttBuscar.Location = new System.Drawing.Point(113, 48);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttBuscar.TabIndex = 4;
            this.bttBuscar.Text = "Buscar";
            this.bttBuscar.UseVisualStyleBackColor = true;
            this.bttBuscar.Click += new System.EventHandler(this.bttBuscar_Click);
            // 
            // bttElim
            // 
            this.bttElim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttElim.Enabled = false;
            this.bttElim.Location = new System.Drawing.Point(113, 192);
            this.bttElim.Name = "bttElim";
            this.bttElim.Size = new System.Drawing.Size(75, 23);
            this.bttElim.TabIndex = 5;
            this.bttElim.Text = "Eliminar";
            this.bttElim.UseVisualStyleBackColor = true;
            this.bttElim.Click += new System.EventHandler(this.bttElim_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVolver.Location = new System.Drawing.Point(114, 293);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 48);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtID_Cliente
            // 
            this.txtID_Cliente.Location = new System.Drawing.Point(123, 10);
            this.txtID_Cliente.Mask = "0000-0000-00000";
            this.txtID_Cliente.Name = "txtID_Cliente";
            this.txtID_Cliente.Size = new System.Drawing.Size(100, 20);
            this.txtID_Cliente.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Estado Cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(103, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(103, 127);
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
            this.tabControl1.Size = new System.Drawing.Size(297, 275);
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
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtID_Cliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(289, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Eliminar Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAceptar);
            this.tabPage2.Controls.Add(this.txtTelefonoMod);
            this.tabPage2.Controls.Add(this.txtCorreoMod);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtApellidoMod);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtNombreMod);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnBuscarMod);
            this.tabPage2.Controls.Add(this.txtIdentidadMod);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(289, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(123, 199);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtTelefonoMod
            // 
            this.txtTelefonoMod.Enabled = false;
            this.txtTelefonoMod.Location = new System.Drawing.Point(107, 137);
            this.txtTelefonoMod.Mask = "0000-0000";
            this.txtTelefonoMod.Name = "txtTelefonoMod";
            this.txtTelefonoMod.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoMod.TabIndex = 18;
            // 
            // txtCorreoMod
            // 
            this.txtCorreoMod.Enabled = false;
            this.txtCorreoMod.Location = new System.Drawing.Point(107, 164);
            this.txtCorreoMod.Name = "txtCorreoMod";
            this.txtCorreoMod.Size = new System.Drawing.Size(100, 20);
            this.txtCorreoMod.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Correo Electronico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Telefono:";
            // 
            // txtApellidoMod
            // 
            this.txtApellidoMod.Enabled = false;
            this.txtApellidoMod.Location = new System.Drawing.Point(107, 111);
            this.txtApellidoMod.Name = "txtApellidoMod";
            this.txtApellidoMod.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoMod.TabIndex = 21;
            this.txtApellidoMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoMod_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Apellido:";
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Enabled = false;
            this.txtNombreMod.Location = new System.Drawing.Point(107, 85);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMod.TabIndex = 19;
            this.txtNombreMod.TextChanged += new System.EventHandler(this.txtNombreMod_TextChanged);
            this.txtNombreMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMod_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nombre:";
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
            // btnBuscarMod
            // 
            this.btnBuscarMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarMod.Location = new System.Drawing.Point(123, 46);
            this.btnBuscarMod.Name = "btnBuscarMod";
            this.btnBuscarMod.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMod.TabIndex = 10;
            this.btnBuscarMod.Text = "Buscar";
            this.btnBuscarMod.UseVisualStyleBackColor = true;
            this.btnBuscarMod.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdentidadMod
            // 
            this.txtIdentidadMod.Location = new System.Drawing.Point(107, 9);
            this.txtIdentidadMod.Mask = "0000-0000-00000";
            this.txtIdentidadMod.Name = "txtIdentidadMod";
            this.txtIdentidadMod.Size = new System.Drawing.Size(100, 20);
            this.txtIdentidadMod.TabIndex = 11;
            // 
            // Mantenimiento_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(319, 354);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnVolver);
            this.MaximizeBox = false;
            this.Name = "Mantenimiento_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Clientes";
            this.Load += new System.EventHandler(this.Mantenimiento_Clientes_Load);
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
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.MaskedTextBox txtID_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarMod;
        private System.Windows.Forms.MaskedTextBox txtIdentidadMod;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MaskedTextBox txtTelefonoMod;
        private System.Windows.Forms.TextBox txtCorreoMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidoMod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.Label label7;
    }
}