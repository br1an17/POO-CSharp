using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBiblioteca
{
    internal class Biblioteca
    {
        private readonly List<Libro> libros;
        private readonly List<Lector> lectores;
        public Biblioteca()
        {
            libros = [];
            lectores = [];
        }
        private Libro? BuscarLibro(string titulo)
        {
            Libro? libroBuscado = null;
            int i = 0;
            while (i < libros.Count && !libros[i].GetTitulo().Equals(titulo))
                i++;
            if (i != libros.Count)
                libroBuscado = libros[i];
            return libroBuscado;
        }
        public bool AgregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;
            Libro? libro;
            libro = BuscarLibro(titulo);
            if (libro == null)
            {
                libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                resultado = true;
            }
            return resultado;
        }
        public void ListarLibros()
        {
            foreach (var libro in libros)
                Console.WriteLine(libro);
        }
        public bool EliminarLibro(string titulo)
        {
            bool resultado = false;
            Libro? libro;
            libro = BuscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                resultado = true;
            }
            return resultado;
        }
        private Lector? BuscarLector(int dni)
        {
            Lector? lectorBuscado = null;
            int i = 0;
            while (i < lectores.Count && !lectores[i].GetDni().Equals(dni))
                i++;
            if (i != lectores.Count)
                lectorBuscado = lectores[i];
            return lectorBuscado;
        }
        public bool AltaLector(string nombre, int dni)
        {
            bool resultado = false;
            Lector? lector;
            lector = BuscarLector(dni);
            if (lector == null)
            {
                lector = new Lector(nombre, dni);
                lectores.Add(lector);
                resultado = true;
            }
            return resultado;
        }
        public string PrestarLibro(string titulo, int dni)
        {

            Lector? lector = BuscarLector(dni);
            if (lector == null)
            {
                return "LECTOR INEXISTENTE";
            }
            if (lector.GetPrestamos().Count >= 3)
            {
                return "TOPE DE PRESTAMOS ALCANZADO";
            }

            Libro? libro = BuscarLibro(titulo);
            if (libro == null)
            {
                return "LIBRO INEXISTENTE";
            }
            libros.Remove(libro);
            lector.GetPrestamos().Add(libro);

            return "PRESTAMO EXITOSO";

        }

    
    }
}
