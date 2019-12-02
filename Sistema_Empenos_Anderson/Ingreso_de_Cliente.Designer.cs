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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpInfo_Nuevo_Cliente = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtIdentidad = new System.Windows.Forms.MaskedTextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_Info_Cliente = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_Electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBusqueda_ID = new System.Windows.Forms.MaskedTextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpInfo_Nuevo_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Info_Cliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBusqueda_ID
            // 
            this.lblBusqueda_ID.AutoSize = true;
            this.lblBusqueda_ID.Location = new System.Drawing.Point(64, 78);
            this.lblBusqueda_ID.Name = "lblBusqueda_ID";
            this.lblBusqueda_ID.Size = new System.Drawing.Size(193, 13);
            this.lblBusqueda_ID.TabIndex = 0;
            this.lblBusqueda_ID.Text = "Numero de Identidad del Cliente:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(289, 104);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpInfo_Nuevo_Cliente
            // 
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.txtTelefono);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.txtIdentidad);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.txtCorreo);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.label5);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.label4);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.txtApellido);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.label3);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.txtNombre);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.label2);
            this.grpInfo_Nuevo_Cliente.Controls.Add(this.label1);
            this.grpInfo_Nuevo_Cliente.Enabled = false;
            this.grpInfo_Nuevo_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo_Nuevo_Cliente.Location = new System.Drawing.Point(526, 18);
            this.grpInfo_Nuevo_Cliente.Name = "grpInfo_Nuevo_Cliente";
            this.grpInfo_Nuevo_Cliente.Size = new System.Drawing.Size(278, 174);
            this.grpInfo_Nuevo_Cliente.TabIndex = 3;
            this.grpInfo_Nuevo_Cliente.TabStop = false;
            this.grpInfo_Nuevo_Cliente.Text = "Añadir un Cliente:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(117, 100);
            this.txtTelefono.Mask = "0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ShortcutsEnabled = false;
            this.txtTelefono.Size = new System.Drawing.Size(116, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Enabled = false;
            this.txtIdentidad.Location = new System.Drawing.Point(117, 19);
            this.txtIdentidad.Mask = "0000-0000-00000";
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.ShortcutsEnabled = false;
            this.txtIdentidad.Size = new System.Drawing.Size(116, 20);
            this.txtIdentidad.TabIndex = 10;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(117, 127);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ShortcutsEnabled = false;
            this.txtCorreo.Size = new System.Drawing.Size(116, 20);
            this.txtCorreo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Correo Electronico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefono:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(117, 74);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(116, 20);
            this.txtApellido.TabIndex = 12;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 48);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(116, 20);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
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
            this.dtgv_Info_Cliente.Location = new System.Drawing.Point(3, 148);
            this.dtgv_Info_Cliente.Name = "dtgv_Info_Cliente";
            this.dtgv_Info_Cliente.ReadOnly = true;
            this.dtgv_Info_Cliente.Size = new System.Drawing.Size(517, 47);
            this.dtgv_Info_Cliente.TabIndex = 4;
            this.dtgv_Info_Cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Correo_Electronico
            // 
            this.Correo_Electronico.HeaderText = "Correo_Electronico";
            this.Correo_Electronico.Name = "Correo_Electronico";
            this.Correo_Electronico.ReadOnly = true;
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAvanzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvanzar.Enabled = false;
            this.btnAvanzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvanzar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAvanzar.Location = new System.Drawing.Point(415, 212);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(87, 30);
            this.btnAvanzar.TabIndex = 5;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = false;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.Enabled = false;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAñadir.Location = new System.Drawing.Point(699, 198);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(87, 30);
            this.btnAñadir.TabIndex = 7;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(15, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 33);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sistema de Empeños Anderson";
            // 
            // txtBusqueda_ID
            // 
            this.txtBusqueda_ID.Location = new System.Drawing.Point(289, 75);
            this.txtBusqueda_ID.Mask = "0000-0000-00000";
            this.txtBusqueda_ID.Name = "txtBusqueda_ID";
            this.txtBusqueda_ID.ShortcutsEnabled = false;
            this.txtBusqueda_ID.Size = new System.Drawing.Size(116, 20);
            this.txtBusqueda_ID.TabIndex = 9;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVolver.Location = new System.Drawing.Point(3, 212);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(87, 30);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.lblBusqueda_ID);
            this.panel1.Controls.Add(this.txtBusqueda_ID);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.grpInfo_Nuevo_Cliente);
            this.panel1.Controls.Add(this.btnAñadir);
            this.panel1.Controls.Add(this.dtgv_Info_Cliente);
            this.panel1.Controls.Add(this.btnAvanzar);
            this.panel1.Location = new System.Drawing.Point(4, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 245);
            this.panel1.TabIndex = 11;
            // 
            // Ingreso_de_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 253);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Ingreso_de_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingreso de Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ingreso_de_Cliente_Load);
            this.grpInfo_Nuevo_Cliente.ResumeLayout(false);
            this.grpInfo_Nuevo_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Info_Cliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBusqueda_ID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpInfo_Nuevo_Cliente;
        private System.Windows.Forms.DataGridView dtgv_Info_Cliente;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_Electronico;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtBusqueda_ID;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtIdentidad;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel1;
    }
}