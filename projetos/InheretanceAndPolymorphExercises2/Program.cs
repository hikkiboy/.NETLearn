using InheretanceAndPolymorphExercises2.Entities;

namespace InheretanceAndPolymorphExercises2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter Number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++ )
            {
                Console.Write("Commom, Used or imported?: ");
                char inpt = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (inpt == 'i')
                {
                    Console.Write("Custom Fee: ");
                    double fee = double.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct(name, price, fee));

                }
                else if (inpt == 'u')
                {
                    Console.Write("Manufactured Date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name,price, date));
                }
                else
                {
                    products.Add(new Product(name, price));
                }

            }
            Console.WriteLine();
            foreach(Product product in products)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}
