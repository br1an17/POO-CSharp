//Se trata de implementar un programa que sume los dígitos de un número
//entero no negativo de 4 dígitos. Por ejemplo, la suma de los dígitos del 3433 es 13.
//Para darle un poco más de emoción, el programa no se limitará a escribir
//el resultado de la suma, sino que también escribirá todos los sumandos utilizados: 3 + 4 + 3 + 3 = 13.


using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número de 4 dígitos:");
            string valor = Console.ReadLine(); 

            int suma = 0;
            string textoSuma = "";

            if (valor.Length == 4 )
            {
                for (int i = 0; i < 4; i++)
                {

                    int digito = Convert.ToInt32(valor.Substring(i, 1));


                    suma = suma + digito;


                    if (i < 3)
                    {
                        textoSuma = textoSuma + digito + " + ";
                    }
                    else
                    {
                        textoSuma = textoSuma + digito;
                    }
                }
                Console.WriteLine($"La suma de los digitos {textoSuma} es = {suma}");
            }
            else
            {
                Console.WriteLine("numero incorrecto");

            }

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
