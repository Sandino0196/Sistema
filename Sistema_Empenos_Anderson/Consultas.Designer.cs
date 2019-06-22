namespace Sistema_Empenos_Anderson
{
    partial class Consultas
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelseleccion = new System.Windows.Forms.Label();
            this.lblcambio = new System.Windows.Forms.Label();
            this.cmbseleccion = new System.Windows.Forms.ComboBox();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.cmbtipartic = new System.Windows.Forms.ComboBox();
            this.txtingreso = new System.Windows.Forms.TextBox();
            this.btnregresar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Empeños Anderson";
            // 
            // labelseleccion
            // 
            this.labelseleccion.AutoSize = true;
            this.labelseleccion.Location = new System.Drawing.Point(18, 110);
            this.labelseleccion.Name = "labelseleccion";
            this.labelseleccion.Size = new System.Drawing.Size(149, 13);
            this.labelseleccion.TabIndex = 1;
            this.labelseleccion.Text = "Seleccione Tipo de Consulta: ";
            // 
            // lblcambio
            // 
            this.lblcambio.AutoSize = true;
            this.lblcambio.Location = new System.Drawing.Point(18, 161);
            this.lblcambio.Name = "lblcambio";
            this.lblcambio.Size = new System.Drawing.Size(35, 13);
            this.lblcambio.TabIndex = 2;
            this.lblcambio.Text = "label3";
            // 
            // cmbseleccion
            // 
            this.cmbseleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbseleccion.FormattingEnabled = true;
            this.cmbseleccion.Items.AddRange(new object[] {
            "Identidad del Cliente",
            "Codigo Recibo",
            "Codigo Factura",
            "Tipo de Articulos",
            "Numero de Serie",
            "Estado de Articulos"});
            this.cmbseleccion.Location = new System.Drawing.Point(21, 126);
            this.cmbseleccion.Name = "cmbseleccion";
            this.cmbseleccion.Size = new System.Drawing.Size(163, 21);
            this.cmbseleccion.TabIndex = 3;
            this.cmbseleccion.SelectedIndexChanged += new System.EventHandler(this.cmbseleccion_SelectedIndexChanged);
            // 
            // cmbestado
            // 
            this.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Items.AddRange(new object[] {
            "Caducados",
            "Activos"});
            this.cmbestado.Location = new System.Drawing.Point(21, 177);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(163, 21);
            this.cmbestado.TabIndex = 4;
            // 
            // cmbtipartic
            // 
            this.cmbtipartic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipartic.FormattingEnabled = true;
            this.cmbtipartic.Items.AddRange(new object[] {
            "Electrodomesticos",
            "Joyerias",
            "Dispositivos Moviles",
            "Vehiculos",
            "Entretenimientos"});
            this.cmbtipartic.Location = new System.Drawing.Point(21, 177);
            this.cmbtipartic.Name = "cmbtipartic";
            this.cmbtipartic.Size = new System.Drawing.Size(163, 21);
            this.cmbtipartic.TabIndex = 5;
            // 
            // txtingreso
            // 
            this.txtingreso.Location = new System.Drawing.Point(21, 177);
            this.txtingreso.Name = "txtingreso";
            this.txtingreso.Size = new System.Drawing.Size(163, 20);
            this.txtingreso.TabIndex = 6;
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(21, 409);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(88, 49);
            this.btnregresar.TabIndex = 7;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(60, 219);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(88, 49);
            this.btnaceptar.TabIndex = 8;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView1.Location = new System.Drawing.Point(226, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1047, 337);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Identidad";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Articulo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo Art.";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Marca";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Num Serie";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Estado";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Fecha Entrada";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Fecha Pago";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Cuota";
            this.Column10.Name = "Column10";
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1295, 470);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.txtingreso);
            this.Controls.Add(this.cmbtipartic);
            this.Controls.Add(this.cmbestado);
            this.Controls.Add(this.cmbseleccion);
            this.Controls.Add(this.lblcambio);
            this.Controls.Add(this.labelseleccion);
            this.Controls.Add(this.label1);
            this.Name = "Consultas";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelseleccion;
        private System.Windows.Forms.Label lblcambio;
        private System.Windows.Forms.ComboBox cmbseleccion;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.ComboBox cmbtipartic;
        private System.Windows.Forms.TextBox txtingreso;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}