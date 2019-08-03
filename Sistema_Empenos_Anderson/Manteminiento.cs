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
            this.Dispose();
            Menu men = new Menu(Objetos_Globales.usuario.codigo_Tipo_Usuario);
            men.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User_Mantenimiento user = new User_Mantenimiento();
            user.Show();
            this.Hide();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            Mantenimiento_Articulos man = new Mantenimiento_Articulos();
            this.Hide();
            man.Show();
        }
    }
}
