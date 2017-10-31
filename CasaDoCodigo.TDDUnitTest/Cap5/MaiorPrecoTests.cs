using CasaDoCodigo.TDD.Cap5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CasaDoCodigo.TDDUnitTest.Cap5
{
    [TestClass]
    [TestCategory("Cap 5 - Maior Preço")]
    public class MaiorPrecoTests
    {
        [TestMethod]
        public void DeveRetornarMaiorValorDoSeCarrinhoComMuitosElementos()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));
            carrinho.Adiciona(new Item("Fogão", 1, 1500.0));
            carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0));

            Assert.AreEqual(1500.0, carrinho.MaiorValor(), 0.0001);
        }

        [TestMethod]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));

            Assert.AreEqual(900.0, carrinho.MaiorValor(), 0.0001);
        }

        [TestMethod]
        public void DeveRetornarZeroSeCarrinhoVazio()
        {
            var carrinho = new CarrinhoDeCompras();

            Assert.AreEqual(0.0, carrinho.MaiorValor(), 0.0001);
        }
    }
}