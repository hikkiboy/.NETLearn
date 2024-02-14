using AbstractStuffCsharp.Entities;
using AbstractStuffCsharp.Entities.Enums;

namespace AbstractStuffCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();    
            
            Console.WriteLine("number: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) 
            {
                Console.WriteLine("figuera");

                Console.WriteLine("R ou C?: ");
                char inpt = char.Parse(Console.ReadLine());

                Console.WriteLine("Cor: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(inpt == 'r')
                {

                }
            }

        }
    }
}
