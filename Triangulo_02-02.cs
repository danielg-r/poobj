using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Triangulo2
    {
        static void Main()
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese t, a°:");
            double t = double.Parse(Console.ReadLine());
            double aGrados = double.Parse(Console.ReadLine());

            //Deg -> Rad
            double aRadianes = aGrados * (Math.PI / 180);

            //Cálculo de los valores
            double cRadianes = Math.PI - (Math.PI / 2) - aRadianes; //Hallamos c en radianes con 180-90-a
            double cGrados = cRadianes * (180 / Math.PI);           //Conversión a grados
            double z = t * Math.Sin(cRadianes);                     //Hallamos z: z=t*sin(c)
            double y = z / Math.Tan(cRadianes);                     //Hallamos y: y=z/tan(c)

            //Imprimir datos
            Console.WriteLine("c° = " + cGrados + "°");
            Console.WriteLine("Y = "+y);
            Console.WriteLine("Z = "+z);
        }
    }
}
