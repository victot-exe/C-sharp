using ExemploExplorando.Model;
using ExemploExplorando.Models;

dynamic variavel = 4;
Console.WriteLine($"Tipo: {variavel.GetType()}, valor {variavel}");

variavel = "Texto";
Console.WriteLine($"Tipo: {variavel.GetType()}, valor {variavel}");