using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models {
    public class ArraysIntro {
        
        int[] arrayInteiros = new int[4];//Quando iniciada os valores são o padrão do tipo definido, no caso do int é 0. Um array nasce e morre com o mesmo tamanho.

        public void iniciandoArray(){
            arrayInteiros[0] = 72;
            arrayInteiros[1] = 64;
            arrayInteiros[2] = 50;
            arrayInteiros[3] = 0;//=> da erro pois a array tem tamanho fixo e ele foi definido como 3(index begins with 0... 0, 1, 2)
        }

        public void percorrendoArray(){
            for(int i = 0; i < arrayInteiros.Length; i++){
                Console.WriteLine($"posição n° {i} => {arrayInteiros[i]}");
            }
        }

        public void percorrendoForEach(){
            
            foreach(int i in arrayInteiros){
                Console.WriteLine(i);
            }
        }

        public void redmencionandoArray(){
            Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
            //Redmenciona a array, podendo ser até passado uma formula para calcular o novo tamanho => ele cria uma cópia do array em uma array com o novo tamanho
        }

        public void copiandoArray(){
            this.iniciandoArray();

            int[] arrayDobrado = new int[arrayInteiros.Length * 2];//criando uma array com o dobro do tamanho
            Array.Copy(arrayInteiros, arrayDobrado, arrayInteiros.Length);
            //(Array base, array destino, quanto da array quer copiar)
            

        }

    }
}