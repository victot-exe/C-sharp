using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_intro.Entities{
    //Classe que vai virar um espelho da tablema do DB
    public class Contato{

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
        
    }
}