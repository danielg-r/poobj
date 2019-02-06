using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Simulacro
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = aleatorio.Next(1, 7);
            int dado2 = aleatorio.Next(1, 7);
            int dado3 = 0;
            int dado4 = 0;
            int turno = 1;
            int puntos = 0;
            bool gameOver = false;
            int dobles = 0;

            Console.WriteLine("Su objetivo es sumar 100 puntos.");

            Console.WriteLine("*** TURNO " + turno + " ***");
            Console.WriteLine("Lanzando dados...");
            Console.WriteLine("Dado 1: " + dado1);
            Console.WriteLine("Dado 2: " + dado2);
            puntos += dado1;
            puntos += dado2;
            Console.WriteLine("Puntos: " + puntos);

            while (puntos < 100 && gameOver != true)
            {
                Console.WriteLine("¿Lanzar los dados? (Y) ¿O retirarse? (N)");
                string respuesta = Console.ReadLine();

                if (respuesta == "Y")
                {
                    dado3 = aleatorio.Next(1, 7);
                    dado4 = aleatorio.Next(1, 7);
                    turno += 1;
                    Console.WriteLine("*** TURNO " + turno + " ***");
                    Console.WriteLine("Lanzando dados...");
                    Console.WriteLine("Dado 1: " + dado3);
                    Console.WriteLine("Dado 2: " + dado4);
                    puntos += dado3;
                    puntos += dado4;
                    Console.WriteLine("Puntos: " + puntos);

                    if (dado3 == dado4)
                    {
                        dobles += 1;
                        if (dobles >= 3)
                        {
                            gameOver = true;
                            Console.WriteLine("Ha ganado el juego por 3 dobles consecutivos.");
                        }
                    }

                    else
                    {
                        dobles = 0;
                    }

                    if (dado3 == 1 && dado4 == 1)
                    {
                        gameOver = true;
                    }
                }
                else if (respuesta == "N")
                {
                    Console.WriteLine("Usted se ha retirado del juego.");
                    Console.WriteLine("Puntaje final: " + puntos);
                }
                else
                {
                    Console.WriteLine("Entrada no válida.");
                }
            }
            if (puntos >= 100)
            {
                Console.WriteLine("Usted ha ganado el juego.");
            }
        }
    }
}
