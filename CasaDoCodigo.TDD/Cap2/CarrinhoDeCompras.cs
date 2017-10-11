using System.Collections.Generic;
using System.Linq;

namespace CasaDoCodigo.TDD.Cap2
{
    public class CarrinhoDeCompras
    {
        private readonly IList<Produto> _items;

        public CarrinhoDeCompras()
        {
            _items = new List<Produto>();
        }

        public IReadOnlyCollection<Produto> Produtos => _items.ToArray();

        public void Adiciona(Produto produto)
        {
            _items.Add(produto);
        }
    }
}