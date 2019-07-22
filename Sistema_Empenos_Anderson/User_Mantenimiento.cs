using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_Empenos_Anderson
{
    public partial class User_Mantenimiento : Form
    {
        public User_Mantenimiento(int tab)
        {
            InitializeComponent();
            tabCUsuario.SelectTab(tab);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if(Usuario.Codigo_Usuario == 0)
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

        }

        private void btnAceptarPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarTipo_Click(object sender, EventArgs e)
        {
            if (cbxTp_User_Modificar.SelectedItem.ToString().Equals("Administrador"))
            {
                if()
            }
        }
    }
}