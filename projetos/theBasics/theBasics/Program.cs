using theBasics.Common.Models;



using System;

namespace PriorizacaoTestes {
  class Program {
    static void Main(string[] args) {
      // TODO: Defina um array 'testes' para armazenar as complexidades dos testes:
      string[] testes = new string[3];
      // TODO: Defina um array 'complexidades' que contém as possíveis complexidades dos testes:
      int[] complexidades = {10, 20, 30};
      for (int i = 0; i < 3; i++) {
        // Solicita ao usuário a complexidade do teste e armazena-o em testes[i]:
        testes[i] = Console.ReadLine().ToLower();
      }

      int maiorComplexidadeIndex = EncontrarMaiorComplexidadeIndex(testes, complexidades);
      string testePrioritario =$"Teste {maiorComplexidadeIndex + 1}";

      // Aqui é exibido o teste prioritário na tela:
      Console.WriteLine($"O teste a ser executado primeiro é o {testePrioritario}.");

      // Esse trecho aguarda a entrada do usuário antes de encerrar o programa
      Console.ReadLine();
    }

    static int EncontrarMaiorComplexidadeIndex(string[] testes, string[] complexidades) {
      int maiorIndex = 0;

      // Aqui é implementada a lógica necessária para encontrar o índice do teste com a maior complexidade:
      // Utiliza o "loop FOR" para encontrar o índice:
      for (int i = 1; i < testes.Length; i++) {
        // No trecho de código abaixo é comparado a complexidade de diferentes testes 
        // E encontra o índice do teste com a maior complexidade
        if (Array.IndexOf(complexidades, testes[i]) > Array.IndexOf(complexidades, testes[maiorIndex])) {
          maiorIndex = i;
        }
      }
      return maiorIndex;
    }
  }
}

















    // // Solicita ao usuário a quantidade de testes bem-sucedidos:
    //   double testesBemSucedidos = double.Parse(Console.ReadLine());

    //   // Solicita ao usuário a quantidade de testes totais:
    //   double testesTotais = double.Parse(Console.ReadLine());

    //   // TODO: Implemente as condições para o cálculo da taxa de sucesso:
    //   double taxaSucesso = testesBemSucedidos / testesTotais; 

    //   // TODO: Implemente uma estrutura condicional (if/else) para avaliar a taxa de sucesso e tomar decisões com base nela:
    //   if(taxaSucesso > 0.8)
    //   {
    //     Console.WriteLine("A funcionalidade esta pronta para lancamento");
    //   }else{
    //     Console.WriteLine("A funcionalidade nao esta pronta para lancamento");
    //   }








// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");


// for (int i = 0; i < listaString.Count; i++){"
//     Console.WriteLine($"Posição {i}, Estado {listaString[i]}");
// }



// Console.WriteLine("ForEach");
// int j = 0;
// foreach(string i in listaString){
//     Console.WriteLine($"Posição {j}, Estado {i}");
//     j++;
// }


















// int[] arrayInteiros = new int[3];


// arrayInteiros[0] = 2;
// arrayInteiros[1] = 77;
// arrayInteiros[2] = 4;


// int[] arrayInteirosDobrado = new int[arrayInteiros.Length*2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// //Array.Resize(ref arrayInteiros, arrayInteiros.Length*2);

// Console.WriteLine("FOR");
// for (int i = 0; i < arrayInteiros.Length; i++){
//     Console.WriteLine($"Posição : {i}, Numero : {arrayInteiros[i]} ");
// }


// int j = 0;

// Console.WriteLine("FOREACH");
// foreach(int i in arrayInteiros){
//     Console.WriteLine($"Posição : {j}, Numero : {arrayInteiros[j]} ");
//     j++;
// }








// Pessoa p1 = new Pessoa();
// p1.Nome = "a";
// p1.Idade = 10;
// p1.Apresentar();











// //Condicionais 


// int quantidadeEmEstoque = 10;

// int quantidadeCompra = 4;

// bool venda = quantidadeEmEstoque >= quantidadeCompra;
// Console.WriteLine($"Quantidade em estoque {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra {quantidadeCompra}");
// Console.WriteLine($"da de vender?  {venda}");



// if (quantidadeEmEstoque >= quantidadeCompra)
// {
//     Console.WriteLine("mim de papai");
// }
// else
// {
//     Console.WriteLine("quero naum");
// }





// // DateTime agorinhamesmo = DateTime.Now.AddDays(6);


// // Console.WriteLine(agorinhamesmo.ToString("dd/MM/yyyy"));

// // // using theBasics.Models;

// // // Pessoa p = new Pessoa();

// // // p.Nome = "bobo";
// // // p.Idade = 22;

// // // p.Apresentar();"