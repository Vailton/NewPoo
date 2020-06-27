using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc._6
{
    class Pessoas
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public override string ToString()
        {
            return Nome + "  " + Idade;
        }
    }
}
