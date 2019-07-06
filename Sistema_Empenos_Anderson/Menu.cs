﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rdbIngresarArticulo.Checked)
            {
                Ingreso_de_Cliente ingreso = new Ingreso_de_Cliente();
                ingreso.Show();
            }
            if (rdbPagoIntereses.Checked)
            {
                Pago_de_Cuotas pago = new Pago_de_Cuotas();
                pago.Show();
            }
            /*if (rdbRetirarArticulo.Checked)
            {
                Retiro1 Retiro = new Retiro1();
                Retiro.Show();
            }*/
            if(rdbVender.Checked)
            {
                Facturacion facturacion = new Facturacion();
                facturacion.Show();
            }
            if(rdbConsulta.Checked)
            {
                Consultas consulta = new Consultas();
                consulta.Show();
            }

            this.Hide();

        }

        private void rdbRetirarArticulo_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
        }
    }
}
