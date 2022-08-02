using ExamenQuarkCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkCSharp.Presenters
{
    public class TiendaPresenter
    {
        private Tienda _tienda;
        private IView _view;
        private Vendedor _empleado;
        public TiendaPresenter()
        {

        }
        public TiendaPresenter(IView view)
        {
            _view = view;
            _tienda = InicializarTienda();
            _empleado = _tienda.Empleados.FirstOrDefault();
            TiendaViewModel tiendaVM = new TiendaViewModel()
            {
                Nombre = _tienda.Nombre,
                Direccion = _tienda.Direccion.ToString(),
                Vendedor = _tienda.Empleados.FirstOrDefault().ToString()
            };
            _view.InicializarControles(tiendaVM);
        }

        private Tienda InicializarTienda()
        {
            List<Vendedor> empleados = new List<Vendedor>();
            Vendedor newVendedor = new Vendedor(109, "Lucas", "Barbosa");
            empleados.Add(newVendedor);
            List<Prenda> prendas = new List<Prenda>();
            prendas.Add(new Camisa("Camisa Manga Corta, standard, cuello mao", TipoDeCalidad.Standard, 100, TipoDeCuello.Mao, TipoDeManga.Corta));
            prendas.Add(new Camisa("Camisa Manga Corta, premium, cuello mao", TipoDeCalidad.Premium, 100, TipoDeCuello.Mao, TipoDeManga.Corta));
            prendas.Add(new Camisa("Camisa Manga Corta, premium, cuello comun", TipoDeCalidad.Premium, 150, TipoDeCuello.Comun, TipoDeManga.Corta));
            prendas.Add(new Camisa("Camisa Manga Corta, standard, cuello comun", TipoDeCalidad.Standard, 150, TipoDeCuello.Comun, TipoDeManga.Corta));
            prendas.Add(new Camisa("Camisa Manga Larga, standard, cuello mao", TipoDeCalidad.Standard, 75, TipoDeCuello.Mao));
            prendas.Add(new Camisa("Camisa Manga Larga, premium, cuello mao", TipoDeCalidad.Premium, 75, TipoDeCuello.Mao));
            prendas.Add(new Camisa("Camisa Manga Larga, premium, cuello comun", TipoDeCalidad.Premium, 175));
            prendas.Add(new Camisa("Camisa Manga Larga, standard, cuello comun", TipoDeCalidad.Standard, 175));
            prendas.Add(new Pantalon("Pantalon Chupín, standard", TipoDeCalidad.Standard, 750, TipoDeCalce.Chupin));
            prendas.Add(new Pantalon("Pantalon Chupín, premium", TipoDeCalidad.Premium, 750, TipoDeCalce.Chupin));
            prendas.Add(new Pantalon("Pantalon Común, standard", TipoDeCalidad.Standard, 250));
            prendas.Add(new Pantalon("Pantalon Común, premium", TipoDeCalidad.Premium, 250));

            Tienda newTienda = new Tienda("Lunabe", "Rio Turbio", 1685, "Buenos Aires", empleados, prendas);
            return newTienda;
        }


        public void MostrarPantalonesStandard()
        {
            Prenda pantalonesStandard = GetPantalonesStandard();
            _view.ActualizarFormulario(MapPrendaToPrendaViewModel(pantalonesStandard));
        }
        private Prenda GetPantalonesStandard()
        {
            Prenda pantalonesStandard = new Pantalon();
            foreach (Prenda item in _tienda.Stock)
            {
                if (item is Pantalon pantalon)
                {
                    if (pantalon.Calidad == TipoDeCalidad.Standard && pantalon.Calce == TipoDeCalce.Comun)
                    {
                        pantalonesStandard = item;
                        break;
                    }
                    else if (_view.IsChupin() && pantalon.Calce == TipoDeCalce.Chupin)
                    {
                        pantalonesStandard = item;
                        break;
                    }
                }
            }
            return pantalonesStandard;
        }
        public void MostrarPantalonesPremium()
        {
            Prenda pantalonesPremium = GetPantalonesPremium();
            _view.ActualizarFormulario(MapPrendaToPrendaViewModel(pantalonesPremium));
        }
        private Prenda GetPantalonesPremium()
        {
            Prenda pantalonesPremium = new Pantalon();
            foreach (Prenda item in _tienda.Stock)
            {
                if (item is Pantalon pantalon && pantalon.Calidad == TipoDeCalidad.Premium)
                {
                    if (pantalon.Calce == TipoDeCalce.Comun)
                    {
                        pantalonesPremium = item;
                        break;
                    }
                    else if (_view.IsChupin() && pantalon.Calce == TipoDeCalce.Chupin)
                    {
                        pantalonesPremium = item;
                        break;
                    }
                }
            }
            return pantalonesPremium;
        }
        public void MostrarCamisasStandard()
        {
            Prenda camisasStandard = GetCamisasStandard();
            _view.ActualizarFormulario(MapPrendaToPrendaViewModel(camisasStandard));
        }
        private Prenda GetCamisasStandard()
        {
            Prenda camisasStandard = new Camisa();
            foreach (Prenda item in _tienda.Stock)
            {
                if (item is Camisa camisa)
                {
                    if (_view.IsMangaCorta() && camisa.Manga == TipoDeManga.Corta &&
                        _view.IsCuelloMao() && camisa.Cuello == TipoDeCuello.Mao)
                    {
                        camisasStandard = item;
                        break;
                    }
                    else if (_view.IsCuelloMao() && camisa.Cuello == TipoDeCuello.Mao
                        && camisa.Manga != TipoDeManga.Corta)
                    {
                        camisasStandard = item;
                        break;
                    }
                    else if (_view.IsMangaCorta() && camisa.Manga == TipoDeManga.Corta
                        && camisa.Cuello != TipoDeCuello.Mao)
                    {
                        camisasStandard = item;
                        break;
                    }
                    else if (camisa.Calidad == TipoDeCalidad.Standard && camisa.Manga == TipoDeManga.Larga && camisa.Cuello == TipoDeCuello.Comun)
                    {
                        camisasStandard = item;
                        break;
                    }
                }
            }
            return camisasStandard;
        }
        public void MostrarCamisasPremium()
        {
            Prenda camisasPremium = GetCamisasPremium();
            _view.ActualizarFormulario(MapPrendaToPrendaViewModel(camisasPremium));
        }
        private Prenda GetCamisasPremium()
        {
            Prenda camisasPremium = new Camisa();
            foreach (Prenda item in _tienda.Stock)
            {
                if (item is Camisa camisa && camisa.Calidad == TipoDeCalidad.Premium)
                {
                    if (_view.IsMangaCorta() && camisa.Manga == TipoDeManga.Corta &&
                        _view.IsCuelloMao() && camisa.Cuello == TipoDeCuello.Mao)
                    {
                        camisasPremium = item;
                        break;
                    }
                    else if (_view.IsCuelloMao() && camisa.Cuello == TipoDeCuello.Mao
                        && camisa.Manga != TipoDeManga.Corta)
                    {
                        camisasPremium = item;
                        break;
                    }
                    else if (_view.IsMangaCorta() && camisa.Manga == TipoDeManga.Corta
                        && camisa.Cuello != TipoDeCuello.Mao)
                    {
                        camisasPremium = item;
                        break;
                    }
                    else if (camisa.Manga == TipoDeManga.Larga && camisa.Cuello == TipoDeCuello.Comun)
                    {
                        camisasPremium = item;
                        break;
                    }
                }
            }
            return camisasPremium;
        }
        public void RealizarCotizacion()
        {
            try
            {
                FormDataViewModel formDataVM = _view.GetFormData();
                Prenda prendaCotizada = ProcesarFormData(formDataVM);
                Cotizacion cotizacion = _empleado.Cotizar(prendaCotizada, formDataVM.CantidadCotizada);
                _empleado.GuardarCotizacion(cotizacion);
                _view.ActualizarLabelMontoCotizado(cotizacion.Monto.ToString());
            }
            catch (Exception ex)
            {
                _view.MostrarError(ex.Message);
            }
        }

        private Prenda ProcesarFormData(FormDataViewModel formDataVM)
        {
            Prenda prendaFormData = null;
            if (formDataVM.IsCamisa)
            {
                if (formDataVM.IsStandard)
                {
                    prendaFormData =  GetCamisasStandard();
                }
                else
                {
                    prendaFormData =  GetCamisasPremium();
                }
            }
            else
            {
                if (formDataVM.IsStandard)
                {
                    prendaFormData =  GetPantalonesStandard();
                }
                else
                {
                    prendaFormData =  GetPantalonesPremium();
                }
            }
            prendaFormData.PrecioUnitario = formDataVM.PrecioCotizado;
            return prendaFormData;
        }
        private PrendaViewModel MapPrendaToPrendaViewModel(Prenda prenda)
        {
            return new PrendaViewModel() { PrecioUnitario = prenda.PrecioUnitario.ToString(), StockDisponible = prenda.Cantidad.ToString() };
        }
        public void ListarCotizaciones()
        {
            _view.ActualizarFormHistorial(_empleado.MostrarHistorialDeCotizaciones());
        }
    }
}
