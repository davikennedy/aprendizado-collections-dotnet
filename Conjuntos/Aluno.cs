using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }

        public Aluno(string nome, int numeroMatricula)
        {
            Nome = nome;
            Matricula = numeroMatricula;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nMatrícula: {Matricula}\n";
        }
    }
}
