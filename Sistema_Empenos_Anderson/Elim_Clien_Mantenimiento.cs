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
    public partial class Elim_Clien_Mantenimiento : Form
    {
        public Elim_Clien_Mantenimiento()
        {
            InitializeComponent();
        }

        private void bttBuscar_Click(object sender, EventArgs e)
        {
            if(BD.Busqueda_Cliente(txtID_Cliente.Text) > 0)
            {
                txtNombre.Text = Objetos_Globales.cliente.nombre_Cliente + Objetos_Globales.cliente.apellido_Cliente;
            }
            else
            {
                MessageBox.Show("Atención","El cliente no existe");
            }
        }

        private void bttElim_Click(object sender, EventArgs e)
        {

        }
    }
}
