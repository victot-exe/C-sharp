using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models{
    public class Filas{//queue (peps (primeiro que entra, primeiro que sai))

        Queue<int> fila;

        public Filas(){
            // Criando a fila
            fila = new();

            AdicionandoElementos();
            PercorrendoElementos();
            RemovendoElementos();
            PercorrendoElementos();
            
        }

        void AdicionandoElementos(){
            fila.Enqueue(2);//adicionando elementos na fila
            fila.Enqueue(4);
            fila.Enqueue(6);
            fila.Enqueue(8);
            //.Enqueue() => Adiciona um elemento no final da fila
        }
        
        void PercorrendoElementos(){
             foreach (int i in fila)
            {
                Console.WriteLine(i);
            }
        }

        void RemovendoElementos(){
            Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
            //.Dequeue() => remove o primeiro elemento da fila
        }
        
    }
}