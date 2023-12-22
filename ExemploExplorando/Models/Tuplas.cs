using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models{
    public class Tuplas{//Tupla é semelhante as colections com a diferença que ela pode agrupar tipos de dados diferentes em uma única variável.
        //declarando a tupla
        (int Id, string Nome, string Sobrenome, decimal Altura) tupla;
        ValueTuple<int, string, string, decimal> tupla2;

        public Tuplas(){
            tupla = (1, "Victor", "Faria", 1.80M);
            LendoTupla(tupla);

            tupla2 = (2, "Ícaro", "Faria Sousa", 1.85M);
            LendoTupla(tupla2);

            //var OutroExemplo = Tuple.Create(3, "Linda", "Souza", 1.65M);//=> Outro método de criar as tuplas
            //Descarte=> para descartar informações que não utilizamos, no local que receberá o retorno colocamos um _ no local que irá receber a informação que será descartada
        }

        void LendoTupla((int, string, string, decimal) tupla){
            Console.WriteLine($"Id: {tupla.Item1}");
            Console.WriteLine($"Nome: {tupla.Item2}");
            Console.WriteLine($"Sobrenome: {tupla.Item3}");
            Console.WriteLine($"Altura: {tupla.Item4}");
        }
    }
}