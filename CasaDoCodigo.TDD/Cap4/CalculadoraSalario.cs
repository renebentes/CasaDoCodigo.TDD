namespace CasaDoCodigo.TDD.Cap4
{
    public class CalculadoraSalario
    {
        public double CalculaSalario(Funcionario funcionario)
        {
            if (funcionario.Cargo == Cargo.Desenvolvedor)
            {
                if (funcionario.Salario > 3000)
                {
                    return funcionario.Salario * 0.8;
                }
                return funcionario.Salario * 0.9;
            }

            return funcionario.Salario * 0.85;
        }
    }
}