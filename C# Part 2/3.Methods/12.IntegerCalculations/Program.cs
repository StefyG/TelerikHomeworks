using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.IntegerCalculations
{
    class Program
    {
        static void CalculateMin(int[] arr)
        {
            int min = arr.Min();
            Console.WriteLine(min);
        }
        static void CalculateMax(int[] arr)
        {
            int max = arr.Max();
            Console.WriteLine(max);
        }
        static void CalculateAverage(int[] arr)
        {
            int sum = 0;
            double avg;
            for (int j = 0; j < arr.Length; j++)
            {
                sum += arr[j];
            }
            avg = sum / 5.0;
            Console.WriteLine("{0:F2}", avg);
        }
        static void CalculateSum(int[] arr)
        {
            int sum = 0;

            for (int j = 0; j < arr.Length; j++)
            {
                sum += arr[j];
            }
            Console.WriteLine(sum);
        }
        static void CalculateProduct(int[] arr)
        {
            BigInteger product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            Console.WriteLine(product);
        }

        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string[] array = number.Split(' ');
            int[] numbers = new int[array.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(array[i]);
            }

            CalculateMin(numbers);
            CalculateMax(numbers);
            CalculateAverage(numbers);
            CalculateSum(numbers);
            CalculateProduct(numbers);
        }
    }
}
