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
            Menu men = new Sistema_Empenos_Anderson.Menu(Objetos_Globales.usuario.codigo_Usuario);
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
            if (BD.Busqueda_Articulo(int.Parse(txtNumRecibo.Text), txtNumSerie.Text) > 0)
            {
                txtArticulo.Text = Objetos_Mantenimiento.articuloMantenimiento.Descripcion;
                txtEstado.Text = Objetos_Mantenimiento.articuloMantenimiento.Estado;
                txtIntereses.Text = Objetos_Mantenimiento.articuloMantenimiento.Interes.ToString();
                txtMonto.Text = Objetos_Mantenimiento.articuloMantenimiento.Prestado.ToString();
                txtMeses.Text = Objetos_Mantenimiento.articuloMantenimiento.Meses.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu(Objetos_Globales.usuario.codigo_Tipo_Usuario);
            this.Hide();
            men.Show();
        }
    }
}
