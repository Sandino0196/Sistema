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
            if (BD.Login(txtUsuario.Text,txtPassword.Text) > 0)
            {
                if(Objetos_Globales.usuario.estado == 2)               
                    MessageBoxTemporal.Show("Usuario inactivo", "Mensaje Importante", 2, false);
                else
                {
                    BD.Fecha_Inicio_Sesion(txtUsuario.Text, txtPassword.Text, Objetos_Globales.fechaHoy());
                    Menu menu = new Menu();
                    this.Hide();
                    menu.Show();
                }
            } else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta", "Error");
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Mantenimiento user = new User_Mantenimiento(1);
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
                    BD.Fecha_Inicio_Sesion(Objetos_Globales.usuario.nombre_Usuario, Objetos_Globales.usuario.password_Usuario, Objetos_Globales.fechaHoy());
                    Menu menu = new Menu();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta", "Error");
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
