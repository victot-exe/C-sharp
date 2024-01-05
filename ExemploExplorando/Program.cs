using ExemploExplorando.Model;
using ExemploExplorando.Models;

int numero = 20;
bool par = numero.EhPar();

string mensagem = "O numero " + numero + " é " +  (par ? "Par" : "impar");
Console.WriteLine(mensagem);