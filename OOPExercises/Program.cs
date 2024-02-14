namespace OOPExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Retangulo r = new Retangulo();
            Console.WriteLine("Digite a largura e altura do retangulo:" );
            r.Altura = double.Parse( Console.ReadLine() );
            r.Largura = double.Parse( Console.ReadLine() );
            Console.WriteLine(r.ToString() );
        }
    }
}
