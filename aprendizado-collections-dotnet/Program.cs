// Lidando com arrays

string aulaIntro = "Introdução às Coleções";
string aulaModelando = "Modelando a classe Aula";
string aulaSets = "Trabalhando com conjuntos";

string[] aulas = new string[3];
aulas[0] = aulaIntro;
aulas[1] = aulaModelando;
aulas[2] = aulaSets;

Imprimir(aulas);

static void Imprimir(string[] aulas)
{
    foreach (var aula in aulas)
    {
        Console.WriteLine(aula);
    }
}