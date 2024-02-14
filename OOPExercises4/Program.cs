namespace OOPExercises4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* registrar conta com numero da conta
             * nome
             * valor de deposito inicial (opcional)
             * numero da conta bancaria n pode mudar
             * o nome pode
             * saldo so muda com deposito ou saque
             * saque tem taxa de 5
            Console.WriteLine("Hello, World!");*/
            Conta conta = new Conta();
            Console.Write("Insira o numero da conta: ");
            int nConta = int.Parse(Console.ReadLine());
            Console.Write("Insira o titular da conta: ");
            string nomeTemp = Console.ReadLine();
            Console.Write("Haverá deposito inicial? (s/n) ");
            char choice = char.Parse(Console.ReadLine());
            if (choice.Equals('s'))
            {
                Console.Write("Insira o valor para deposito: ");

                double depos = double.Parse(Console.ReadLine());

                conta = new Conta(nomeTemp, depos, nConta);

                Console.WriteLine(conta.ToString());
            }
            else
            {
                conta = new Conta(nomeTemp, nConta);
                Console.WriteLine(conta.ToString());
            }

            Console.WriteLine("Entre o valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);
            Console.WriteLine(conta.ToString());
            Console.WriteLine("Entre o valor para saque");
            double saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);
            Console.WriteLine(conta.ToString());
        }
    }
}
