using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese votos del partido A.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese votos del partido B.");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese votos en blanco.");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese votos anulados.");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese población de todas las edades.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese porcentaje de población mayor de edad.");
            int p = int.Parse(Console.ReadLine());
            
            int mayores = ((n * p) / 100);

            bool cond1 = (a + b + blancos + anulados) > n;
            bool cond2 = (a - b) < (((a + b + blancos + anulados) * 10) / 100);
            bool cond3 = (a + b + blancos + anulados) < ((n * 30) / 100);

            Console.WriteLine("Votos:");
            Console.WriteLine("a: " + a + " b: " + b + " Blancos: " + blancos + " Anulados: " + anulados);
            Console.WriteLine("Población total: " + n + " Mayores de edad: " + p + "%");
            Console.WriteLine("Total votantes: " + (a + b + blancos + anulados));
            Console.WriteLine("Población mayor de edad: " + mayores);


            if ((cond1 || cond2) && (cond3))
            {
                Console.WriteLine("Las elecciones deben repetirse.");
            }
            else
            {
                if (a < b)
                {
                    Console.WriteLine("El ganador es el partido B.");
                }
                else
                {
                    Console.WriteLine("El ganador es el partido A.");
                }
            }
        }
    }
}
