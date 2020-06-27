using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NewPoo1
{
    class Class1
    {
        static void Main(string[] args)
        {
            double Raio, Area, pi = 3.14159;

            Console.WriteLine("Digite o valor do Raio");

            Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = pi * Raio * Raio;

            Console.WriteLine("A=" + Area.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }   

    }
}
