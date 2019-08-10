using System;
using System.Collections;

namespace Sistema_Empenos_Anderson
{
    public class Objetos_Globales
    {
        public static Usuario usuario;
        public static Cliente cliente;
        public static Articulo articulo;
        public static string identidadTemporal;
        public static ArrayList articulos;

        public static DateTime fecha = DateTime.Now;

        public static string fechaHoyCorta()
        {
            return fecha.Day + "/" + fecha.Month + "/" + fecha.Year;
        }

        public static string fechaHoy()
        {
            return fecha.Day + "/" + fecha.Month + "/" + fecha.Year + " " + fecha.Hour + ":"
                + fecha.Minute + ":" + fecha.Second + "." + fecha.Millisecond;
        }
    }
}
