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

        public Cotizacion Cotizar(Prenda prenda)
        {
            return prenda.CalcularCotizacion();
        }
    }
}
