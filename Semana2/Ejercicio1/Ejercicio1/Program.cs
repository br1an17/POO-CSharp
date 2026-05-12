//Escribir la clase Test que contenga el método main()
//para probar el correcto funcionamiento de la clase previamente realizada con el siguiente ejemplo:
//superHeroe1: Nombre: “Batman”, Fuerza: 90, Resistencia: 70, Superpoderes: 0
//superHeroe2: Nombre: “Superman”, Fuerza: 95, Resistencia: 60, Superpoderes: 70

//Hacer jugar al superheroe1 pasándole el objeto superheroe2 y mostrar el resultado por pantalla. 
//Chequear el resultado (debería ser DERROTA).
//Hacer jugar al superheroe2 contra el superheroe1 y mostrar el resultado por pantalla. 
//Chequear el resultado (debería ser TRIUNFO).
//Crear más superhéroes con distintos valores y ... ¡¡A jugar!!

using System;

namespace Ejercicio1
{



    public class SuperHeroe
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Resistencia { get; set; }
        public int Superpoderes { get; set; }

        public SuperHeroe(string nombre, int fuerza, int resistencia, int superpoderes)
        {
            this.Nombre = nombre;
            this.Fuerza = fuerza;
            this.Resistencia = resistencia;
            this.Superpoderes = superpoderes;
        }
        public string Luchar(SuperHeroe rival, string opcion)
        {

            int miPoder = 0;
            int rivalPoder = 0;

            switch (opcion)
            {
                case "1":
                    miPoder = this.Fuerza;
                    rivalPoder = rival.Fuerza;
                    break;
                case "2":
                    miPoder = this.Resistencia;
                    rivalPoder = rival.Resistencia;
                    break;
                case "3":
                    miPoder = this.Superpoderes;
                    rivalPoder = rival.Superpoderes;
                    break;
                default:
                    Console.WriteLine("Esa opción no existe. Se eligió Fuerza por defecto.");
                    miPoder = this.Fuerza;
                    rivalPoder = rival.Fuerza;
                    break;

            }
            if (miPoder > rivalPoder)
                {
                    return "TRIUNFO";
                }
                else if (rivalPoder > miPoder)
                {
                    return "DERROTA";
                }
                else
                {
                    return "EMPATE";
                }


        }

    }

    public class Test
    {
        public static void Main(string[] args)
        {
            SuperHeroe heroe1 = new SuperHeroe("Batman", 90, 70, 0);
            SuperHeroe heroe2 = new SuperHeroe("Superman", 95, 60, 70);

            Console.WriteLine("¡Es el turno de Batman! Elegí tu atributo de ataque:");
            Console.WriteLine("1 - Fuerza");
            Console.WriteLine("2 - Resistencia");
            Console.WriteLine("3 - Superpoderes");

            string opcion = Console.ReadLine();

            string resultado = heroe1.Luchar(heroe2, opcion);

            Console.WriteLine($"El resultado del combate es: {resultado}");

            Console.WriteLine("\n¡Es el turno de Superman! Elegí tu atributo de ataque:");
            Console.WriteLine("1 - Fuerza");
            Console.WriteLine("2 - Resistencia");
            Console.WriteLine("3 - Superpoderes");

            string opcion2 = Console.ReadLine();

            string resultado2 = heroe2.Luchar(heroe1, opcion2);

            Console.WriteLine($"El resultado del combate es: {resultado2}");

            Console.WriteLine("\nPresione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}