namespace Sistema_Empenos_Anderson
{
    public class Articulo
    {
        private int meses;
        private double precioPago, prestado, interes;
        private string descripcion, marca, modelo, estado, numeroSerie, tipo;

        public Articulo()
        {
        }

        public Articulo(int meses, double precioPago, double prestado, double interes, string descripcion, string marca, string modelo, string estado, string numeroSerie, string tipo)
        {
            this.meses = meses;
            this.precioPago = precioPago;
            this.prestado = prestado;
            this.interes = interes;
            this.descripcion = descripcion;
            this.marca = marca;
            this.modelo = modelo;
            this.estado = estado;
            this.numeroSerie = numeroSerie;
            this.tipo = tipo;
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

        public double PrecioPago
        {
            get { return precioPago; }
            set { this.precioPago = value; }
        }

        public double Prestado
        {
            get { return prestado; }
            set { this.prestado = value; }
        }

        public int Meses
        {
            get { return meses; }
            set { this.meses = value; }
        }

        public double Interes
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
    }
}
