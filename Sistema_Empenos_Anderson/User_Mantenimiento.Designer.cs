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
            this.tabCUsuario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAceptarTipo = new System.Windows.Forms.Button();
            this.lblNom_User = new System.Windows.Forms.Label();
            this.lblTp_User = new System.Windows.Forms.Label();
            this.cbxTp_User_Modificar = new System.Windows.Forms.ComboBox();
            this.txtNom_User_Tipo = new System.Windows.Forms.TextBox();
            this.btnBuscarTipo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPassConfirmar_Change = new System.Windows.Forms.TextBox();
            this.txtPassNuevo_Change = new System.Windows.Forms.TextBox();
            this.txtPass_Change = new System.Windows.Forms.TextBox();
            this.btnAceptarPassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom_User_Pass = new System.Windows.Forms.TextBox();
            this.btnBuscarPassword = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxTp_User_New = new System.Windows.Forms.ComboBox();
            this.txtPassConfirmar_New = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassNuevo_New = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNom_User_Nuevo = new System.Windows.Forms.TextBox();
            this.btnAceptarNew = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tabCUsuario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCUsuario
            // 
            this.tabCUsuario.Controls.Add(this.tabPage1);
            this.tabCUsuario.Controls.Add(this.tabPage2);
            this.tabCUsuario.Controls.Add(this.tabPage3);
            this.tabCUsuario.Location = new System.Drawing.Point(12, 12);
            this.tabCUsuario.Name = "tabCUsuario";
            this.tabCUsuario.SelectedIndex = 0;
            this.tabCUsuario.Size = new System.Drawing.Size(328, 237);
            this.tabCUsuario.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAceptarTipo);
            this.tabPage1.Controls.Add(this.lblNom_User);
            this.tabPage1.Controls.Add(this.lblTp_User);
            this.tabPage1.Controls.Add(this.cbxTp_User_Modificar);
            this.tabPage1.Controls.Add(this.txtNom_User_Tipo);
            this.tabPage1.Controls.Add(this.btnBuscarTipo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(320, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modificar Tipo Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAceptarTipo
            // 
            this.btnAceptarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarTipo.Enabled = false;
            this.btnAceptarTipo.Location = new System.Drawing.Point(115, 131);
            this.btnAceptarTipo.Name = "btnAceptarTipo";
            this.btnAceptarTipo.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarTipo.TabIndex = 5;
            this.btnAceptarTipo.Text = "Aceptar";
            this.btnAceptarTipo.UseVisualStyleBackColor = true;
            this.btnAceptarTipo.Click += new System.EventHandler(this.btnAceptarTipo_Click);
            // 
            // lblNom_User
            // 
            this.lblNom_User.AutoSize = true;
            this.lblNom_User.Location = new System.Drawing.Point(6, 17);
            this.lblNom_User.Name = "lblNom_User";
            this.lblNom_User.Size = new System.Drawing.Size(103, 13);
            this.lblNom_User.TabIndex = 0;
            this.lblNom_User.Text = "Nombre del Usuario:";
            // 
            // lblTp_User
            // 
            this.lblTp_User.AutoSize = true;
            this.lblTp_User.Location = new System.Drawing.Point(6, 93);
            this.lblTp_User.Name = "lblTp_User";
            this.lblTp_User.Size = new System.Drawing.Size(82, 13);
            this.lblTp_User.TabIndex = 3;
            this.lblTp_User.Text = "Tipo de Usuario";
            // 
            // cbxTp_User_Modificar
            // 
            this.cbxTp_User_Modificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTp_User_Modificar.Enabled = false;
            this.cbxTp_User_Modificar.FormattingEnabled = true;
            this.cbxTp_User_Modificar.Location = new System.Drawing.Point(115, 90);
            this.cbxTp_User_Modificar.Name = "cbxTp_User_Modificar";
            this.cbxTp_User_Modificar.Size = new System.Drawing.Size(121, 21);
            this.cbxTp_User_Modificar.TabIndex = 4;
            // 
            // txtNom_User_Tipo
            // 
            this.txtNom_User_Tipo.Location = new System.Drawing.Point(115, 14);
            this.txtNom_User_Tipo.Name = "txtNom_User_Tipo";
            this.txtNom_User_Tipo.Size = new System.Drawing.Size(100, 20);
            this.txtNom_User_Tipo.TabIndex = 1;
            // 
            // btnBuscarTipo
            // 
            this.btnBuscarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarTipo.Location = new System.Drawing.Point(115, 49);
            this.btnBuscarTipo.Name = "btnBuscarTipo";
            this.btnBuscarTipo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTipo.TabIndex = 2;
            this.btnBuscarTipo.Text = "Buscar";
            this.btnBuscarTipo.UseVisualStyleBackColor = true;
            this.btnBuscarTipo.Click += new System.EventHandler(this.btnBuscarTipo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtPassConfirmar_Change);
            this.tabPage2.Controls.Add(this.txtPassNuevo_Change);
            this.tabPage2.Controls.Add(this.txtPass_Change);
            this.tabPage2.Controls.Add(this.btnAceptarPassword);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtNom_User_Pass);
            this.tabPage2.Controls.Add(this.btnBuscarPassword);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(320, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cambiar Password";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPassConfirmar_Change
            // 
            this.txtPassConfirmar_Change.Enabled = false;
            this.txtPassConfirmar_Change.Location = new System.Drawing.Point(164, 132);
            this.txtPassConfirmar_Change.Name = "txtPassConfirmar_Change";
            this.txtPassConfirmar_Change.PasswordChar = '*';
            this.txtPassConfirmar_Change.Size = new System.Drawing.Size(131, 20);
            this.txtPassConfirmar_Change.TabIndex = 12;
            // 
            // txtPassNuevo_Change
            // 
            this.txtPassNuevo_Change.Enabled = false;
            this.txtPassNuevo_Change.Location = new System.Drawing.Point(115, 99);
            this.txtPassNuevo_Change.Name = "txtPassNuevo_Change";
            this.txtPassNuevo_Change.PasswordChar = '*';
            this.txtPassNuevo_Change.Size = new System.Drawing.Size(131, 20);
            this.txtPassNuevo_Change.TabIndex = 11;
            // 
            // txtPass_Change
            // 
            this.txtPass_Change.Enabled = false;
            this.txtPass_Change.Location = new System.Drawing.Point(115, 65);
            this.txtPass_Change.Name = "txtPass_Change";
            this.txtPass_Change.PasswordChar = '*';
            this.txtPass_Change.Size = new System.Drawing.Size(131, 20);
            this.txtPass_Change.TabIndex = 10;
            // 
            // btnAceptarPassword
            // 
            this.btnAceptarPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarPassword.Enabled = false;
            this.btnAceptarPassword.Location = new System.Drawing.Point(128, 167);
            this.btnAceptarPassword.Name = "btnAceptarPassword";
            this.btnAceptarPassword.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarPassword.TabIndex = 9;
            this.btnAceptarPassword.Text = "Aceptar";
            this.btnAceptarPassword.UseVisualStyleBackColor = true;
            this.btnAceptarPassword.Click += new System.EventHandler(this.btnAceptarPassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirmacion password nueva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password nueva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password actual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del Usuario:";
            // 
            // txtNom_User_Pass
            // 
            this.txtNom_User_Pass.Location = new System.Drawing.Point(115, 10);
            this.txtNom_User_Pass.Name = "txtNom_User_Pass";
            this.txtNom_User_Pass.Size = new System.Drawing.Size(131, 20);
            this.txtNom_User_Pass.TabIndex = 4;
            // 
            // btnBuscarPassword
            // 
            this.btnBuscarPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPassword.Location = new System.Drawing.Point(128, 36);
            this.btnBuscarPassword.Name = "btnBuscarPassword";
            this.btnBuscarPassword.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPassword.TabIndex = 5;
            this.btnBuscarPassword.Text = "Buscar";
            this.btnBuscarPassword.UseVisualStyleBackColor = true;
            this.btnBuscarPassword.Click += new System.EventHandler(this.btnBuscarPassword_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.cbxTp_User_New);
            this.tabPage3.Controls.Add(this.txtPassConfirmar_New);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtPassNuevo_New);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtNom_User_Nuevo);
            this.tabPage3.Controls.Add(this.btnAceptarNew);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(320, 211);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nuevo Usuario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tipo de Usuario";
            // 
            // cbxTp_User_New
            // 
            this.cbxTp_User_New.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTp_User_New.FormattingEnabled = true;
            this.cbxTp_User_New.Location = new System.Drawing.Point(112, 128);
            this.cbxTp_User_New.Name = "cbxTp_User_New";
            this.cbxTp_User_New.Size = new System.Drawing.Size(131, 21);
            this.cbxTp_User_New.TabIndex = 14;
            // 
            // txtPassConfirmar_New
            // 
            this.txtPassConfirmar_New.Location = new System.Drawing.Point(112, 88);
            this.txtPassConfirmar_New.Name = "txtPassConfirmar_New";
            this.txtPassConfirmar_New.PasswordChar = '*';
            this.txtPassConfirmar_New.Size = new System.Drawing.Size(131, 20);
            this.txtPassConfirmar_New.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Confirme Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password:";
            // 
            // txtPassNuevo_New
            // 
            this.txtPassNuevo_New.Location = new System.Drawing.Point(112, 54);
            this.txtPassNuevo_New.Name = "txtPassNuevo_New";
            this.txtPassNuevo_New.PasswordChar = '*';
            this.txtPassNuevo_New.Size = new System.Drawing.Size(131, 20);
            this.txtPassNuevo_New.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre del Usuario:";
            // 
            // txtNom_User_Nuevo
            // 
            this.txtNom_User_Nuevo.Location = new System.Drawing.Point(112, 14);
            this.txtNom_User_Nuevo.Name = "txtNom_User_Nuevo";
            this.txtNom_User_Nuevo.Size = new System.Drawing.Size(131, 20);
            this.txtNom_User_Nuevo.TabIndex = 7;
            // 
            // btnAceptarNew
            // 
            this.btnAceptarNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarNew.Location = new System.Drawing.Point(127, 172);
            this.btnAceptarNew.Name = "btnAceptarNew";
            this.btnAceptarNew.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarNew.TabIndex = 8;
            this.btnAceptarNew.Text = "Aceptar";
            this.btnAceptarNew.UseVisualStyleBackColor = true;
            this.btnAceptarNew.Click += new System.EventHandler(this.btnAceptarNew_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Location = new System.Drawing.Point(128, 269);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 49);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // User_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 343);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tabCUsuario);
            this.Name = "User_Mantenimiento";
            this.Text = "User_Mantenimiento";
            this.Load += new System.EventHandler(this.User_Mantenimiento_Load);
            this.tabCUsuario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCUsuario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAceptarTipo;
        private System.Windows.Forms.Label lblNom_User;
        private System.Windows.Forms.Label lblTp_User;
        private System.Windows.Forms.ComboBox cbxTp_User_Modificar;
        private System.Windows.Forms.TextBox txtNom_User_Tipo;
        private System.Windows.Forms.Button btnBuscarTipo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtPassConfirmar_Change;
        private System.Windows.Forms.TextBox txtPassNuevo_Change;
        private System.Windows.Forms.TextBox txtPass_Change;
        private System.Windows.Forms.Button btnAceptarPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom_User_Pass;
        private System.Windows.Forms.Button btnBuscarPassword;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNom_User_Nuevo;
        private System.Windows.Forms.Button btnAceptarNew;
        private System.Windows.Forms.TextBox txtPassConfirmar_New;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassNuevo_New;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxTp_User_New;
    }
}