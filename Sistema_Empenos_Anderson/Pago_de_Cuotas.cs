using System;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class Pago_de_Cuotas : Form
    {
        public Pago_de_Cuotas()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            men.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pago_de_Cuotas_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
            txtNumRecibo.Focus();
            txtArticulo.Text = Objetos_Mantenimiento.articuloMantenimiento.Descripcion;
            txtEstado.Text = Objetos_Mantenimiento.articuloMantenimiento.Estado;
            txtIntereses.Text = Objetos_Mantenimiento.articuloMantenimiento.Interes.ToString();
            txtMonto.Text = Objetos_Mantenimiento.articuloMantenimiento.Prestado.ToString();
            txtMeses.Text = Objetos_Mantenimiento.articuloMantenimiento.Meses.ToString();
            btnAvanzar.Enabled = false;
        }

        private void bttBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta_Articulos cons = new Consulta_Articulos();
            cons.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Objetos_Mantenimiento.articuloMantenimiento.Estado.Equals("En Prenda"))
            {
                Pago_de_Cuotas_Detalle cuotas_Detalle = new Pago_de_Cuotas_Detalle();
                cuotas_Detalle.Show();
                this.Hide();
            } else
                MessageBoxTemporal.Show("Este articulo ya esta " + txtEstado.Text, "Mensaje Importante",2,false);
        }

        private void bttBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtNumSerie.Text == "" || txtNumRecibo.Text == "")
            {
                MessageBoxTemporal.Show("Error no deje los campos vacios", "Error", 2, false);
            }
            else
            if (txtNumRecibo.Text.Equals("") && txtNumSerie.Text.Equals(""))
                MessageBoxTemporal.Show("Ingrese los valores correspondientes", "Mensaje Importante", 2, false);
            else
            {
                if (BD.Busqueda_Articulo(int.Parse(txtNumRecibo.Text), txtNumSerie.Text) > 0)
                {
                    txtArticulo.Text = Objetos_Mantenimiento.articuloMantenimiento.Descripcion;
                    txtEstado.Text = Objetos_Mantenimiento.articuloMantenimiento.Estado;
                    txtIntereses.Text = Objetos_Mantenimiento.articuloMantenimiento.Interes.ToString();
                    txtMonto.Text = Objetos_Mantenimiento.articuloMantenimiento.Prestado.ToString();
                    txtMeses.Text = Objetos_Mantenimiento.articuloMantenimiento.Meses.ToString();
                    btnAvanzar.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            this.Hide();
            men.Show();
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
    }
}
