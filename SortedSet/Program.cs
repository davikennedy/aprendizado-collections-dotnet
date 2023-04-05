ISet<string> alunos = new SortedSet<string>(new CompararNomesIguais())
{
    "Vanessa Tonini",
    "Ana Losnak",
    "Rafael Nercessian",
    "Priscila Stuani"
};

alunos.Add("Rafael Rollo");
alunos.Add("Fabio Gushiken");
alunos.Add("Fabio Gushiken");

foreach (var aluno in alunos)
{
    Console.WriteLine(aluno);
}

internal class CompararNomesIguais : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        return string.Compare(x, y, StringComparison.CurrentCultureIgnoreCase);
    }
}