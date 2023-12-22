using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class DIct{//Dictionary => composto por chave a valor, todas as chaves devem ser unicas
        Dictionary<string, string> estados;

        public DIct(){
            estados = new();
            AdicionandoElementos();
            PercorrerElementos();

            RemovendoElementos();
            PercorrerElementos();

            AlterandoValor();
            PercorrerElementos();

            VerificarValor("BA");

            VerificarValor("ES");
            PercorrerElementos();

        }

        void AdicionandoElementos(){
            estados.Add("SP", "São Paulo");
            estados.Add("BA", "Bahia");
            estados.Add("MG", "Minas Gerais");
        }

        void PercorrerElementos(){
            foreach(KeyValuePair<string, string> i in estados){
                Console.WriteLine($"Chave: {i.Key} => Valor: {i.Value}");
            }
            Console.WriteLine("\n");
        }

        void RemovendoElementos(){
            estados.Remove("SP");
        }

        void AlterandoValor(){
            estados["BA"] = "Alterando valor";
        }

        void VerificarValor(string chave){
            if (estados.ContainsKey(chave)){
                Console.WriteLine($"O dict já contem a chave {chave}");
            }else{
                Console.WriteLine($"É seguro adicionar {chave}");
                estados.Add(chave, "Chave testada");
            }
        }
    }
}