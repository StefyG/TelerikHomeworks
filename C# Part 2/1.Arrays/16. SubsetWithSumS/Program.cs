using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.SubsetWithSumS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 1, 2, 4, 3, 5, 2, 6 };
            int s = 14;
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int number = arr[i];
                sum += number;
                for (int j = i+1; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (s < sum)
                    {
                        break;
                    }
                    else if (s == sum)
                    {
                        Console.WriteLine("yes");
                    }                    
                }
                sum = 0;
            }
        }
    }
}
