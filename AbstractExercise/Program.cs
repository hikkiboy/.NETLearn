using AbstractExercise.Entities;

namespace AbstractExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Console.WriteLine("Number of tax boys: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Company or individual ?: ");
                char inpt = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Income: ");
                double income = double.Parse(Console.ReadLine());

                if(inpt == 'i')
                {
                    Console.Write("Health Expenses: ");
                    double heal = double.Parse(Console.ReadLine());

                    pessoas.Add(new PessoaFisica(name, income, heal));
                }
                else
                {
                    Console.Write("Number of Employees");
                    int employ = int.Parse(Console.ReadLine());

                    pessoas.Add(new PessoaJuridica(name, income, employ));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES: ");
            double sum = 0;
            foreach (Pessoa p in pessoas)
            {
                

                sum += p.Taxes();

                Console.WriteLine(p.Taxes().ToString("F2"));

               
            }
            Console.WriteLine("TOTAL TAXES: ") ;
            Console.WriteLine(sum);
        }
    }
}
