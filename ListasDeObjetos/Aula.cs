using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeObjetos
{
    public class Aula : IComparable
    {
        public string Titulo { get; set; }        
        public int Tempo { get; set; }

        public Aula(string titulo, int tempo)
        {
            Titulo = titulo;
            Tempo = tempo;
        }
        public int CompareTo(object obj)
        {
            Aula other = obj as Aula;
            return Titulo.CompareTo(other.Titulo);
        }

        public override string ToString()
        {
            return $"[Título: {Titulo}, Tempo: {Tempo} minutos]";
        }
    }
}
