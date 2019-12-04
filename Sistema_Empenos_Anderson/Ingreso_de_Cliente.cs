using System;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

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

        private Boolean Validar_Correo(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda_ID.MaskFull)
            {
                if (BD.Busqueda_Cliente(txtBusqueda_ID.Text) > 0)
                {
                    Objetos_Globales.cliente.identidad_Cliente = txtBusqueda_ID.Text;
                    dtgv_Info_Cliente.Rows[0].Cells[0].Value = Objetos_Globales.cliente.nombre_Cliente;
                    dtgv_Info_Cliente.Rows[0].Cells[1].Value = Objetos_Globales.cliente.apellido_Cliente;
                    dtgv_Info_Cliente.Rows[0].Cells[2].Value = Objetos_Globales.cliente.telefono_Cliente;
                    dtgv_Info_Cliente.Rows[0].Cells[3].Value = Objetos_Globales.cliente.correo_Cliente;
                    btnAvanzar.Enabled = true;
                    grpInfo_Nuevo_Cliente.Enabled = false;
                }
                else
                {
                    DialogResult res = MessageBox.Show("No se encontro el cliente en la Base de Datos\nDesea Agregarlo?", "ALERTA", MessageBoxButtons.YesNo);
                    if (res.ToString() == "Yes")
                    {
                        grpInfo_Nuevo_Cliente.Enabled = true;
                        btnAñadir.Enabled = true;
                        txtIdentidad.Text = txtBusqueda_ID.Text;
                        txtNombre.Focus();
                        btnAvanzar.Enabled = false;
                    } else
                    {
                        
                        grpInfo_Nuevo_Cliente.Enabled = false;
                        btnAñadir.Enabled = false;
                    }
                }
            } else    
                MessageBoxTemporal.Show("Ingrese bien la identidad", "Error",1,false);
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
            txtBusqueda_ID.Focus();
            txtBusqueda_ID.Select();
            int tamanoL = this.Width / 5;
            int tamanoR = this.Height / 4;
            panel1.Left = tamanoL;
            panel1.Top = tamanoR;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtTelefono.MaskFull && txtNombre.Text!="" && txtApellido.Text!="" && Validar_Correo(txtCorreo.Text))
            {
                if (BD.Ingreso_Cliente(txtIdentidad.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, 1, "Cliente") == 0)
                {
                    MessageBoxTemporal.Show("Identidad encontrada en otro registro, utilice otra o el cliente ya está agregado", "Mensaje Importante",2,false);
                }
                else
                {
                    MessageBoxTemporal.Show("Ingresado correctamente", "Mensaje Importante",1,false);
                    Objetos_Globales.cliente.nombre_Cliente = txtNombre.Text;
                    Objetos_Globales.cliente.apellido_Cliente = txtApellido.Text;
                    Objetos_Globales.cliente.telefono_Cliente = txtTelefono.Text;
                    Objetos_Globales.cliente.correo_Cliente = txtCorreo.Text;
                    Objetos_Globales.cliente.identidad_Cliente = txtBusqueda_ID.Text;
                    dtgv_Info_Cliente.Rows[0].Cells[0].Value = Objetos_Globales.cliente.nombre_Cliente;
                    dtgv_Info_Cliente.Rows[0].Cells[1].Value = Objetos_Globales.cliente.apellido_Cliente;
                    dtgv_Info_Cliente.Rows[0].Cells[2].Value = Objetos_Globales.cliente.telefono_Cliente;
                    dtgv_Info_Cliente.Rows[0].Cells[3].Value = Objetos_Globales.cliente.correo_Cliente;
                    btnAvanzar.Enabled = true;
                }
            } else
            {
                MessageBoxTemporal.Show("Ha ingresado incorrectamente algunos datos!\nPorfavor Reviselos.", "Mensaje Importante", 2, false);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBoxTemporal.Show("Solo se permiten letras", "Advertencia", 1, false);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBoxTemporal.Show("Solo se permiten letras", "Advertencia", 1, false);
                e.Handled = true;
                return;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu();
            this.Hide();
            men.Show();
        }
    }
}
