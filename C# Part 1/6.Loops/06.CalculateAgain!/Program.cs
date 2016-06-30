using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAgain
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            decimal factorial = 1;

            for (int i = K + 1; i <= N; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
