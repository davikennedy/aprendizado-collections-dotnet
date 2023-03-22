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
        public int numeroMatricula { get; set; }

        public Aluno(string nome, int numeroMatricula)
        {
            Nome = nome;
            this.numeroMatricula = numeroMatricula;
        }
    }
}
