using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImplementacao
    {
        public int Somar (int a, int b)
        {
            return a + b;
        }

        public bool isPar(int num)
        {
            return num % 2 == 0;
        }
    }
}