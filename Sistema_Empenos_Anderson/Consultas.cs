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
    public partial class Consultas : Form
    {

        protected override void OnClosed(EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            men.Show();
        }

        public Consultas()
        {
            InitializeComponent();
            lblcambio.Visible = false;
            txtingreso.Visible = false;
            cmbtipartic.Visible = false;
            txtID.Visible = false;
            btnaceptar.Visible = false;

        }

        private void cmbseleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cmbseleccion.Text=="Tipo de Articulos")
            {
                lblcambio.Text = "Seleccione un Tipo de Articulos: ";
                lblcambio.Visible = true;
                txtingreso.Visible = false;
                txtID.Visible = false;
                cmbtipartic.Visible = true;
                btnaceptar.Visible = true;
                txtIngresochar.Visible = false;
            }
            else 
            if(cmbseleccion.Text == "Identidad del Cliente")
            {
                lblcambio.Text = "Ingrese Identidad del Cliente: ";
                lblcambio.Visible = true;
                txtingreso.Visible = false;
                txtID.Visible = true;
                btnaceptar.Visible = true;
                txtIngresochar.Visible = false;
            }
            else
            {
                if (cmbseleccion.Text == "Numero de Serie")
                {
                    lblcambio.Text = "Ingrese Datos: ";
                    lblcambio.Visible = true;
                    txtIngresochar.Visible = true;
                    txtID.Visible = false;
                    txtIngresochar.Clear();
                    txtIngresochar.Focus();
                    cmbtipartic.Visible = false;
                    btnaceptar.Visible = true;
                }
                else
                {
                    lblcambio.Text = "Ingrese Datos: ";
                    lblcambio.Visible = true;
                    txtingreso.Visible = true;
                    txtID.Visible = false;
                    txtingreso.Clear();
                    txtingreso.Focus();
                    cmbtipartic.Visible = false;
                    btnaceptar.Visible = true;
                    txtIngresochar.Visible = false;
                }

            }
            
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            this.Hide();
            men.Show();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
            int tamanoL = this.Width / 5;
            int tamanoR = this.Height / 8;
            panel1.Left = tamanoL;
            panel1.Top = tamanoR;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (cmbseleccion.Text == "Identidad del Cliente")
                if (txtID.MaskFull == false)
                {
                    MessageBox.Show("Error, campo vacio","Error");
                }
                else
                dtConsultas.DataSource = BD.Cargar_Cliente(txtID.Text); 
            if(cmbseleccion.Text== "Codigo Recibo")
            {
                if (txtingreso.Text == "")
                {
                    MessageBox.Show("Error, campo vacio", "Error");
                }
                else
                dtConsultas.DataSource = BD.CargarArticulo(int.Parse(txtingreso.Text));
            }
            if(cmbseleccion.Text == "Codigo Factura")
            {
                if (txtingreso.Text == "")
                {
                    MessageBox.Show("Error, campo vacio", "Error");
                }
                else
                dtConsultas.DataSource = BD.Cargar_Factura(int.Parse(txtingreso.Text));
            }
            if(cmbseleccion.Text == "Numero de Serie")
            {
                if (txtIngresochar.Text == "")
                {
                    MessageBox.Show("Error, campo vacio", "Error");
                }
                else
                dtConsultas.DataSource = BD.Cargar_NumSerie(txtIngresochar.Text);
            }
            if(cmbseleccion.Text == "Tipo de Articulos")
            {
                if (cmbtipartic.Text == "")
                {
                    MessageBox.Show("Error, seleccione un tipo de articulo", "Error");
                }
                else
                {
                    if (cmbtipartic.Text == "Joyería")
                        dtConsultas.DataSource = BD.Cargar_TpArt(1);
                    else
                        if (cmbtipartic.Text == "Transporte")
                        dtConsultas.DataSource = BD.Cargar_TpArt(2);
                    else
                            if (cmbtipartic.Text == "Electrodoméstico")
                        dtConsultas.DataSource = BD.Cargar_TpArt(3);
                    else
                                if (cmbtipartic.Text == "Mueble")
                        dtConsultas.DataSource = BD.Cargar_TpArt(4);
                    else
                                       if (cmbtipartic.Text == "Electrónico")
                        dtConsultas.DataSource = BD.Cargar_TpArt(5);
                    else
                        dtConsultas.DataSource = BD.Cargar_TpArt(6);
                }
            }

            
        }

        private void txtingreso_KeyPress(object sender, KeyPressEventArgs e)
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
