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
            Objetos_Globales.fechaHoy = Objetos_Globales.fecha.Day + "/" + Objetos_Globales.fecha.Month + 
                "/" +Objetos_Globales.fecha.Year + " " + Objetos_Globales.fecha.Hour + ":"
                + Objetos_Globales.fecha.Minute + ":" + Objetos_Globales.fecha.Second + "."
                + Objetos_Globales.fecha.Millisecond;
            Objetos_Globales.fechaHoyCorta = Objetos_Globales.fecha.Day + "/" + Objetos_Globales.fecha.Month +
                "/" + Objetos_Globales.fecha.Year;
            if (BD.Login(txtUsuario.Text,txtPassword.Text) > 0)
            {
                if(Objetos_Globales.usuario.estado == 2)               
                    MessageBoxTemporal.Show("Usuario inactivo", "Mensaje Importante", 2, false);
                else
                {
                    BD.Fecha_Inicio_Sesion(txtUsuario.Text, txtPassword.Text, Objetos_Globales.fechaHoy);
                    Menu menu = new Menu(Objetos_Globales.usuario.codigo_Tipo_Usuario);
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
                Objetos_Globales.fechaHoy = Objetos_Globales.fecha.Day.ToString() + "/" + Objetos_Globales.fecha.Month.ToString() +
                "/" + Objetos_Globales.fecha.Year.ToString() + " " + Objetos_Globales.fecha.Hour.ToString() + ":"
                + Objetos_Globales.fecha.Minute.ToString() + ":" + Objetos_Globales.fecha.Second.ToString() + "."
                + Objetos_Globales.fecha.Millisecond.ToString();
                if (BD.Login(txtUsuario.Text, txtPassword.Text) > 0)
                {
                    BD.Fecha_Inicio_Sesion(Objetos_Globales.usuario.nombre_Usuario, Objetos_Globales.usuario.password_Usuario, Objetos_Globales.fechaHoy);
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

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
