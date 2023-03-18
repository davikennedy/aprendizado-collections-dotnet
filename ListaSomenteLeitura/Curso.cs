using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSomenteLeitura;

public class Curso
{
    private IList<Aula> aulas;
    public IList<Aula> Aulas
    {
        get { return new ReadOnlyCollection<Aula>(aulas); }
    }
    public string Nome { get; set; }
    public string Instrutor { get; set; }

    public Curso(string nome, string instrutor)
    {
        Nome = nome;
        Instrutor = instrutor;
        aulas = new List<Aula>();
    }

    internal void Adicionar(Aula aula)
    {
        aulas.Add(aula);
    }
}
