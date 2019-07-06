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
            connection.ConnectionString = @"Data Source=DESKTOP-T785USI; Initial Catalog=Base_Empeños; Integrated Security=Yes";
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

            SqlParameter verificador = new SqlParameter("@Verificador", 0);
            verificador.Direction = ParameterDirection.Output;
            command.Parameters.Add(verificador);

            command.ExecuteNonQuery();

            CloseConnection();

            try
            {
                Verificador = int.Parse(command.Parameters["@Verificador"].Value.ToString());
            }
            catch
            {
                Verificador = 0;
            }
            Cliente.Nombre_Cliente = command.Parameters["@Nombre"].Value.ToString();
            Cliente.Apellido_Cliente = command.Parameters["@Apellido"].Value.ToString();
            Cliente.Telefono_Cliente = command.Parameters["@Telefono"].Value.ToString();
            Cliente.Correo_Cliente = command.Parameters["@Correo"].Value.ToString();


            return Verificador;
        }

        public static int Busqueda_Articulo(int recibo, string numeroSerie)
        {
            int existencia = 0;

            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SP_BusquedaArticulo";
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@NumRecibo", recibo));
            command.Parameters.Add(new SqlParameter("@NumSerie", numeroSerie));

            SqlParameter descripcion = new SqlParameter("@Descripcion", " ");
            descripcion.Direction = ParameterDirection.Output;
            descripcion.Size = 100;
            command.Parameters.Add(descripcion);

            SqlParameter marca = new SqlParameter("@Marca", " ");
            marca.Direction = ParameterDirection.Output;
            marca.Size = 50;
            command.Parameters.Add(marca);

            SqlParameter modelo = new SqlParameter("@Modelo", " ");
            modelo.Direction = ParameterDirection.Output;
            modelo.Size = 50;
            command.Parameters.Add(modelo);

            SqlParameter estado = new SqlParameter("@Estado", " ");
            estado.Direction = ParameterDirection.Output;
            estado.Size = 50;
            command.Parameters.Add(estado);

            SqlParameter prestado = new SqlParameter("@Prestado",0);
            prestado.Direction = ParameterDirection.Output;
            command.Parameters.Add(prestado);

            SqlParameter existe = new SqlParameter("@Existencia", 0);
            existe.Direction = ParameterDirection.Output;
            command.Parameters.Add(existe);

            command.ExecuteNonQuery();

            CloseConnection();

            try
            {
                existencia = int.Parse(command.Parameters["@Existencia"].Value.ToString());
            }
            catch
            {
                existencia = 0;
            }

            Articulo.descripcion = command.Parameters["@Descripcion"].Value.ToString();
            Articulo.marca = command.Parameters["@Marca"].Value.ToString();
            Articulo.modelo = command.Parameters["@Modelo"].Value.ToString();
            Articulo.estado = command.Parameters["@Estado"].Value.ToString();
            Articulo.prestado = double.Parse(command.Parameters["@Prestado"].Value.ToString());

            return existencia;
        }

        public static void Ingreso_Recibo(int Codigo, string Identidad, int Codigo_user, string Fecha)
        {
            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SP_IngresarRecibo";
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Codigo", Codigo));
            command.Parameters.Add(new SqlParameter("@Id_Cliente", Identidad));
            command.Parameters.Add(new SqlParameter("@Cod_Usuario", Codigo_user));
            command.Parameters.Add(new SqlParameter("@Fecha_Recibo", Fecha));

            command.ExecuteNonQuery();
            CloseConnection();
        }

        public static void Ingreso_Cliente(string identidad, string nombre, string apellido, string telefono, string correo)
        {
            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SP_Ingreso_Cliente";
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@identidad", identidad));
            command.Parameters.Add(new SqlParameter("@nombre", nombre));
            command.Parameters.Add(new SqlParameter("@apellido", apellido));
            command.Parameters.Add(new SqlParameter("@telefono", telefono));
            command.Parameters.Add(new SqlParameter("@correo", correo));

            command.ExecuteNonQuery();
            CloseConnection();
        }

        public static void Ingreso_Articulo( int codigo, string Numero_Serie, int Tipo_Art, string Descripcion, string Marca, string Modelo, double Monto, double Tasa, int Estado)
        {
            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SP_Ingreso_Articulo";
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Codigo", codigo));
            command.Parameters.Add(new SqlParameter("@Numero_Serie", Numero_Serie));
            command.Parameters.Add(new SqlParameter("@Tipo_Articulo", Tipo_Art));
            command.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));
            command.Parameters.Add(new SqlParameter("@Marca", Marca));
            command.Parameters.Add(new SqlParameter("@Modelo", Modelo));
            command.Parameters.Add(new SqlParameter("@Monto", Monto));
            command.Parameters.Add(new SqlParameter("@Tasa", Tasa));
            command.Parameters.Add(new SqlParameter("@Estado", Estado));

            command.ExecuteNonQuery();

            CloseConnection();
        }

        public static void Ingreso_Factura(int codigoFactura, string identidad, int codigoUsuario, string fecha)
        {
            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SP_Ingreso_Facturacion";
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@CodFact", codigoFactura));
            command.Parameters.Add(new SqlParameter("@ID_Cliente", identidad));
            command.Parameters.Add(new SqlParameter("@Cod_Us", codigoUsuario));
            command.Parameters.Add(new SqlParameter("@Fecha", fecha));

            command.ExecuteNonQuery();

            CloseConnection();
        }

        public static void Ingreso_Articulo_Vendido(int codigoFactura, string numeroSerie, int recibo, double precio)
        {
            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SP_Ingreso_Fact_Detalle";
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Cod_Fact", codigoFactura));
            command.Parameters.Add(new SqlParameter("@Num_Serie", numeroSerie));
            command.Parameters.Add(new SqlParameter("@Cod_Rec", recibo));
            command.Parameters.Add(new SqlParameter("@Prec_Vent", precio));

            command.ExecuteNonQuery();

            CloseConnection();
        }

    }
}
