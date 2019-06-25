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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(BD.Login(txtUsuario.Text,txtPassword.Text) > 0)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            } else
            {
                MessageBox.Show("Error","Usuario no encontrado");
            }
            
        }
    }
}
