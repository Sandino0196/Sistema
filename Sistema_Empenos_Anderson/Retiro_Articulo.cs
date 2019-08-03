using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class Retiro_Articulo : Form
    {
        private Label label6;
        private Label label2;
        private TextBox txtRecibo;
        private TextBox txtSerie;
        private Label label3;
        private DataGridView dtgvInfo;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Monto;
        private Button btnSearch;

        protected override void OnClosed(EventArgs e)
        {
            this.Dispose();
            Menu men = new Menu(Objetos_Globales.usuario.codigo_Tipo_Usuario);
            men.Show();
        }
        public Retiro_Articulo()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvInfo = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sistema de Empeños Anderson";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Numero de Recibo:";
            // 
            // txtRecibo
            // 
            this.txtRecibo.Location = new System.Drawing.Point(146, 70);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(100, 20);
            this.txtRecibo.TabIndex = 14;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(369, 70);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 20);
            this.txtSerie.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Numero de Serie:";
            // 
            // dtgvInfo
            // 
            this.dtgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Marca,
            this.Modelo,
            this.Monto});
            this.dtgvInfo.Location = new System.Drawing.Point(12, 111);
            this.dtgvInfo.Name = "dtgvInfo";
            this.dtgvInfo.Size = new System.Drawing.Size(586, 138);
            this.dtgvInfo.TabIndex = 17;
            this.dtgvInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(492, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripcion";
            this.Description.Name = "Description";
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Description.Width = 150;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Marca.Width = 150;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Modelo.Width = 150;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto a Pagar";
            this.Monto.Name = "Monto";
            // 
            // Retiro_Articulo
            // 
            this.ClientSize = new System.Drawing.Size(610, 329);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtgvInfo);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRecibo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Name = "Retiro_Articulo";
            this.Text = "Retiro de Articulos";
            this.Load += new System.EventHandler(this.Retiro_Articulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Retiro_Articulo_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(BD.Busqueda_Articulo(int.Parse(txtRecibo.Text), txtSerie.Text.ToString()) > 0)
            {
                dtgvInfo.Rows[0].Cells[0].Value = Objetos_Mantenimiento.articuloMantenimiento.Descripcion;
                dtgvInfo.Rows[0].Cells[1].Value = Objetos_Mantenimiento.articuloMantenimiento.Marca;
                dtgvInfo.Rows[0].Cells[2].Value = Objetos_Mantenimiento.articuloMantenimiento.Modelo;
                dtgvInfo.Rows[0].Cells[3].Value = Objetos_Globales.articulo.PrecioPago(Objetos_Mantenimiento.articuloMantenimiento.Meses);
            }
            else
            {
                MessageBoxTemporal.Show("No se encontro el Articulo","Error", 1, false);
            }
        }
    }
}
