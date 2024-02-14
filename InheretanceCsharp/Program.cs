using InheretanceCsharp.Entities;

namespace InheretanceCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Flavio", 0.0, 500);

            //UPCAST

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "asdasd", 0.0, 300);
            Account acc3 = new SavingsAccount(1003, "asdasd", 0.0, 0.01);

            //DOWNCAST

            BusinessAccount acc4 = (BusinessAccount)acc2;

            //BusinessAccount acc5 = (BusinessAccount)acc3;

            if ( acc3 is BusinessAccount )
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }
        }
    }
}
