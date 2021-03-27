using System;

namespace A133590.Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 10");
            Console.WriteLine("Dada una frase por el usuario, el programa presenta la misma frase en minúscula.");
            Console.Write("Por favor, ingrese una frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine(frase.ToLowerInvariant());
            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
