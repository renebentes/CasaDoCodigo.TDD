using CasaDoCodigo.TDD.Cap2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CasaDoCodigo.TDDUnitTest.Cap2
{
    [TestClass]
    public class TestaMaiorMenor
    {
        [TestCategory("Cap 2 - Maior e Menor")]
        [TestMethod]
        public void OrdemCrescente()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Jogo de Pratos", 70));
            carrinho.Adiciona(new Produto("Liquidificador", 250));
            carrinho.Adiciona(new Produto("Geladeira", 450));

            var algoritmo = new MaiorMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Jogo de Pratos", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }

        [TestCategory("Cap 2 - Maior e Menor")]
        [TestMethod]
        public void OrdemDecrescente()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Geladeira", 450));
            carrinho.Adiciona(new Produto("Liquidificador", 250));
            carrinho.Adiciona(new Produto("Jogo de Pratos", 70));

            var algoritmo = new MaiorMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Jogo de Pratos", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }

        [TestCategory("Cap 2 - Maior e Menor")]
        [TestMethod]
        public void OrdemVariada()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Liquidificador", 250));
            carrinho.Adiciona(new Produto("Geladeira", 450));
            carrinho.Adiciona(new Produto("Jogo de Pratos", 70));

            var algoritmo = new MaiorMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Jogo de Pratos", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }

        [TestCategory("Cap 2 - Maior e Menor")]
        [TestMethod]
        public void UmProduto()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Liquidificador", 250));

            var algoritmo = new MaiorMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Liquidificador", algoritmo.Menor.Nome);
            Assert.AreEqual("Liquidificador", algoritmo.Maior.Nome);
        }
    }
}