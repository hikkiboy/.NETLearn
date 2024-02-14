using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AbstractExercise.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public double HealthExpend {  get; set; }

        public PessoaFisica(string name, double annualGain, double healthExpend) : base(name, annualGain)
        {
            HealthExpend = healthExpend;
        }

        public override double Taxes()
        {
            double tax = 0;

            if(AnnualGain < 20000.00)
            {

                tax = (AnnualGain * 0.15) - (HealthExpend * 0.5);
            }
            else
            {
                tax = (AnnualGain * 0.25) - (HealthExpend * 0.5);
            }
            return tax;
        }
    }
}
