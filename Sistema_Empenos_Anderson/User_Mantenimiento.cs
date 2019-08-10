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
            txtNom_User_Pass.Enabled = true;
            btnBuscarPassword.Enabled = true;
            txtRespuesta1Pass.Enabled = true;
            txtRespuesta2Pass.Enabled = true;
            cmbPreguntas1.Enabled = true;
            cmbPreguntas2.Enabled = true;
            txtNom_User_Nuevo.Enabled = true;
            txtPassNuevo_New.Enabled = true;
            txtPassConfirmar_New.Enabled = true;
            cbxTp_User_New.Enabled = true;
            btnAceptarNew.Enabled = true;
            btnBuscarEliminar.Enabled = true;
            txtUsuarioEliminar.Enabled = true;
            txtRespuesta1.Enabled = true;
            txtRespuesta2.Enabled = true;
            txtNom_User_Tipo.Enabled = true;
            btnBuscarTipo.Enabled = true;
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
                txtRespuesta1Pass.Enabled = true;
                txtRespuesta2Pass.Enabled = true;
                cmbPreguntas1.Enabled = false;
                cmbPreguntas2.Enabled = false;
                txtNom_User_Nuevo.Enabled = false;
                txtPassNuevo_New.Enabled = false;
                txtPassConfirmar_New.Enabled = false;
                cbxTp_User_New.Enabled = false;
                btnAceptarNew.Enabled = false;
                btnBuscarEliminar.Enabled = false;
                txtUsuarioEliminar.Enabled = false;
                txtRespuesta1.Enabled = false;
                txtRespuesta2.Enabled = false;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            Manteminiento man = new Manteminiento();
            man.Show();
            this.Dispose();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if(Objetos_Globales.usuario.codigo_Usuario == 0)
            {
                Form1 form = new Form1();
                this.Close();
                form.Show();
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
            this.Icon = Properties.Resources.Icons8_Windows_8_Ecommerce_Cash_Register;
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
            if(BD.Busqueda_Usuario(txtNom_User_Nuevo.Text) == 0)
            {
                if (txtPassNuevo_New.Text.Equals(txtPassConfirmar_New.Text))
                {
                    if(cmbPreguntas1.SelectedIndex != cmbPreguntas2.SelectedIndex)
                    {
                        if (BD.Ingreso_Usuario(txtNom_User_Nuevo.Text, txtPassNuevo_New.Text,cbxTp_User_New.SelectedIndex+1, 1, "Usuario",
                        Objetos_Globales.fechaHoy(), cmbPreguntas1.SelectedItem.ToString(),
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
               if (Objetos_Mantenimiento.usuarioMantenimiento.password_Usuario !=  (txtPassNuevo_Change.Text))
                {
                    if (BD.Cambio_Password(txtNom_User_Pass.Text, txtPassNuevo_Change.Text, txtRespuesta1Pass.Text, txtRespuesta2Pass.Text) > 0)
                    {
                        MessageBox.Show("Se ha modificado correctamente", "Mensaje");
                        txtNom_User_Pass.Text = "";
                        txtPassNuevo_Change.Text = "";
                        txtPassConfirmar_Change.Text = "";
                        txtPassNuevo_Change.Enabled = false;
                        txtPassConfirmar_Change.Enabled = false;
                    }
                    else
                        MessageBox.Show("Hubo un error al ingresar la contraseña", "Error");
                } else
                    MessageBox.Show("No se puede cambiar porque la contraseña es la misma", "Error");
            } else
                MessageBox.Show("Las contraseñas no coinciden", "Error");
        }

        private void btnAceptarTipo_Click(object sender, EventArgs e)
        {
            if(BD.Cambio_Tipo_Usuario(txtNom_User_Tipo.Text, cbxTp_User_Modificar.SelectedIndex+1) > 0)
            {
                MessageBoxTemporal.Show("Cambio realizado correctamente","Mensaje",1,false);
                cbxTp_User_Modificar.Enabled = false;
                btnAceptarTipo.Enabled = false;
            } else
                MessageBoxTemporal.Show("No se pudo realizar el cambio", "Error",1,false);
        }

        private void btnBuscarPassword_Click(object sender, EventArgs e)
        {
            if (BD.Busqueda_Usuario(txtNom_User_Pass.Text) > 0)
            {
                lblPregunta1.Text = Objetos_Mantenimiento.usuarioMantenimiento.pregunta1;
                lblPregunta2.Text = Objetos_Mantenimiento.usuarioMantenimiento.pregunta2;
                txtRespuesta1Pass.Enabled = true;
                txtRespuesta2Pass.Enabled = true;
                txtPassNuevo_Change.Enabled = true;
                txtPassConfirmar_Change.Enabled = true;
                btnAceptarPassword.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se ha encontrado al usuario", "Advertencia");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BD.Busqueda_Usuario(txtUsuarioEliminar.Text) > 0)
            {
                if(Objetos_Mantenimiento.usuarioMantenimiento.estado == 2)
                    MessageBoxTemporal.Show("Usuario ya eliminado", "Mensaje Imporante", 1, false);
                else
                {
                    MessageBoxTemporal.Show("Usuario Encontrado", "Mensaje Imporante", 1, false);
                    btnEliminar.Enabled = true;
                }
            }
            else
                MessageBoxTemporal.Show("No se ha encontrado al usuario", "Advertencia",1,false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BD.EliminarUsuario(txtUsuarioEliminar.Text);
            MessageBoxTemporal.Show("Usuario eliminado", "Advertencia", 1, false);
            btnEliminar.Enabled = false;
        }
    }
}