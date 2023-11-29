using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models{
    public class ListIntro{
        //Lists são arrays melhoradas
        List<string> listaString = new List<string>();

        public void adicionandoElementos(){
            listaString.Add("SP");
            listaString.Add("BA");
            listaString.Add("MG");
        }

        public void percorrendoArray(){
            Console.WriteLine("Usando for.");
            for(int i = 0; i < listaString.Count; i++){
                Console.WriteLine($"Pos {i} => {listaString[i]}");
            }

            Console.WriteLine("Usando foreach.");
            foreach(string i in listaString){
                Console.WriteLine(i);
            }

        }
        
    }
}