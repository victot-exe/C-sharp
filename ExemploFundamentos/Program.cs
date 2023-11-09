// See https://aka.ms/new-console-template for more information
using ExemploFundamentos.Models;
// Console.WriteLine("Hello, World!");
// int a = 10;
// int b = 20;

// int c = a + b;

// c += 5;
// int inteiro = 5;
// string c = inteiro.ToString();

// Console.WriteLine(c);

// int estoque = 3;
// Console.WriteLine($"Quantidade em estoque: {estoque}");
// int venda = 0;
// Console.WriteLine($"Quantidade venda: {venda}");
// bool possivel = estoque >= venda & venda != 0;
// Console.WriteLine($"É possível realizar a venda? {possivel}");


// if(venda == 0){
//     Console.WriteLine("Venda inválida!");
// }else if(possivel){
//     Console.WriteLine("Venda realizada!");
// }else{
//     Console.WriteLine("Quantidade em estoque insuficiente!");
// }

Console.WriteLine("Escreva uma letra: ");
string letra = Console.ReadLine();

if(letra == "a" | letra == "e" | letra == "i" | letra == "o" | letra == "u"){
    Console.WriteLine("Vogal");
}else{
    Console.WriteLine("Consoante");
}

switch(letra){
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}