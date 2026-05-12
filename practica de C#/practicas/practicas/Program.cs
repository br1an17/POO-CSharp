using System;
//Crea un programa en C# para calcular la superficie y el volumen de una esfera, dado su radio.
namespace Practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.1416;
            Console.WriteLine("ingrece el radio de un circulo");
            float radio = Convert.ToSingle(Console.ReadLine( ));

            double superficie = 4 * pi * (radio * radio);

            double volumen = (4 / 3) * pi * (radio * radio * radio);
            Console.WriteLine("la superficie de la esfera es: " + superficie);
            Console.WriteLine("el volumen de la esfera es: " + volumen);

        }
    }
}

