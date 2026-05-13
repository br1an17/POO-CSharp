using System;
using System.Linq.Expressions;
//Escribe un programa en C# que calcule el resultado
//de sumar, restar, multiplicar y dividir dos números introducidos por el usuario.

//Además también debería calcular el resto de la división en la última linea.


namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            Calculadora miCalc = new Calculadora();

            Console.WriteLine("el resultado de la cuenta es " + miCalc.calculo(num1, num2));

        }
        class Calculadora
        {

            public int sumar(int a, int b)
            {
                return a + b;
            }
            public int restar(int a, int b)
            {
                return a - b;
            }
            public int multiplicar(int a, int b)
            {
                return a * b;
            }
            public int dividir(int a, int b)
            {
                double resultado = a / b;
                return Convert.ToInt32(resultado);
            }

             public double calculo(int a, int b)
            {

                int valor = 0;

                Console.WriteLine("elije el claculo");

                Console.WriteLine("1 = suma, 2 = resta, 3 = multiplicacion, 4 = dividir");
                valor =Convert.ToInt32(Console.ReadLine());

                switch (valor)
                {
                    case 1:
                        return sumar(a, b);
                    case 2:
                        return restar(a, b);
                    case 3:
                        return multiplicar(a, b);
                    case 4:
                        return dividir(a, b);
                    default:
                        Console.WriteLine("valor no valido");
                        return 0;

                }

            }

        }
    }




}
