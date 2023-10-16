using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritmeticas
    /// Operação soma e subtração de dois nrs
    /// </summary>
    internal class Aritmetica
    {
        /// <summary>
        /// Tipo de Conversão de Teperatura
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
        public int Somar(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// operação de subtração d edois numeros retorna o seu resultado
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }

        public double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.800 + 32);
            }
            else if (conversao ==ConversaoTemperatura.FahrenheitCelsius)
            {
                return((temperatura - 32) / 1.800);
            }
            return -1;
        }

    }
}
