
internal class Program
{
    static Queue<string> pedagio = new Queue<string>();
    private static void Main(string[] args)
    {
        Enfileirar("van");
        Enfileirar("kombi");
        Enfileirar("guincho");

        Desenfileirar();
        Desenfileirar();
        Desenfileirar();
        Desenfileirar();
    }

    private static void Enfileirar(string veiculo)
    {
        Console.WriteLine($"Entrou na fila: {veiculo}");
        pedagio.Enqueue(veiculo);
        ImprimirFila();
    }
    private static void Desenfileirar()
    {
        if (pedagio.Any())
        {
            var veiculo = pedagio.Dequeue();
            Console.WriteLine($"Saiu da fila: {veiculo}");
            ImprimirFila();
        }        
    }

    private static void ImprimirFila()
    {
        Console.WriteLine("Fila:");

        foreach (var v in pedagio)
        {
            Console.WriteLine(v);
        }
    }
}