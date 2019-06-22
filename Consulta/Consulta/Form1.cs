using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Visible = false;
            estadocmb.Visible = false;
            tipoartcmb.Visible = false;
            labelcambio.Visible = false;
            btnaceptar.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Estados del Articulos")
            {
                btnaceptar.Visible = false;
                textBox1.Visible = false;
                tipoartcmb.Visible = false;
                estadocmb.Visible = true;
                labelcambio.Visible = true;
                labelcambio.Text = "Seleccione el Tipo de Estado: ";
            }
            else if(comboBox1.Text=="Tipo de Articulos")
            {
                btnaceptar.Visible = false;
                textBox1.Visible = false;
                estadocmb.Visible = false;
                tipoartcmb.Visible = true;
                labelcambio.Visible = true;
                labelcambio.Text = "Seleccione el Tipo de Articulo: ";
            }
            else
            {
                estadocmb.Visible = false;
                tipoartcmb.Visible = false;
                textBox1.Visible = true;
                labelcambio.Visible = true;
                labelcambio.Text = "Ingrese Datos: ";
                btnaceptar.Visible = true;
            }
        }

        private void labelcambio_Click(object sender, EventArgs e)
        {

        }

        private void estadocmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
