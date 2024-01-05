## Tipos especiais
* São os tipos diferentes do esperado
    * `null` -> Normalmente as variáveis não recebem o valor `null` e apontam um erro, colocamos os `?` após o tipo para especificar que o valor pode ser `null`.  
    ~~~
    bool? desejaReceberEmail = null;
    if(desejaReceberEmail.HasValue & desejaReceberEmail.Value){
        Console.WriteLina("True");
    } else{
        Console.WriteLina("False");
    }
    ~~~
    * Tipo anônimo -> Objetos somente de leitura  
           `var tipoAnonimo = {Nome = "Victor", Sobrenome = "Faria", Altura = 1.80}`
    ~~~
    string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
    List<Venda> listaVenda = Json.Convert.DeserializeObject<List<Venda>>(conteudoArquivo);

    var listaAnonima = listaVenda.Select(x => new{ x.Produto, x.Preco });

    foreach(var venda in listaAnonima){
        Console.WriteLine($"Produto: {venda.produto}, preço: {venda.preco});
    }
    ~~~
    * `dynamic` -> uma variável que tem tipagem dinâmica (muda de acordo com o valor)
    ~~~
    dynamic variavel = 4;
    Console.WriteLine($"Tipo: {variavel.GetType()}, valor {variavel}");

    variavel = "Texto";
    Console.WriteLine($"Tipo: {variavel.GetType()}, valor {variavel}");
    ~~~
    * Classe genérica -> As classes genéricas encapsulam operações de um tipo que não foi especificado ainda. `List<Tipo> lista = new()`
