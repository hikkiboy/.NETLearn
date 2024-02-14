namespace CursoCsharpInputClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            while(x != null && y != null)
            {
                if(x >= 1 && y >= 1)
                {
                    Console.WriteLine("Primeiro quadrante");
                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());
                }
                else if(x <= 0 && y >= 0)
                {
                    Console.WriteLine("Quarto Quadrante");
                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());
                }
                else if (x > 0 && y > 0)
                {
                    Console.WriteLine("Terceiro quadrante");
                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());
                }
                else if(x > 0 && y < 0)
                {
                    Console.WriteLine("Segundo quadrante");
                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());
                }

                

            }
            Console.WriteLine("fim");


        }
    }
}
