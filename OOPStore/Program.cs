using System.Security.Cryptography;

namespace OOPStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);
            
            
            Console.WriteLine("Dados do produto: " + p);
            
            Console.Write("Digite a quantidade a ser adicionada no estoque: ");
            
            int quantity = int.Parse(Console.ReadLine());
            
            p.AdicionarProdutos(quantity);
            
            
            Console.WriteLine("Dados do produto: " + p);
            
            Console.Write("Digite a quantidade a ser removida do estoque: ");
            
            quantity = int.Parse(Console.ReadLine());
            
            p.RemoverProdutos(quantity);
            
            
            Console.WriteLine("Dados do produto: " + p);

        }
    }
}
