using System;

namespace OddOrEven
{
    class Program
    {
        static void Main()
        {
            int a;

            bool IsEven = int.TryParse(Console.ReadLine(), out a);
            if (a % 2 == 0)
            {

                Console.WriteLine("even {0}", a);
            }
            else
            {
                Console.WriteLine("odd {0}", a);
            }
        }
    }
}