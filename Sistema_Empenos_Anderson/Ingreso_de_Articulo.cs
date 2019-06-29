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
    public partial class Ingreso_de_Articulo : Form
    {
        public Ingreso_de_Articulo()
        {
            InitializeComponent();
        }
        public static int Ingreso = 0, row=0;

        protected override void OnClosed(EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            men.Show();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            men.Show();
            this.Close();
        }

        private void Ingreso_de_Articulo_Load(object sender, EventArgs e)
        {
            Ingreso = 0;
            row = 0;
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Ingreso_de_Cliente ingreso = new Ingreso_de_Cliente();
            ingreso.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(Ingreso == 0)
            {
                BD.Ingreso_Recibo(int.Parse(txtCod_Recibo.Text), Cliente.Identidad_Cliente, 1, clndrFecha.TodayDate.ToString() );
                Ingreso++;
            }

            int Tipo = 0;
            if (cmbTipo_Articulo.SelectedItem.ToString() == "Electrodomestico")
                Tipo = 1;
            if (cmbTipo_Articulo.SelectedItem.ToString() == "Entretenimiento")
                Tipo = 2;
            if (cmbTipo_Articulo.SelectedItem.ToString() == "Joyeria")
                Tipo = 3;
            if (cmbTipo_Articulo.SelectedItem.ToString() == "Vehiculo")
                Tipo = 4;

            MessageBox.Show(Tipo.ToString(), "Titulo");


            BD.Ingreso_Articulo(int.Parse(txtCod_Recibo.Text), txtNumero_Serie.Text, Tipo, txtDescripcion.Text, txtMarca.Text, txtModelo.Text, double.Parse(txtMonto.Text), double.Parse(txtTasa.Text), 1);
            dtgvArticulos.Rows.Add();
            dtgvArticulos.Rows[row].Cells[0].Value = txtNumero_Serie.Text;
            dtgvArticulos.Rows[row].Cells[1].Value = txtDescripcion.Text;
            dtgvArticulos.Rows[row].Cells[2].Value = cmbTipo_Articulo.SelectedItem.ToString();
            dtgvArticulos.Rows[row].Cells[3].Value = txtMarca.Text;
            dtgvArticulos.Rows[row].Cells[4].Value = txtModelo.Text;
            row++;
        }
    }
}
