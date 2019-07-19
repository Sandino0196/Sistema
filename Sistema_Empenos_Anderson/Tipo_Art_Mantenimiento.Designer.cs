namespace Sistema_Empenos_Anderson
{
    partial class Tipo_Art_Mantenimiento
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
            this.GBArt_Exist = new System.Windows.Forms.GroupBox();
            this.cbxTipo_Art_Elim = new System.Windows.Forms.ComboBox();
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
            this.GBQuitar_Tipo = new System.Windows.Forms.GroupBox();
            this.GB_Añadir_TArt = new System.Windows.Forms.GroupBox();
            this.lblTpArt_Elim = new System.Windows.Forms.Label();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.lblNom_TpArt = new System.Windows.Forms.Label();
            this.txtNom_TpArt = new System.Windows.Forms.TextBox();
            this.bttAñadir = new System.Windows.Forms.Button();
            this.GBArt_Exist.SuspendLayout();
            this.GBQuitar_Tipo.SuspendLayout();
            this.GB_Añadir_TArt.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBArt_Exist
            // 
            this.GBArt_Exist.Controls.Add(this.bttActualizar);
            this.GBArt_Exist.Controls.Add(this.lblTipo);
            this.GBArt_Exist.Controls.Add(this.cbxTipo_Art);
            this.GBArt_Exist.Controls.Add(this.txtArticulo);
            this.GBArt_Exist.Controls.Add(this.lblArt);
            this.GBArt_Exist.Controls.Add(this.bttBuscar);
            this.GBArt_Exist.Controls.Add(this.Recibotxt);
            this.GBArt_Exist.Controls.Add(this.Serietxt);
            this.GBArt_Exist.Controls.Add(this.Num_Reci_lbl);
            this.GBArt_Exist.Controls.Add(this.Num_Se_lbl);
            this.GBArt_Exist.Location = new System.Drawing.Point(12, 12);
            this.GBArt_Exist.Name = "GBArt_Exist";
            this.GBArt_Exist.Size = new System.Drawing.Size(389, 238);
            this.GBArt_Exist.TabIndex = 0;
            this.GBArt_Exist.TabStop = false;
            this.GBArt_Exist.Text = "Cambio Artículos Existentes";
            // 
            // cbxTipo_Art_Elim
            // 
            this.cbxTipo_Art_Elim.FormattingEnabled = true;
            this.cbxTipo_Art_Elim.Items.AddRange(new object[] {
            "Automovil",
            "Joyería",
            "Electrodomesticos",
            "Electrónico"});
            this.cbxTipo_Art_Elim.Location = new System.Drawing.Point(215, 37);
            this.cbxTipo_Art_Elim.Name = "cbxTipo_Art_Elim";
            this.cbxTipo_Art_Elim.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo_Art_Elim.TabIndex = 10;
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
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 165);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(172, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Seleccione Nuevo Tipo de Articulo";
            // 
            // cbxTipo_Art
            // 
            this.cbxTipo_Art.FormattingEnabled = true;
            this.cbxTipo_Art.Items.AddRange(new object[] {
            "Automovil",
            "Joyería",
            "Electrodomesticos",
            "Electrónico"});
            this.cbxTipo_Art.Location = new System.Drawing.Point(215, 162);
            this.cbxTipo_Art.Name = "cbxTipo_Art";
            this.cbxTipo_Art.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo_Art.TabIndex = 7;
            this.cbxTipo_Art.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // GBQuitar_Tipo
            // 
            this.GBQuitar_Tipo.Controls.Add(this.bttEliminar);
            this.GBQuitar_Tipo.Controls.Add(this.lblTpArt_Elim);
            this.GBQuitar_Tipo.Controls.Add(this.cbxTipo_Art_Elim);
            this.GBQuitar_Tipo.Location = new System.Drawing.Point(12, 256);
            this.GBQuitar_Tipo.Name = "GBQuitar_Tipo";
            this.GBQuitar_Tipo.Size = new System.Drawing.Size(389, 116);
            this.GBQuitar_Tipo.TabIndex = 1;
            this.GBQuitar_Tipo.TabStop = false;
            this.GBQuitar_Tipo.Text = "Quitar Tipo de Articulo";
            // 
            // GB_Añadir_TArt
            // 
            this.GB_Añadir_TArt.Controls.Add(this.bttAñadir);
            this.GB_Añadir_TArt.Controls.Add(this.txtNom_TpArt);
            this.GB_Añadir_TArt.Controls.Add(this.lblNom_TpArt);
            this.GB_Añadir_TArt.Location = new System.Drawing.Point(12, 398);
            this.GB_Añadir_TArt.Name = "GB_Añadir_TArt";
            this.GB_Añadir_TArt.Size = new System.Drawing.Size(389, 119);
            this.GB_Añadir_TArt.TabIndex = 2;
            this.GB_Añadir_TArt.TabStop = false;
            this.GB_Añadir_TArt.Text = "Añadir Tipo de Artículo";
            // 
            // lblTpArt_Elim
            // 
            this.lblTpArt_Elim.AutoSize = true;
            this.lblTpArt_Elim.Location = new System.Drawing.Point(10, 40);
            this.lblTpArt_Elim.Name = "lblTpArt_Elim";
            this.lblTpArt_Elim.Size = new System.Drawing.Size(185, 13);
            this.lblTpArt_Elim.TabIndex = 11;
            this.lblTpArt_Elim.Text = "Seleccione Tipo de Articulo a Eliminar";
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(242, 77);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(75, 23);
            this.bttEliminar.TabIndex = 12;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.UseVisualStyleBackColor = true;
            // 
            // lblNom_TpArt
            // 
            this.lblNom_TpArt.AutoSize = true;
            this.lblNom_TpArt.Location = new System.Drawing.Point(10, 40);
            this.lblNom_TpArt.Name = "lblNom_TpArt";
            this.lblNom_TpArt.Size = new System.Drawing.Size(172, 13);
            this.lblNom_TpArt.TabIndex = 0;
            this.lblNom_TpArt.Text = "Ingrese un Nuevo Tipo de Articulo:";
            // 
            // txtNom_TpArt
            // 
            this.txtNom_TpArt.Location = new System.Drawing.Point(236, 37);
            this.txtNom_TpArt.Name = "txtNom_TpArt";
            this.txtNom_TpArt.Size = new System.Drawing.Size(100, 20);
            this.txtNom_TpArt.TabIndex = 1;
            // 
            // bttAñadir
            // 
            this.bttAñadir.Location = new System.Drawing.Point(242, 77);
            this.bttAñadir.Name = "bttAñadir";
            this.bttAñadir.Size = new System.Drawing.Size(75, 23);
            this.bttAñadir.TabIndex = 2;
            this.bttAñadir.Text = "Añadir";
            this.bttAñadir.UseVisualStyleBackColor = true;
            // 
            // Tipo_Art_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 529);
            this.Controls.Add(this.GB_Añadir_TArt);
            this.Controls.Add(this.GBQuitar_Tipo);
            this.Controls.Add(this.GBArt_Exist);
            this.Name = "Tipo_Art_Mantenimiento";
            this.Text = "Tipo_Art_Mantenimiento";
            this.GBArt_Exist.ResumeLayout(false);
            this.GBArt_Exist.PerformLayout();
            this.GBQuitar_Tipo.ResumeLayout(false);
            this.GBQuitar_Tipo.PerformLayout();
            this.GB_Añadir_TArt.ResumeLayout(false);
            this.GB_Añadir_TArt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBArt_Exist;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbxTipo_Art;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.Button bttBuscar;
        private System.Windows.Forms.TextBox Recibotxt;
        private System.Windows.Forms.TextBox Serietxt;
        private System.Windows.Forms.Label Num_Reci_lbl;
        private System.Windows.Forms.Label Num_Se_lbl;
        private System.Windows.Forms.GroupBox GBQuitar_Tipo;
        private System.Windows.Forms.GroupBox GB_Añadir_TArt;
        private System.Windows.Forms.Button bttActualizar;
        private System.Windows.Forms.ComboBox cbxTipo_Art_Elim;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.Label lblTpArt_Elim;
        private System.Windows.Forms.Button bttAñadir;
        private System.Windows.Forms.TextBox txtNom_TpArt;
        private System.Windows.Forms.Label lblNom_TpArt;
    }
}