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
            Menu men = new Sistema_Empenos_Anderson.Menu();
            men.Show();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
            if(Objetos_Globales.articulos.Count != 0)
            {
                for(int i = 0; i < Objetos_Globales.articulos.Count; i++)
                {
                    dtgvArticulos.Rows.Add();
                    dtgvArticulos.Rows[i].Cells[0].Value = ((Articulo)Objetos_Globales.articulos[i]).Descripcion;                    
                    dtgvArticulos.Rows[i].Cells[1].Value = ((Articulo)Objetos_Globales.articulos[i]).Marca;
                    dtgvArticulos.Rows[i].Cells[2].Value = ((Articulo)Objetos_Globales.articulos[i]).Modelo;
                    dtgvArticulos.Rows[i].Cells[3].Value = ((Articulo)Objetos_Globales.articulos[i]).MontoPago;
                }
            }
        }

        private void bttBuscar_Click(object sender, EventArgs e)
        {
            if(BD.Busqueda_Articulo(int.Parse(txtNumRecibo.Text),txtNumSerie.Text) > 0)
            {
                txtArticulo.Text = Objetos_Mantenimiento.articuloMantenimiento.Descripcion;
                txtEstado.Text = Objetos_Mantenimiento.articuloMantenimiento.Estado;
                txtMonto.Text = Objetos_Mantenimiento.articuloMantenimiento.Prestado.ToString();
                bttAgregar.Enabled = true;
            } else
            {
                MessageBoxTemporal.Show("Artículo no encontrado", "Mensaje importante", 2, false);
                bttAgregar.Enabled = false;
            }
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            if (!Objetos_Mantenimiento.articuloMantenimiento.Descripcion.Equals(""))
            {
                if (Objetos_Mantenimiento.articuloMantenimiento.Estado.Equals("Vencido"))
                {
                    Objetos_Globales.articulos.Add(new Articulo(Objetos_Mantenimiento.articuloMantenimiento.Meses, Objetos_Mantenimiento.articuloMantenimiento.Prestado, Objetos_Mantenimiento.articuloMantenimiento.Interes, Objetos_Mantenimiento.articuloMantenimiento.Descripcion,
                    Objetos_Mantenimiento.articuloMantenimiento.Marca, Objetos_Mantenimiento.articuloMantenimiento.Modelo, Objetos_Mantenimiento.articuloMantenimiento.Estado, Objetos_Mantenimiento.articuloMantenimiento.NumeroSerie, Objetos_Mantenimiento.articuloMantenimiento.Tipo, Objetos_Mantenimiento.articuloMantenimiento.CodigoTipo,
                    Objetos_Mantenimiento.articuloMantenimiento.NumeroRecibo));
                    dtgvArticulos.Rows.Add();
                    dtgvArticulos.Rows[row].Cells[0].Value = Objetos_Mantenimiento.articuloMantenimiento.Descripcion;
                    dtgvArticulos.Rows[row].Cells[1].Value = Objetos_Mantenimiento.articuloMantenimiento.Marca;
                    dtgvArticulos.Rows[row].Cells[2].Value = Objetos_Mantenimiento.articuloMantenimiento.Modelo;
                    dtgvArticulos.Rows[row].Cells[3].Value = txtPrecio.Text;
                    ((Articulo)Objetos_Globales.articulos[row]).MontoPago = double.Parse(txtPrecio.Text);

                    ((Articulo)(Objetos_Globales.articulos[row])).MontoPago = double.Parse(txtPrecio.Text);

                    txtNumRecibo.Text = "";
                    txtNumSerie.Text = "";
                    txtArticulo.Text = "";
                    txtEstado.Text = "";
                    txtMonto.Text = "";
                    txtPrecio.Text = "";

                    row++;
                    bttAgregar.Enabled = false;
                } else if(Objetos_Mantenimiento.articuloMantenimiento.Estado.Equals("Vendido"))
                    MessageBoxTemporal.Show("Este articulo ya fue vendido","Mensaje importante",2,false);
                else if (Objetos_Mantenimiento.articuloMantenimiento.Estado.Equals("Retirado"))
                    MessageBoxTemporal.Show("Este articulo ya fue Retirado", "Mensaje importante", 2, false);
                else
                    MessageBoxTemporal.Show("Este articulo sigue en prenda", "Mensaje importante", 2, false);
            } else
                MessageBoxTemporal.Show("Ingrese un articulo", "Mensaje importante", 2, false);
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturacion_Detalle venta = new Facturacion_Detalle();
            venta.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta_Articulos cons = new Consulta_Articulos();
            cons.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            this.Hide();
            men.Show();
        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtNumRecibo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBoxTemporal.Show("Solo se permiten numeros", "Advertencia", 1, false);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBoxTemporal.Show("Solo se permiten numeros", "Advertencia", 1, false);
                e.Handled = true;
                return;
            }
        }
    }
}
