using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models{
    public class Pilhas{//LIFO(last in first out) Stack
        Stack<int> pilha;

        public Pilhas(){
            pilha = new();

            AdicionarElementos();
            PercorrerElementos();
            
            RemoverElemento();
            PercorrerElementos();
        }

        private void PercorrerElementos(){
            foreach (int i in pilha){
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        private void RemoverElemento(){
            Console.WriteLine($"Elemento removido: {pilha.Pop()} \n");
            //.Pop() => Remove o elemento no topo da pilha
        }

        private void AdicionarElementos(){
            pilha.Push(42);
            pilha.Push(75);
            pilha.Push(74);
            pilha.Push(61);
            //.Push(i) => Insere um elemento na pilha
        }

        

    }
}