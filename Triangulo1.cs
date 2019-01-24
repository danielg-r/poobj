using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    class Triangulo1
    {
        static void Main()
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese y, z:");
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            //Cálculo de los valores
            double t = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2));  //Pitágoras t^2 = y^2 + z^2
            double cRadianes = Math.Asin(z / t);                    //Seno inverso para obtener c en radianes
            double cGrados = cRadianes * (180 / Math.PI);           //Conversión a grados
            double aRadianes = Math.PI - (Math.PI / 2) - cRadianes; //Hallamos a en radianes con 180-90-c
            double aGrados = aRadianes * (180 / Math.PI);           //Conversión a grados

            //Imprimir datos
            //Console.WriteLine("C en radianes = " + cRadianes);
            Console.WriteLine("c° = " + cGrados+"°");
            Console.WriteLine("a° = " + aGrados + "°");
            Console.WriteLine("t = " + t);

        }
    }
}
