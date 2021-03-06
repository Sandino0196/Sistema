﻿using System;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class Consulta_Articulos : Form
    {
        Articulo consulta = new Articulo();

        public Consulta_Articulos()
        {
            InitializeComponent();
        }

        private void Consulta_Facturacion_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
        }

        private void rbRecibo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRecibo.Checked)
            {
                lbl1.Text = "Ingrese Código del Recibo:";
                txtCod.Visible = true;
                txtCodCliente.Visible = false;
                txtCod.Focus();
                txtCod.ShortcutsEnabled = false;
            }
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCliente.Checked)
            {
                lbl1.Text = "Ingrese Identidad del Cliente:";
                txtCod.Visible = false;
                txtCodCliente.Visible = true;
                txtCodCliente.Focus();
                txtCodCliente.ShortcutsEnabled = false;
            }
        }

        private void bttBuscar_Click(object sender, EventArgs e)
        {
            if (rbRecibo.Checked)
            {
                if (txtCod.Text == "")
                {
                    MessageBox.Show("Error, campo vacio", "Error");
                }
                else
                dtgConsultaArticulo.DataSource = BD.CargarArticulo(int.Parse(txtCod.Text));
            }
            if (rbCliente.Checked)
            {
                if (txtCodCliente.MaskFull == false)
                {
                    MessageBox.Show("Error, campo vacio", "Error");
                }
                else
                dtgConsultaArticulo.DataSource = BD.Cargar_Cliente(txtCodCliente.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        Articulo articulo = new Articulo();

        private void dtgConsultaArticulo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*articulo.NumeroSerie = dtgConsultaArticulo.Rows[e.RowIndex].Cells["Numero_Serie_Articulo"].Value.ToString();
            articulo.Tipo = dtgConsultaArticulo.Rows[e.RowIndex].Cells["Tipo Articulo"].Value.ToString();
            articulo.Marca = dtgConsultaArticulo.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
            articulo.Modelo = dtgConsultaArticulo.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
            articulo.Prestado = float.Parse(dtgConsultaArticulo.Rows[e.RowIndex].Cells["Valor_Prestado"].Value.ToString());
            articulo.Interes = double.Parse(dtgConsultaArticulo.Rows[e.RowIndex].Cells["Tasa_Interes"].Value.ToString());
            articulo.Estado = dtgConsultaArticulo.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
            articulo.Descripcion = dtgConsultaArticulo.Rows[e.RowIndex].Cells["Descripcion_Articulo"].Value.ToString();
            articulo.Meses = int.Parse(dtgConsultaArticulo.Rows[e.RowIndex].Cells["Cuotas_Meses"].Value.ToString());
            Objetos_Globales.articulo = articulo;*/
        }


        private void btnCerrarConsulta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Volver_Click(object sender, EventArgs e)
        {

        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBoxTemporal.Show("Solo se permiten numeros", "Advertencia", 1, false);
                e.Handled = true;
                return;
            }
        }
    }
}
