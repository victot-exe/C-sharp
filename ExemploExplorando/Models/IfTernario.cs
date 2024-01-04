using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class IfTernario
    {
        public string ImparOuPar(int num){
            return num % 2 == 0 ? "Par" : "Impar";
        }
    }
}