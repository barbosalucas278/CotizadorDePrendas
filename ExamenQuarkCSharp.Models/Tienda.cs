using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkCSharp.Models
{
    public class Tienda
    {
        public string Nombre { get; set; }
        public Direccion Direccion { get; set; }
        public List<Prenda> Stock { get; set; }
        public List<Vendedor> Empleados { get; set; }
        public List<Cotizacion> HistorialDeCotizaciones { get; set; }
        public Tienda(string nombre, string calle, int numero, string provincia, List<Vendedor> empleados, List<Prenda> stock)
        {
            Nombre = nombre;
            Direccion = new Direccion(calle, numero, provincia);
            Stock = stock;
            Empleados = empleados;
            HistorialDeCotizaciones = new List<Cotizacion>();
        }
        public void GuardarCotizacion(Cotizacion cotizacion)
        {
            HistorialDeCotizaciones.Add(cotizacion);
        }
        public string MostrarHistorialDeCotizaciones()
        {
            StringBuilder st = new StringBuilder();
            foreach (var cotizacion in HistorialDeCotizaciones)
            {
                st.AppendLine(cotizacion.ToString());
                st.AppendLine($"-------------------------------------------");
            }
            return st.ToString();
        }
    }
}
