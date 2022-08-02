using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkCSharp.Models
{
    public class Vendedor
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Vendedor()
        {

        }
        public Vendedor(int codigo, string nombre, string apellido)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
        }

        public Cotizacion Cotizar(Prenda prenda, int cantidadCotizada)
        {
            if (cantidadCotizada > prenda.Cantidad)
                throw new CotizacionException("La cantidad cotizada no puede ser mayor a la cantidad disponible");
            float monto = prenda.CalcularCotizacion() * (float)cantidadCotizada;
            Cotizacion cotizacion = new Cotizacion(prenda, monto, this.Codigo);

            return cotizacion;
        }
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.Append($"{Nombre} {Apellido} | {Codigo}");
            return st.ToString();
        }
    }
}
