Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");
estados.Add("GO", "Goiás");

foreach (var estado in estados)
{
    Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
}

estados.Add("BA2", "Bahia");