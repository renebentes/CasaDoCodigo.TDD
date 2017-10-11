namespace CasaDoCodigo.TDD.Cap2
{
    public class Produto
    {
        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Valor = preco;
        }

        public string Nome { get; private set; }

        public decimal Valor { get; private set; }
    }
}