using ExemploExplorando.Model;
using ExemploExplorando.Models;

Venda v1 = new(1, "Material de escritorio", 25.00m);

// Console.WriteLine(v1.Serializado);

Venda v2 = new(2, "Licença de Software", 110.00m);
VendasColecaoParaJSON vendas = new();
vendas.AddVenda(v1);
vendas.AddVenda(v2);

vendas.CreateArquivo();