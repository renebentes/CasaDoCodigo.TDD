using CasaDoCodigo.TDD.Cap3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CasaDoCodigo.TDD.Cap2UnitTest.Cap3
{
    [TestClass]
    [TestCategory("Cap 3 - Conversor de Romano")]
    public class ConversorNumeroRomanoTest
    {
        [TestMethod]
        public void DeveEntenderDoisSimbolosComoII()
        {
            var romano = new ConversorNumeroRomano();
            var numero = romano.Converte("II");
            Assert.AreEqual(2, numero);
        }

        [TestMethod]
        public void DeveEntenderQuatroSimbolosComoXXII()
        {
            var romano = new ConversorNumeroRomano();
            var numero = romano.Converte("XXII");
            Assert.AreEqual(22, numero);
        }

        [TestMethod]
        public void DeveEntenderSimboloI()
        {
            var romano = new ConversorNumeroRomano();
            var numero = romano.Converte("I");
            Assert.AreEqual(1, numero);
        }

        [TestMethod]
        public void DeveEntenderSimbolosComoIX()
        {
            var romano = new ConversorNumeroRomano();
            var numero = romano.Converte("IX");
            Assert.AreEqual(9, numero);
        }

        [TestMethod]
        public void DeveEntenderSimbolosComplexosComoXXIV()
        {
            var romano = new ConversorNumeroRomano();
            var numero = romano.Converte("XXIV");
            Assert.AreEqual(24, numero);
        }

        [TestMethod]
        public void DeveEntenderSimboloV()
        {
            var romano = new ConversorNumeroRomano();
            var numero = romano.Converte("V");
            Assert.AreEqual(5, numero);
        }
    }
}