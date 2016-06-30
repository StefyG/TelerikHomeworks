using System;

namespace Circle
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * r * Math.PI;
            double area = r * r * Math.PI;

            Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
        }
    }
}
