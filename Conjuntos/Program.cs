/* Propriedades dos Sets:
 * Sets não permitem duplicidade
 * Os elementos não são mantidos em ordem específica
 */
using Conjuntos;

ISet<string> alunos = new HashSet<string>();
alunos.Add("Vanessa Tonini");
alunos.Add("Ana Losnak");
alunos.Add("Rafael Nercessian");
alunos.Add("Marcos Aurélio");
alunos.Add("Paulo Júnior");
alunos.Add("João Gomes");
Console.WriteLine(String.Join(", ", alunos));

var alunosEmLista = new List<string>(alunos);
alunosEmLista.Sort();
Console.WriteLine(String.Join(", ", alunosEmLista));

var cSharpColecoes = new Curso("C# Coleções", "Marcelo Oliveira");
cSharpColecoes.Adicionar(new Aula("Trabalhando com listas", 21));
cSharpColecoes.Adicionar(new Aula("Criando uma Aula", 20));
cSharpColecoes.Adicionar(new Aula("Modelando com coleções", 24));

Aluno a1 = new Aluno("Rafael Gonçalves", 24534);
Aluno a2 = new Aluno("João Gomes", 35145);
Aluno a3 = new Aluno("Késia Amaral", 92356);

cSharpColecoes.Matricular(a1);
cSharpColecoes.Matricular(a2);
cSharpColecoes.Matricular(a3);

Console.WriteLine("Imprimindo alunos matriculados:\n");
foreach (var aluno in cSharpColecoes.Alunos)
{
    Console.WriteLine(aluno);
}

Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");
Console.WriteLine(cSharpColecoes.EstaMatriculado(a1));

var alunoMatriculado = cSharpColecoes.BuscarMatriculado(5117);
Console.WriteLine(alunoMatriculado);