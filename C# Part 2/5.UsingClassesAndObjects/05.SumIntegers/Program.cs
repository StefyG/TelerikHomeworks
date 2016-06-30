using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] numbersArr = numbers.Split(' ');
            int[] array = new int[numbersArr.Length];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(numbersArr[i]);
                sum += array[i];
            }

            Console.WriteLine(sum);
        }
    }
}
