/* Propriedades dos Sets:
 * Sets não permitem duplicidade
 * Os elementos não são mantidos em ordem específica
 */

ISet<string> alunos = new HashSet<string>();
alunos.Add("Vanessa Tonini");
alunos.Add("Ana Losnak");
alunos.Add("Rafael Nercessian");

Console.WriteLine(String.Join(", ", alunos));