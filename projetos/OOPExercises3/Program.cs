namespace OOPExercises3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno A = new Aluno();
            Console.WriteLine("Bota as nota ai pai: ");
            A.Nota1 = double.Parse(Console.ReadLine());
            A.Nota2 = double.Parse(Console.ReadLine());
            A.Nota3 = double.Parse(Console.ReadLine());
            A.NotaFinal();

        }
    }
}
