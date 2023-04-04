using SortedDictionary;

IDictionary<string, Aluno> sorted = new SortedDictionary<string, Aluno>();

sorted.Add("WM", new Aluno("Wanderson", 11287));
sorted.Add("VT", new Aluno("Vanessa", 34672));
sorted.Add("AL", new Aluno("Ana", 56171));
sorted.Add("RN", new Aluno("Rafael", 143763));

Console.WriteLine();

foreach (var item in sorted)
{
    Console.WriteLine(item);
}