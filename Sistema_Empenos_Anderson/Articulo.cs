using System.Collections;

namespace Sistema_Empenos_Anderson
{
    public class Articulo
    {
        public static ArrayList Numeros_Serie = new ArrayList(); 
        public static double precioPago, prestado, interes;
        public static string descripcion, marca, modelo, estado;

        public static void Ingresar_Numero(string Num)
        {
            Numeros_Serie.Add(Num);
        }

    }
}
