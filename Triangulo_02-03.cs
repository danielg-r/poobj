using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo3
{
    class Triangulo3
    {
        static void Main()
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese c°, z:");
            double cGrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            //Deg -> Rad
            double cRadianes = cGrados * (Math.PI / 180);

            //Cálculo de los valores
            double y = z / Math.Tan(cRadianes);                     //Hallamos y: y=z/tan(c)
            double t = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2));  //Pitágoras t^2 = y^2 + z^2
            double aRadianes = Math.PI - (Math.PI / 2) - cRadianes; //Hallamos a en radianes con 180-90-c
            double aGrados = aRadianes * (180 / Math.PI);           //Conversión a grados

            //Imprimir datos
            Console.WriteLine("a° = " + aGrados + "°");
            Console.WriteLine("y = " + y);
            Console.WriteLine("t = " + t);
        }
    }
}
