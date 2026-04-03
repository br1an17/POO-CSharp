//Resolver la consiga del punto 4 con la particularidad que el número puede
//tener cualquier cantidad de dígitos, es decir,
//puede ser un número de dos dígitos como un número de 6 dígitos.
//Tomá la codificación anterior e introducí los cambios que sean necesarios.

using system;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            string valor = Console.ReadLine();

            int suma = 0;
            string textoSuma = "";

            while (!int.TryParse(valor, out _))
            {
                Console.WriteLine("El valor ingresado no es un número. Por favor, ingrese un número");
                valor = Console.ReadLine();
            }


            for (int i = 0; i < valor.Length; i++)
            {

                int digito = Convert.ToInt32(valor.Substring(i, 1));


                suma = suma + digito;


                if (i < valor.Length - 1)
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
    }
}
