using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___CalculoTarifa
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
            if (smmlv <= 2)
            {
                Console.WriteLine("Su tarifa es A.");
            }
            if (2 < smmlv && smmlv < 4)
            {
                Console.WriteLine("Su tarifa es B.");
            }
            if (smmlv > 4)
            {
                Console.WriteLine("Su tarifa es C.");
            }


            //Imprimir datos
            Console.WriteLine("Su salario en SMMLV es: " + smmlv);
        }
    }
}
