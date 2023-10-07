using exploringC_.models;


Pessoa p1 = new Pessoa("bobo", "bibi");


Pessoa p2 = new Pessoa("bibi", "bobo");


Curso CursoDeSerSilly = new Curso();

CursoDeSerSilly.NomeCurso = "Silly 101";
CursoDeSerSilly.Alunos = new List<Pessoa>();
CursoDeSerSilly.AdicionarAluno(p1);
CursoDeSerSilly.AdicionarAluno(p2);
CursoDeSerSilly.ListarAlunos();

// Pessoa p = new Pessoa();
// p.Nome = "doido";
// p.Idade = 10;
// p.Sobrenome = "doidinho";
// p.Apresentar();