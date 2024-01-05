using ExemploExplorando.Model;
using ExemploExplorando.Models;

ClasseGenerica<int> classeGenerica = new();

classeGenerica.AdicionarElemento(30);

Console.WriteLine(classeGenerica[0]);