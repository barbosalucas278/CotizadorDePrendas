using System;
using System.Runtime.Serialization;

namespace ExamenQuarkCSharp.Models
{
    [Serializable]
    public class CotizacionException : Exception
    {
        public CotizacionException()
        {
        }

        public CotizacionException(string message) : base(message)
        {
        }

        public CotizacionException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}