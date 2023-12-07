using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models{
    public class TestandoDateTime{
        
        DateTime date = DateTime.Now;//retorna a data e hora atual

        public void MostrarData(){
            Console.WriteLine(date.ToString("dd/MM/yy HH:mm"));
            Console.WriteLine(date.ToShortDateString());//apenas a data
            Console.WriteLine(date.ToShortTimeString());//apenas a hora
        }

        public void StringParaData(string data){
            bool sucesso = DateTime.TryParseExact(data, "yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataTeste);

            if(sucesso){
                Console.WriteLine($"Conversão com sucesso! Data: {dataTeste}");
            }else{
                Console.WriteLine($"{data} não é uma data válida");
            }
            Console.WriteLine(dataTeste);
        }
    }
}