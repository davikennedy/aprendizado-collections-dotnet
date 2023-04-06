﻿string[,] resultados = new string[4, 3]
{
    { "Alemanha", "Espanha", "Itália" },
    { "Argentina", "Holanda", "França" },
    { "Holanda", "Alemanha", "Alemanha" },
    { "Brasil", "Uruguai", "Portugal" }
};

for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++)
{
    int ano = 2014 - copa * 4;
    Console.Write(ano.ToString().PadRight(12));
}

Console.WriteLine();

for (int posicao = 0; posicao <= resultados.GetUpperBound(0); posicao++)
{
    for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++)
    {
        Console.Write(resultados[posicao, copa].PadRight(12));
    }

    Console.WriteLine();
}