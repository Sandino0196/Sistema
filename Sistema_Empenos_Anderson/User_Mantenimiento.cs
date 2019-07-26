using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class User_Mantenimiento : Form
    {
        public User_Mantenimiento()
        {
            InitializeComponent();
            txtNom_User_Tipo.Enabled = true;
            btnBuscarTipo.Enabled = true;
            txtNom_User_Pass.Enabled = true;
            btnBuscarPassword.Enabled = true;
            txtNom_User_Pass.Enabled = false;
            btnBuscarPassword.Enabled = false;
            txtNom_User_Nuevo.Enabled = true;
            txtPassNuevo_New.Enabled = true;
            txtPassConfirmar_New.Enabled = true;           
        }

        public User_Mantenimiento(int tab)
        {
            InitializeComponent();
            tabCUsuario.SelectTab(tab);
            txtNom_User_Tipo.Enabled = false;
            btnBuscarTipo.Enabled = false;
            if (tab == 1)
            {
                txtNom_User_Pass.Enabled = true;
                btnBuscarPassword.Enabled = true;
                txtNom_User_Nuevo.Enabled = false;
                txtPassNuevo_New.Enabled = false;
                txtPassConfirmar_New.Enabled = false;
                cbxTp_User_New.Enabled = false;
                btnAceptarNew.Enabled = false;
            } else
            {
                txtNom_User_Pass.Enabled = false;
                btnBuscarPassword.Enabled = false;
                txtNom_User_Nuevo.Enabled = true;
                txtPassNuevo_New.Enabled = true;
                txtPassConfirmar_New.Enabled = true;
                cbxTp_User_New.Enabled = true;
                btnAceptarNew.Enabled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if(Objetos_Globales.usuario.codigo_Usuario == 0)
            {
                this.Close();
            } else {
                Manteminiento manteminiento = new Manteminiento();
                this.Close();
                manteminiento.Show();
            }
        }

        private void btnBuscarTipo_Click(object sender, EventArgs e)
        {
            if (BD.Busqueda_Usuario(txtNom_User_Tipo.Text) > 0)
            {
                cbxTp_User_Modificar.Enabled = true;
                btnAceptarTipo.Enabled = true;
            } else
            {
                MessageBox.Show("No se ha encontrado al usuario", "Advertencia");
            }
        }

        private void User_Mantenimiento_Load(object sender, EventArgs e)
        {
            BD.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("SP_Tipos_Usuario", BD.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            BD.CloseConnection();

            cbxTp_User_Modificar.DataSource = dt;
            cbxTp_User_Modificar.DisplayMember = "Descripcion";
            cbxTp_User_Modificar.ValueMember = "Codigo_Tipo_Usuario";

            cbxTp_User_New.DataSource = dt;
            cbxTp_User_New.DisplayMember = "Descripcion";
            cbxTp_User_New.ValueMember = "Codigo_Tipo_Usuario";
            
        }

        private void btnAceptarNew_Click(object sender, EventArgs e)
        {
            int tipo;
            if (cbxTp_User_New.SelectedItem.ToString().Equals("Administrador"))
                tipo = 1;
            else
                tipo = 2;

            if (txtPassNuevo_New.Text.Equals(txtPassConfirmar_New.Text))
            {
                if (BD.Ingreso_Usuario(2, txtNom_User_Nuevo.Text, txtPassNuevo_New.Text, tipo) > 0)
                {
                    MessageBox.Show("El usuario se ha ingresado correctamente", "Mensaje");
                    txtNom_User_Tipo.Text = "";
                    cbxTp_User_Modificar.Enabled = false;
                    btnAceptarTipo.Enabled = false;
                }
                else
                    MessageBox.Show("El usuario no ha podido ser ingresado", "Error");
            }
            else
                MessageBox.Show("Las contraseñas no coinciden","Error");
        }

        private void btnAceptarPassword_Click(object sender, EventArgs e)
        {
            if (txtPassNuevo_Change.Text.Equals(txtPassConfirmar_Change.Text))
            {
                if (Objetos_Mantenimiento.usuarioMantenimiento.password_Usuario.Equals(txtPass_Change.Text))
                {
                    if (BD.Cambio_Password(txtNom_User_Pass.Text, txtPassNuevo_Change.Text) > 0)
                    {
                        MessageBox.Show("Se ha modificado correctamente", "Mensaje");
                        txtNom_User_Pass.Text = "";
                        txtPass_Change.Text = "";
                        txtPassNuevo_Change.Text = "";
                        txtPassConfirmar_Change.Text = "";
                        txtPass_Change.Enabled = false;
                        txtPassNuevo_Change.Enabled = false;
                        txtPassConfirmar_Change.Enabled = false;
                    }
                    else
                        MessageBox.Show("Hubo un error al ingresar la contraseña", "Error");
                } else
                    MessageBox.Show("La contraseña del usuario es incorrecta", "Error");
            } else
                MessageBox.Show("Las contraseñas no coinciden", "Error");
        }

        private void btnAceptarTipo_Click(object sender, EventArgs e)
        {
            int tipo;
            if (cbxTp_User_Modificar.SelectedItem.ToString().Equals("Administrador"))
                tipo = 1;
            else
                tipo = 2;

            if(BD.Cambio_Tipo_Usuario(txtNom_User_Tipo.Text,tipo) > 0)
            {
                MessageBox.Show("Cambio realizado correctamente","Mensaje");
                cbxTp_User_Modificar.Enabled = false;
                btnAceptarTipo.Enabled = false;
            } else
                MessageBox.Show("No se pudo realizar el cambio", "Error");
        }

        private void btnBuscarPassword_Click(object sender, EventArgs e)
        {
            if (BD.Busqueda_Usuario(txtNom_User_Tipo.Text) > 0)
            {
                txtPass_Change.Enabled = true;
                txtPassNuevo_Change.Enabled = true;
                txtPassConfirmar_Change.Enabled = true;
                btnAceptarPassword.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se ha encontrado al usuario", "Advertencia");
            }
        }
    }
}