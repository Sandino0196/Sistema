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
    public partial class Retiro_Articulo : Form
    {
        public Retiro_Articulo()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
        }

        private void Retiro_Articulo_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (BD.Busqueda_Articulo(int.Parse(txtCod_Recibo.Text), txtNumSerie.Text) > 0 )
            {
                dtgvInfo_Articulo.Rows[0].Cells[0].Value = Articulo.descripcion;
                dtgvInfo_Articulo.Rows[0].Cells[1].Value = Articulo.marca;
                dtgvInfo_Articulo.Rows[0].Cells[2].Value = Articulo.modelo;
                dtgvInfo_Articulo.Rows[0].Cells[3].Value = Articulo.estado;
            }
            else
            {
                MessageBox.Show("No se encontro el articulo","ERROR");
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            BD.Retirar_Articulo(int.Parse(txtCod_Recibo.Text), txtNumSerie.Text);
        }
    }
}
