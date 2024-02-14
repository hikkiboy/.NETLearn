using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsExercises1
{
    internal class Funcionario
    {
        public int Id {  get; set; }
        public string Nome {  get; set; }
        public double Salario { get; private set; }


        public Funcionario() { }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public Funcionario(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void aumentaSalario (double valor)
        {
            Salario += Salario * (valor * 0.01);
        }


        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario
                + "\n";
        }
    }
}
