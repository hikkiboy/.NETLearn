using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace theBasics.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        

        public void Apresentar()
        {
            // funciona como se fosse o set --> Nome = "oiiii";
            Console.WriteLine($"Olá meu nome é {Nome}, e tenho {Idade} anos");
        }
    }   
}