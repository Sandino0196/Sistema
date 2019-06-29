namespace Sistema_Empenos_Anderson
{
    partial class Ingreso_de_Cliente
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
            this.lblBusqueda_ID = new System.Windows.Forms.Label();
            this.txtBusqueda_ID = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpInfo_Nuevo_Cliente = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_Info_Cliente = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_Electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grpInfo_Nuevo_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Info_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda_ID
            // 
            this.lblBusqueda_ID.AutoSize = true;
            this.lblBusqueda_ID.Location = new System.Drawing.Point(70, 77);
            this.lblBusqueda_ID.Name = "lblBusqueda_ID";
            this.lblBusqueda_ID.Size = new System.Drawing.Size(161, 13);
            this.lblBusqueda_ID.TabIndex = 0;
            this.lblBusqueda_ID.Text = "Numero de Identidad del Cliente:";
            // 
            // txtBusqueda_ID
            // 
            this.txtBusqueda_ID.Location = new System.Drawing.Point(238, 77);
            this.txtBusqueda_ID.Name = "txtBusqueda_ID";
            this.txtBusqueda_ID.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda_ID.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(263, 103);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpInfo_Nuevo_Cliente
            // 
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.txtCorreo);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.label5);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.txtTelefono);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.label4);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.txtApellido);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.label3);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.txtNombre);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.label2);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.txtIdentidad);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.label1);
            this.grpInfo_Nuevo_Cliente.Enabled = false;
            this.grpInfo_Nuevo_Cliente.Location = new System.Drawing.Point(463, 17);
            this.grpInfo_Nuevo_Cliente.Name = "grpInfo_Nuevo_Cliente";
            this.grpInfo_Nuevo_Cliente.Size = new System.Drawing.Size(238, 174);
            this.grpInfo_Nuevo_Cliente.TabIndex = 3;
            this.grpInfo_Nuevo_Cliente.TabStop = false;
            this.grpInfo_Nuevo_Cliente.Text = "Añadir un Cliente:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(100, 127);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Correo Electronico:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(100, 100);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefono:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(100, 74);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Location = new System.Drawing.Point(100, 22);
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(100, 20);
            this.txtIdentidad.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identidad:";
            // 
            // dtgv_Info_Cliente
            // 
            this.dtgv_Info_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Info_Cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Telefono,
            this.Correo_Electronico});
            this.dtgv_Info_Cliente.Location = new System.Drawing.Point(12, 147);
            this.dtgv_Info_Cliente.Name = "dtgv_Info_Cliente";
            this.dtgv_Info_Cliente.Size = new System.Drawing.Size(443, 47);
            this.dtgv_Info_Cliente.TabIndex = 4;
            this.dtgv_Info_Cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Correo_Electronico
            // 
            this.Correo_Electronico.HeaderText = "Correo_Electronico";
            this.Correo_Electronico.Name = "Correo_Electronico";
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Enabled = false;
            this.btnAvanzar.Location = new System.Drawing.Point(371, 218);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(75, 23);
            this.btnAvanzar.TabIndex = 5;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 218);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Enabled = false;
            this.btnAñadir.Location = new System.Drawing.Point(615, 197);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 7;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 33);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sistema de Empeños Anderson";
            // 
            // Ingreso_de_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 253);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.dtgv_Info_Cliente);
            this.Controls.Add(this.grpInfo_Nuevo_Cliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda_ID);
            this.Controls.Add(this.lblBusqueda_ID);
            this.Name = "Ingreso_de_Cliente";
            this.Text = "Ingreso de Cliente";
            this.Load += new System.EventHandler(this.Ingreso_de_Cliente_Load);
            this.grpInfo_Nuevo_Cliente.ResumeLayout(false);
            this.grpInfo_Nuevo_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Info_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusqueda_ID;
        private System.Windows.Forms.TextBox txtBusqueda_ID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpInfo_Nuevo_Cliente;
        private System.Windows.Forms.DataGridView dtgv_Info_Cliente;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_Electronico;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label label6;
    }
}