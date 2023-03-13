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

// Localizando índice de uma string, dentro de um array
Console.WriteLine($"Aula 'Modelando' está no índice: {Array.IndexOf(aulas, aulaModelando)}");

// Métodos de cópia de arrays
string[] copia = new string[2];
Array.Copy(aulas, 1, copia, 0, 2);
Imprimir(copia);

string[] clone = aulas.Clone() as string[];
Imprimir(clone);