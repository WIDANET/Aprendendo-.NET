using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aprendendo_.NET.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string Nome, int Idade){
            this.Nome = Nome;
            this.Idade = Idade;
        }

        public void Apresentar (){

            Console.WriteLine($"Olá, meu nome é {Nome}, e eu tenho {Idade} anos.");
        }

    }
}