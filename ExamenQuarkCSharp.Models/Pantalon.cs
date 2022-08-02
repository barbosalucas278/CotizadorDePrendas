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
        public Pantalon() : base()
        {
            Calce = TipoDeCalce.Comun;
        }
        public Pantalon(string detalle, TipoDeCalidad calidad, float precioUnitario, int cantidad, TipoDeCalce calce = TipoDeCalce.Comun)
            : base(detalle, calidad, precioUnitario, cantidad)
        {
            Calce = calce;
        }

        public TipoDeCalce Calce { get; set; }

        public override float CalcularCotizacion()
        {
           
            if (Calidad == TipoDeCalidad.Standard)
                return PrecioUnitario;

            float monto = PrecioUnitario + (PrecioUnitario * 0.3f);
            if (Calce == TipoDeCalce.Chupin)
            {
                float descuento = PrecioUnitario * (float)0.12;
                monto -= descuento;
            }

            return monto;
        }
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine($"{base.ToString()}");
            st.AppendLine($"Tipo de Calce: {Calce}");
            return st.ToString();
        }
    }
}
