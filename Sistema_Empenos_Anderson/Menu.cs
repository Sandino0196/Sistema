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
        }
    }
}
