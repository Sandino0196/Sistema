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
            if (BD.Busqueda_Articulo(int.Parse(txtCod_Recibo.Text), txtNumSerie.Text) > 0 && Articulo.estado.Equals("En Prenda"))
            {
                dtgvInfo_Articulo.Rows[0].Cells[0].Value = Articulo.descripcion;
                dtgvInfo_Articulo.Rows[0].Cells[1].Value = Articulo.marca;
                dtgvInfo_Articulo.Rows[0].Cells[2].Value = Articulo.modelo;
                dtgvInfo_Articulo.Rows[0].Cells[3].Value = Articulo.prestado + (Articulo.interes*Articulo.prestado);
                btnRetirar.Enabled = true;
            }
            else if (BD.Busqueda_Articulo(int.Parse(txtCod_Recibo.Text), txtNumSerie.Text) == 0)
            {
                dtgvInfo_Articulo.Rows[0].Cells[0].Value = null;
                dtgvInfo_Articulo.Rows[0].Cells[1].Value = null;
                dtgvInfo_Articulo.Rows[0].Cells[2].Value = null;
                dtgvInfo_Articulo.Rows[0].Cells[3].Value = null;
                btnRetirar.Enabled = false;
                MessageBox.Show("No se encontro el articulo", "ERROR");
            }  else if(Articulo.estado != "En Prenda")
            { 
                dtgvInfo_Articulo.Rows[0].Cells[0].Value = null;
                dtgvInfo_Articulo.Rows[0].Cells[1].Value = null;
                dtgvInfo_Articulo.Rows[0].Cells[2].Value = null;
                dtgvInfo_Articulo.Rows[0].Cells[3].Value = null;
                btnRetirar.Enabled = false;
                MessageBox.Show("El  articulo no esta   dispoonible para retiro", "ERROR");
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            //Probando
            BD.Retirar_Articulo(int.Parse(txtCod_Recibo.Text), txtNumSerie.Text);
            Retiro_Articulo_Info retiro = new Retiro_Articulo_Info();
            retiro.Show();
            this.Hide();
        }
    }
}
