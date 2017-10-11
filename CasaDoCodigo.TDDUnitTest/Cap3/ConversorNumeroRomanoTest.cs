using CasaDoCodigo.TDD.Cap3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CasaDoCodigo.TDD.Cap2UnitTest.Cap3
{
    [TestClass]
    public class ConversorNumeroRomanoTest
    {
        [TestCategory("Cap 3 - Conversor de Romano")]
        [TestMethod]
        public void DeveEntenderDoisSimbolosComoII()
        {
            var romano = new ConversorNumeroRomano();
            var numero = romano.Converte("II");
            Assert.AreEqual(2, numero);
        }

        [TestCategory("Cap 3 - Conversor de Romano")]
        [TestMethod]
        public void DeveEntenderQuatroSimbolosComoXXII()
        {
            var romano = new ConversorNumeroRomano();
            var numero = romano.Converte("XXII");
            Assert.AreEqual(22, numero);
        }

        [TestCategory("Cap 3 - Conversor de Romano")]
        [TestMethod]
        public void DeveEntenderSimboloI()
        {
            var romano = new ConversorNumeroRomano();
            var numero = romano.Converte("I");
            Assert.AreEqual(1, numero);
        }

        [TestCategory("Cap 3 - Conversor de Romano")]
        [TestMethod]
        public void DeveEntenderSimbolosComoIX()
        {
            var romano = new ConversorNumeroRomano();
            var numero = romano.Converte("IX");
            Assert.AreEqual(9, numero);
        }

        [TestCategory("Cap 3 - Conversor de Romano")]
        [TestMethod]
        public void DeveEntenderSimbolosComplexosComoXXIV()
        {
            var romano = new ConversorNumeroRomano();
            var numero = romano.Converte("XXIV");
            Assert.AreEqual(24, numero);
        }

        [TestCategory("Cap 3 - Conversor de Romano")]
        [TestMethod]
        public void DeveEntenderSimboloV()
        {
            var romano = new ConversorNumeroRomano();
            var numero = romano.Converte("V");
            Assert.AreEqual(5, numero);
        }
    }
}