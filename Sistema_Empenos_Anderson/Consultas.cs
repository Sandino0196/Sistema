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
    }
}
