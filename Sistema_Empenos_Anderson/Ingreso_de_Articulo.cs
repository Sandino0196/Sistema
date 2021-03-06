﻿using System;
using System.Windows.Forms;


namespace Sistema_Empenos_Anderson
{
    public partial class Ingreso_de_Articulo : Form
    {
        public Ingreso_de_Articulo()
        {
            InitializeComponent();
        }

        private int Validar_Monto(string campo)
        {
            string Monto;
            double  x;
            bool verificador;
            Monto = campo;

            if(verificador = Double.TryParse(Monto.ToString(), out x) == true)
                return 1;
            else{
                return 0;
            }

            
        }

        public static int Ingreso = 0, row=0;

        protected override void OnClosed(EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            men.Show();
        }

        

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            if(BD.Busqueda_Recibo(int.Parse(txtCod_Recibo.Text)) == 0)
            {
                BD.Ingreso_Recibo(int.Parse(txtCod_Recibo.Text), Objetos_Globales.cliente.identidad_Cliente, Objetos_Globales.usuario.codigo_Usuario, DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString() + "-" + DateTime.Today.Year.ToString());
                for (int i = 0; i < Objetos_Globales.articulos.Count; i++)
                    BD.Ingreso_Articulo(int.Parse(txtCod_Recibo.Text), ((Articulo)Objetos_Globales.articulos[i]).NumeroSerie,
                        ((Articulo)Objetos_Globales.articulos[i]).CodigoTipo, ((Articulo)Objetos_Globales.articulos[i]).Descripcion,
                        ((Articulo)Objetos_Globales.articulos[i]).Marca, ((Articulo)Objetos_Globales.articulos[i]).Modelo,
                        ((Articulo)Objetos_Globales.articulos[i]).Prestado, ((Articulo)Objetos_Globales.articulos[i]).Interes, 1,
                        ((Articulo)Objetos_Globales.articulos[i]).Meses, "Articulo");
                MessageBoxTemporal.Show("Transaccion finalizada", "Listo", 1, false);
                Menu men = new Sistema_Empenos_Anderson.Menu();
                men.Show();
                this.Hide();
            }
            else
            {
                MessageBoxTemporal.Show("Este recibo ya existe", "Mensaje Importante", 1, false);
                txtCod_Recibo.Enabled = true;
            }
        }

