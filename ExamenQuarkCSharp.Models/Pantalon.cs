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
        public TipoDeCalce Calce { get; set; }
        public Pantalon() : base()
        {
            Calce = TipoDeCalce.Comun;
        }
        public Pantalon(string detalle, TipoDeCalidad calidad, int cantidad, TipoDeCalce calce = TipoDeCalce.Comun)
            : base(detalle, calidad, cantidad)
        {
            Calce = calce;
        }


        public override float CalcularCotizacion()
        {
            float monto = PrecioUnitario;
            if (Calce == TipoDeCalce.Chupin)
            {
                float descuento = monto * (float)0.12;
                monto -= descuento;
            }

            if (Calidad == TipoDeCalidad.Standard)
                return monto;
            else
                return monto + (monto * (float)0.3);
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
