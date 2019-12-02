using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
            if (Objetos_Globales.usuario.codigo_Tipo_Usuario == 1)
                btnMantenimiento.Enabled = true;
            else
                btnMantenimiento.Enabled = false;
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.ExitThread();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
            int tamanoL = this.Width / 3;
            int tamanoR = this.Height / 6;
            panel1.Left = tamanoL;
            panel1.Top = tamanoR;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso_de_Cliente cliente = new Ingreso_de_Cliente();
            Objetos_Globales.articulos = new System.Collections.ArrayList();
            Objetos_Globales.cliente = new Cliente();
            cliente.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pago_de_Cuotas pago = new Pago_de_Cuotas();
            Objetos_Mantenimiento.articuloMantenimiento = new Articulo();
            pago.Show();
            this.Hide();
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            Objetos_Globales.cliente = new Cliente();
            Objetos_Mantenimiento.articuloMantenimiento = new Articulo();
            Retirar_Articulos retiro = new Retirar_Articulos();
            retiro.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Facturacion venta = new Facturacion();
            Objetos_Globales.cliente = new Cliente();
            Objetos_Globales.articulos = new System.Collections.ArrayList();
            venta.Show();
            this.Hide();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            consultas.Show();
            this.Hide();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            Manteminiento manteminiento = new Manteminiento();
            manteminiento.Show();
            this.Hide();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
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
