using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AppearanceCount
{
    class Program
    {
        static void Count(int[] arr, int a)
        {
            int count = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == a)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            string numbers = Console.ReadLine();
            string[] array = numbers.Split();

            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(array[i]);
            }

            int x = int.Parse(Console.ReadLine());

            Count(number, x);
        }
    }
}
