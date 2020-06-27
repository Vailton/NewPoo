using System;

namespace NewPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Valor1, Valor2, Soma;

            Console.WriteLine("Digite o primeiro valores:");
            Valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            Valor2 = int.Parse(Console.ReadLine());

            Soma = Valor1 + Valor2;

            Console.WriteLine("O resultado da soma é: " + Soma);

            Console.ReadLine();

        }
    }
}
