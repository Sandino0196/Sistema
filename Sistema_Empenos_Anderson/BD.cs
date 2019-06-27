using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Sistema_Empenos_Anderson
{
    public class BD
    {
        public static SqlConnection connection = new SqlConnection();

        public static void OpenConnection()
        {
            connection.ConnectionString = @"Data Source=DESKTOP-D1B8U5J; Initial Catalog=Base_Empeños; Integrated Security=Yes";
            connection.Open();
            //Donde dice DATA SOURCE le ponen el nombre de su máquina; 
        }

        public static void CloseConnection()
        {
            connection.Close();
        }

        public static int Login(string usuario, string password)
        {
            int login = 0;

            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SP_Login";
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@usuario", usuario));
            command.Parameters.Add(new SqlParameter("@password", password));
            SqlParameter pLogin = new SqlParameter("@login",0);
            pLogin.Direction = ParameterDirection.Output;
            command.Parameters.Add(pLogin);

            command.ExecuteNonQuery();

            CloseConnection();

            login = int.Parse(command.Parameters["@login"].Value.ToString());

            return login;
        }

        public static int Busqueda_Cliente(string Identidad)
        {
            int Verificador = 0;

            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SP_BusquedaCliente";
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Identidad", Identidad));

            SqlParameter verificador = new SqlParameter("@Verificador", 0);
            verificador.Direction = ParameterDirection.Output;
            command.Parameters.Add(verificador);

            SqlParameter nombre = new SqlParameter("@Nombre", " ");
            nombre.Direction = ParameterDirection.Output;
            nombre.Size = 50;
            command.Parameters.Add(nombre);

            SqlParameter apellido = new SqlParameter("@Apellido", " ");
            apellido.Direction = ParameterDirection.Output;
            apellido.Size = 50;
            command.Parameters.Add(apellido);

            SqlParameter telefono = new SqlParameter("@Telefono", " ");
            telefono.Direction = ParameterDirection.Output;
            telefono.Size = 50;
            command.Parameters.Add(telefono);

            SqlParameter correo = new SqlParameter("@Correo", " ");
            correo.Direction = ParameterDirection.Output;
            correo.Size = 50;
            command.Parameters.Add(correo);

            command.ExecuteNonQuery();

            CloseConnection();

            Verificador = Int32.Parse(command.Parameters["@Verificador"].Value.ToString());

            return Verificador;
        }

    }
}
