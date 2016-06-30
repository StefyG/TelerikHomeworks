using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SortingArray
{
    class Program
    {
        static void SortArray(int[] arr)
        {
            Array.Sort(arr);
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == arr[arr.Length - 1])
                {
                    Console.Write("{0}", arr[j]);
                }
                else
                {
                    Console.Write("{0} ", arr[j]);
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numbers = Console.ReadLine();
            string[] array = numbers.Split(' ');
            int[] numberArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                numberArray[i] = int.Parse(array[i]);
            }

            SortArray(numberArray);
        }
    }
}
