# Tipos de memória e garbage collector C#
### Declaração de variáveis
* `tipo` `nome` `=` `valor`  
    * `tipo` -> Tipo de dado que a variável irá receber
    * `nome` -> O nome da variável deve ser único dentro do escopo em que ela se encontra.
    * `valor` -> valor da variável.  

* **Dependendo do tipo da variável ela vai para o tipo correto de memórioa `stack` ou `heap`.**  

### Stack e Heap _(tipos de memoria)_
* **Stack**
    * É como uma pilha LIFO _last in first out_ 
    * _É uma memória estática_
    * Armazena tipos simples `int`, `string`, `bool`, etc...
    * Armazena o nome e o valor das variáveis
    * Quando é um objeto ele guarda o nome do objeto e o endereço de memória referenciando a memória `Heap`
    * A stack armazena e joga para a RAM e quanto de espaço ela está ocupando

* **Heap**
    * Armazena tipos complexos de objetos, onde ele armazena o objeto em si.
    * Não ter ordem especifica para remover e adicionar os dados, é uma memória dinâmica

* Os dois tipos de memória se comunicam entre si.

### Garbage Collector _(limpeza de memória)_
* Gerencia de forma inteligente o uso das memórias
* Quando terminamos de executar um método a memória `stack` limpa as variáveis usando o método `LIFO`.
* O `Garbage Collector` é responsável por limpar a `heap`.
    * Ele limpa todos os objetos que não têm uma referência na `stack`.

### Tipos de valor x Tipo de referência
* **Tipo de valor**
    * `Value Types` _`Value Types`_
    * Uma variável de um tipo que contém uma instância do tipo.
    * Armazenada na `stack`.
    ~~~
    void metodo(){
        int a = 10;
        int b = a;
        b = 2;
    }
    ~~~
    * Ele copia o valor e cria outra variável diferente, alterar uma não altera a outra.

* **Tipo de referência**
    * TIpos complexos
    * Uma variável de um tipo que contém uma referência a uma instância do tipo.
    * Armazena na `stack` uma referência a `heap` onde fica a instância do tipo.
    ~~~
    void metodo(){
    
        Pessoa p1 = new("Victor", "Faria");
        Pessoa p2 = p1;
        p2.Nome = "Leonardo";
    }
    ~~~
    * Quando declaramos assim os tipos de referência ambos estão referenciados para o mesmo endereço de memória na `heap`
    * Se alterar o nome de uma altera o nome da outra.
