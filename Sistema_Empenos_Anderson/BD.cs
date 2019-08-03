using System.Data;
using System.Data.SqlClient;

namespace Sistema_Empenos_Anderson
{
    public class BD
    {
        public static SqlConnection connection = new SqlConnection();

        #region Conexion

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

        #endregion

        #region Login

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

            SqlParameter pLogin = new SqlParameter("@login", 0);
            pLogin.Direction = ParameterDirection.Output;
            command.Parameters.Add(pLogin);

            SqlParameter pCodigo = new SqlParameter("@codigoUsuario", 0);
            pCodigo.Direction = ParameterDirection.Output;
            command.Parameters.Add(pCodigo);

            SqlParameter pCodigoTipo = new SqlParameter("@codigoTipo", 0);
            pCodigoTipo.Direction = ParameterDirection.Output;
            command.Parameters.Add(pCodigoTipo);

            try
            {
                command.ExecuteNonQuery();

                CloseConnection();

                login = int.Parse(command.Parameters["@login"].Value.ToString());
                Objetos_Globales.usuario.codigo_Usuario = int.Parse(command.Parameters["@codigoUsuario"].Value.ToString());
                Objetos_Globales.usuario.nombre_Usuario = usuario;
                Objetos_Globales.usuario.password_Usuario = password;
                Objetos_Globales.usuario.codigo_Tipo_Usuario = int.Parse(command.Parameters["@codigoTipo"].Value.ToString());
                return login;
            }
            catch
            {
                CloseConnection();
                return 0;
            }
        }

        #region Cargar Datos

        public static DataTable CargarArticulo(int codigo)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("Select  * from[dbo].[F_Buscar_Recibo](" + codigo + ") ", BD.connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch
            {
                return dt;
            }
        }

        public static DataTable CargarTipoArticulos()
        {
            DataTable dt = new DataTable();
            try
            {
                BD.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("SP_Tipos_Articulo", BD.connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                BD.CloseConnection();
                return dt;
            }
            catch
            {
                return dt;
            }
        }

        public static DataTable CargarEstadosArticulo()
        {
            DataTable dt = new DataTable();
            try
            {
                BD.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("SP_Estados", BD.connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                BD.CloseConnection();
                return dt;
            }
            catch
            {
                return dt;
            }
        }

        #endregion

        #region Busqueda

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

            try
            {
                command.ExecuteNonQuery();

                CloseConnection();

                Verificador = int.Parse(command.Parameters["@Verificador"].Value.ToString());
                Objetos_Globales.cliente.identidad_Cliente = Identidad;
                Objetos_Globales.cliente.nombre_Cliente = command.Parameters["@Nombre"].Value.ToString();
                Objetos_Globales.cliente.apellido_Cliente = command.Parameters["@Apellido"].Value.ToString();
                Objetos_Globales.cliente.telefono_Cliente = command.Parameters["@Telefono"].Value.ToString();
                Objetos_Globales.cliente.correo_Cliente = command.Parameters["@Correo"].Value.ToString();
            }
            catch
            {
                Verificador = 0;
            }
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

            SqlParameter tipo = new SqlParameter("@Tipo", " ");
            tipo.Direction = ParameterDirection.Output;
            tipo.Size = 50;
            command.Parameters.Add(tipo);

            SqlParameter estado = new SqlParameter("@Estado", " ");
            estado.Direction = ParameterDirection.Output;
            estado.Size = 50;
            command.Parameters.Add(estado);

            SqlParameter prestado = new SqlParameter("@Prestado", 0);
            prestado.Direction = ParameterDirection.Output;
            command.Parameters.Add(prestado);

            SqlParameter interes = new SqlParameter("@Interes", 0);
            interes.Direction = ParameterDirection.Output;
            command.Parameters.Add(interes);

            SqlParameter identidad = new SqlParameter("@Identidad", " ");
            identidad.Direction = ParameterDirection.Output;
            identidad.Size = 50;
            command.Parameters.Add(identidad);

            SqlParameter meses = new SqlParameter("@Meses", 0);
            meses.Direction = ParameterDirection.Output;
            command.Parameters.Add(meses);

            SqlParameter existe = new SqlParameter("@Existencia", 0);
            existe.Direction = ParameterDirection.Output;
            command.Parameters.Add(existe);

            try
            {
                command.ExecuteNonQuery();

                existencia = int.Parse(command.Parameters["@Existencia"].Value.ToString());
                Objetos_Mantenimiento.articuloMantenimiento.NumeroRecibo = recibo;
                Objetos_Mantenimiento.articuloMantenimiento.NumeroSerie = numeroSerie;
                Objetos_Mantenimiento.articuloMantenimiento.Descripcion = command.Parameters["@Descripcion"].Value.ToString();
                Objetos_Mantenimiento.articuloMantenimiento.Marca = command.Parameters["@Marca"].Value.ToString();
                Objetos_Mantenimiento.articuloMantenimiento.Modelo = command.Parameters["@Modelo"].Value.ToString();
                Objetos_Mantenimiento.articuloMantenimiento.Estado = command.Parameters["@Estado"].Value.ToString();
                Objetos_Mantenimiento.articuloMantenimiento.Tipo = command.Parameters["@Tipo"].Value.ToString();
                Objetos_Mantenimiento.articuloMantenimiento.Prestado = double.Parse(command.Parameters["@Prestado"].Value.ToString());
                Objetos_Mantenimiento.articuloMantenimiento.Interes = int.Parse(command.Parameters["@Interes"].Value.ToString());
                Objetos_Globales.identidadTemporal = command.Parameters["@Identidad"].Value.ToString();
                Objetos_Mantenimiento.articuloMantenimiento.Meses = int.Parse(command.Parameters["@Meses"].Value.ToString());
            }
            catch
            {
                existencia = 0;
            }
            CloseConnection();
            return existencia;
        }

        public static int Busqueda_Usuario(string nombreUsuario)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SP_Busqueda_Usuario ";
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Nombre", nombreUsuario));

            SqlParameter descripcion = new SqlParameter("@Tipo", " ");
            descripcion.Direction = ParameterDirection.Output;
            descripcion.Size = 50;
            command.Parameters.Add(descripcion);

            SqlParameter pass = new SqlParameter("@Password", " ");
            pass.Direction = ParameterDirection.Output;
            pass.Size = 50;
            command.Parameters.Add(pass);

            try
            {
                command.ExecuteNonQuery();
                CloseConnection();
                Objetos_Mantenimiento.usuarioMantenimiento.nombre_Usuario = nombreUsuario;
                Objetos_Mantenimiento.usuarioMantenimiento.tipo_Usuario = command.Parameters["@Tipo"].Value.ToString();
                Objetos_Mantenimiento.usuarioMantenimiento.password_Usuario = command.Parameters["@Password"].Value.ToString();
                return 1;
            }
            catch
            {
                return 0;
            }

        }

