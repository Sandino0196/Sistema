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
            connection.ConnectionString = @"Data Source=DESKTOP-H4LNV2M; Initial Catalog=Base_Empeños; Integrated Security=Yes";
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

    }
}
