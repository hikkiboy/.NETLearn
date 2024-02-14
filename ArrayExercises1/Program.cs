namespace ArrayExercises1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de ocupantes");
            int n = int.Parse(Console.ReadLine());
            Ocupante[] arr = new Ocupante[10];

            if( n <= 10)
            {
                for(int i = 0;  i < n; i++)
                {
                    Console.Write("Digite o nome do ocupante: ");
                    string tempnome = Console.ReadLine();
                    Console.Write("Digite o email do ocupante: ");
                    string tempemail = Console.ReadLine();
                    Console.Write("Digite o Quarto a ser ocupado: ");
                    int tempquarto = int.Parse(Console.ReadLine());

                    arr[i] = new Ocupante (tempnome,tempemail,tempquarto);

                }


                Console.WriteLine("Quartos Ocupados: ");

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(arr[i].ToString());
                }
            }
            else
            {
                Console.WriteLine("Numero Execido de quartos.");
            }

            
            


        }
    }
}
