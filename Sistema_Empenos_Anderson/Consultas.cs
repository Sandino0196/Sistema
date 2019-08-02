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
            cmbestado.Visible = false;
            cmbtipartic.Visible = false;
            btnaceptar.Visible = false;

        }

        private void cmbseleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbseleccion.Text=="Estado de Articulos")
            {
                lblcambio.Text = "Seleccione un Estado: ";
                lblcambio.Visible = true;
                txtingreso.Visible = false;
                cmbestado.Visible = true;
                cmbtipartic.Visible = false;
                btnaceptar.Visible = false;

            }
            else if(cmbseleccion.Text=="Tipo de Articulos")
            {
                lblcambio.Text = "Seleccione Tipo de Artiuclos: ";
                lblcambio.Visible = true;
                txtingreso.Visible = false;
                cmbestado.Visible = false;
                cmbtipartic.Visible = true;
                btnaceptar.Visible = false;
            }
            else
            {
                lblcambio.Text = "Ingrese Datos: ";
                lblcambio.Visible = true;
                txtingreso.Visible = true;
                txtingreso.Clear();
                txtingreso.Focus();
                cmbestado.Visible = false;
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
    }
}
