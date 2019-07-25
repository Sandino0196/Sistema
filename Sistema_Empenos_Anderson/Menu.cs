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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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
                Objetos_Globales.articulo = new Articulo();
                pago.Show();
                this.Hide();
            } else if (rdbRetiro.Checked)
            {
                Retiro_Articulo retiro = new Retiro_Articulo();
                retiro.Show();
                this.Hide();
            } else if (rdbVenta.Checked)
            {
                Facturacion venta = new Facturacion();
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
            if(Usuario.Codigo_Usuario != 1)
            {
                rdbMantenimiento.Visible = false;
            } else
            {
                rdbMantenimiento.Visible = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();            
            form1.Show();
            Usuario.Codigo_Usuario = 0;
            Usuario.Codigo_Tipo_Usuario = 0;
            Usuario.Nombre_Usuario = "";
            Usuario.Password_Usuario = "";
        }
    }
}
