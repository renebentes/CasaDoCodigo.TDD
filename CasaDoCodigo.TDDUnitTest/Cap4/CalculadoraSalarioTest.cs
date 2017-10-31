using CasaDoCodigo.TDD.Cap4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CasaDoCodigo.TDDUnitTest.Cap4
{
    [TestClass]
    [TestCategory("Cap 4 - Calculadora de Salário")]
    public class CalculadoraSalarioTest
    {
        [TestMethod]
        public void DeveCalcularSalarioParaDbasComSalarioAbaixoDoLimite()
        {
            var calculadora = new CalculadoraSalario();
            var desenvolvedor = new Funcionario("Mauricio", 500.0, Cargo.Dba);
            var salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(500.0 * 0.85, salario, 0.00001);
        }

        [TestMethod]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            var calculadora = new CalculadoraSalario();
            var desenvolvedor = new Funcionario("Mauricio", 1500.0, Cargo.Desenvolvedor);
            var salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500.0 * 0.9, salario, 0.00001);
        }

        [TestMethod]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
            var calculadora = new CalculadoraSalario();
            var desenvolvedor = new Funcionario("Mauricio", 4000.0, Cargo.Desenvolvedor);
            var salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(4000.0 * 0.8, salario, 0.00001);
        }
    }
}