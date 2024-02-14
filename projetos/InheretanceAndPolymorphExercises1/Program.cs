using InheretanceAndPolymorphExercises1.Entities;
using System.Globalization;

namespace InheretanceAndPolymorphExercises1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("How many Employees?");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++ )
            {
                Console.WriteLine($"Employee #{i + 1} Data: ");
                Console.Write("OutSourced? ");
                char inpt = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value Per Hour: ");
                double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);    

                if(inpt == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valueHour, addCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valueHour));
                }

            }
            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.payment().ToString("F2", CultureInfo.InvariantCulture));


            }
        }
    }
}
