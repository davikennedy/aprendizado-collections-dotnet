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

static void Imprimir(List<string> aulas)
{
    /*foreach (var aula in aulas)
    {
        Console.WriteLine(aula);
    }*/

    aulas.ForEach(aula => Console.WriteLine(aula));
    Console.WriteLine($"A primeira aula é: {aulas.First()}");
    Console.WriteLine($"A última aula é: {aulas.Last()}");
}