using System.Collections.Generic;

namespace ListsExercises1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o Numero de Funcionarios: ");
            int n = int.Parse(Console.ReadLine());
            List<int> ids = new List<int>();
            List<Funcionario> funcs = new List<Funcionario>();


            for (int i = 0; i < n; i++)
            {
                Console.Write("Id: ");

                int id = int.Parse(Console.ReadLine());

                ids.Add(id);

                Console.Write("Nome: ");

                string nome = Console.ReadLine();

                Console.Write("Salario: ");

                double sal = double.Parse(Console.ReadLine());

                funcs.Add(new Funcionario(id, nome, sal));


            }

            Console.Write("Id do funcionario para aumentar o salario: ");
            int temp = int.Parse(Console.ReadLine());

            Funcionario F = funcs.Find(x => x.Id == temp);

            if(F != null)
            {
                Console.WriteLine("Quantos % vai aumentar ?");
                double porc = double.Parse(Console.ReadLine());
                F.aumentaSalario(porc);
            }
            else
            {
                Console.WriteLine("Não tem esse id");
            }


            Console.WriteLine("Lista de Funcionarios: ");
            foreach (Funcionario f in funcs)
            {
                Console.Write(f.ToString());
            }
        }
    }
}
