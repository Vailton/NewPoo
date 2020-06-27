using System;
using System.Globalization;

namespace Exerc._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double senha = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (senha != 2012)
            {
                Console.WriteLine("A sua senha está inválida! Tenta de novo:");
                senha = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Pronto sua senha está correta");
        }
    }
}
