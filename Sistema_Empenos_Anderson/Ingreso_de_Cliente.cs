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
    public partial class Ingreso_de_Cliente : Form
    {
        public Ingreso_de_Cliente()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (BD.Busqueda_Cliente(txtBusqueda_ID.Text) > 0)
            {
                dtgv_Info_Cliente.Rows[0].Cells[0].Value = Cliente.Nombre_Cliente;
                dtgv_Info_Cliente.Rows[0].Cells[1].Value = Cliente.Apellido_Cliente;
                dtgv_Info_Cliente.Rows[0].Cells[2].Value = Cliente.Telefono_Cliente;
                dtgv_Info_Cliente.Rows[0].Cells[3].Value = Cliente.Correo_Cliente;
                btnAvanzar.Enabled = true;
            }
            else
            {
                grpInfo_Nuevo_Cliente.Enabled = true;
                btnAñadir.Enabled = true;

            }
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            Ingreso_de_Articulo Articulos = new Ingreso_de_Articulo();
            Articulos.Show();
            this.Hide();
        }
    }
}
