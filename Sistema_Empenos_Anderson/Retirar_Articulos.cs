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
    public partial class Retirar_Articulos : Form
    {
        public Retirar_Articulos()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            men.Show();
        }

        private void Retirar_Articulos_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
            btnRetirar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(BD.Busqueda_Articulo(int.Parse(txtRecibo.Text), txtSerie.Text) > 0)
            {
                dtgvInfo.Rows[0].Cells[0].Value = Objetos_Mantenimiento.articuloMantenimiento.Descripcion;
                dtgvInfo.Rows[0].Cells[1].Value = Objetos_Mantenimiento.articuloMantenimiento.Marca;
                dtgvInfo.Rows[0].Cells[2].Value = Objetos_Mantenimiento.articuloMantenimiento.Modelo;
                dtgvInfo.Rows[0].Cells[3].Value = Objetos_Mantenimiento.articuloMantenimiento.PrecioPago(Objetos_Mantenimiento.articuloMantenimiento.Meses).ToString();
                btnRetirar.Enabled = true;
            }
            else
            {
                MessageBoxTemporal.Show("No se encontro el Articulo","Error",2,false);
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (BD.Busqueda_Retiro(int.Parse(txtRetiro.Text)) == 0)
            {
                if (Double.Parse(txtMontoPagado.Text) < Objetos_Mantenimiento.articuloMantenimiento.PrecioPago(Objetos_Mantenimiento.articuloMantenimiento.Meses) || txtMontoPagado.Text == null)
                {
                    MessageBoxTemporal.Show("El valor ingresado no puede ser menor al monto a pagar", "Alerta", 2, false);
                }
                else
                {
                    double cambio = 0;
                    BD.Actualizar_Estado_Articulo(txtSerie.Text, int.Parse(txtRecibo.Text), 4, "Articulo");
                    cambio = double.Parse(txtMontoPagado.Text) - Objetos_Mantenimiento.articuloMantenimiento.PrecioPago(Objetos_Mantenimiento.articuloMantenimiento.Meses);
                    MessageBoxTemporal.Show("El articulo fue retirado con exito\nCambio:" + cambio, "Informacion", 2, false);
                    BD.Ingreso_Retiro(int.Parse(txtRetiro.Text), Objetos_Globales.identidadTemporal, int.Parse(txtRecibo.Text), txtSerie.Text, Objetos_Globales.fechaHoyCorta());
                    this.Close();
                }
            } else
                MessageBoxTemporal.Show("Este codigo de retiro ya fue utilizado", "Mensaje Importante", 2, false);
        }

        private void txtRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBoxTemporal.Show("Solo se permiten numeros", "Advertencia", 1, false);
                e.Handled = true;
                return;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            this.Hide();
            men.Show();
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {

        }

        private void txtMontoPagado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBoxTemporal.Show("Solo se permiten numeros", "Advertencia", 1, false);
                e.Handled = true;
                return;
            }
        }

        private void txtRetiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBoxTemporal.Show("Solo se permiten numeros", "Advertencia", 1, false);
                e.Handled = true;
                return;
            }
        }

        private void txtSerie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRetiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRecibo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMontoPagado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
