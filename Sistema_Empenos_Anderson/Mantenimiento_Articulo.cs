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
    public partial class Mantenimiento_Articulo : Form
    {
        public Mantenimiento_Articulo()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Articulo_Load(object sender, EventArgs e)
        {

        }

        private int Validar_Recibo(string recibo)
        {
            string dato;
            int x;
            bool verificador;
            dato = recibo;
            if (verificador = int.TryParse(dato.ToString(), out x) == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        protected override void OnClosed(EventArgs e)
        {
            Manteminiento man = new Manteminiento();
            this.Dispose();
            man.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta_Articulos cons = new Consulta_Articulos();
            cons.Show();
        }

        private void Tipo_Art_Mantenimiento_Load(object sender, EventArgs e)
        {
            //Comentario por aqui
            cbxTipo_Art.DataSource = BD.CargarTipoArticulos();
            cbxTipo_Art.DisplayMember = "Descripcion";
            cbxTipo_Art.ValueMember = "Codigo_Tipo_Articulo";

            cmbEstados.DataSource = BD.CargarEstadosArticulo();
            cmbEstados.DisplayMember = "Descripcion";
            cmbEstados.ValueMember = "Codigo_Estado";

            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
        }

        private void btnConsultaEstado_Click(object sender, EventArgs e)
        {
            Consulta_Articulos cons = new Consulta_Articulos();
            cons.Show();
        }

        private void bttActualizar_Click(object sender, EventArgs e)
        {
            if (Recibotxt.Text == "" || Validar_Recibo(Recibotxt.Text) == 0 || Serietxt.Text == "")
            {
                //Comentario por aca
                MessageBoxTemporal.Show("Ingreso incorrectamente algunos datos", "Alerta", 1, false);
            }
            else if (BD.Actualizar_Tipo_Articulo(Serietxt.Text, int.Parse(Recibotxt.Text), cbxTipo_Art.SelectedIndex + 1) == 1)
            {
                MessageBoxTemporal.Show("Informacion Actualizada!", "Informacion", 1, false);
            }
            else
            {
                MessageBoxTemporal.Show("No se actualizo la informacion!", "Alerta", 1, false);
            }


        }

        private void bttBuscar_Click(object sender, EventArgs e)
        {
            if (Validar_Recibo(Recibotxt.Text) == 0)
            {
                MessageBoxTemporal.Show("Ingreso incorrectamente el codigo de Recibo", "Error", 1, false);
            }
            else
            if (BD.Busqueda_Articulo(int.Parse(Recibotxt.Text), Serietxt.Text) != 0)
            {
                //Probando
                txtArticulo.Text = Objetos_Mantenimiento.articuloMantenimiento.Descripcion;
                txtType.Text = Objetos_Mantenimiento.articuloMantenimiento.Tipo;
                txtMarca.Text = Objetos_Mantenimiento.articuloMantenimiento.Marca;
                txtModelo.Text = Objetos_Mantenimiento.articuloMantenimiento.Modelo;
            }
            else
            {
                MessageBoxTemporal.Show("No se encontro el articulo", "Error", 1, false);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Manteminiento man = new Manteminiento();
            this.Dispose();
            man.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Validar_Recibo(txtNum_Recibo.Text) == 0)
            {
                MessageBoxTemporal.Show("Ingreso incorrectamente el numero de Recibo", "Error", 1, false);
            }
            else
            //Probando
            if (BD.Busqueda_Articulo(int.Parse(txtNum_Recibo.Text), txtNum_Serie.Text) != 0)
            {
                txtDescripcion.Text = Objetos_Mantenimiento.articuloMantenimiento.Descripcion;
                txtEstado.Text = Objetos_Mantenimiento.articuloMantenimiento.Estado;
                txtMarca2.Text = Objetos_Mantenimiento.articuloMantenimiento.Marca;
                txtModelo2.Text = Objetos_Mantenimiento.articuloMantenimiento.Modelo;
            }
            else
            {
                MessageBoxTemporal.Show("No se encontro el articulo", "Error", 1, false);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BD.Actualizar_Estado_Articulo(txtNum_Serie.Text, int.Parse(txtNum_Recibo.Text), cmbEstados.SelectedIndex + 1, cmbEstados.SelectedItem.ToString());
            MessageBoxTemporal.Show("Informacion Actualizada!", "Informacion", 1, false);
        }
    }
}