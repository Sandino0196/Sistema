using System;
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
            Menu men = new Sistema_Empenos_Anderson.Menu(Objetos_Globales.usuario.codigo_Usuario);
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
                txtArticulo.Text = Objetos_Mantenimiento.articuloMantenimiento.Descripcion;
                txtEstado.Text = Objetos_Mantenimiento.articuloMantenimiento.Estado;
                txtMonto.Text = Objetos_Mantenimiento.articuloMantenimiento.Prestado.ToString();
            }
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            if (!Objetos_Mantenimiento.articuloMantenimiento.Descripcion.Equals(""))
            {
                if (Objetos_Mantenimiento.articuloMantenimiento.Equals("Vencido"))
                {
                    Objetos_Globales.articulos.Add(new Articulo(Objetos_Mantenimiento.articuloMantenimiento.Meses, Objetos_Mantenimiento.articuloMantenimiento.Prestado, Objetos_Mantenimiento.articuloMantenimiento.Interes, Objetos_Mantenimiento.articuloMantenimiento.Descripcion,
                    Objetos_Mantenimiento.articuloMantenimiento.Marca, Objetos_Mantenimiento.articuloMantenimiento.Modelo, Objetos_Mantenimiento.articuloMantenimiento.Estado, Objetos_Mantenimiento.articuloMantenimiento.NumeroSerie, Objetos_Mantenimiento.articuloMantenimiento.Tipo, Objetos_Mantenimiento.articuloMantenimiento.CodigoTipo,
                    Objetos_Mantenimiento.articuloMantenimiento.NumeroRecibo));
                    dtgvArticulos.Rows.Add();
                    dtgvArticulos.Rows[row].Cells[0].Value = Objetos_Mantenimiento.articuloMantenimiento.Descripcion;
                    dtgvArticulos.Rows[row].Cells[1].Value = Objetos_Mantenimiento.articuloMantenimiento.Marca;
                    dtgvArticulos.Rows[row].Cells[2].Value = Objetos_Mantenimiento.articuloMantenimiento.Modelo;
                    dtgvArticulos.Rows[row].Cells[3].Value = txtPrecio.Text;

                    ((Articulo)(Objetos_Globales.articulos[row])).MontoPago = double.Parse(txtPrecio.Text);

                    txtNumRecibo.Text = "";
                    txtNumSerie.Text = "";
                    txtArticulo.Text = "";
                    txtEstado.Text = "";
                    txtMonto.Text = "";
                    txtPrecio.Text = "";

                    row++;
                } else if(Objetos_Mantenimiento.articuloMantenimiento.Estado.Equals("Vendido"))
                    MessageBoxTemporal.Show("Este articulo ya fue vendido","Mensaje importante",2,false);
                else if (Objetos_Mantenimiento.articuloMantenimiento.Estado.Equals("Retirado"))
                    MessageBoxTemporal.Show("Este articulo ya fue Retirado", "Mensaje importante", 2, false);
                else
                    MessageBoxTemporal.Show("Este articulo sigue en prenda", "Mensaje importante", 2, false);
            } else
            {
                MessageBoxTemporal.Show("Ingrese un articulo", "Mensaje importante", 2, false);
            }
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Venta venta = new Venta();
            venta.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta_Articulos cons = new Consulta_Articulos();
            cons.Show();
        }
    }
}
