using System.Collections.Generic;
using System.Linq;

namespace CasaDoCodigo.TDD.Cap5
{
    public class CarrinhoDeCompras
    {
        private readonly IList<Item> _itens;

        public CarrinhoDeCompras()
        {
            _itens = new List<Item>();
        }

        public IEnumerable<Item> Itens => _itens.ToArray();

        public void Adiciona(Item item)
        {
            _itens.Add(item);
        }

        public double MaiorValor()
        {
            if (!Itens.Any())
            {
                return 0;
            }

            var maior = Itens.ElementAt(0).ValorTotal;

            foreach (var item in Itens)
            {
                if (maior < item.ValorTotal)
                {
                    maior = item.ValorTotal;
                }
            }

            return maior;
        }
    }
}