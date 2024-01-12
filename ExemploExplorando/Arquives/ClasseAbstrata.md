# Classe abstrata
**Classe que serve para ser herdada, ela faz um contrato com atributos e métodos que as classes que a herdam tem que implementar**  
#### Declarando a classe abstrata
~~~
public abstract class Conta{
    
    public Conta(string nome){//Fazendo a herança do constructor
        this.titular = nome;
    }
    
    protected decimal saldo;
    protectec string titular;

    
    public abstract void Creditar(decimal valor);

    public void exibirSaldo(){
        Console.WriteLine($"O saldo é: {saldo}.");
    }
}
~~~
#### Usando a classe abstrata
~~~
public class ContaCorrente : Conta{

    public ContaCorrente(string nome) : base(nome){//para herdar o construtor usamos a palavra base, passando os atributos do método.

    }

    public override void Creditar(decimal valor){//implementando o método abstrato.
        saldo += valor;
    }
}
~~~
