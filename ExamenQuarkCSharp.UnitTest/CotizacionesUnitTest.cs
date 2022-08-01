using ExamenQuarkCSharp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExamenQuarkCSharp.UnitTest
{
    [TestClass]
    public class CotizacionesUnitTest
    {
        [TestMethod]
        public void ShouldBeTenPercentLessFromPriceIfShirtHasShortSleeves()
        {
            //act
            Vendedor vendedor = new Vendedor();
            Prenda camisaMangaCorta = new Camisa()
            {
                Manga = TipoDeManga.Corta,
                Calidad = TipoDeCalidad.Premium,
                PrecioUnitario = 100
            };
            Cotizacion cotizacion = new Cotizacion();
            //arrange
            cotizacion = vendedor.Cotizar(camisaMangaCorta);
            //assert
            Assert.AreEqual(117, cotizacion.Monto);
        }
        [TestMethod]
        public void ShouldBeThreePercentMoreFromPriceIfShirtHasMaoNeck()
        {
            //act
            Vendedor vendedor = new Vendedor();
            Prenda camisaCuelloMao = new Camisa()
            {
                Cuello = TipoDeCuello.Mao,
                Calidad = TipoDeCalidad.Premium,
                PrecioUnitario = 100
            };
            Cotizacion cotizacion = new Cotizacion();
            //arrange
            cotizacion = vendedor.Cotizar(camisaCuelloMao);
            //assert
            Assert.AreEqual(133.9f, cotizacion.Monto);
        }
        [TestMethod]
        public void ShouldBeThreePercentMoreAndTenPercentLessFromPriceIfShirtHasMaoNeckAndShortSleeves()
        {
            //act
            Vendedor vendedor = new Vendedor();
            Prenda camisaCuelloMaoMangasCortas = new Camisa()
            {
                Cuello = TipoDeCuello.Mao,
                Manga = TipoDeManga.Corta,
                Calidad = TipoDeCalidad.Premium,
                PrecioUnitario = 100
            };
            Cotizacion cotizacion = new Cotizacion();
            //arrange
            cotizacion = vendedor.Cotizar(camisaCuelloMaoMangasCortas);
            //assert
            Assert.AreEqual(120.9f, cotizacion.Monto);
        }
        [TestMethod]
        public void ShouldBeTwelvePercentLessFromPriceIfPantsIsChupin()
        {
            //act
            Vendedor vendedor = new Vendedor();
            Prenda pantalonChupin = new Pantalon()
            {
                Calce = TipoDeCalce.Chupin,
                Calidad = TipoDeCalidad.Premium,
                PrecioUnitario = 100
            };
            Cotizacion cotizacion = new Cotizacion();
            //arrange
            cotizacion = vendedor.Cotizar(pantalonChupin);
            //assert
            Assert.AreEqual(114.4f, cotizacion.Monto);
        }
        [TestMethod]
        [ExpectedException(typeof(CotizacionException))]
        public void ThePriceShouldNotBeModifiedIfTheGarmentIsOfAStandardType()
        {
            //act
            Vendedor vendedor = new Vendedor();
            Prenda pantalonChupin = new Pantalon()
            {
                Calce = TipoDeCalce.Chupin,
                PrecioUnitario = 100,
                Calidad = TipoDeCalidad.Standard
            };
            Cotizacion cotizacion = new Cotizacion();
            //arrange
            cotizacion = vendedor.Cotizar(pantalonChupin);
            //assert
        }
        [TestMethod]
        public void ThePriceShouldBIncreasedByThirtyPercentIfTheGarmentIsPremiumType()
        {
            //act
            Vendedor vendedor = new Vendedor();
            Prenda pantalonChupin = new Pantalon()
            {
                PrecioUnitario = 100,
                Calidad = TipoDeCalidad.Premium
            };
            //arrange
            Cotizacion cotizacion = vendedor.Cotizar(pantalonChupin);
            //assert
            Assert.AreEqual(130, cotizacion.Monto);

        }
    }
}
