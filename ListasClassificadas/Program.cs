using ListasClassificadas;

IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();

alunos.Add("WM", new Aluno("Wanderson", 11287));
alunos.Add("VT", new Aluno("Vanessa", 34672));
alunos.Add("AL", new Aluno("Ana", 56171));
alunos.Add("RN", new Aluno("Rafael", 143763));

foreach (var aluno in alunos)
{
    Console.WriteLine(aluno);
}

IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();

sorted.Add("WM", new Aluno("Wanderson", 11287));
sorted.Add("VT", new Aluno("Vanessa", 34672));
sorted.Add("AL", new Aluno("Ana", 56171));
sorted.Add("RN", new Aluno("Rafael", 143763));

Console.WriteLine();
foreach (var item in sorted)
{
    Console.WriteLine(item);
}