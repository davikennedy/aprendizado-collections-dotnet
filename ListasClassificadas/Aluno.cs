namespace ListasClassificadas;

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

    public override bool Equals(object? obj)
    {
        Aluno outro = obj as Aluno;
        return Nome.Equals(outro.Nome);
    }

    public override int GetHashCode()
    {
        return Nome.GetHashCode();
    }
}
