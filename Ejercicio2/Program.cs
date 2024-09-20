#define Frase
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor introduzca dos frases, la primera:");
            string frase1 = Console.ReadLine();
            Console.WriteLine("Ahora la segunda:");
            string frase2 = Console.ReadLine();

#if Frase

            Console.WriteLine($"\"{frase1}\"\t\\{frase2}\\");

#else
            Console.WriteLine($"{frase1}\t{frase2}\n{frase1}\n{frase2}");

#endif
            Console.ReadKey();
        }
    }
}
