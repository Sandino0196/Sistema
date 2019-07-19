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
        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (rdbIngreso.Checked)
            {
                Ingreso_de_Cliente cliente = new Ingreso_de_Cliente();
                cliente.Show();
            }
            if (rdbPago.Checked)
            {
                Pago_de_Cuotas pago = new Pago_de_Cuotas();
                pago.Show();
            }
            if (rdbRetiro.Checked)
            {
                Retiro_Articulo retiro = new Retiro_Articulo();
                retiro.Show();
            }
            if (rdbVenta.Checked)
            {
                Facturacion venta = new Facturacion();
                venta.Show();
            }
            if (rdbConsulta.Checked)
            {
                Consultas consultas = new Consultas();
                consultas.Show();
            }
            if(rdbConsulta.Checked==false && rdbIngreso.Checked==false && rdbMantenimiento.Checked==false && rdbPago.Checked==false && rdbRetiro.Checked==false && rdbVenta.Checked==false)
            {
                MessageBox.Show("Porfavor seleccione una opcion","ALERTA");
            }
            else
            {
                this.Hide();
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
        }
    }
}
