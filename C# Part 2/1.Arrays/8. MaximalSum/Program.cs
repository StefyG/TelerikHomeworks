using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int maxSum = 0;
            int sum = 0;
            int count = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());

            //    sum += arr[i];
            //    count++;
            //    if (maxSum < sum)
            //    {
            //        maxSum = sum;
            //    }
            //    else //maxSum>sum
            //    {
            //        sum -= arr[i - count + 1];
            //        maxSum = sum;
            //        count--;
            //    }
            //}
            //Console.WriteLine(maxSum);

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < arr.Length; j++)
            {
                int number = arr[j];
                sum = number;
                for (int k = j + 1; k < arr.Length; k++)
                {
                    sum += arr[k];
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
