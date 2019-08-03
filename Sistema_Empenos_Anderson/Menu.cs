using System;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class Menu : Form
    {

        public Menu(int codigo)
        {
            InitializeComponent();
            if (codigo != 1)
                rdbMantenimiento.Visible = false;
            else
                rdbMantenimiento.Visible = true;
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (rdbIngreso.Checked)
            {
                Ingreso_de_Cliente cliente = new Ingreso_de_Cliente();
                Objetos_Globales.articulos = new System.Collections.ArrayList();
                Objetos_Globales.cliente = new Cliente();
                cliente.Show();
                this.Hide();
            } else if (rdbPago.Checked)
            {
                Pago_de_Cuotas pago = new Pago_de_Cuotas();
                Objetos_Mantenimiento.articuloMantenimiento = new Articulo();
                pago.Show();
                this.Hide();
            } else if (rdbRetiro.Checked)
            {
                Retirar_Articulos retiro = new Retirar_Articulos();
                retiro.Show();
                this.Hide();
            } else if (rdbVenta.Checked)
            {
                Facturacion venta = new Facturacion();
                Objetos_Globales.cliente = new Cliente();
                Objetos_Globales.articulos = new System.Collections.ArrayList();
                venta.Show();
                this.Hide();
            } else if (rdbConsulta.Checked)
            {
                Consultas consultas = new Consultas();
                consultas.Show();
                this.Hide();
            } else if (rdbMantenimiento.Checked)
            {
                Manteminiento manteminiento = new Manteminiento();
                manteminiento.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Seleccione una opción, por favor", "Advertencia");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if(Objetos_Globales.usuario.codigo_Tipo_Usuario != 1)
            {
                rdbMantenimiento.Visible = false;
            } else
            {
                rdbMantenimiento.Visible = true;
            }

            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();            
            form1.Show();
            Objetos_Globales.usuario.codigo_Usuario = 0;
            Objetos_Globales.usuario.codigo_Tipo_Usuario = 0;
            Objetos_Globales.usuario.nombre_Usuario = "";
            Objetos_Globales.usuario.password_Usuario = "";
        }
    }
}
