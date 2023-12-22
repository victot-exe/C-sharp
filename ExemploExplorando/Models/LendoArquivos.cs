using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models{
    public class LendoArquivos{

        // string[] linhas = File.ReadAllLines("Arquives/arquivo_Leiura.txt");

        public void LinhaPorLinha(string caminhoArquivo){

            try{
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                foreach(string linha in linhas){
                Console.WriteLine($"{linha}");
                }
            } catch(FileNotFoundException ex){
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. {ex.Message}");
            } catch(DirectoryNotFoundException ex){
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. {ex.Message}");
            } catch(Exception ex){
                Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
            } finally{
                Console.WriteLine("Chegou no finally");
            }
        }
        
    }
}