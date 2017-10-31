namespace CasaDoCodigo.TDD.Cap5
{
    public class Item
    {
        public Item(string descricao, int quantidade, double valorUnitario)
        {
            Descricao = descricao;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }

        public string Descricao { get; private set; }
        public int Quantidade { get; private set; }
        public double ValorUnitario { get; private set; }

        public double ValorTotal => ValorUnitario * Quantidade;
    }
}