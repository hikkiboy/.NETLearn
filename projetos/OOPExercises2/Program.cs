namespace OOPExercises2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.WriteLine("eai man? :");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("porcentagem: ");
            double po = double.Parse(Console.ReadLine());
            f.AumentarSalario(po);
            Console.WriteLine(f.SalarioBruto);
        }
    }
}
