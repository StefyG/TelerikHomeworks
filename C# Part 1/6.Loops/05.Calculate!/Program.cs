using System;


namespace Calculate
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            decimal factorial = 1;
            decimal sum = 1;

            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
                sum += factorial / ((decimal)Math.Pow(x, i));
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}