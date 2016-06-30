using System;

namespace MMSAOfNNumbers
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double number;
            double sum = 0;
            double max = Double.MinValue;
            double min = Double.MaxValue;
            double avg = 0;

            for (int i = 1; i <= N; i++)
            {
                number = double.Parse(Console.ReadLine());
                sum += number;
                avg = sum / N;
                if (min > number)
                {
                    min = number;
                }
                if (max < number)
                {
                    max = number;
                }

            }
            Console.WriteLine("min={0:F2} \r\nmax={1:F2} \r\nsum={2:F2} \r\navg={3:F2}", min, max, sum, avg);
        }
    }
}