        #endregion

        #region Ingreso

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

        public static int Ingreso_Cliente(string identidad, string nombre, string apellido, string telefono, string correo, int cod_estado, string estado)
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
            command.Parameters.Add(new SqlParameter("@Cod_Estado", cod_estado));
            command.Parameters.Add(new SqlParameter("@Estado", estado));

            try
            {
                command.ExecuteNonQuery();
                CloseConnection();
                return 1;
            }
            catch
            {
                CloseConnection();
                return 0;
            }
        }

        public static int Ingreso_Usuario(int codigo, string usuario, string password, int tipo, int cod_estado, string estado, string fecha)
        {
            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SP_Ingreso_Usuario";
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Codigo", codigo));
            command.Parameters.Add(new SqlParameter("@Usuario", usuario));
            command.Parameters.Add(new SqlParameter("@Password", password));
            command.Parameters.Add(new SqlParameter("@Tipo", tipo));
            command.Parameters.Add(new SqlParameter("@Cod_Estado", cod_estado));
            command.Parameters.Add(new SqlParameter("@Estado", estado));
            command.Parameters.Add(new SqlParameter("@Fecha_Creado", fecha));

            try
            {
                command.ExecuteNonQuery();
                CloseConnection();
                return 1;
            }
            catch
            {
                CloseConnection();
                return 0;
            }
        }

        public static void Ingreso_Articulo(int codigo, string Numero_Serie, int Tipo_Art, string Descripcion, string Marca, string Modelo, double Monto, double Tasa, int Estado, int meses, string tipo_estado)
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
            command.Parameters.Add(new SqlParameter("@Meses", meses));
            command.Parameters.Add(new SqlParameter("@Tipo_Estado", tipo_estado));

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
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBoxTemporal.Show("No pudo realizarse la operación", "Mensaje Imporante", 2, false);
            }

            CloseConnection();
        }

        public static void Ingreso_Pago_Interes()
        {

        }

        #endregion

        #region Cambio de datos

        public static int Cambio_Password(string usuario, string password)
        {
            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SP_Cambiar_Password";
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Usuario", usuario));
            command.Parameters.Add(new SqlParameter("@Password", password));

            try
            {
                command.ExecuteNonQuery();
                CloseConnection();
                return 1;
            }
            catch
            {
                CloseConnection();
                return 0;
            }
        }

        public static int Cambio_Tipo_Usuario(string usuario, int tipo)
        {
            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SP_Cambiar_Tipo_Usuario";
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Usuario", usuario));
            command.Parameters.Add(new SqlParameter("@Tipo", tipo));

            try
            {
                command.ExecuteNonQuery();
                CloseConnection();
                return 1;
            }
            catch
            {
                CloseConnection();
                return 0;
            }
        }

        #endregion

        #region Mantenimiento

        public static int Actualizar_Tipo_Articulo(string Num_Serie, int Num_Recibo, int Cod_Tipo)
        {
            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SP_Actualizar_Tipo_Articulo";
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Num_Serie", Num_Serie));
            command.Parameters.Add(new SqlParameter("@Num_Recibo", Num_Recibo));
            command.Parameters.Add(new SqlParameter("@Cod_Tipo", Cod_Tipo));
            try
            {
                command.ExecuteNonQuery();
                CloseConnection();
                return 1;
            }
            catch
            {
                return 0;
            }
            
        }

        public static void Actualizar_Estado_Articulo(string Num_Serie, int Num_Recibo, int Cod_Estado)
        {
            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SP_Actualizar_Estado_Articulo";
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Num_Serie", Num_Serie));
            command.Parameters.Add(new SqlParameter("@Recibo", Num_Recibo));
            command.Parameters.Add(new SqlParameter("@Estado", Cod_Estado));

            try
            {
                command.ExecuteNonQuery();
                CloseConnection();
            }
            catch
            {
                MessageBoxTemporal.Show("No se encontro el articulo", "Error", 2, false);
            }
            
        }


        #endregion
    }
}
