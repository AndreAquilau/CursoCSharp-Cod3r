using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        /// <summary>
        /// Método static executar o exercicios
        /// </summary>
        public static void Executar()
        {
            // Area da Circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415

            double area = PI * raio * raio;

            Console.WriteLine("Área é " + area);

            // bool True or False
            bool estaChovendo = true;

            Console.WriteLine("Está Chovendo " + estaChovendo);

            // byte 0 a 256
            byte idade = 45;
            Console.WriteLine(idade);

            // sbyte -128 a 127
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols + " a " + sbyte.MaxValue);

            // short -32768 a 32767
            Console.WriteLine("Type Short: "+short.MinValue + " a " + short.MaxValue);

            // int -2b a 2b
            Console.WriteLine("Type Int: " + int.MinValue + " a " + int.MaxValue);

            // uint 0 a 4b
            Console.WriteLine("Type Int: " + uint.MinValue + " a " + uint.MaxValue);

            // long -9....... a 9.........
            Console.WriteLine("Type Int: " + ulong.MinValue + " a " + ulong.MaxValue);

            // long 0 a 18.....
            Console.WriteLine("Type Int: " + ulong.MinValue + " a " + ulong.MaxValue);

            // Ponto flutuante
            // Float 
            float precoComputador = 1299.99f;
            Console.WriteLine("Valor 1299.99 tipo float como float: " + precoComputador);
            Console.WriteLine("Float Min e Max: " + float.MinValue +" a "+ float.MaxValue);

            // Double
            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor de Mercado da Apple :" + valorDeMercadoDaApple);
            Console.WriteLine("Double Min e Max:" + double.MinValue + " a " + double.MinValue);

        }
    }
}
