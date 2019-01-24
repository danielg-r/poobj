using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___CuotaModeradora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso datos
            Console.WriteLine("Ingrese su salario completo:");
            double salario = double.Parse(Console.ReadLine());
            double smmlv = salario / 828116;

            //Cálculo datos

            if (smmlv < 2)
            {
                Console.WriteLine("Su tarifa es A.");
                Console.WriteLine("Su cuota moderadora es $3,200.");
            }
            if (2 <= smmlv && smmlv < 5)
            {
                Console.WriteLine("Su tarifa es B.");
                Console.WriteLine("Su cuota moderadora es $12,700.");
            }
            if (smmlv >= 5)
            {
                Console.WriteLine("Su tarifa es C.");
                Console.WriteLine("Su cuota moderadora es $33,500.");
            }

            //Imprimir datos extra 
            Console.WriteLine("Su salario en SMMLV es: " + smmlv);
        }
    }
}
