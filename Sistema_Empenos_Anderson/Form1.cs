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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
            Usuario.Codigo_Usuario = 0;
            Usuario.Codigo_Tipo_Usuario = 0;
            Usuario.Nombre_Usuario = "";
            Usuario.Password_Usuario = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(BD.Login(txtUsuario.Text,txtPassword.Text) > 0)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
                Usuario.Nombre_Usuario = txtUsuario.Text;
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
    }
}
