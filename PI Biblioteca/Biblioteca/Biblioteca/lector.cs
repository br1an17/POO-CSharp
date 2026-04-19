using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBiblioteca
{

    public class Lector(string nombre, int dni)
    {
        public string Nombre { get; set; } = nombre;
        public int Dni { get; set; } = dni;
        public List<Libro> LibrosPrestados { get; set; } = [];
        public int GetDni()
        {
            return Dni;
        }
        public List<Libro> GetPrestamos()
        {
            return LibrosPrestados;
        }

        public override string ToString()
        {
            return "DNI: " + Dni + " Nombre: " + Nombre;
        }
    }
}
