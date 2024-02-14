using EnumExercisesFinal.Entities;
using EnumExercisesFinal.Entities.Enums;

namespace EnumExercisesFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Date of Birth: ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Order Data: ");
            Console.Write("How many items ?: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Order Status: "); 
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birth);

            Order order = new Order(DateTime.Now,client, status);
            

            for(int i = 0; i< n; i++)
            {
                Console.WriteLine($"Enter #{i} Data");
                Console.Write("Product Name: ");
                string pname = Console.ReadLine();

                Console.Write("Product Price: ");
                double pprice = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int qnt = int.Parse(Console.ReadLine());

                Product product = new Product(pname, pprice);

                OrderItem orderitem = new OrderItem(qnt, pprice, product);
                order.addItem(orderitem);
            }
            Console.WriteLine("Summary: ");
            Console.WriteLine(order);
            
    

        }
    }
}
