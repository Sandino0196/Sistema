using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Empenos_Anderson
{
    public class Usuario
    {
        private string Nombre_Usuario, Password_Usuario;
        private int Codigo_Tipo_Usuario;

        public Usuario()
        {
        }

        public Usuario(string nombre_Usuario, string password_Usuario, int codigo_Tipo_Usuario)
        {
            Nombre_Usuario = nombre_Usuario;
            Password_Usuario = password_Usuario;
            Codigo_Tipo_Usuario = codigo_Tipo_Usuario;
        }

        public string nombre_Usuario
        {
            get { return Nombre_Usuario; }
            set { this.Nombre_Usuario = value; }
        }

        public string password_Usuario
        {
            get { return Password_Usuario; }
            set { this.Password_Usuario = value; }
        }

        public int codigo_Tipo_Usuario
        {
            get { return Codigo_Tipo_Usuario; }
            set { this.Codigo_Tipo_Usuario = value; }
        }
    }
}
