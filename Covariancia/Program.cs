IList<string> listaMeses = new List<string>
{
    "Janeiro", 
    "Fevereiro", 
    "Março", 
    "Abril", 
    "Maio", 
    "Junho",
    "Julho", 
    "Agosto", 
    "Setembro",
    "Outubro", 
    "Novembro", 
    "Dezembro"
};

IEnumerable<object> enumObj  = listaMeses; // Covariância

foreach (var item in enumObj)
{
    Console.WriteLine(item);
}