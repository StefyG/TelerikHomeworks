using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.NFactorial
{
    class Program
    {
        static void Factorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Factorial(number);
        }
    }
}
