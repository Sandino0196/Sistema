namespace Sistema_Empenos_Anderson
{
    public class Recibo_Informe
    {
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public string Fecha_Entrada { get; set; }
        public string Numero_Serie { get; set; }
        public double Prestado { get; set; }
        public double ISV { get; set; }
        public double Total { get; set; }

        public Recibo_Informe()
        {}

        public Recibo_Informe(Recibo_Informe recibo)
        {
            Nombre = recibo.Nombre;
            Modelo = recibo.Modelo;
            Marca = recibo.Marca;
            Descripcion = recibo.Descripcion;
            Fecha_Entrada = recibo.Fecha_Entrada;
            Numero_Serie = recibo.Numero_Serie;
            Prestado = recibo.Prestado;
            ISV = recibo.ISV;
            Total = recibo.Total;
        }
    }
}

