var navegador = new Navegador();

navegador.NavegarPara("google.com");
navegador.NavegarPara("caelum.com.br");
navegador.NavegarPara("alura.com.br");

navegador.VoltarPagina();
navegador.VoltarPagina();
navegador.VoltarPagina();

navegador.AvancarPagina();

internal class Navegador
{
    private readonly Stack<string> historicoAnterior = new Stack<string>();
    private readonly Stack<string> historicoProximo = new Stack<string>();

    private string atual = "vazia";
    private string proxima = "vazia";

    public Navegador()
    {
        Console.WriteLine($"Página atual: {atual}");
    }

    internal void NavegarPara(string url)
    {
        historicoAnterior.Push(atual);        
        atual = url;

        Console.WriteLine($"Página atual: {atual}");
    }

    internal void VoltarPagina()
    {
        if (historicoAnterior.Any())
        {
            historicoProximo.Push(atual);
            atual = historicoAnterior.Pop();            

            Console.WriteLine($"Página atual: {atual}");
        }        
    }
    internal void AvancarPagina()
    {
        if (historicoProximo.Any())
        {
            historicoAnterior.Push(atual);
            atual = historicoProximo.Pop();

            Console.WriteLine($"Página atual: {atual}");
        }
    }
}