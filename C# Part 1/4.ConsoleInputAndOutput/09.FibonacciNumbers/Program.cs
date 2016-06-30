using System;


namespace FibonacciNumbers
{
    class Program
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong a = 0;
            ulong b = 1;
            ulong c;

            for (ulong i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    Console.WriteLine("{0}", a);
                }
                else
                {
                    Console.Write("{0}, ", a);
                    c = a + b;
                    a = b;
                    b = c;
                }
            }
        }
    }
}