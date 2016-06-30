using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculate3
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger factorial1 = 1;
            BigInteger factorial2 = 1;

            for (int i = K + 1; i <= N; i++)
            {
                factorial1 *= i;
            }
            for (int j = 1; j <= N - K; j++)
            {
                factorial2 *= j;
            }
            Console.WriteLine(factorial1 / factorial2);


        }
    }
}
