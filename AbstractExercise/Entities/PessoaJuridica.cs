using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExercise.Entities
{
    internal class PessoaJuridica : Pessoa
    {
        public double NFunc { get; set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string name, double annualGain,double nFunc): base(name, annualGain)
        {
            NFunc = nFunc;
        }

        public override double Taxes()
        {
            double tax = 0;

            if(NFunc > 10)
            {
                tax = AnnualGain * 0.14;
            }
            else
            {
                tax = AnnualGain * 0.16;
            }
            return tax;
        }
    }
}
