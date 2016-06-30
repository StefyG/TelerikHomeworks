using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetLargestNumber
{
    class Program
    {
        static void GetMax(int[] arr)
        {
            int max = arr.Max();
            Console.WriteLine(max);
        }

        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] number = numbers.Split();
            int[] finalArr = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                finalArr[i] = int.Parse(number[i]);
            }

            GetMax(finalArr);
        }
    }
}
