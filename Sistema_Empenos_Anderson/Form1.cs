using System;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Objetos_Globales.usuario = new Usuario();
            Objetos_Globales.fechaHoy = Objetos_Globales.fecha.Year + "-" + Objetos_Globales.fecha.Month + 
                "-" + Objetos_Globales.fecha.Day + " " + Objetos_Globales.fecha.Hour + ":"
                + Objetos_Globales.fecha.Minute + ":" + Objetos_Globales.fecha.Second + ":" 
                + Objetos_Globales.fecha.Millisecond;
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(BD.Login(txtUsuario.Text,txtPassword.Text) > 0)
            {
                Menu menu = new Menu(Objetos_Globales.usuario.codigo_Usuario);
                this.Hide();
                menu.Show();
            } else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta", "Error");
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            User_Mantenimiento user = new User_Mantenimiento(1);
            user.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            User_Mantenimiento user = new User_Mantenimiento(2);
            user.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (BD.Login(txtUsuario.Text, txtPassword.Text) > 0)
                {
                    Menu menu = new Menu(Objetos_Globales.usuario.codigo_Usuario);
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta", "Error");
                }
            }
        }
    }
}
