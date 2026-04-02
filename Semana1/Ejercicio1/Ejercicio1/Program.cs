//El precio de los productos no tiene incluido el incremento del 15%
//que representa la ganancia del negocio, por lo tanto,
//el algoritmo debe calcular el precio final a abonar por un cliente.
//Se ingresa el precio del producto y como resultado muestra el precio de venta.

using System;

namespace Ejercicio1
{
    class Program
    {
        const double INCREMENTO = 0.15;

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el precio del producto: ");

            double precioProducto = Convert.ToDouble(Console.ReadLine());

            double precioFinal = precioProducto + (precioProducto * INCREMENTO);

            Console.WriteLine("El precio final a abonar por el cliente es: " + precioFinal);

            // --- Agregue esta linea porque la consola luego de ingresar el precio se cerraba sola ---
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
       

    }
}