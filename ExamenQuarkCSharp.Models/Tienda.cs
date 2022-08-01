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
    }
}
