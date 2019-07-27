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

        Articulo cuota;

        public Pago_de_Cuotas(Articulo articulo)
        {
            cuota = articulo;
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
            if(txtEstado.Text.Equals("En Prenda"))
            {
                Pago_de_Cuotas_Detalle cuotas_Detalle = new Pago_de_Cuotas_Detalle();
                cuotas_Detalle.Show();
                this.Hide();
            } else
                MessageBoxTemporal.Show("Este articulo ya esta " + txtEstado.Text, "Mensaje Importante",2,false);
        }

        private void bttBuscar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
