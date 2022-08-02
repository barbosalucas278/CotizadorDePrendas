using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkCSharp.Models
{
    public enum TipoDeCuello
    {
        Mao,
        Comun
    }
    public enum TipoDeManga
    {
        Corta,
        Larga
    }
    public class Camisa : Prenda
    {
        public TipoDeCuello Cuello { get; set; }
        public TipoDeManga Manga { get; set; }
        public Camisa()
        {
            Cuello = TipoDeCuello.Comun;
            Manga = TipoDeManga.Larga;
        }
        public Camisa(string detalle, TipoDeCalidad calidad, float precioUnitario, int cantidad, TipoDeCuello cuello = TipoDeCuello.Comun,
            TipoDeManga manga = TipoDeManga.Larga) : base(detalle, calidad, precioUnitario, cantidad)
        {
            Cuello = cuello;
            Manga = manga;
        }
        public override float CalcularCotizacion()
        {
            if (Calidad == TipoDeCalidad.Standard)
                return PrecioUnitario;

            float monto = PrecioUnitario + (PrecioUnitario * 0.3f);
            if (Manga == TipoDeManga.Corta)
            {
                float descuento = PrecioUnitario * (float)0.1;
                monto -= descuento;
            }
            if (Cuello == TipoDeCuello.Mao)
            {
                float recargo = PrecioUnitario * (float)0.03;
                monto += recargo;
            }
            return monto;
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine($"{base.ToString()}");
            st.AppendLine($"Tipo de Manga: {Manga}");
            st.AppendLine($"Tipo de Cuello: {Cuello}");
            return st.ToString();
        }
    }
}
