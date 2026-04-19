//Desarrollar el método altaLector que pasándole los parámetros necesarios
//de el alta a un lector dentro de la lista de lectores
//si es que no se encontraba previamente registrado.
//Desarrollar el método prestarLibro de la clase Biblioteca la cual recibe
//por parámetro el título de un libro y el dni del lector que lo solicita
//y retorna un string con los posibles valores:
//"PRESTAMO EXITOSO"(en este caso el libro se le pudo prestar al lector,
//se lo quitó de la lista de libros que dispone la biblioteca y se lo adjudicó al lector).
//"LIBRO INEXISTENTE"(cuando el libro no se encuentra dentro
//de la colección de libros en la biblioteca)
//"TOPE DE PRESTAMO ALCAZADO"
//(cuando el lector ya posee tres libros en préstamo).
//"LECTOR INEXISTENTE"(cuando el lector no es se encuentra registrado
//dentro de la colección de lectores en la biblioteca).


using System.Collections.Generic;
using System;
using ProgramaBiblioteca;


using System;

namespace ProgramaBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Biblioteca miBiblioteca = new ();

            miBiblioteca.AgregarLibro("El Aleph", "Jorge Luis Borges", "Debolsillo");
            miBiblioteca.AgregarLibro("Cien años de soledad", "Gabriel García Márquez", "Sudamericana");
            miBiblioteca.AgregarLibro("C# Moderno", "Microsoft Press", "Tecno");
            miBiblioteca.AgregarLibro("Clean Code", "Robert C. Martin", "Prentice Hall");



            static void MenuLector(Biblioteca miBiblioteca)
            {
                Console.WriteLine("=== MODO LECTOR ===");

                Console.Write("Ingrese su DNI: ");
                int dni = int.Parse(Console.ReadLine());

                Console.WriteLine("1 - Ver libros");
                Console.WriteLine("2 - Pedir préstamo");

                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.WriteLine("--- Libros en la biblioteca ---");
                    miBiblioteca.ListarLibros();
                }
                else if (opcion == "2")
                {
                    Console.Write("Título del libro: ");
                    string titulo = Console.ReadLine();

                    string resultado = miBiblioteca.PrestarLibro(titulo, dni);
                    Console.WriteLine(resultado);
                }
            }
            static void MenuBibliotecario(Biblioteca miBiblioteca)
            {
                Console.WriteLine("=== MODO BIBLIOTECARIO ===");

                Console.WriteLine("1 - Agregar libro");
                Console.WriteLine("2 - Eliminar libro");
               

                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.Write("Título: ");
                    string titulo = Console.ReadLine();

                    Console.Write("Autor: ");
                    string autor = Console.ReadLine();

                    Console.Write("Editorial: ");
                    string editorial = Console.ReadLine();

                    bool ok = miBiblioteca.AgregarLibro(titulo, autor, editorial);

                    Console.WriteLine(ok ? "Libro agregado" : "El libro ya existe");
                }
                else if (opcion == "2")
                {
                    Console.Write("Título a eliminar: ");
                    string titulo = Console.ReadLine();

                    bool ok = miBiblioteca.EliminarLibro(titulo);

                    Console.WriteLine(ok ? "Libro eliminado" : "No existe el libro");
                }
            }

            Console.WriteLine("=== SISTEMA BIBLIOTECA ===");
            Console.WriteLine("1 - Lector");
            Console.WriteLine("2 - Bibliotecario");

            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                MenuLector(miBiblioteca);
            }
            else if (opcion == "2")
            {
                MenuBibliotecario(miBiblioteca);
            }
            else
            {
                Console.WriteLine("Opción inválida");
            }



            Console.WriteLine("--- Libros en la biblioteca ---");
            miBiblioteca.ListarLibros();

       
            miBiblioteca.AltaLector("Brian Paez", 12345678);

            Console.WriteLine("\n--- Probando Préstamos ---");


            string res1 = miBiblioteca.PrestarLibro("El Aleph", 12345678);
            Console.WriteLine($"Intento 1 (El Aleph): {res1}");

           
            string res2 = miBiblioteca.PrestarLibro("Harry Potter", 12345678);
            Console.WriteLine($"Intento 2 (Harry Potter): {res2}");

          
            string res3 = miBiblioteca.PrestarLibro("C# Moderno", 99999999);
            Console.WriteLine($"Intento 3 (DNI falso): {res3}");

          
            miBiblioteca.PrestarLibro("Cien años de soledad", 12345678);
            miBiblioteca.PrestarLibro("C# Moderno", 12345678);

            string res4 = miBiblioteca.PrestarLibro("Clean Code", 12345678);
            Console.WriteLine($"Intento 4 (Cuarto libro): {res4}");

            Console.WriteLine("\n--- Estado Final de Libros en Biblioteca ---");
            miBiblioteca.ListarLibros();

            Console.WriteLine("\nPresione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}





