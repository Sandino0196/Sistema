using System;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class Ingreso_de_Cliente : Form
    {
        public Ingreso_de_Cliente()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (BD.Busqueda_Cliente(txtBusqueda_ID.Text) > 0)
            {
                Objetos_Globales.cliente.identidad_Cliente = txtBusqueda_ID.Text;
                dtgv_Info_Cliente.Rows[0].Cells[0].Value = Objetos_Globales.cliente.nombre_Cliente;
                dtgv_Info_Cliente.Rows[0].Cells[1].Value = Objetos_Globales.cliente.apellido_Cliente;
                dtgv_Info_Cliente.Rows[0].Cells[2].Value = Objetos_Globales.cliente.telefono_Cliente;
                dtgv_Info_Cliente.Rows[0].Cells[3].Value = Objetos_Globales.cliente.correo_Cliente;
                btnAvanzar.Enabled = true;
            }else
            {
                MessageBox.Show("No se encontro el cliente en la Base de Datos\nDesea Agregarlo?","ALERTA", MessageBoxButtons.YesNo);
                grpInfo_Nuevo_Cliente.Enabled = true;
                btnAñadir.Enabled = true;
            }
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            Ingreso_de_Articulo Articulos = new Ingreso_de_Articulo();
            Articulos.Show();
            this.Hide();
        }

        private void Ingreso_de_Cliente_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
            txtBusqueda_ID.Select();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if(BD.Ingreso_Cliente(txtIdentidad.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text) == 0)
            {
                MessageBox.Show("Identidad encontrada en otro registro, utilice otra o el cliente ya está agregado", "Mensaje Importante");
            } else
            {
                MessageBox.Show("Ingresado correctamente", "Mensaje Importante");
                dtgv_Info_Cliente.Rows[0].Cells[0].Value = txtNombre.Text;
                dtgv_Info_Cliente.Rows[0].Cells[1].Value = txtApellido.Text;
                dtgv_Info_Cliente.Rows[0].Cells[2].Value = txtTelefono.Text;
                dtgv_Info_Cliente.Rows[0].Cells[3].Value = txtCorreo.Text;
                Objetos_Globales.cliente.identidad_Cliente = txtBusqueda_ID.Text;
                dtgv_Info_Cliente.Rows[0].Cells[0].Value = Objetos_Globales.cliente.nombre_Cliente;
                dtgv_Info_Cliente.Rows[0].Cells[1].Value = Objetos_Globales.cliente.apellido_Cliente;
                dtgv_Info_Cliente.Rows[0].Cells[2].Value = Objetos_Globales.cliente.telefono_Cliente;
                dtgv_Info_Cliente.Rows[0].Cells[3].Value = Objetos_Globales.cliente.correo_Cliente;
                btnAvanzar.Enabled = true;
            }
        }

    }
}
