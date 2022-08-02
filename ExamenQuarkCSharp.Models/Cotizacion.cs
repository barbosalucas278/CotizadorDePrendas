using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkCSharp.Models
{
    public class Cotizacion
    {
        public int Id { get; set; }
        public int CodigoVendedor { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public Prenda Prenda { get; set; }
        public float Monto { get; set; }
        public Cotizacion()
        {

        }
        public Cotizacion(Prenda prenda, float monto, int codigoVendedor)
        {
            Prenda = prenda;
            Fecha = DateTime.Now.Date;
            Hora = DateTime.Now.TimeOfDay;
            Monto = monto;
            CodigoVendedor = codigoVendedor;
        }
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine($"Vendedor: {CodigoVendedor} Fecha: {Fecha} {Hora}");
            st.AppendLine($"Prenda");
            st.AppendLine($"{Prenda}");
            st.AppendLine($"Monto: {Monto}");
            return st.ToString();
        }
    }
}
