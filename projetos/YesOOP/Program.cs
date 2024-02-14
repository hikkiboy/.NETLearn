using System.Globalization;

namespace YesOOP

{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            f1.nome = Console.ReadLine();
            f1.salario = float.Parse(Console.ReadLine());


            Console.WriteLine("Dados do segundo funcionario: ");
            f2.nome = Console.ReadLine();
            f2.salario = float.Parse(Console.ReadLine());

            double media = (f1.salario + f2.salario) / 2;
            Console.WriteLine("Media: " +  media);
        }
    }
}
