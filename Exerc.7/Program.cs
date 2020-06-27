﻿using System;
using System.Globalization;

namespace Exerc._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados da primeira Funcionario: ");
            Console.WriteLine("Nome: ");

            f1.Nome = Console.ReadLine();

            Console.WriteLine("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Dados da Segunda Funcionario: ");
            Console.WriteLine("Nome: ");

            f2.Nome = Console.ReadLine();

            Console.WriteLine("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
