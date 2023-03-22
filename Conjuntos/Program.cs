/* Propriedades dos Sets:
 * Sets não permitem duplicidade
 * Os elementos não são mantidos em ordem específica
 */

using ListaSomenteLeitura;

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