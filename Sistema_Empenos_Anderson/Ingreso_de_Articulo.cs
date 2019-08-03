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

        private int Validar_Monto(string campo)
        {
            string Monto;
            double  x;
            bool verificador;
            Monto = campo;

            if(verificador = Double.TryParse(Monto.ToString(), out x) == true)
                return 1;
            else{
                return 0;
            }    
        }

        private void Limpiar()
        {
            txtCod_Recibo.Enabled = false;
            txtNumero_Serie.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtMonto.Text = "";
            txtTasa.Text = "";
            txtNumero_Serie.Focus();
        }

        public void llenarDataGrid() { 
}
        public static int Ingreso = 0, row=0;

        protected override void OnClosed(EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu(Objetos_Globales.usuario.codigo_Tipo_Usuario);
            men.Show();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            BD.Ingreso_Recibo(int.Parse(txtCod_Recibo.Text), Objetos_Globales.cliente.identidad_Cliente, Objetos_Globales.usuario.codigo_Usuario, clndrFecha.TodayDate.ToString());
            for(int i = 0; i < Objetos_Globales.articulos.Count ; i++)
                BD.Ingreso_Articulo(int.Parse(txtCod_Recibo.Text), ((Articulo)Objetos_Globales.articulos[i]).NumeroSerie,
                    ((Articulo)Objetos_Globales.articulos[i]).CodigoTipo, ((Articulo)Objetos_Globales.articulos[i]).Descripcion,
                    ((Articulo)Objetos_Globales.articulos[i]).Marca, ((Articulo)Objetos_Globales.articulos[i]).Modelo, 
                    ((Articulo)Objetos_Globales.articulos[i]).Prestado, ((Articulo)Objetos_Globales.articulos[i]).Interes, 1,
                    ((Articulo)Objetos_Globales.articulos[i]).Meses, "Articulo");
            MessageBoxTemporal.Show("Transaccion finalizada", "Listo", 1, false);
            Menu men = new Sistema_Empenos_Anderson.Menu(Objetos_Globales.usuario.codigo_Tipo_Usuario);
            men.Show();
            this.Dispose();
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
            this.Hide();
            Ingreso_de_Cliente ingreso = new Ingreso_de_Cliente();
            ingreso.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtCod_Recibo.Text=="" || Validar_Monto(txtCod_Recibo.Text)==0 || txtNumero_Serie.Text=="" || txtDescripcion.Text=="" || txtMarca.Text=="" || txtModelo.Text=="" || Validar_Monto(txtMonto.Text)==0 || txtMonto.Text=="" || Validar_Monto(txtTasa.Text)==0)
            {
                MessageBoxTemporal.Show("Ha ingresado incorrectamente algunos datos!\nPorfavor Reviselos.", "Alerta",2,false);
            }
            else
            {
                Objetos_Globales.articulos.Add(new Articulo(1, double.Parse(txtMonto.Text),
                double.Parse(txtTasa.Text), txtDescripcion.Text, txtMarca.Text, txtModelo.Text,
                "En Prenda", txtNumero_Serie.Text, cmbTipo_Articulo.SelectedItem.ToString(),
                cmbTipo_Articulo.SelectedIndex + 1, int.Parse(txtCod_Recibo.Text)));
                dtgvArticulos.Rows.Add();
                dtgvArticulos.Rows[row].Cells[0].Value = txtNumero_Serie.Text;
                dtgvArticulos.Rows[row].Cells[1].Value = txtDescripcion.Text;
                dtgvArticulos.Rows[row].Cells[2].Value = cmbTipo_Articulo.SelectedItem.ToString();
                dtgvArticulos.Rows[row].Cells[3].Value = txtMarca.Text;
                dtgvArticulos.Rows[row].Cells[4].Value = txtModelo.Text;
                row++;
                Limpiar();
            }
            
        }
    }
}
