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
//Generar un video grupal de 10 minutos máximo,
//con cámaras activas, donde cada integrante explique parte del desarrollo
//y funcionamiento del proyecto. Por cuestiones de espacio en la plataforma,
//pueden enviar un link al video, como recomendación pueden subirlo a Youtube,
//sino puede ser un enlace a Drive, pero cerciórense de asignar el permiso de
//visualización correspondiente y no deben borrarlo hasta tener aprobada la materia.
//No dejen para entregar a último momento porque la plataforma puede fallar,
//se aconseja enviarlo un día antes como mínimo.

using System;
using System.Collections.Generic;

namespace Biblioteca;

public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Editorial { get; set; }

    public Libro(string titulo, string autor, string editorial)
    {
        this.Titulo = titulo;
        this.Autor = autor;
        this.Editorial = editorial;
    }
}
public class Lector
{
    public string Nombre { get; set; }
    public int Dni { get; set; }
    public List<Libro> LibrosPrestados { get; set; }

    public Lector(string nombre, int dni)
    {
        Nombre = nombre;
        Dni = dni;
        LibrosPrestados = [];
    }
}



