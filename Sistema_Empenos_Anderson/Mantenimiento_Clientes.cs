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
    public partial class Mantenimiento_Clientes : Form
    {
        public Mantenimiento_Clientes()
        {
            InitializeComponent();
        }

        private void bttBuscar_Click(object sender, EventArgs e)
        {
            if (txtID_Cliente.MaskFull)
            {
                if (BD.Busqueda_Cliente(txtID_Cliente.Text) > 0)
                {
                    if(Objetos_Globales.cliente.estado == 2)
                        MessageBoxTemporal.Show("Cliente ya eliminado", "Error", 1, false);
                    else
                    {
                        txtNombre.Text = Objetos_Globales.cliente.nombre_Cliente + Objetos_Globales.cliente.apellido_Cliente;
                        txtEstado.Text = "Activo";
                        bttElim.Enabled = true;
                    }
                } 
                else
                    MessageBoxTemporal.Show("No se encuentra al cliente", "Error", 1, false);
            }
            else
                MessageBoxTemporal.Show("Ingrese bien la identidad","Error",1,false);
        }

        private void bttElim_Click(object sender, EventArgs e)
        {
            BD.EliminarCliente(txtID_Cliente.Text);
            MessageBoxTemporal.Show("Cliente eliminado", "Mensaje", 1, false);
            bttElim.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdentidadMod.MaskFull)
            {
                if (BD.Busqueda_Cliente(txtIdentidadMod.Text) > 0)
                {
                    txtNombreMod.Text = Objetos_Globales.cliente.nombre_Cliente;
                    txtApellidoMod.Text = Objetos_Globales.cliente.apellido_Cliente;
                    txtTelefonoMod.Text = Objetos_Globales.cliente.telefono_Cliente;
                    txtCorreoMod.Text = Objetos_Globales.cliente.correo_Cliente;
                    txtNombreMod.Enabled = true;
                    txtApellidoMod.Enabled = true;
                    txtTelefonoMod.Enabled = true;
                    txtCorreoMod.Enabled = true;
                    btnAceptar.Enabled = true;
                }
                else
                    MessageBoxTemporal.Show("No se encuentra al cliente", "Error", 1, false);
            }
            else
                MessageBoxTemporal.Show("Ingrese bien la identidad", "Error", 1, false);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manteminiento manteminiento = new Manteminiento();
            manteminiento.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            BD.Actualizar_Cliente(txtIdentidadMod.Text, txtNombreMod.Text, txtApellidoMod.Text, txtTelefonoMod.Text, txtCorreoMod.Text);
            MessageBoxTemporal.Show("Cliente modificado", "Mensaje Importante", 1, false);
        }

        private void txtNombreMod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBoxTemporal.Show("Solo se permiten letras", "Advertencia", 1, false);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBoxTemporal.Show("Solo se permiten letras", "Advertencia", 1, false);
                e.Handled = true;
                return;
            }
        }

        private void Mantenimiento_Clientes_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
        }
    }
}
