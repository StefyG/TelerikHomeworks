using System;

namespace ExchangeNumbers
{
    class Program
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double temp;

            if (A > B)
            {
                temp = A;
                A = B;
                B = temp;
                Console.WriteLine("{0} {1}", A, B);
            }
            else
            {
                Console.WriteLine("{0} {1}", A, B);
            }
        }
    }
}