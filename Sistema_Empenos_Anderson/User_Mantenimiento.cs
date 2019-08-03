using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class User_Mantenimiento : Form
    {
        string[] preguntas = { "¿´Cuál es el nombre de la ciudad donde naciste?",
                "¿Cuál es tu color favorito?",
                "¿Cuál es el segundo nombre de tu padre?",
                "¿Cuál es el nombre de tu primer mascota?",
                "¿Cuál es tu comida favorita?" };

        public User_Mantenimiento()
        {
            InitializeComponent();
            txtNom_User_Tipo.Enabled = true;
            btnBuscarTipo.Enabled = true;
            txtNom_User_Pass.Enabled = true;
            btnBuscarPassword.Enabled = true;
            txtNom_User_Nuevo.Enabled = true;
            txtPassNuevo_New.Enabled = true;
            txtPassConfirmar_New.Enabled = true;
            cmbPreguntas1.Enabled = true;
            cmbPreguntas2.Enabled = true;
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
                cmbPreguntas1.Enabled = true;
                cmbPreguntas2.Enabled = true;
                txtNom_User_Nuevo.Enabled = false;
                txtPassNuevo_New.Enabled = false;
                txtPassConfirmar_New.Enabled = false;
                cbxTp_User_New.Enabled = false;
                btnAceptarNew.Enabled = false;
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

            for (int i = 0; i < 5; i++)
            {
                cmbPreguntas1.Items.Add(preguntas[i]);
                cmbPreguntas2.Items.Add(preguntas[i]);
            }
        }

        private void btnAceptarNew_Click(object sender, EventArgs e)
        {
            int tipo;
            if (cbxTp_User_New.SelectedItem.ToString().Equals("Administrador"))
                tipo = 1;
            else
                tipo = 2;
            if(BD.Busqueda_Usuario(txtNom_User_Nuevo.Text) > 0)
            {
                if (txtPassNuevo_New.Text.Equals(txtPassConfirmar_New.Text))
                {
                    if(cmbPreguntas1.SelectedIndex != cmbPreguntas2.SelectedIndex)
                    {
                        if (BD.Ingreso_Usuario(txtNom_User_Nuevo.Text, txtPassNuevo_New.Text, tipo, 1, "Usuario",
                        Objetos_Globales.fechaHoy, cmbPreguntas1.SelectedItem.ToString(),
                        cmbPreguntas2.SelectedItem.ToString(), txtRespuesta1.Text, txtRespuesta2.Text) > 0)
                        {
                            MessageBoxTemporal.Show("El usuario se ha ingresado correctamente", "Mensaje", 1, false);
                            txtNom_User_Tipo.Text = "";
                            cbxTp_User_Modificar.Enabled = false;
                            btnAceptarTipo.Enabled = false;
                        }
                        else
                            MessageBoxTemporal.Show("El usuario no ha podido ser ingresado", "Error", 1, false);
                    }
                    else
                        MessageBoxTemporal.Show("Las preguntas no pueden ser las mismas", "Error", 1, false);
                }
                else
                    MessageBoxTemporal.Show("Las contraseñas no coinciden", "Error",1,false);
            } else
                MessageBoxTemporal.Show("El nombre de usuario ya existe", "Error", 1, false);
        }

        private void btnAceptarPassword_Click(object sender, EventArgs e)
        {
            if (txtPassNuevo_Change.Text.Equals(txtPassConfirmar_Change.Text))
            {
               if (Objetos_Mantenimiento.usuarioMantenimiento.password_Usuario.Equals(txtPassNuevo_Change.Text))
                {
                   /* if (BD.Cambio_Password(txtNom_User_Pass.Text, txtPassNuevo_Change.Text) > 0)
                    {
                        MessageBox.Show("Se ha modificado correctamente", "Mensaje");
                        txtNom_User_Pass.Text = "";
                        txtPassNuevo_Change.Text = "";
                        txtPassConfirmar_Change.Text = "";
                        txtPassNuevo_Change.Enabled = false;
                        txtPassConfirmar_Change.Enabled = false;
                    }
                    else
                        MessageBox.Show("Hubo un error al ingresar la contraseña", "Error");*/
                } else
                    MessageBox.Show("No se puede cambiar porque la contraseña es la misma", "Error");
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
                //txtPass_Change.Enabled = true;
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