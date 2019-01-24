using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCondicionales
{
    class Program
    {
        static void Main()
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese a, b, c.");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            //Cálculo b^2 - 4ac
            double discriminante = Math.Pow(b, 2) - 4 * (a * c);

            //Salida
            if (discriminante == 0)
            {
                double x0 = - b / (2 * a);
                Console.WriteLine("Sólo existe una solución.");
                Console.WriteLine("X = " + x0);
            }
            if (discriminante > 0)
            {
                double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * (a * c))) / 2 * a;
                double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * (a * c))) / 2 * a;
                Console.WriteLine("Existen dos soluciones.");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else
            {
                Console.WriteLine("No existe ninguna solución");
            }

        }
    }
}
