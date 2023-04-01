using ListaSomenteLeitura;

Curso cSharpColecoes = new Curso("C# Collections", "Marcelo");

cSharpColecoes.Adicionar(new Aula("Trabalhando com Listas", 21));
Imprimir(cSharpColecoes.Aulas);

cSharpColecoes.Adicionar(new Aula("Criando uma Aula", 20));
cSharpColecoes.Adicionar(new Aula("Modelando com Coleções", 19));
Imprimir(cSharpColecoes.Aulas);

// Ordenando aulas
var aulasCopiadas = new List<Aula>(cSharpColecoes.Aulas);
aulasCopiadas.Sort();
Imprimir(aulasCopiadas);

// Totalizando tempo do curso
Console.WriteLine($"\nTempo total do curso: {cSharpColecoes.TempoTotal} minutos.");

// Obtendo descrição do Curso
Console.WriteLine(cSharpColecoes);

static void Imprimir(IList<Aula> aulas)
{
    Console.Clear();

    foreach(var aula in aulas)
    {
        Console.WriteLine(aula);
    }        
}