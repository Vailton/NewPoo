﻿using System;

namespace Exerc._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();

            Console.WriteLine("Dados da primeira Pessoa: ");
            Console.WriteLine("Nome: ");

            p1.Nome = Console.ReadLine();

            Console.WriteLine("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados da Segunda Pessoa: ");
            Console.WriteLine("Nome: ");

            p2.Nome = Console.ReadLine();

            Console.WriteLine("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
                Console.WriteLine("Pessoa mais velha: " + p1);
            else
                Console.WriteLine("Pessoa mais velha: " + p2);



        }
    }
}
