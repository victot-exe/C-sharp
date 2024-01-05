using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models{
    public class ClasseGenerica<T>{
        
        private static int capacidade = 10;
        private int contador = 0;
        private T[] array = new T[capacidade];

        public void AdicionarElemento(T elemento){
            if (contador + 1 < 11){
                array[contador] = elemento;
            }
            contador ++;
        }
    //criou um setter e o getter para a classe genérica
        public T this[int index]{
            get {return array[index];}
            set { array[index] = value;}
        }
    }
}