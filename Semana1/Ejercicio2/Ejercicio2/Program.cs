//En el campeonato estudiantil llegan a la última etapa los participantes que superen los 80 puntos.
//El algoritmo pide el nombre de cada participante y la puntuación de los 3 jurados.
//Debe mostrar el nombre y el puntaje total de cada participante.
//Nota: cuando se ingrese "FIN" en el nombre del participante finaliza nuestro programa.


using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int jur1, jur2, jur3, punTotal;

            Console.WriteLine("Ingrese el nombre del participante: ");
            nombre = Console.ReadLine();

            while (nombre.ToUpper() != "FIN")
            {

                Console.WriteLine("puntaje del primer jurado 1:");
                jur1 = int.Parse(Console.ReadLine());

                Console.WriteLine("puntaje del primer jurado 2:");
                jur2 = int.Parse(Console.ReadLine());

                Console.WriteLine("puntaje del primer jurado 3:");
                jur3 = int.Parse(Console.ReadLine());

                punTotal = jur1 + jur2 + jur3;
                Console.WriteLine($"el puntaje del participante  {nombre} es: {punTotal}");

                if (punTotal > 80)
                {
                    Console.WriteLine(" Clasifica a la siguiente etapa");
                }
                else
                {
                    Console.WriteLine(" No clasifica");
                }

                Console.WriteLine("\nIngrese el nombre del siguiente participante (o FIN para terminar): ");
                nombre = Console.ReadLine();


            }
            Console.WriteLine("Programa finalizado");


        }
    }
}