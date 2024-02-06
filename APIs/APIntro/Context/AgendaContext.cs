using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_intro.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_intro.Context{
    public class AgendaContext : DbContext{
        //Criando o construtor fazendo referência ao construtor da classe pai
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options){

        }

        public DbSet<Contato> Contatos{ get; set; }
    }
}