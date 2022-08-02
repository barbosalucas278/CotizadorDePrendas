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
        public float PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public Prenda()
        {

        }
        public Prenda(string detalle, TipoDeCalidad calidad, int cantidad)
        {
            Detalle = detalle;
            Calidad = calidad;
            Cantidad = cantidad;
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