namespace CasaDoCodigo.TDD.Cap4
{
    public class Funcionario
    {
        public Funcionario(string nome, double salario, Cargo cargo)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }

        public Cargo Cargo { get; private set; }

        public string Nome { get; private set; }

        public double Salario { get; private set; }
    }
}