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
            Prenda camisaMangaCorta = new Camisa()
            {
                Manga = TipoDeManga.Corta,
                Calidad = TipoDeCalidad.Premium,
                PrecioUnitario = 100,
                Cantidad = 2
            };
            //arrange
            float precio = camisaMangaCorta.CalcularCotizacion();
            //assert
            Assert.AreEqual(117, precio);
        }
        [TestMethod]
        public void ShouldBeThreePercentMoreFromPriceIfShirtHasMaoNeck()
        {
            //act
            Prenda camisaCuelloMao = new Camisa()
            {
                Cuello = TipoDeCuello.Mao,
                Calidad = TipoDeCalidad.Premium,
                PrecioUnitario = 100,
                Cantidad = 2
            };
            //arrange
            float precio = camisaCuelloMao.CalcularCotizacion();
            //assert
            Assert.AreEqual(133.9f, precio);
        }
        [TestMethod]
        public void ShouldBeThreePercentMoreAndTenPercentLessFromPriceIfShirtHasMaoNeckAndShortSleeves()
        {
            //act
            Prenda camisaCuelloMaoMangasCortas = new Camisa()
            {
                Cuello = TipoDeCuello.Mao,
                Manga = TipoDeManga.Corta,
                Calidad = TipoDeCalidad.Premium,
                PrecioUnitario = 100,
                Cantidad = 2
            };
            //arrange
            float precio = camisaCuelloMaoMangasCortas.CalcularCotizacion();
            //assert
            Assert.AreEqual(120.9f, precio);
        }
        [TestMethod]
        public void ShouldBeTwelvePercentLessFromPriceIfPantsIsChupin()
        {
            //act
            Prenda pantalonChupin = new Pantalon()
            {
                Calce = TipoDeCalce.Chupin,
                Calidad = TipoDeCalidad.Premium,
                PrecioUnitario = 100,
                Cantidad = 2
            };
            //arrange
            float precio = pantalonChupin.CalcularCotizacion();
            //assert
            Assert.AreEqual(114.4f, precio);
        }
        [TestMethod]
        public void ThePriceShouldNotBeModifiedIfTheGarmentIsOfAStandardType()
        {
            //act
            Prenda pantalonChupin = new Pantalon()
            {
                Calce = TipoDeCalce.Chupin,
                PrecioUnitario = 100,
                Calidad = TipoDeCalidad.Standard,
                Cantidad = 2
            };
            //arrange
            float precio = pantalonChupin.CalcularCotizacion();
            //assert
            Assert.AreEqual(pantalonChupin.PrecioUnitario, precio);
        }
        [TestMethod]
        public void ThePriceShouldBIncreasedByThirtyPercentIfTheGarmentIsPremiumType()
        {
            //act
            Prenda pantalonChupin = new Pantalon()
            {
                PrecioUnitario = 100,
                Calidad = TipoDeCalidad.Premium,
                Cantidad = 2
            };
            //arrange
            float precio = pantalonChupin.CalcularCotizacion();
            //assert
            Assert.AreEqual(130, precio);

        }
        [TestMethod]
        [ExpectedException(typeof(CotizacionException))]
        public void TheQuotedQuantityMutsBeLessThanOrEqualToTheAvailableQuantity()
        {
            //act
            Vendedor vendedor = new Vendedor();
            Prenda pantalonChupin = new Pantalon()
            {
                PrecioUnitario = 100,
                Calidad = TipoDeCalidad.Premium,
                Cantidad = 10
            };
            //arrange
            Cotizacion cotizacion = vendedor.Cotizar(pantalonChupin, 11);
            //assert
        }
    }
}
