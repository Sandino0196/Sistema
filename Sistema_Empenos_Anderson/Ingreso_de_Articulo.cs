using System;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class Ingreso_de_Articulo : Form
    {
        public Ingreso_de_Articulo()
        {
            InitializeComponent();
        }

        public void llenarDataGrid() { 
}
        public static int Ingreso = 0, row=0;

        protected override void OnClosed(EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            men.Show();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            men.Show();
            this.Close();
        }

        private void Ingreso_de_Articulo_Load(object sender, EventArgs e)
        {
            Ingreso = 0;
            row = 0;
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
            cmbTipo_Articulo.DataSource = BD.CargarTipoArticulos();
            cmbTipo_Articulo.DisplayMember = "Descripcion";
            cmbTipo_Articulo.ValueMember = "Codigo_Tipo_Articulo";

            if (Objetos_Globales.articulos.Count != 0)
            {
                for (int i = 0; i < Objetos_Globales.articulos.Count; i++)
                {
                    dtgvArticulos.Rows.Add();
                    dtgvArticulos.Rows[i].Cells[0].Value = ((Articulo)Objetos_Globales.articulos[i]).NumeroSerie;
                    dtgvArticulos.Rows[i].Cells[1].Value = ((Articulo)Objetos_Globales.articulos[i]).Descripcion;
                    dtgvArticulos.Rows[i].Cells[2].Value = ((Articulo)Objetos_Globales.articulos[i]).Tipo;
                    dtgvArticulos.Rows[i].Cells[3].Value = ((Articulo)Objetos_Globales.articulos[i]).Marca;
                    dtgvArticulos.Rows[i].Cells[4].Value = ((Articulo)Objetos_Globales.articulos[i]).Modelo;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Ingreso_de_Cliente ingreso = new Ingreso_de_Cliente();
            ingreso.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(Ingreso == 0)
            {
                BD.Ingreso_Recibo(int.Parse(txtCod_Recibo.Text), Objetos_Globales.cliente.identidad_Cliente, Objetos_Globales.usuario.codigo_Usuario, clndrFecha.TodayDate.ToString() );
                Ingreso++;
            }

            MessageBox.Show(Tipo.ToString(), "Titulo");
            BD.Ingreso_Articulo(int.Parse(txtCod_Recibo.Text), txtNumero_Serie.Text, cmbTipo_Articulo.SelectedIndex + 1, txtDescripcion.Text, txtMarca.Text, txtModelo.Text, double.Parse(txtMonto.Text), double.Parse(txtTasa.Text), 1);
            Objetos_Globales.articulos.Add(new Articulo(1, double.Parse(txtMonto.Text) + (double.Parse(txtMonto.Text)* double.Parse(txtTasa.Text)), double.Parse(txtMonto.Text), double.Parse(txtTasa.Text), txtDescripcion.Text, txtMarca.Text, txtModelo.Text,"En Prenda", txtNumero_Serie.Text, cmbTipo_Articulo.SelectedItem.ToString()));
            dtgvArticulos.Rows.Add();
            dtgvArticulos.Rows[row].Cells[0].Value = txtNumero_Serie.Text;
            dtgvArticulos.Rows[row].Cells[1].Value = txtDescripcion.Text;
            dtgvArticulos.Rows[row].Cells[2].Value = cmbTipo_Articulo.SelectedItem.ToString();
            dtgvArticulos.Rows[row].Cells[3].Value = txtMarca.Text;
            dtgvArticulos.Rows[row].Cells[4].Value = txtModelo.Text;
            row++;
        }
    }
}
