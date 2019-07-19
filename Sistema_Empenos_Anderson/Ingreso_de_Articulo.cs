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
        public static int Ingreso = 0, row = 0;

        public int Verificar_Monto()
        {
            int verificador, x;
            if(!int.TryParse(txtMonto.Text, out x))
            {  
                return verificador=1;
            }
            else
            {
                return verificador=0;
            }
            
        }

        public void Agregar_Recibo()
        {
            if(BD.Ingreso_Recibo(int.Parse(txtCod_Recibo.Text), Cliente.Identidad_Cliente, 1, clndrFecha.TodayDate.ToString()) == 0)
                MessageBox.Show("Este codigo de recibo ya esta ingresado en el sistema", "ERROR");
            else
            {
                if (Ingreso == 0)
                {
                    BD.Ingreso_Recibo(int.Parse(txtCod_Recibo.Text), Cliente.Identidad_Cliente, 1, clndrFecha.TodayDate.ToString());

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



                BD.Ingreso_Articulo(int.Parse(txtCod_Recibo.Text), txtNumero_Serie.Text, Tipo, txtDescripcion.Text, txtMarca.Text, txtModelo.Text, double.Parse(txtMonto.Text), double.Parse(txtTasa.Text), 1);


                dtgvArticulos.Rows.Add();
                dtgvArticulos.Rows[row].Cells[0].Value = txtNumero_Serie.Text;
                dtgvArticulos.Rows[row].Cells[1].Value = txtDescripcion.Text;
                dtgvArticulos.Rows[row].Cells[2].Value = cmbTipo_Articulo.SelectedItem.ToString();
                dtgvArticulos.Rows[row].Cells[3].Value = txtMarca.Text;
                dtgvArticulos.Rows[row].Cells[4].Value = txtModelo.Text;
                row++;
                txtCod_Recibo.Enabled = false;
            }
           

        }
    
        protected override void OnClosed(EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            men.Show();
        }

        public void Limpiar()
        {
            txtNumero_Serie.Text = null;
            txtDescripcion.Text = null;
            txtMarca.Text = null;
            txtModelo.Text = null;
            txtMonto.Text = null;
            txtTasa.Text = null;

        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            Articulo.Reiniciar_Arreglo();
            Menu men = new Sistema_Empenos_Anderson.Menu();
            men.Show();
            this.Hide();
           
        }

        private void Ingreso_de_Articulo_Load(object sender, EventArgs e)
        {
            Ingreso = 0;
            row = 0;
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Articulo.Reiniciar_Arreglo();
            this.Hide();
            Ingreso_de_Cliente ingreso = new Ingreso_de_Cliente();
            ingreso.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtCod_Recibo.Text=="" || cmbTipo_Articulo.SelectedIndex < 0 || txtNumero_Serie.Text=="" || txtDescripcion.Text=="" || txtMarca.Text=="" || txtModelo.Text=="" || txtMonto.Text=="" || Verificar_Monto()==1 || txtTasa.MaskCompleted==false)
            {
                MessageBox.Show("Ha dejado espacios vacios en la informacion del recibo, o ingreso de manera incorrecta el monto","Alerta");
            }
            else
            {
                DialogResult res = MessageBox.Show("Esta seguro de que esta ingresando la informacion correcta?","Confirmacion", MessageBoxButtons.YesNo);
                if(res.ToString()=="Yes")
                {
                    int contador;
                    if (Articulo.Numeros_Serie.Count == 0)
                    {
                        Articulo.Ingresar_Numero(txtNumero_Serie.Text);
                        Agregar_Recibo();
                        Limpiar();
                    }
                    else
                    {
                        contador = 0;
                        for (int x = 0; x < Articulo.Numeros_Serie.Count; x++)
                        {
                            if (txtNumero_Serie.Text == Articulo.Numeros_Serie[x].ToString())
                            {
                                contador = 1;
                            }
                        }
                        if (contador == 0)
                        {
                            Articulo.Ingresar_Numero(txtNumero_Serie.Text);
                            Agregar_Recibo();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("El Numero de Serie del Articulo ya fue ingresado", "ALERTA");
                            Limpiar();
                        }

                    }
                
                }
            
            }

        }
    }
}
