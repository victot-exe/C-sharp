using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
//Classe para exemplo da serialização usando a lib "Newtonsoft.Json"
namespace ExemploExplorando.Models{
    public class Venda{
        public Venda(int id, string produto, decimal preco){
            this.Id = id;
            this.Produto = produto;
            this.Preco = preco;
            this.CreateArquivo();
        }
        
        public int Id{get; set;}
        public string Produto{get; set;}
        public decimal Preco{get; set;}

        public string GetSerialização(){
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public void CreateArquivo(){
            string serializado = this.GetSerialização();
            File.WriteAllText("Arquives/vendas.json", serializado);
        }
    }
}