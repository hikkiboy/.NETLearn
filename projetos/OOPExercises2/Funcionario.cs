using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises2
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto -= Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            double porcentagemReal = porcentagem * 0.01;
            SalarioBruto += SalarioBruto * porcentagemReal;
        }
    }
}
