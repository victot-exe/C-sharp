using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models{
    public class LacosDeRapeticao{
        
        public void LacoFor(int maximo){

            for(int i = 0; i <= maximo; i++){
                Console.WriteLine(i);
            }
        }

        public void LacoWhile(int numero){
            int contador = 0;

            while(contador <= 10){
                if(contador == 7){
                    break;
                }
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                contador ++;

            }
        }

        public void DoWhile(){

            int soma = 0, numero = 0;

            do{
                Console.WriteLine("Digite um número (0 para parar)");
                numero = Convert.ToInt32(Console.ReadLine());

                soma += numero;
            }while(numero != 0);

            Console.WriteLine($"Total da soma é: {soma}");
        }

        public void MenuInterativo(){
            
            string? opcao;
            bool exibirMenu = true;
            
            while(exibirMenu){
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Buscar cliente");
                Console.WriteLine("3 - Apagar cliente");
                Console.WriteLine("4 - Encerrar");

                opcao = Console.ReadLine();

                switch(opcao){
                    case "1":
                        Console.WriteLine("Cadastro de cliente");
                        break;
                    case "2":
                        Console.WriteLine("Buscando o cliente");
                        break;
                    case "3":
                        Console.WriteLine("Apagando o cliente");
                        break;
                    case "4":
                        Console.WriteLine("Encerrando");
                        exibirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }
            }
        }
    }
}