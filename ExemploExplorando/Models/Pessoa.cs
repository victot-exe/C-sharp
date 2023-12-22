using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ExemploExplorando.Models{
    public class Pessoa{
        public Pessoa(){}
        public Pessoa(string nome, string sobrenome){
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome){//um método que retorna em variáveis os atributos da classe, o contrário do construtor
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome;
        public string Nome{
            get => _nome.ToUpper();
            
            set{
                if (value == ""){
                    throw new ArgumentException("O nome não pode ser vazio.");
                }

                _nome = value;
            }
        }

        string _sobrenome;

        public string Sobrenome {
            get => _sobrenome.ToUpper();
            set{
                if(value == ""){
                    throw new ArgumentException("O sobrenome não pode ser vazio");
                }
                _sobrenome = value;
            }
         }
        
        public string NomeCompleto {
            get => $"{Nome} {Sobrenome}";//propriedade apenas de retorno de valores
        }
        private int _idade;
        public int Idade {
            get => _idade;//ao inves do return podemos utilizar o "=>"//
            set {
                if(value < 0){
                    throw new ArgumentException("a idade não pode ser menor do que 0");
                }

                _idade = value;
            }
        }

        public void Apresentar(){
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }

        public override string ToString()
        {
            return $"Nome: {NomeCompleto}, Idade: {Idade}";
        }
    }
}