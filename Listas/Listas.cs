string aulaIntro = "Introdução às Coleções";
string aulaModelando = "Modelando a classe Aula";
string aulaSets = "Trabalhando com conjuntos";

/*List<string> aulas = new List<string>
{
    aulaIntro,
    aulaModelando,
    aulaSets
};*/

List<string> aulas = new List<string>();

aulas.Add(aulaIntro);
aulas.Add(aulaModelando);
aulas.Add(aulaSets);

Imprimir(aulas);
Console.WriteLine($"A primeira aula é: {aulas.First()}");
Console.WriteLine($"A última aula é: {aulas.Last()}");

aulas[0] = "Trabalhando com listas";
Console.WriteLine("A primeira aula que contém 'Trabalhando' é: "
    + aulas.First(aula => aula.Contains("Trabalhando")));

Console.WriteLine("A última aula que contém 'Trabalhando' é: "
    + aulas.Last(aula => aula.Contains("Trabalhando")));

Console.WriteLine("A primeira aula que contém 'Conclusão' é: "
    + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

// Obtendo os dois últimos elementos da lista
List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
Imprimir(copia);

List<string> clone = new List<string>(aulas);

static void Imprimir(List<string> aulas)
{
    /*foreach (var aula in aulas)
    {
        Console.WriteLine(aula);
    }*/

    aulas.ForEach(aula => Console.WriteLine(aula));    
}