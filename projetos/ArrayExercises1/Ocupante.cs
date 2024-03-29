﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercises1
{
    internal class Ocupante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public int Quarto { get; set; }

        public Ocupante(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return "\n" + Quarto + ": " + Nome + ", " + Email ;
        }
    }
}
