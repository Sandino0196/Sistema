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
    public partial class Manteminiento : Form
    {
        public Manteminiento()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            Menu men = new Menu();
            this.Dispose();
            men.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User_Mantenimiento user = new User_Mantenimiento();
            user.Show();
            this.Hide();
        }

        private void Manteminiento_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            Mantenimiento_Articulos art = new Mantenimiento_Articulos();
            this.Dispose();
            art.Show();
        }
    }
}
