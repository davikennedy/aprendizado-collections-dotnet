List<Mes> meses = new List<Mes>()
{
   new Mes("Janeiro     ", 31),
   new Mes("Fevereiro   ", 28),
   new Mes("Março       ", 31),
   new Mes("Abril       ", 30),
   new Mes("Maio        ", 31),
   new Mes("Junho       ", 30),
   new Mes("Julho       ", 31),
   new Mes("Agosto      ", 31),
   new Mes("Setembro    ", 30),
   new Mes("Outubro     ", 31),
   new Mes("Novembro    ", 30),
   new Mes("Dezembro    ", 31)
};

/*IEnumerable<string>
    consulta = meses
        .Where(m => m.Dias == 31)
        .OrderBy(m => m.Nome)
        .Select(m => m.Nome.ToUpper());*/

// Imprime o 1º trimestre
var consulta = meses.Take(3);
foreach (var item in consulta)
{
    Console.WriteLine(item);
}
Console.WriteLine();

// Imprime os últimos 9 meses do ano
var consulta2 = meses.Skip(3);
foreach (var item in consulta2)
{
    Console.WriteLine(item);
}
Console.WriteLine();

// Imprime o 3º trimestre
var consulta3 = meses.Skip(6).Take(3);
foreach (var item in consulta3)
{
    Console.WriteLine(item);
}
Console.WriteLine();

// Imprime os meses até que o nome do mês inicie com a letra 'S'
var consulta4 = meses.TakeWhile(mes => !mes.Nome.StartsWith("S"));
foreach (var item in consulta4)
{
    Console.WriteLine(item);
}
Console.WriteLine();

// Pular os meses até que o nome do mês inicie com a letra 'S'
var consulta5 = meses.SkipWhile(mes => !mes.Nome.StartsWith("S"));
foreach (var item in consulta5)
{
    Console.WriteLine(item);
}
Console.WriteLine();

public class Mes
{
    public string Nome { get; private set; }
    public int Dias { get; private set; }

    public Mes(string nome, int dias)
    {
        Nome = nome;
        Dias = dias;
    }

    public override string ToString()
    {
        return $"{Nome} - {Dias}";
    }
}