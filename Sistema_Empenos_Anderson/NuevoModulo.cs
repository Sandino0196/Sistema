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
    public partial class NuevoModulo : Form
    {
        public NuevoModulo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtArticulos.DataSource = BD.CargarArticulos(cmbTipo_Articulo.SelectedIndex + 1);
        }

        private void NuevoModulo_Load(object sender, EventArgs e)
        {
            cmbTipo_Articulo.DataSource = BD.CargarTipoArticulos();
            cmbTipo_Articulo.DisplayMember = "Descripcion";
            cmbTipo_Articulo.ValueMember = "Codigo_Tipo_Articulo";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