        private void Ingreso_de_Articulo_Load(object sender, EventArgs e)
        {
            Ingreso = 0;
            row = 0;
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
            cmbTipo_Articulo.DataSource = BD.CargarTipoArticulos();
            cmbTipo_Articulo.DisplayMember = "Descripcion";
            cmbTipo_Articulo.ValueMember = "Codigo_Tipo_Articulo";
            int tamanoL = this.Width / 5;
            int tamanoR = this.Height / 7;
            panel1.Left = tamanoL;
            panel1.Top = tamanoR;

            if (Objetos_Globales.articulos.Count != 0)
            {
                for (int i = 0; i < Objetos_Globales.articulos.Count; i++)
                {
                    dtgvArticulos.Rows.Add();
                    dtgvArticulos.Rows[i].Cells[0].Value = ((Articulo)Objetos_Globales.articulos[i]).NumeroSerie;
                    dtgvArticulos.Rows[i].Cells[1].Value = ((Articulo)Objetos_Globales.articulos[i]).Descripcion;
                    dtgvArticulos.Rows[i].Cells[2].Value = ((Articulo)Objetos_Globales.articulos[i]).Tipo;
                    dtgvArticulos.Rows[i].Cells[3].Value = ((Articulo)Objetos_Globales.articulos[i]).Marca;
                    dtgvArticulos.Rows[i].Cells[4].Value = ((Articulo)Objetos_Globales.articulos[i]).Modelo;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingreso_de_Cliente ingreso = new Ingreso_de_Cliente();
            ingreso.Show();
        }

        private void txtCod_Recibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBoxTemporal.Show("Solo se permiten numeros", "Advertencia", 1, false);
                e.Handled = true;
                return;
            }
        }



        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBoxTemporal.Show("Solo se permiten numeros", "Advertencia", 1, false);
                e.Handled = true;
                return;
            }
        }

        private void txtTasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBoxTemporal.Show("Solo se permiten numeros", "Advertencia", 1, false);
                e.Handled = true;
                return;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtCod_Recibo.Text=="" || Validar_Monto(txtCod_Recibo.Text)==0 || txtNumero_Serie.Text=="" || txtDescripcion.Text=="" || txtMarca.Text=="" || txtModelo.Text=="" || Validar_Monto(txtMonto.Text)==0 || txtMonto.Text=="" || Validar_Monto(txtTasa.Text)==0 || double.Parse(txtTasa.Text)> 20)
            {
                if(double.Parse(txtTasa.Text) > 20)
                {
                    MessageBoxTemporal.Show("La tasa de interes máxima es de 20%", "ALERTA", 2, false);
                }
                MessageBoxTemporal.Show("Ha ingresado incorrectamente algunos datos!\nPorfavor Reviselos.", "Alerta",2,false);
            }
            else
            {
                if(Objetos_Globales.articulos.Count == 0)
                {
                    Objetos_Globales.articulos.Add(new Articulo(1, double.Parse(txtMonto.Text),
                double.Parse(txtTasa.Text)/100, txtDescripcion.Text, txtMarca.Text, txtModelo.Text,
                "En Prenda", txtNumero_Serie.Text, cmbTipo_Articulo.SelectedText,
                cmbTipo_Articulo.SelectedIndex + 1, int.Parse(txtCod_Recibo.Text)));

                    dtgvArticulos.Rows.Add();
                    dtgvArticulos.Rows[row].Cells[0].Value = txtNumero_Serie.Text;
                    dtgvArticulos.Rows[row].Cells[1].Value = txtDescripcion.Text;
                    dtgvArticulos.Rows[row].Cells[2].Value = txtMarca.Text;
                    dtgvArticulos.Rows[row].Cells[3].Value = txtModelo.Text;
                    row++;
                    txtCod_Recibo.Enabled = false;
                    txtNumero_Serie.Text = "";
                    txtDescripcion.Text = "";
                    txtMarca.Text = "";
                    txtModelo.Text = "";
                    txtMonto.Text = "";
                    txtTasa.Text = "";
                } else
                {
                    bool existeArticulo = false;
                    for (int i = 0; i < Objetos_Globales.articulos.Count; i++)
                    {
                        if (((Articulo)Objetos_Globales.articulos[i]).NumeroSerie.Equals(txtNumero_Serie.Text)) { 
                            i = Objetos_Globales.articulos.Count;
                            existeArticulo = true;
                        } else
                            existeArticulo = false;
                    }

                    if (!existeArticulo)
                    {
                        Objetos_Globales.articulos.Add(new Articulo(1, double.Parse(txtMonto.Text),
                        double.Parse(txtTasa.Text), txtDescripcion.Text, txtMarca.Text, txtModelo.Text,
                        "En Prenda", txtNumero_Serie.Text, cmbTipo_Articulo.SelectedValue.ToString(),
                        cmbTipo_Articulo.SelectedIndex + 1, int.Parse(txtCod_Recibo.Text)));

                        
                        dtgvArticulos.Rows.Add();
                        dtgvArticulos.Rows[row].Cells[0].Value = txtNumero_Serie.Text;
                        dtgvArticulos.Rows[row].Cells[1].Value = txtDescripcion.Text;
                        dtgvArticulos.Rows[row].Cells[2].Value = txtMarca.Text;
                        dtgvArticulos.Rows[row].Cells[3].Value = txtModelo.Text;
                        row++;
                        txtCod_Recibo.Enabled = false;
                        txtNumero_Serie.Text = "";
                        txtDescripcion.Text = "";
                        txtMarca.Text = "";
                        txtModelo.Text = "";
                        txtMonto.Text = "";
                        txtTasa.Text = "";
                    }
                    else                    
                        MessageBoxTemporal.Show("Este articulo ya se ha ingresado", "Mensaje Importante", 2, false);
                }
            }
            
        }
    }
}
