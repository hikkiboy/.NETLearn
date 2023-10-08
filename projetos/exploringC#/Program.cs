using exploringC_.models;
using System.Globalization;


Dictionary<string, string> estados = new Dictionary<string, string>();


estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas gerais");
estados.Add("BA", "Bahia");


Console.WriteLine(estados["MG"]);



// foreach(var i in estados)
// {
//     Console.WriteLine(i);
// }

// Console.WriteLine("--------------");
// estados["SP"] = "nao sao paulo";

// foreach(var i in estados)
// {
//     Console.WriteLine(i);
// }


// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave} ");

// if( estados.ContainsKey("BA"))
// {
//     Console.WriteLine("boa ta certo");
// }
// else{
//     Console.WriteLine($"pd meter a tal da {chave}");
// }



// Stack<int> pilha = new Stack<int>();


// pilha.Push(1);
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(10);
// pilha.Push(142);
// pilha.Push(25);




// foreach(int i in pilha)
// {
//     Console.WriteLine(i);
// }


// Console.WriteLine($"removendo o elemento: {pilha.Pop()}");




// foreach(int i in pilha)
// {
//     Console.WriteLine(i);
// }




















// Queue<int> fila = new Queue<int>();


// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(12);
// foreach(int i in fila)
// {
//     Console.WriteLine(i);
// }


// fila.Dequeue();

// foreach(int i in fila)
// {
//     Console.WriteLine(i);
// }



//new ExemploException().Metodo1();






























// try
// {
    
//     string[] linhas = File.ReadAllLines("Arquivos/ArquivoPraLer.txt");
//     foreach (string i in linhas)
//     {
//     Console.WriteLine(i);
//     }

// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"nn achei as tal das pasta e pa \n{ex.Message}\narruma ai  ");
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"nn achei o tal do arquivo e pa \n{ex.Message}\narruma ai  ");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"o man deu isso aq  {ex.Message}\narruma ai  ");
// }
// finally
// {
//     Console.WriteLine("oiii");
// }














// string data = "10/04/2024 06:32";

// bool sucesso = DateTime.TryParseExact(data, "dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConvertida );



// if (sucesso)
// {
//     Console.WriteLine($"deu certo man {dataConvertida}");
// }
// else{
//     Console.WriteLine("deu ruim geral");
// }












// //DateTime data = DateTime.Now;

// DateTime data = DateTime.Parse("17/04/2023");

// Console.WriteLine(data.ToString("dd/MM/yyyy hh:mm"));

// Console.WriteLine(data.ToShortDateString());












// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");



// decimal valorMonetario = 82.40M;

// Console.WriteLine($"{valorMonetario:C}");

// double porcentagem = .3244;

// Console.WriteLine(porcentagem.ToString("P"));


// int numero = 11231351;

// Console.WriteLine(numero.ToString("###-###-##"));










// Pessoa p1 = new Pessoa("bobo", "bibi");


// Pessoa p2 = new Pessoa("bibi", "bobo");


// Curso CursoDeSerSilly = new Curso();

// CursoDeSerSilly.NomeCurso = "Silly 101";
// CursoDeSerSilly.Alunos = new List<Pessoa>();
// CursoDeSerSilly.AdicionarAluno(p1);
// CursoDeSerSilly.AdicionarAluno(p2);
// CursoDeSerSilly.ListarAlunos();

// Pessoa p = new Pessoa();
// p.Nome = "doido";
// p.Idade = 10;
// p.Sobrenome = "doidinho";
// p.Apresentar();