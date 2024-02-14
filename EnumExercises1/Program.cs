using EnumExercises1.Entities;
using EnumExercises1.Entities.Enums;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace EnumExercises1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Department's name: ");
            string dpName = Console.ReadLine();
            Console.WriteLine("Enter the Worker's data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level(Junior/MidLevel/Senior): ");
            WorkerLevel lvl = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salary: ");
            double sal = double.Parse(Console.ReadLine());    
            Console.Write("How many contracts?: ");
            int n = int.Parse(Console.ReadLine());

            Department dp = new Department(dpName);
            Worker worker = new Worker(name,lvl,sal,dp);


            for (int i = 0; i < n; i++)
            {

                Console.Write("Date: ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Hourly Rate: ");
                double valueHour = double.Parse(Console.ReadLine());
                Console.Write("Duration:  ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(data, valueHour, duration);
                worker.addContract(contract);

            }

            Console.WriteLine();
            Console.WriteLine("Enter Month and year to calc income: ");
            string monthandYear = Console.ReadLine();
            int month = int.Parse(monthandYear.Substring(0,2));
            int year = int.Parse(monthandYear.Substring(3));
            Console.WriteLine(worker.Name);
            Console.WriteLine(worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
