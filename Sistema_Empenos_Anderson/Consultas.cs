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
            Menu men = new Sistema_Empenos_Anderson.Menu(Objetos_Globales.usuario.codigo_Usuario);
            men.Show();
        }

        public Consultas()
        {
            InitializeComponent();
            lblcambio.Visible = false;
            txtingreso.Visible = false;
            cmbtipartic.Visible = false;
            btnaceptar.Visible = false;

        }

        private void cmbseleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cmbseleccion.Text=="Tipo de Articulos")
            {
                lblcambio.Text = "Seleccione un Tipo de Articulos: ";
                lblcambio.Visible = true;
                txtingreso.Visible = false;
                cmbtipartic.Visible = true;
                btnaceptar.Visible = true;
            }
            else
            {
                lblcambio.Text = "Ingrese Datos: ";
                lblcambio.Visible = true;
                txtingreso.Visible = true;
                txtingreso.Clear();
                txtingreso.Focus();
                cmbtipartic.Visible = false;
                btnaceptar.Visible = true;

            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if(cmbseleccion.Text=="Identidad del Cliente")
                dtConsultas.DataSource = BD.Cargar_Cliente(txtingreso.Text); 

            if(cmbseleccion.Text== "Codigo Recibo")
            {
                dtConsultas.DataSource = BD.CargarArticulo(int.Parse(txtingreso.Text));
            }
            if(cmbseleccion.Text == "Codigo Factura")
            {
                dtConsultas.DataSource = BD.Cargar_Factura(int.Parse(txtingreso.Text));
            }
            if(cmbseleccion.Text == "Numero de Serie")
            {
                dtConsultas.DataSource = BD.Cargar_NumSerie(txtingreso.Text);
            }
            if(cmbseleccion.Text == "Tipo de Articulos")
            {
                if(cmbtipartic.Text== "Joyería")
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
}
