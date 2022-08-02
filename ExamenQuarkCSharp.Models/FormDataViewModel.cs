using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkCSharp.Models
{
    public class FormDataViewModel
    {
        public bool IsCamisa { get; set; }
        public bool IsMangaCorta { get; set; }
        public bool IsCuelloMao { get; set; }
        public bool IsChupin { get; set; }
        public bool IsStandard { get; set; }
        public int StockDisponible { get; set; }
        public int CantidadCotizada { get; set; }
    }
}
