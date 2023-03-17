using ListasDeObjetos;

var aulaIntro = new Aula("3 - Introdução às Coleções", 20);
var aulaModelando = new Aula("5 - Modelando a classe Aula", 18);
var aulaSets = new Aula("2 - Trabalhando com conjuntos", 16);

List<Aula> aulas = new()
{
    aulaIntro,
    aulaModelando,
    aulaSets
};

Imprimir(aulas);

aulas.Sort();
Imprimir(aulas);

aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
Imprimir(aulas);

static void Imprimir(List<Aula> aulas)
{
    Console.Clear();

    foreach(var aula in aulas) 
        Console.WriteLine(aula);
}