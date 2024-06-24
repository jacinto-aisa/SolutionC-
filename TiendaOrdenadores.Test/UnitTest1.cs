using TiendaOrdenadores.Comportamientos;

namespace TiendaOrdenadores.Test
{
    [TestClass]
    public class UnitTestComportamientos
    {
        [TestMethod]
        public void TestMethodConDescripcion()
        {
            IDescripcion descripcion = new ConDescripcion("ejemplo");
            Assert.IsNotNull(descripcion);
            Assert.AreEqual("ejemplo",descripcion.Descripcion);
        }
        [TestMethod]
        public void TestMethodSinDescripcion()
        {
            IDescripcion descripcion = new SinDescripcion();
            Assert.IsNotNull(descripcion);
            Assert.AreEqual("", descripcion.Descripcion);
        }
        [TestMethod]
        public void TestMethodConSerie()
        {
            ISerie serie = new ConSerie("ejemplo");
            Assert.IsNotNull(serie);
            Assert.AreEqual("ejemplo", serie.NumeroSerie);
        }
        [TestMethod]
        public void TestMethodSinSerie()
        {
            ISerie serie = new SinSerie();
            Assert.IsNotNull(serie);
            Assert.AreEqual("", serie.NumeroSerie);
        }
        [TestMethod]
        public void TestMethodConCalor()
        {
            ISerie serie = new ConSerie("ejemplo");
            Assert.IsNotNull(serie);
            Assert.AreEqual("ejemplo", serie.NumeroSerie);
        }
        [TestMethod]
        public void TestMethodSinCalor()
        {
            ISerie serie = new SinSerie();
            Assert.IsNotNull(serie);
            Assert.AreEqual("", serie.NumeroSerie);
        }
    }
}