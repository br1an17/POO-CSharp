
//Tres personas aportan diferente capital a una sociedad y desean saber el valor
//total aportado y qué porcentaje aportó cada una (indicando nombre y porcentaje).
//Para ello, solicitar la carga por teclado del nombre de cada socio,
//su capital aportado y a partir de esto calcular e informar lo requerido previamente .
namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] socios = new string[3];
            double[] capital = new double[3];
            double capitalTotal = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el nombre del socio " + (i+1));
                socios[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el aporte de " + socios[i]);
                string capitalIngresado = Console.ReadLine();
                while (!double.TryParse(capitalIngresado, out capital[i]))
                {
                    Console.WriteLine("Valor incorrecto, ingrese el aporte correspondiente");
                    capitalIngresado = Console.ReadLine();
                }
                
                capitalTotal += capital[i];

            }

            Console.WriteLine("el total aportado es de: " + capitalTotal);

            for (int i = 0; i < socios.Length; i++)
            {
                double porcentaje = ( capital[i] / capitalTotal) * 100;
                Console.WriteLine($"El porcentaje aportado por {socios[i]} es de {porcentaje:F0} %");


            }
        }

    }
}