﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSomenteLeitura;

public class Curso
{
    private IList<Aula> aulas;
    public IList<Aula> Aulas
    {
        get { return new ReadOnlyCollection<Aula>(aulas); }
    }
    public string Nome { get; set; }
    public string Instrutor { get; set; }
    public int TempoTotal => Aulas.Sum(aula => aula.Tempo);

    public Curso(string nome, string instrutor)
    {
        Nome = nome;
        Instrutor = instrutor;
        aulas = new List<Aula>();
    }

    internal void Adicionar(Aula aula)
    {
        aulas.Add(aula);
    }

    public override string ToString()
    {
        Console.Clear();
        return $"Curso: {Nome} \nTempo: {TempoTotal} minutos \nAulas:\n\t{String.Join(",\n\t", Aulas)}";
    }
}