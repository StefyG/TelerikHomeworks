using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger factorial2n = 1;
            BigInteger factorialN = 1;
            BigInteger factorialN1 = 1;
            BigInteger result;
            for (int i = 1; i <= N; i++)
            {
                factorialN *= i;
            }
            for (int j = 1; j <= 2 * N; j++)
            {
                factorial2n *= j;
            }
            for (int k = 1; k <= N + 1; k++)
            {
                factorialN1 *= k;
            }

            result = factorial2n / (factorialN * factorialN1);
            Console.WriteLine(result);
        }
    }
}