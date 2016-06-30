﻿using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);

            if (D > 0)
            {
                if (x1 < x2)
                {
                    Console.WriteLine("{0:F2}", x1);
                    Console.WriteLine("{0:F2}", x2);
                }
                else
                {
                    Console.WriteLine("{0:F2}", x2);
                    Console.WriteLine("{0:F2}", x1);
                }
            }
            else if (D == 0)
            {
                Console.WriteLine("{0:F2}", x1);
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
