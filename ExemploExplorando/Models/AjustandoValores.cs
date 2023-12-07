using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models{
    public class AjustandoValores{
        decimal valorMonetario = 1282.40M;//decimal precisa colocar o M no final
        double porcentagem = .3421;

        public void ImprimirValor(){
            Console.WriteLine(valorMonetario);
         }

        public void ImprimirValorFormatado(){
            Console.WriteLine($"{valorMonetario:C}");//=>Coloando o ":C" após a variável ele usa a moeda corrente local para definir os valores no caso do br reais
        }

        public void ImprimirValorDeOutroPais(){//=>Aqui alteraremos a loalização de todo o sistema.
        CultureInfo.DefaultThreadCurrentCulture = new("en-US");//=> classe responsável por mudar a localização do sistema.
        this.ImprimirValorFormatado();
            
        }
        
        public void ImprimirValorSemAlterarLocalidade(){
            Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
        }

        public void ImprimirFormatacaoPersonalizada(){
            Console.WriteLine(valorMonetario.ToString("C2"));//o C* altera o numero de casas que será exibido após a virgula
        }

        public void PorcentagemExibicao(){
            Console.WriteLine(porcentagem.ToString("P"));
        }

        public void ExibicaoPersonalizada(int numero){//Personalizando a exibição do número pelo formato ditado pelos ## e pelos outros simbolos ou letras.
            Console.WriteLine(numero.ToString("##-##-##"));
            Console.WriteLine(numero.ToString("####-##"));
            Console.WriteLine(numero.ToString("####y##"));
        }
    }
}