using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkCSharp.Models
{
    public enum TipoDeCalce
    {
        Comun,
        Chupin
    }
    public class Pantalon : Prenda
    {
        public Pantalon():base()
        {
            Calce = TipoDeCalce.Comun;
        }
        public Pantalon(string detalle, TipoDeCalidad calidad, float precioUnitario, int cantidad, TipoDeCalce calce)
            : base(detalle, calidad, precioUnitario, cantidad)
        {
            Calce = calce;
        }

        public TipoDeCalce Calce { get; set; }

        public override Cotizacion CalcularCotizacion()
        {
            Cotizacion cotizacion = new Cotizacion(this)
            {
                Monto = PrecioUnitario,
            }; if (Calce == TipoDeCalce.Chupin)
            {
                float descuento = PrecioUnitario * (float)0.12;
                cotizacion.Monto -= descuento;
            }

            return cotizacion;
        }
    }
}
