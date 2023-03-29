LinkedList<string> dias = new LinkedList<string>();

var d4 = dias.AddFirst("Quarta-Feira");
var d2 = dias.AddBefore(d4, "Segunda-Feira");
var d3 = dias.AddAfter(d2, "Terça-Feira");
var d1 = dias.AddBefore(d2, "Domingo");
var d7 = dias.AddLast("Sábado");
var d5 = dias.AddBefore(d7, "Quinta-Feira");
var d6 = dias.AddAfter(d5, "Sexta-Feira");

foreach(var dia in dias)
{
    Console.WriteLine(dia);
}