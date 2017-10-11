using System.Collections.Generic;

namespace CasaDoCodigo.TDD.Cap3
{
    public class ConversorNumeroRomano
    {
        private readonly Dictionary<char, int> _romanos;

        public ConversorNumeroRomano()
        {
            _romanos = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };
        }

        public int Converte(string numeroRomano)
        {
            var acumulador = 0;
            var ultimoVizinhoDireita = 0;
            for (int i = numeroRomano.Length - 1; i >= 0; i--)
            {
                var multiplicador = 1;
                var atual = _romanos[numeroRomano[i]];

                if (atual < ultimoVizinhoDireita)
                {
                    multiplicador = -1;
                }

                acumulador += atual * multiplicador;
                ultimoVizinhoDireita = atual;
            }

            return acumulador;
        }
    }
}