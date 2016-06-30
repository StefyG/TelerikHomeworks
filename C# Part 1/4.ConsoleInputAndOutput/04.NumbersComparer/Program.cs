using System;


namespace NumberComparer
{
    class Program
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            var result = A > B ? A : B;
            Console.WriteLine(result);
        }
    }
}