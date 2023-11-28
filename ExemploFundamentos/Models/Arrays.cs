using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models{
    public class Arrays{

        int[] jeitoUm = new int[4]; //diz que essa array vai poder armazenar até 4 valores
        int[] jeitoDois = new int[]{42, 75, 74, 61}; //esta array pode armazenar até 4 valores que foram atribuidos já na sua declaração
        string[] jeitoTres = {"Jan", "Fev"};

        public void adicionandoValor(){
            jeitoUm[0] = 1;
        }

        public void alterandoValor(){
            jeitoDois[0] = 0;
        }

        int[] arrayInteiros = new int[3];

        public void iniciandoArrayInteiros(){
            arrayInteiros[0] = 72;
            arrayInteiros[1] = 64;
            arrayInteiros[2] = 50;
            // arrayInteiros[3] = 1;//=> erro pois a array só vai até o indice 2
        }

        public void exibindoArrayInteiros(){
            for(int i = 0; i <= arrayInteiros.Length; i++){
                Console.WriteLine($"O índice {i} tem o valor {arrayInteiros[i]}");
            }
        }
    }
}