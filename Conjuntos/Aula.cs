namespace Conjuntos;

public class Aula : IComparable
{
    public Aula(string titulo, int tempo)
    {
        Titulo = titulo;
        Tempo = tempo;
    }

    public string Titulo { get; set; }        
    public int Tempo { get; set; }

    public int CompareTo(object obj)
    {
        Aula other = obj as Aula;
        return Titulo.CompareTo(other.Titulo);
    }

    public override string ToString()
    {
        return $"[Título: {Titulo}, Tempo: {Tempo} minutos]";
    }
}
