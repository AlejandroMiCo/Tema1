using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program //TODO control rangos en dados, quiniela alineada
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Seleccione una opción del menú");
                Console.WriteLine("Opción 1 Tirar Dado");
                Console.WriteLine("Opción 2 Adivina el número");
                Console.WriteLine("Opción 3 Quiniela");
                Console.WriteLine("Opción 4 Jugar a todo");
                Console.WriteLine("Opción 5 Salir");

                opcion = Convert.ToInt32(Console.ReadLine());
                Random random = new Random();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Juego numero 1 Tirar dado\n");
                        int numApostado;
                        int numCaras;
                        int cont = 0;
                        int valorDado;
                        do
                        {
                            Console.WriteLine("Por favor introduzca el número de caras del dado:");
                            numCaras = Convert.ToInt32(Console.ReadLine());
                            if (numCaras < 2)
                            {
                                Console.WriteLine(
                                    "Por favor introduzca un numero de caras mayor a 1"
                                );
                            }
                        } while (numCaras < 2);

                        do
                        {
                            Console.WriteLine("Por favor indique el número que quieres acertar: ");
                            numApostado = Convert.ToInt32(Console.ReadLine());

                            if (numApostado < 1 || numApostado > numCaras)
                            {
                                Console.WriteLine(
                                    "Recuerde que el numero que vaya a acertar debe ser mayor a 0 y menor o igual al numero maximo de caras"
                                );
                            }
                        } while (numApostado < 1 || numApostado > numCaras);

                        for (int i = 0; i < 10; i++)
                        {
                            valorDado = random.Next(1, numCaras + 1);
                            Console.WriteLine($"El dado ha sido {valorDado}");

                            if (valorDado == numApostado)
                            {
                                cont++;
                            }
                        }

                        Console.WriteLine($"Usted a acertado {cont} veces");
                        Console.ReadKey();

                        if (opcion == 4)
                        {
                            goto case 2;
                        }

                        Console.WriteLine("Desea volver a jugar? s/n");
                        if (Convert.ToChar(Console.ReadLine()) == 's')
                        {
                            goto case 1;
                        }

                        break;

                    case 2:
                        Console.WriteLine("Juego numero 2 Adivina el número\n");

                        int numRandom = random.Next(1, 101);
                        Console.WriteLine(numRandom);
                        int numIntentos = 5;
                        bool adivinar = false;

                        do
                        {
                            Console.WriteLine("\nQue numero desea jugar?");
                            int numElegido = Convert.ToInt32(Console.ReadLine());

                            if (numElegido < 1 || numElegido > 100)
                            {
                                Console.WriteLine("Por favor introduzca un numero entre 1 y 100");
                            }
                            else
                            {
                                if (numElegido > numRandom)
                                {
                                    Console.WriteLine("Su numero es mayor al numero deseado");
                                    numIntentos--;
                                    Console.WriteLine($"Le quedan {numIntentos} intentos");
                                }
                                if (numElegido < numRandom)
                                {
                                    Console.WriteLine("Su numero es menor al numero deseado");
                                    numIntentos--;
                                    Console.WriteLine($"Le quedan {numIntentos} intentos");
                                }

                                if (numElegido == numRandom)
                                {
                                    Console.WriteLine("Enhorabuena, has acertado!!");
                                    adivinar = true;
                                }

                                if (numIntentos == 0)
                                {
                                    Console.WriteLine(
                                        "Lo siento, has perdido, te has quedado sin intentos"
                                    );
                                    Console.WriteLine($"El numero a adivinar era {numRandom}");
                                }
                            }
                        } while (numIntentos > 0 && !adivinar);

                        if (opcion == 4)
                        {
                            goto case 3;
                        }

                        Console.WriteLine("Desea volver a jugar? s/n");
                        if (Convert.ToChar(Console.ReadLine()) == 's')
                        {
                            goto case 2;
                        }

                        break;

                    case 3:
                        Console.WriteLine("Juego numero 3 Quiniela\n");

                        for (int i = 0; i < 14; i++)
                        {
                            Console.WriteLine(
                                $"El resultado del la fila {i + 1, 3} es {QuinielaGenerator(random.Next(1, 101))}"
                            );
                        }

                        Console.WriteLine("Desea volver a jugar? s/n");
                        if (opcion == 3)
                        {
                            if (Console.ReadLine()[0] == 's')
                            {
                                goto case 3;
                            }
                        }
                        break;

                    case 4:
                        goto case 1;
                    default:
                        break;
                }
            } while (opcion != 5);
        }

        public static char QuinielaGenerator(int random)
        {
            switch (random)
            {
                case int x when x <= 60:
                    return '1';
                case int x when x >= 61 && x <= 85:
                    return 'x';
                case int x when x >= 85 && x <= 100:
                    return '2';
                default:
                    return 'e';
            }
        }
    }
}
