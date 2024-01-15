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

# Classe selada
**Diferente da classe abstrata, essa classe diz que nenhuma classe pode ser sua derivada, ela é apenas instanciada**  
~~~
public sealed class Professor : Pessoa{

}
~~~
**Usa quando a classe pode herdar mas não pode ser herdada**  
**Também temos métodos selados**  
* Métodos com `sealed` não podem ser sobrescritos `override`  

# Classe object
**A classe System.Object é a mãe de todas as classes na hierarquia do .NET**  
* Ela prove serviços de baixo nível para suas classes filhas  

# Interface
**Um contrato que pode ser implementado por outra classe**
* Todas as classes precisam implementar os métodos da interface
* Uma classe só pode implementar uma class mas pode implementar mais de uma interface.
* Interfaces podem ter métodos padrão, que já vem implementados e têm a sua implementação opcional.
~~~
public interface ICalculadora{
    int Somar(int num1, int num2);
    int Subtrair(int num1, int num2);
    int Multiplicar(int num1, int num2);
    int Dividir(int num1, int num2){
        return num1 / num2;
    }
}
~~~
* Todos os métodos devem ser implementados para que não tenha nenhum erro.  
~~~
public class Calculadora : ICalculadora{

    public int Multiplicar(int num1, int num2){
        return num1 * num2;
    }

    public int Somar(int num1, int num2){
        return num1 + num2;
    }

    public int Subtrair(int num1, int num2){
        return num1 - num2;
    }
}
~~~
