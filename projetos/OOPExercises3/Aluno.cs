using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises3
{
    internal class Aluno
    {
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            double final = Nota1 + Nota2 + Nota3;
            if (final >= 60.00)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine($"Nota final:{final} ");
                return final;
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Nota final:{final} ");
                return final;
            }
        }
    }
}
