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

        private void button1_Click(object sender, EventArgs e)
        {
            if(rdbIngresarArticulo.Checked)
            {
                Ingreso_de_Articulo ingreso = new Ingreso_de_Articulo();
                ingreso.Show();
            }
            if (rdbPagoIntereses.Checked)
            {
                Pago_de_Cuotas pago = new Pago_de_Cuotas();
                pago.Show();
            }
            if (rdbRetirarArticulo.Checked)
            {

            }
            if(rdbVender.Checked)
            {
                Facturacion facturacion = new Facturacion();
                facturacion.Show();
            }
            if(rdbConsulta.Checked)
            {
                Consultas consulta = new Consultas();
                consulta.Show();
            }

        }
    }
}
