using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Empenos_Anderson
{
    public class Cliente
    {
        public static string Identidad_Cliente, Nombre_Cliente, Apellido_Cliente, Telefono_Cliente, Correo_Cliente;

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
        
    }
}
