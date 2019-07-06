using System;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            men.Show();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            double subtotal = 0, isv = 0;
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
            txtVendedor.Text = Usuario.Nombre_Usuario;
            txtFechaVenta.Text = calendarVenta.SelectionStart.ToShortDateString();
            isv = Articulo.precioPago * 0.15;
            subtotal = Articulo.precioPago - isv;
            txtSubtotal.Text = subtotal.ToString();
            txtISV.Text = isv.ToString();
            txtTotalPagar.Text = Articulo.precioPago.ToString();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (BD.Busqueda_Cliente(txtIDComp.Text) > 0)
            {
                Cliente.Identidad_Cliente = txtIDComp.Text;
                txtNombre.Text = Cliente.Nombre_Cliente;
                txtApellido.Text = Cliente.Apellido_Cliente;
                txtTelefono.Text = Cliente.Telefono_Cliente;
                txtCorreo.Text = Cliente.Correo_Cliente;                
            }
            else
            {
                MessageBox.Show("No se encontro el cliente en la Base de Datos\nDesea Agregarlo?", "ALERTA", MessageBoxButtons.YesNo);
                gbInfoComp.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BD.Ingreso_Cliente(txtIDComp.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text);
            MessageBox.Show("Ingresado Correctamente", "Empeños Anderson");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BD.Ingreso_Factura(int.Parse(txtCodigo.Text),txtIDComp.Text,1,txtFechaVenta.Text);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturacion facturacion = new Facturacion();
            facturacion.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbInfoComp.Enabled = true;
        }
    }
}
