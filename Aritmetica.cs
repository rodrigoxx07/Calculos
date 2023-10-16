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
    }
}
