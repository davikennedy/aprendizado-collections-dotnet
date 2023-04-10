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

/*meses.Sort();

foreach (var mes in meses)
{
    if (mes.Dias != 31) continue; 
    Console.WriteLine(mes.Nome.ToUpper());
}*/

IEnumerable<string>
    consulta = meses
        .Where(m => m.Dias == 31)
        .OrderBy(m => m.Nome)
        .Select(m => m.Nome.ToUpper());

foreach (var item in consulta)
{
    Console.WriteLine(item);
}

public class Mes //: IComparable
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
    
    /*public int CompareTo(object? obj)
    {
        Mes? outro = obj as Mes;
        return Nome.CompareTo(outro.Nome);
    }*/
}