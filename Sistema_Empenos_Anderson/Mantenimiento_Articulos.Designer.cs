﻿namespace Sistema_Empenos_Anderson
{
    partial class Mantenimiento_Articulos
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
            this.bttActualizar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbxTipo_Art = new System.Windows.Forms.ComboBox();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.lblArt = new System.Windows.Forms.Label();
            this.bttBuscar = new System.Windows.Forms.Button();
            this.Recibotxt = new System.Windows.Forms.TextBox();
            this.Serietxt = new System.Windows.Forms.TextBox();
            this.Num_Reci_lbl = new System.Windows.Forms.Label();
            this.Num_Se_lbl = new System.Windows.Forms.Label();
            this.bttAñadir = new System.Windows.Forms.Button();
            this.txtNom_TpArt = new System.Windows.Forms.TextBox();
            this.lblNom_TpArt = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnConsultaTipo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTipo_Estado = new System.Windows.Forms.Label();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultaEstado = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttActualizar
            // 
            this.bttActualizar.Location = new System.Drawing.Point(125, 231);
            this.bttActualizar.Name = "bttActualizar";
            this.bttActualizar.Size = new System.Drawing.Size(75, 23);
            this.bttActualizar.TabIndex = 9;
            this.bttActualizar.Text = "Actualizar";
            this.bttActualizar.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 196);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(172, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Seleccione Nuevo Tipo de Articulo";
            // 
            // cbxTipo_Art
            // 
            this.cbxTipo_Art.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo_Art.FormattingEnabled = true;
            this.cbxTipo_Art.Items.AddRange(new object[] {
            "Automovil",
            "Joyería",
            "Electrodomesticos",
            "Electrónico"});
            this.cbxTipo_Art.Location = new System.Drawing.Point(197, 193);
            this.cbxTipo_Art.Name = "cbxTipo_Art";
            this.cbxTipo_Art.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo_Art.TabIndex = 7;
            this.cbxTipo_Art.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(78, 131);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(147, 20);
            this.txtArticulo.TabIndex = 6;
            // 
            // lblArt
            // 
            this.lblArt.AutoSize = true;
            this.lblArt.Location = new System.Drawing.Point(6, 134);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(47, 13);
            this.lblArt.TabIndex = 5;
            this.lblArt.Text = "Artículo:";
            // 
            // bttBuscar
            // 
            this.bttBuscar.Location = new System.Drawing.Point(9, 94);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttBuscar.TabIndex = 4;
            this.bttBuscar.Text = "Buscar";
            this.bttBuscar.UseVisualStyleBackColor = true;
            // 
            // Recibotxt
            // 
            this.Recibotxt.Location = new System.Drawing.Point(140, 62);
            this.Recibotxt.Name = "Recibotxt";
            this.Recibotxt.Size = new System.Drawing.Size(100, 20);
            this.Recibotxt.TabIndex = 3;
            // 
            // Serietxt
            // 
            this.Serietxt.Location = new System.Drawing.Point(140, 24);
            this.Serietxt.Name = "Serietxt";
            this.Serietxt.Size = new System.Drawing.Size(100, 20);
            this.Serietxt.TabIndex = 2;
            // 
            // Num_Reci_lbl
            // 
            this.Num_Reci_lbl.AutoSize = true;
            this.Num_Reci_lbl.Location = new System.Drawing.Point(6, 62);
            this.Num_Reci_lbl.Name = "Num_Reci_lbl";
            this.Num_Reci_lbl.Size = new System.Drawing.Size(99, 13);
            this.Num_Reci_lbl.TabIndex = 1;
            this.Num_Reci_lbl.Text = "Número de Recibo:";
            // 
            // Num_Se_lbl
            // 
            this.Num_Se_lbl.AutoSize = true;
            this.Num_Se_lbl.Location = new System.Drawing.Point(6, 24);
            this.Num_Se_lbl.Name = "Num_Se_lbl";
            this.Num_Se_lbl.Size = new System.Drawing.Size(89, 13);
            this.Num_Se_lbl.TabIndex = 0;
            this.Num_Se_lbl.Text = "Número de Serie:";
            // 
            // bttAñadir
            // 
            this.bttAñadir.Location = new System.Drawing.Point(125, 161);
            this.bttAñadir.Name = "bttAñadir";
            this.bttAñadir.Size = new System.Drawing.Size(100, 39);
            this.bttAñadir.TabIndex = 2;
            this.bttAñadir.Text = "Añadir";
            this.bttAñadir.UseVisualStyleBackColor = true;
            // 
            // txtNom_TpArt
            // 
            this.txtNom_TpArt.Location = new System.Drawing.Point(125, 110);
            this.txtNom_TpArt.Name = "txtNom_TpArt";
            this.txtNom_TpArt.Size = new System.Drawing.Size(100, 20);
            this.txtNom_TpArt.TabIndex = 1;
            // 
            // lblNom_TpArt
            // 
            this.lblNom_TpArt.AutoSize = true;
            this.lblNom_TpArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom_TpArt.Location = new System.Drawing.Point(63, 71);
            this.lblNom_TpArt.Name = "lblNom_TpArt";
            this.lblNom_TpArt.Size = new System.Drawing.Size(247, 16);
            this.lblNom_TpArt.TabIndex = 0;
            this.lblNom_TpArt.Text = "Ingrese un Nuevo Tipo de Articulo:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(349, 297);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnConsultaTipo);
            this.tabPage1.Controls.Add(this.bttActualizar);
            this.tabPage1.Controls.Add(this.cbxTipo_Art);
            this.tabPage1.Controls.Add(this.lblTipo);
            this.tabPage1.Controls.Add(this.Num_Se_lbl);
            this.tabPage1.Controls.Add(this.Num_Reci_lbl);
            this.tabPage1.Controls.Add(this.txtArticulo);
            this.tabPage1.Controls.Add(this.Serietxt);
            this.tabPage1.Controls.Add(this.lblArt);
            this.tabPage1.Controls.Add(this.Recibotxt);
            this.tabPage1.Controls.Add(this.bttBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(341, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cambio de Tipo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnConsultaTipo
            // 
            this.btnConsultaTipo.Location = new System.Drawing.Point(125, 94);
            this.btnConsultaTipo.Name = "btnConsultaTipo";
            this.btnConsultaTipo.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaTipo.TabIndex = 32;
            this.btnConsultaTipo.Text = "Consulta";
            this.btnConsultaTipo.UseVisualStyleBackColor = true;
            this.btnConsultaTipo.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bttAñadir);
            this.tabPage2.Controls.Add(this.txtNom_TpArt);
            this.tabPage2.Controls.Add(this.lblNom_TpArt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(341, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Añadir Tipo de Articulo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Location = new System.Drawing.Point(141, 315);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 49);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btnConsultaEstado);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.lblTipo_Estado);
            this.tabPage3.Controls.Add(this.cmbEstados);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnBuscar);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(341, 271);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cambiar Estado";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblTipo_Estado
            // 
            this.lblTipo_Estado.AutoSize = true;
            this.lblTipo_Estado.Location = new System.Drawing.Point(3, 194);
            this.lblTipo_Estado.Name = "lblTipo_Estado";
            this.lblTipo_Estado.Size = new System.Drawing.Size(131, 13);
            this.lblTipo_Estado.TabIndex = 18;
            this.lblTipo_Estado.Text = "Seleccione Nuevo Estado";
            // 
            // cmbEstados
            // 
            this.cmbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Items.AddRange(new object[] {
            "En Prenda",
            "Retirado",
            "Vencido",
            "Vendido"});
            this.cmbEstados.Location = new System.Drawing.Point(140, 191);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(121, 21);
            this.cmbEstados.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Artículo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(61, 87);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Número de Recibo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Número de Serie:";
            // 
            // btnConsultaEstado
            // 
            this.btnConsultaEstado.Location = new System.Drawing.Point(191, 87);
            this.btnConsultaEstado.Name = "btnConsultaEstado";
            this.btnConsultaEstado.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaEstado.TabIndex = 32;
            this.btnConsultaEstado.Text = "Consulta";
            this.btnConsultaEstado.UseVisualStyleBackColor = true;
            this.btnConsultaEstado.Click += new System.EventHandler(this.btnConsultaEstado_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 20);
            this.textBox4.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Estado:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(78, 157);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(147, 20);
            this.textBox5.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tipo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Mantenimiento_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 391);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tabControl1);
            this.Name = "Mantenimiento_Articulos";
            this.Text = "Mantenimiento de Articulos";
            this.Load += new System.EventHandler(this.Tipo_Art_Mantenimiento_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbxTipo_Art;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.Button bttBuscar;
        private System.Windows.Forms.TextBox Recibotxt;
        private System.Windows.Forms.TextBox Serietxt;
        private System.Windows.Forms.Label Num_Reci_lbl;
        private System.Windows.Forms.Label Num_Se_lbl;
        private System.Windows.Forms.Button bttActualizar;
        private System.Windows.Forms.Button bttAñadir;
        private System.Windows.Forms.TextBox txtNom_TpArt;
        private System.Windows.Forms.Label lblNom_TpArt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnConsultaTipo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTipo_Estado;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsultaEstado;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
    }
}