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

        private void button3_Click(object sender, EventArgs e)
        {
            User_Mantenimiento user = new User_Mantenimiento();
            user.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu(Objetos_Globales.usuario.codigo_Usuario);
            this.Hide();
            men.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Elim_Clien_Mantenimiento cliente = new Elim_Clien_Mantenimiento();
            this.Hide();
            cliente.Show();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            Mantenimiento_Articulos mantenimiento = new Mantenimiento_Articulos();
            this.Hide();
            mantenimiento.Show();
        }
    }
}
