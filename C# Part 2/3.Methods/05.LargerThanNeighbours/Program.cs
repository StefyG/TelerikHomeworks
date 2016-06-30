using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LargerThanNeighbours
{
    class Program
    {
        static void LargerThanNeighbours(int[] arr)
        {
            int count = 0;
            for (int j = 1; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j - 1] && arr[j] > arr[j + 1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            string number = Console.ReadLine();
            string[] array = number.Split(' ');

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(array[i]);
            }

            LargerThanNeighbours(numbers);
        }
    }
}
