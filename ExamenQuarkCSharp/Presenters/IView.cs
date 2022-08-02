using ExamenQuarkCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkCSharp.Presenters
{
    public interface IView
    {
        void InicializarControles(TiendaViewModel tienda);
        void ActualizarFormulario(PrendaViewModel prenda);
        bool IsMangaCorta();
        bool IsCuelloMao();
        bool IsChupin();
        FormDataViewModel GetFormData();
        void MostrarError(string mensaje);
        void ActualizarLabelMontoCotizado(string montoCotizado);
        void ActualizarFormHistorial(string historial);
    }
}
