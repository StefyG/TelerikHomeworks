using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriangleSurfaceByTwoSidesAndAnAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            double sin = Math.Sin(angle * (Math.PI / 180));
            double surface = (sideA * sideB * sin) / 2;
            Console.WriteLine("{0:F2}", surface);

        }
    }
}
