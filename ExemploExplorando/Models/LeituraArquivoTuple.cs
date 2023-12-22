using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Model{
    public class LeituraArquivoTuple{
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho){
            
            try{
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
                 //Descarte=> para descartar informações que não utilizamos, no local que receberá o retorno colocamos um _ no local que irá receber a informação que será descartada
            }catch(Exception){
                return(false, new string[0], 0);
            }

        }
    }
}