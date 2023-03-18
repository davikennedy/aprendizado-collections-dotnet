using ListaSomenteLeitura;

Curso cSharpColecoes = new Curso("C# Collections", "Marcelo");
cSharpColecoes.Adicionar(new Aula("Trabalhando com Listas", 21));

Imprimir(cSharpColecoes.Aulas);

static void Imprimir(IList<Aula> aulas)
{
    Console.Clear();
    //aulas.ForEach(aula => Console.WriteLine(aula));

    foreach(var aula in aulas) 
        Console.WriteLine(aula);
}