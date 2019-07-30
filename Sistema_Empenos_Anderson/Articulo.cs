namespace Sistema_Empenos_Anderson
{
    public class Articulo
    {
        private int meses, codigoTipo, numeroRecibo;
        private double montoPago;
        private float prestado, interes;
        private string descripcion, marca, modelo, estado, numeroSerie, tipo;

        public Articulo()
        {
        }

        public Articulo(int meses, float prestado, float interes, string descripcion, string marca, string modelo, string estado, string numeroSerie, string tipo, int codigoTipo, int numeroRecibo)
        {
            this.meses = meses;
            this.prestado = prestado;
            this.interes = interes;
            this.descripcion = descripcion;
            this.marca = marca;
            this.modelo = modelo;
            this.estado = estado;
            this.numeroSerie = numeroSerie;
            this.tipo = tipo;
            this.codigoTipo = codigoTipo;
            this.numeroRecibo = numeroRecibo;
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { this.descripcion = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { this.marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { this.modelo = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { this.estado = value; }
        }

        public float Prestado
        {
            get { return prestado; }
            set { this.prestado = value; }
        }

        public int Meses
        {
            get { return meses; }
            set { this.meses = value; }
        }

        public float Interes
        {
            get { return interes; }
            set { this.interes = value; }
        }

        public string NumeroSerie
        {
            get { return numeroSerie; }
            set { this.numeroSerie = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { this.tipo = value; }
        }

        public int CodigoTipo
        {
            get { return codigoTipo; }
            set { this.codigoTipo = value; }
        }

        public int NumeroRecibo
        {
            get { return numeroRecibo; }
            set { this.numeroRecibo = value; }
        }

        public double MontoPago
        {
            get { return montoPago; }
            set { this.montoPago = value; }
        }

        public double PrecioPago(int cantidadMeses)
        {
            return prestado + (cantidadMeses * interes * prestado);
        }
    }
}
