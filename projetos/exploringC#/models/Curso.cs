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
        for(int i = 0; i < Alunos.Count();i++)
        {
            string texto = $"Numero {i+1} - {Alunos[i].NomeComplete}";
            Console.WriteLine(texto);
            //Console.WriteLine(Alunos[i].NomeComplete);
        }
       }


    }
}