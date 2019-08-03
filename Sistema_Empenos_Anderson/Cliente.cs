namespace Sistema_Empenos_Anderson
{
    public class Cliente
    {
        private string Identidad_Cliente, Nombre_Cliente, Apellido_Cliente, Telefono_Cliente, Correo_Cliente;
        private int Estado;

        public Cliente()
        {
        }

        public Cliente(string identidad_Cliente, string nombre_Cliente, string apellido_Cliente, string telefono_Cliente, string correo_Cliente)
        {
            Identidad_Cliente = identidad_Cliente;
            Nombre_Cliente = nombre_Cliente;
            Apellido_Cliente = apellido_Cliente;
            Telefono_Cliente = telefono_Cliente;
            Correo_Cliente = correo_Cliente;
        }

        public int estado
        {
            get { return this.Estado; }
            set { this.Estado = value; }
        }

        public string identidad_Cliente
        {
            get { return this.Identidad_Cliente; }
            set { this.Identidad_Cliente = value; }
        }

        public string nombre_Cliente
        {
            get { return this.Nombre_Cliente; }
            set { this.Nombre_Cliente = value; }
        }

        public string apellido_Cliente
        {
            get { return this.Apellido_Cliente; }
            set { this.Apellido_Cliente = value; }
        }

        public string telefono_Cliente
        {
            get { return this.Telefono_Cliente; }
            set { this.Telefono_Cliente = value; }
        }

        public string correo_Cliente
        {
            get { return this.Correo_Cliente; }
            set { this.Correo_Cliente = value; }
        }
    }
}
