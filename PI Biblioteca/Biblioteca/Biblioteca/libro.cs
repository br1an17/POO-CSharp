using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBiblioteca
{
    public class Libro(string titulo, string autor, string editorial)
    {
        public string Titulo { get; set; } = titulo;
        public string Autor { get; set; } = autor;
        public string Editorial { get; set; } = editorial;

        public string GetTitulo()
        {
            return Titulo;
        }
        public override string ToString()
        {
            return $"Título: {Titulo} | Autor: {Autor} | Editorial: {Editorial}";
        }
    }
}
