﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class Facturacion_Detalle : Form
    {
        public Facturacion_Detalle()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            Menu men = new Sistema_Empenos_Anderson.Menu(Objetos_Globales.usuario.codigo_Usuario);
            men.Show();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
            double subtotal = 0, isv = 0;
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
            txtVendedor.Text = Objetos_Globales.usuario.nombre_Usuario;
            txtFechaVenta.Text = Objetos_Globales.fechaHoyCorta;
            isv = Objetos_Globales.articulo.MontoPago * 0.15;
            subtotal = Objetos_Globales.articulo.MontoPago - isv;
            txtSubtotal.Text = subtotal.ToString();
            txtISV.Text = isv.ToString();
            txtTotalPagar.Text = Objetos_Globales.articulo.MontoPago.ToString();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (BD.Busqueda_Cliente(txtIDComp.Text) > 0)
            {
                Objetos_Globales.cliente.identidad_Cliente = txtIDComp.Text;
                txtNombre.Text = Objetos_Globales.cliente.nombre_Cliente;
                txtApellido.Text = Objetos_Globales.cliente.apellido_Cliente;
                txtTelefono.Text = Objetos_Globales.cliente.telefono_Cliente;
                txtCorreo.Text = Objetos_Globales.cliente.correo_Cliente;                
            }
            else
            {
                DialogResult res = MessageBox.Show("No se encontro el cliente en la Base de Datos\nDesea Agregarlo?", "ALERTA", MessageBoxButtons.YesNo);
                if (res.ToString() == "Yes")
                {
                    btnAdd.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtNombre.Focus();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTelefono.MaskFull && txtNombre.Text != "" && txtApellido.Text != "" && Validar_Correo(txtCorreo.Text))
            {
                if (BD.Ingreso_Cliente(txtIDComp.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, 1, "Cliente") == 0)
                {
                    MessageBoxTemporal.Show("Identidad encontrada en otro registro, utilice otra o el cliente ya está agregado", "Mensaje Importante", 2, false);
                }
                else
                {
                    MessageBoxTemporal.Show("Ingresado correctamente", "Mensaje Importante", 1, false);
                    Objetos_Globales.cliente.nombre_Cliente = txtNombre.Text;
                    Objetos_Globales.cliente.apellido_Cliente = txtApellido.Text;
                    Objetos_Globales.cliente.telefono_Cliente = txtTelefono.Text;
                    Objetos_Globales.cliente.correo_Cliente = txtCorreo.Text;
                    Objetos_Globales.cliente.identidad_Cliente = txtIDComp.Text;
                    btnAdd.Enabled = false;
                }
            }
            else
            {
                MessageBoxTemporal.Show("Ha ingresado incorrectamente algunos datos!\nPorfavor Reviselos.", "Mensaje Importante", 2, false);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(double.Parse(txtTotalPagar.Text) > double.Parse(txtMonto.Text))
                MessageBoxTemporal.Show("Monto ingresado es menor al de venta", "Mensaje importante", 2, false);
            else
            {
                if (txtIDComp.MaskFull)
                    BD.Ingreso_Factura(int.Parse(txtCodigo.Text), txtIDComp.Text, Objetos_Globales.usuario.codigo_Usuario, txtFechaVenta.Text);
                else
                    BD.Ingreso_Factura(int.Parse(txtCodigo.Text), null, Objetos_Globales.usuario.codigo_Usuario, txtFechaVenta.Text);

                for (int i = 0; i < Objetos_Globales.articulos.Count; i++)
                {
                    BD.Ingreso_Articulo_Vendido(int.Parse(txtCodigo.Text), ((Articulo)Objetos_Globales.articulos[i]).NumeroSerie,
                        ((Articulo)Objetos_Globales.articulos[i]).NumeroRecibo, ((Articulo)(Objetos_Globales.articulos[i])).MontoPago);
                }
                MessageBoxTemporal.Show("Realizado correctamente", "Mensaje importante", 1, false);
                this.Hide();
                Menu men = new Sistema_Empenos_Anderson.Menu(Objetos_Globales.usuario.codigo_Tipo_Usuario);
                men.Show();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturacion facturacion = new Facturacion();
            facturacion.Show();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBoxTemporal.Show("Solo se permiten numeros", "Advertencia", 1, false);
                e.Handled = true;
                return;
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBoxTemporal.Show("Solo se permiten numeros", "Advertencia", 1, false);
                e.Handled = true;
                return;
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
    }
}
