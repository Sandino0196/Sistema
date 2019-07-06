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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        int row = 0;

        protected override void OnClosed(EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            men.Show();
        }

        private void bttRegresar_Click(object sender, EventArgs e)
        {

        }

        private void bttAceptar_Click(object sender, EventArgs e)
        {

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
            
        }

        private void bttBuscar_Click(object sender, EventArgs e)
        {
            if(BD.Busqueda_Articulo(int.Parse(txtNumRecibo.Text),txtNumSerie.Text) > 0)
            {
                txtArticulo.Text = Articulos.descripcion;
                txtEstado.Text = Articulos.estado;
                txtMonto.Text = Articulos.prestado.ToString();
            }
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            dtgvArticulos.Rows.Add();
            dtgvArticulos.Rows[row].Cells[0].Value = Articulos.descripcion;
            dtgvArticulos.Rows[row].Cells[1].Value = Articulos.marca;
            dtgvArticulos.Rows[row].Cells[2].Value = Articulos.modelo;
            dtgvArticulos.Rows[row].Cells[3].Value = txtPrecio.Text;

            Articulos.precioPago += double.Parse(txtPrecio.Text);

            txtNumRecibo.Text = "";
            txtNumSerie.Text = "";
            txtArticulo.Text = "";
            txtEstado.Text = "";
            txtMonto.Text = "";
            txtPrecio.Text = "";

            row++;
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Venta venta = new Venta();
            venta.Show();
        }
    }
}
