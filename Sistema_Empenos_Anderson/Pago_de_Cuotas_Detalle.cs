using System;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class Pago_de_Cuotas_Detalle : Form
    {
        public Pago_de_Cuotas_Detalle()
        {
            InitializeComponent();
            txtCliente.Text = Objetos_Globales.identidadTemporal;
            numMeses.Minimum = 1;
            numMeses.Maximum = Objetos_Mantenimiento.articuloMantenimiento.Meses;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pago_de_Cuotas pago = new Pago_de_Cuotas();
            pago.Show();
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(double.Parse(txtIngresado.Text) < double.Parse(txtMonto.Text))
                MessageBoxTemporal.Show("El monto ingresado no es suficiente para pagar", "Mensaje importante", 1, false);
            else
            {
                if(BD.Modificar_Meses(Objetos_Mantenimiento.articuloMantenimiento.NumeroRecibo, Objetos_Mantenimiento.articuloMantenimiento.NumeroSerie, Objetos_Mantenimiento.articuloMantenimiento.Meses - int.Parse(numMeses.Value.ToString())) > 0)
                {
                    Objetos_Globales.fechaHoyCorta = Objetos_Globales.fecha.Day + "/" + Objetos_Globales.fecha.Month +
                "/" + Objetos_Globales.fecha.Year;
                    BD.Ingreso_Pago_Interes(Objetos_Mantenimiento.articuloMantenimiento.NumeroRecibo, Objetos_Mantenimiento.articuloMantenimiento.NumeroSerie,
                        int.Parse(txtCodigoPago.Text), txtCliente.Text, Objetos_Globales.fechaHoyCorta, double.Parse(txtMonto.Text),
                        Objetos_Globales.usuario.codigo_Usuario);
                    MessageBoxTemporal.Show(Objetos_Globales.fechaHoyCorta, "Mensaje importante", 1, false);
                    MessageBoxTemporal.Show("Transaccion Finalizada", "Mensaje importante", 1, false);
                    this.Hide();
                    Menu men = new Sistema_Empenos_Anderson.Menu(Objetos_Globales.usuario.codigo_Tipo_Usuario);
                    men.Show();
                } else
                    MessageBoxTemporal.Show("Ha ocurrido un error", "Mensaje importante", 1, false);
            }
        }

        private void Pago_de_Cuotas_Detalle_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
        }

        private void numMeses_ValueChanged(object sender, EventArgs e)
        {
            txtMonto.Text = Objetos_Mantenimiento.articuloMantenimiento.PagoInteres(int.Parse(numMeses.Value.ToString())).ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu men = new Sistema_Empenos_Anderson.Menu(Objetos_Globales.usuario.codigo_Tipo_Usuario);
            men.Show();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtIngresado_KeyPress(object sender, KeyPressEventArgs e)
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
