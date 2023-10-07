using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploringC_.models
{
    public class Curso
    {
        public string NomeCurso { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno (Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public bool RemoverAluno (Pessoa aluno){
            return Alunos.Remove(aluno);
            
        }

       public int ObterQuantidadeDeAlunosMatriculados()
       {
        int quantidade = Alunos.Count;
        return quantidade;
       }

       public void ListarAlunos(){
        foreach (Pessoa i in Alunos)
        {
            Console.WriteLine(i.NomeComplete);
        }
       }


    }
}