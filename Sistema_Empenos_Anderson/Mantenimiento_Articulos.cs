using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class Mantenimiento_Articulos : Form
    {
        public Mantenimiento_Articulos()
        {
            InitializeComponent();
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
            cbxTipo_Art.DataSource = BD.CargarTipoArticulos();
            cbxTipo_Art.DisplayMember = "Descripcion";
            cbxTipo_Art.ValueMember = "Codigo_Tipo_Articulo";

            cmbEstados.DataSource = BD.CargarEstadosArticulo();
            cmbEstados.DisplayMember = "Descripcion";
            cmbEstados.ValueMember = "Codigo_Estado";
        }

        private void btnConsultaEstado_Click(object sender, EventArgs e)
        {
            Consulta_Articulos cons = new Consulta_Articulos();
            cons.Show();
        }
    }
}
