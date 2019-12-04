using System;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class Manteminiento : Form
    {
        public Manteminiento()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            this.Dispose();
            Menu men = new Menu();
            men.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User_Mantenimiento user = new User_Mantenimiento();
            user.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            this.Hide();
            men.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Mantenimiento_Clientes cliente = new Mantenimiento_Clientes();
            this.Hide();
            cliente.Show();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            Mantenimiento_Articulos mantenimiento = new Mantenimiento_Articulos();
            this.Hide();
            mantenimiento.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }

        private void Manteminiento_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
            int tamanoL = this.Width / 4;
            int tamanoR = this.Height / 3;
            panel1.Left = tamanoL;
            panel1.Top = tamanoR;
        }
    }
}
