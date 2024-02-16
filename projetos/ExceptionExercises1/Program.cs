using ExceptionExercises1.Entites;

namespace ExceptionExercises1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check in date: ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check out date: ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(number, checkin, checkout);

            Console.WriteLine();
            Console.WriteLine("Update: ");
            Console.Write("Check in date: ");
            checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check out date: ");
            checkout = DateTime.Parse(Console.ReadLine());

        }
    }
}
