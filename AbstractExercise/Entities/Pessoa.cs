using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExercise.Entities
{
    internal abstract class Pessoa
    {
        public string Name { get; set; }
        public double AnnualGain { get; set; }


        protected Pessoa(string name, double annualGain)
        {
            Name = name;
            AnnualGain = annualGain;
        }

        protected Pessoa()
        {
        }

        public abstract double Taxes();
    }
}
