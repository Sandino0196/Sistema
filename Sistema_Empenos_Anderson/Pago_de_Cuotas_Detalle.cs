using System;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class Pago_de_Cuotas_Detalle : Form
    {
        public Pago_de_Cuotas_Detalle()
        {
            InitializeComponent();
            if (BD.Busqueda_Cliente(Objetos_Globales.identidadTemporal) > 0)
                txtCliente.Text = Objetos_Globales.cliente.nombre_Cliente + " " + Objetos_Globales.cliente.apellido_Cliente;
            numMeses.Minimum = 1;
            numMeses.Maximum = Objetos_Mantenimiento.articuloMantenimiento.Meses;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void Pago_de_Cuotas_Detalle_Load(object sender, EventArgs e)
        {
            
        }

        private void numMeses_ValueChanged(object sender, EventArgs e)
        {
            txtMonto.Text = Objetos_Mantenimiento.articuloMantenimiento.PrecioPago(int.Parse(numMeses.Value.ToString())).ToString();
        }
    }
}
