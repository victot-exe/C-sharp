using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models{
    public class VendasColecaoParaJSON{

        public List<Venda> vendas = new();
        public void AddVenda(Venda venda){
            this.vendas.Add(venda);
        }
        
        public void CreateArquivo(){
            string Serializado = JsonConvert.SerializeObject(vendas, Formatting.Indented);
            File.WriteAllText("Arquives/vendas.json", Serializado);
            Console.WriteLine(Serializado);
        }

        public void DeserializandoJSON(string caminho){
            string conteudoArquivo = File.ReadAllText(caminho);
            vendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

            foreach (Venda venda in vendas){
                Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto} - r$ {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
            }
        }
    }
}