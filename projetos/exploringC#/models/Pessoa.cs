using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploringC_.models
{
    public class Pessoa
    {
        
        public Pessoa()
        {

        }


        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }


        private string _nome;
        private int _idade;
        public int Idade 
        {
            get => _idade;


            set{
                if(value < 0)
                {
                    throw new ArgumentException("Idade não pd ser menor q 0");
                }

                _idade = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeComplete => $"{Nome} {Sobrenome}".ToUpper(); 
       
        public string Nome { 
            get => _nome.ToUpper();

 
            set
            {
                if(value == ""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome {NomeComplete} Idade {Idade}");
        }
    }
}