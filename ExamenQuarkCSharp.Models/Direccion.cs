using System.Text;

namespace ExamenQuarkCSharp.Models
{
    public class Direccion
    {
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Provincia { get; set; }
        public Direccion(string calle, int numero, string provincia)
        {
            Calle = calle;
            Numero = numero;
            Provincia = provincia;
        }
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.Append($"{Calle} {Numero}, {Provincia}");
            return st.ToString();
        }
    }
}