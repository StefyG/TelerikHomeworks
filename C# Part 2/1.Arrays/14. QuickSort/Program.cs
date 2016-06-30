using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int min;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < arr.Length; j++)
            {
                for (int k = j + 1; k < arr.Length; k++)
                {
                    if (arr[j] < arr[k])
                    {
                        min = arr[j];
                    }
                    else
                    {
                        min = arr[k];
                        arr[k] = arr[j];
                        arr[j] = min;
                    }
                }
            }

            for (int p = 0; p < arr.Length; p++)
            {
                Console.WriteLine(arr[p]);
            }
        }
    }
}
