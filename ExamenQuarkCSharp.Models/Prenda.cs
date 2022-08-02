using System.Text;

namespace ExamenQuarkCSharp.Models
{
    public enum TipoDeCalidad
    {
        Standard,
        Premium
    }
    public abstract class Prenda
    {
        public int Id { get; set; }
        public string Detalle { get; set; }
        public TipoDeCalidad Calidad { get; set; }
        private float precioUnitario;
        public int Cantidad { get; set; }
        public Prenda()
        {

        }
        public Prenda(string detalle, TipoDeCalidad calidad, float precioUnitario, int cantidad)
        {
            Detalle = detalle;
            Calidad = calidad;
            PrecioUnitario = precioUnitario;
            Cantidad = cantidad;
        }
        public float PrecioUnitario
        {
            get
            {
                float aumento = this.precioUnitario * (float)0.3;
                if (Calidad == TipoDeCalidad.Premium)
                    return this.precioUnitario + aumento;
                else
                    return this.precioUnitario;
            }
            set
            {
                this.precioUnitario = value;
            }
        }
        public abstract float CalcularCotizacion();
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine($"Detalle: {Detalle}");
            st.AppendLine($"Calidad: {Calidad}");
            return st.ToString();
        }
    }
}