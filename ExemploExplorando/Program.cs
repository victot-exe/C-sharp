using ExemploExplorando.Model;
using ExemploExplorando.Models;

LeituraArquivoTuple arquivo = new();

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquives/arquivoLeiura.txt");

if(sucesso){
    Console.WriteLine($"Quantidade de linhas do arquivo {quantidadeLinhas}");
    foreach (string i in linhasArquivo){
        Console.WriteLine(i);
    }
}else{
    Console.WriteLine("Não foi possível ler o arquivo");
}