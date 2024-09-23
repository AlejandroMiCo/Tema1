#define FactorialOPintar

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
#if FactorialOPintar

            Factorial(ref num);
            Console.WriteLine(num);
#else
            PintarPantalla();
#endif

            Console.ReadKey();
        }

        public static bool Factorial(ref int factorial)
        {
            if (factorial < 0 || factorial > 10)
            {
                return false;
            }

          

            for (int valorini = factorial - 1; valorini >= 1; valorini--)
            {
                factorial = factorial * valorini;
            }

            return true;
        }

        public static void PintarPantalla(int numAsteriscos = 10)
        {
            Random rnd = new Random();

            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < numAsteriscos; i++)
            {
                Console.SetCursorPosition(rnd.Next(1, 21), rnd.Next(1, 11));

                Console.WriteLine("*");
            }
        }
    }
}
