using ExemploExplorando.Models;

Pessoa p1 = new("victor", "faria");

Pessoa p2 = new ();
p2.Nome = "Leonardo";
p2.Sobrenome = "Leitão";

Curso cursoDeIngles = new("Ingles");

cursoDeIngles.AdicionarAluno(p1); 
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();

Console.WriteLine(cursoDeIngles.RemoverAluno(p2));



