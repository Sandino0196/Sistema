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
    public partial class User_Mantenimiento : Form
    {
        public User_Mantenimiento(int tab)
        {
            InitializeComponent();
            if (tab == 1)
            {
                tabCUsuario.SelectTab(tab);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if(Usuario.Codigo_Usuario == 0)
            {
                this.Close();
            } else {
                Manteminiento manteminiento = new Manteminiento();
                this.Close();
                manteminiento.Show();
            }
        }
    }
}
