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
        private float monto;
        public float Monto
        {
            get
            {
                return this.monto;
            }
            set
            {
                if (Prenda.Calidad == TipoDeCalidad.Premium)
                {
                    this.monto = value;
                }
                else
                {
                    throw new CotizacionException("No se puede modificar el monto de una prenda de calidad Standard");
                }
            }
        }
        public Cotizacion()
        {

        }
        public Cotizacion(Prenda prenda)
        {
            Prenda = prenda;
            Fecha = DateTime.Now.Date;
            Hora = DateTime.Now.TimeOfDay;
        }
    }
}
