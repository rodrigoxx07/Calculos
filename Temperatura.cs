using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculos.Aritmetica;

namespace Calculos
{
    /// <summary>
    /// Classe que implementa operações de conversão
    /// 
    /// </summary>
    internal static class Temperatura
    {
        public static enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
        /// <summary>
        /// tipo de conversão de distâncias
        /// </summary>
        public enum ConversaoDistancias
        {
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros
        }
        /// <summary>
        /// Conversão de temperaturas
        /// </summary>
        /// <param name="conversao"> A conversão a efetuar</param>
        /// <param name="temperatura">A temperatura a converter</param>
        /// <returns>Resultado da conversão</returns>
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.800 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.800);
            }
            return -1;
        }/// <summary>
        /// Conversao de distâncias
        /// </summary>
        /// <param name="conversao"></param>
        /// <param name="distancia"></param>
        /// <returns></returns>
        public static double ConverterDistancias(ConversaoDistancia conversao, double distancia)
        {
            if (conversao == ConversaoDistancias.MetrosMilhas)
            {
                return distancia * 0.0006213712;

            }
            else if (conversao == ConversaoDistancias.MilhasMetros)
            {
                return distancia * 1609.344;
            }
            return - 1;
        }
    }
}
