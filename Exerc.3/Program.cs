using System;
using System.Globalization;

namespace Exerc._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, horas;

            double valorHora, salario;

            Console.WriteLine("Digite o seu Id funcional: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas trabalhou no mês: ");
            horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor horas: ");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine("NUMBER= " + id);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
