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
    public partial class Consulta_Facturacion : Form
    {
        public Consulta_Facturacion()
        {
            InitializeComponent();
        }

        private void Consulta_Facturacion_Load(object sender, EventArgs e)
        {
           

            
        }

        private void rbRecibo_CheckedChanged(object sender, EventArgs e)
        {
            if(rbRecibo.Checked)
                lbl1.Text = "Ingrese Código del Recibo:";
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCliente.Checked)
                lbl1.Text = "Ingrese Identidad del Cliente:";
        }

        private void bttBuscar_Click(object sender, EventArgs e)
        {
            if (rbRecibo.Checked)
            {
                BD.OpenConnection();
                SqlCommand cmd = new SqlCommand("Select  * from[dbo].[F_Buscar_Recibo]("+ int.Parse(txtCod.Text) + ") ", BD.connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                BD.CloseConnection();
            }
        }
    }
}
