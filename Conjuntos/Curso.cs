using System.Collections.ObjectModel;

namespace Conjuntos;

public class Curso
{
    private ISet<Aluno> alunos = new HashSet<Aluno>();
    public IList<Aluno> Alunos 
    {
        get { return new ReadOnlyCollection<Aluno>(alunos.ToList()); }
    }
    
    private IList<Aula> aulas;
    
    public IList<Aula> Aulas
    {
        get { return new ReadOnlyCollection<Aula>(aulas); }
    }
    public string Nome { get; set; }
    public string Instrutor { get; set; }
    public int TempoTotal => Aulas.Sum(aula => aula.Tempo);

    public Curso(string nome, string instrutor)
    {
        Nome = nome;
        Instrutor = instrutor;
        aulas = new List<Aula>();
    }

    public void Adicionar(Aula aula)
    {
        aulas.Add(aula);
    }

    public override string ToString()
    {
        Console.Clear();
        return $"Curso: {Nome} \nTempo: {TempoTotal} minutos \nAulas:\n\t{String.Join(",\n\t", Aulas)}";
    }

    public void Matricular(Aluno aluno)
    {
        alunos.Add(aluno);
    }
}
